namespace Project2
{
    partial class frmOrderDetails
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
            this.pnlOrderDetailTop = new System.Windows.Forms.Panel();
            this.pnlOrderDetailFill = new System.Windows.Forms.Panel();
            this.pnlOrderDetailButton = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.lblProductID = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.pnlOrderDetailTop.SuspendLayout();
            this.pnlOrderDetailFill.SuspendLayout();
            this.pnlOrderDetailButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOrderDetailTop
            // 
            this.pnlOrderDetailTop.Controls.Add(this.label1);
            this.pnlOrderDetailTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOrderDetailTop.Location = new System.Drawing.Point(0, 0);
            this.pnlOrderDetailTop.Name = "pnlOrderDetailTop";
            this.pnlOrderDetailTop.Size = new System.Drawing.Size(321, 51);
            this.pnlOrderDetailTop.TabIndex = 0;
            // 
            // pnlOrderDetailFill
            // 
            this.pnlOrderDetailFill.Controls.Add(this.txtDiscount);
            this.pnlOrderDetailFill.Controls.Add(this.txtQuantity);
            this.pnlOrderDetailFill.Controls.Add(this.txtUnitPrice);
            this.pnlOrderDetailFill.Controls.Add(this.txtProductID);
            this.pnlOrderDetailFill.Controls.Add(this.txtOrderID);
            this.pnlOrderDetailFill.Controls.Add(this.lblDiscount);
            this.pnlOrderDetailFill.Controls.Add(this.lblQuantity);
            this.pnlOrderDetailFill.Controls.Add(this.lblUnitPrice);
            this.pnlOrderDetailFill.Controls.Add(this.lblProductID);
            this.pnlOrderDetailFill.Controls.Add(this.lblOrderID);
            this.pnlOrderDetailFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOrderDetailFill.Location = new System.Drawing.Point(0, 51);
            this.pnlOrderDetailFill.Name = "pnlOrderDetailFill";
            this.pnlOrderDetailFill.Size = new System.Drawing.Size(321, 297);
            this.pnlOrderDetailFill.TabIndex = 1;
            // 
            // pnlOrderDetailButton
            // 
            this.pnlOrderDetailButton.Controls.Add(this.btnSubmit);
            this.pnlOrderDetailButton.Controls.Add(this.btnCancel);
            this.pnlOrderDetailButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlOrderDetailButton.Location = new System.Drawing.Point(0, 290);
            this.pnlOrderDetailButton.Name = "pnlOrderDetailButton";
            this.pnlOrderDetailButton.Size = new System.Drawing.Size(321, 58);
            this.pnlOrderDetailButton.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Location = new System.Drawing.Point(36, 24);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(47, 13);
            this.lblOrderID.TabIndex = 0;
            this.lblOrderID.Text = "Order ID";
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Location = new System.Drawing.Point(36, 66);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(58, 13);
            this.lblProductID.TabIndex = 1;
            this.lblProductID.Text = "Product ID";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(36, 107);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(53, 13);
            this.lblUnitPrice.TabIndex = 2;
            this.lblUnitPrice.Text = "Unit Price";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(36, 150);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(46, 13);
            this.lblQuantity.TabIndex = 3;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(36, 195);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(49, 13);
            this.lblDiscount.TabIndex = 4;
            this.lblDiscount.Text = "Discount";
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(121, 21);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(162, 20);
            this.txtOrderID.TabIndex = 0;
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(121, 63);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(162, 20);
            this.txtProductID.TabIndex = 1;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(121, 104);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(100, 20);
            this.txtUnitPrice.TabIndex = 2;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(121, 147);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtQuantity.TabIndex = 3;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(121, 192);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(100, 20);
            this.txtDiscount.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(53, 20);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(198, 20);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // frmOrderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 348);
            this.Controls.Add(this.pnlOrderDetailButton);
            this.Controls.Add(this.pnlOrderDetailFill);
            this.Controls.Add(this.pnlOrderDetailTop);
            this.Name = "frmOrderDetails";
            this.Text = "frmOrderDetails";
            this.pnlOrderDetailTop.ResumeLayout(false);
            this.pnlOrderDetailTop.PerformLayout();
            this.pnlOrderDetailFill.ResumeLayout(false);
            this.pnlOrderDetailFill.PerformLayout();
            this.pnlOrderDetailButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOrderDetailTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlOrderDetailFill;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.Panel pnlOrderDetailButton;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
    }
}