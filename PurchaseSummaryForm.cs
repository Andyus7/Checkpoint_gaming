using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsProyectoFinal.Models;
using Timer = System.Windows.Forms.Timer;

namespace WinFormsProyectoFinal
{
    public partial class PurchaseSummaryForm : Form
    {
        #region Private local variables

        private List<CartItem> cartItems = new List<CartItem>();

        private DateTime purchaseDateTime;

        #endregion

        #region Builder
        public PurchaseSummaryForm(List<CartItem> items, decimal total, string paymentMethod, string clientName)
        {
            InitializeComponent();
            ConfigureListView();
            this.cartItems = items;

            purchaseDateTime = DateTime.Now;

            lblClientName.Text = $"Client: {clientName}";
            lblPaymentMethod.Text = $"Payment Method: {paymentMethod}";
            lblTotal.Text = $"Total with taxes: ${total:F2}";
            lblDate.Text = $"Date: {purchaseDateTime.ToShortDateString()}";
            lblTime.Text = $"Time: {purchaseDateTime.ToShortTimeString()}";

            // Poblar el ListView
            LoadCart();
        }

        #endregion

        #region List view Config
        private void ConfigureListView()
        {
            // Configure the ListView to display in “Details” view
            listProducts.View = View.Details;
            listProducts.FullRowSelect = true;//Complete line selection
            listProducts.GridLines = true;//Lines between data

            //Add columns to the ListView
            listProducts.Columns.Clear();
            listProducts.Columns.Add("Products", 150, HorizontalAlignment.Left); //Product name
            listProducts.Columns.Add("Price", 100, HorizontalAlignment.Right);   //Price
            listProducts.Columns.Add("Quantity", 100, HorizontalAlignment.Center); //Quantity
            listProducts.Columns.Add("Subtotal", 100, HorizontalAlignment.Right); //Subtotal
        }
        private void LoadCart()
        {
            listProducts.Items.Clear();

            //Populate the ListView with data from `cartItems`.
            foreach (var item in cartItems)
            {
                
                decimal taxes = (item.Price*6)/100;
                decimal total = item.Price+taxes;
                var subtotal =total* item.Quantity;

                // Crear un renglón del ListView
                ListViewItem row = new ListViewItem(item.Name); //Product column
                row.SubItems.Add(item.Price.ToString("C2"));    // Price column
                row.SubItems.Add(item.Quantity.ToString());     //Quantity column
                row.SubItems.Add(subtotal.ToString("C2"));      //Subtotal column

                //Add line to ListView
                listProducts.Items.Add(row);
            }
        }
        #endregion

        #region Btn OK
        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra el formulario
        }
        #endregion

        #region useless for now
        private void lblClientName_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
