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
    /// Class name: FrmcategoryItemEdit
    /// Class description: Provide categoried maintenace page
    /// you can view and edit informations of particular category.
    /// you can always link back to maintenance page 
    /// you can delete particular category record 
    /// by clicking "delete" button.
    /// You can also insert new category record
    /// by clicking "insert" button
    /// when insertation, it will check whether 
    /// the category name existed in record
    /// if no, commit inserting
    /// otherwise show item existing information
    /// and ask for your action either updating or cancel
    /// cancel is to clear all the filed information filled out
    /// And then employee can re-entery for inserting other record.
    /// Side effects (if any) including Errors and Exceptions:
    /// 1-"Updating causes a problem:Miss required information!Please check follow filed: categoryName."
    /// 2-"Inserting causes a problem:Miss required information!Please check follow filed: categoryName."
    /// 3-"category name exist ,You can change the name or update the category information."
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
    public partial class frmCategories : Form
    {
        private Business business;
        // A way to simplify other code
        // These are references to arrays of references
        private Label[] labelArray = null;
        private TextBox[] textBoxArray = null;
        string[,] categoryInformation;
        private String EditingItemID = null;
        private String repeatInsertItemID = null;
        private byte[] thisPicture;
        string updatePicture = null;
        public frmCategories(Business business)
        {
            this.business = business;
            InitializeComponent();
            this.Text = "Add New Category Form";
        }

        public frmCategories(String EditingItemID, Business business, Byte[] picture)
        {
            //theButton = (Button)senderButton;
            thisPicture = picture;
            this.business = business;
            this.EditingItemID = EditingItemID;
            InitializeComponent();
            this.Text = "Editing: CategoryID " + EditingItemID;
        }


        #region page_load and initialize array
        /// <summary>
        /// Method name: Page_Load
        /// Method description: 
        /// get all Categories informations from business object which
        /// is store in Session varable
        /// Show information for particular category
        /// show some button for editing the category
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
        private void frmCategories_Load(object sender, EventArgs e)
        {
            InitializeArrays();

            categoryInformation = business.getCategoryInformation(); ;
            string[] currentItemInformation = new string[categoryInformation.GetLength(1)];

            //theButton.Enabled = false;

            if (EditingItemID != null)
            {
                // Loading up Categories in combo list
                for (int i = 0; i < categoryInformation.GetLength(0); i++)
                {
                    if (EditingItemID == categoryInformation[i, 0])
                    {
                        for (int j = 0; j < currentItemInformation.Length; j++)
                        {
                            currentItemInformation[j] = categoryInformation[i, j];
                        }
                    }
                }

                //Edit:Update,Delete
                btnUpdate.Visible = true;
                btnInsert.Enabled = false;

            }
            else
            {
                //no-editing action
                btnUpdate.Enabled = false;
            }

            if (currentItemInformation[0] != null)
            {
                textBoxArray[0].Text = currentItemInformation[0];
                textBoxArray[1].Text = currentItemInformation[1];
                textBoxArray[2].Text = currentItemInformation[2];
            }

            labelArray[0].Text = "categoryID";
            labelArray[1].Text = "categoryName";
            labelArray[2].Text = "description";
            labelArray[3].Text = "picture";



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
            labelArray = new Label[4];
            textBoxArray = new TextBox[3];

            // Now assign the Controls to their array references
            labelArray[0] = lblCategoryID;
            labelArray[1] = lblCategoryName;
            labelArray[2] = lblDescription;
            labelArray[3] = lblPicture;

            textBoxArray[0] = txtCategoryID;
            textBoxArray[1] = txtCategoryName;
            textBoxArray[2] = txtDescription;
            ///thePictureBox=thisPicture;//how to do this one?





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
            // Go back to catalog form

        }
        #endregion

        #region update category information
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
                    UpdateByID(getPkValue(), getNoPkValue(), getPicture());
                    MessageBox.Show("Update successfully!");
                    this.Close();
                }
            }
            //catch (ArgumentNullException arEx)
            //{
            //    MessageBox.Show(arEx.Message);
            //    txtCategoryName.Focus();
            //}
            catch (Exception ex)
            {
                lblWarningMessage.Text = ex.Message;
                textBoxArray[1].Focus();
            }

        }

        /// <summary>
        /// Method name: UpdateByID
        /// Method description: 
        /// invoke by method btnUpdate_Click(object sender, EventArgs e)
        /// it is to update category information 
        /// through call method updatecategoryInfo of business object 
        /// which is store in Session varable.
        /// Parameter list (one or more lines per parameter): categoryID-String
        /// Return type and value: N/A
        /// Side effects (if any) including Errors and Exceptions:
        /// "Updating causes a problem:Miss required information!Please check follow filed: categoryName."
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
        private void UpdateByID(String pkValue, String[] noPKvalue,Byte[] thePicture)
        {

            //String[] key = new String[labelArray.Length-1 ];
            //String[] value = new String[textBoxArray.Length-1 ];

            //for (int i = 0; i < labelArray.Length ; i++)
            //{
            //    key[i] = labelArray[i+1].Text;
            //    value[i] = textBoxArray[i+1].Text;
            //}

                business.updateCategoryInfo(pkValue, noPKvalue, thePicture);


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


        private Byte[] getPicture()
        {

            byte[] picture=null;
            if (updatePicture!=null)
            {

                Image img = Image.FromFile(updatePicture);
                using (MemoryStream ms = new MemoryStream())
                {
                    img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    picture = ms.ToArray();
                }
            }

            return picture;
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
            Boolean allPassed = true;
            string categoryName = textBoxArray[1].Text.Trim();

            if (updatePicture != null)
            {
                lblWarningMessage.Text = "Invaid image format.";
                allPassed = false;
            }

            if (categoryName.Length == 0)
            {
                lblWarningMessage.Text = "Missing required information: categoryName.";
                allPassed = false;
            }

            return allPassed;
        }


        # region insert new category record

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
                        updatePicture = null;
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
                lblWarningMessage.Text = otherEx.Message;
            }

        }

        /// <summary>
        /// Method name: insertData
        /// Method description: 
        /// invoke by method btnInsert_Click(object sender, EventArgs e)
        /// it is to insert new category record to database 
        /// through call method insertcategory of business object 
        /// which is store in Session varable.
        /// Parameter list (one or more lines per parameter): categoryID-String
        /// Return type and value: N/A
        /// Side effects (if any) including Errors and Exceptions:
        /// 1-"category name exist <br>You can change the name or update the customer information."
        /// 2-"Inserting causes a problem:Miss required information!Please check follow filed: categoryName."
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



                for (int i = 0; i < categoryInformation.GetLength(0); i++)
                {
                    if (textBoxArray[0].Text == categoryInformation[i, 0])
                    {
                        repeatInsertItemID = categoryInformation[i, 0];
                        lblWarningMessage.Text ="category ID exist, please change another one.";

                    }
                }
                business.insertCategory(getNoPkValue(),getPicture());

        }

        #endregion


        private void btnUploadNewPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog newPicture = new OpenFileDialog();
            newPicture.InitialDirectory = "c:\\";
            newPicture.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (newPicture.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    updatePicture = newPicture.FileName;
                    // display image in picture box
                    picPicture.Image = new Bitmap(newPicture.FileName);
                    btnDeleteUploadedPicture.Enabled = true;

                }
                catch (Exception ex)
                {
                    lblWarningMessage.Text ="Could not read file from disk: " + ex.Message;
                }
            }

        }

        private void btnDeleteUploadedPicture_Click(object sender, EventArgs e)
        {
            picPicture.Image = null;
            updatePicture = null;
            btnDeleteUploadedPicture.Enabled = false;
        }
    }
}