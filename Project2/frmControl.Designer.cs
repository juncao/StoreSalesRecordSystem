namespace Project2
{
    partial class frmControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmControl));
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeCurrentFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newOrderFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newMaintenanceFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewShipperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewSupplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeCurrentFormToolStripMenuItem,
            this.closeAllFormToolStripMenuItem});
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.closeToolStripMenuItem.Text = "Clos&e";
            // 
            // closeCurrentFormToolStripMenuItem
            // 
            this.closeCurrentFormToolStripMenuItem.Name = "closeCurrentFormToolStripMenuItem";
            this.closeCurrentFormToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.closeCurrentFormToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.closeCurrentFormToolStripMenuItem.Text = "C&lose Current Form";
            this.closeCurrentFormToolStripMenuItem.Click += new System.EventHandler(this.closeCurrentFormToolStripMenuItem_Click);
            // 
            // closeAllFormToolStripMenuItem
            // 
            this.closeAllFormToolStripMenuItem.Name = "closeAllFormToolStripMenuItem";
            this.closeAllFormToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.closeAllFormToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.closeAllFormToolStripMenuItem.Text = "Close &All Form";
            this.closeAllFormToolStripMenuItem.Click += new System.EventHandler(this.closeAllFormToolStripMenuItem_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.windowsMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.MdiWindowListItem = this.windowsMenu;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 4;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.addToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(37, 20);
            this.fileMenu.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newOrderFormToolStripMenuItem,
            this.newMaintenanceFormToolStripMenuItem});
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "&New";
            // 
            // newOrderFormToolStripMenuItem
            // 
            this.newOrderFormToolStripMenuItem.Name = "newOrderFormToolStripMenuItem";
            this.newOrderFormToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.newOrderFormToolStripMenuItem.Text = "New Order Form";
            this.newOrderFormToolStripMenuItem.Click += new System.EventHandler(this.newOrderFormToolStripMenuItem_Click);
            // 
            // newMaintenanceFormToolStripMenuItem
            // 
            this.newMaintenanceFormToolStripMenuItem.Name = "newMaintenanceFormToolStripMenuItem";
            this.newMaintenanceFormToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.newMaintenanceFormToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.newMaintenanceFormToolStripMenuItem.Text = "New &Maintenance Form";
            this.newMaintenanceFormToolStripMenuItem.Click += new System.EventHandler(this.newMaintenanceFormToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // windowsMenu
            // 
            this.windowsMenu.Name = "windowsMenu";
            this.windowsMenu.Size = new System.Drawing.Size(68, 20);
            this.windowsMenu.Text = "&Windows";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewCustomerToolStripMenuItem,
            this.addNewEmployeeToolStripMenuItem,
            this.addNewCategoryToolStripMenuItem,
            this.addNewProductToolStripMenuItem,
            this.addNewShipperToolStripMenuItem,
            this.addNewSupplierToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // addNewCustomerToolStripMenuItem
            // 
            this.addNewCustomerToolStripMenuItem.Name = "addNewCustomerToolStripMenuItem";
            this.addNewCustomerToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.addNewCustomerToolStripMenuItem.Text = "Add New Customer";
            this.addNewCustomerToolStripMenuItem.Click += new System.EventHandler(this.addNewCustomerToolStripMenuItem_Click);
            // 
            // addNewEmployeeToolStripMenuItem
            // 
            this.addNewEmployeeToolStripMenuItem.Name = "addNewEmployeeToolStripMenuItem";
            this.addNewEmployeeToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.addNewEmployeeToolStripMenuItem.Text = "Add New Employee";
            this.addNewEmployeeToolStripMenuItem.Click += new System.EventHandler(this.addNewEmployeeToolStripMenuItem_Click);
            // 
            // addNewCategoryToolStripMenuItem
            // 
            this.addNewCategoryToolStripMenuItem.Name = "addNewCategoryToolStripMenuItem";
            this.addNewCategoryToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.addNewCategoryToolStripMenuItem.Text = "Add New Category";
            this.addNewCategoryToolStripMenuItem.Click += new System.EventHandler(this.addNewCategoryToolStripMenuItem_Click);
            // 
            // addNewProductToolStripMenuItem
            // 
            this.addNewProductToolStripMenuItem.Name = "addNewProductToolStripMenuItem";
            this.addNewProductToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.addNewProductToolStripMenuItem.Text = "Add New Product";
            this.addNewProductToolStripMenuItem.Click += new System.EventHandler(this.addNewProductToolStripMenuItem_Click);
            // 
            // addNewShipperToolStripMenuItem
            // 
            this.addNewShipperToolStripMenuItem.Name = "addNewShipperToolStripMenuItem";
            this.addNewShipperToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.addNewShipperToolStripMenuItem.Text = "Add New Shipper";
            this.addNewShipperToolStripMenuItem.Click += new System.EventHandler(this.addNewShipperToolStripMenuItem_Click);
            // 
            // addNewSupplierToolStripMenuItem
            // 
            this.addNewSupplierToolStripMenuItem.Name = "addNewSupplierToolStripMenuItem";
            this.addNewSupplierToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.addNewSupplierToolStripMenuItem.Text = "Add New Supplier";
            this.addNewSupplierToolStripMenuItem.Click += new System.EventHandler(this.addNewSupplierToolStripMenuItem_Click);
            // 
            // frmControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.Name = "frmControl";
            this.Text = "frmControl";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeCurrentFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllFormToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newOrderFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newMaintenanceFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsMenu;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewShipperToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewSupplierToolStripMenuItem;

    }
}



