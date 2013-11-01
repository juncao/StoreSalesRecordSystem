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
    /// Class name: FrmShipperItemEdit
    /// Class description: Provide categoried maintenace page
    /// you can view and edit informations of particular shipper.
    /// you can always link back to maintenance page 
    /// you can delete particular shipper record 
    /// by clicking "delete" button.
    /// You can also insert new shipper record
    /// by clicking "insert" button
    /// when insertation, it will check whether 
    /// the shipper name existed in record
    /// if no, commit inserting
    /// otherwise show item existing information
    /// and ask for your action either updating or cancel
    /// cancel is to clear all the filed information filled out
    /// And then employee can re-entery for inserting other record.
    /// Side effects (if any) including Errors and Exceptions:
    /// 1-"Updating causes a problem:Miss required information!Please check follow filed: ShipperName."
    /// 2-"Inserting causes a problem:Miss required information!Please check follow filed: ShipperName."
    /// 3-"Shipper name exist ,You can change the name or update the shipper information."
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
    public partial class frmShippers : Form
    {
        private Business business;
        // A way to simplify other code
        // These are references to arrays of references
        private Label[] labelArray = null;
        private TextBox[] textBoxArray = null;
        string[,] shipperInformation;
        private String EditingItemID = null;
        private String repeatInsertItemID=null;


        public frmShippers(Business business)
        {
            this.business = business;
            InitializeComponent();
            this.Text = "Add New Shipper Form";
        }

        public frmShippers(String EditingItemID, Business business)
        {
            //theButton = (Button)senderButton;
            this.business = business;
            this.EditingItemID = EditingItemID;
            InitializeComponent();
            this.Text = "Editing: ShipperID " + EditingItemID;
        }


        #region page_load and initialize array
        /// <summary>
        /// Method name: Page_Load
        /// Method description: 
        /// get all shippers informations from business object which
        /// is store in Session varable
        /// Show information for particular shipper
        /// show some button for editing the shipper
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
        private void frmShippers_Load(object sender, EventArgs e)
        {
            InitializeArrays();

            shipperInformation = business.getShippersInformation();
            string[] currentItemInformation = new string[shipperInformation.GetLength(1)];

            //theButton.Enabled = false;

                if (EditingItemID != null)
                {
                    // Loading up Shippers in combo list
                    for (int i = 0; i < shipperInformation.GetLength(0); i++)
                    {
                        if (EditingItemID == shipperInformation[i, 0])
                        {
                            for (int j = 0; j < currentItemInformation.Length; j++)
                            {
                                currentItemInformation[j] = shipperInformation[i, j];
                            }
                        }
                    }

                    //Edit:Update,Delete
                    btnUpdate.Enabled= true;
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
                    textBoxArray[0].Text = currentItemInformation[0];
                    textBoxArray[1].Text = currentItemInformation[1];
                    textBoxArray[2].Text = currentItemInformation[2];


                }

                labelArray[0].Text = "ShipperID";
                labelArray[1].Text = "CompanyName";
                labelArray[2].Text = "phone";



            
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
            labelArray = new Label[3];
            textBoxArray = new TextBox[3];

            // Now assign the Controls to their array references
            labelArray[0] = lblShipperID;
            labelArray[1] = lblCompanyName;
            labelArray[2] = lblPhone;

            textBoxArray[0] = txtShipperID;
            textBoxArray[1] = txtCompanyName;
            textBoxArray[2] = txtPhone;

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

        #region update Shipper information
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
        /// it is to update Shipper information 
        /// through call method updateShipperInfo of business object 
        /// which is store in Session varable.
        /// Parameter list (one or more lines per parameter): ShipperID-String
        /// Return type and value: N/A
        /// Side effects (if any) including Errors and Exceptions:
        /// "Updating causes a problem:Miss required information!Please check follow filed: ShipperName."
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

                business.updateShipperInfo(pkValue, noPKvalue);


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


            if (companyName.Length == 0)
            {
                lblWarningMessage.Text = "Missing required information: companyName.";
                return false;
            }
            return true;

        }



        # region insert new shipper record

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
                txtCompanyName.Focus();
            }

        }

        /// <summary>
        /// Method name: insertData
        /// Method description: 
        /// invoke by method btnInsert_Click(object sender, EventArgs e)
        /// it is to insert new shipper record to database 
        /// through call method insertShipper of business object 
        /// which is store in Session varable.
        /// Parameter list (one or more lines per parameter): shipperID-String
        /// Return type and value: N/A
        /// Side effects (if any) including Errors and Exceptions:
        /// 1-"Shipper name exist <br>You can change the name or update the customer information."
        /// 2-"Inserting causes a problem:Miss required information!Please check follow filed: ShipperName."
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

           business.insertShipper(textBoxArray[0].Text, getNoPkValue());

        }

        #endregion

        


    }
}