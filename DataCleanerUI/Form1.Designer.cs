namespace JRADataCleanUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label41 = new System.Windows.Forms.Label();
            this.chkBoxAllGroups = new System.Windows.Forms.CheckBox();
            this.chkBoxAllColumns = new System.Windows.Forms.CheckBox();
            this.chkListBoxGroups = new System.Windows.Forms.CheckedListBox();
            this.label53 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabInput = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxAppend = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.chkUsePreferredCity = new System.Windows.Forms.CheckBox();
            this.chkAdvancedAddressCorrection = new System.Windows.Forms.CheckBox();
            this.comboBoxCentricHint = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkActionAppend = new System.Windows.Forms.CheckBox();
            this.chkActionCheck = new System.Windows.Forms.CheckBox();
            this.chkActionVerify = new System.Windows.Forms.CheckBox();
            this.txtAddressline2 = new System.Windows.Forms.TextBox();
            this.label56 = new System.Windows.Forms.Label();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmdSendStdrequest = new System.Windows.Forms.Button();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPostal = new System.Windows.Forms.TextBox();
            this.txtProvince = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAddressline1 = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabColumns = new System.Windows.Forms.TabPage();
            this.label49 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.chkListBoxColumns = new System.Windows.Forms.CheckedListBox();
            this.label46 = new System.Windows.Forms.Label();
            this.tabOutput = new System.Windows.Forms.TabPage();
            this.txtOutResults = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtOutAddressLine2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtOutCompany = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtOutPhone = new System.Windows.Forms.TextBox();
            this.txtOutEmail = new System.Windows.Forms.TextBox();
            this.txtOutState = new System.Windows.Forms.TextBox();
            this.txtOutCity = new System.Windows.Forms.TextBox();
            this.txtOutAddressLine1 = new System.Windows.Forms.TextBox();
            this.txtOutFullName = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.tabXMLOut = new System.Windows.Forms.TabPage();
            this.webBrowserResponse = new System.Windows.Forms.WebBrowser();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkActionMove = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabInput.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabColumns.SuspendLayout();
            this.tabOutput.SuspendLayout();
            this.tabXMLOut.SuspendLayout();
            this.SuspendLayout();
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(335, 320);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(60, 13);
            this.label41.TabIndex = 43;
            this.label41.Text = "FirstName: ";
            // 
            // chkBoxAllGroups
            // 
            this.chkBoxAllGroups.Location = new System.Drawing.Point(353, 89);
            this.chkBoxAllGroups.Name = "chkBoxAllGroups";
            this.chkBoxAllGroups.Size = new System.Drawing.Size(138, 17);
            this.chkBoxAllGroups.TabIndex = 14;
            this.chkBoxAllGroups.Text = "Check All Groups";
            this.chkBoxAllGroups.UseVisualStyleBackColor = true;
            this.chkBoxAllGroups.CheckedChanged += new System.EventHandler(this.chkBoxAllGroups_CheckedChanged);
            // 
            // chkBoxAllColumns
            // 
            this.chkBoxAllColumns.Location = new System.Drawing.Point(37, 88);
            this.chkBoxAllColumns.Name = "chkBoxAllColumns";
            this.chkBoxAllColumns.Size = new System.Drawing.Size(121, 17);
            this.chkBoxAllColumns.TabIndex = 13;
            this.chkBoxAllColumns.Text = "Check All Columns";
            this.chkBoxAllColumns.UseVisualStyleBackColor = true;
            this.chkBoxAllColumns.CheckedChanged += new System.EventHandler(this.chkBoxAllColumns_CheckedChanged);
            // 
            // chkListBoxGroups
            // 
            this.chkListBoxGroups.CheckOnClick = true;
            this.chkListBoxGroups.FormattingEnabled = true;
            this.chkListBoxGroups.Location = new System.Drawing.Point(350, 112);
            this.chkListBoxGroups.Name = "chkListBoxGroups";
            this.chkListBoxGroups.Size = new System.Drawing.Size(266, 124);
            this.chkListBoxGroups.TabIndex = 12;
            // 
            // label53
            // 
            this.label53.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label53.Location = new System.Drawing.Point(350, 53);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(260, 14);
            this.label53.TabIndex = 11;
            this.label53.Text = "You can also select a group of columns to output";
            // 
            // label54
            // 
            this.label54.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label54.Location = new System.Drawing.Point(38, 53);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(284, 16);
            this.label54.TabIndex = 10;
            this.label54.Text = "Select the Columns you wish to add to your output";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(335, 344);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(61, 13);
            this.label42.TabIndex = 44;
            this.label42.Text = "LastName: ";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabInput);
            this.tabControl1.Controls.Add(this.tabColumns);
            this.tabControl1.Controls.Add(this.tabOutput);
            this.tabControl1.Controls.Add(this.tabXMLOut);
            this.tabControl1.Location = new System.Drawing.Point(7, 56);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(676, 545);
            this.tabControl1.TabIndex = 47;
            // 
            // tabInput
            // 
            this.tabInput.BackColor = System.Drawing.Color.Transparent;
            this.tabInput.Controls.Add(this.groupBox2);
            this.tabInput.Controls.Add(this.groupBox1);
            this.tabInput.Controls.Add(this.txtAddressline2);
            this.tabInput.Controls.Add(this.label56);
            this.tabInput.Controls.Add(this.txtLast);
            this.tabInput.Controls.Add(this.txtFirst);
            this.tabInput.Controls.Add(this.label42);
            this.tabInput.Controls.Add(this.label41);
            this.tabInput.Controls.Add(this.txtCompany);
            this.tabInput.Controls.Add(this.label10);
            this.tabInput.Controls.Add(this.cmdSendStdrequest);
            this.tabInput.Controls.Add(this.txtCountry);
            this.tabInput.Controls.Add(this.txtPhone);
            this.tabInput.Controls.Add(this.txtEmail);
            this.tabInput.Controls.Add(this.txtPostal);
            this.tabInput.Controls.Add(this.txtProvince);
            this.tabInput.Controls.Add(this.txtCity);
            this.tabInput.Controls.Add(this.txtAddressline1);
            this.tabInput.Controls.Add(this.txtName);
            this.tabInput.Controls.Add(this.label9);
            this.tabInput.Controls.Add(this.label8);
            this.tabInput.Controls.Add(this.label7);
            this.tabInput.Controls.Add(this.label6);
            this.tabInput.Controls.Add(this.label5);
            this.tabInput.Controls.Add(this.label4);
            this.tabInput.Controls.Add(this.label3);
            this.tabInput.Controls.Add(this.label2);
            this.tabInput.Location = new System.Drawing.Point(4, 22);
            this.tabInput.Name = "tabInput";
            this.tabInput.Padding = new System.Windows.Forms.Padding(3);
            this.tabInput.Size = new System.Drawing.Size(668, 519);
            this.tabInput.TabIndex = 0;
            this.tabInput.Text = "Input";
            this.tabInput.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxAppend);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.chkUsePreferredCity);
            this.groupBox2.Controls.Add(this.chkAdvancedAddressCorrection);
            this.groupBox2.Controls.Add(this.comboBoxCentricHint);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Location = new System.Drawing.Point(205, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 124);
            this.groupBox2.TabIndex = 58;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Options";
            // 
            // comboBoxAppend
            // 
            this.comboBoxAppend.FormattingEnabled = true;
            this.comboBoxAppend.Items.AddRange(new object[] {
            "Check Error",
            "Always",
            "Blank"});
            this.comboBoxAppend.Location = new System.Drawing.Point(76, 94);
            this.comboBoxAppend.Name = "comboBoxAppend";
            this.comboBoxAppend.Size = new System.Drawing.Size(184, 21);
            this.comboBoxAppend.TabIndex = 58;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(26, 97);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 57;
            this.label13.Text = "Append";
            // 
            // chkUsePreferredCity
            // 
            this.chkUsePreferredCity.AutoSize = true;
            this.chkUsePreferredCity.Location = new System.Drawing.Point(15, 19);
            this.chkUsePreferredCity.Name = "chkUsePreferredCity";
            this.chkUsePreferredCity.Size = new System.Drawing.Size(111, 17);
            this.chkUsePreferredCity.TabIndex = 53;
            this.chkUsePreferredCity.Text = "Use Preferred City";
            this.chkUsePreferredCity.UseVisualStyleBackColor = true;
            // 
            // chkAdvancedAddressCorrection
            // 
            this.chkAdvancedAddressCorrection.Location = new System.Drawing.Point(15, 38);
            this.chkAdvancedAddressCorrection.Name = "chkAdvancedAddressCorrection";
            this.chkAdvancedAddressCorrection.Size = new System.Drawing.Size(184, 24);
            this.chkAdvancedAddressCorrection.TabIndex = 54;
            this.chkAdvancedAddressCorrection.Text = "Advanced Address Correction";
            this.chkAdvancedAddressCorrection.UseVisualStyleBackColor = true;
            // 
            // comboBoxCentricHint
            // 
            this.comboBoxCentricHint.FormattingEnabled = true;
            this.comboBoxCentricHint.Location = new System.Drawing.Point(76, 67);
            this.comboBoxCentricHint.Name = "comboBoxCentricHint";
            this.comboBoxCentricHint.Size = new System.Drawing.Size(184, 21);
            this.comboBoxCentricHint.TabIndex = 56;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(11, 70);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(59, 13);
            this.label24.TabIndex = 55;
            this.label24.Text = "CentricHint";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkActionMove);
            this.groupBox1.Controls.Add(this.chkActionAppend);
            this.groupBox1.Controls.Add(this.chkActionCheck);
            this.groupBox1.Controls.Add(this.chkActionVerify);
            this.groupBox1.Location = new System.Drawing.Point(26, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(108, 110);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Action";
            // 
            // chkActionAppend
            // 
            this.chkActionAppend.AutoSize = true;
            this.chkActionAppend.Location = new System.Drawing.Point(18, 65);
            this.chkActionAppend.Name = "chkActionAppend";
            this.chkActionAppend.Size = new System.Drawing.Size(66, 17);
            this.chkActionAppend.TabIndex = 53;
            this.chkActionAppend.Text = "Append ";
            this.chkActionAppend.UseVisualStyleBackColor = true;
            // 
            // chkActionCheck
            // 
            this.chkActionCheck.Checked = true;
            this.chkActionCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActionCheck.Location = new System.Drawing.Point(18, 19);
            this.chkActionCheck.Name = "chkActionCheck";
            this.chkActionCheck.Size = new System.Drawing.Size(83, 17);
            this.chkActionCheck.TabIndex = 51;
            this.chkActionCheck.Text = "Check      ";
            this.chkActionCheck.UseVisualStyleBackColor = true;
            // 
            // chkActionVerify
            // 
            this.chkActionVerify.AutoSize = true;
            this.chkActionVerify.Location = new System.Drawing.Point(18, 42);
            this.chkActionVerify.Name = "chkActionVerify";
            this.chkActionVerify.Size = new System.Drawing.Size(58, 17);
            this.chkActionVerify.TabIndex = 52;
            this.chkActionVerify.Text = "Verify  ";
            this.chkActionVerify.UseVisualStyleBackColor = true;
            // 
            // txtAddressline2
            // 
            this.txtAddressline2.Location = new System.Drawing.Point(120, 247);
            this.txtAddressline2.Name = "txtAddressline2";
            this.txtAddressline2.Size = new System.Drawing.Size(492, 20);
            this.txtAddressline2.TabIndex = 49;
            // 
            // label56
            // 
            this.label56.Location = new System.Drawing.Point(22, 250);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(92, 17);
            this.label56.TabIndex = 48;
            this.label56.Text = "Address Line 2: ";
            // 
            // txtLast
            // 
            this.txtLast.Location = new System.Drawing.Point(421, 341);
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(192, 20);
            this.txtLast.TabIndex = 46;
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(421, 317);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(192, 20);
            this.txtFirst.TabIndex = 45;
            // 
            // txtCompany
            // 
            this.txtCompany.Location = new System.Drawing.Point(120, 196);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(492, 20);
            this.txtCompany.TabIndex = 32;
            this.txtCompany.Text = "Melissa Data";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 199);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "Company: ";
            // 
            // cmdSendStdrequest
            // 
            this.cmdSendStdrequest.Location = new System.Drawing.Point(452, 444);
            this.cmdSendStdrequest.Name = "cmdSendStdrequest";
            this.cmdSendStdrequest.Size = new System.Drawing.Size(150, 41);
            this.cmdSendStdrequest.TabIndex = 30;
            this.cmdSendStdrequest.Text = "Send Request";
            this.cmdSendStdrequest.UseVisualStyleBackColor = true;
            this.cmdSendStdrequest.Click += new System.EventHandler(this.cmdSendStdrequest_Click);
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(120, 393);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(183, 20);
            this.txtCountry.TabIndex = 29;
            this.txtCountry.Text = "USA";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(421, 390);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(192, 20);
            this.txtPhone.TabIndex = 28;
            this.txtPhone.Text = "7815457300";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(421, 366);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(192, 20);
            this.txtEmail.TabIndex = 27;
            // 
            // txtPostal
            // 
            this.txtPostal.Location = new System.Drawing.Point(120, 366);
            this.txtPostal.Name = "txtPostal";
            this.txtPostal.Size = new System.Drawing.Size(183, 20);
            this.txtPostal.TabIndex = 26;
            this.txtPostal.Text = "02066";
            // 
            // txtProvince
            // 
            this.txtProvince.Location = new System.Drawing.Point(121, 340);
            this.txtProvince.Name = "txtProvince";
            this.txtProvince.Size = new System.Drawing.Size(182, 20);
            this.txtProvince.TabIndex = 25;
            this.txtProvince.Text = "MA";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(120, 314);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(183, 20);
            this.txtCity.TabIndex = 24;
            this.txtCity.Text = "Scituate";
            // 
            // txtAddressline1
            // 
            this.txtAddressline1.Location = new System.Drawing.Point(120, 221);
            this.txtAddressline1.Name = "txtAddressline1";
            this.txtAddressline1.Size = new System.Drawing.Size(492, 20);
            this.txtAddressline1.TabIndex = 23;
            this.txtAddressline1.Text = "50 Cole Parkway #34";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(120, 171);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(492, 20);
            this.txtName.TabIndex = 22;
            this.txtName.Text = "Mr. John Doe";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(24, 396);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Country: ";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(335, 393);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Phone: ";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(335, 369);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "eMail: ";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(22, 369);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "PostalCode: ";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(22, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "State :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "City: ";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(22, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Address Line 1: ";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(23, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "FullName :";
            // 
            // tabColumns
            // 
            this.tabColumns.BackColor = System.Drawing.Color.Transparent;
            this.tabColumns.Controls.Add(this.chkBoxAllGroups);
            this.tabColumns.Controls.Add(this.chkBoxAllColumns);
            this.tabColumns.Controls.Add(this.chkListBoxGroups);
            this.tabColumns.Controls.Add(this.label53);
            this.tabColumns.Controls.Add(this.label54);
            this.tabColumns.Controls.Add(this.label49);
            this.tabColumns.Controls.Add(this.label48);
            this.tabColumns.Controls.Add(this.label47);
            this.tabColumns.Controls.Add(this.chkListBoxColumns);
            this.tabColumns.Controls.Add(this.label46);
            this.tabColumns.Location = new System.Drawing.Point(4, 22);
            this.tabColumns.Name = "tabColumns";
            this.tabColumns.Padding = new System.Windows.Forms.Padding(3);
            this.tabColumns.Size = new System.Drawing.Size(668, 519);
            this.tabColumns.TabIndex = 7;
            this.tabColumns.Text = "Columns";
            this.tabColumns.UseVisualStyleBackColor = true;
            // 
            // label49
            // 
            this.label49.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label49.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label49.Location = new System.Drawing.Point(356, 383);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(260, 60);
            this.label49.TabIndex = 9;
            this.label49.Text = "Unchecked columns will not be returned";
            // 
            // label48
            // 
            this.label48.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label48.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label48.Location = new System.Drawing.Point(356, 254);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(260, 47);
            this.label48.TabIndex = 8;
            this.label48.Text = "By default, \'Actions\' return basic output columns.";
            // 
            // label47
            // 
            this.label47.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label47.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label47.Location = new System.Drawing.Point(356, 312);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(260, 65);
            this.label47.TabIndex = 5;
            this.label47.Text = "To override the default Response structure, select the properties which you would" +
                " like returned in the XML response";
            // 
            // chkListBoxColumns
            // 
            this.chkListBoxColumns.CheckOnClick = true;
            this.chkListBoxColumns.FormattingEnabled = true;
            this.chkListBoxColumns.Location = new System.Drawing.Point(34, 114);
            this.chkListBoxColumns.Name = "chkListBoxColumns";
            this.chkListBoxColumns.Size = new System.Drawing.Size(288, 334);
            this.chkListBoxColumns.TabIndex = 4;
            // 
            // label46
            // 
            this.label46.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.Location = new System.Drawing.Point(20, 25);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(85, 14);
            this.label46.TabIndex = 3;
            this.label46.Text = "COLUMNS";
            // 
            // tabOutput
            // 
            this.tabOutput.Controls.Add(this.txtOutResults);
            this.tabOutput.Controls.Add(this.label12);
            this.tabOutput.Controls.Add(this.txtOutAddressLine2);
            this.tabOutput.Controls.Add(this.label11);
            this.tabOutput.Controls.Add(this.txtOutCompany);
            this.tabOutput.Controls.Add(this.label15);
            this.tabOutput.Controls.Add(this.txtOutPhone);
            this.tabOutput.Controls.Add(this.txtOutEmail);
            this.tabOutput.Controls.Add(this.txtOutState);
            this.tabOutput.Controls.Add(this.txtOutCity);
            this.tabOutput.Controls.Add(this.txtOutAddressLine1);
            this.tabOutput.Controls.Add(this.txtOutFullName);
            this.tabOutput.Controls.Add(this.label17);
            this.tabOutput.Controls.Add(this.label18);
            this.tabOutput.Controls.Add(this.label20);
            this.tabOutput.Controls.Add(this.label21);
            this.tabOutput.Controls.Add(this.label22);
            this.tabOutput.Controls.Add(this.label23);
            this.tabOutput.Location = new System.Drawing.Point(4, 22);
            this.tabOutput.Name = "tabOutput";
            this.tabOutput.Size = new System.Drawing.Size(668, 519);
            this.tabOutput.TabIndex = 8;
            this.tabOutput.Text = "Output";
            this.tabOutput.UseVisualStyleBackColor = true;
            // 
            // txtOutResults
            // 
            this.txtOutResults.Location = new System.Drawing.Point(125, 225);
            this.txtOutResults.Multiline = true;
            this.txtOutResults.Name = "txtOutResults";
            this.txtOutResults.ReadOnly = true;
            this.txtOutResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutResults.Size = new System.Drawing.Size(492, 248);
            this.txtOutResults.TabIndex = 95;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(27, 225);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 17);
            this.label12.TabIndex = 94;
            this.label12.Text = "Results:";
            // 
            // txtOutAddressLine2
            // 
            this.txtOutAddressLine2.Location = new System.Drawing.Point(125, 102);
            this.txtOutAddressLine2.Name = "txtOutAddressLine2";
            this.txtOutAddressLine2.ReadOnly = true;
            this.txtOutAddressLine2.Size = new System.Drawing.Size(492, 20);
            this.txtOutAddressLine2.TabIndex = 93;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(27, 105);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 17);
            this.label11.TabIndex = 92;
            this.label11.Text = "Address Line 2: ";
            // 
            // txtOutCompany
            // 
            this.txtOutCompany.Location = new System.Drawing.Point(125, 51);
            this.txtOutCompany.Name = "txtOutCompany";
            this.txtOutCompany.ReadOnly = true;
            this.txtOutCompany.Size = new System.Drawing.Size(492, 20);
            this.txtOutCompany.TabIndex = 91;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(28, 54);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 13);
            this.label15.TabIndex = 90;
            this.label15.Text = "Company: ";
            // 
            // txtOutPhone
            // 
            this.txtOutPhone.Location = new System.Drawing.Point(425, 177);
            this.txtOutPhone.Name = "txtOutPhone";
            this.txtOutPhone.ReadOnly = true;
            this.txtOutPhone.Size = new System.Drawing.Size(192, 20);
            this.txtOutPhone.TabIndex = 89;
            // 
            // txtOutEmail
            // 
            this.txtOutEmail.Location = new System.Drawing.Point(425, 153);
            this.txtOutEmail.Name = "txtOutEmail";
            this.txtOutEmail.ReadOnly = true;
            this.txtOutEmail.Size = new System.Drawing.Size(192, 20);
            this.txtOutEmail.TabIndex = 88;
            // 
            // txtOutState
            // 
            this.txtOutState.Location = new System.Drawing.Point(124, 177);
            this.txtOutState.Name = "txtOutState";
            this.txtOutState.ReadOnly = true;
            this.txtOutState.Size = new System.Drawing.Size(182, 20);
            this.txtOutState.TabIndex = 87;
            // 
            // txtOutCity
            // 
            this.txtOutCity.Location = new System.Drawing.Point(124, 153);
            this.txtOutCity.Name = "txtOutCity";
            this.txtOutCity.ReadOnly = true;
            this.txtOutCity.Size = new System.Drawing.Size(182, 20);
            this.txtOutCity.TabIndex = 86;
            // 
            // txtOutAddressLine1
            // 
            this.txtOutAddressLine1.Location = new System.Drawing.Point(125, 76);
            this.txtOutAddressLine1.Name = "txtOutAddressLine1";
            this.txtOutAddressLine1.ReadOnly = true;
            this.txtOutAddressLine1.Size = new System.Drawing.Size(492, 20);
            this.txtOutAddressLine1.TabIndex = 85;
            // 
            // txtOutFullName
            // 
            this.txtOutFullName.Location = new System.Drawing.Point(125, 26);
            this.txtOutFullName.Name = "txtOutFullName";
            this.txtOutFullName.ReadOnly = true;
            this.txtOutFullName.Size = new System.Drawing.Size(492, 20);
            this.txtOutFullName.TabIndex = 84;
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(339, 180);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(74, 17);
            this.label17.TabIndex = 83;
            this.label17.Text = "Phone: ";
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(339, 156);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(74, 17);
            this.label18.TabIndex = 82;
            this.label18.Text = "eMail: ";
            // 
            // label20
            // 
            this.label20.Location = new System.Drawing.Point(28, 182);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(75, 17);
            this.label20.TabIndex = 81;
            this.label20.Text = "State :";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(28, 156);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(30, 13);
            this.label21.TabIndex = 80;
            this.label21.Text = "City: ";
            // 
            // label22
            // 
            this.label22.Location = new System.Drawing.Point(27, 79);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(92, 17);
            this.label22.TabIndex = 79;
            this.label22.Text = "Address Line 1: ";
            // 
            // label23
            // 
            this.label23.Location = new System.Drawing.Point(28, 29);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(68, 17);
            this.label23.TabIndex = 78;
            this.label23.Text = "FullName :";
            // 
            // tabXMLOut
            // 
            this.tabXMLOut.BackColor = System.Drawing.Color.Transparent;
            this.tabXMLOut.Controls.Add(this.webBrowserResponse);
            this.tabXMLOut.Location = new System.Drawing.Point(4, 22);
            this.tabXMLOut.Name = "tabXMLOut";
            this.tabXMLOut.Padding = new System.Windows.Forms.Padding(3);
            this.tabXMLOut.Size = new System.Drawing.Size(668, 519);
            this.tabXMLOut.TabIndex = 2;
            this.tabXMLOut.Text = "XML Output";
            this.tabXMLOut.UseVisualStyleBackColor = true;
            // 
            // webBrowserResponse
            // 
            this.webBrowserResponse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserResponse.Location = new System.Drawing.Point(3, 3);
            this.webBrowserResponse.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserResponse.Name = "webBrowserResponse";
            this.webBrowserResponse.Size = new System.Drawing.Size(662, 513);
            this.webBrowserResponse.TabIndex = 0;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(83, 16);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(342, 20);
            this.txtCustomerID.TabIndex = 49;
            this.txtCustomerID.Text = "Enter Customer ID Here";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 48;
            this.label1.Text = "Customer ID: ";
            // 
            // chkActionMove
            // 
            this.chkActionMove.AutoSize = true;
            this.chkActionMove.Location = new System.Drawing.Point(18, 87);
            this.chkActionMove.Name = "chkActionMove";
            this.chkActionMove.Size = new System.Drawing.Size(53, 17);
            this.chkActionMove.TabIndex = 54;
            this.chkActionMove.Text = "Move";
            this.chkActionMove.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 608);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Personator Web Service SOAP Sample";
            this.tabControl1.ResumeLayout(false);
            this.tabInput.ResumeLayout(false);
            this.tabInput.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabColumns.ResumeLayout(false);
            this.tabOutput.ResumeLayout(false);
            this.tabOutput.PerformLayout();
            this.tabXMLOut.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.CheckBox chkBoxAllGroups;
        private System.Windows.Forms.CheckBox chkBoxAllColumns;
        private System.Windows.Forms.CheckedListBox chkListBoxGroups;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabInput;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkUsePreferredCity;
        private System.Windows.Forms.CheckBox chkAdvancedAddressCorrection;
        private System.Windows.Forms.ComboBox comboBoxCentricHint;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkActionCheck;
        private System.Windows.Forms.CheckBox chkActionVerify;
        private System.Windows.Forms.TextBox txtAddressline2;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button cmdSendStdrequest;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPostal;
        private System.Windows.Forms.TextBox txtProvince;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtAddressline1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabColumns;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.CheckedListBox chkListBoxColumns;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.TabPage tabXMLOut;
        private System.Windows.Forms.WebBrowser webBrowserResponse;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabOutput;
        private System.Windows.Forms.TextBox txtOutResults;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtOutAddressLine2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtOutCompany;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtOutPhone;
        private System.Windows.Forms.TextBox txtOutEmail;
        private System.Windows.Forms.TextBox txtOutState;
        private System.Windows.Forms.TextBox txtOutCity;
        private System.Windows.Forms.TextBox txtOutAddressLine1;
        private System.Windows.Forms.TextBox txtOutFullName;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox comboBoxAppend;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox chkActionAppend;
        private System.Windows.Forms.CheckBox chkActionMove;
    }
}

