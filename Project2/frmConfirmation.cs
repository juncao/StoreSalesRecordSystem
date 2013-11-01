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
    public partial class frmConfirmation : Form
    {
        private salesOrderForm salesForm;

        public frmConfirmation(salesOrderForm s)
        {
            InitializeComponent();
            salesForm = s;
            // If have out of stock product, show product names
            // let user choose modify or cancel order
            if (salesForm.getOutOfStockProducts() != null)
            {
                lblMessage.Text = salesForm.getOutOfStockProducts() + "Please modify your order.";
                modifyButton.Visible = true;
                cancelButton.Visible = true;
                confirmButton.Visible = false;
            }
            else
            {
                lblMessage.Text = "Your order is placed." +Environment.NewLine
                                    + "Your order ID is:" + salesForm.GetOrderID;
                confirmButton.Visible = true;
                modifyButton.Visible = false;
                cancelButton.Visible = false;
            }
        }
        // If user choose modify order, close thie form let client go back to sales form
        private void modifyButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // If user choose cancel order, close this form, also reset sales form
        private void cancelButton_Click(object sender, EventArgs e)
        {
            salesForm.resetForm();
            this.Close();
        }
        // After confirm, close this form, reset sales form
        private void confirmButton_Click(object sender, EventArgs e)
        {
            salesForm.resetForm();
            this.Close();
        }
    }
}
