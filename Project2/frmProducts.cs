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

    /// <summary>
    /// Class name: FrmProductItemEdit
    /// Class description: Provide Products maintenace page
    /// you can view and edit informations of particular Product.
    /// you can always link back to maintenance page 
    /// you can delete particular Product record 
    /// by clicking "delete" button.
    /// You can also insert new Product record
    /// by clicking "insert" button
    /// when insertation, it will check whether 
    /// the Product name existed in record
    /// if no, commit inserting
    /// otherwise show item existing information
    /// and ask for your action either updating or cancel
    /// cancel is to clear all the filed information filled out
    /// And then employee can re-entery for inserting other record.
    /// Side effects (if any) including Errors and Exceptions:
    /// 1-"Updating causes a problem:Miss required information!Please check follow filed: ProductName."
    /// 2-"Inserting causes a problem:Miss required information!Please check follow filed: ProductName."
    /// 3-"Customer name exist ,You can change the name or update the Product information."
    /// Constraints: 
    ///     Name filed-It is required filed which should be filled out
    ///                Its maximum length is 15.
    /// Assumptions: none
    /// Required libraries: 
    /// System;
    /// System.Collections.Generic;
    /// System.ComponentModel;
    /// System.Data;
    /// System.Drawing;
    /// System.Linq;
    /// System.Text;
    /// System.Windows.Forms;
    /// Any warnings for maintenance: none
    /// Unresolved issues: none
    /// </summary>
    public partial class frmProducts : Form
    {
        private Business business;
        private TextBox[] textBoxArray = null;
        private ComboBox[] cmbArray;
        string[,] ProductsInformation;
        private String EditingItemID = null;
        private String repeatInsertItemID = null;

        #region constructer public frmMaintenace(Business myBusiness)
        /// <summary>
        /// constructer with only one parameter 
        /// it is used by inserting
        /// initialize component
        /// assign Business reference to myBusiness of this page
        /// </summary>
        /// <param name="business">Business referent type</param>
        public frmProducts(Business business)
        {
            this.business = business;
            InitializeComponent();
            this.Text = "Add New Product Form";
        }
        #endregion
        #region
        /// <summary>
        /// constructer with two parameters 
        /// it is used by editing
        /// initialize component
        /// assign Business reference to myBusiness of this page
        /// </summary>
        /// <param name="business">Business referent type</param>
        public frmProducts(String EditingItemID, Business business)
        {
            this.business = business;
            this.EditingItemID = EditingItemID;
            InitializeComponent();
            this.Text = "Editing: PorductID " + EditingItemID;
        }
        #endregion

        #region page_load and initialize array
        /// <summary>
        /// Method name: Page_Load
        /// Method description: 
        /// get all Customers informations from business object which
        /// is store in internal varable
        /// Show information for particular Customer
        /// if this form is for editing
        /// but leave empty field 
        /// if this form is for inserting
        /// show some button for editing the Customer
        /// Parameter list (one or more lines per parameter): sender and e
        /// sender-object
        /// e-EventArgs
        /// Return type and value: N/A
        /// Side effects (if any) including Errors and Exceptions: N/A
        /// Constraints: none
        /// Assumptions: none
        /// Required libraries: 
        /// Any warnings for maintenance: none
        /// Unresolved issues: none
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">System.EventArgs</param>
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
        #endregion
        /// <summary>
        /// Method name: InitializeArrays
        /// Method description: initialize labelArray
        /// and textBoxArray
        /// make easy way to manage textfield and lable
        /// Parameter list (one or more lines per parameter): none
        /// Return type and value: N/A
        /// Side effects (if any) including Errors and Exceptions: N/A
        /// Constraints: none
        /// Assumptions: none
        /// Required libraries: 
        /// Any warnings for maintenance: none
        /// Unresolved issues: none
        /// </summary>
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
        # region return to maintain page
        /// <summary>
        /// Method name: btnReturn_Click
        /// Method description: 
        /// this method invokes by clicking the return button
        /// it is to link back to maintain page
        /// Parameter list (one or more lines per parameter): sender and e
        /// Return type and value: void
        /// Side effects (if any) including Errors and Exceptions: N/A
        /// Constraints: none
        /// Assumptions: none
        /// Required libraries: N/A
        /// Any warnings for maintenance: none
        /// Unresolved issues: none
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">System.EventArgs</param>
        protected void btnReturn_Click(object sender, EventArgs e)
        {
            // Do not change anything.
            // Close this form.
            this.Close();
        }

        #endregion
        #region Edit Products information
        #region update Customer information
        /// <summary>
        /// Method name: btnUpdate_Click
        /// Method description: 
        /// this method invokes by clicking the Update button
        /// it is to invoke UpdateByID method
        /// and then link back to maintain page
        /// Parameter list (one or more lines per parameter): sender and e
        /// Return type and value: void
        /// Side effects (if any) including Errors and Exceptions: N/A
        /// Constraints: none
        /// Assumptions: none
        /// Required libraries: System.Data.OleDb;
        /// Any warnings for maintenance: none
        /// Unresolved issues: none
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">System.EventArgs</param>

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
        #endregion

        private Boolean getDiscontinued()
        {
            return cklDiscontinued.Checked;
        }

        /// <summary>
        /// Method name: UpdateByID
        /// Method description: 
        /// invoke by method btnUpdate_Click(object sender, EventArgs e)
        /// it is to update Customer information 
        /// through call method updateCustomerInfo of business object 
        /// Parameter list (one or more lines per parameter): CustomerID-String
        /// Return type and value: N/A
        /// Side effects (if any) including Errors and Exceptions:
        /// "Updating causes a problem:Miss required information!Please check follow filed: CustomerName."
        /// Constraints: require field, such as name, can not be empty
        /// Assumptions: none
        /// Required libraries: 
        ///     using System;
        ///     System.Data;
        /// Any warnings for maintenance: none
        /// Unresolved issues: none
        /// </summary>
        private void UpdateByID(String pkValue, String[] noPKvalue,Boolean discontinuted)
        {

                business.updateProductInfo(pkValue, noPKvalue, discontinuted);

        }
        #endregion

        #region Insert Product information
        /// <summary>
        /// Method name: btnInsert_Click
        /// Method description: 
        /// this method invokes by clicking the Insert button
        /// it is to invoke insertData method
        /// and then link back to maintain page
        /// Parameter list (one or more lines per parameter): sender and e
        /// Return type and value: void
        /// Side effects (if any) including Errors and Exceptions: N/A
        /// Constraints: none
        /// Assumptions: none
        /// Required libraries: System.Data.OleDb;
        /// Any warnings for maintenance: none
        /// Unresolved issues: none
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">System.EventArgs</param>
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

        /// Method name: insertData
        /// Method description: 
        /// invoke by method btnInsert_Click(object sender, EventArgs e)
        /// it is to insert new Customer record to database 
        /// through call method insertCustomer of business object 
        /// which is store in Session varable.
        /// Parameter list (one or more lines per parameter): CustomerID-String
        /// Return type and value: N/A
        /// Side effects (if any) including Errors and Exceptions:
        /// 1-"Customer name exist <br>You can change the name or update the customer information."
        /// 2-"Inserting causes a problem:Miss required information!Please check follow filed: CustomerName."
        /// Constraints: customer name can not existing in store when inserting
        /// Assumptions: none
        /// Required libraries: 
        ///     using System;
        ///     System.Data;
        /// Any warnings for maintenance: none
        /// Unresolved issues: none
        /// </summary>
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
        /// <summary>
        /// Method name: getPkValue
        /// Method description: This method is to ge Primary key which is customer id
        /// Parameter list (one or more lines per parameter): N/A
        /// Return type and value: String
        /// Side effects (if any) including Errors and Exceptions: N/A
        /// Constraints: none
        /// Assumptions: none
        /// Required libraries: none
        /// Any warnings for maintenance: none
        /// Unresolved issues: none
        /// </summary>
        /// <returns>String</returns>
        private String getPkValue()
        {
            return textBoxArray[0].Text;
        }
        /// <summary>
        /// Method name: getNoPkValue
        /// Method description: This method is to get no-Primary key value 
        /// Parameter list (one or more lines per parameter): N/A
        /// Return type and value: String[]
        /// Side effects (if any) including Errors and Exceptions: N/A
        /// Constraints: none
        /// Assumptions: none
        /// Required libraries: none
        /// Any warnings for maintenance: none
        /// Unresolved issues: none
        /// </summary>
        /// <returns>String[]</returns>
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

        /// <summary>
        /// Method name: reqiredfieldValidate
        /// Method description: 
        /// validate the field value
        /// id and name are all requird 
        /// and some field is numeric only
        /// other words, they are not allowed to be empty
        /// before commit unpdate process.
        /// Parameter list (one or more lines per parameter): none
        /// Return type and value: bool
        /// Side effects (if any) including Errors and Exceptions: N/A
        /// Constraints: none
        /// Assumptions: none
        /// Required libraries: 
        /// Any warnings for maintenance: none
        /// Unresolved issues: none
        /// </summary>
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
