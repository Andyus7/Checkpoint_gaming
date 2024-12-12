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

namespace WinFormsProyectoFinal
{
    public partial class PurchaseSummaryForm : Form
    {

        private List<CartItem> cartItems = new List<CartItem>();

        public PurchaseSummaryForm(List<CartItem> items, decimal total, string paymentMethod, string clientName)
        {
            InitializeComponent();
            ConfigureListView();
            LoadCart();
            this.cartItems = items;

            lblTitle.Text = "Purchase Summary";
            lblClientName.Text = $"Client: {clientName}";
            lblPaymentMethod.Text = $"Payment Method: {paymentMethod}";
            lblTotal.Text = $"Total: ${total:F2}";
            listProducts.Items.Clear();

            foreach (var item in items)
            {
                listProducts.Items.Add($"{item.Name} - ${item.Price} x {item.Quantity}");
            }
        }

        private void ConfigureListView()
        {
            // Configurar el ListView para mostrar en vista de "Detalles"
            listProducts.View = View.Details;
            listProducts.FullRowSelect = true; // Selección completa del renglón
            listProducts.GridLines = true; // Líneas entre los datos

            // Agregar columnas al ListView
            listProducts.Columns.Clear();
            listProducts.Columns.Add("Products", 150, HorizontalAlignment.Left);
        }

        private void LoadCart()
        {
            listProducts.Items.Clear();

            // Poblar el ListView con los datos de `cartItems`
            foreach (var item in cartItems)
            {
                var subtotal = item.Price * item.Quantity;

                ListViewItem row = new ListViewItem(item.Name);
                row.SubItems.Add(item.Price.ToString("C2")); // Precio
                row.SubItems.Add(item.Quantity.ToString()); // Cantidad
                row.SubItems.Add(subtotal.ToString("C2")); // Subtotal

                listProducts.Items.Add(row);
            }
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra el formulario
        }
    }
}
