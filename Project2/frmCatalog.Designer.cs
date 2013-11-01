namespace Project2
{
    partial class frmCatalog
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblIntroduction = new System.Windows.Forms.Label();
            this.dgProducts = new System.Windows.Forms.DataGridView();
            this.category = new System.Windows.Forms.DataGridViewImageColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityPerUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlCategory = new System.Windows.Forms.Panel();
            this.close = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgProducts)).BeginInit();
            this.pnlCategory.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIntroduction
            // 
            this.lblIntroduction.AutoSize = true;
            this.lblIntroduction.Location = new System.Drawing.Point(9, 27);
            this.lblIntroduction.Name = "lblIntroduction";
            this.lblIntroduction.Size = new System.Drawing.Size(180, 13);
            this.lblIntroduction.TabIndex = 2;
            this.lblIntroduction.Text = "Click product to add it into sales form\r\n";
            // 
            // dgProducts
            // 
            this.dgProducts.AllowUserToAddRows = false;
            this.dgProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgProducts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgProducts.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgProducts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.category,
            this.ProductName,
            this.UnitPrice,
            this.supplier,
            this.QuantityPerUnit});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgProducts.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgProducts.Location = new System.Drawing.Point(0, 0);
            this.dgProducts.Name = "dgProducts";
            this.dgProducts.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgProducts.Size = new System.Drawing.Size(817, 256);
            this.dgProducts.TabIndex = 0;
            this.dgProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clickeAddOrder);
            // 
            // category
            // 
            this.category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.category.HeaderText = "Category";
            this.category.Name = "category";
            this.category.ReadOnly = true;
            this.category.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.category.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.category.Width = 74;
            // 
            // ProductName
            // 
            this.ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Width = 92;
            // 
            // UnitPrice
            // 
            this.UnitPrice.HeaderText = "Unit Price";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            this.UnitPrice.Width = 72;
            // 
            // supplier
            // 
            this.supplier.HeaderText = "Supplier";
            this.supplier.Name = "supplier";
            this.supplier.ReadOnly = true;
            this.supplier.Width = 70;
            // 
            // QuantityPerUnit
            // 
            this.QuantityPerUnit.HeaderText = "Quantity per Unit";
            this.QuantityPerUnit.Name = "QuantityPerUnit";
            this.QuantityPerUnit.ReadOnly = true;
            this.QuantityPerUnit.Width = 85;
            // 
            // pnlCategory
            // 
            this.pnlCategory.Controls.Add(this.dgProducts);
            this.pnlCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCategory.Location = new System.Drawing.Point(0, 0);
            this.pnlCategory.Name = "pnlCategory";
            this.pnlCategory.Size = new System.Drawing.Size(817, 256);
            this.pnlCategory.TabIndex = 5;
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(654, 27);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 23);
            this.close.TabIndex = 1;
            this.close.Text = "Close Catalog";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblIntroduction);
            this.panel1.Controls.Add(this.close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 256);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(817, 62);
            this.panel1.TabIndex = 6;
            // 
            // frmCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 318);
            this.Controls.Add(this.pnlCategory);
            this.Controls.Add(this.panel1);
            this.Name = "frmCatalog";
            this.Text = "frmCatalog";
            this.Load += new System.EventHandler(this.frmCatalog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProducts)).EndInit();
            this.pnlCategory.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblIntroduction;
        private System.Windows.Forms.DataGridView dgProducts;
        private System.Windows.Forms.DataGridViewImageColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityPerUnit;
        private System.Windows.Forms.Panel pnlCategory;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Panel panel1;
    }
}