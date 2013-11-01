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
    /// <summary>
    /// Class name: FrmSupplierItemEdit
    /// Class description: Provide categoried maintenace page
    /// you can view and edit informations of particular Supplier.
    /// you can always link back to maintenance page 
    /// you can delete particular Supplier record 
    /// by clicking "delete" button.
    /// You can also insert new Supplier record
    /// by clicking "insert" button
    /// when insertation, it will check whether 
    /// the Supplier name existed in record
    /// if no, commit inserting
    /// otherwise show item existing information
    /// and ask for your action either updating or cancel
    /// cancel is to clear all the filed information filled out
    /// And then employee can re-entery for inserting other record.
    /// Side effects (if any) including Errors and Exceptions:
    /// 1-"Updating causes a problem:Miss required information!Please check follow filed: SupplierName."
    /// 2-"Inserting causes a problem:Miss required information!Please check follow filed: SupplierName."
    /// 3-"Supplier name exist ,You can change the name or update the Supplier information."
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
    public partial class frmSuppliers : Form
    {
        private Business business;
        private TextBox[] textBoxArray = null;
        string[,] supplierInformation;
        private String EditingItemID = null;

        #region constructer public frmMaintenace(Business myBusiness)
        /// <summary>
        /// constructer with only one parameter 
        /// it is used by inserting
        /// initialize component
        /// assign Business reference to myBusiness of this page
        /// </summary>
        /// <param name="business">Business referent type</param>
        public frmSuppliers(Business business)
        {
            this.business = business;
            InitializeComponent();
            this.Text = "Add New Supplier Form";
        }
        #endregion  
        #region frmSuppliers(String EditingItemID, Business business)
        /// <summary>
        /// constructer with two parameters 
        /// it is used by editing
        /// initialize component
        /// assign Business reference to myBusiness of this page
        /// </summary>
        /// <param name="business">Business referent type</param>
        public frmSuppliers(String EditingItemID, Business business)
        {
            this.business = business;
            this.EditingItemID = EditingItemID;
            InitializeComponent();
            this.Text = "Editing: SupplierID " + EditingItemID;
        }
        #endregion

        #region page_load and initialize array
        /// <summary>
        /// Method name: Page_Load
        /// Method description: 
        /// get all Suppliers informations from business object which
        /// is store in internal varable
        /// Show information for particular Supplier
        /// if this form is for editing
        /// but leave empty field 
        /// if this form is for inserting
        /// show some button for editing the Supplier
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

        #endregion


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
        /// <summary>
        /// Method name: UpdateByID
        /// Method description: 
        /// invoke by method btnUpdate_Click(object sender, EventArgs e)
        /// it is to update Supplier information 
        /// through call method updateSupplierInfo of business object 
        /// Parameter list (one or more lines per parameter): SupplierID-String
        /// Return type and value: N/A
        /// Side effects (if any) including Errors and Exceptions:
        /// "Updating causes a problem:Miss required information!Please check follow filed: SupplierName."
        /// Constraints: require field, such as name, can not be empty
        /// Assumptions: none
        /// Required libraries: 
        ///     using System;
        ///     System.Data;
        /// Any warnings for maintenance: none
        /// Unresolved issues: none
        /// </summary>
        private void UpdateByID(String pkValue, String[] noPKvalue)
        {

                business.updateSupplierInfo(pkValue, noPKvalue);


        }
        #endregion

        #region Insert Suppliers information
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
        /// <summary>
        /// Method name: insertData
        /// Method description: 
        /// invoke by method btnInsert_Click(object sender, EventArgs e)
        /// it is to insert new Supplier record to database 
        /// through call method insertSupplier of business object 
        /// which is store in Session varable.
        /// Parameter list (one or more lines per parameter): SupplierID-String
        /// Return type and value: N/A
        /// Side effects (if any) including Errors and Exceptions:
        /// 1-"Supplier name exist <br>You can change the name or update the Supplier information."
        /// 2-"Inserting causes a problem:Miss required information!Please check follow filed: SupplierName."
        /// Constraints: Supplier name can not existing in store when inserting
        /// Assumptions: none
        /// Required libraries: 
        ///     using System;
        ///     System.Data;
        /// Any warnings for maintenance: none
        /// Unresolved issues: none
        /// </summary>
        private void insertData()
        {

           business.insertSupplier(getNoPkValue());

        }
        #endregion

        #region Help methods
        /// <summary>
        /// Method name: getPkValue
        /// Method description: This method is to ge Primary key which is Supplier id
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
            String[] value = new String[textBoxArray.Length - 1];

            for (int i = 0; i < value.Length; i++)
            {
                value[i] = textBoxArray[i + 1].Text;
            }
            return value;
        }

        /// <summary>
        /// Method name: reqiredfieldValidate
        /// Method description: 
        /// validate the field value
        /// id and name are all requird 
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
