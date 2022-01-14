using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;    // For handling & manipulating files

namespace oop_contactTracer
{
    public partial class tracer : Form
    {
        public tracer()
        {
            InitializeComponent();
        }

        // Set date & time controls up in real-time
        private void clock_Tick(object sender, EventArgs e)
        {
            date.Value = DateTime.Now;
            time.Text = DateTime.Now.ToShortTimeString();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            var emptyFields = new List<string>();

            // Recursively check for any empty fields present on submit
            foreach (var ctrl in this.innerTable.Controls)
            {
                if (ctrl is TextBox)    // For textboxes
                {
                    var tb = ctrl as TextBox;
                    if (string.IsNullOrEmpty(tb.Text.Trim()))
                    {
                        if (tb.Name == "temp")
                            emptyFields.Add("Temperature");
                        else if (tb.Name == "mobile")
                            emptyFields.Add("Phone Number");
                    }
                }
                else if (ctrl is TableLayoutPanel)  // For table panel layouts
                {
                    var tlp = ctrl as TableLayoutPanel;

                    if (tlp.Name == "addressTable")
                    {
                        var addressINC = false;
                        foreach (var textbox in tlp.Controls.OfType<TextBox>())
                        {
                            if (string.IsNullOrEmpty(textbox.Text.Trim()))
                            {
                                addressINC = true; break;
                            }
                        }
                        if (addressINC) emptyFields.Add("Complete Address");
                    }
                    else if (tlp.Name == "infoTable")
                    {
                        var infoINC = false;
                        foreach (var textbox in tlp.Controls.OfType<TextBox>())
                        {
                            if (textbox.Name != "middle" && 
                                string.IsNullOrEmpty(textbox.Text.Trim()))
                            {
                                infoINC = true; break;
                            }
                        }
                        if (infoINC) emptyFields.Add("Full Name");
                    }
                }
            }

            // For radio buttons, 'gender' fields in particular
            if (!male.Checked && !female.Checked) emptyFields.Add("Gender");

            // Determine path depending on number of items in 'emptyFields'
            if (emptyFields == null || !emptyFields.Any()) processData();
            else
            {
                string list = ""; emptyFields.Sort();
                foreach (var item in emptyFields) list += "\n" + "- " + item;

                // Show all empty fields in a message box 
                MessageBox.Show("Please fill out all form fields:" + list,
                    "Submission Incomplete", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
            }
        }

        // Process data if all fields are filled up
        private void processData()
        {
            string dateTime = DateTime.Now.ToString(),
                    temp = this.temp.Text + " \x00B0C",
                fullName = $"{last.Text}, {first.Text} {middle.Text}",
                completeAddress = $"{house.Text} " +
                    $"{street.Text} {barangay.Text}, {city.Text}",
                contacts = mobile.Text, gender, health = "";

            foreach (var checkbox in innerTable.Controls.OfType<CheckBox>())
            {
                if (checkbox.Checked)
                {
                    if (health == "") health = $"Has {checkbox.Name}";
                    else health += $", has {checkbox.Name}";
                }
            }

            if (health == "") health = "No COVID-like symptoms";
            if (male.Checked) gender = "Male"; else gender = "Female";

            // Execute database entry based on initialized fields above
            databaseEnter(new List<string>() {
                dateTime, temp, fullName, gender,
                completeAddress, health, contacts
            }); clearAll(innerTable);   // Clear all fields

            // Determine between form resubmission or application exit
            if (MessageBox.Show($"Your form has successfully pushed through"
                + $", {first.Text}~ much thanks!\n\nWant to submit again?",
                "Submission Complete", MessageBoxButtons.YesNo,
                MessageBoxIcon.Asterisk) == DialogResult.No) Application.Exit();
        }

        // Enter entries to database
        private void databaseEnter(List<string> entries)
        {
            // Initialize database file & its directory
            string username = "Benedict Fernando";
            string database = $@"C:\Users\{username}\Downloads\CTDatabase.txt";
            // Note: 'username' & 'database' can be changed depending on target

            string enter = "";
            foreach (var entry in entries) enter += entry + "\n";

            if (File.Exists(database))  // If database specified above is found
            {
                using var file = new StreamWriter(database, append: true);
                file.NewLine = "\n"; file.WriteLine(enter);   // Append to file
            }
            else File.WriteAllText(database, enter + "\n"); // Else, create new
        }

        // Clear all fields recursively
        private void clearAll(Control table)
        {
            foreach (var control in table.Controls)
            {
                if (control is TextBox)
                    (control as TextBox).Text = string.Empty;
                else if (control is RadioButton)
                    (control as RadioButton).Checked = false;
                else if (control is CheckBox)
                    (control as CheckBox).Checked = false;
                else if (control is TableLayoutPanel)
                    clearAll(control as TableLayoutPanel);
            }
        }
        
        // Warn user before application closing
        private void appClosing(object sender, FormClosingEventArgs e)
        {
            var msg = "Thank you for using C#'s Contact Tracer~ keep safe!";
            if (MessageBox.Show("Are you really sure to exit?",
                "Exit Program", MessageBoxButtons.YesNo,
                MessageBoxIcon.Stop) == DialogResult.Yes)
                    MessageBox.Show(msg); else e.Cancel = true;
        }
    }
}
