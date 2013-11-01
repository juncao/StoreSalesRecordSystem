namespace Project2
{
    partial class frmProducts
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblProductsInfor = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbCategoryIDs = new System.Windows.Forms.ComboBox();
            this.cmbSupplierIDs = new System.Windows.Forms.ComboBox();
            this.cklDiscontinued = new System.Windows.Forms.CheckBox();
            this.txtReorderLevel = new System.Windows.Forms.TextBox();
            this.txtUnitsOnOrder = new System.Windows.Forms.TextBox();
            this.txtUnitsInStock = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtQuantityPerUnit = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.lblDiscontinued = new System.Windows.Forms.Label();
            this.lblReorderLevel = new System.Windows.Forms.Label();
            this.lblUnitsOnOrder = new System.Windows.Forms.Label();
            this.lblUnitsInStock = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblQuantityPerUnit = new System.Windows.Forms.Label();
            this.lblCategoryID = new System.Windows.Forms.Label();
            this.lblSupplierID = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProductID = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblWarningMessage = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblProductsInfor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 53);
            this.panel1.TabIndex = 0;
            // 
            // lblProductsInfor
            // 
            this.lblProductsInfor.AutoSize = true;
            this.lblProductsInfor.Location = new System.Drawing.Point(142, 19);
            this.lblProductsInfor.Name = "lblProductsInfor";
            this.lblProductsInfor.Size = new System.Drawing.Size(99, 13);
            this.lblProductsInfor.TabIndex = 0;
            this.lblProductsInfor.Text = "Product Information";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblWarningMessage);
            this.panel2.Controls.Add(this.cmbCategoryIDs);
            this.panel2.Controls.Add(this.cmbSupplierIDs);
            this.panel2.Controls.Add(this.cklDiscontinued);
            this.panel2.Controls.Add(this.txtReorderLevel);
            this.panel2.Controls.Add(this.txtUnitsOnOrder);
            this.panel2.Controls.Add(this.txtUnitsInStock);
            this.panel2.Controls.Add(this.txtUnitPrice);
            this.panel2.Controls.Add(this.txtQuantityPerUnit);
            this.panel2.Controls.Add(this.txtProductName);
            this.panel2.Controls.Add(this.txtProductID);
            this.panel2.Controls.Add(this.lblDiscontinued);
            this.panel2.Controls.Add(this.lblReorderLevel);
            this.panel2.Controls.Add(this.lblUnitsOnOrder);
            this.panel2.Controls.Add(this.lblUnitsInStock);
            this.panel2.Controls.Add(this.lblUnitPrice);
            this.panel2.Controls.Add(this.lblQuantityPerUnit);
            this.panel2.Controls.Add(this.lblCategoryID);
            this.panel2.Controls.Add(this.lblSupplierID);
            this.panel2.Controls.Add(this.lblProductName);
            this.panel2.Controls.Add(this.lblProductID);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(374, 434);
            this.panel2.TabIndex = 1;
            // 
            // cmbCategoryIDs
            // 
            this.cmbCategoryIDs.FormattingEnabled = true;
            this.cmbCategoryIDs.Location = new System.Drawing.Point(110, 124);
            this.cmbCategoryIDs.Name = "cmbCategoryIDs";
            this.cmbCategoryIDs.Size = new System.Drawing.Size(121, 21);
            this.cmbCategoryIDs.TabIndex = 13;
            // 
            // cmbSupplierIDs
            // 
            this.cmbSupplierIDs.FormattingEnabled = true;
            this.cmbSupplierIDs.Location = new System.Drawing.Point(110, 83);
            this.cmbSupplierIDs.Name = "cmbSupplierIDs";
            this.cmbSupplierIDs.Size = new System.Drawing.Size(121, 21);
            this.cmbSupplierIDs.TabIndex = 13;
            // 
            // cklDiscontinued
            // 
            this.cklDiscontinued.AutoSize = true;
            this.cklDiscontinued.Location = new System.Drawing.Point(110, 352);
            this.cklDiscontinued.Name = "cklDiscontinued";
            this.cklDiscontinued.Size = new System.Drawing.Size(15, 14);
            this.cklDiscontinued.TabIndex = 9;
            this.cklDiscontinued.UseVisualStyleBackColor = true;
            // 
            // txtReorderLevel
            // 
            this.txtReorderLevel.Location = new System.Drawing.Point(110, 312);
            this.txtReorderLevel.Name = "txtReorderLevel";
            this.txtReorderLevel.Size = new System.Drawing.Size(212, 20);
            this.txtReorderLevel.TabIndex = 8;
            // 
            // txtUnitsOnOrder
            // 
            this.txtUnitsOnOrder.Location = new System.Drawing.Point(110, 275);
            this.txtUnitsOnOrder.Name = "txtUnitsOnOrder";
            this.txtUnitsOnOrder.Size = new System.Drawing.Size(104, 20);
            this.txtUnitsOnOrder.TabIndex = 7;
            // 
            // txtUnitsInStock
            // 
            this.txtUnitsInStock.Location = new System.Drawing.Point(110, 239);
            this.txtUnitsInStock.Name = "txtUnitsInStock";
            this.txtUnitsInStock.Size = new System.Drawing.Size(104, 20);
            this.txtUnitsInStock.TabIndex = 6;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(110, 200);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(104, 20);
            this.txtUnitPrice.TabIndex = 5;
            // 
            // txtQuantityPerUnit
            // 
            this.txtQuantityPerUnit.Location = new System.Drawing.Point(110, 164);
            this.txtQuantityPerUnit.Name = "txtQuantityPerUnit";
            this.txtQuantityPerUnit.Size = new System.Drawing.Size(104, 20);
            this.txtQuantityPerUnit.TabIndex = 4;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(110, 50);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(212, 20);
            this.txtProductName.TabIndex = 1;
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(110, 16);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.ReadOnly = true;
            this.txtProductID.Size = new System.Drawing.Size(194, 20);
            this.txtProductID.TabIndex = 0;
            // 
            // lblDiscontinued
            // 
            this.lblDiscontinued.AutoSize = true;
            this.lblDiscontinued.Location = new System.Drawing.Point(22, 352);
            this.lblDiscontinued.Name = "lblDiscontinued";
            this.lblDiscontinued.Size = new System.Drawing.Size(69, 13);
            this.lblDiscontinued.TabIndex = 12;
            this.lblDiscontinued.Text = "Discontinued";
            // 
            // lblReorderLevel
            // 
            this.lblReorderLevel.AutoSize = true;
            this.lblReorderLevel.Location = new System.Drawing.Point(22, 315);
            this.lblReorderLevel.Name = "lblReorderLevel";
            this.lblReorderLevel.Size = new System.Drawing.Size(71, 13);
            this.lblReorderLevel.TabIndex = 11;
            this.lblReorderLevel.Text = "ReorderLevel";
            // 
            // lblUnitsOnOrder
            // 
            this.lblUnitsOnOrder.AutoSize = true;
            this.lblUnitsOnOrder.Location = new System.Drawing.Point(22, 278);
            this.lblUnitsOnOrder.Name = "lblUnitsOnOrder";
            this.lblUnitsOnOrder.Size = new System.Drawing.Size(71, 13);
            this.lblUnitsOnOrder.TabIndex = 10;
            this.lblUnitsOnOrder.Text = "UnitsOnOrder";
            // 
            // lblUnitsInStock
            // 
            this.lblUnitsInStock.AutoSize = true;
            this.lblUnitsInStock.Location = new System.Drawing.Point(22, 242);
            this.lblUnitsInStock.Name = "lblUnitsInStock";
            this.lblUnitsInStock.Size = new System.Drawing.Size(68, 13);
            this.lblUnitsInStock.TabIndex = 9;
            this.lblUnitsInStock.Text = "UnitsInStock";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(22, 203);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(50, 13);
            this.lblUnitPrice.TabIndex = 8;
            this.lblUnitPrice.Text = "UnitPrice";
            // 
            // lblQuantityPerUnit
            // 
            this.lblQuantityPerUnit.AutoSize = true;
            this.lblQuantityPerUnit.Location = new System.Drawing.Point(22, 167);
            this.lblQuantityPerUnit.Name = "lblQuantityPerUnit";
            this.lblQuantityPerUnit.Size = new System.Drawing.Size(81, 13);
            this.lblQuantityPerUnit.TabIndex = 7;
            this.lblQuantityPerUnit.Text = "QuantityPerUnit";
            // 
            // lblCategoryID
            // 
            this.lblCategoryID.AutoSize = true;
            this.lblCategoryID.Location = new System.Drawing.Point(22, 127);
            this.lblCategoryID.Name = "lblCategoryID";
            this.lblCategoryID.Size = new System.Drawing.Size(60, 13);
            this.lblCategoryID.TabIndex = 6;
            this.lblCategoryID.Text = "CategoryID";
            // 
            // lblSupplierID
            // 
            this.lblSupplierID.AutoSize = true;
            this.lblSupplierID.Location = new System.Drawing.Point(22, 91);
            this.lblSupplierID.Name = "lblSupplierID";
            this.lblSupplierID.Size = new System.Drawing.Size(56, 13);
            this.lblSupplierID.TabIndex = 5;
            this.lblSupplierID.Text = "SupplierID";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(22, 53);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(72, 13);
            this.lblProductName.TabIndex = 4;
            this.lblProductName.Text = "ProductName";
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Location = new System.Drawing.Point(22, 19);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(55, 13);
            this.lblProductID.TabIndex = 3;
            this.lblProductID.Text = "ProductID";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnReturn);
            this.panel3.Controls.Add(this.btnInsert);
            this.panel3.Controls.Add(this.btnUpdate);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 399);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(374, 35);
            this.panel3.TabIndex = 2;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(25, 3);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 9;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Enabled = false;
            this.btnInsert.Location = new System.Drawing.Point(247, 5);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 10;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(139, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblWarningMessage
            // 
            this.lblWarningMessage.AutoSize = true;
            this.lblWarningMessage.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblWarningMessage.Location = new System.Drawing.Point(55, 383);
            this.lblWarningMessage.Name = "lblWarningMessage";
            this.lblWarningMessage.Size = new System.Drawing.Size(0, 13);
            this.lblWarningMessage.TabIndex = 14;
            // 
            // frmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 487);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmProducts";
            this.Text = "frmProducts";
            this.Load += new System.EventHandler(this.frmProducts_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblProductsInfor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox cklDiscontinued;
        private System.Windows.Forms.TextBox txtReorderLevel;
        private System.Windows.Forms.TextBox txtUnitsOnOrder;
        private System.Windows.Forms.TextBox txtUnitsInStock;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtQuantityPerUnit;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label lblDiscontinued;
        private System.Windows.Forms.Label lblReorderLevel;
        private System.Windows.Forms.Label lblUnitsOnOrder;
        private System.Windows.Forms.Label lblUnitsInStock;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblQuantityPerUnit;
        private System.Windows.Forms.Label lblCategoryID;
        private System.Windows.Forms.Label lblSupplierID;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cmbCategoryIDs;
        private System.Windows.Forms.ComboBox cmbSupplierIDs;
        private System.Windows.Forms.Label lblWarningMessage;
    }
}