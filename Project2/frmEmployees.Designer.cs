namespace Project2
{
    partial class frmEmployees
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
            this.txtReportsTo = new System.Windows.Forms.TextBox();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtHomePhone = new System.Windows.Forms.TextBox();
            this.txtExtension = new System.Windows.Forms.TextBox();
            this.txtRegion = new System.Windows.Forms.TextBox();
            this.pnlEmployeeFill = new System.Windows.Forms.Panel();
            this.lblWarningMessage = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.txtPhoto = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtTitleOfCourtesy = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.lblPhoto = new System.Windows.Forms.Label();
            this.lblExtension = new System.Windows.Forms.Label();
            this.lblHomePhone = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblPostalCode = new System.Windows.Forms.Label();
            this.lblReportsTo = new System.Windows.Forms.Label();
            this.lblRegion = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblTitleOfCourtesy = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.dtpHireDate = new System.Windows.Forms.DateTimePicker();
            this.lblHireDate = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblEmployeeInfor = new System.Windows.Forms.Label();
            this.pnlEmployeeInforTop = new System.Windows.Forms.Panel();
            this.pnlEmployeeFill.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlEmployeeInforTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtReportsTo
            // 
            this.txtReportsTo.Location = new System.Drawing.Point(429, 171);
            this.txtReportsTo.Name = "txtReportsTo";
            this.txtReportsTo.Size = new System.Drawing.Size(225, 20);
            this.txtReportsTo.TabIndex = 16;
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(104, 339);
            this.txtPostalCode.MaxLength = 10;
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(146, 20);
            this.txtPostalCode.TabIndex = 10;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(429, 13);
            this.txtCountry.MaxLength = 15;
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(165, 20);
            this.txtCountry.TabIndex = 11;
            // 
            // txtHomePhone
            // 
            this.txtHomePhone.Location = new System.Drawing.Point(429, 46);
            this.txtHomePhone.MaxLength = 24;
            this.txtHomePhone.Name = "txtHomePhone";
            this.txtHomePhone.Size = new System.Drawing.Size(165, 20);
            this.txtHomePhone.TabIndex = 12;
            // 
            // txtExtension
            // 
            this.txtExtension.Location = new System.Drawing.Point(429, 73);
            this.txtExtension.MaxLength = 4;
            this.txtExtension.Name = "txtExtension";
            this.txtExtension.Size = new System.Drawing.Size(130, 20);
            this.txtExtension.TabIndex = 13;
            // 
            // txtRegion
            // 
            this.txtRegion.Location = new System.Drawing.Point(104, 305);
            this.txtRegion.MaxLength = 15;
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Size = new System.Drawing.Size(146, 20);
            this.txtRegion.TabIndex = 9;
            // 
            // pnlEmployeeFill
            // 
            this.pnlEmployeeFill.Controls.Add(this.lblWarningMessage);
            this.pnlEmployeeFill.Controls.Add(this.panel2);
            this.pnlEmployeeFill.Controls.Add(this.txtNotes);
            this.pnlEmployeeFill.Controls.Add(this.txtReportsTo);
            this.pnlEmployeeFill.Controls.Add(this.txtPostalCode);
            this.pnlEmployeeFill.Controls.Add(this.txtCountry);
            this.pnlEmployeeFill.Controls.Add(this.txtHomePhone);
            this.pnlEmployeeFill.Controls.Add(this.txtExtension);
            this.pnlEmployeeFill.Controls.Add(this.txtRegion);
            this.pnlEmployeeFill.Controls.Add(this.txtPhoto);
            this.pnlEmployeeFill.Controls.Add(this.txtCity);
            this.pnlEmployeeFill.Controls.Add(this.txtAddress);
            this.pnlEmployeeFill.Controls.Add(this.txtTitleOfCourtesy);
            this.pnlEmployeeFill.Controls.Add(this.txtTitle);
            this.pnlEmployeeFill.Controls.Add(this.txtFirstName);
            this.pnlEmployeeFill.Controls.Add(this.txtLastName);
            this.pnlEmployeeFill.Controls.Add(this.lblNotes);
            this.pnlEmployeeFill.Controls.Add(this.lblPhoto);
            this.pnlEmployeeFill.Controls.Add(this.lblExtension);
            this.pnlEmployeeFill.Controls.Add(this.lblHomePhone);
            this.pnlEmployeeFill.Controls.Add(this.lblCountry);
            this.pnlEmployeeFill.Controls.Add(this.lblPostalCode);
            this.pnlEmployeeFill.Controls.Add(this.lblReportsTo);
            this.pnlEmployeeFill.Controls.Add(this.lblRegion);
            this.pnlEmployeeFill.Controls.Add(this.lblCity);
            this.pnlEmployeeFill.Controls.Add(this.lblAddress);
            this.pnlEmployeeFill.Controls.Add(this.lblTitleOfCourtesy);
            this.pnlEmployeeFill.Controls.Add(this.lblTitle);
            this.pnlEmployeeFill.Controls.Add(this.lblFirstName);
            this.pnlEmployeeFill.Controls.Add(this.lblLastName);
            this.pnlEmployeeFill.Controls.Add(this.lblEmployeeID);
            this.pnlEmployeeFill.Controls.Add(this.txtEmployeeID);
            this.pnlEmployeeFill.Controls.Add(this.dtpBirthDate);
            this.pnlEmployeeFill.Controls.Add(this.dtpHireDate);
            this.pnlEmployeeFill.Controls.Add(this.lblHireDate);
            this.pnlEmployeeFill.Controls.Add(this.lblBirthDate);
            this.pnlEmployeeFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEmployeeFill.Location = new System.Drawing.Point(0, 39);
            this.pnlEmployeeFill.Name = "pnlEmployeeFill";
            this.pnlEmployeeFill.Size = new System.Drawing.Size(690, 387);
            this.pnlEmployeeFill.TabIndex = 13;
            // 
            // lblWarningMessage
            // 
            this.lblWarningMessage.AutoSize = true;
            this.lblWarningMessage.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblWarningMessage.Location = new System.Drawing.Point(355, 275);
            this.lblWarningMessage.Name = "lblWarningMessage";
            this.lblWarningMessage.Size = new System.Drawing.Size(0, 13);
            this.lblWarningMessage.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnReturn);
            this.panel2.Controls.Add(this.btnInsert);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Location = new System.Drawing.Point(301, 290);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(373, 69);
            this.panel2.TabIndex = 23;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(54, 30);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 6;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(266, 30);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 7;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(161, 30);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(429, 135);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(225, 20);
            this.txtNotes.TabIndex = 16;
            // 
            // txtPhoto
            // 
            this.txtPhoto.Location = new System.Drawing.Point(429, 104);
            this.txtPhoto.MaxLength = 255;
            this.txtPhoto.Name = "txtPhoto";
            this.txtPhoto.Size = new System.Drawing.Size(225, 20);
            this.txtPhoto.TabIndex = 14;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(104, 268);
            this.txtCity.MaxLength = 15;
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(146, 20);
            this.txtCity.TabIndex = 8;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(104, 235);
            this.txtAddress.MaxLength = 60;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(229, 20);
            this.txtAddress.TabIndex = 7;
            // 
            // txtTitleOfCourtesy
            // 
            this.txtTitleOfCourtesy.Location = new System.Drawing.Point(104, 135);
            this.txtTitleOfCourtesy.MaxLength = 25;
            this.txtTitleOfCourtesy.Name = "txtTitleOfCourtesy";
            this.txtTitleOfCourtesy.Size = new System.Drawing.Size(146, 20);
            this.txtTitleOfCourtesy.TabIndex = 4;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(104, 104);
            this.txtTitle.MaxLength = 30;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(146, 20);
            this.txtTitle.TabIndex = 3;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(104, 73);
            this.txtFirstName.MaxLength = 10;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(133, 20);
            this.txtFirstName.TabIndex = 2;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(104, 43);
            this.txtLastName.MaxLength = 20;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(160, 20);
            this.txtLastName.TabIndex = 1;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(352, 138);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(35, 13);
            this.lblNotes.TabIndex = 22;
            this.lblNotes.Text = "Notes";
            // 
            // lblPhoto
            // 
            this.lblPhoto.AutoSize = true;
            this.lblPhoto.Location = new System.Drawing.Point(352, 107);
            this.lblPhoto.Name = "lblPhoto";
            this.lblPhoto.Size = new System.Drawing.Size(35, 13);
            this.lblPhoto.TabIndex = 21;
            this.lblPhoto.Text = "Photo";
            // 
            // lblExtension
            // 
            this.lblExtension.AutoSize = true;
            this.lblExtension.Location = new System.Drawing.Point(352, 76);
            this.lblExtension.Name = "lblExtension";
            this.lblExtension.Size = new System.Drawing.Size(53, 13);
            this.lblExtension.TabIndex = 20;
            this.lblExtension.Text = "Extension";
            // 
            // lblHomePhone
            // 
            this.lblHomePhone.AutoSize = true;
            this.lblHomePhone.Location = new System.Drawing.Point(352, 46);
            this.lblHomePhone.Name = "lblHomePhone";
            this.lblHomePhone.Size = new System.Drawing.Size(66, 13);
            this.lblHomePhone.TabIndex = 19;
            this.lblHomePhone.Text = "HomePhone";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(352, 16);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(43, 13);
            this.lblCountry.TabIndex = 18;
            this.lblCountry.Text = "Country";
            // 
            // lblPostalCode
            // 
            this.lblPostalCode.AutoSize = true;
            this.lblPostalCode.Location = new System.Drawing.Point(13, 342);
            this.lblPostalCode.Name = "lblPostalCode";
            this.lblPostalCode.Size = new System.Drawing.Size(61, 13);
            this.lblPostalCode.TabIndex = 17;
            this.lblPostalCode.Text = "PostalCode";
            // 
            // lblReportsTo
            // 
            this.lblReportsTo.AutoSize = true;
            this.lblReportsTo.Location = new System.Drawing.Point(352, 171);
            this.lblReportsTo.Name = "lblReportsTo";
            this.lblReportsTo.Size = new System.Drawing.Size(57, 13);
            this.lblReportsTo.TabIndex = 16;
            this.lblReportsTo.Text = "ReportsTo";
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Location = new System.Drawing.Point(13, 308);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(41, 13);
            this.lblRegion.TabIndex = 15;
            this.lblRegion.Text = "Region";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(13, 271);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 14;
            this.lblCity.Text = "City";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(13, 238);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 13;
            this.lblAddress.Text = "Address";
            // 
            // lblTitleOfCourtesy
            // 
            this.lblTitleOfCourtesy.AutoSize = true;
            this.lblTitleOfCourtesy.Location = new System.Drawing.Point(13, 138);
            this.lblTitleOfCourtesy.Name = "lblTitleOfCourtesy";
            this.lblTitleOfCourtesy.Size = new System.Drawing.Size(79, 13);
            this.lblTitleOfCourtesy.TabIndex = 12;
            this.lblTitleOfCourtesy.Text = "TitleOfCourtesy";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(13, 107);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "Title";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(13, 76);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(54, 13);
            this.lblFirstName.TabIndex = 10;
            this.lblFirstName.Text = "FirstName";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(13, 46);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(55, 13);
            this.lblLastName.TabIndex = 9;
            this.lblLastName.Text = "LastName";
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Location = new System.Drawing.Point(13, 16);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(67, 13);
            this.lblEmployeeID.TabIndex = 7;
            this.lblEmployeeID.Text = "Employee ID";
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Enabled = false;
            this.txtEmployeeID.Location = new System.Drawing.Point(104, 13);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.ReadOnly = true;
            this.txtEmployeeID.Size = new System.Drawing.Size(160, 20);
            this.txtEmployeeID.TabIndex = 0;
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Location = new System.Drawing.Point(104, 165);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(200, 20);
            this.dtpBirthDate.TabIndex = 5;
            // 
            // dtpHireDate
            // 
            this.dtpHireDate.Location = new System.Drawing.Point(104, 199);
            this.dtpHireDate.Name = "dtpHireDate";
            this.dtpHireDate.Size = new System.Drawing.Size(200, 20);
            this.dtpHireDate.TabIndex = 6;
            // 
            // lblHireDate
            // 
            this.lblHireDate.AutoSize = true;
            this.lblHireDate.Location = new System.Drawing.Point(13, 205);
            this.lblHireDate.Name = "lblHireDate";
            this.lblHireDate.Size = new System.Drawing.Size(52, 13);
            this.lblHireDate.TabIndex = 5;
            this.lblHireDate.Text = "Hire Date";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(13, 171);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(54, 13);
            this.lblBirthDate.TabIndex = 5;
            this.lblBirthDate.Text = "Birth Date";
            // 
            // lblEmployeeInfor
            // 
            this.lblEmployeeInfor.AutoSize = true;
            this.lblEmployeeInfor.Location = new System.Drawing.Point(247, 9);
            this.lblEmployeeInfor.Name = "lblEmployeeInfor";
            this.lblEmployeeInfor.Size = new System.Drawing.Size(108, 13);
            this.lblEmployeeInfor.TabIndex = 0;
            this.lblEmployeeInfor.Text = "Employee Information";
            // 
            // pnlEmployeeInforTop
            // 
            this.pnlEmployeeInforTop.Controls.Add(this.lblEmployeeInfor);
            this.pnlEmployeeInforTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEmployeeInforTop.Location = new System.Drawing.Point(0, 0);
            this.pnlEmployeeInforTop.Name = "pnlEmployeeInforTop";
            this.pnlEmployeeInforTop.Size = new System.Drawing.Size(690, 39);
            this.pnlEmployeeInforTop.TabIndex = 12;
            // 
            // frmEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 426);
            this.Controls.Add(this.pnlEmployeeFill);
            this.Controls.Add(this.pnlEmployeeInforTop);
            this.Name = "frmEmployees";
            this.Text = "frmEmployees";
            this.Load += new System.EventHandler(this.frmEmployees_Load);
            this.pnlEmployeeFill.ResumeLayout(false);
            this.pnlEmployeeFill.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pnlEmployeeInforTop.ResumeLayout(false);
            this.pnlEmployeeInforTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtReportsTo;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtHomePhone;
        private System.Windows.Forms.TextBox txtExtension;
        private System.Windows.Forms.TextBox txtRegion;
        private System.Windows.Forms.Panel pnlEmployeeFill;
        private System.Windows.Forms.TextBox txtPhoto;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtTitleOfCourtesy;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Label lblPhoto;
        private System.Windows.Forms.Label lblExtension;
        private System.Windows.Forms.Label lblHomePhone;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblPostalCode;
        private System.Windows.Forms.Label lblReportsTo;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblTitleOfCourtesy;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.DateTimePicker dtpHireDate;
        private System.Windows.Forms.Label lblHireDate;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Label lblEmployeeInfor;
        private System.Windows.Forms.Panel pnlEmployeeInforTop;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label lblWarningMessage;

    }
}