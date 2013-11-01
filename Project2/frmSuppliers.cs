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
    public partial class frmSuppliers : Form
    {
        private Business business;
        private TextBox[] textBoxArray = null;
        string[,] supplierInformation;
        private String EditingItemID = null;

        // This constructor will instantiate a form with all empty textBoxes that allows user
        // to insert new supplier information
        public frmSuppliers(Business business)
        {
            this.business = business;
            InitializeComponent();
            this.Text = "Add New Supplier Form";
        }
        // This constructor will take a supplier ID and display that product's information
        // This form will show edit buttons
        public frmSuppliers(String EditingItemID, Business business)
        {
            this.business = business;
            this.EditingItemID = EditingItemID;
            InitializeComponent();
            this.Text = "Editing: SupplierID " + EditingItemID;
        }

        private void frmSuppliers_Load(object sender, EventArgs e)
        {
            InitializeArray();

            supplierInformation = business.getSupplierInformation();

            //theButton.Enabled = false;

            if (EditingItemID != null)
            {
                // Loading up Suppliers in combo list
                for (int i = 0; i < supplierInformation.GetLength(0); i++)
                {
                    if (EditingItemID == supplierInformation[i, 0])
                    {
                        for (int j = 0; j < textBoxArray.Length; j++)
                        {
                            textBoxArray[j].Text = supplierInformation[i, j];
                        }
                    }
                }

                //Edit:Update
                btnUpdate.Enabled = true;
                btnInsert.Enabled = false;
            }
            else
            {
                //Insert action
                btnUpdate.Enabled = false;
                btnInsert.Enabled = true;
            }
            this.ActiveControl = txtCompanyName;
        }

        private void InitializeArray()
        {
            textBoxArray = new TextBox[12];

            textBoxArray[0] = txtSupplierID;
            textBoxArray[1] = txtCompanyName;
            textBoxArray[2] = txtContactName;
            textBoxArray[3] = txtContactTitle;
            textBoxArray[4] = txtAddress;
            textBoxArray[5] = txtCity;
            textBoxArray[6] = txtRegion;
            textBoxArray[7] = txtPostalCode;
            textBoxArray[8] = txtCountry;
            textBoxArray[9] = txtPhone;
            textBoxArray[10] = txtFax;
            textBoxArray[11] = txtHomePage;
        }

        protected void btnReturn_Click(object sender, EventArgs e)
        {
            // Do not change anything.
            // Close this form.
            this.Close();
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            //reset all textbox vlaues
            foreach (TextBox tb in textBoxArray)
            {
                tb.Text = "";
            }
            btnUpdate.Visible = false;
            btnInsert.Visible = true;
        }

        #region Edit Suppliers information
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (reqiredfieldValidate())
                {
                    UpdateByID(getPkValue(), getNoPkValue());
                    MessageBox.Show("Update successfully!");
                    this.Close();
                }
            }
            //catch (ArgumentNullException arEx)
            //{
            //    MessageBox.Show(arEx.Message);
            //    textBoxArray[1].Focus();
            //}
            catch (Exception ex)
            {
                lblWarningMessage.Text =ex.Message;
                textBoxArray[1].Focus();
            }
        }

        private void UpdateByID(String pkValue, String[] noPKvalue)
        {

                business.updateSupplierInfo(pkValue, noPKvalue);


        }
        #endregion

        #region Insert Suppliers information
        protected void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (reqiredfieldValidate())
                {
                    insertData();
                    // Go back to catalog form
                    DialogResult dialogResult = MessageBox.Show("Insert successfully! Do you want to insert another one?", "Insert", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        lblWarningMessage.Text = "";
                        foreach (TextBox t in textBoxArray)
                        {
                            t.Text = "";
                        }
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        this.Close();
                    }
                }

            }
            //catch (ArgumentException ArEx)
            //{
            //    MessageBox.Show(ArEx.Message);
            //}
            catch (Exception otherEx)
            {
                MessageBox.Show(otherEx.Message);
                textBoxArray[1].Focus();
            }

        }

        private void insertData()
        {

           business.insertSupplier(getNoPkValue());

        }
        #endregion

        #region Help methods
        private String getPkValue()
        {
            return textBoxArray[0].Text;
        }

        private String[] getNoPkValue()
        {
            String[] value = new String[textBoxArray.Length - 1];

            for (int i = 0; i < value.Length; i++)
            {
                value[i] = textBoxArray[i + 1].Text;
            }
            return value;
        }


        private Boolean reqiredfieldValidate()
        {

            string companyName = textBoxArray[1].Text.Trim();


            if (companyName.Length == 0)
            {
                lblWarningMessage.Text = " Missing required information: companyName.";
                return false;
            }
            return true;

        }
        #endregion
    }
}
