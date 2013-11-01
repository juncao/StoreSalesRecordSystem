/*******************************************************************/
/**                                                               **/
/**    Group                       :  Project2 05                 **/
/**    Student Name                :  Jun Cao, Sufeng Ding,       **/
/**                                   Muran Yang, Zhi Long Wu,    **/
/**                                   Cristian Salinas-O'Neill    **/
/**    Course Number               :  CST2335                     **/
/**    Lab Section Number          :  411                         **/
/**    Professor Name              :  John Tappin                 **/
/**    Assignment Name/Number/Date :  Project2                    **/
/**                                                               **/
/*******************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Web;
using System.IO;

namespace Project2
{
    public partial class frmCatalog : Form
    {

        private salesOrderForm salesForm;

        public frmCatalog(salesOrderForm s)
        {
            InitializeComponent();
            salesForm = s;
        }


        private void frmCatalog_Load(object sender, EventArgs e)
        {
            // Align UnitPrice to right
            this.dgProducts.Columns["UnitPrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            // Load products information
            string[,] products = salesForm.getMyBusiness().getProductsInformation();
            int count = products.GetLength(0);

            for (int i = 0; i < count; i++)
            {
                int n = dgProducts.Rows.Add();
                ImageConverter ic = new ImageConverter();
                Image img = (Image)ic.ConvertFrom(salesForm.getMyBusiness().getPictureByID(int.Parse(products[i, 2])));
                Bitmap bitmap1 = new Bitmap(img);
                dgProducts.Rows[n].Cells[0].Value = img; // Show category picture on first column

                //dgProducts.Rows[n].Cells[0].Value = products[i, 4];
                dgProducts.Rows[n].Cells[1].Value = products[i, 0];
                dgProducts.Rows[n].Cells[2].Value = products[i, 1];
                dgProducts.Rows[n].Cells[3].Value = products[i, 3];
                dgProducts.Rows[n].Cells[4].Value = products[i, 2];
            }
        }
        // This is a click event related to all cells
        public void clickeAddOrder(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int index = e.RowIndex;

                try
                {
                    // Add a new sales line on the realetd sales form
                    salesForm.addNewSalesLine(index);
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("This product already in order form.");
                }
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

   

    }
}
