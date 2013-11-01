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
    /// Class name: FrmEmployeeItemEdit
    /// Class description: Provide categoried maintenace page
    /// you can view and edit informations of particular Employee.
    /// you can always link back to maintenance page 
    /// you can delete particular Employee record 
    /// by clicking "delete" button.
    /// You can also insert new Employee record
    /// by clicking "insert" button
    /// when insertation, it will check whether 
    /// the Employee name existed in record
    /// if no, commit inserting
    /// otherwise show item existing information
    /// and ask for your action either updating or cancel
    /// cancel is to clear all the filed information filled out
    /// And then employee can re-entery for inserting other record.
    /// Side effects (if any) including Errors and Exceptions:
    /// 1-"Updating causes a problem:Miss required information!Please check follow filed: EmployeeName."
    /// 2-"Inserting causes a problem:Miss required information!Please check follow filed: EmployeeName."
    /// 3-"Employee name exist ,You can change the name or update the Employee information."
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
    public partial class frmEmployees : Form
    {
        private Business business;
        // A way to simplify other code
        // These are references to arrays of references
        //private Label[] labelArray = null;
        private TextBox[] textBoxArray = null;
        private DateTimePicker[] dateTimePickerArray = null;
        string[,] EmployeeInformation;
        private String EditingItemID = null;


        public frmEmployees(Business business)
        {
            this.business = business;
            InitializeComponent();
            this.Text = "Add New Employee Form";
        }

        public frmEmployees(String EditingItemID, Business business)
        {
            //theButton = (Button)senderButton;
            this.business = business;
            this.EditingItemID = EditingItemID;
            InitializeComponent();
            this.Text = "Editing: EmployeeID " + EditingItemID;
        }


        #region page_load and initialize array
        /// <summary>
        /// Method name: Page_Load
        /// Method description: 
        /// get all Employees informations from business object which
        /// is store in Session varable
        /// Show information for particular Employee
        /// show some button for editing the Employee
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
        private void frmEmployees_Load(object sender, EventArgs e)
        {
            InitializeArrays();

            EmployeeInformation = business.getEmployeesInformation();
            string[] currentItemInformation = new string[EmployeeInformation.GetLength(1)];

            //theButton.Enabled = false;

                if (EditingItemID != null)
                {
                    // Loading up Employees in combo list
                    for (int i = 0; i < EmployeeInformation.GetLength(0); i++)
                    {
                        if (EditingItemID == EmployeeInformation[i, 0])
                        {
                            for (int j = 0; j < currentItemInformation.Length; j++)
                            {
                                currentItemInformation[j] = EmployeeInformation[i, j];
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


                    //for (int i = 0; i < textBoxArray.Length;i++ )
                    //{
                    //    textBoxArray[i].Text = currentItemInformation[i];
                    //}     

                    for (int i = 0; i < 5; i++)
                    {

                        textBoxArray[i].Text = currentItemInformation[i];

                    }

                    dateTimePickerArray[0].Text = currentItemInformation[5];
                    dateTimePickerArray[1].Text = currentItemInformation[6];
                    for (int i = 5; i < textBoxArray.Length; i++)
                    {

                        textBoxArray[i].Text = currentItemInformation[i+2];

                    }


                }

                //labelArray[0].Text = "EmployeeID";
                //labelArray[1].Text = "lastName";
                //labelArray[2].Text = "firstName";
                //labelArray[3].Text = "title";
                //labelArray[4].Text = "titleOfCourtesy";
                //labelArray[5].Text = "birthDate";
                //labelArray[6].Text = "hireDate";
                //labelArray[7].Text = "address";
                //labelArray[8].Text = "city";
                //labelArray[9].Text = "region";
                //labelArray[10].Text = "postalCode";
                //labelArray[11].Text = "Country";
                //labelArray[12].Text = "homePhone";
                //labelArray[13].Text = "extension";
                //labelArray[14].Text = "photo";
                //labelArray[15].Text = "reportsTo";
                //labelArray[16].Text = "notes";

            
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
            //labelArray = new Label[17];
            textBoxArray = new TextBox[15];
            dateTimePickerArray = new DateTimePicker[2];

            // Now assign the Controls to their array references
            //labelArray[0] = lblEmployeeID;
            //labelArray[1] = lblLastName;
            //labelArray[2] = lblFirstName;
            //labelArray[3] = lblTitle;
            //labelArray[4] = lblTitleOfCourtesy;
            //labelArray[5] = lblBirthDate;
            //labelArray[6] = lblHireDate;
            //labelArray[7] = lblAddress;
            //labelArray[8] = lblCity;
            //labelArray[9] = lblRegion;
            //labelArray[10] = lblPostalCode;
            //labelArray[11] = lblCountry;
            //labelArray[12] = lblHomePhone;
            //labelArray[13] = lblExtension;
            //labelArray[14] = lblPhoto;
            //labelArray[15] = lblReportsTo;
            //labelArray[16] = lblNotes;
            //labelArray[17] = lblNotes;


            textBoxArray[0] = txtEmployeeID;
            textBoxArray[1] = txtLastName;
            textBoxArray[2] = txtFirstName;
            textBoxArray[3] = txtTitle;
            textBoxArray[4] = txtTitleOfCourtesy;
            textBoxArray[5] = txtAddress;
            textBoxArray[6] = txtCity;
            textBoxArray[7] = txtRegion;
            textBoxArray[8] = txtPostalCode;
            textBoxArray[9] = txtCountry;
            textBoxArray[10] = txtHomePhone;
            textBoxArray[11] = txtExtension;
            textBoxArray[12] = txtPhoto;
            textBoxArray[13] = txtNotes;
            textBoxArray[14] = txtReportsTo;


            dateTimePickerArray[0] = dtpBirthDate;
            dateTimePickerArray[1] = dtpHireDate;
          
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

        #region update Employee information
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
                MessageBox.Show(ex.Message);
                textBoxArray[1].Focus();
            }


        }

        /// <summary>
        /// Method name: UpdateByID
        /// Method description: 
        /// invoke by method btnUpdate_Click(object sender, EventArgs e)
        /// it is to update Employee information 
        /// through call method updateEmployeeInfo of business object 
        /// which is store in Session varable.
        /// Parameter list (one or more lines per parameter): EmployeeID-String
        /// Return type and value: N/A
        /// Side effects (if any) including Errors and Exceptions:
        /// "Updating causes a problem:Miss required information!Please check follow filed: EmployeeName."
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


                business.updateEmployeeInfo(pkValue, noPKvalue);

                


        }

        # endregion

        private String getPkValue()
        {
            return textBoxArray[0].Text;
        }
        private String[] getNoPkValue()
        {
            //        String[] key = new String[labelArray.Length - 1];
            String[] value = new String[textBoxArray.Length+1];

            for (int i = 0; i < 4; i++)
            {

                value[i] = textBoxArray[i + 1].Text;

            }

            value[4] = dateTimePickerArray[0].Text;
            value[5] = dateTimePickerArray[1].Text;
            for (int i = 6; i < textBoxArray.Length+1; i++)
            {

               value[i] = textBoxArray[i -1].Text;

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

        private Boolean numberAndReqiredfieldValidate() 
        {
            Boolean allPassed = true;
            string lastName=textBoxArray[1].Text.Trim();
            string firstName=textBoxArray[2].Text.Trim();
            string reportsTo = textBoxArray[14].Text.Trim();
            DateTime today = DateTime.Today;
            int intValue;

            if (reportsTo.Length != 0)
            {
                if (!int.TryParse(reportsTo, out intValue))
                {
                    lblWarningMessage.Text = "Invalid format: reportsTo.";
                    allPassed = false;
                }

            }
            if (Convert.ToDateTime(dateTimePickerArray[0].Text) >= today)
            {
                lblWarningMessage.Text = "Brith Date have to be ealier than today.";
                allPassed = false;
            }
            if (Convert.ToDateTime(dateTimePickerArray[1].Text) >= today)
            {
                lblWarningMessage.Text = "Hire Date have to be ealier than today.";
                allPassed = false;
            }
            if (lastName.Length == 0)
            {
                lblWarningMessage.Text = "Missing required information: lastName.";
                allPassed = false;
            }
            if (firstName.Length == 0)
            {
                lblWarningMessage.Text = "Missing required information: firstName.";
                allPassed = false;
            }
            
            return allPassed;
        }




        # region insert new Employee record

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
                        foreach (TextBox t in textBoxArray)
                        {
                            t.Text = "";
                        }
                        dtpBirthDate.Value = DateTime.Now;
                        dtpHireDate.Value = DateTime.Now;
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        this.Close();
                    }
                }

            }
            catch (Exception otherEx)
            {
                lblWarningMessage.Text = otherEx.Message;
            }

        }

        /// <summary>
        /// Method name: insertData
        /// Method description: 
        /// invoke by method btnInsert_Click(object sender, EventArgs e)
        /// it is to insert new Employee record to database 
        /// through call method insertEmployee of business object 
        /// which is store in Session varable.
        /// Parameter list (one or more lines per parameter): EmployeeID-String
        /// Return type and value: N/A
        /// Side effects (if any) including Errors and Exceptions:
        /// 1-"Employee name exist <br>You can change the name or update the customer information."
        /// 2-"Inserting causes a problem:Miss required information!Please check follow filed: EmployeeName."
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

                //for (int i = 0; i < EmployeeInformation.GetLength(0); i++)
                //{
                //    if (textBoxArray[1].Text == EmployeeInformation[i, 1])
                //    {
                //        repeatInsertItemName = EmployeeInformation[i, 1];
                //        throw new System.ArgumentException("Employee Name exist .");

                //    }
                //}
                business.insertEmployee(getNoPkValue());

        }


        #endregion

    }
}