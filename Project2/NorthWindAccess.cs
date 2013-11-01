/*
NotrhWindAccess.cs
The The Data Access Layer of an application
A simple version that can:
	supply a 2 d list of Customer names with associated Customer IDs
	supply the Contact Name for a customer based on a Customer ID.

Written 31 October 2005
By John Tappin
to demonstrate non-connected data access

You should modify the accompanying Customer class
And add a method here that returns a Customer object based on a Customer ID
* */
using System;
using System.Data;
using System.Data.OleDb;
using System.Collections;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.IO;




/// <summary>
/// Summary description for NorthWindAccess.
/// </summary>
public class NorthWindAccess
{

//    private const Byte[] defaultPicture = new byte[1000]{byte[10746]};
    #region The data members
    public event Business.Update employeeInfChange;
    public event Business.Update customerInfChange;
    public event Business.Update productInfChange;
    public event Business.Update categoryInfChange;
    public event Business.Update ShipperInfChange;
    public event Business.Update SupplierInfChange;
   
    private OleDbConnection NWConnection;
    private OleDbCommand NWSelectCommand;

    private OleDbCommand NWInsertCommand;
    private OleDbCommand NWUpdateCommand;
    private OleDbCommand NWDeleteCommand;

    private OleDbCommand NWInsertCustomerCommand;
    private OleDbCommand NWUpdateCustomerCommand;
    private OleDbCommand NWDeleteCustomerCommand;

    private OleDbCommand NWInsertProductCommand;
    private OleDbCommand NWUpdateProductCommand;
    private OleDbCommand NWDeleteProductCommand;

    private OleDbCommand NWInsertEmployeeCommand;
    private OleDbCommand NWUpdateEmployeeCommand;
    private OleDbCommand NWDeleteEmployeeCommand;

    private OleDbCommand NWInsertShipperCommand;
    private OleDbCommand NWUpdateShipperCommand;
    private OleDbCommand NWDeleteShipperCommand;

    private OleDbCommand NWInsertSupplierCommand;
    private OleDbCommand NWUpdateSupplierCommand;
    private OleDbCommand NWDeleteSupplierCommand;

    private OleDbCommand NWInsertCategoryCommand;
    //private OleDbCommand NWUpdateCategoryCommand;
    private OleDbCommand NWUpdateCategoryCommandWithpicture;
    private OleDbCommand NWUpdateCategoryCommandWithoutpicture;
    private OleDbCommand NWDeleteCategoryCommand;
    private OleDbDataAdapter NWDataAdapter;
    private DataSet dsNW;

    private DataSet dsNorthWind;
    //private DataTable dtEmployees;
    //private DataTable dtCustomers;
    //private DataTable dtProducts;
	#endregion


    #region	NorthWindAccess(String connectionString)
    /// <summary>
    ///  The NorthWindAccess Data Layer Constructor
    /// </summary>
    public NorthWindAccess()
	{
		#region instantiate the OleDb Objects
		NWDataAdapter = new OleDbDataAdapter();
		NWSelectCommand = new OleDbCommand();



        NWInsertCommand = new OleDbCommand();
		NWUpdateCommand = new OleDbCommand();
        NWDeleteCommand = new OleDbCommand();

		NWInsertCustomerCommand = new OleDbCommand();
		NWUpdateCustomerCommand = new OleDbCommand();
        NWDeleteCustomerCommand = new OleDbCommand();

        NWInsertEmployeeCommand = new OleDbCommand();
        NWUpdateEmployeeCommand = new OleDbCommand();
        NWDeleteEmployeeCommand = new OleDbCommand();

        NWInsertProductCommand = new OleDbCommand();
        NWUpdateProductCommand = new OleDbCommand();
        NWDeleteProductCommand = new OleDbCommand();
        
        NWInsertShipperCommand = new OleDbCommand();
        NWUpdateShipperCommand = new OleDbCommand();
        NWDeleteShipperCommand = new OleDbCommand();
        
        NWInsertSupplierCommand = new OleDbCommand();
        NWUpdateSupplierCommand = new OleDbCommand();
        NWDeleteSupplierCommand = new OleDbCommand();

        NWInsertCategoryCommand = new OleDbCommand();
        //NWUpdateCategoryCommand = new OleDbCommand();
        NWUpdateCategoryCommandWithpicture = new OleDbCommand();
        NWUpdateCategoryCommandWithoutpicture= new OleDbCommand();
        NWDeleteCategoryCommand = new OleDbCommand();

		
        NWConnection = new OleDbConnection();
		#endregion

		#region Initialize the DataAdapter with the command objects
        NWDataAdapter.DeleteCommand = NWDeleteCustomerCommand;
        NWDataAdapter.InsertCommand = NWInsertCustomerCommand;
		NWDataAdapter.SelectCommand = NWSelectCommand;
        NWDataAdapter.UpdateCommand = NWUpdateCustomerCommand;
		#endregion

        #region Initialize the Command Objects 
        #region Initialize the Command Objects for Customer

        #region NWInsertCustomerCommand


        NWInsertCustomerCommand.CommandText = "INSERT INTO Customers(CustomerID,CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax) VALUES (?, ?, ?, ?, ?, ?, ?, ?,?, ?,? )";

        NWInsertCustomerCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("CustomerID", System.Data.OleDb.OleDbType.VarWChar, 5, "CustomerID"));
        NWInsertCustomerCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("CompanyName", System.Data.OleDb.OleDbType.VarWChar, 40, "CompanyName"));
        NWInsertCustomerCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("ContactName", System.Data.OleDb.OleDbType.VarWChar, 30, "ContactName"));
        NWInsertCustomerCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("ContactTitle", System.Data.OleDb.OleDbType.VarWChar, 30, "ContactTitle"));
        NWInsertCustomerCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("Address", System.Data.OleDb.OleDbType.VarWChar, 60, "Address"));
        NWInsertCustomerCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("City", System.Data.OleDb.OleDbType.VarWChar, 15, "City"));
        NWInsertCustomerCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("Region", System.Data.OleDb.OleDbType.VarWChar, 15, "Region"));
        NWInsertCustomerCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("PostalCode", System.Data.OleDb.OleDbType.VarWChar, 10, "PostalCode"));
        NWInsertCustomerCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("Country", System.Data.OleDb.OleDbType.VarWChar, 15, "Country"));
        NWInsertCustomerCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("Phone", System.Data.OleDb.OleDbType.VarWChar, 24, "Phone"));
        NWInsertCustomerCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("Fax", System.Data.OleDb.OleDbType.VarWChar, 24, "Fax"));

        NWInsertCustomerCommand.Connection = NWConnection;
        #endregion
        #region NWUpdateCustomerCommand

        NWUpdateCustomerCommand.CommandText = @"UPDATE Customers SET CompanyName = ?, ContactName=?,ContactTitle = ?,Address = ?, City = ?, Region = ?, PostalCode = ?, Country = ?, Phone = ?, Fax = ? WHERE (CustomerID = ?)";



        NWUpdateCustomerCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("CompanyName", System.Data.OleDb.OleDbType.VarWChar, 40, "CompanyName"));
        NWUpdateCustomerCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("ContactName", System.Data.OleDb.OleDbType.VarWChar, 30, "ContactName"));
        NWUpdateCustomerCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("ContactTitle", System.Data.OleDb.OleDbType.VarWChar, 30, "ContactTitle"));
        NWUpdateCustomerCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("Address", System.Data.OleDb.OleDbType.VarWChar, 60, "Address"));
        NWUpdateCustomerCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("City", System.Data.OleDb.OleDbType.VarWChar, 15, "City"));
        NWUpdateCustomerCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("Region", System.Data.OleDb.OleDbType.VarWChar, 15, "Region"));
        NWUpdateCustomerCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("PostalCode", System.Data.OleDb.OleDbType.VarWChar, 10, "PostalCode"));
        NWUpdateCustomerCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("Country", System.Data.OleDb.OleDbType.VarWChar, 15, "Country"));
        NWUpdateCustomerCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("Phone", System.Data.OleDb.OleDbType.VarWChar, 24, "Phone"));
        NWUpdateCustomerCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("Fax", System.Data.OleDb.OleDbType.VarWChar, 24, "Fax"));
        NWUpdateCustomerCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("CustomerID", System.Data.OleDb.OleDbType.VarWChar, 5, "CustomerID"));
        NWUpdateCustomerCommand.Connection = NWConnection;
        #endregion
        #region NWDeleteCommand
        // 
        NWDeleteCustomerCommand.CommandText = @"DELETE FROM Customers WHERE (CustomerID = ?)";
        NWDeleteCustomerCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("CustomerID", System.Data.OleDb.OleDbType.VarWChar, 5, "CustomerID"));
        NWDeleteCustomerCommand.Connection = NWConnection;
        #endregion
        #endregion
        #region Initialize the Command Objects for Employee

        #region NWInsertEmployeeCommand


        NWInsertEmployeeCommand.CommandText = "INSERT INTO Employees(lastName, firstName, title, titleOfCourtesy, birthDate, hireDate, address,city,region,postalCode, Country, homePhone, extension,photo,notes,reportsTo) VALUES ( ?, ?, ?, ?,?, ?,?,?, ?, ?, ?, ?, ?, ?,?, ? )";

        //NWInsertEmployeeCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("EmployeeID", System.Data.OleDb.OleDbType.Integer, 5 "EmployeeID"));
        NWInsertEmployeeCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("lastName", System.Data.OleDb.OleDbType.VarWChar, 20, "lastName"));
        NWInsertEmployeeCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("firstName", System.Data.OleDb.OleDbType.VarWChar, 10, "firstName"));
        NWInsertEmployeeCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("title", System.Data.OleDb.OleDbType.VarWChar, 30, "title"));
        NWInsertEmployeeCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("titleOfCourtesy", System.Data.OleDb.OleDbType.VarWChar, 25, "titleOfCourtesy"));
        NWInsertEmployeeCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("birthDate", System.Data.OleDb.OleDbType.Date, 15, "birthDate"));
        NWInsertEmployeeCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("hireDate", System.Data.OleDb.OleDbType.Date, 15, "hireDate"));
        NWInsertEmployeeCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("address", System.Data.OleDb.OleDbType.VarWChar, 60, "address"));
        NWInsertEmployeeCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("city", System.Data.OleDb.OleDbType.VarWChar, 15, "city"));
        NWInsertEmployeeCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("region", System.Data.OleDb.OleDbType.VarWChar, 15, "region"));
        NWInsertEmployeeCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("postalCode", System.Data.OleDb.OleDbType.VarWChar, 10, "postalCode"));
        NWInsertEmployeeCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("Country", System.Data.OleDb.OleDbType.VarWChar, 15, "Country"));
        NWInsertEmployeeCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("homePhone", System.Data.OleDb.OleDbType.VarWChar, 24, "homePhone"));
        NWInsertEmployeeCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("extension", System.Data.OleDb.OleDbType.VarWChar, 4, "extension"));
        NWInsertEmployeeCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("photo", System.Data.OleDb.OleDbType.VarWChar, 255, "photo"));
        NWInsertEmployeeCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("notes", System.Data.OleDb.OleDbType.VarWChar, 30, "notes"));
        NWInsertEmployeeCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("reportsTo", System.Data.OleDb.OleDbType.Integer, 60, "reportsTo"));
        //NWInsertEmployeeCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("account", System.Data.OleDb.OleDbType.Integer, 100, "account"));
        //NWInsertEmployeeCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("email", System.Data.OleDb.OleDbType.VarWChar, 255, "email"));
        //NWInsertEmployeeCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("password", System.Data.OleDb.OleDbType.VarWChar, 255, "password"));
        NWInsertEmployeeCommand.Connection = NWConnection;
        #endregion
        #region NWUpdateEmployeeCommand

        NWUpdateEmployeeCommand.CommandText = @"UPDATE Employees SET lastName=?, firstName=?, title=?, titleOfCourtesy=?, birthDate=?, hireDate=?, address=?,city=?,region=?,postalCode=?, Country=?, homePhone=?, extension=?,photo=?,notes=?,reportsTo=? WHERE EmployeeID = ?";

        NWUpdateEmployeeCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("lastName", System.Data.OleDb.OleDbType.VarWChar, 20, "lastName"));
        NWUpdateEmployeeCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("firstName", System.Data.OleDb.OleDbType.VarWChar, 10, "firstName"));
        NWUpdateEmployeeCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("title", System.Data.OleDb.OleDbType.VarWChar, 30, "title"));
        NWUpdateEmployeeCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("titleOfCourtesy", System.Data.OleDb.OleDbType.VarWChar, 25, "titleOfCourtesy"));
        NWUpdateEmployeeCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("birthDate", System.Data.OleDb.OleDbType.Date, 15, "birthDate"));
        NWUpdateEmployeeCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("hireDate", System.Data.OleDb.OleDbType.Date, 15, "hireDate"));
        NWUpdateEmployeeCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("address", System.Data.OleDb.OleDbType.VarWChar, 60, "address"));
        NWUpdateEmployeeCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("city", System.Data.OleDb.OleDbType.VarWChar, 15, "city"));
        NWUpdateEmployeeCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("region", System.Data.OleDb.OleDbType.VarWChar, 15, "region"));
        NWUpdateEmployeeCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("postalCode", System.Data.OleDb.OleDbType.VarWChar, 10, "postalCode"));
        NWUpdateEmployeeCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("Country", System.Data.OleDb.OleDbType.VarWChar, 15, "Country"));
        NWUpdateEmployeeCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("homePhone", System.Data.OleDb.OleDbType.VarWChar, 24, "homePhone"));
        NWUpdateEmployeeCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("extension", System.Data.OleDb.OleDbType.VarWChar, 4, "extension"));
        NWUpdateEmployeeCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("photo", System.Data.OleDb.OleDbType.VarWChar, 255, "photo"));
        NWUpdateEmployeeCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("notes", System.Data.OleDb.OleDbType.VarWChar, 30, "notes"));
        NWUpdateEmployeeCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("reportsTo", System.Data.OleDb.OleDbType.Integer, 60, "reportsTo"));
        NWUpdateEmployeeCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("EmployeeID", System.Data.OleDb.OleDbType.Integer, 5, "EmployeeID"));
        
        NWUpdateEmployeeCommand.Connection = NWConnection;
        #endregion
        #region NWDeleteEmployeeCommand
        // 
        NWDeleteEmployeeCommand.CommandText = @"DELETE FROM Employees WHERE (EmployeeID = ?)";
        NWDeleteEmployeeCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("EmployeeID", System.Data.OleDb.OleDbType.VarWChar, 5, "EmployeeID"));
        NWDeleteEmployeeCommand.Connection = NWConnection;
        #endregion
        #endregion
        #region Initialize the Command Objects for Product

        #region NWInsertProductCommand

        NWInsertProductCommand.CommandText = "INSERT INTO Products(productName, supplierID, categoryID, quantityPerUnit, unitPrice, unitsInStock, unitsOnOrder, reorderLevel, discontinued) VALUES (?, ?, ?, ?, ?, ?, ?,?, ?)";

        //NWInsertProductCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("ProductID", System.Data.OleDb.OleDbType.Integer, 5, "ProductID"));
        NWInsertProductCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("productName", System.Data.OleDb.OleDbType.VarWChar, 40, "productName"));
        NWInsertProductCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("supplierID", System.Data.OleDb.OleDbType.Integer, 30, "supplierID"));
        NWInsertProductCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("categoryID", System.Data.OleDb.OleDbType.Integer, 30, "categoryID"));
        NWInsertProductCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("quantityPerUnit", System.Data.OleDb.OleDbType.VarWChar, 20, "quantityPerUnit"));
        NWInsertProductCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("unitPrice", System.Data.OleDb.OleDbType.Decimal, 15, "unitPrice"));
        NWInsertProductCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("unitsInStock", System.Data.OleDb.OleDbType.Integer, 15, "unitsInStock"));
        NWInsertProductCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("unitsOnOrder", System.Data.OleDb.OleDbType.Integer, 10, "unitsOnOrder"));
        NWInsertProductCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("reorderLevel", System.Data.OleDb.OleDbType.Integer, 15, "reorderLevel"));
        NWInsertProductCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("discontinued", System.Data.OleDb.OleDbType.Boolean, 1, "discontinued"));

        NWInsertProductCommand.Connection = NWConnection;
        #endregion
        #region NWUpdateProductCommand

        NWUpdateProductCommand.CommandText = @"UPDATE Products SET productName=?, supplierID=?, categoryID=?, quantityPerUnit=?, unitPrice=?, unitsInStock=?, unitsOnOrder=?, reorderLevel=?, discontinued=? WHERE (ProductID = ?)";


        
        NWUpdateProductCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("productName", System.Data.OleDb.OleDbType.VarWChar, 40, "CompanyName"));
        NWUpdateProductCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("supplierID", System.Data.OleDb.OleDbType.Integer, 30, "ContactName"));
        NWUpdateProductCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("categoryID", System.Data.OleDb.OleDbType.Integer, 30, "ContactTitle"));
        NWUpdateProductCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("quantityPerUnit", System.Data.OleDb.OleDbType.VarWChar, 20, "Address"));
        NWUpdateProductCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("unitPrice", System.Data.OleDb.OleDbType.Decimal, 15, "City"));
        NWUpdateProductCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("unitsInStock", System.Data.OleDb.OleDbType.Integer, 15, "Region"));
        NWUpdateProductCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("unitsOnOrder", System.Data.OleDb.OleDbType.Integer, 10, "PostalCode"));
        NWUpdateProductCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("reorderLevel", System.Data.OleDb.OleDbType.Integer, 15, "Country"));
        NWUpdateProductCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("discontinued", System.Data.OleDb.OleDbType.Boolean, 1, "Phone"));
        NWUpdateProductCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("ProductID", System.Data.OleDb.OleDbType.Integer, 5, "ProductID"));

        NWUpdateProductCommand.Connection = NWConnection;
        #endregion
        #region NWDeleteProductCommand
        // 
        NWDeleteProductCommand.CommandText = @"DELETE FROM Products WHERE (ProductID = ?)";
        NWDeleteProductCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("ProductID", System.Data.OleDb.OleDbType.Integer, 5, "ProductID"));
        NWDeleteProductCommand.Connection = NWConnection;
        #endregion
        #endregion
        #region Initialize the Command Objects for Shipper

        #region NWInsertShipperCommand

        NWInsertShipperCommand.CommandText = "INSERT INTO Shippers(CompanyName, phone) VALUES (?, ? )";//ShipperID,

//        NWInsertShipperCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("ShipperID", System.Data.OleDb.OleDbType.Integer, 5, "ShipperID"));
        NWInsertShipperCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("CompanyName", System.Data.OleDb.OleDbType.VarWChar, 40, "CompanyName"));
        NWInsertShipperCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("phone", System.Data.OleDb.OleDbType.VarWChar, 24, "phone"));
       
        NWInsertShipperCommand.Connection = NWConnection;
        #endregion
        #region NWUpdateShipperCommand

        NWUpdateShipperCommand.CommandText = @"UPDATE Shippers SET CompanyName = ?, phone=? WHERE (ShipperID = ?)";

        NWUpdateShipperCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("CompanyName", System.Data.OleDb.OleDbType.VarWChar, 40, "CompanyName"));
        NWUpdateShipperCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("phone", System.Data.OleDb.OleDbType.VarWChar, 24, "phone"));
        NWUpdateShipperCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("ShipperID", System.Data.OleDb.OleDbType.Integer, 5, "ShipperID"));
       

        NWUpdateShipperCommand.Connection = NWConnection;
        #endregion
        #region NWDeleteShipperCommand
        // 
        NWDeleteShipperCommand.CommandText = @"DELETE FROM Shippers WHERE (ShipperID = ?)";
        NWDeleteShipperCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("ShipperID", System.Data.OleDb.OleDbType.VarWChar, 5, "ShipperID"));
        NWDeleteShipperCommand.Connection = NWConnection;
        #endregion
        #endregion
        #region Initialize the Command Objects for Supplier

        #region NWInsertSupplierCommand

          
        NWInsertSupplierCommand.CommandText = "INSERT INTO Suppliers(CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax,homePage) VALUES ( ?, ?, ?, ?, ?, ?, ?,?, ?,?,? )";

        //NWInsertSupplierCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("SupplierID", System.Data.OleDb.OleDbType.Integer, 5, "SupplierID"));
        NWInsertSupplierCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("CompanyName", System.Data.OleDb.OleDbType.VarWChar, 40, "CompanyName"));
        NWInsertSupplierCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("ContactName", System.Data.OleDb.OleDbType.VarWChar, 30, "ContactName"));
        NWInsertSupplierCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("ContactTitle", System.Data.OleDb.OleDbType.VarWChar, 30, "ContactTitle"));
        NWInsertSupplierCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("Address", System.Data.OleDb.OleDbType.VarWChar, 60, "Address"));
        NWInsertSupplierCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("City", System.Data.OleDb.OleDbType.VarWChar, 15, "City"));
        NWInsertSupplierCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("Region", System.Data.OleDb.OleDbType.VarWChar, 15, "Region"));
        NWInsertSupplierCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("PostalCode", System.Data.OleDb.OleDbType.VarWChar, 10, "PostalCode"));
        NWInsertSupplierCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("Country", System.Data.OleDb.OleDbType.VarWChar, 15, "Country"));
        NWInsertSupplierCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("Phone", System.Data.OleDb.OleDbType.VarWChar, 24, "Phone"));
        NWInsertSupplierCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("Fax", System.Data.OleDb.OleDbType.VarWChar, 24, "Fax"));
        NWInsertSupplierCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("homePage", System.Data.OleDb.OleDbType.VarWChar, 24, "homePage"));
        NWInsertSupplierCommand.Connection = NWConnection;
        #endregion
        #region NWUpdateSupplierCommand

        NWUpdateSupplierCommand.CommandText = @"UPDATE Suppliers SET CompanyName = ?, ContactName=?,ContactTitle = ?,Address = ?, City = ?, Region = ?, PostalCode = ?, Country = ?, Phone = ?, Fax = ?, homePage=? WHERE (SupplierID = ?)";
 
        NWUpdateSupplierCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("CompanyName", System.Data.OleDb.OleDbType.VarWChar, 40, "CompanyName"));
        NWUpdateSupplierCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("ContactName", System.Data.OleDb.OleDbType.VarWChar, 30, "ContactName"));
        NWUpdateSupplierCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("ContactTitle", System.Data.OleDb.OleDbType.VarWChar, 30, "ContactTitle"));
        NWUpdateSupplierCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("Address", System.Data.OleDb.OleDbType.VarWChar, 60, "Address"));
        NWUpdateSupplierCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("City", System.Data.OleDb.OleDbType.VarWChar, 15, "City"));
        NWUpdateSupplierCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("Region", System.Data.OleDb.OleDbType.VarWChar, 15, "Region"));
        NWUpdateSupplierCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("PostalCode", System.Data.OleDb.OleDbType.VarWChar, 10, "PostalCode"));
        NWUpdateSupplierCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("Country", System.Data.OleDb.OleDbType.VarWChar, 15, "Country"));
        NWUpdateSupplierCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("Phone", System.Data.OleDb.OleDbType.VarWChar, 24, "Phone"));
        NWUpdateSupplierCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("Fax", System.Data.OleDb.OleDbType.VarWChar, 24, "Fax"));
        NWUpdateSupplierCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("homePage", System.Data.OleDb.OleDbType.VarWChar, 24, "homePage"));
        NWUpdateSupplierCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("SupplierID", System.Data.OleDb.OleDbType.Integer, 5, "SupplierID"));

        NWUpdateSupplierCommand.Connection = NWConnection;
        #endregion
        #region NWDeleteSupplierCommand
        // 
        NWDeleteSupplierCommand.CommandText = @"DELETE FROM Suppliers WHERE (SupplierID = ?)";
        NWDeleteSupplierCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("SupplierID", System.Data.OleDb.OleDbType.VarWChar, 5, "SupplierID"));
        NWDeleteSupplierCommand.Connection = NWConnection;
        #endregion
        #endregion
        #region Initialize the Command Objects for Category

        #region NWInsertCategoryCommand


        NWInsertCategoryCommand.CommandText = "INSERT INTO Categories(categoryName, description, picture) VALUES (?, ?, ?)";

        //NWInsertCategoryCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("CategoryID", System.Data.OleDb.OleDbType.Integer, 5, "CategoryID"));
        NWInsertCategoryCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("categoryName", System.Data.OleDb.OleDbType.VarWChar, 15, "categoryName"));
        NWInsertCategoryCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("description", System.Data.OleDb.OleDbType.VarWChar, 30, "description"));
        NWInsertCategoryCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("picture", System.Data.OleDb.OleDbType.LongVarBinary, 2000, "picture"));
       
        NWInsertCategoryCommand.Connection = NWConnection;
        #endregion
        #region NWUpdateCategoryCommand

        NWUpdateCategoryCommandWithpicture.CommandText = @"UPDATE Categories SET categoryName = ?, description=?,picture = ? WHERE (CategoryID = ?)";


        NWUpdateCategoryCommandWithpicture.Parameters.Add(new System.Data.OleDb.OleDbParameter("categoryName", System.Data.OleDb.OleDbType.VarWChar, 15, "categoryName"));
        NWUpdateCategoryCommandWithpicture.Parameters.Add(new System.Data.OleDb.OleDbParameter("description", System.Data.OleDb.OleDbType.VarWChar, 30, "description"));
        NWUpdateCategoryCommandWithpicture.Parameters.Add(new System.Data.OleDb.OleDbParameter("picture", System.Data.OleDb.OleDbType.LongVarBinary, 30, "picture"));
        NWUpdateCategoryCommandWithpicture.Parameters.Add(new System.Data.OleDb.OleDbParameter("CategoryID", System.Data.OleDb.OleDbType.Integer, 5, "CategoryID"));

        NWUpdateCategoryCommandWithpicture.Connection = NWConnection;
        #endregion
        #region NWUpdateCategoryCommand

        NWUpdateCategoryCommandWithoutpicture.CommandText = @"UPDATE Categories SET categoryName = ?, description=? WHERE (CategoryID = ?)";


        NWUpdateCategoryCommandWithoutpicture.Parameters.Add(new System.Data.OleDb.OleDbParameter("categoryName", System.Data.OleDb.OleDbType.VarWChar, 15, "categoryName"));
        NWUpdateCategoryCommandWithoutpicture.Parameters.Add(new System.Data.OleDb.OleDbParameter("description", System.Data.OleDb.OleDbType.VarWChar, 30, "description"));
        //NWUpdateCategoryCommandWithoutpicture.Parameters.Add(new System.Data.OleDb.OleDbParameter("picture", System.Data.OleDb.OleDbType.LongVarBinary, 30, "picture"));
        NWUpdateCategoryCommandWithoutpicture.Parameters.Add(new System.Data.OleDb.OleDbParameter("CategoryID", System.Data.OleDb.OleDbType.Integer, 5, "CategoryID"));

        NWUpdateCategoryCommandWithoutpicture.Connection = NWConnection;
        #endregion
        #region NWDeleteCategoryCommand
        // 
        NWDeleteCategoryCommand.CommandText = @"DELETE FROM Categorys WHERE (CategoryID = ?)";
        NWDeleteCategoryCommand.Parameters.Add(new System.Data.OleDb.OleDbParameter("CategoryID", System.Data.OleDb.OleDbType.VarWChar, 5, "CategoryID"));
        NWDeleteCategoryCommand.Connection = NWConnection;
        #endregion
        #endregion
        #endregion

        #region initialize the Connection object
        // 
		// NWConnection
        // Note path is to the parent of the parent directory - ..\..\
		// 

        NWConnection.ConnectionString =
            @"Provider=Microsoft.ACE.OLEDB.12.0;"
        + @"Data Source=..\..\Northwind.mdb;Persist Security Info=False ";


   

		#endregion

        #region instantiate and initialize DataSet and DataTable Objects
        dsNorthWind = new DataSet();
        //dtEmployees = new DataTable();
        //dtCustomers = new DataTable();
        //dtProducts = new DataTable();
        

        // Employees Table Info
        NWDataAdapter.TableMappings.AddRange(
            new System.Data.Common.DataTableMapping[] {
                new System.Data.Common.DataTableMapping("Employees", "Employees", 
                    new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("EmployeeID", "EmployeeID"),
                        new System.Data.Common.DataColumnMapping("LastName", "LastName"),
                        new System.Data.Common.DataColumnMapping("FirstName", "FirstName"),
                        new System.Data.Common.DataColumnMapping("Title", "Title"),
                        new System.Data.Common.DataColumnMapping("TitleOfCourtesy", "TitleOfCoutesy"),
                        new System.Data.Common.DataColumnMapping("BirthDate", "BirthDate"),
                        new System.Data.Common.DataColumnMapping("HireDate", "HireDate"),
                        new System.Data.Common.DataColumnMapping("Address", "Address"),
                        new System.Data.Common.DataColumnMapping("City", "City"),
                        new System.Data.Common.DataColumnMapping("Region", "Region"),
                        new System.Data.Common.DataColumnMapping("PostalCode", "PostalCode"),
                        new System.Data.Common.DataColumnMapping("Country", "Country"),
                        new System.Data.Common.DataColumnMapping("HomePhone", "HomePhone"),
                        new System.Data.Common.DataColumnMapping("Extension", "Extension"),
                        new System.Data.Common.DataColumnMapping("Photo", "Photo"),
                        new System.Data.Common.DataColumnMapping("Notes", "Notes"),
                        new System.Data.Common.DataColumnMapping("ReportsTo", "ReportsTo"),              
                    })});

        // Customers Table Info
        NWDataAdapter.TableMappings.AddRange(
            new System.Data.Common.DataTableMapping[] {
                new System.Data.Common.DataTableMapping("Customers", "Customers", 
                    new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("CustomerID", "CustomerID"),
                        new System.Data.Common.DataColumnMapping("CompanyName", "CompanyName"),
                        new System.Data.Common.DataColumnMapping("ContactName", "ContactName"),
                        new System.Data.Common.DataColumnMapping("ContactTitle", "ContactTitle"),
                        new System.Data.Common.DataColumnMapping("Address", "Address"),
                        new System.Data.Common.DataColumnMapping("city", "city"),
                        new System.Data.Common.DataColumnMapping("Region", "Region"),
                        new System.Data.Common.DataColumnMapping("PostalCode", "PostalCode"),
                        new System.Data.Common.DataColumnMapping("Country", "Country"),
                        new System.Data.Common.DataColumnMapping("Phone", "Phone"),
                        new System.Data.Common.DataColumnMapping("Fax", "Fax"),
                    })});

        // Products Table Info
        NWDataAdapter.TableMappings.AddRange(
        new System.Data.Common.DataTableMapping[] {
                new System.Data.Common.DataTableMapping("Products", "Products",                
                    new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("ProductID", "ProductID"),
                        new System.Data.Common.DataColumnMapping("ProductName", "ProductName"),
                        new System.Data.Common.DataColumnMapping("CategoryID", "CategoryID"),
                        new System.Data.Common.DataColumnMapping("CategoryName", "CategoryName"),
                        new System.Data.Common.DataColumnMapping("SupplierID", "SupplierID"),
                        new System.Data.Common.DataColumnMapping("CompanyName", "CompanyName"),
                        new System.Data.Common.DataColumnMapping("QuantityPerUnit", "QuantityPerUnit"),
                        new System.Data.Common.DataColumnMapping("UnitPrice", "UnitPrice"),
                        new System.Data.Common.DataColumnMapping("UnitsInStock", "UnitsInStock"),
                        new System.Data.Common.DataColumnMapping("UnitsOnOrder", "UnitsOnOrder"),
                        new System.Data.Common.DataColumnMapping("ReorderLevel", "ReorderLevel"),
                        new System.Data.Common.DataColumnMapping("Discontinued", "Discontinued"),

                    })});
        // Categories Table Info
        NWDataAdapter.TableMappings.AddRange(
        new System.Data.Common.DataTableMapping[] {
                new System.Data.Common.DataTableMapping("Categories", "Categories",                
                    new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("CategoryID", "CategoryID"),
                        new System.Data.Common.DataColumnMapping("CategoryName", "CategoryName"),
                        new System.Data.Common.DataColumnMapping("Description", "Description"),
                        new System.Data.Common.DataColumnMapping("Picture", "Picture"),
                    })});

        // Shippers Table Info
        NWDataAdapter.TableMappings.AddRange(
        new System.Data.Common.DataTableMapping[] {
                new System.Data.Common.DataTableMapping("Shippers", "Shippers",                
                    new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("ShipperID", "ShipperID"),
                        new System.Data.Common.DataColumnMapping("CompanyName", "CompanyName"),
                        new System.Data.Common.DataColumnMapping("Phone", "Phone"),
                    })});

        // Shippers Table Info
        NWDataAdapter.TableMappings.AddRange(
        new System.Data.Common.DataTableMapping[] {
                new System.Data.Common.DataTableMapping("Suppliers", "Suppliers",                
                    new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("SupplierID", "SupplierID"),
                        new System.Data.Common.DataColumnMapping("CompanyName", "CompanyName"),
                        new System.Data.Common.DataColumnMapping("ContactName", "ContactName"),
                        new System.Data.Common.DataColumnMapping("ContactTitle", "ContactTitle"),
                        new System.Data.Common.DataColumnMapping("Address", "Address"),
                        new System.Data.Common.DataColumnMapping("City", "City"),
                        new System.Data.Common.DataColumnMapping("Region", "Region"),
                        new System.Data.Common.DataColumnMapping("PostalCode", "PostalCode"),
                        new System.Data.Common.DataColumnMapping("Country", "Country"),
                        new System.Data.Common.DataColumnMapping("Phone", "Phone"),
                        new System.Data.Common.DataColumnMapping("Fax", "Fax"),
                        new System.Data.Common.DataColumnMapping("HomePage", "HomePage"),
                    })});


        #endregion

        #region Initialize the DataAdapter with the command objects
        NWSelectCommand = new OleDbCommand();
        NWDataAdapter = new OleDbDataAdapter();
        #endregion
        updateDateSet();
    
    #endregion
        
        #region initialize the Connection object
        // 
		// NWConnection
        // Note path is to the parent of the parent directory - ..\..\
		// 
        NWConnection.ConnectionString =
            @"Provider=Microsoft.ACE.OLEDB.12.0;"
        + @"Data Source=..\..\Northwind.mdb;Persist Security Info=False ";

		#endregion

        #region instantiate and initialize DataSet and DataTable Objects
        dsNorthWind = new DataSet();
        //dtEmployees = new DataTable();
        //dtCustomers = new DataTable();
        //dtProducts = new DataTable();
        

        // Employees Table Info
        NWDataAdapter.TableMappings.AddRange(
            new System.Data.Common.DataTableMapping[] {
                new System.Data.Common.DataTableMapping("Employees", "Employees", 
                    new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("EmployeeID", "EmployeeID"),
                        new System.Data.Common.DataColumnMapping("LastName", "LastName"),
                        new System.Data.Common.DataColumnMapping("FirstName", "FirstName"),
                        new System.Data.Common.DataColumnMapping("Title", "Title"),
                        new System.Data.Common.DataColumnMapping("TitleOfCourtesy", "TitleOfCoutesy"),
                        new System.Data.Common.DataColumnMapping("BirthDate", "BirthDate"),
                        new System.Data.Common.DataColumnMapping("HireDate", "HireDate"),
                        new System.Data.Common.DataColumnMapping("Address", "Address"),
                        new System.Data.Common.DataColumnMapping("City", "City"),
                        new System.Data.Common.DataColumnMapping("Region", "Region"),
                        new System.Data.Common.DataColumnMapping("PostalCode", "PostalCode"),
                        new System.Data.Common.DataColumnMapping("Country", "Country"),
                        new System.Data.Common.DataColumnMapping("HomePhone", "HomePhone"),
                        new System.Data.Common.DataColumnMapping("Extension", "Extension"),
                        new System.Data.Common.DataColumnMapping("Photo", "Photo"),
                        new System.Data.Common.DataColumnMapping("Notes", "Notes"),
                        new System.Data.Common.DataColumnMapping("ReportsTo", "ReportsTo"),              
                    })});

        // Customers Table Info
        NWDataAdapter.TableMappings.AddRange(
            new System.Data.Common.DataTableMapping[] {
                new System.Data.Common.DataTableMapping("Customers", "Customers", 
                    new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("CustomerID", "CustomerID"),
                        new System.Data.Common.DataColumnMapping("CompanyName", "CompanyName"),
                        new System.Data.Common.DataColumnMapping("ContactName", "ContactName"),
                        new System.Data.Common.DataColumnMapping("ContactTitle", "ContactTitle"),
                        new System.Data.Common.DataColumnMapping("Address", "Address"),
                        new System.Data.Common.DataColumnMapping("city", "city"),
                        new System.Data.Common.DataColumnMapping("Region", "Region"),
                        new System.Data.Common.DataColumnMapping("PostalCode", "PostalCode"),
                        new System.Data.Common.DataColumnMapping("Country", "Country"),
                        new System.Data.Common.DataColumnMapping("Phone", "Phone"),
                        new System.Data.Common.DataColumnMapping("Fax", "Fax"),
                    })});

        // Products Table Info
        NWDataAdapter.TableMappings.AddRange(
        new System.Data.Common.DataTableMapping[] {
                new System.Data.Common.DataTableMapping("Products", "Products",                
                    new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("ProductID", "ProductID"),
                        new System.Data.Common.DataColumnMapping("ProductName", "ProductName"),
                        new System.Data.Common.DataColumnMapping("CategoryID", "CategoryID"),
                        new System.Data.Common.DataColumnMapping("CategoryName", "CategoryName"),
                        new System.Data.Common.DataColumnMapping("SupplierID", "SupplierID"),
                        new System.Data.Common.DataColumnMapping("CompanyName", "CompanyName"),
                        new System.Data.Common.DataColumnMapping("QuantityPerUnit", "QuantityPerUnit"),
                        new System.Data.Common.DataColumnMapping("UnitPrice", "UnitPrice"),
                        new System.Data.Common.DataColumnMapping("UnitsInStock", "UnitsInStock"),
                        new System.Data.Common.DataColumnMapping("UnitsOnOrder", "UnitsOnOrder"),
                        new System.Data.Common.DataColumnMapping("ReorderLevel", "ReorderLevel"),
                        new System.Data.Common.DataColumnMapping("Discontinued", "Discontinued"),

                    })});
        // Categories Table Info
        NWDataAdapter.TableMappings.AddRange(
        new System.Data.Common.DataTableMapping[] {
                new System.Data.Common.DataTableMapping("Categories", "Categories",                
                    new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("CategoryID", "CategoryID"),
                        new System.Data.Common.DataColumnMapping("CategoryName", "CategoryName"),
                        new System.Data.Common.DataColumnMapping("Description", "Description"),
                        new System.Data.Common.DataColumnMapping("Picture", "Picture"),
                    })});

        // Shippers Table Info
        NWDataAdapter.TableMappings.AddRange(
        new System.Data.Common.DataTableMapping[] {
                new System.Data.Common.DataTableMapping("Shippers", "Shippers",                
                    new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("ShipperID", "ShipperID"),
                        new System.Data.Common.DataColumnMapping("CompanyName", "CompanyName"),
                        new System.Data.Common.DataColumnMapping("Phone", "Phone"),
                    })});

        // Shippers Table Info
        NWDataAdapter.TableMappings.AddRange(
        new System.Data.Common.DataTableMapping[] {
                new System.Data.Common.DataTableMapping("Suppliers", "Suppliers",                
                    new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("SupplierID", "SupplierID"),
                        new System.Data.Common.DataColumnMapping("CompanyName", "CompanyName"),
                        new System.Data.Common.DataColumnMapping("ContactName", "ContactName"),
                        new System.Data.Common.DataColumnMapping("ContactTitle", "ContactTitle"),
                        new System.Data.Common.DataColumnMapping("Address", "Address"),
                        new System.Data.Common.DataColumnMapping("City", "City"),
                        new System.Data.Common.DataColumnMapping("Region", "Region"),
                        new System.Data.Common.DataColumnMapping("PostalCode", "PostalCode"),
                        new System.Data.Common.DataColumnMapping("Country", "Country"),
                        new System.Data.Common.DataColumnMapping("Phone", "Phone"),
                        new System.Data.Common.DataColumnMapping("Fax", "Fax"),
                        new System.Data.Common.DataColumnMapping("HomePage", "HomePage"),
                    })});


        #endregion

        #region Initialize the DataAdapter with the command objects
        NWSelectCommand = new OleDbCommand();
        NWDataAdapter = new OleDbDataAdapter();
        #endregion
        updateDateSet();
    }

    #region Select informations and fill DataSet updateDateSet()
    public void updateDateSet()
    {
        #region set connection and the TableMappings for the DataAdapter (Employees Table Info)
        NWSelectCommand.Connection = NWConnection;
        NWSelectCommand.CommandText = "SELECT EmployeeID,LastName,FirstName,Title,TitleOfCourtesy,BirthDate,HireDate,Address"
        + ",City,Region,PostalCode,Country,HomePhone,Extension,Photo,Notes,ReportsTo FROM Employees";

        dsNorthWind.Clear();
        NWConnection.Open();
        NWDataAdapter.SelectCommand = NWSelectCommand;
        NWDataAdapter.Fill(dsNorthWind, "Employees");
        NWConnection.Close();
        #endregion

        #region set connection and the TableMappings for the DataAdapter (Customers Table Info)
        NWSelectCommand.Connection = NWConnection;
        NWSelectCommand.CommandText = "SELECT Address, City, CompanyName, ContactName, ContactTitle, Country, CustomerID" +
            ", Fax, Phone, PostalCode, Region FROM Customers";

        

        //NWDataAdapter.SelectCommand = NWSelectCommand;
        //NWDataAdapter.Fill(dsNorthWind, "Customers");
        //dsNorthWind.Tables.Add(dtCustomers);

        NWConnection.Open();
        NWDataAdapter.SelectCommand = NWSelectCommand;
        NWDataAdapter.Fill(dsNorthWind, "Customers");
        NWConnection.Close();
        #endregion

        #region set connection and the TableMappings for the DataAdapter (Products Table Information)
        NWSelectCommand.Connection = NWConnection;
        NWSelectCommand.CommandText = "SELECT  " +
            "Products.ProductID, Products.ProductName, " +
            "Categories.CategoryID,Categories.CategoryName, " +
            "Suppliers.SupplierID,Suppliers.CompanyName, " +
            "Products.QuantityPerUnit, " +
            "Products.UnitPrice, Products.UnitsInStock, " +
            "Products.UnitsOnOrder, Products.ReorderLevel,Products.Discontinued "+
            "FROM Categories " +
            "INNER JOIN (Suppliers " +
            "INNER JOIN Products " +
            "ON Suppliers.SupplierID = Products.SupplierID) " +
            "ON Categories.CategoryID = Products.CategoryID";


        //"SELECT ProductID, ProductName, SupplierID, "
        //                        + "CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock, "
        //                        + "UnitsOnOrder, ReorderLevel, Discontinued FROM Products";

        

       
        NWConnection.Open();
        NWDataAdapter.SelectCommand = NWSelectCommand;
        NWDataAdapter.Fill(dsNorthWind, "Products");
        NWConnection.Close();
        #endregion

        #region set connection and the TableMappings for the DataAdapter (Categories Table Info)
        NWSelectCommand.Connection = NWConnection;
        NWSelectCommand.CommandText = "SELECT CategoryID,CategoryName,Description,Picture FROM Categories";
        //NWSelectCommand.CommandText = "SELECT EmployeeID,LastName FROM Employees";


        NWConnection.Open();
        NWDataAdapter.SelectCommand = NWSelectCommand;
        NWDataAdapter.Fill(dsNorthWind, "Categories");
        NWConnection.Close();
        #endregion

        #region set connection and the TableMappings for the DataAdapter (Shippers Table Info)
        NWSelectCommand.Connection = NWConnection;
        NWSelectCommand.CommandText = "SELECT ShipperID,CompanyName,Phone FROM Shippers";
 
        NWConnection.Open();
        NWDataAdapter.SelectCommand = NWSelectCommand;
        NWDataAdapter.Fill(dsNorthWind, "Shippers");
        NWConnection.Close();
        #endregion

        #region set connection and the TableMappings for the DataAdapter (Suppliers Table Info)
        NWSelectCommand.Connection = NWConnection;
        NWSelectCommand.CommandText = "SELECT SupplierID,CompanyName,ContactName,ContactTitle,Address, City,"
        + "Region,PostalCode,Country,Phone,Fax,HomePage FROM Suppliers";

        NWConnection.Open();
        NWDataAdapter.SelectCommand = NWSelectCommand;
        NWDataAdapter.Fill(dsNorthWind, "Suppliers");
        NWConnection.Close();
        #endregion
    }
        #endregion


    #region Get Tables Information

    #region	public String [,] getCustomerInformation()
    /// <summary>
	/// getCustomerNamesAndIDs()
	/// returned array has as many elements in the first dimension
	/// as there are records
	/// It has two elements in the second dimension
	/// </summary>
	/// <returns>A 2 dimensional string array 
	/// </returns>
	public String [,] getCustomerInformation()
	{
        String[,] CustomersList = null;
			
		// Allocate the 2 d array
        CustomersList = new String[dsNorthWind.Tables["Customers"].Rows.Count, dsNorthWind.Tables["Customers"].Columns.Count];

		// load the array
		int i = 0;
        foreach (DataRow customer in dsNorthWind.Tables["Customers"].Rows)
		{
            CustomersList[i, 0] = customer["CustomerID"].ToString();
            CustomersList[i, 1] = customer["CompanyName"].ToString();
            CustomersList[i, 2] = customer["ContactName"].ToString();
            CustomersList[i, 3] = customer["ContactTitle"].ToString();
            CustomersList[i, 4] = customer["Address"].ToString();
            CustomersList[i, 5] = customer["City"].ToString();
            CustomersList[i, 6] = customer["Region"].ToString();
            CustomersList[i, 7] = customer["PostalCode"].ToString();
            CustomersList[i, 8] = customer["Country"].ToString();
            CustomersList[i, 9] = customer["Phone"].ToString();
            CustomersList[i, 10] = customer["Fax"].ToString();
			i++;
		}
		return CustomersList;
	}

    #endregion
 
    #region	public String [,] getEmployeesInformation()
    public String[,] getEmployeesInformation()
    {

        String[,] EmployeesList = null;

        // Allocate the 2 d array
        EmployeesList = new String[dsNorthWind.Tables["Employees"].Rows.Count, dsNorthWind.Tables["Employees"].Columns.Count];

        // load the array
        int i = 0;
        foreach (DataRow employee in dsNorthWind.Tables["Employees"].Rows)
        {
            EmployeesList[i, 0] = employee["EmployeeID"].ToString();
            EmployeesList[i, 1] = employee["LastName"].ToString();
            EmployeesList[i, 2] = employee["FirstName"].ToString();
            EmployeesList[i, 3] = employee["Title"].ToString();
            EmployeesList[i, 4] = employee["TitleOfCourtesy"].ToString();
            EmployeesList[i, 5] = employee["BirthDate"].ToString();
            EmployeesList[i, 6] = employee["HireDate"].ToString();
            EmployeesList[i, 7] = employee["Address"].ToString();
            EmployeesList[i, 8] = employee["City"].ToString();
            EmployeesList[i, 9] = employee["Region"].ToString();
            EmployeesList[i, 10] = employee["PostalCode"].ToString();
            EmployeesList[i, 11] = employee["Country"].ToString();
            EmployeesList[i, 12] = employee["HomePhone"].ToString();
            EmployeesList[i, 13] = employee["Extension"].ToString();
            EmployeesList[i, 14] = employee["Photo"].ToString();
            EmployeesList[i, 15] = employee["Notes"].ToString();
            EmployeesList[i, 16] = employee["ReportsTo"].ToString();
            i++;
        }
        return EmployeesList;
    }
    #endregion      

    #region	public String [,] getProductsInformation()
    public String[,] getProductsInformation()
    {
        String[,] ProductsList = null;

        // Allocate the 2 d array
        ProductsList = new String[dsNorthWind.Tables["Products"].Rows.Count, dsNorthWind.Tables["Products"].Columns.Count];

        // load the array
        int i = 0;
        foreach (DataRow product in dsNorthWind.Tables["Products"].Rows)
        {
            ProductsList[i, 0] = product["ProductID"].ToString();
            ProductsList[i, 1] = product["ProductName"].ToString();
            ProductsList[i, 2] = product["CategoryID"].ToString();
            ProductsList[i, 3] = product["CategoryName"].ToString();
            ProductsList[i, 4] = product["SupplierID"].ToString();
            ProductsList[i, 5] = product["CompanyName"].ToString();
            ProductsList[i, 6] = product["QuantityPerUnit"].ToString();
            ProductsList[i, 7] = product["UnitPrice"].ToString();
            ProductsList[i, 8] = product["UnitsInStock"].ToString();
            ProductsList[i, 9] = product["UnitsOnOrder"].ToString();
            ProductsList[i, 10] = product["ReorderLevel"].ToString();
            ProductsList[i, 11] = product["Discontinued"].ToString();
            i++;
        }
        return ProductsList;
    }
    #endregion

    #region	public String [,] getCategoryInformation()
    public String[,] getCategoryInformation()
    {
        String[,] CategoryList = null;

        // Allocate the 2 d array
        CategoryList = new String[dsNorthWind.Tables["Categories"].Rows.Count, dsNorthWind.Tables["Categories"].Columns.Count];

        // load the array
        int i = 0;
        foreach (DataRow product in dsNorthWind.Tables["Categories"].Rows)
        {
            CategoryList[i, 0] = product["CategoryID"].ToString();
            CategoryList[i, 1] = product["CategoryName"].ToString();
            CategoryList[i, 2] = product["Description"].ToString();
            //CategoryList[i, 3] = product["Picture"].ToString();
            
            i++;
        }
        return CategoryList;
    }
    #endregion

    #region	public String [,] getShippersInformation()
    public String[,] getShippersInformation()
    {
        String[,] ShippersList = null;

        // Allocate the 2 d array
        ShippersList = new String[dsNorthWind.Tables["Shippers"].Rows.Count, dsNorthWind.Tables["Shippers"].Columns.Count];
        // load the array
        int i = 0;
        foreach (DataRow product in dsNorthWind.Tables["Shippers"].Rows)
        {
            ShippersList[i, 0] = product["ShipperID"].ToString();
            ShippersList[i, 1] = product["CompanyName"].ToString();
            ShippersList[i, 2] = product["Phone"].ToString();

            i++;
        }
        return ShippersList;
    }
    #endregion

    #region	public String [,] getSupplierInformation()
    public String[,] getSupplierInformation()
    {
        String[,] SupplierList = null;

        // Allocate the 2 d array
        SupplierList = new String[dsNorthWind.Tables["Suppliers"].Rows.Count, dsNorthWind.Tables["Suppliers"].Columns.Count];
        // load the array
        int i = 0;
        foreach (DataRow product in dsNorthWind.Tables["Suppliers"].Rows)
        {
            SupplierList[i, 0] = product["SupplierID"].ToString();
            SupplierList[i, 1] = product["CompanyName"].ToString();
            SupplierList[i, 2] = product["ContactName"].ToString();
            SupplierList[i, 3] = product["ContactTitle"].ToString();
            SupplierList[i, 4] = product["Address"].ToString();
            SupplierList[i, 5] = product["City"].ToString();
            SupplierList[i, 6] = product["Region"].ToString();
            SupplierList[i, 7] = product["PostalCode"].ToString();
            SupplierList[i, 8] = product["Country"].ToString();
            SupplierList[i, 9] = product["Phone"].ToString();
            SupplierList[i, 10] = product["Fax"].ToString();
            SupplierList[i, 11] = product["HomePage"].ToString();

            i++;
        }
        return SupplierList;
    }
    #endregion

    public SortedList getCategoryPictureList()
    {
        SortedList pictureList = new SortedList();

        int i = 0;
        foreach (DataRow product in dsNorthWind.Tables["Categories"].Rows)
        {
            if (!DBNull.Value.Equals(product["Picture"]))
            {
                pictureList.Add(int.Parse(product["CategoryID"].ToString()), product["Picture"]);
            }
            else
            {
                pictureList.Add(int.Parse(product["CategoryID"].ToString()), getDefaultBitmap());
            }

            i++;
        }

        return pictureList;
    }
    #endregion   


    //#region	public byte[][] getPictures()
    ///// <summary>
    ///// getPictures()
    ///// Return an array of many byte arrays 
    ///// Each byte array represents an image
    ///// </summary>
    ///// <returns>A jagged byte array 
    ///// </returns>
    //public byte[][] getPictures()
    //{
    //    DataSet dsNWPictures = new DataSet();
    //    byte[][] pictures = new byte[8][];
    //    NWSelectCommand.CommandText = "SELECT Picture FROM Categories";

    //    try
    //    {
    //        NWConnection.Open();
    //        NWDataAdapter.Fill(dsNWPictures, "Picture");
    //    }
    //    catch (Exception exception)
    //    {
            
    //    }
    //    finally
    //    {
    //        NWConnection.Close();
    //    }

    //    // load the array
    //    int i = 0;
    //    foreach (DataRow picture in dsNWPictures.Tables["Picture"].Rows)
    //    {
    //        if (!DBNull.Value.Equals(picture["Picture"]))//picture["Picture"]==Null//String.IsNullOrEmpty(picture["Picture"].ToString())
    //        {
    //            pictures[i] = (byte[])picture["Picture"];
    //        }
    //        else
    //        {
    //            pictures[i] = getDefaultBitmap();
    //        }

    //        i++;
    //    }

    //    return pictures;
    //}

    //#endregion



    #region DABaccess method for Products

    public void updateUnitsInStock(int productID, int decrement)
    {
        try
        {
            NWConnection.Open();
            // Query string concatenates fixed text with the user's selection
            string updates = "UPDATE [Products] SET Products.UnitsInStock = (Products.UnitsInStock -"
                + decrement + ") WHERE Products.ProductID = " + productID;
            OleDbDataAdapter da = new OleDbDataAdapter();
            OleDbCommand cmd = new OleDbCommand(updates, NWConnection);
            cmd.ExecuteNonQuery();

            if (productInfChange != null)
                productInfChange();
        }
        catch (Exception)
        {
        }
        finally
        {
            NWConnection.Close();
        }
    }

    public void insertProduct(String[] noPKvalue, Boolean discontinued)
    {


        try
        {

            int i = 0;
            foreach (System.Data.OleDb.OleDbParameter p in NWInsertProductCommand.Parameters)
            {

                switch (i)
                {
                    case 0:
                    case 3:
                        {
                            if ((noPKvalue[i].Trim().Length) == 0)
                            {
                                p.Value = DBNull.Value;
                            }
                            else
                            {
                                p.Value = noPKvalue[i];
                            }
                            break;
                        }
                    case 4:
                        {
                            if ((noPKvalue[i].Trim().Length) == 0)
                            {
                                p.Value = 0;
                            }
                            else
                            {
                                p.Value = Convert.ToDecimal(noPKvalue[i]);
                            }

                            break;
                        }
                    case 8:
                        {
                            p.Value = discontinued;

                            break;
                        }

                    default:
                        {
                            if ((noPKvalue[i].Trim().Length) == 0)
                            {
                                p.Value = 0;
                            }
                            else
                            {
                                p.Value = Convert.ToInt32(noPKvalue[i]);
                            }

                            break;
                        }


                }
                i++;
            }

            NWConnection.Open();
            NWInsertProductCommand.ExecuteNonQuery();


        }
        catch (Exception)
        {
        }
        finally
        {
            NWConnection.Close();
        }
        if (productInfChange != null)
            productInfChange();



    }

    public void updateProductInfo(String ProductID, String[] noPKvalue, Boolean discontinued)
    {
        try
        {

            int i = 0;
            foreach (System.Data.OleDb.OleDbParameter p in NWUpdateProductCommand.Parameters)
            {

                switch (i)
                {
                    case 0:
                    case 3:
                        {
                            if ((noPKvalue[i].Trim().Length) == 0)
                            {
                                p.Value = DBNull.Value;
                            }
                            else
                            {
                                p.Value = noPKvalue[i];
                            }
                            break;
                        }
                    case 4:
                        {
                            if ((noPKvalue[i].Trim().Length) == 0)
                            {
                                p.Value = 0.0;
                            }
                            else
                            {
                                p.Value = Convert.ToDecimal(noPKvalue[i]);
                            }

                            break;
                        }
                    case 8:
                        {
                            p.Value = discontinued;

                            break;
                        }
                        
                    case 9:
                        {
                            p.Value = Convert.ToInt32(ProductID);

                            break;
                        }

                    default:
                        {
                            if ((noPKvalue[i].Trim().Length) == 0)
                            {
                                p.Value = 0;
                            }
                            else
                            {
                                p.Value = Convert.ToInt32(noPKvalue[i]);
                            }

                            break;
                        }


                }
                i++;
            }

            NWConnection.Open();
            NWUpdateProductCommand.ExecuteNonQuery();


        }
        catch (Exception)
        {
        }
        finally
        {
            NWConnection.Close();
        }
        if (productInfChange != null)
            productInfChange();


    }


    public void deleteProductInfo(String ProductID)
    {

        try
        {
            NWDeleteProductCommand.Parameters["ProductID"].Value = ProductID;

            NWConnection.Open();
            NWDeleteProductCommand.ExecuteNonQuery();

            if (customerInfChange != null)
                customerInfChange();
        }
        catch (Exception)
        {
        }
        finally
        {
            NWConnection.Close();
        }
    }

    #endregion 

    #region DABaccess method for Customer
    public void insertCustomer(String CustomerID, String[] noPKvalue)
    {
       
        try
        {
  
            int i = 0;
            foreach (System.Data.OleDb.OleDbParameter p in NWInsertCustomerCommand.Parameters)
            {

                if (i == 0)
                {
                    p.Value = CustomerID;
                }
                else if ((noPKvalue[i - 1].Trim().Length) == 0)
                {
                    p.Value = DBNull.Value;
                }
                else
                {
                    p.Value = noPKvalue[i - 1];
                }
                i++;
            }

            NWConnection.Open();
            NWInsertCustomerCommand.ExecuteNonQuery();


        }
        catch (Exception)
        {
        }
        finally
        {
            NWConnection.Close();
        }

        if (customerInfChange != null)
            customerInfChange();

    }

    public void updateCustomerInfo(String CustomerID, String[] noPKvalue)
    {

        try
        {
         int i = 0;
            foreach (System.Data.OleDb.OleDbParameter p in NWUpdateCustomerCommand.Parameters)
            {

                if (i == 10)
                {
                    p.Value =  CustomerID;
                }

                else if ((noPKvalue[i].Trim().Length) == 0)
                {
                    p.Value = DBNull.Value;
                }
                else
                {
                    p.Value = noPKvalue[i];
                }
                i++;
            }

            NWConnection.Open();
            NWUpdateCustomerCommand.ExecuteNonQuery();


        }
        catch (Exception)
        {
        }
        finally
        {
            NWConnection.Close();
        }

        if (customerInfChange != null)
            customerInfChange();
    }


    public void deleteCustomerInfo(String CustomerID)
    {
   
        try
        {
            NWDeleteCustomerCommand.Parameters["CustomerID"].Value = CustomerID;

            NWConnection.Open();
            NWDeleteCustomerCommand.ExecuteNonQuery();

            if (customerInfChange != null)
                customerInfChange();
        }
        catch (Exception)
        {
        }
        finally
        {
            NWConnection.Close();
        }
    }

    #endregion

    #region DABaccess method for Employee
    public void insertEmployee(String[] noPKvalue)
    {

        try
        {

            int i = 0;
            foreach (System.Data.OleDb.OleDbParameter p in NWInsertEmployeeCommand.Parameters)
            {
                switch(i)
                {
                    //case 0:
                    //case 1:
                    //case 2:
                    //case 3:
                    //case 6:
                    //case 7:
                    //case 8:
                    //case 9:
                    //case 10:
                    //case 11:
                    //case 12:
                    //case 13:
                    //case 14:

                    case 4:
                    case 5:
                        {
                            p.Value = Convert.ToDateTime(noPKvalue[i]);//DateTime dt = Convert.ToDateTime(date); 
                            break;
                        }

                    case 15:
                        {
                            if ((noPKvalue[i].Trim().Length) == 0)
                            {
                                p.Value = 0;
                            }
                            else
                            {
                                p.Value = Convert.ToInt32(noPKvalue[i]);
                            }
                            
                            break;
                        }

                    default:
                        {
                            if ((noPKvalue[i].Trim().Length) == 0)
                            {
                                p.Value = DBNull.Value;
                            }
                            else
                            {
                                p.Value = noPKvalue[i];
                            }

                            break;
                        }
                        

                }


                i++;
            }

            NWConnection.Open();
            NWInsertEmployeeCommand.ExecuteNonQuery();


        }
        catch (Exception)
        {
        }
        finally
        {
            NWConnection.Close();
        }
        if (employeeInfChange != null)
            employeeInfChange();

    }

    public void updateEmployeeInfo(String EmployeeID, String[] noPKvalue)
    {

        try
        {

            int i = 0;
            foreach (System.Data.OleDb.OleDbParameter p in NWUpdateEmployeeCommand.Parameters)
            {
                switch (i)
                {
                    //case 0:
                    //case 1:
                    //case 2:
                    //case 3:
                    //case 6:
                    //case 7:
                    //case 8:
                    //case 9:
                    //case 10:
                    //case 11:
                    //case 12:
                    //case 13:
                    //case 14:

                    case 4:
                    case 5:
                        {
                            p.Value = Convert.ToDateTime(noPKvalue[i]);//DateTime dt = Convert.ToDateTime(date); 
                            break;
                        }

                    case 15:
                        {
                            if ((noPKvalue[i].Trim().Length) == 0)
                            {
                                p.Value = 0;
                            }
                            else
                            {
                                p.Value = Convert.ToInt32(noPKvalue[i]);
                            }

                            break;
                        }
                    case 16:
                        {
                            p.Value = Convert.ToInt32(EmployeeID);
                            break;
                        }
                    default:
                        {
                            if ((noPKvalue[i].Trim().Length) == 0)
                            {
                                p.Value = DBNull.Value;
                            }
                            else
                            {
                                p.Value = noPKvalue[i];
                            }

                            break;
                        }


                }


                i++;
            }

            NWConnection.Open();
            NWUpdateEmployeeCommand.ExecuteNonQuery();


        }
        catch (Exception)
        {
        }
        finally
        {
            NWConnection.Close();
        }
        if (employeeInfChange != null)
            employeeInfChange();


    }


    public void deleteEmployeeInfo(String EmployeeID)
    {

        try
        {
            NWDeleteEmployeeCommand.Parameters["EmployeeID"].Value = EmployeeID;

            NWConnection.Open();
            NWDeleteEmployeeCommand.ExecuteNonQuery();

            if (customerInfChange != null)
                customerInfChange();
        }
        catch (Exception)
        {
        }
        finally
        {
            NWConnection.Close();
        }
    }

    #endregion

    #region DABaccess method for Category
    public void insertCategory(String[] noPKvalue, Byte[] picture)
    {

        try
        {

            int i = 0;
            foreach (System.Data.OleDb.OleDbParameter p in NWInsertCategoryCommand.Parameters)
            {


                if(i==2)
                {
                    if (picture==null)
                    {
                        p.Value = DBNull.Value;
                    }
                    else
                    {
                        p.Value = picture;
                    }
                    
                }
                else if ((noPKvalue[i].Trim().Length) == 0)
                {
                    p.Value = DBNull.Value;
                }
                else
                {
                    p.Value = noPKvalue[i];
                }
                i++;
            }

            NWConnection.Open();
            NWInsertCategoryCommand.ExecuteNonQuery();


        }
        catch (Exception)
        {
        }
        finally
        {
            NWConnection.Close();
        }
        if (categoryInfChange != null)
            categoryInfChange();

    }

    public void updateCategoryInfo(String CategoryID, String[] noPKvalue, Byte[] picture)
    {

        
        try
        {
            if (picture == null)
            {

                int i = 0;
                foreach (System.Data.OleDb.OleDbParameter p in NWUpdateCategoryCommandWithoutpicture.Parameters)
                {

                    if (i == 2)
                    {
                        p.Value = Convert.ToInt32(CategoryID);
                    }

                    else if ((noPKvalue[i].Trim().Length) == 0)
                    {
                        p.Value = DBNull.Value;
                    }
                    else
                    {
                        p.Value = noPKvalue[i];
                    }
                    i++;
                }
                NWConnection.Open();
                NWUpdateCategoryCommandWithoutpicture.ExecuteNonQuery();
            }
            else
            {
                int i = 0;
                foreach (System.Data.OleDb.OleDbParameter p in NWUpdateCategoryCommandWithpicture.Parameters)
                {

                    if (i == 2)
                    {

                        p.Value = picture;

                    }
                    else if (i == 3)
                    {
                        p.Value = Convert.ToInt32(CategoryID);
                    }

                    else if ((noPKvalue[i].Trim().Length) == 0)
                    {
                        p.Value = DBNull.Value;
                    }
                    else
                    {
                        p.Value = noPKvalue[i];
                    }
                    i++;

                }
                NWConnection.Open();
                NWUpdateCategoryCommandWithpicture.ExecuteNonQuery();
            }

        //try
        //{
        //    int i = 0;
        //    foreach (System.Data.OleDb.OleDbParameter p in NWUpdateCategoryCommandWithpicture.Parameters)
        //    {

        //        if (i == 2)
        //        {
        //            if (picture == null)
        //            {
        //                p.Value = DBNull.Value;
        //            }
        //            else
        //            {
        //                p.Value = picture;
        //            }

        //        }
        //        else if (i == 3)
        //        {
        //            p.Value =  Convert.ToInt32(CategoryID);
        //        }

        //        else if ((noPKvalue[i].Trim().Length) == 0)
        //        {
        //            p.Value = DBNull.Value;
        //        }
        //        else
        //        {
        //            p.Value = noPKvalue[i];
        //        }
        //        i++;
        //    }

            //NWConnection.Open();
            //NWUpdateCategoryCommandWithpicture.ExecuteNonQuery();



        }
        catch (Exception)
        {
        }
        finally
        {
            NWConnection.Close();
        }
        if (categoryInfChange != null)
            categoryInfChange();
    }


    public void deleteCategoryInfo(String CategoryID)
    {

        try
        {
            NWDeleteCategoryCommand.Parameters["CategoryID"].Value = CategoryID;

            NWConnection.Open();
            NWDeleteCategoryCommand.ExecuteNonQuery();

            if (customerInfChange != null)
                customerInfChange();
        }
        catch (Exception)
        {
        }
        finally
        {
            NWConnection.Close();
        }
    }

    #endregion

    #region DABaccess method for Shippers
    public void insertShipper(String[] noPKvalue)//String ShipperID,
    {

        try
        {

            int i = 0;
            foreach (System.Data.OleDb.OleDbParameter p in NWInsertShipperCommand.Parameters)
            {

                //if (i == 0)
                //{
                //    p.Value = ShipperID;
                //}
                //else 
                    if ((noPKvalue[i].Trim().Length) == 0)
                {
                    p.Value = DBNull.Value;
                }
                else
                {
                    p.Value = noPKvalue[i];
                }
                i++;
            }

            NWConnection.Open();
            NWInsertShipperCommand.ExecuteNonQuery();


        }
        catch (Exception)
        {
        }
        finally
        {
            NWConnection.Close();
        }
        if (ShipperInfChange != null)
            ShipperInfChange();

    }

    public void updateShipperInfo(String ShipperID, String[] noPKvalue)
    {

        try
        {
            int i = 0;
            foreach (System.Data.OleDb.OleDbParameter p in NWUpdateShipperCommand.Parameters)
            {

                if (i == 2)
                {
                    p.Value = ShipperID;
                }

                else if ((noPKvalue[i].Trim().Length) == 0)
                {
                    p.Value = DBNull.Value;
                }
                else
                {
                    p.Value = noPKvalue[i];
                }
                i++;
            }

            NWConnection.Open();
            NWUpdateShipperCommand.ExecuteNonQuery();


        }
        catch (Exception)
        {
        }
        finally
        {
            NWConnection.Close();
        }

        if (ShipperInfChange != null)
            ShipperInfChange();
    }


    public void deleteShipperInfo(String ShipperID)
    {

        try
        {
            NWDeleteShipperCommand.Parameters["ShipperID"].Value = ShipperID;

            NWConnection.Open();
            NWDeleteShipperCommand.ExecuteNonQuery();


        }
        catch (Exception)
        {
        }
        finally
        {
            NWConnection.Close();
        }
        if (customerInfChange != null)
            customerInfChange();
    }

    #endregion

    #region DABaccess method for Suppliers
    public void insertSupplier(String[] noPKvalue)
    {

        try
        {
            int i = 0;
            foreach (System.Data.OleDb.OleDbParameter p in NWInsertSupplierCommand.Parameters)
            {

                if ((noPKvalue[i].Trim().Length) == 0)
                {
                    p.Value = DBNull.Value;
                }
                else
                {
                    p.Value = noPKvalue[i];
                }
                i++;
            }

            NWConnection.Open();
            NWInsertSupplierCommand.ExecuteNonQuery();


        }
        catch (Exception)
        {
        }
        finally
        {
            NWConnection.Close();
        }
        if (SupplierInfChange != null)
            SupplierInfChange();

    }

    public void updateSupplierInfo(String SupplierID, String[] noPKvalue)
    {

        try
        {
            int i = 0;
            foreach (System.Data.OleDb.OleDbParameter p in NWUpdateSupplierCommand.Parameters)
            {

                if (i == 11)
                {
                    p.Value = Convert.ToInt32(SupplierID);
                }

                else if ((noPKvalue[i].Trim().Length) == 0)
                {
                    p.Value = DBNull.Value;
                }
                else
                {
                    p.Value = noPKvalue[i];
                }
                i++;
            }

            NWConnection.Open();
            NWUpdateSupplierCommand.ExecuteNonQuery();


        }
        catch (Exception)
        {
        }
        finally
        {
            NWConnection.Close();
        }
        if (SupplierInfChange != null)
            SupplierInfChange();
    }


    public void deleteSupplierInfo(String SupplierID)
    {

        try
        {
            NWDeleteSupplierCommand.Parameters["SupplierID"].Value = SupplierID;

            NWConnection.Open();
            NWDeleteSupplierCommand.ExecuteNonQuery();

            if (customerInfChange != null)
                customerInfChange();
        }
        catch (Exception)
        {
        }
        finally
        {
            NWConnection.Close();
        }
    }

    #endregion

    #region public string insertOrders(string CustomerID, string EmployeeID, string OrderDate)
    /// <summary>
    /// insertOrders(string CustomerID, string EmployeeID, string OrderDate)
    /// get those valuse and insert them into table Orders
    /// as a new row
    /// </summary>
    /// <param name="CustomerID"> the CustomerID value</param>
    /// <param name="EmployeeID"> the EmployeeID value</param>
    /// <param name="OrderDate">the OrderDate value</param>
    /// /// <returns>The new automatic generated OrderID 
    /// that is associated with the new insert values</returns>
    public string insertOrders(string CustomerID, string EmployeeID, string OrderDate)
    {
        NWInsertCommand.CommandText = "INSERT INTO Orders"
            + "(CustomerID, EmployeeID, OrderDate) "
            + "VAlUES ('" + CustomerID + "'," + EmployeeID + ",'" + OrderDate + "')";

        NWSelectCommand.CommandText = "SELECT MAX(OrderID) FROM Orders";
        string OrderID = null;
        try
        {
            NWConnection.Open();
            NWInsertCommand.ExecuteNonQuery();
            if (NWSelectCommand.ExecuteScalar() != null)
            {
                OrderID = NWSelectCommand.ExecuteScalar().ToString();
            }
        }
        catch (Exception exception)
        {
           
        }
        finally
        {
            NWConnection.Close();
        }
        return OrderID;
    }

    #endregion


    #region public void insertOrderDetails(string OrderID, string ProductID, string UnitPrice, string Quantity)
    /// <summary>
    /// insertOrderDetails(string OrderID, string ProductID, string UnitPrice, string Quantity)
    /// get those valuse and insert them into table OrderDetails
    /// as a new row
    /// </summary>
    /// <param name="OrderID"> the OrderID value</param>
    /// <param name="ProductID"> the ProductID value</param>
    /// <param name="UnitPrice"> the UnitPrice value</param>
    /// <param name="Quantity">the Quantity value</param>
    public void insertOrderDetails(string OrderID, string ProductID, string UnitPrice, string Quantity)
    {
        // We not consider Discount in this project, insert value will be 0
        NWInsertCommand.CommandText = "INSERT INTO [Order Details]"
            + "(OrderID, ProductID, UnitPrice, Quantity, Discount) "
            + "VAlUES (" + OrderID + "," + ProductID + "," + UnitPrice + "," + Quantity + ", 0)";

        try
        {
            NWConnection.Open();
            NWInsertCommand.ExecuteNonQuery();
        }
        catch (Exception exception)
        {
            
        }
        finally
        {
            NWConnection.Close();
        }

    }
    #endregion

    #region public void updateUnitsInStock(string ProductID, string Quantity)
    /// <summary>
    /// updateUnitsInStock(string ProductID, string Quantity)
    /// get those valuse and update table Products
    /// Decrease the given quantity in the UnitsInStock value
    /// that is associated with the given ProductID
    /// </summary>
    /// <param name="OrderID"> the OrderID value</param>
    /// <param name="ProductID"> the ProductID value</param>
    /// <param name="UnitPrice"> the UnitPrice value</param>
    /// <param name="Quantity">the Quantity value</param>
    public void updateUnitsInStock(string ProductID, string Quantity)
    {
        NWUpdateCommand.CommandText = "UPDATE [Products] SET Products.UnitsInStock ="
            + "(Products.UnitsInStock -" + Quantity + ") WHERE Products.ProductID = "
            + ProductID;

        try
        {
            NWConnection.Open();
            NWUpdateCommand.ExecuteNonQuery();
        }
        catch (Exception exception)
        {
            
        }
        finally
        {
            NWConnection.Close();
        }

    }
    #endregion
    #region private byte[] getDefaultBitmap()
    /// <summary>
    /// defaut image for fill category picture information
    /// if the picture of category is null in database
    /// </summary>
    /// <returns></returns>
    private byte[] getDefaultBitmap()
    {
        Bitmap img = new Bitmap(@"..\..\image\defaultImageforCategory.bmp");//..\..\Northwind.mdb;
        byte[] byteArray = new byte[0];
        using (MemoryStream stream = new MemoryStream())
        {
            img.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
            stream.Close();

            byteArray = stream.ToArray();
        }
        return byteArray;
    }
    #endregion
}
