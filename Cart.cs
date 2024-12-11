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

namespace WinFormsProyectoFinal
{
    public partial class Cart : Form
    {
        #region Variables locales privadas

        private List<CartItem> cartItems;

        private AdmonBD db = new AdmonBD();

        private int currentUserId;

        #endregion

        #region Constructor
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
            ProcessPayment("Efectivo");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            var creditCardForm = new creditCard();
            creditCardForm.PaymentCompleted += method => ProcessPayment(method);
            creditCardForm.ShowDialog(); // Show as pop-up window
        }
        private void ProcessPayment(string paymentMethod)
        {
            decimal total = cartItems.Sum(item => item.Price * item.Quantity);
            int totalEntero = Convert.ToInt32(total);

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

                string userUpdateQuery = "UPDATE usuarios SET Monto = Monto + @total WHERE id = @userId";
                using (var cmd = new MySqlCommand(userUpdateQuery, db.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@total", total);
                    cmd.Parameters.AddWithValue("@userId", currentUserId);
                    cmd.ExecuteNonQuery();
                }

                shoppingCartUtils.GeneratePDF(cartItems, paymentMethod, currentUserId, totalEntero, db);

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
            // Limpiar cualquier configuración previa
            cartListView.Clear();

            // Configurar las columnas
            cartListView.View = View.Details; // Modo de detalles
            cartListView.FullRowSelect = true; // Permite seleccionar toda la fila
            cartListView.GridLines = true; // Líneas para mayor claridad

            // Agregar columnas con anchos automáticos
            cartListView.Columns.Add("Product Name", 150, HorizontalAlignment.Left);
            cartListView.Columns.Add("Price", 80, HorizontalAlignment.Right);
            cartListView.Columns.Add("Quantity", 80, HorizontalAlignment.Center);
            cartListView.Columns.Add("Subtotal", 100, HorizontalAlignment.Right);
        }

        private void ActualizarTotal()
        {
            decimal total = cartItems.Sum(item => item.Price * item.Quantity); // Calcular el total

            // Mostrar el total como una fila separada
            ListViewItem totalItem = new ListViewItem("Total");
            totalItem.SubItems.Add(""); // Columna vacía
            totalItem.SubItems.Add(""); // Columna vacía
            totalItem.SubItems.Add($"${total:F2}"); // Mostrar el total en la última columna
            totalItem.BackColor = Color.LightGray; // Resaltar la fila del total
            totalItem.Font = new System.Drawing.Font(cartListView.Font, FontStyle.Bold);//Bold 


            // Agregar la fila del total
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

        #region Inutil por ahora
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

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
    }
}
