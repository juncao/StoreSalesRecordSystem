using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace Project2
{


    /// <summary>
    /// Class name: Maintenance
    /// Class description: Provide categoried maintenace page
    /// included customer,employee,product,category,shipper,and supplier
    /// in multiple view by using tagpages
    /// in each tabpage
    /// you can view partial information of  every maintanacing item in each row.
    /// Paging the list of every maintanacing.
    /// you can link to ItemEdit page to update information for every items
    /// You can also insert new record
    /// by clicking "insert" button 
    /// and then going to ItemEdit page
    /// for making inserting  
    /// Side effects (if any) including Errors and Exceptions: N/A
    /// Constraints: none
    /// Assumptions: none
    /// Required libraries: 
    ///     using System;
    ///     System.Data;
    ///     System.Web.UI.WebControls;
    ///     System.Web.UI.WebControls.WebParts;
    ///     System.Web.UI.HtmlControls;
    ///     System.Data.OleDb;
    ///     System.Drawing;
    /// Any warnings for maintenance: none
    /// Unresolved issues: none
    /// </summary>
    public partial class frmMaintenace : Form
    {

        private Business myBusiness;

        private frmCategories myfrmCategories;
        private frmCustomers myfrmCustomers;
        private frmEmployees myfrmEmployees;
        private frmProducts myfrmProducts;
        private frmShippers myfrmShippers;
        private frmSuppliers myfrmSuppliers;

        private enum TabPage { tabPageCustomers, tabPageEmployees, tabPageProducts, tabPageShippers, tabPageSuppliers, tabPageCategories };
        private TabPage currenTagPage ;

        public delegate void Update();

        #region constructer public frmMaintenace(Business myBusiness)
        /// <summary>
        /// initialize component
        /// assign Business reference to myBusiness of this page
        /// </summary>
        /// <param name="myBusiness">Business reference type allowing to pass bussiness object reference to this from</param>
        public frmMaintenace(Business myBusiness)
        {
            InitializeComponent();
            this.myBusiness = myBusiness;
            //FillCustomerGrid();
        }

        #endregion

        #region private void frmMaintenace_Load(object sender, EventArgs e)
        /// <summary>
        /// Method name: frmMaintenace_Load
        /// Method description: This method is to handle the form load event
        /// it is to assign the form text
        /// fill every datagridview with related imformation
        /// register delegates to relative events
        /// Parameter list (one or more lines per parameter): sender and e
        /// Return type and value: N/A
        /// Side effects (if any) including Errors and Exceptions: N/A
        /// Constraints: none
        /// Assumptions: none
        /// Required libraries: System.Data.OleDb;
        /// Any warnings for maintenance: none
        /// Unresolved issues: none
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">System.EventArgs</param>
        private void frmMaintenace_Load(object sender, EventArgs e)
        {
            this.Text = "Maintenace Form";
            FillCustomerGrid();
            FillProductGrid();
            FillEmployeeGrid();
            FillCategoryGrid();
            FillShipperGrid();
            FillSupplierGrid();

            myBusiness.employeeInfChangeEvent += new Update(FillEmployeeGrid);
            myBusiness.customerInfChangeEvent += new Update(FillCustomerGrid);
            myBusiness.productInfChangeEvent += new Update(FillProductGrid);
            myBusiness.categoryInfChangeEvent += new Update(FillCategoryGrid);
            myBusiness.ShipperInfChangeEvent += new Update(FillShipperGrid);
           // myBusiness.ShipperInfChangeEvent += new Update(FreshShipperGrid);
            myBusiness.SupplierInfChangeEvent += new Update(FillSupplierGrid);
        }

        #endregion
        //private void FreshShipperGrid()
        //{
        //    this.dgShippers.Refresh();
        //}
        #region fill gird methods

        /// <summary>
        /// Method name: FillCustomerGrid()
        /// Method description: This method is to get customer information
        /// from Business reference
        /// and fill the information in datagridview by assigning edited table
        /// as its source
        /// Parameter list (one or more lines per parameter): N/A
        /// Return type and value: N/A
        /// Side effects (if any) including Errors and Exceptions: N/A
        /// Constraints: none
        /// Assumptions: none
        /// Required libraries: System.Data.OleDb;
        /// Any warnings for maintenance: none
        /// Unresolved issues: none
        /// </summary>
        private void FillCustomerGrid()
        {
            dgCustomers.DataSource = null;

            string[,] customerInformation = myBusiness.getCustomerInformation();

            DataTable tbCustomer = new DataTable("Customer");

            DataColumn customerIDCol = new DataColumn("CustomerID");
            customerIDCol.ReadOnly = false;
            customerIDCol.DataType = System.Type.GetType("System.String");
            tbCustomer.Columns.Add(customerIDCol);

            DataColumn companyNameCol = new DataColumn("CompanyName");
            companyNameCol.ReadOnly = false;
            companyNameCol.DataType = System.Type.GetType("System.String");
            tbCustomer.Columns.Add(companyNameCol);

            DataColumn contactNameCol = new DataColumn("ContactName");
            contactNameCol.ReadOnly = false;
            contactNameCol.DataType = System.Type.GetType("System.String");
            tbCustomer.Columns.Add(contactNameCol);

            DataColumn ContactTitleCol = new DataColumn("ContactTitle");
            ContactTitleCol.ReadOnly = false;
            ContactTitleCol.DataType = System.Type.GetType("System.String");
            tbCustomer.Columns.Add(ContactTitleCol);

            // Loading up Customers in combo list
            for (int i = 0; i < customerInformation.GetLength(0); i++)
            {
                DataRow row = tbCustomer.NewRow();

                row["CustomerID"] = customerInformation[i, 0];
                row["CompanyName"] = customerInformation[i, 1];
                row["ContactName"] = customerInformation[i, 2];
                row["ContactTitle"] = customerInformation[i, 3];
                tbCustomer.Rows.Add(row);

            }

            dgCustomers.DataSource = tbCustomer;
            //dgCustomers.DataBind();

        }

        /// <summary>
        /// Method name: FillCustomerGrid()
        /// Method description: This method is to get customer information
        /// from Business reference
        /// and fill the information in datagridview by assigning edited table
        /// as its source
        /// Parameter list (one or more lines per parameter): N/A
        /// Return type and value: N/A
        /// Side effects (if any) including Errors and Exceptions: N/A
        /// Constraints: none
        /// Assumptions: none
        /// Required libraries: System.Data.OleDb;
        /// Any warnings for maintenance: none
        /// Unresolved issues: none
        /// </summary>
        private void FillEmployeeGrid()
        {

            string[,] employeeInformation = myBusiness.getEmployeesInformation();

            DataTable tbEmployee = new DataTable("Employee");

            DataColumn employeeIDCol = new DataColumn("EmployeeID");
            employeeIDCol.ReadOnly = false;
            employeeIDCol.DataType = System.Type.GetType("System.String");
            tbEmployee.Columns.Add(employeeIDCol);

            DataColumn lastNameCol = new DataColumn("LastName");
            lastNameCol.ReadOnly = false;
            lastNameCol.DataType = System.Type.GetType("System.String");
            tbEmployee.Columns.Add(lastNameCol);

            DataColumn firstNameCol = new DataColumn("FirstName");
            firstNameCol.ReadOnly = false;
            firstNameCol.DataType = System.Type.GetType("System.String");
            tbEmployee.Columns.Add(firstNameCol);

            DataColumn titleCol = new DataColumn("Title");
            titleCol.ReadOnly = false;
            titleCol.DataType = System.Type.GetType("System.String");
            tbEmployee.Columns.Add(titleCol);



            // Loading up Categories in combo list
            for (int i = 0; i < employeeInformation.GetLength(0); i++)
            {
                DataRow row = tbEmployee.NewRow();

                row["EmployeeID"] = employeeInformation[i, 0];
                row["LastName"] = employeeInformation[i, 1];
                row["FirstName"] = employeeInformation[i, 2];
                row["Title"] = employeeInformation[i, 3];

                tbEmployee.Rows.Add(row);
            }

            dgEmployees.DataSource = tbEmployee;
            
        }

        /// <summary>
        /// Method name: FillCustomerGrid()
        /// Method description: This method is to get customer information
        /// from Business reference
        /// and fill the information in datagridview by assigning edited table
        /// as its source
        /// Parameter list (one or more lines per parameter): N/A
        /// Return type and value: N/A
        /// Side effects (if any) including Errors and Exceptions: N/A
        /// Constraints: none
        /// Assumptions: none
        /// Required libraries: System.Data.OleDb;
        /// Any warnings for maintenance: none
        /// Unresolved issues: none
        /// </summary>
        private void FillCategoryGrid()
        {
 
            dgCategories.DataSource = null;
            string[,] categoryInformation = myBusiness.getCategoryInformation();

            DataTable tbCategory = new DataTable("Category");

            DataColumn CategoryPicureCol = new DataColumn("CategoryPicure");
            CategoryPicureCol.ReadOnly = false;
            CategoryPicureCol.DataType = System.Type.GetType("System.Byte[]");
            tbCategory.Columns.Add(CategoryPicureCol);

            DataColumn CategoryIDCol = new DataColumn("CategoryID");
            CategoryIDCol.ReadOnly = false;
            CategoryIDCol.DataType = System.Type.GetType("System.String");
            tbCategory.Columns.Add(CategoryIDCol);

            DataColumn CategoryNameCol = new DataColumn("CategoryName");
            CategoryNameCol.ReadOnly = false;
            CategoryNameCol.DataType = System.Type.GetType("System.String");
            tbCategory.Columns.Add(CategoryNameCol);

            DataColumn DescriptionCol = new DataColumn("Description");
            DescriptionCol.ReadOnly = false;
            DescriptionCol.DataType = System.Type.GetType("System.String");
            tbCategory.Columns.Add(DescriptionCol);

            SortedList pictures = myBusiness.getCategoryPictureList();
            // Loading up Categories in combo list
            for (int i = 0; i < categoryInformation.GetLength(0); i++)
            {
                DataRow row = tbCategory.NewRow();
                Byte[] picture = (Byte[])(pictures[int.Parse(categoryInformation[i, 0])]);

                row["CategoryPicure"] = picture;
                row["CategoryID"] = categoryInformation[i, 0];
                row["CategoryName"] = categoryInformation[i, 1];
                row["Description"] = categoryInformation[i, 2];

                tbCategory.Rows.Add(row);


            }
            dgCategories.DataSource = tbCategory;



        }


        /// <summary>
        /// Method name: FillCustomerGrid()
        /// Method description: This method is to get customer information
        /// from Business reference
        /// and fill the information in datagridview by assigning edited table
        /// as its source
        /// Parameter list (one or more lines per parameter): N/A
        /// Return type and value: N/A
        /// Side effects (if any) including Errors and Exceptions: N/A
        /// Constraints: none
        /// Assumptions: none
        /// Required libraries: System.Data.OleDb;
        /// Any warnings for maintenance: none
        /// Unresolved issues: none
        /// </summary>
        private void FillProductGrid()
        {
            dgProducts.DataSource = null;
            string[,] productsInformation = myBusiness.getProductsInformation();


            DataTable tbProducts = new DataTable("Products");


            DataColumn productIDCol = new DataColumn("ProductID");
            productIDCol.ReadOnly = false;
            productIDCol.DataType = System.Type.GetType("System.String");
            tbProducts.Columns.Add(productIDCol);


            DataColumn productNameCol = new DataColumn("ProductName");
            productNameCol.ReadOnly = false;
            productNameCol.DataType = System.Type.GetType("System.String");
            tbProducts.Columns.Add(productNameCol);

            DataColumn productUnitPriceCol = new DataColumn("UnitPrice");
            productUnitPriceCol.ReadOnly = false;
            productUnitPriceCol.DataType = System.Type.GetType("System.String");
            tbProducts.Columns.Add(productUnitPriceCol);

            for (int i = 0; i < productsInformation.GetLength(0); i++)
            {
                DataRow row = tbProducts.NewRow();

                row["ProductID"] = productsInformation[i, 0];
                row["ProductName"] = productsInformation[i, 1];
                row["UnitPrice"] = productsInformation[i, 7];

                tbProducts.Rows.Add(row);
            }

            dgProducts.DataSource = tbProducts;

            //dgProducts.DataBind();
        }


        /// <summary>
        /// Method name: FillCustomerGrid()
        /// Method description: This method is to get customer information
        /// from Business reference
        /// and fill the information in datagridview by assigning edited table
        /// as its source
        /// Parameter list (one or more lines per parameter): N/A
        /// Return type and value: N/A
        /// Side effects (if any) including Errors and Exceptions: N/A
        /// Constraints: none
        /// Assumptions: none
        /// Required libraries: System.Data.OleDb;
        /// Any warnings for maintenance: none
        /// Unresolved issues: none
        /// </summary>
        private void FillShipperGrid()
        {
            dgShippers.DataSource = null;

            string[,] shippersInformation = myBusiness.getShippersInformation();


            DataTable tbShippers = new DataTable("Shippers");


            DataColumn ShipperIDCol = new DataColumn("ShipperID");
            ShipperIDCol.ReadOnly = false;
            ShipperIDCol.DataType = System.Type.GetType("System.String");
            tbShippers.Columns.Add(ShipperIDCol);


            DataColumn CompanyNameCol = new DataColumn("CompanyName");
            CompanyNameCol.ReadOnly = false;
            CompanyNameCol.DataType = System.Type.GetType("System.String");
            tbShippers.Columns.Add(CompanyNameCol);

            DataColumn PhoneCol = new DataColumn("Phone");
            PhoneCol.ReadOnly = false;
            PhoneCol.DataType = System.Type.GetType("System.String");
            tbShippers.Columns.Add(PhoneCol);

            for (int i = 0; i < shippersInformation.GetLength(0); i++)
            {
                DataRow row = tbShippers.NewRow();

                row["ShipperID"] = shippersInformation[i, 0];
                row["CompanyName"] = shippersInformation[i, 1];
                row["Phone"] = shippersInformation[i, 2];

                tbShippers.Rows.Add(row);
            }

            dgShippers.DataSource = tbShippers;

            //dgShippers.DataBind();
        }


        /// <summary>
        /// Method name: FillCustomerGrid()
        /// Method description: This method is to get customer information
        /// from Business reference
        /// and fill the information in datagridview by assigning edited table
        /// as its source
        /// Parameter list (one or more lines per parameter): N/A
        /// Return type and value: N/A
        /// Side effects (if any) including Errors and Exceptions: N/A
        /// Constraints: none
        /// Assumptions: none
        /// Required libraries: System.Data.OleDb;
        /// Any warnings for maintenance: none
        /// Unresolved issues: none
        /// </summary>
        private void FillSupplierGrid()
        {
            dgSuppliers.DataSource = null;

            string[,] SupplierInformation = myBusiness.getSupplierInformation();

            DataTable tbSuppliers = new DataTable("Suppliers");

            DataColumn SupplierIDCol = new DataColumn("SupplierID");
            SupplierIDCol.ReadOnly = false;
            SupplierIDCol.DataType = System.Type.GetType("System.String");
            tbSuppliers.Columns.Add(SupplierIDCol);


            DataColumn CompanyNameCol = new DataColumn("CompanyName");
            CompanyNameCol.ReadOnly = false;
            CompanyNameCol.DataType = System.Type.GetType("System.String");
            tbSuppliers.Columns.Add(CompanyNameCol);

            DataColumn ContactNameCol = new DataColumn("ContactName");
            ContactNameCol.ReadOnly = false;
            ContactNameCol.DataType = System.Type.GetType("System.String");
            tbSuppliers.Columns.Add(ContactNameCol);

            DataColumn ContactTitleCol = new DataColumn("ContactTitle");
            ContactTitleCol.ReadOnly = false;
            ContactTitleCol.DataType = System.Type.GetType("System.String");
            tbSuppliers.Columns.Add(ContactTitleCol);

            for (int i = 0; i < SupplierInformation.GetLength(0); i++)
            {
                DataRow row = tbSuppliers.NewRow();

                row["SupplierID"] = SupplierInformation[i, 0];
                row["CompanyName"] = SupplierInformation[i, 1];
                row["ContactName"] = SupplierInformation[i, 2];
                row["ContactTitle"] = SupplierInformation[i, 3];

                tbSuppliers.Rows.Add(row);
            }

            dgSuppliers.DataSource = tbSuppliers;
        }

        #endregion



        #region Data Grids click
        /// <summary>
        /// Method name: dgCustomers_CellClick
        /// Method description: This method is invoked when edit button column is clicked
        /// it will instantiate and load a Customer edition form
        /// only one customer editing form is provide
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
        /// <param name="e">DataGridViewCellEventArgs</param>
        private void dgCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgCustomers.Columns["ColCustomerEdit"].Index && e.RowIndex >= 0)
            {
                if (myfrmCustomers == null || myfrmCustomers.IsDisposed)
                {
                    int index = e.RowIndex;

                    String EditingItemID = (String)dgCustomers.Rows[index].Cells[1].Value;

                    myfrmCustomers = new frmCustomers(EditingItemID, myBusiness);

                    myfrmCustomers.MdiParent = this.MdiParent;
                }
                myfrmCustomers.Show();
            }
        }

        /// <summary>
        /// Method name: dgCustomers_CellClick
        /// Method description: This method is invoked when edit button column is clicked
        /// it will instantiate and load a Customer edition form
        /// only one customer editing form is provide
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
        /// <param name="e">DataGridViewCellEventArgs</param>
        private void dgEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == dgEmployees.Columns["ColEmployeeEdit"].Index && e.RowIndex >= 0)
            {
                if (myfrmEmployees == null || myfrmEmployees.IsDisposed)
                {
                    int index = e.RowIndex;

                    String EditingItemID = (String)dgEmployees.Rows[index].Cells[1].Value;

                    myfrmEmployees = new frmEmployees(EditingItemID, myBusiness);

                    myfrmEmployees.MdiParent = this.MdiParent;
                }

                myfrmEmployees.Show();
            }
        }

        /// <summary>
        /// Method name: dgCustomers_CellClick
        /// Method description: This method is invoked when edit button column is clicked
        /// it will instantiate and load a Customer edition form
        /// only one customer editing form is provide
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
        /// <param name="e">DataGridViewCellEventArgs</param>
        private void dgCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgCategories.Columns["ColCategoryEdit"].Index && e.RowIndex >= 0)
            {
                if (myfrmCategories == null || myfrmCategories.IsDisposed)
                {
                    int index = e.RowIndex;

                    String EditingItemID = (String)dgCategories.Rows[index].Cells[2].Value;

                    SortedList pictures = myBusiness.getCategoryPictureList();
                    Byte[] picture = (Byte[])(pictures[int.Parse(EditingItemID)]);

                    myfrmCategories = new frmCategories(EditingItemID, myBusiness, picture);

                    myfrmCategories.MdiParent = this.MdiParent;
                }
                myfrmCategories.Show();
            }
        }

        /// <summary>
        /// Method name: dgCustomers_CellClick
        /// Method description: This method is invoked when edit button column is clicked
        /// it will instantiate and load a Customer edition form
        /// only one customer editing form is provide
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
        /// <param name="e">DataGridViewCellEventArgs</param>
        private void dgShippers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgShippers.Columns["ColShipperEdit"].Index && e.RowIndex >= 0)
            {
                if (myfrmShippers == null || myfrmShippers.IsDisposed)
                {
                    int index = e.RowIndex;

                    String EditingItemID = (String)dgShippers.Rows[index].Cells[1].Value;

                    //DataGridViewButtonCell buttonCell =
                    //   (DataGridViewButtonCell)dgShippers.Rows[e.RowIndex].Cells["ColShipperEdit"];

                    myfrmShippers = new frmShippers(EditingItemID, myBusiness);

                    // buttonCell.ReadOnly = false;

                    myfrmShippers.MdiParent = this.MdiParent;
                }
                // myfrmShippers.Text = "Add New Shippers";
                myfrmShippers.Show();
            }
        }

        /// <summary>
        /// Method name: dgCustomers_CellClick
        /// Method description: This method is invoked when edit button column is clicked
        /// it will instantiate and load a Customer edition form
        /// only one customer editing form is provide
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
        /// <param name="e">DataGridViewCellEventArgs</param>
        private void dgProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == dgProducts.Columns["ColProductEdit"].Index && e.RowIndex >= 0)
            {
                if (myfrmProducts == null || myfrmProducts.IsDisposed)
                {
                    int index = e.RowIndex;

                    String EditingItemID = (String)dgProducts.Rows[index].Cells[1].Value;

                    myfrmProducts = new frmProducts(EditingItemID, myBusiness);

                    myfrmProducts.MdiParent = this.MdiParent;
                }
                myfrmProducts.Show();
            }
        }

        /// <summary>
        /// Method name: dgCustomers_CellClick
        /// Method description: This method is invoked when edit button column is clicked
        /// it will instantiate and load a Customer edition form
        /// only one customer editing form is provide
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
        /// <param name="e">DataGridViewCellEventArgs</param>
        private void dgSuppliers_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == dgSuppliers.Columns["ColSupplierEdit"].Index && e.RowIndex >= 0)
            {
                if (myfrmSuppliers == null || myfrmSuppliers.IsDisposed)
                {
                    int index = e.RowIndex;

                    String EditingItemID = (String)dgSuppliers.Rows[index].Cells[1].Value;

                    myfrmSuppliers = new frmSuppliers(EditingItemID, myBusiness);

                    myfrmSuppliers.MdiParent = this.MdiParent;
                }
                myfrmSuppliers.Show();
            }
        }
        #endregion

        /// <summary>
        /// Method name: btnInsert_Click
        /// Method description: This method is to control the form openning
        /// base on current active tabpage.
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
        private void btnInsert_Click(object sender, EventArgs e)
        {

            switch (currenTagPage)
            {
                case  TabPage.tabPageCustomers:
                    if (myfrmCustomers == null || myfrmCustomers.IsDisposed)
                        {
                            myfrmCustomers = new frmCustomers(myBusiness);
                            myfrmCustomers.MdiParent = this.MdiParent;
                        }
                        //myfrmCustomers.Text = "Maintenance for " + this.Text;
                        myfrmCustomers.Show();
                        break;
                case TabPage.tabPageEmployees:
                        if (myfrmEmployees == null || myfrmEmployees.IsDisposed)
                        {
                            myfrmEmployees = new frmEmployees(myBusiness);
                            myfrmEmployees.MdiParent = this.MdiParent;
                        }
                        //myfrmEmployees.Text = "Maintenance for " + this.Text;
                        myfrmEmployees.Show();
                        break;
                case TabPage.tabPageProducts:
                        if (myfrmProducts == null || myfrmProducts.IsDisposed)
                        {
                            myfrmProducts = new frmProducts(myBusiness);
                            myfrmProducts.MdiParent = this.MdiParent;
                        }
                        //myfrmProducts.Text = "Maintenance for " + this.Text;
                        myfrmProducts.Show();
                        break;
                case TabPage.tabPageShippers:
                        if (myfrmShippers == null || myfrmShippers.IsDisposed)
                        {
                            myfrmShippers = new frmShippers(myBusiness);
                            myfrmShippers.MdiParent = this.MdiParent;
                        }
                        //myfrmShippers.Text = "Maintenance for " + this.Text;
                        myfrmShippers.Show();
                        break;
                case TabPage.tabPageSuppliers:
                        if (myfrmSuppliers == null || myfrmSuppliers.IsDisposed)
                        {
                            myfrmSuppliers = new frmSuppliers(myBusiness);
                            myfrmSuppliers.MdiParent = this.MdiParent;
                        }
                        //myfrmSuppliers.Text = "Maintenance for " + this.Text;
                        myfrmSuppliers.Show();
                        break;
                case TabPage.tabPageCategories:
                        if (myfrmCategories == null || myfrmCategories.IsDisposed)
                        {
                            myfrmCategories = new frmCategories(myBusiness);
                            myfrmCategories.MdiParent = this.MdiParent;
                        }
                        //myfrmCategories.Text = "Maintenance for " + this.Text;
                        myfrmCategories.Show();
                        break;
            }

        }

        /// <summary>
        /// Method name: tbCtrl_SelectedIndexChanged
        /// Method description: This method is to manage the text of the insert button and 
        /// the value of currenTagPage.
        /// currenTagPage is enum type
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
        private void tbCtrl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbCtrl.SelectedTab == tbCtrl.TabPages["tabPageCustomers"])
            {
                currenTagPage = TabPage.tabPageCustomers;
                btnInsert.Text = "Add New Customer";
            }
            else if(tbCtrl.SelectedTab == tbCtrl.TabPages["tabPageEmployees"])
            {
                currenTagPage = TabPage.tabPageEmployees;
                btnInsert.Text = "Add New Employees";
            }
            else if (tbCtrl.SelectedTab == tbCtrl.TabPages["tabPageProducts"])
            {
                currenTagPage = TabPage.tabPageProducts;
                btnInsert.Text = "Add New Product";
            }
            else if (tbCtrl.SelectedTab == tbCtrl.TabPages["tabPageShippers"])
            {
                currenTagPage = TabPage.tabPageShippers;
                btnInsert.Text = "Add New Shipper";
            }
            else if (tbCtrl.SelectedTab == tbCtrl.TabPages["tabPageSuppliers"])
            {
                currenTagPage = TabPage.tabPageSuppliers;
                btnInsert.Text = "Add New Supplier";
            }
            else 
            {
                currenTagPage = TabPage.tabPageCategories;
                btnInsert.Text = "Add New Category";
            }


        }





    }
}
