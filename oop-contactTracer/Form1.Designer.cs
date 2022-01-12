namespace oop_contactTracer
{
    partial class tracer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tracer));
            this.outerTable = new System.Windows.Forms.TableLayoutPanel();
            this.innerTable = new System.Windows.Forms.TableLayoutPanel();
            this.headingTable = new System.Windows.Forms.TableLayoutPanel();
            this.heading = new System.Windows.Forms.Label();
            this.note = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.temp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addressTable = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.house = new System.Windows.Forms.TextBox();
            this.street = new System.Windows.Forms.TextBox();
            this.barangay = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.mobile = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.fever = new System.Windows.Forms.CheckBox();
            this.colds = new System.Windows.Forms.CheckBox();
            this.cough = new System.Windows.Forms.CheckBox();
            this.infoTable = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.first = new System.Windows.Forms.TextBox();
            this.last = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.middle = new System.Windows.Forms.TextBox();
            this.male = new System.Windows.Forms.RadioButton();
            this.female = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.dataLabel = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.checkLabel = new System.Windows.Forms.Label();
            this.detailsLabel = new System.Windows.Forms.Label();
            this.clock = new System.Windows.Forms.Timer(this.components);
            this.outerTable.SuspendLayout();
            this.innerTable.SuspendLayout();
            this.headingTable.SuspendLayout();
            this.addressTable.SuspendLayout();
            this.infoTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // outerTable
            // 
            this.outerTable.ColumnCount = 3;
            this.outerTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.outerTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.outerTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.outerTable.Controls.Add(this.innerTable, 1, 1);
            this.outerTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outerTable.Location = new System.Drawing.Point(0, 0);
            this.outerTable.Name = "outerTable";
            this.outerTable.RowCount = 3;
            this.outerTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.outerTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.outerTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.outerTable.Size = new System.Drawing.Size(780, 457);
            this.outerTable.TabIndex = 0;
            // 
            // innerTable
            // 
            this.innerTable.BackColor = System.Drawing.SystemColors.Control;
            this.innerTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.innerTable.ColumnCount = 4;
            this.innerTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.innerTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.innerTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.innerTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.innerTable.Controls.Add(this.headingTable, 0, 0);
            this.innerTable.Controls.Add(this.time, 3, 0);
            this.innerTable.Controls.Add(this.date, 1, 2);
            this.innerTable.Controls.Add(this.temp, 2, 2);
            this.innerTable.Controls.Add(this.label1, 1, 1);
            this.innerTable.Controls.Add(this.label2, 2, 1);
            this.innerTable.Controls.Add(this.addressTable, 1, 4);
            this.innerTable.Controls.Add(this.label12, 2, 6);
            this.innerTable.Controls.Add(this.submit, 3, 6);
            this.innerTable.Controls.Add(this.mobile, 1, 7);
            this.innerTable.Controls.Add(this.label11, 1, 6);
            this.innerTable.Controls.Add(this.fever, 1, 5);
            this.innerTable.Controls.Add(this.colds, 2, 5);
            this.innerTable.Controls.Add(this.cough, 3, 5);
            this.innerTable.Controls.Add(this.infoTable, 1, 3);
            this.innerTable.Controls.Add(this.dataLabel, 0, 1);
            this.innerTable.Controls.Add(this.infoLabel, 0, 3);
            this.innerTable.Controls.Add(this.addressLabel, 0, 4);
            this.innerTable.Controls.Add(this.checkLabel, 0, 5);
            this.innerTable.Controls.Add(this.detailsLabel, 0, 6);
            this.innerTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.innerTable.Location = new System.Drawing.Point(23, 23);
            this.innerTable.Name = "innerTable";
            this.innerTable.RowCount = 8;
            this.innerTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.innerTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.innerTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.innerTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.innerTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.innerTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.innerTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.innerTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.innerTable.Size = new System.Drawing.Size(734, 411);
            this.innerTable.TabIndex = 0;
            // 
            // headingTable
            // 
            this.headingTable.ColumnCount = 1;
            this.innerTable.SetColumnSpan(this.headingTable, 3);
            this.headingTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.headingTable.Controls.Add(this.heading, 0, 0);
            this.headingTable.Controls.Add(this.note, 0, 1);
            this.headingTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headingTable.Location = new System.Drawing.Point(3, 3);
            this.headingTable.Name = "headingTable";
            this.headingTable.RowCount = 2;
            this.headingTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.headingTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.headingTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.headingTable.Size = new System.Drawing.Size(540, 75);
            this.headingTable.TabIndex = 1;
            // 
            // heading
            // 
            this.heading.AutoSize = true;
            this.heading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.heading.Font = new System.Drawing.Font("Century Gothic", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.heading.Location = new System.Drawing.Point(3, 0);
            this.heading.Name = "heading";
            this.heading.Size = new System.Drawing.Size(534, 52);
            this.heading.TabIndex = 0;
            this.heading.Text = "Tracing Application Form";
            this.heading.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // note
            // 
            this.note.AutoSize = true;
            this.note.Dock = System.Windows.Forms.DockStyle.Fill;
            this.note.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.note.Location = new System.Drawing.Point(3, 52);
            this.note.Name = "note";
            this.note.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.note.Size = new System.Drawing.Size(534, 23);
            this.note.TabIndex = 1;
            this.note.Text = "Note: Please fill out all fields honestly. Also, kindly not forget to submit this" +
    " afterwards.";
            this.note.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.time.Dock = System.Windows.Forms.DockStyle.Fill;
            this.time.Font = new System.Drawing.Font("Century Gothic", 27F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.time.Location = new System.Drawing.Point(549, 0);
            this.time.Name = "time";
            this.innerTable.SetRowSpan(this.time, 3);
            this.time.Size = new System.Drawing.Size(178, 145);
            this.time.TabIndex = 2;
            this.time.Text = "Time";
            this.time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // date
            // 
            this.date.CalendarFont = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.date.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.date.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.date.Enabled = false;
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date.Location = new System.Drawing.Point(185, 120);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(176, 22);
            this.date.TabIndex = 5;
            this.date.Value = new System.DateTime(2022, 1, 13, 0, 38, 4, 405);
            // 
            // temp
            // 
            this.temp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.temp.Location = new System.Drawing.Point(367, 120);
            this.temp.Name = "temp";
            this.temp.PlaceholderText = "Ex: 35.6";
            this.temp.Size = new System.Drawing.Size(176, 22);
            this.temp.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(185, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Date";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(367, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Temperature (C°)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // addressTable
            // 
            this.addressTable.ColumnCount = 4;
            this.innerTable.SetColumnSpan(this.addressTable, 3);
            this.addressTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.addressTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.addressTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.addressTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.addressTable.Controls.Add(this.label10, 3, 0);
            this.addressTable.Controls.Add(this.label9, 2, 0);
            this.addressTable.Controls.Add(this.house, 0, 1);
            this.addressTable.Controls.Add(this.street, 1, 1);
            this.addressTable.Controls.Add(this.barangay, 2, 1);
            this.addressTable.Controls.Add(this.city, 3, 1);
            this.addressTable.Controls.Add(this.label7, 0, 0);
            this.addressTable.Controls.Add(this.label8, 1, 0);
            this.addressTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addressTable.Location = new System.Drawing.Point(185, 213);
            this.addressTable.Name = "addressTable";
            this.addressTable.RowCount = 2;
            this.addressTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.addressTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.addressTable.Size = new System.Drawing.Size(542, 59);
            this.addressTable.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Location = new System.Drawing.Point(381, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(158, 29);
            this.label10.TabIndex = 25;
            this.label10.Text = "City";
            this.label10.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(219, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(156, 29);
            this.label9.TabIndex = 23;
            this.label9.Text = "Subdivision / District";
            this.label9.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // house
            // 
            this.house.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.house.Location = new System.Drawing.Point(3, 34);
            this.house.Name = "house";
            this.house.PlaceholderText = "Ex: 123";
            this.house.Size = new System.Drawing.Size(48, 22);
            this.house.TabIndex = 20;
            // 
            // street
            // 
            this.street.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.street.Location = new System.Drawing.Point(57, 34);
            this.street.Name = "street";
            this.street.PlaceholderText = "Ex: 25th Street";
            this.street.Size = new System.Drawing.Size(156, 22);
            this.street.TabIndex = 22;
            // 
            // barangay
            // 
            this.barangay.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barangay.Location = new System.Drawing.Point(219, 34);
            this.barangay.Name = "barangay";
            this.barangay.PlaceholderText = "Ex: BGC";
            this.barangay.Size = new System.Drawing.Size(156, 22);
            this.barangay.TabIndex = 24;
            // 
            // city
            // 
            this.city.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.city.Location = new System.Drawing.Point(381, 34);
            this.city.Name = "city";
            this.city.PlaceholderText = "Ex: Taguig";
            this.city.Size = new System.Drawing.Size(158, 22);
            this.city.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 29);
            this.label7.TabIndex = 19;
            this.label7.Text = "No.";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(57, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 29);
            this.label8.TabIndex = 21;
            this.label8.Text = "Street";
            this.label8.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(367, 340);
            this.label12.Name = "label12";
            this.innerTable.SetRowSpan(this.label12, 2);
            this.label12.Size = new System.Drawing.Size(176, 67);
            this.label12.TabIndex = 34;
            this.label12.Text = "By submitting, you agree to allow us store and use your data for tracking purpose" +
    "s, to keep us safe in this COVID-19 pandemic.";
            // 
            // submit
            // 
            this.submit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.submit.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.submit.Location = new System.Drawing.Point(549, 343);
            this.submit.Name = "submit";
            this.innerTable.SetRowSpan(this.submit, 2);
            this.submit.Size = new System.Drawing.Size(178, 61);
            this.submit.TabIndex = 35;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // mobile
            // 
            this.mobile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mobile.Location = new System.Drawing.Point(185, 375);
            this.mobile.Name = "mobile";
            this.mobile.PlaceholderText = "Ex: 0912 345 6789";
            this.mobile.Size = new System.Drawing.Size(176, 22);
            this.mobile.TabIndex = 33;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Location = new System.Drawing.Point(185, 340);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(176, 32);
            this.label11.TabIndex = 32;
            this.label11.Text = "Phone No.";
            this.label11.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // fever
            // 
            this.fever.AutoSize = true;
            this.fever.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fever.Location = new System.Drawing.Point(185, 278);
            this.fever.Name = "fever";
            this.fever.Size = new System.Drawing.Size(176, 59);
            this.fever.TabIndex = 28;
            this.fever.Text = "Currently having fever?";
            this.fever.UseVisualStyleBackColor = true;
            // 
            // colds
            // 
            this.colds.AutoSize = true;
            this.colds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colds.Location = new System.Drawing.Point(367, 278);
            this.colds.Name = "colds";
            this.colds.Size = new System.Drawing.Size(176, 59);
            this.colds.TabIndex = 29;
            this.colds.Text = "Currently having colds?";
            this.colds.UseVisualStyleBackColor = true;
            // 
            // cough
            // 
            this.cough.AutoSize = true;
            this.cough.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cough.Location = new System.Drawing.Point(549, 278);
            this.cough.Name = "cough";
            this.cough.Size = new System.Drawing.Size(178, 59);
            this.cough.TabIndex = 30;
            this.cough.Text = "Currently having cough?";
            this.cough.UseVisualStyleBackColor = true;
            // 
            // infoTable
            // 
            this.infoTable.ColumnCount = 5;
            this.innerTable.SetColumnSpan(this.infoTable, 3);
            this.infoTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33966F));
            this.infoTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33966F));
            this.infoTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.663262F));
            this.infoTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.3288F));
            this.infoTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.32861F));
            this.infoTable.Controls.Add(this.label3, 0, 0);
            this.infoTable.Controls.Add(this.label5, 2, 0);
            this.infoTable.Controls.Add(this.first, 1, 1);
            this.infoTable.Controls.Add(this.last, 0, 1);
            this.infoTable.Controls.Add(this.label4, 1, 0);
            this.infoTable.Controls.Add(this.middle, 2, 1);
            this.infoTable.Controls.Add(this.male, 3, 1);
            this.infoTable.Controls.Add(this.female, 4, 1);
            this.infoTable.Controls.Add(this.label6, 3, 0);
            this.infoTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoTable.Location = new System.Drawing.Point(185, 148);
            this.infoTable.Name = "infoTable";
            this.infoTable.RowCount = 2;
            this.infoTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.infoTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.infoTable.Size = new System.Drawing.Size(542, 59);
            this.infoTable.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "Surname";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(363, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 29);
            this.label5.TabIndex = 13;
            this.label5.Text = "M.I.";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // first
            // 
            this.first.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.first.Location = new System.Drawing.Point(183, 34);
            this.first.Name = "first";
            this.first.PlaceholderText = "Ex: Juan";
            this.first.Size = new System.Drawing.Size(174, 22);
            this.first.TabIndex = 12;
            // 
            // last
            // 
            this.last.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.last.Location = new System.Drawing.Point(3, 34);
            this.last.Name = "last";
            this.last.PlaceholderText = "Ex: Dela Cruz";
            this.last.Size = new System.Drawing.Size(174, 22);
            this.last.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(183, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 29);
            this.label4.TabIndex = 11;
            this.label4.Text = "Given Name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // middle
            // 
            this.middle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.middle.Location = new System.Drawing.Point(363, 34);
            this.middle.Name = "middle";
            this.middle.Size = new System.Drawing.Size(30, 22);
            this.middle.TabIndex = 14;
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.male.Location = new System.Drawing.Point(399, 35);
            this.male.Name = "male";
            this.male.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.male.Size = new System.Drawing.Size(60, 21);
            this.male.TabIndex = 16;
            this.male.TabStop = true;
            this.male.Text = "Male";
            this.male.UseVisualStyleBackColor = true;
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.female.Location = new System.Drawing.Point(465, 35);
            this.female.Name = "female";
            this.female.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.female.Size = new System.Drawing.Size(74, 21);
            this.female.TabIndex = 17;
            this.female.TabStop = true;
            this.female.Text = "Female";
            this.female.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.infoTable.SetColumnSpan(this.label6, 2);
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(399, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 29);
            this.label6.TabIndex = 15;
            this.label6.Text = "Gender";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // dataLabel
            // 
            this.dataLabel.AutoSize = true;
            this.dataLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLabel.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.dataLabel.Location = new System.Drawing.Point(3, 81);
            this.dataLabel.Name = "dataLabel";
            this.dataLabel.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.innerTable.SetRowSpan(this.dataLabel, 2);
            this.dataLabel.Size = new System.Drawing.Size(176, 64);
            this.dataLabel.TabIndex = 3;
            this.dataLabel.Text = "Current Data";
            this.dataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoLabel.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.infoLabel.Location = new System.Drawing.Point(3, 145);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.infoLabel.Size = new System.Drawing.Size(176, 65);
            this.infoLabel.TabIndex = 8;
            this.infoLabel.Text = "Personal Information";
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addressLabel.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.addressLabel.Location = new System.Drawing.Point(3, 210);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.addressLabel.Size = new System.Drawing.Size(176, 65);
            this.addressLabel.TabIndex = 18;
            this.addressLabel.Text = "Address";
            this.addressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkLabel
            // 
            this.checkLabel.AutoSize = true;
            this.checkLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkLabel.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.checkLabel.Location = new System.Drawing.Point(3, 275);
            this.checkLabel.Name = "checkLabel";
            this.checkLabel.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.checkLabel.Size = new System.Drawing.Size(176, 65);
            this.checkLabel.TabIndex = 27;
            this.checkLabel.Text = "Health Check";
            this.checkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // detailsLabel
            // 
            this.detailsLabel.AutoSize = true;
            this.detailsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailsLabel.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.detailsLabel.Location = new System.Drawing.Point(3, 340);
            this.detailsLabel.Name = "detailsLabel";
            this.detailsLabel.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.innerTable.SetRowSpan(this.detailsLabel, 2);
            this.detailsLabel.Size = new System.Drawing.Size(176, 67);
            this.detailsLabel.TabIndex = 31;
            this.detailsLabel.Text = "Contact Details";
            this.detailsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // clock
            // 
            this.clock.Enabled = true;
            this.clock.Interval = 1000;
            this.clock.Tick += new System.EventHandler(this.clock_Tick);
            // 
            // tracer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(780, 457);
            this.Controls.Add(this.outerTable);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "tracer";
            this.Text = "Contact Tracer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.appClosing);
            this.outerTable.ResumeLayout(false);
            this.innerTable.ResumeLayout(false);
            this.innerTable.PerformLayout();
            this.headingTable.ResumeLayout(false);
            this.headingTable.PerformLayout();
            this.addressTable.ResumeLayout(false);
            this.addressTable.PerformLayout();
            this.infoTable.ResumeLayout(false);
            this.infoTable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel outerTable;
        private System.Windows.Forms.TableLayoutPanel innerTable;
        private System.Windows.Forms.Label heading;
        private System.Windows.Forms.TableLayoutPanel headingTable;
        private System.Windows.Forms.Label note;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.TextBox temp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox last;
        private System.Windows.Forms.TextBox first;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel addressTable;
        private System.Windows.Forms.TextBox house;
        private System.Windows.Forms.TextBox street;
        private System.Windows.Forms.TextBox barangay;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.TextBox mobile;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox fever;
        private System.Windows.Forms.CheckBox colds;
        private System.Windows.Forms.CheckBox cough;
        private System.Windows.Forms.TableLayoutPanel infoTable;
        private System.Windows.Forms.TextBox middle;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.RadioButton female;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label dataLabel;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label checkLabel;
        private System.Windows.Forms.Label detailsLabel;
        private System.Windows.Forms.Timer clock;
    }
}
