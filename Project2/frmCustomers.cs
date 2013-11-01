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
    /// Class name: FrmCustomerItemEdit
    /// Class description: Provide categoried maintenace page
    /// you can view and edit informations of particular Customer.
    /// you can always link back to maintenance page 
    /// you can delete particular Customer record 
    /// by clicking "delete" button.
    /// You can also insert new Customer record
    /// by clicking "insert" button
    /// when insertation, it will check whether 
    /// the Customer name existed in record
    /// if no, commit inserting
    /// otherwise show item existing information
    /// and ask for your action either updating or cancel
    /// cancel is to clear all the filed information filled out
    /// And then employee can re-entery for inserting other record.
    /// Side effects (if any) including Errors and Exceptions:
    /// 1-"Updating causes a problem:Miss required information!Please check follow filed: CustomerName."
    /// 2-"Inserting causes a problem:Miss required information!Please check follow filed: CustomerName."
    /// 3-"Customer name exist ,You can change the name or update the Customer information."
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
    public partial class frmCustomers : Form
    {
        private Business business;
        // A way to simplify other code
        // These are references to arrays of references
        private Label[] labelArray = null;
        private TextBox[] textBoxArray = null;
        string[,] CustomerInformation;
        private String EditingItemID = null;
        private String repeatInsertItemID=null;


        public frmCustomers(Business business)
        {
            this.business = business;
            InitializeComponent();
            this.Text = "Add New Customer Form";
        }

        public frmCustomers(String EditingItemID, Business business)
        {
            //theButton = (Button)senderButton;
            this.business = business;
            this.EditingItemID = EditingItemID;
            InitializeComponent();
            this.Text = "Editing: CustomerID " + EditingItemID;
        }


        #region page_load and initialize array
        /// <summary>
        /// Method name: Page_Load
        /// Method description: 
        /// get all Customers informations from business object which
        /// is store in Session varable
        /// Show information for particular Customer
        /// show some button for editing the Customer
        /// Parameter list (one or more lines per parameter): 
        /// sender-object
        /// e-EventArgs
        /// Return type and value: N/A
        /// Side effects (if any) including Errors and Exceptions: N/A
        /// Constraints: none
        /// Assumptions: none
        /// Required libraries: 
        ///     System.Web.UI.WebControls;
        ///     System.Web.UI.WebControls.WebParts;
        ///     System.Web.UI.HtmlControls;
        /// Any warnings for maintenance: none
        /// Unresolved issues: none
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">System.EventArgs</param>
        private void frmCustomers_Load(object sender, EventArgs e)
        {
            InitializeArrays();

            CustomerInformation = business.getCustomerInformation();
            string[] currentItemInformation = new string[CustomerInformation.GetLength(1)];

            //theButton.Enabled = false;

                if (EditingItemID != null)
                {
                    // Loading up Customers in combo list
                    for (int i = 0; i < CustomerInformation.GetLength(0); i++)
                    {
                        if (EditingItemID == CustomerInformation[i, 0])
                        {
                            for (int j = 0; j < currentItemInformation.Length; j++)
                            {
                                currentItemInformation[j] = CustomerInformation[i, j];
                            }
                        }
                    }

                    //Edit:Update,Delete
                    btnUpdate.Enabled = true;
                    //btnDelete.Visible = true;
                    //no-editing action
                    btnInsert.Enabled = false;



                }
                else
                {
                    btnUpdate.Enabled = false;
                    //btnDelete.Visible = false;
                    btnInsert.Enabled = true;

                }

                if (currentItemInformation[0] != null)
                {
                    for (int i = 0; i < textBoxArray.Length; i++)
                    {

                        textBoxArray[i].Text = currentItemInformation[i];

                    }
                }

                labelArray[0].Text = "CustomerID";
                labelArray[1].Text = "CompanyName";
                labelArray[2].Text = "ContractName";
                labelArray[3].Text = "ContractTitle";
                labelArray[4].Text = "Address";
                labelArray[5].Text = "City";
                labelArray[6].Text = "Region";
                labelArray[7].Text = "PostCode";
                labelArray[8].Text = "Country";
                labelArray[9].Text = "Phone";
                labelArray[10].Text = "Fax";



            
            // Set the user Focus on  the textbox they need to use
                this.ActiveControl = textBoxArray[1];
        }
        /// <summary>
        /// Method name: InitializeArrays
        /// Method description: 
        /// 
        /// Parameter list (one or more lines per parameter): none
        /// Return type and value: N/A
        /// Side effects (if any) including Errors and Exceptions: N/A
        /// Constraints: none
        /// Assumptions: none
        /// Required libraries: 
        ///     System.Web.UI.WebControls;
        ///     System.Web.UI.WebControls.WebParts;
        ///     System.Web.UI.HtmlControls;
        /// Any warnings for maintenance: none
        /// Unresolved issues: none
        /// </summary>
        private void InitializeArrays()
        {
            // First create arrays of 6 references
            // No Label or TextBox objects are created
            // They already exist, we are simply going to give them another set of names
            // that are array elements
            labelArray = new Label[11];
            textBoxArray = new TextBox[11];

            // Now assign the Controls to their array references
            //labelArray[0] = lblCustomerID;
            //labelArray[1] = lblCompanyName;
            //labelArray[2] = lblPhone;


            textBoxArray[0] = txtCustomerID;
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


            // Now we can manipulate the controls using the arrays
        } // end of InitializeArrays

        # endregion



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
        /// Required libraries: System.Data.OleDb;
        /// Any warnings for maintenance: none
        /// Unresolved issues: none
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">System.EventArgs</param>
        protected void btnReturn_Click(object sender, EventArgs e)
        {
            // Clear the current item
            this.Close();

        }
        #endregion

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
            //    txtCompanyName.Focus();
            //}
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtCompanyName.Focus();
            }



        }

        /// <summary>
        /// Method name: UpdateByID
        /// Method description: 
        /// invoke by method btnUpdate_Click(object sender, EventArgs e)
        /// it is to update Customer information 
        /// through call method updateCustomerInfo of business object 
        /// which is store in Session varable.
        /// Parameter list (one or more lines per parameter): CustomerID-String
        /// Return type and value: N/A
        /// Side effects (if any) including Errors and Exceptions:
        /// "Updating causes a problem:Miss required information!Please check follow filed: CustomerName."
        /// Constraints: require field, such as name, can not be empty
        /// Assumptions: none
        /// Required libraries: 
        ///     using System;
        ///     System.Data;
        ///     System.Web.UI.WebControls;
        ///     System.Web.UI.WebControls.WebParts;
        ///     System.Web.UI.HtmlControls;
        /// Any warnings for maintenance: none
        /// Unresolved issues: none
        /// </summary>
        private void UpdateByID(String pkValue, String[] noPKvalue)
        {

            //String[] key = new String[labelArray.Length-1 ];
            //String[] value = new String[textBoxArray.Length-1 ];

            //for (int i = 0; i < labelArray.Length ; i++)
            //{
            //    key[i] = labelArray[i+1].Text;
            //    value[i] = textBoxArray[i+1].Text;
            //}

                business.updateCustomerInfo(pkValue, noPKvalue);


        }

        # endregion

        private String getPkValue()
        {
            return textBoxArray[0].Text;
        }
        private String[] getNoPkValue()
        {
            //        String[] key = new String[labelArray.Length - 1];
            String[] value = new String[textBoxArray.Length - 1];

            for (int i = 0; i < value.Length; i++)
            {
                //            key[i] = labelArray[i + 1].Text;
                value[i] = textBoxArray[i + 1].Text;
            }

            return value;
        }

        /// <summary>
        /// Method name: isRequiredFiledEmpty
        /// Method description: 
        /// Check whether the name filed is un-filed 
        /// before commit unpdate process.
        /// Parameter list (one or more lines per parameter): none
        /// Return type and value: bool
        /// Side effects (if any) including Errors and Exceptions: N/A
        /// Constraints: none
        /// Assumptions: none
        /// Required libraries: 
        ///     System.Web.UI.WebControls;
        ///     System.Web.UI.WebControls.WebParts;
        ///     System.Web.UI.HtmlControls;
        /// Any warnings for maintenance: none
        /// Unresolved issues: none
        /// </summary>
        private Boolean reqiredfieldValidate()
        {
            string companyName = textBoxArray[1].Text.Trim();
            string CustomerID = textBoxArray[0].Text.Trim();

            if (companyName.Length == 0)
            {
                lblWarningMessage.Text = "Missing required information: companyName.";
                return false;
            }

            if (CustomerID.Length == 0)
            {
                lblWarningMessage.Text = "Missing required information: CustomerID.";
                return false;
            }
            return true;
        }


        # region insert new Customer record

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
        ///     System.Web.UI.WebControls;
        ///     System.Web.UI.WebControls.WebParts;
        ///     System.Web.UI.HtmlControls;
        /// Any warnings for maintenance: none
        /// Unresolved issues: none
        /// </summary>
        private void insertData()
        {

                for (int i = 0; i < CustomerInformation.GetLength(0); i++)
                {
                    if (textBoxArray[0].Text == CustomerInformation[i, 0])
                    {
                        repeatInsertItemID = CustomerInformation[i, 0];
                        throw new System.ArgumentException("Customer ID exist.");

                    }
                }
                business.insertCustomer(textBoxArray[0].Text, getNoPkValue());

        }

        #endregion

    }
}
       