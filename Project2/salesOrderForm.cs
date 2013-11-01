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
    public partial class salesOrderForm : Form
    {
        private Business business;
        private string outOfStockProducts;
        private string OrderID;
        private frmCatalog myfrmCatalog;

        public salesOrderForm(Business mybusiness)
        {
            this.business = mybusiness;
            InitializeComponent();
        }

        private void salesOrderForm_Load(object sender, EventArgs e)
        {
            // Set value for all comboboxes
            cmbCustomerID.Items.AddRange(business.getCustomerIDs());
            cmbCustomerName.Items.AddRange(business.getCustomerNames());
            cmbClerkName.Items.AddRange(business.getEmployeeNames());
            lblTime.Text = string.Format("{0:dd MMM yyyy HH:mm}", DateTime.Now);
            // Align all numbers to right
            this.salesList.Columns["productPrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.salesList.Columns["quantity"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.salesList.Columns["linePrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.txtTotalPrice.TextAlign = HorizontalAlignment.Right;
        }

        private void cmbCustomerID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCustomerID.SelectedIndex != -1)
            { cmbCustomerName.SelectedIndex = cmbCustomerID.SelectedIndex; }
        }

        private void cmbCustomerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCustomerName.SelectedIndex != -1)
            { cmbCustomerID.SelectedIndex = cmbCustomerName.SelectedIndex; }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = string.Format("{0:dd MMM yyyy HH:mm}", DateTime.Now);
        }

        private void btnCatalog_Click(object sender, EventArgs e)
        {
            if (myfrmCatalog == null || myfrmCatalog.IsDisposed)
            {
                myfrmCatalog = new frmCatalog(this);
                myfrmCatalog.MdiParent = this.MdiParent;
            }
            myfrmCatalog.Text = "Catalog for " + this.Text;
            myfrmCatalog.Show();
        }

        public Business getMyBusiness()
        {
            return business;
        }

        /// <summary>
        /// Add a new sales line in the dataGridView
        /// If is a duplicate order, trow exception
        ///Because we will call this method at catalog form
        /// Catalog form will show warnning message after catched exception
        /// </summary>
        /// <param name="index"></param>
        public void addNewSalesLine(int index)
        {

            if (checkDuplicateOrder(index))
            {
                throw new System.ArgumentException();
            }
            else
            {
                string ID = business.getProductsInformation()[index, 0];
                string name = business.getProductsInformation()[index, 1];
                double price = Convert.ToDouble(business.getProductsInformation()[index, 7]);
                // Add a new row for sales, n will be the new row index
                int n = salesList.Rows.Add();

                salesList.Rows[n].Cells[0].Value = ID;
                salesList.Rows[n].Cells[1].Value = name;
                salesList.Rows[n].Cells[2].Value = price;
            }
        }



        /// <summary>
        /// Check if product aready exist in dataGridView
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        private Boolean checkDuplicateOrder(int index)
        {
            Boolean duplicated = false;
            for (int i = 0; i < salesList.Rows.Count; i++)
            {

                if (business.getProductsInformation()[index, 0] == salesList.Rows[i].Cells[0].Value.ToString())
                    duplicated = true;


            }
            return duplicated;
        }

        private void dgProducts_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            UpdateLinePrice();
        }

        private void UpdateLinePrice()
        {
            double totalPrice = 0;
            if (salesList.Rows.Count > 0) // Check is there any sales line
            {
                for (int i = 0; i < salesList.Rows.Count; i++)
                {
                    if (salesList.Rows[i].Cells[3].Value != null)
                    {
                        try // Check is the input only include numbers
                        {
                            int quantity = Convert.ToInt32(salesList.Rows[i].Cells[3].Value);
                            if (quantity >= 0) // Check is it a postive number
                            {
                                double price = Convert.ToDouble(salesList.Rows[i].Cells[2].Value);
                                salesList.Rows[i].Cells[4].Value = (price * quantity); //Update line price
                                totalPrice += Convert.ToDouble(salesList.Rows[i].Cells[4].Value); // Update total price
                            }
                            else
                                salesList.Rows[i].Cells[3].Value = null;
                        }
                        catch (Exception)
                        {
                            salesList.Rows[i].Cells[3].Value = null;
                        }
                    }
                }
            }
            txtTotalPrice.Text = "$" + totalPrice.ToString();
        }


 

        public string GetOrderID
        {
            get
            {
                return OrderID;
            }
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            if (cmbClerkName.SelectedIndex == -1) //check is employee name selected
            {
                MessageBox.Show("You have to choose your name before submit order.");
            }
            else if (cmbCustomerID.SelectedIndex == -1) // Check is customer selected
            {
                MessageBox.Show("You have to choose customer before submit order.");
            }
            else
            {
                if (checkStock() == null) // If no outOfStock product, update DataBase
                {
                    updateDataBase();
                }
                // Open confirmation for to dispaly result
                Form myfrmConfirmation = new frmConfirmation(this);
                myfrmConfirmation.MdiParent = this.MdiParent;
                myfrmConfirmation.Text = "Confirmation for " + this.Text;
                myfrmConfirmation.Show();
            }
        }
        private string checkStock()
        {
            outOfStockProducts = null;
            for (int i = 0; i < salesList.Rows.Count; i++)
            {
                if (salesList.Rows[i].Cells[3].Value != null)
                {
                    if (Convert.ToInt32(salesList.Rows[i].Cells[3].Value) > business.getUnitsInStock(Convert.ToInt32(salesList.Rows[i].Cells[0].Value)))
                    {
                        outOfStockProducts += "Product: " + salesList.Rows[i].Cells[1].Value + " is out of stock" + Environment.NewLine;
                    }
                }
            }
            return outOfStockProducts;
        }

        public string getOutOfStockProducts()
        {
            return outOfStockProducts;
        }

        private void updateDataBase()
        {
            //collect necessary informations
            string EmployeeID = business.getEmployeeID(cmbClerkName.SelectedIndex);
            string CustomerID = business.getCustomerIDs()[cmbCustomerID.SelectedIndex];
            string OrderDate = "11-17-2012";
            //DateTime.Now.ToString("dd-mmm-yyyy");
            //string.Format("{04-Jul-1996}", DateTime.Now);


            // Insert into Orders table, return the new OrderID
            OrderID = business.insertOrders(CustomerID, EmployeeID, OrderDate);


            for (int i = 0; i < salesList.Rows.Count; i++)
            {
                if (salesList.Rows[i].Cells[3].Value != null)
                {
                    string ProductID = salesList.Rows[i].Cells[0].Value.ToString();
                    string UnitPrice = salesList.Rows[i].Cells[2].Value.ToString();
                    string Quantity = salesList.Rows[i].Cells[3].Value.ToString();
                    // Insert into OrderDetails table
                    business.insertOrderDetails(OrderID, ProductID, UnitPrice, Quantity);
                    // Update Products table
                    business.updateUnitsInStock(int.Parse(ProductID), int.Parse(Quantity));
                }
            }




        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want cancel this order?", "Cancel", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                resetForm();
            }
            else if (dialogResult == DialogResult.No)
            {
            }
        }

        public void resetForm()
        {
            cmbClerkName.SelectedIndex = -1;
            cmbCustomerID.SelectedIndex = -1;
            cmbCustomerName.SelectedIndex = -1;
            cmbCustomerID.Text = "ID";
            cmbCustomerName.Text = "Name";
            txtTotalPrice.Text = null;
            salesList.Rows.Clear();
        }


        

 

    }



    
}
