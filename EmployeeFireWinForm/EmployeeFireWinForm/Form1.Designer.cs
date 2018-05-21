namespace EmployeeFireWinForm
{
    partial class fEmployeesList
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
            this.label = new System.Windows.Forms.Label();
            this.lbEmployeesList = new System.Windows.Forms.ListBox();
            this.bFired = new System.Windows.Forms.Button();
            this.lFirstName = new System.Windows.Forms.Label();
            this.lLastName = new System.Windows.Forms.Label();
            this.lJobTitle = new System.Windows.Forms.Label();
            this.lAddress = new System.Windows.Forms.Label();
            this.lPhone = new System.Windows.Forms.Label();
            this.lEmail = new System.Windows.Forms.Label();
            this.lCity = new System.Windows.Forms.Label();
            this.lState = new System.Windows.Forms.Label();
            this.lRegion = new System.Windows.Forms.Label();
            this.lPostCode = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbJobTitle = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.tbState = new System.Windows.Forms.TextBox();
            this.tbRegion = new System.Windows.Forms.TextBox();
            this.tbPostCode = new System.Windows.Forms.TextBox();
            this.tbStartDate = new System.Windows.Forms.TextBox();
            this.tbEndDate = new System.Windows.Forms.TextBox();
            this.lStartDate = new System.Windows.Forms.Label();
            this.lEndDate = new System.Windows.Forms.Label();
            this.tbMiddleName = new System.Windows.Forms.TextBox();
            this.lMiddleName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.Location = new System.Drawing.Point(48, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(76, 17);
            this.label.TabIndex = 0;
            this.label.Text = "Employees";
            // 
            // lbEmployeesList
            // 
            this.lbEmployeesList.FormattingEnabled = true;
            this.lbEmployeesList.Location = new System.Drawing.Point(12, 29);
            this.lbEmployeesList.Name = "lbEmployeesList";
            this.lbEmployeesList.Size = new System.Drawing.Size(157, 277);
            this.lbEmployeesList.TabIndex = 1;
            this.lbEmployeesList.SelectedIndexChanged += new System.EventHandler(this.lbEmployeesList_SelectedIndexChanged);
            // 
            // bFired
            // 
            this.bFired.Location = new System.Drawing.Point(49, 320);
            this.bFired.Name = "bFired";
            this.bFired.Size = new System.Drawing.Size(75, 23);
            this.bFired.TabIndex = 2;
            this.bFired.Text = "Fired";
            this.bFired.UseVisualStyleBackColor = true;
            this.bFired.Click += new System.EventHandler(this.bFired_Click);
            // 
            // lFirstName
            // 
            this.lFirstName.AutoSize = true;
            this.lFirstName.Location = new System.Drawing.Point(187, 28);
            this.lFirstName.Name = "lFirstName";
            this.lFirstName.Size = new System.Drawing.Size(57, 13);
            this.lFirstName.TabIndex = 3;
            this.lFirstName.Text = "First Name";
            // 
            // lLastName
            // 
            this.lLastName.AutoSize = true;
            this.lLastName.Location = new System.Drawing.Point(187, 54);
            this.lLastName.Name = "lLastName";
            this.lLastName.Size = new System.Drawing.Size(58, 13);
            this.lLastName.TabIndex = 4;
            this.lLastName.Text = "Last Name";
            // 
            // lJobTitle
            // 
            this.lJobTitle.AutoSize = true;
            this.lJobTitle.Location = new System.Drawing.Point(187, 111);
            this.lJobTitle.Name = "lJobTitle";
            this.lJobTitle.Size = new System.Drawing.Size(44, 13);
            this.lJobTitle.TabIndex = 5;
            this.lJobTitle.Text = "JobTitle";
            // 
            // lAddress
            // 
            this.lAddress.AutoSize = true;
            this.lAddress.Location = new System.Drawing.Point(187, 189);
            this.lAddress.Name = "lAddress";
            this.lAddress.Size = new System.Drawing.Size(45, 13);
            this.lAddress.TabIndex = 6;
            this.lAddress.Text = "Address";
            // 
            // lPhone
            // 
            this.lPhone.AutoSize = true;
            this.lPhone.Location = new System.Drawing.Point(187, 137);
            this.lPhone.Name = "lPhone";
            this.lPhone.Size = new System.Drawing.Size(38, 13);
            this.lPhone.TabIndex = 6;
            this.lPhone.Text = "Phone";
            // 
            // lEmail
            // 
            this.lEmail.AutoSize = true;
            this.lEmail.Location = new System.Drawing.Point(187, 163);
            this.lEmail.Name = "lEmail";
            this.lEmail.Size = new System.Drawing.Size(32, 13);
            this.lEmail.TabIndex = 7;
            this.lEmail.Text = "Email";
            // 
            // lCity
            // 
            this.lCity.AutoSize = true;
            this.lCity.Location = new System.Drawing.Point(188, 215);
            this.lCity.Name = "lCity";
            this.lCity.Size = new System.Drawing.Size(24, 13);
            this.lCity.TabIndex = 8;
            this.lCity.Text = "City";
            // 
            // lState
            // 
            this.lState.AutoSize = true;
            this.lState.Location = new System.Drawing.Point(187, 241);
            this.lState.Name = "lState";
            this.lState.Size = new System.Drawing.Size(32, 13);
            this.lState.TabIndex = 9;
            this.lState.Text = "State";
            // 
            // lRegion
            // 
            this.lRegion.AutoSize = true;
            this.lRegion.Location = new System.Drawing.Point(187, 267);
            this.lRegion.Name = "lRegion";
            this.lRegion.Size = new System.Drawing.Size(41, 13);
            this.lRegion.TabIndex = 10;
            this.lRegion.Text = "Region";
            // 
            // lPostCode
            // 
            this.lPostCode.AutoSize = true;
            this.lPostCode.Location = new System.Drawing.Point(187, 293);
            this.lPostCode.Name = "lPostCode";
            this.lPostCode.Size = new System.Drawing.Size(56, 13);
            this.lPostCode.TabIndex = 11;
            this.lPostCode.Text = "Post Code";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(260, 25);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(150, 20);
            this.tbFirstName.TabIndex = 12;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(260, 51);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(150, 20);
            this.tbLastName.TabIndex = 13;
            // 
            // tbJobTitle
            // 
            this.tbJobTitle.Location = new System.Drawing.Point(260, 103);
            this.tbJobTitle.Name = "tbJobTitle";
            this.tbJobTitle.Size = new System.Drawing.Size(150, 20);
            this.tbJobTitle.TabIndex = 14;
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(260, 129);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(150, 20);
            this.tbPhone.TabIndex = 15;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(260, 155);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(150, 20);
            this.tbEmail.TabIndex = 16;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(260, 181);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(150, 20);
            this.tbAddress.TabIndex = 17;
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(260, 207);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(150, 20);
            this.tbCity.TabIndex = 18;
            // 
            // tbState
            // 
            this.tbState.Location = new System.Drawing.Point(260, 233);
            this.tbState.Name = "tbState";
            this.tbState.Size = new System.Drawing.Size(150, 20);
            this.tbState.TabIndex = 19;
            // 
            // tbRegion
            // 
            this.tbRegion.Location = new System.Drawing.Point(260, 259);
            this.tbRegion.Name = "tbRegion";
            this.tbRegion.Size = new System.Drawing.Size(150, 20);
            this.tbRegion.TabIndex = 20;
            // 
            // tbPostCode
            // 
            this.tbPostCode.Location = new System.Drawing.Point(260, 286);
            this.tbPostCode.Name = "tbPostCode";
            this.tbPostCode.Size = new System.Drawing.Size(150, 20);
            this.tbPostCode.TabIndex = 21;
            // 
            // tbStartDate
            // 
            this.tbStartDate.Location = new System.Drawing.Point(214, 322);
            this.tbStartDate.Name = "tbStartDate";
            this.tbStartDate.Size = new System.Drawing.Size(65, 20);
            this.tbStartDate.TabIndex = 22;
            // 
            // tbEndDate
            // 
            this.tbEndDate.Location = new System.Drawing.Point(343, 322);
            this.tbEndDate.Name = "tbEndDate";
            this.tbEndDate.Size = new System.Drawing.Size(65, 20);
            this.tbEndDate.TabIndex = 23;
            // 
            // lStartDate
            // 
            this.lStartDate.AutoSize = true;
            this.lStartDate.Location = new System.Drawing.Point(153, 325);
            this.lStartDate.Name = "lStartDate";
            this.lStartDate.Size = new System.Drawing.Size(55, 13);
            this.lStartDate.TabIndex = 24;
            this.lStartDate.Text = "Start Date";
            // 
            // lEndDate
            // 
            this.lEndDate.AutoSize = true;
            this.lEndDate.Location = new System.Drawing.Point(285, 325);
            this.lEndDate.Name = "lEndDate";
            this.lEndDate.Size = new System.Drawing.Size(52, 13);
            this.lEndDate.TabIndex = 25;
            this.lEndDate.Text = "End Date";
            // 
            // tbMiddleName
            // 
            this.tbMiddleName.Location = new System.Drawing.Point(260, 77);
            this.tbMiddleName.Name = "tbMiddleName";
            this.tbMiddleName.Size = new System.Drawing.Size(150, 20);
            this.tbMiddleName.TabIndex = 26;
            // 
            // lMiddleName
            // 
            this.lMiddleName.AutoSize = true;
            this.lMiddleName.Location = new System.Drawing.Point(186, 80);
            this.lMiddleName.Name = "lMiddleName";
            this.lMiddleName.Size = new System.Drawing.Size(69, 13);
            this.lMiddleName.TabIndex = 27;
            this.lMiddleName.Text = "Middle Name";
            // 
            // fEmployeesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 351);
            this.Controls.Add(this.lMiddleName);
            this.Controls.Add(this.tbMiddleName);
            this.Controls.Add(this.lEndDate);
            this.Controls.Add(this.lStartDate);
            this.Controls.Add(this.tbEndDate);
            this.Controls.Add(this.tbStartDate);
            this.Controls.Add(this.tbPostCode);
            this.Controls.Add(this.tbRegion);
            this.Controls.Add(this.tbState);
            this.Controls.Add(this.tbCity);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.tbJobTitle);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.lPostCode);
            this.Controls.Add(this.lRegion);
            this.Controls.Add(this.lState);
            this.Controls.Add(this.lCity);
            this.Controls.Add(this.lEmail);
            this.Controls.Add(this.lPhone);
            this.Controls.Add(this.lAddress);
            this.Controls.Add(this.lJobTitle);
            this.Controls.Add(this.lLastName);
            this.Controls.Add(this.lFirstName);
            this.Controls.Add(this.bFired);
            this.Controls.Add(this.lbEmployeesList);
            this.Controls.Add(this.label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fEmployeesList";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employees List";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fEmployeesList_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ListBox lbEmployeesList;
        private System.Windows.Forms.Button bFired;
        private System.Windows.Forms.Label lFirstName;
        private System.Windows.Forms.Label lLastName;
        private System.Windows.Forms.Label lJobTitle;
        private System.Windows.Forms.Label lAddress;
        private System.Windows.Forms.Label lPhone;
        private System.Windows.Forms.Label lEmail;
        private System.Windows.Forms.Label lCity;
        private System.Windows.Forms.Label lState;
        private System.Windows.Forms.Label lRegion;
        private System.Windows.Forms.Label lPostCode;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbJobTitle;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.TextBox tbState;
        private System.Windows.Forms.TextBox tbRegion;
        private System.Windows.Forms.TextBox tbPostCode;
        private System.Windows.Forms.TextBox tbStartDate;
        private System.Windows.Forms.TextBox tbEndDate;
        private System.Windows.Forms.Label lStartDate;
        private System.Windows.Forms.Label lEndDate;
        private System.Windows.Forms.TextBox tbMiddleName;
        private System.Windows.Forms.Label lMiddleName;
    }
}

