using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Project2
{
    public partial class frmProducts : Form
    {
        private Business business;
        private TextBox[] textBoxArray = null;
        private ComboBox[] cmbArray;
        string[,] ProductsInformation;
        private String EditingItemID = null;
        private String repeatInsertItemID = null;

        // This constructor will instantiate a form with all empty textBoxes that allows user
        // to insert new product information
        public frmProducts(Business business)
        {
            this.business = business;
            InitializeComponent();
            this.Text = "Add New Product Form";
        }
        // This constructor will take a product ID and display that product's information
        // This form will show edit buttons
        public frmProducts(String EditingItemID, Business business)
        {
            this.business = business;
            this.EditingItemID = EditingItemID;
            InitializeComponent();
            this.Text = "Editing: PorductID " + EditingItemID;
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            InitializeArray();

            ProductsInformation = business.getProductsInformation();
            cmbArray[0].Items.AddRange(business.getSupplierIDs());
            cmbArray[1].Items.AddRange(business.getCategoryIDs());
            //theButton.Enabled = false;

            if (EditingItemID != null)
            {
                // Loading up Shippers in combo list
                for (int i = 0; i < ProductsInformation.GetLength(0); i++)
                {
                    if (EditingItemID == ProductsInformation[i, 0])
                    {
                        // Pass the Discontinued value to check box
                        for (int j = 0; j < ProductsInformation.Length; j++)
                        {
                            if(j==2)
                            {
                                cmbArray[0].Text= ProductsInformation[i, j];
                            }
                            else if (j == 4)
                            {
                                cmbArray[1].Text= ProductsInformation[i, j];
                            }

                            
                            if (j == 11)
                            {
                                if (ProductsInformation[i, j] == "True")
                                    cklDiscontinued.Checked = true;
                            }else
                            // skip index 3 and 5 because those values are from refrenced tables
                            if (j != 3 && j != 5 && j!=2 && j!=4)
                                textBoxArray[j].Text = ProductsInformation[i, j];
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
            this.ActiveControl = textBoxArray[1];
        }

        private void InitializeArray()
        {
            textBoxArray = new TextBox[11];

            textBoxArray[0] = txtProductID;
            textBoxArray[1] = txtProductName;
            textBoxArray[2] = null;
            textBoxArray[3] = null;
            textBoxArray[4] = null;
            textBoxArray[5] = null;
            textBoxArray[6] = txtQuantityPerUnit;
            textBoxArray[7] = txtUnitPrice;
            textBoxArray[8] = txtUnitsInStock;
            textBoxArray[9] = txtUnitsOnOrder;
            textBoxArray[10] = txtReorderLevel;

            cmbArray=new ComboBox[2];
            cmbArray[0] = cmbSupplierIDs;
            cmbArray[1] = cmbCategoryIDs;

        }

        protected void btnReturn_Click(object sender, EventArgs e)
        {
            // Do not change anything.
            // Close this form.
            this.Close();
        }

        #region Edit Products information
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (numberAndReqiredfieldValidate())
                {
                    UpdateByID(getPkValue(), getNoPkValue(), getDiscontinued());
                    MessageBox.Show("Update successfully!");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                lblWarningMessage.Text = ex.Message;
                textBoxArray[1].Focus();
            }
        }
        private Boolean getDiscontinued()
        {
            return cklDiscontinued.Checked;
        }
        private void UpdateByID(String pkValue, String[] noPKvalue,Boolean discontinuted)
        {

                business.updateProductInfo(pkValue, noPKvalue, discontinuted);

        }
        #endregion

        #region Insert Product information
        protected void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (numberAndReqiredfieldValidate())
                {
                    insertData();
                    DialogResult dialogResult = MessageBox.Show("Insert successfully! Do you want to insert another one?", "Insert", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        lblWarningMessage.Text = "";
                        textBoxArray[0].Text = "";
                        textBoxArray[1].Text = "";
                        textBoxArray[6].Text = "";
                        textBoxArray[7].Text = "";
                        textBoxArray[8].Text = "";
                        textBoxArray[9].Text = "";
                        textBoxArray[10].Text = "";
                        cmbArray[0].SelectedIndex = -1;
                        cmbArray[1].SelectedIndex = -1;
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
            }

        }

        private void insertData()
        {

                for (int i = 0; i < ProductsInformation.GetLength(0); i++)
                {
                    if (textBoxArray[0].Text == ProductsInformation[i, 0])
                    {
                        repeatInsertItemID = ProductsInformation[i, 0];
                        throw new System.ArgumentException("Product ID exist .");

                    }
                }
                business.insertProduct(getNoPkValue(),getDiscontinued());

        }
        #endregion

        #region Help methods
        private String getPkValue()
        {
            return textBoxArray[0].Text;
        }

        private String[] getNoPkValue()
        {
            String[] value = new String[textBoxArray.Length - 3];

            value[0] = textBoxArray[1].Text;

            if (cmbCategoryIDs.SelectedIndex != -1)
            value[1] = cmbCategoryIDs.Text;
            if (cmbSupplierIDs.SelectedIndex != -1)
            value[2] =  cmbSupplierIDs.Text;
            //for (int i = 0; i < 2; i++)
            //{
                
            //        value[i] = textBoxArray[i+1].Text;
            //}

            //value[2] = textBoxArray[4].Text;
            for (int i = 3; i < value.Length; i++)
            {
               
                value[i] = textBoxArray[i + 3].Text;
            }
            return value;
        }


        private Boolean numberAndReqiredfieldValidate() 
        {
            Boolean allPassed = true;

            string unitPrice = textBoxArray[7].Text.Trim();
            string UnitsInStock = textBoxArray[8].Text.Trim();
            string unitsOnOrder = textBoxArray[9].Text.Trim();
            string reorderLevel = textBoxArray[10].Text.Trim();

            double doubleValue;
            int intValue;

            
            if (unitPrice.Length != 0)
            {
                bool isNum=double.TryParse(unitPrice,out doubleValue);

                if (!isNum)
                {
                    lblWarningMessage.Text = "Invalid format: unitPrice.";   
                    allPassed = false;
                }

            }
            if (UnitsInStock.Length != 0)
            {
                bool isNum = int.TryParse(UnitsInStock, out intValue);

                if (!isNum)
                {
                    lblWarningMessage.Text = "Invalid format: UnitsInStock.";
                    allPassed = false;
                }

            }
            if (unitsOnOrder.Length != 0)
            {
                bool isNum = int.TryParse(unitsOnOrder, out intValue);

                if (!isNum)
                {
                    lblWarningMessage.Text = "Invalid format: unitsOnOrder.";
                    allPassed = false;
                }

            }
            if (reorderLevel.Length != 0)
            {
                bool isNum = int.TryParse(reorderLevel, out intValue);

                if (!isNum)
                {
                    lblWarningMessage.Text = "Invalid format: reorderLevel.";   // do whatever you want with the error label
                    allPassed = false;
                }
            }

            if (cmbCategoryIDs.SelectedIndex == -1)
            {
                lblWarningMessage.Text = "Missing required information: CategoryID.";
                allPassed = false;
            }

            if (cmbSupplierIDs.SelectedIndex == -1)
            {
                lblWarningMessage.Text = "Missing required information: SupplierID.";
                allPassed = false;
            }

            if (textBoxArray[1].Text.Trim().Length == 0)
            {
                lblWarningMessage.Text = "Missing required information: ProductName.";
                allPassed = false;
            }
            return allPassed;
        }

        #endregion
        
    }
}
