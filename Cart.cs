using iTextSharp.text.pdf;
using iTextSharp.text;
using MySql.Data.MySqlClient;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;
using K4os.Compression.LZ4.Streams.Adapters;

namespace WinFormsProyectoFinal
{
    public partial class Cart : Form
    {
        #region Private local variables

        private List<CartItem> cartItems;

        private AdmonBD db = new AdmonBD();

        private int currentUserId;


        #endregion

        #region Builder
        public Cart(List<CartItem> shoppingCart, AdmonBD db, int userId)
        {
            InitializeComponent();
            this.cartItems = shoppingCart;
            this.db = db;
            this.currentUserId = userId;
            configListView();
            LoadCart();
        }
        #endregion

        #region Button Buy
        private void button1_Click(object sender, EventArgs e)
        {
            if (cartItems == null || !cartItems.Any())
            {
                MessageBox.Show("Error, empty cart", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ProcessPayment("Efectivo");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (cartItems == null || !cartItems.Any()) {
                MessageBox.Show("Error, empty cart", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var creditCardForm = new creditCard();
                creditCardForm.PaymentCompleted += method => ProcessPayment(method);
                creditCardForm.ShowDialog(); // Show as pop-up window
            }
        }
        private void ProcessPayment(string paymentMethod)
        {
            decimal total = cartItems.Sum(item => item.Price * item.Quantity);
            decimal taxes = (6 * total) / 100; // Cálculo de impuestos
            decimal totalWithTaxes = taxes + total; // Total con impuestos

            try
            {
                foreach (var item in cartItems)
                {
                    string updateQuery = "UPDATE consolesplay SET Existencias = Existencias - @cantidad WHERE nombre = @nombre";
                    using (var cmd = new MySqlCommand(updateQuery, db.GetConnection()))
                    {
                        cmd.Parameters.AddWithValue("@cantidad", item.Quantity);
                        cmd.Parameters.AddWithValue("@nombre", item.Name);
                        cmd.ExecuteNonQuery();
                    }
                }

                string userUpdateQuery = "UPDATE usuarios SET Monto = Monto + @totalWithTaxes WHERE id = @userId";
                using (var cmd = new MySqlCommand(userUpdateQuery, db.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@totalWithTaxes", totalWithTaxes);
                    cmd.Parameters.AddWithValue("@userId", currentUserId);
                    cmd.ExecuteNonQuery();
                }

                // Mostrar resumen de compra
                var summaryForm = new PurchaseSummaryForm(cartItems, totalWithTaxes, paymentMethod, db.GetUserName(currentUserId, db));
                summaryForm.ShowDialog(); // Formulario emergente

                shoppingCartUtils.GeneratePDF(cartItems, paymentMethod, currentUserId, totalWithTaxes, db);

                MessageBox.Show("Successful purchase.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cartItems.Clear(); //Clean cart
                LoadCart(); //Refresh the cart 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during purchase: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion   

        #region ListView Config
        private void configListView()
        {
            // Clear any previous configuration
            cartListView.Clear();

            // Configurar las columnas
            cartListView.View = View.Details; //Details mode
            cartListView.FullRowSelect = true; //Allows selection of the entire row
            cartListView.GridLines = true; //Lines for clarity

            //Add columns with automatic widths
            cartListView.Columns.Add("Product Name", 150, HorizontalAlignment.Left);
            cartListView.Columns.Add("Price", 80, HorizontalAlignment.Right);
            cartListView.Columns.Add("Quantity", 80, HorizontalAlignment.Center);
            cartListView.Columns.Add("Subtotal", 100, HorizontalAlignment.Right);
        }

        private void ActualizarTotal()
        {
            decimal total = cartItems.Sum(item => item.Price * item.Quantity); //Calculate total
            decimal totalWithTaxes = ((total * 6) / 100)+total;
            //Show total as a separate row
            ListViewItem totalItem = new ListViewItem("Total with taxes");
            totalItem.SubItems.Add(""); // Empty column
            totalItem.SubItems.Add(""); // Empty column
            totalItem.SubItems.Add($"${totalWithTaxes:F2}"); // Show the total in the last column
            totalItem.BackColor = Color.LightGray; // Highlight the row of the total
            totalItem.Font = new System.Drawing.Font(cartListView.Font, FontStyle.Bold);//Bold 


            //Add total row
            cartListView.Items.Add(totalItem);
        }
        private void LoadCart()
        {
            cartListView.Items.Clear();

            foreach (var item in cartItems)
            {
                ListViewItem listItem = new ListViewItem(item.Name);
                listItem.SubItems.Add($"${item.Price}");
                listItem.SubItems.Add(item.Quantity.ToString());
                cartListView.Items.Add(listItem);
            }

            ActualizarTotal();

        }

        #endregion

        #region Button Delete
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string productName = txtProductDelete.Text.Trim();

            if (string.IsNullOrWhiteSpace(productName))
            {
                MessageBox.Show("Please enter the name of the product to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var itemToRemove = cartItems.FirstOrDefault(item => item.Name.Equals(productName, StringComparison.OrdinalIgnoreCase));

            if (itemToRemove != null)
            {
                DialogResult result = MessageBox.Show($"Are you sure you want to remove '{productName}' from your cart?",
                                                      "Confirm Removal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    cartItems.Remove(itemToRemove); // Remove the item from the cart
                    MessageBox.Show($"'{productName}' has been removed from your cart.", "Item Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCart(); // Refresh the cart display
                }
            }
            else
            {
                MessageBox.Show($"The product '{productName}' was not found in your cart.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region Useless for now
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
        #endregion
    }
}
