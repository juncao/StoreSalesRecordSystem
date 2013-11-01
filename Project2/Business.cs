using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Project2;

/// <summary>
/// Summary description for Business
/// </summary>
public class Business
{

    public event frmMaintenace.Update employeeInfChangeEvent;
    public event frmMaintenace.Update customerInfChangeEvent;
    public event frmMaintenace.Update productInfChangeEvent;
    public event frmMaintenace.Update categoryInfChangeEvent;
    public event frmMaintenace.Update ShipperInfChangeEvent;
    public event frmMaintenace.Update SupplierInfChangeEvent;


    private NorthWindAccess DBData;
    private string[,] customers;
    private string[,] products;
    private string[,] employees;
    private string[,] Categories;
    private string[,] shippers;
    private string[,] Suppliers;
    public delegate void Update();

    private Byte[] categoryPicture = null;
    private SortedList pictureList = new SortedList();
    private SortedList myPictureList = new SortedList();

    private string[,] nameAndIds;
    private string[,] clekrs;
    private byte[][] pictures;

    public Business()
	{
        DBData = new NorthWindAccess();

        updateCustomerInformation();
        updateProductsInformation();
        updateEmployeesInformation();
        updateCategoryInformation();
        updateShippersInformation();
        updateSupplierInformation();

        nameAndIds = getCustomerNamesAndIDs();
        employees = getEmployeesInformation();
        //pictures = DBData.getPictures();

        pictureList = getCategoryPictureList();

        DBData.employeeInfChange += new Update(updateEmployeesInformation);
        DBData.customerInfChange += new Update(updateCustomerInformation);
        DBData.productInfChange += new Update(updateProductsInformation);
        DBData.categoryInfChange += new Update(updateCategoryInformation);
        DBData.ShipperInfChange += new Update(updateShippersInformation);
        DBData.SupplierInfChange += new Update(updateSupplierInformation);

        Application.Run(new frmControl(this));
	}


    #region update object stored information
    public void updateCustomerInformation()
    {
        if (customers != null)
        DBData.updateDateSet();
        customers = DBData.getCustomerInformation();
        if (customerInfChangeEvent != null)
            customerInfChangeEvent();


    }

    public void updateProductsInformation()
    {
        if (customers != null)
            DBData.updateDateSet();
        products = DBData.getProductsInformation();
        if (productInfChangeEvent != null)
            productInfChangeEvent();

 
    }

    public void updateEmployeesInformation()
    {
        if (customers != null)
            DBData.updateDateSet();
        employees = DBData.getEmployeesInformation();
        if (employeeInfChangeEvent != null)
            employeeInfChangeEvent();     
    }

    public void updateCategoryInformation()
    {
        if (customers != null)
            DBData.updateDateSet();
        Categories = DBData.getCategoryInformation();

        if (categoryInfChangeEvent != null)
            categoryInfChangeEvent();

    }

    public void updateShippersInformation()
    {
        if (customers != null)
            DBData.updateDateSet();
        try
        {
            shippers = DBData.getShippersInformation();
        }
        catch (Exception ex)
        {

        }


        if (ShipperInfChangeEvent != null)
            ShipperInfChangeEvent();

    }

    public void updateSupplierInformation()
    {
        if (customers != null)
            DBData.updateDateSet();
        Suppliers = DBData.getSupplierInformation();
        if (SupplierInfChangeEvent != null)
            SupplierInfChangeEvent();


    }

    #endregion

    #region Get string[,] infomations for different tables

    public String[,] getCustomerInformation()
    {
        String[,] theCustomers = customers;
        return theCustomers;
    }

    public String[,] getProductsInformation()
    {
        String[,] theProducts = products;
        return theProducts;
    }

    public String[,] getEmployeesInformation()
    {
        String[,] theEmployees = employees;
        return theEmployees;
    }

    public String[,] getCategoryInformation()
    {

        String[,] theCategories = Categories;
        return theCategories;
    }

    public String[,] getShippersInformation()
    {
        String[,] theShippers = shippers;
        return theShippers;
    }

    public String[,] getSupplierInformation()
    {
        String[,] theSuppliers = Suppliers;
        return theSuppliers;
    }

    #region    public String[,] getCustomerNamesAndIDs()
    /// <summary>
    /// getCustomerNamesAndIDs()
    /// returned array has as many elements in the first dimension
    /// as there are records
    /// It has two elements in the second dimension
    /// </summary>
    /// <returns>A 2 dimensional string array 
    /// </returns>
    public String[,] getCustomerNamesAndIDs()
    {

        String[,] nameAndIDList = null;

        // Allocate the 2 d array
        nameAndIDList = new String[customers.GetLength(0), 2];

        // load the array
        for (int i = 0; i < nameAndIDList.GetLength(0); i++)
        {
            nameAndIDList[i, 0] = customers[i, 1];
            nameAndIDList[i, 1] = customers[i, 0];
        }
        return nameAndIDList;
    }
    #endregion
    #region     public string[] getCustomerIDs()
    /// <summary>
    /// Return a string array with customer IDs
    /// </summary>
    /// <returns></returns>
    public string[] getCustomerIDs()
    {
        int count = nameAndIds.GetLength(0);
        string[] CustomerIDs = new string[count];
        for (int i = 0; i < count; i++)
        {
            CustomerIDs[i] = nameAndIds[i, 1];
        }
        return CustomerIDs;
    }
    # endregion
    #region   public string[] getCustomerNames()
    /// <summary>
    /// Return a string array with customer names
    /// </summary>
    /// <returns></returns>
    public string[] getCustomerNames()
    {
        int count = nameAndIds.GetLength(0);
        string[] CustomerNames = new string[count];
        for (int i = 0; i < count; i++)
        {
            CustomerNames[i] = nameAndIds[i, 0];
        }
        return CustomerNames;
    }
    #endregion
    #region public string[] getEmployeeNames()
    /// <summary>
    /// Return a string array with employee name
    /// </summary>
    /// <returns></returns>
    public string[] getEmployeeNames()
    {

        string[] employeeNames = new string[employees.GetLength(0)];
        for (int i = 0; i < employeeNames.GetLength(0); i++)
        {
            // Combine first name and last name together for a better view
            employeeNames[i] = employees[i, 2] + " " + employees[i, 1];
        }
        return employeeNames;
    }
    #endregion
    #region public string getEmployeeID(int index)
    /// <summary>
    /// Return the employee ID value
    /// that is associated with the given index of the array
    /// </summary>
    /// <param name="index"></param>
    /// <returns></returns>
    public string getEmployeeID(int index)
    {
        string employeeID = employees[index, 0];
        return employeeID;
    }
    #endregion

    #region     public string[] getCategoryIDs()
    /// <summary>
    /// Return a string array with customer IDs
    /// </summary>
    /// <returns></returns>
    public string[] getCategoryIDs()
    {

        int count = Categories.GetLength(0);
        string[] CategoryIDs = new string[count];
        for (int i = 0; i < count; i++)
        {
            CategoryIDs[i] = Categories[i, 0];
        }
        return CategoryIDs;
    }
    # endregion
    #region     public string[] getSupplierIDs()
    /// <summary>
    /// Return a string array with customer IDs
    /// </summary>
    /// <returns></returns>
    public string[] getSupplierIDs()
    {

        int count = Suppliers.GetLength(0);
        string[] SupplierIDs = new string[count];
        for (int i = 0; i < count; i++)
        {
            SupplierIDs[i] = Suppliers[i, 0];
        }
        return SupplierIDs;
    }
    # endregion

    public SortedList getCategoryPictureList()
    {
        if (customers != null)
        DBData.updateDateSet();

        //SortedList myPictureList = new SortedList();

        myPictureList = DBData.getCategoryPictureList();

        return myPictureList;
    }

    public Byte[] getPictureByID(int categoryID)
    {
        //Byte[] categoryPicture=null;
        try
        {
            //pictureList = getCategoryPictureList();
            int index = pictureList.IndexOfKey(categoryID);
            categoryPicture = (Byte[])(pictureList.GetByIndex(index));
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
            
        }

        return categoryPicture;
    }

    public byte[] getPictures(string categoryID)
    {
        int index = (Convert.ToInt32(categoryID) - 1);
        return pictures[index];
    }
    #endregion

    #region Employee update
    public void insertEmployee(String[] noPKvalue)
    {
        DBData.insertEmployee(noPKvalue);
    }

    public void updateEmployeeInfo(String EmployeeID, String[] noPKvalue)
    {
        DBData.updateEmployeeInfo(EmployeeID, noPKvalue);
    }

    public void deleteEmployeeInfo(String EmployeeID)
    {
        DBData.deleteEmployeeInfo(EmployeeID);
    }
    #endregion

    #region Customer update

    public void insertCustomer(String CustomerID, String[] noPKvalue)
    {
        DBData.insertCustomer(CustomerID, noPKvalue);
    }

    public void updateCustomerInfo(String CustomerID, String[] noPKvalue)
    {
        DBData.updateCustomerInfo(CustomerID, noPKvalue);
    }

    public void deleteCustomerInfo(String CustomerID)
    {
        DBData.deleteCustomerInfo(CustomerID);
    }
    #endregion

    #region Category update
    public void insertCategory(String[] noPKvalue,Byte[] picture)
    {
        DBData.insertCategory(noPKvalue, picture);
    }

    public void updateCategoryInfo(String CategoryID, String[] noPKvalue,Byte[] picture)
    {
        DBData.updateCategoryInfo(CategoryID, noPKvalue, picture);
    }

    public void deleteCategoryInfo(String CategoryID)
    {
        DBData.deleteCategoryInfo(CategoryID);
    }

    #endregion

    #region Product update
    public void updateUnitsInStock(int productID, int quantity)
    {
        DBData.updateUnitsInStock(productID, quantity);
    }

    public int getUnitsInStock(int productID)
    {

        int productUnitsInStock=0;
        for (int i = 0; i < products.GetLength(0); i++)
        {
            if (int.Parse(products[i,0]) == productID)
            {
                productUnitsInStock = int.Parse(products[i, 8]);
            }
        }
        return productUnitsInStock;
    }



    public void insertProduct(String[] noPKvalue,Boolean discontinued)
    {
        DBData.insertProduct(noPKvalue, discontinued);
    }

    public void updateProductInfo(String ProductID, String[] noPKvalue, Boolean discontinued)
    {
        DBData.updateProductInfo(ProductID, noPKvalue, discontinued);
    }

    public void deleteProductInfo(String ProductID)
    {
        DBData.deleteProductInfo(ProductID);
    }


    #endregion

    #region Shipper update
    public void insertShipper(String ShipperID, String[] noPKvalue)
    {
        DBData.insertShipper(noPKvalue);

    }

    public void updateShipperInfo(String ShipperID, String[] noPKvalue)
    {
        DBData.updateShipperInfo(ShipperID, noPKvalue);
    }

    public void deleteShipperInfo(String ShipperID)
    {
        DBData.deleteShipperInfo(ShipperID);
    }

    #endregion

    #region Supplier update
    public void insertSupplier(String[] noPKvalue)
    {
        DBData.insertSupplier(noPKvalue);
    }

    public void updateSupplierInfo(String SupplierID, String[] noPKvalue)
    {
        DBData.updateSupplierInfo(SupplierID, noPKvalue);
    }

    public void deleteSupplierInfo(String SupplierID)
    {
        DBData.deleteSupplierInfo(SupplierID);
    }

    #endregion

    #region update methods for sales form
    public string insertOrders(string CustomerID, string EmployeeID, string OrderDate)
    {
        return DBData.insertOrders(CustomerID, EmployeeID, OrderDate);
    }

    public void insertOrderDetails(string OrderID, string ProductID, string UnitPrice, string Quantity)
    {
        DBData.insertOrderDetails(OrderID, ProductID, UnitPrice, Quantity);
    }

    public void updateUnitsInStock(string ProductID, string Quantity)
    {
        DBData.updateUnitsInStock(ProductID, Quantity);
    }
    #endregion
}
