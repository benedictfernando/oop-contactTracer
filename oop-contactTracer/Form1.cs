using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_contactTracer
{
    public partial class tracer : Form
    {
        public tracer()
        {
            InitializeComponent();
        }

        private void clock_Tick(object sender, EventArgs e)
        {
            date.Value = DateTime.Now;
            time.Text = DateTime.Now.ToShortTimeString();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            var emptyFields = new List<string>();

            foreach (var ctrl in this.innerTable.Controls)
            {
                if (ctrl is TextBox)
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
                else if (ctrl is TableLayoutPanel)
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

            if (!male.Checked && !female.Checked) emptyFields.Add("Gender");

            if (emptyFields == null || !emptyFields.Any()) processData();
            else
            {
                string list = ""; emptyFields.Sort();
                foreach (var item in emptyFields) list += "\n" + "- " + item;
                MessageBox.Show("Please fill out all form fields:" + list,
                    "Submission Incomplete", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
            }
        }

        private void processData()
        {
            string dateTime = DateTime.Now.ToString(),
                temp = this.temp.Text,
                fullName = $"{last.Text}, {first.Text} {middle.Text}",
                completeAddress = $"{house.Text} " +
                    $"{street.Text} {barangay.Text}, {city.Text}",
                contacts = mobile.Text,
                gender, health = "";

            if (male.Checked) gender = "Male"; else gender = "Female";

            foreach (var checkbox in innerTable.Controls.OfType<CheckBox>())
            {
                if (checkbox.Checked)
                {
                    if (health == "") health = $"Has {checkbox.Name}";
                    else health += $", has {checkbox.Name}";
                }
            }

            // append to text file

            if (MessageBox.Show($"Your form has successfully pushed through"
                + $", {first.Text}~ much thanks!\n\nWant to submit again?",
                "Submission Complete", MessageBoxButtons.YesNo,
                MessageBoxIcon.Asterisk) == DialogResult.Yes)
                    clearAll(innerTable); else Application.Exit();
        }

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
