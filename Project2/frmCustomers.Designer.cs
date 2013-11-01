namespace Project2
{
    partial class frmCustomers
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
            this.txtFax = new System.Windows.Forms.TextBox();
            this.lblFax = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.pnlCustomerInfoTop = new System.Windows.Forms.Panel();
            this.lblCustomerInfro = new System.Windows.Forms.Label();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.pnlCustomerInfoFill = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.lblContactName = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.txtRegion = new System.Windows.Forms.TextBox();
            this.txtContactName = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblPostalCode = new System.Windows.Forms.Label();
            this.lblContactTitle = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtContactTitle = new System.Windows.Forms.TextBox();
            this.lblRegion = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblWarningMessage = new System.Windows.Forms.Label();
            this.pnlCustomerInfoTop.SuspendLayout();
            this.pnlCustomerInfoFill.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(582, 260);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(132, 20);
            this.txtFax.TabIndex = 11;
            // 
            // lblFax
            // 
            this.lblFax.AutoSize = true;
            this.lblFax.Location = new System.Drawing.Point(488, 263);
            this.lblFax.Name = "lblFax";
            this.lblFax.Size = new System.Drawing.Size(24, 13);
            this.lblFax.TabIndex = 10;
            this.lblFax.Text = "Fax";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(582, 224);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(132, 20);
            this.txtPhone.TabIndex = 10;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(582, 182);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(159, 20);
            this.txtCountry.TabIndex = 9;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(488, 227);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(38, 13);
            this.lblPhone.TabIndex = 9;
            this.lblPhone.Text = "Phone";
            // 
            // pnlCustomerInfoTop
            // 
            this.pnlCustomerInfoTop.Controls.Add(this.lblCustomerInfro);
            this.pnlCustomerInfoTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCustomerInfoTop.Location = new System.Drawing.Point(0, 0);
            this.pnlCustomerInfoTop.Name = "pnlCustomerInfoTop";
            this.pnlCustomerInfoTop.Size = new System.Drawing.Size(782, 49);
            this.pnlCustomerInfoTop.TabIndex = 26;
            // 
            // lblCustomerInfro
            // 
            this.lblCustomerInfro.AutoSize = true;
            this.lblCustomerInfro.Location = new System.Drawing.Point(160, 20);
            this.lblCustomerInfro.Name = "lblCustomerInfro";
            this.lblCustomerInfro.Size = new System.Drawing.Size(106, 13);
            this.lblCustomerInfro.TabIndex = 0;
            this.lblCustomerInfro.Text = "Customer Infromation";
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(12, 70);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(62, 13);
            this.lblCustomerID.TabIndex = 0;
            this.lblCustomerID.Text = "CustomerID";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(106, 67);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(276, 20);
            this.txtCustomerID.TabIndex = 1;
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Location = new System.Drawing.Point(12, 108);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(79, 13);
            this.lblCompanyName.TabIndex = 1;
            this.lblCompanyName.Text = "CompanyName";
            // 
            // pnlCustomerInfoFill
            // 
            this.pnlCustomerInfoFill.Controls.Add(this.lblWarningMessage);
            this.pnlCustomerInfoFill.Controls.Add(this.panel2);
            this.pnlCustomerInfoFill.Controls.Add(this.lblCustomerID);
            this.pnlCustomerInfoFill.Controls.Add(this.txtFax);
            this.pnlCustomerInfoFill.Controls.Add(this.txtCustomerID);
            this.pnlCustomerInfoFill.Controls.Add(this.lblFax);
            this.pnlCustomerInfoFill.Controls.Add(this.txtPhone);
            this.pnlCustomerInfoFill.Controls.Add(this.lblCompanyName);
            this.pnlCustomerInfoFill.Controls.Add(this.txtCountry);
            this.pnlCustomerInfoFill.Controls.Add(this.lblPhone);
            this.pnlCustomerInfoFill.Controls.Add(this.txtCompanyName);
            this.pnlCustomerInfoFill.Controls.Add(this.txtPostalCode);
            this.pnlCustomerInfoFill.Controls.Add(this.lblContactName);
            this.pnlCustomerInfoFill.Controls.Add(this.lblCountry);
            this.pnlCustomerInfoFill.Controls.Add(this.txtRegion);
            this.pnlCustomerInfoFill.Controls.Add(this.txtContactName);
            this.pnlCustomerInfoFill.Controls.Add(this.txtCity);
            this.pnlCustomerInfoFill.Controls.Add(this.lblPostalCode);
            this.pnlCustomerInfoFill.Controls.Add(this.lblContactTitle);
            this.pnlCustomerInfoFill.Controls.Add(this.txtAddress);
            this.pnlCustomerInfoFill.Controls.Add(this.txtContactTitle);
            this.pnlCustomerInfoFill.Controls.Add(this.lblRegion);
            this.pnlCustomerInfoFill.Controls.Add(this.lblAddress);
            this.pnlCustomerInfoFill.Controls.Add(this.lblCity);
            this.pnlCustomerInfoFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCustomerInfoFill.Location = new System.Drawing.Point(0, 0);
            this.pnlCustomerInfoFill.Name = "pnlCustomerInfoFill";
            this.pnlCustomerInfoFill.Size = new System.Drawing.Size(782, 398);
            this.pnlCustomerInfoFill.TabIndex = 25;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnReturn);
            this.panel2.Controls.Add(this.btnInsert);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Location = new System.Drawing.Point(106, 324);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(431, 62);
            this.panel2.TabIndex = 12;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(46, 30);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 12;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(298, 30);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 14;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(173, 30);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(106, 105);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(224, 20);
            this.txtCompanyName.TabIndex = 2;
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(582, 143);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(159, 20);
            this.txtPostalCode.TabIndex = 8;
            // 
            // lblContactName
            // 
            this.lblContactName.AutoSize = true;
            this.lblContactName.Location = new System.Drawing.Point(13, 142);
            this.lblContactName.Name = "lblContactName";
            this.lblContactName.Size = new System.Drawing.Size(72, 13);
            this.lblContactName.TabIndex = 2;
            this.lblContactName.Text = "ContactName";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(488, 185);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(43, 13);
            this.lblCountry.TabIndex = 8;
            this.lblCountry.Text = "Country";
            // 
            // txtRegion
            // 
            this.txtRegion.Location = new System.Drawing.Point(579, 105);
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Size = new System.Drawing.Size(159, 20);
            this.txtRegion.TabIndex = 7;
            // 
            // txtContactName
            // 
            this.txtContactName.Location = new System.Drawing.Point(107, 139);
            this.txtContactName.Name = "txtContactName";
            this.txtContactName.Size = new System.Drawing.Size(224, 20);
            this.txtContactName.TabIndex = 3;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(107, 253);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(159, 20);
            this.txtCity.TabIndex = 6;
            // 
            // lblPostalCode
            // 
            this.lblPostalCode.AutoSize = true;
            this.lblPostalCode.Location = new System.Drawing.Point(488, 146);
            this.lblPostalCode.Name = "lblPostalCode";
            this.lblPostalCode.Size = new System.Drawing.Size(61, 13);
            this.lblPostalCode.TabIndex = 7;
            this.lblPostalCode.Text = "PostalCode";
            // 
            // lblContactTitle
            // 
            this.lblContactTitle.AutoSize = true;
            this.lblContactTitle.Location = new System.Drawing.Point(13, 183);
            this.lblContactTitle.Name = "lblContactTitle";
            this.lblContactTitle.Size = new System.Drawing.Size(64, 13);
            this.lblContactTitle.TabIndex = 3;
            this.lblContactTitle.Text = "ContactTitle";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(107, 218);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(295, 20);
            this.txtAddress.TabIndex = 5;
            // 
            // txtContactTitle
            // 
            this.txtContactTitle.Location = new System.Drawing.Point(107, 180);
            this.txtContactTitle.Name = "txtContactTitle";
            this.txtContactTitle.Size = new System.Drawing.Size(224, 20);
            this.txtContactTitle.TabIndex = 4;
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Location = new System.Drawing.Point(485, 108);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(41, 13);
            this.lblRegion.TabIndex = 6;
            this.lblRegion.Text = "Region";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(13, 221);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "Address";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(13, 256);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 5;
            this.lblCity.Text = "City";
            // 
            // lblWarningMessage
            // 
            this.lblWarningMessage.AutoSize = true;
            this.lblWarningMessage.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblWarningMessage.Location = new System.Drawing.Point(106, 305);
            this.lblWarningMessage.Name = "lblWarningMessage";
            this.lblWarningMessage.Size = new System.Drawing.Size(0, 13);
            this.lblWarningMessage.TabIndex = 13;
            // 
            // frmCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 398);
            this.Controls.Add(this.pnlCustomerInfoTop);
            this.Controls.Add(this.pnlCustomerInfoFill);
            this.Name = "frmCustomers";
            this.Text = "frmCustomers";
            this.Load += new System.EventHandler(this.frmCustomers_Load);
            this.pnlCustomerInfoTop.ResumeLayout(false);
            this.pnlCustomerInfoTop.PerformLayout();
            this.pnlCustomerInfoFill.ResumeLayout(false);
            this.pnlCustomerInfoFill.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.Label lblFax;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Panel pnlCustomerInfoTop;
        private System.Windows.Forms.Label lblCustomerInfro;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Panel pnlCustomerInfoFill;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.Label lblContactName;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.TextBox txtRegion;
        private System.Windows.Forms.TextBox txtContactName;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblPostalCode;
        private System.Windows.Forms.Label lblContactTitle;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtContactTitle;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblWarningMessage;

    }
}