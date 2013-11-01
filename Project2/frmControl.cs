/*******************************************************************/
/**                                                               **/
/**    Group                       :  Project2 05                 **/
/**    Student Name                :  Jun Cao, Sufeng Ding,       **/
/**                                   Muran Yang, Zhi Long Wu,    **/
/**                                   Cristian Salinas-O'Neill    **/
/**    Course Number               :  CST2335                     **/
/**    Lab Section Number          :  411                         **/
/**    Professor Name              :  John Tappin                 **/
/**    Assignment Name/Number/Date :  Project2                    **/
/**                                                               **/
/*******************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project2
{
    public partial class frmControl : Form
    {
        private int childFormNumber = 0;
        private Business business;
        private frmCategories myfrmCategories;
        private frmCustomers myfrmCustomers;
        private frmEmployees myfrmEmployees;
        private frmProducts myfrmProducts;
        private frmShippers myfrmShippers;
        private frmSuppliers myfrmSuppliers;
        private frmMaintenace myfrmMaintenance;


        public frmControl(Business b)
        {
            InitializeComponent();
            business = b;
            this.Text = "North Wind Control Form";
        }

        // Open a new sales form
        // That form will reference the business object
        private void ShowNewForm(object sender, EventArgs e)
        {

        }
        // Close appliaction
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Close all mdi child forms
        private void CloseAll_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }
        // Close current actived form
        private void CloseCurrent_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();
        }

        private void newOrderFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form salesOrderForm = new salesOrderForm(business);
            salesOrderForm.MdiParent = this;
            salesOrderForm.Text = "Sales Form " + childFormNumber++;
            salesOrderForm.Show();
        }

        private void closeCurrentFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ActiveMdiChild.Dispose();
        }

        private void closeAllFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form[] f = this.MdiChildren;
            for (int i = 0; i < f.Length; i++)
            {
                f[i].Dispose();
            }
        }

        private void newMaintenanceFormToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (myfrmMaintenance == null || myfrmMaintenance.IsDisposed)
            {
                myfrmMaintenance = new frmMaintenace(this.business);
                myfrmMaintenance.MdiParent = this;
            }
            myfrmMaintenance.Show();
        }

        private void addNewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (myfrmCustomers == null || myfrmCustomers.IsDisposed)
            {
                myfrmCustomers = new frmCustomers(this.business);
                myfrmCustomers.MdiParent = this;
            }
            myfrmCustomers.Show();
        }

        private void addNewEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (myfrmEmployees == null || myfrmEmployees.IsDisposed)
            {
                myfrmEmployees = new frmEmployees(this.business);
                myfrmEmployees.MdiParent = this;
            }
            myfrmEmployees.Show();
        }

        private void addNewCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (myfrmCategories == null || myfrmCategories.IsDisposed)
            {
                myfrmCategories = new frmCategories(this.business);
                myfrmCategories.MdiParent = this;
            }
            myfrmCategories.Show();
        }

        private void addNewProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (myfrmProducts == null || myfrmProducts.IsDisposed)
            {
                myfrmProducts = new frmProducts(this.business);
                myfrmProducts.MdiParent = this;
            }
            myfrmProducts.Show();
        }

        private void addNewShipperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (myfrmShippers == null || myfrmShippers.IsDisposed)
            {
                myfrmShippers = new frmShippers(this.business);
                myfrmShippers.MdiParent = this;
            }
            myfrmShippers.Show();

        }

        private void addNewSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (myfrmSuppliers == null || myfrmSuppliers.IsDisposed)
            {
                myfrmSuppliers = new frmSuppliers(this.business);
                myfrmSuppliers.MdiParent = this;
            }
            myfrmSuppliers.Show();
        }

    }
}
