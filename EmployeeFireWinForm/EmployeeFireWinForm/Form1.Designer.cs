﻿namespace EmployeeFireWinForm
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
            this.label.Location = new System.Drawing.Point(64, 11);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(93, 20);
            this.label.TabIndex = 0;
            this.label.Text = "Employees";
            // 
            // lbEmployeesList
            // 
            this.lbEmployeesList.FormattingEnabled = true;
            this.lbEmployeesList.ItemHeight = 16;
            this.lbEmployeesList.Location = new System.Drawing.Point(16, 36);
            this.lbEmployeesList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbEmployeesList.Name = "lbEmployeesList";
            this.lbEmployeesList.Size = new System.Drawing.Size(208, 340);
            this.lbEmployeesList.TabIndex = 1;
            this.lbEmployeesList.SelectedIndexChanged += new System.EventHandler(this.lbEmployeesList_SelectedIndexChanged);
            // 
            // bFired
            // 
            this.bFired.Location = new System.Drawing.Point(65, 394);
            this.bFired.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bFired.Name = "bFired";
            this.bFired.Size = new System.Drawing.Size(100, 28);
            this.bFired.TabIndex = 2;
            this.bFired.Text = "Fired";
            this.bFired.UseVisualStyleBackColor = true;
            this.bFired.Click += new System.EventHandler(this.bFired_Click);
            // 
            // lFirstName
            // 
            this.lFirstName.AutoSize = true;
            this.lFirstName.Location = new System.Drawing.Point(249, 34);
            this.lFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lFirstName.Name = "lFirstName";
            this.lFirstName.Size = new System.Drawing.Size(76, 17);
            this.lFirstName.TabIndex = 3;
            this.lFirstName.Text = "First Name";
            // 
            // lLastName
            // 
            this.lLastName.AutoSize = true;
            this.lLastName.Location = new System.Drawing.Point(249, 66);
            this.lLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lLastName.Name = "lLastName";
            this.lLastName.Size = new System.Drawing.Size(76, 17);
            this.lLastName.TabIndex = 4;
            this.lLastName.Text = "Last Name";
            // 
            // lJobTitle
            // 
            this.lJobTitle.AutoSize = true;
            this.lJobTitle.Location = new System.Drawing.Point(249, 130);
            this.lJobTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lJobTitle.Name = "lJobTitle";
            this.lJobTitle.Size = new System.Drawing.Size(58, 17);
            this.lJobTitle.TabIndex = 5;
            this.lJobTitle.Text = "JobTitle";
            // 
            // lAddress
            // 
            this.lAddress.AutoSize = true;
            this.lAddress.Location = new System.Drawing.Point(249, 226);
            this.lAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lAddress.Name = "lAddress";
            this.lAddress.Size = new System.Drawing.Size(60, 17);
            this.lAddress.TabIndex = 6;
            this.lAddress.Text = "Address";
            // 
            // lPhone
            // 
            this.lPhone.AutoSize = true;
            this.lPhone.Location = new System.Drawing.Point(249, 162);
            this.lPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lPhone.Name = "lPhone";
            this.lPhone.Size = new System.Drawing.Size(49, 17);
            this.lPhone.TabIndex = 6;
            this.lPhone.Text = "Phone";
            // 
            // lEmail
            // 
            this.lEmail.AutoSize = true;
            this.lEmail.Location = new System.Drawing.Point(249, 194);
            this.lEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lEmail.Name = "lEmail";
            this.lEmail.Size = new System.Drawing.Size(42, 17);
            this.lEmail.TabIndex = 7;
            this.lEmail.Text = "Email";
            // 
            // lCity
            // 
            this.lCity.AutoSize = true;
            this.lCity.Location = new System.Drawing.Point(251, 258);
            this.lCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lCity.Name = "lCity";
            this.lCity.Size = new System.Drawing.Size(31, 17);
            this.lCity.TabIndex = 8;
            this.lCity.Text = "City";
            // 
            // lState
            // 
            this.lState.AutoSize = true;
            this.lState.Location = new System.Drawing.Point(249, 290);
            this.lState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lState.Name = "lState";
            this.lState.Size = new System.Drawing.Size(41, 17);
            this.lState.TabIndex = 9;
            this.lState.Text = "State";
            // 
            // lRegion
            // 
            this.lRegion.AutoSize = true;
            this.lRegion.Location = new System.Drawing.Point(249, 322);
            this.lRegion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lRegion.Name = "lRegion";
            this.lRegion.Size = new System.Drawing.Size(53, 17);
            this.lRegion.TabIndex = 10;
            this.lRegion.Text = "Region";
            // 
            // lPostCode
            // 
            this.lPostCode.AutoSize = true;
            this.lPostCode.Location = new System.Drawing.Point(249, 354);
            this.lPostCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lPostCode.Name = "lPostCode";
            this.lPostCode.Size = new System.Drawing.Size(73, 17);
            this.lPostCode.TabIndex = 11;
            this.lPostCode.Text = "Post Code";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Enabled = false;
            this.tbFirstName.Location = new System.Drawing.Point(347, 31);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(199, 22);
            this.tbFirstName.TabIndex = 12;
            // 
            // tbLastName
            // 
            this.tbLastName.Enabled = false;
            this.tbLastName.Location = new System.Drawing.Point(347, 63);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(199, 22);
            this.tbLastName.TabIndex = 13;
            // 
            // tbJobTitle
            // 
            this.tbJobTitle.Enabled = false;
            this.tbJobTitle.Location = new System.Drawing.Point(347, 127);
            this.tbJobTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbJobTitle.Name = "tbJobTitle";
            this.tbJobTitle.Size = new System.Drawing.Size(199, 22);
            this.tbJobTitle.TabIndex = 14;
            // 
            // tbPhone
            // 
            this.tbPhone.Enabled = false;
            this.tbPhone.Location = new System.Drawing.Point(347, 159);
            this.tbPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(199, 22);
            this.tbPhone.TabIndex = 15;
            // 
            // tbEmail
            // 
            this.tbEmail.Enabled = false;
            this.tbEmail.Location = new System.Drawing.Point(347, 191);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(199, 22);
            this.tbEmail.TabIndex = 16;
            // 
            // tbAddress
            // 
            this.tbAddress.Enabled = false;
            this.tbAddress.Location = new System.Drawing.Point(347, 223);
            this.tbAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(199, 22);
            this.tbAddress.TabIndex = 17;
            // 
            // tbCity
            // 
            this.tbCity.Enabled = false;
            this.tbCity.Location = new System.Drawing.Point(347, 255);
            this.tbCity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(199, 22);
            this.tbCity.TabIndex = 18;
            // 
            // tbState
            // 
            this.tbState.Enabled = false;
            this.tbState.Location = new System.Drawing.Point(347, 287);
            this.tbState.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbState.Name = "tbState";
            this.tbState.Size = new System.Drawing.Size(199, 22);
            this.tbState.TabIndex = 19;
            // 
            // tbRegion
            // 
            this.tbRegion.Enabled = false;
            this.tbRegion.Location = new System.Drawing.Point(347, 319);
            this.tbRegion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbRegion.Name = "tbRegion";
            this.tbRegion.Size = new System.Drawing.Size(199, 22);
            this.tbRegion.TabIndex = 20;
            // 
            // tbPostCode
            // 
            this.tbPostCode.Enabled = false;
            this.tbPostCode.Location = new System.Drawing.Point(347, 352);
            this.tbPostCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPostCode.Name = "tbPostCode";
            this.tbPostCode.Size = new System.Drawing.Size(199, 22);
            this.tbPostCode.TabIndex = 21;
            // 
            // tbStartDate
            // 
            this.tbStartDate.Enabled = false;
            this.tbStartDate.Location = new System.Drawing.Point(285, 392);
            this.tbStartDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbStartDate.Name = "tbStartDate";
            this.tbStartDate.Size = new System.Drawing.Size(85, 22);
            this.tbStartDate.TabIndex = 22;
            // 
            // tbEndDate
            // 
            this.tbEndDate.Enabled = false;
            this.tbEndDate.Location = new System.Drawing.Point(457, 392);
            this.tbEndDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbEndDate.Name = "tbEndDate";
            this.tbEndDate.Size = new System.Drawing.Size(85, 22);
            this.tbEndDate.TabIndex = 23;
            // 
            // lStartDate
            // 
            this.lStartDate.AutoSize = true;
            this.lStartDate.Location = new System.Drawing.Point(204, 396);
            this.lStartDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lStartDate.Name = "lStartDate";
            this.lStartDate.Size = new System.Drawing.Size(72, 17);
            this.lStartDate.TabIndex = 24;
            this.lStartDate.Text = "Start Date";
            // 
            // lEndDate
            // 
            this.lEndDate.AutoSize = true;
            this.lEndDate.Location = new System.Drawing.Point(380, 396);
            this.lEndDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lEndDate.Name = "lEndDate";
            this.lEndDate.Size = new System.Drawing.Size(67, 17);
            this.lEndDate.TabIndex = 25;
            this.lEndDate.Text = "End Date";
            // 
            // tbMiddleName
            // 
            this.tbMiddleName.Enabled = false;
            this.tbMiddleName.Location = new System.Drawing.Point(347, 95);
            this.tbMiddleName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbMiddleName.Name = "tbMiddleName";
            this.tbMiddleName.Size = new System.Drawing.Size(199, 22);
            this.tbMiddleName.TabIndex = 26;
            // 
            // lMiddleName
            // 
            this.lMiddleName.AutoSize = true;
            this.lMiddleName.Location = new System.Drawing.Point(248, 98);
            this.lMiddleName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lMiddleName.Name = "lMiddleName";
            this.lMiddleName.Size = new System.Drawing.Size(90, 17);
            this.lMiddleName.TabIndex = 27;
            this.lMiddleName.Text = "Middle Name";
            // 
            // fEmployeesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 437);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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

