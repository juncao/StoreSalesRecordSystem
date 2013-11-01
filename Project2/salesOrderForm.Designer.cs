namespace Project2
{
    partial class salesOrderForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(salesOrderForm));
            this.btnCancel = new System.Windows.Forms.Button();
            this.salesList = new System.Windows.Forms.DataGridView();
            this.product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.lblTotalPriceLabel = new System.Windows.Forms.Label();
            this.btnComplete = new System.Windows.Forms.Button();
            this.pnlFill = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblClientName = new System.Windows.Forms.Label();
            this.lblCatalogLabel = new System.Windows.Forms.Label();
            this.cmbCustomerID = new System.Windows.Forms.ComboBox();
            this.cmbCustomerName = new System.Windows.Forms.ComboBox();
            this.btnCatalog = new System.Windows.Forms.Button();
            this.lblClerkLabel = new System.Windows.Forms.Label();
            this.cmbClerkName = new System.Windows.Forms.ComboBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.pnlBottom = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.salesList)).BeginInit();
            this.pnlFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(425, 46);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // salesList
            // 
            this.salesList.AllowDrop = true;
            this.salesList.AllowUserToAddRows = false;
            this.salesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.product,
            this.productName,
            this.productPrice,
            this.quantity,
            this.linePrice});
            this.salesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salesList.Location = new System.Drawing.Point(0, 0);
            this.salesList.Name = "salesList";
            this.salesList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.salesList.Size = new System.Drawing.Size(569, 182);
            this.salesList.TabIndex = 8;
            // 
            // product
            // 
            this.product.HeaderText = "Product ID";
            this.product.Name = "product";
            this.product.ReadOnly = true;
            // 
            // productName
            // 
            this.productName.HeaderText = "Product Name";
            this.productName.Name = "productName";
            this.productName.ReadOnly = true;
            // 
            // productPrice
            // 
            this.productPrice.HeaderText = "Unit Price";
            this.productPrice.Name = "productPrice";
            this.productPrice.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Order Quantity";
            this.quantity.Name = "quantity";
            // 
            // linePrice
            // 
            this.linePrice.HeaderText = "Line Price";
            this.linePrice.Name = "linePrice";
            this.linePrice.ReadOnly = true;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(425, 13);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(100, 20);
            this.txtTotalPrice.TabIndex = 11;
            // 
            // lblTotalPriceLabel
            // 
            this.lblTotalPriceLabel.AutoSize = true;
            this.lblTotalPriceLabel.Location = new System.Drawing.Point(320, 16);
            this.lblTotalPriceLabel.Name = "lblTotalPriceLabel";
            this.lblTotalPriceLabel.Size = new System.Drawing.Size(58, 13);
            this.lblTotalPriceLabel.TabIndex = 12;
            this.lblTotalPriceLabel.Text = "Total Price";
            // 
            // btnComplete
            // 
            this.btnComplete.Location = new System.Drawing.Point(323, 46);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(75, 23);
            this.btnComplete.TabIndex = 9;
            this.btnComplete.Text = "Complete";
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // pnlFill
            // 
            this.pnlFill.Controls.Add(this.salesList);
            this.pnlFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFill.Location = new System.Drawing.Point(0, 125);
            this.pnlFill.Name = "pnlFill";
            this.pnlFill.Size = new System.Drawing.Size(569, 182);
            this.pnlFill.TabIndex = 18;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(0, 3);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(544, 70);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 14;
            this.pictureBoxLogo.TabStop = false;
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.pictureBoxLogo);
            this.pnlTop.Controls.Add(this.lblClientName);
            this.pnlTop.Controls.Add(this.lblCatalogLabel);
            this.pnlTop.Controls.Add(this.cmbCustomerID);
            this.pnlTop.Controls.Add(this.cmbCustomerName);
            this.pnlTop.Controls.Add(this.btnCatalog);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(569, 125);
            this.pnlTop.TabIndex = 17;
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Location = new System.Drawing.Point(12, 76);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(170, 13);
            this.lblClientName.TabIndex = 4;
            this.lblClientName.Text = "Please select client by name or ID:";
            // 
            // lblCatalogLabel
            // 
            this.lblCatalogLabel.AutoSize = true;
            this.lblCatalogLabel.Location = new System.Drawing.Point(320, 76);
            this.lblCatalogLabel.Name = "lblCatalogLabel";
            this.lblCatalogLabel.Size = new System.Drawing.Size(205, 13);
            this.lblCatalogLabel.TabIndex = 13;
            this.lblCatalogLabel.Text = "Please select products from catalog page:";
            // 
            // cmbCustomerID
            // 
            this.cmbCustomerID.FormattingEnabled = true;
            this.cmbCustomerID.Location = new System.Drawing.Point(6, 98);
            this.cmbCustomerID.Name = "cmbCustomerID";
            this.cmbCustomerID.Size = new System.Drawing.Size(121, 21);
            this.cmbCustomerID.TabIndex = 0;
            this.cmbCustomerID.Text = "ID";
            this.cmbCustomerID.SelectedIndexChanged += new System.EventHandler(this.cmbCustomerID_SelectedIndexChanged);
            // 
            // cmbCustomerName
            // 
            this.cmbCustomerName.FormattingEnabled = true;
            this.cmbCustomerName.Location = new System.Drawing.Point(133, 98);
            this.cmbCustomerName.Name = "cmbCustomerName";
            this.cmbCustomerName.Size = new System.Drawing.Size(170, 21);
            this.cmbCustomerName.TabIndex = 1;
            this.cmbCustomerName.Text = "Name";
            this.cmbCustomerName.SelectedIndexChanged += new System.EventHandler(this.cmbCustomerName_SelectedIndexChanged);
            // 
            // btnCatalog
            // 
            this.btnCatalog.Location = new System.Drawing.Point(323, 96);
            this.btnCatalog.Name = "btnCatalog";
            this.btnCatalog.Size = new System.Drawing.Size(75, 23);
            this.btnCatalog.TabIndex = 5;
            this.btnCatalog.Text = "Catalog";
            this.btnCatalog.UseVisualStyleBackColor = true;
            this.btnCatalog.Click += new System.EventHandler(this.btnCatalog_Click);
            // 
            // lblClerkLabel
            // 
            this.lblClerkLabel.AutoSize = true;
            this.lblClerkLabel.Location = new System.Drawing.Point(12, 20);
            this.lblClerkLabel.Name = "lblClerkLabel";
            this.lblClerkLabel.Size = new System.Drawing.Size(125, 13);
            this.lblClerkLabel.TabIndex = 3;
            this.lblClerkLabel.Text = "Please select your name:";
            // 
            // cmbClerkName
            // 
            this.cmbClerkName.FormattingEnabled = true;
            this.cmbClerkName.Location = new System.Drawing.Point(143, 16);
            this.cmbClerkName.Name = "cmbClerkName";
            this.cmbClerkName.Size = new System.Drawing.Size(160, 21);
            this.cmbClerkName.TabIndex = 2;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 60000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lblTime
            // 
            this.lblTime.Location = new System.Drawing.Point(16, 49);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(121, 23);
            this.lblTime.TabIndex = 7;
            this.lblTime.Text = "Time";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.lblClerkLabel);
            this.pnlBottom.Controls.Add(this.cmbClerkName);
            this.pnlBottom.Controls.Add(this.lblTime);
            this.pnlBottom.Controls.Add(this.btnCancel);
            this.pnlBottom.Controls.Add(this.txtTotalPrice);
            this.pnlBottom.Controls.Add(this.lblTotalPriceLabel);
            this.pnlBottom.Controls.Add(this.btnComplete);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 307);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(569, 81);
            this.pnlBottom.TabIndex = 19;
            // 
            // salesOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 388);
            this.Controls.Add(this.pnlFill);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlBottom);
            this.Name = "salesOrderForm";
            this.Text = "salesOrderForm";
            this.Load += new System.EventHandler(this.salesOrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salesList)).EndInit();
            this.pnlFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView salesList;
        private System.Windows.Forms.DataGridViewTextBoxColumn product;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn linePrice;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Label lblTotalPriceLabel;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.Panel pnlFill;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.Label lblCatalogLabel;
        private System.Windows.Forms.ComboBox cmbCustomerID;
        private System.Windows.Forms.ComboBox cmbCustomerName;
        private System.Windows.Forms.Button btnCatalog;
        private System.Windows.Forms.Label lblClerkLabel;
        private System.Windows.Forms.ComboBox cmbClerkName;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Panel pnlBottom;
    }
}