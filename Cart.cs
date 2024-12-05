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
        private List<CartItem> cartItems;
        private AdmonBD db;
        private int currentUserId;

        public Cart(List<CartItem> shoppingCart, AdmonBD db, int userId)
        {
            InitializeComponent();
            this.cartItems = shoppingCart;
            this.db = db;
            this.currentUserId = userId;
            configListView();
            LoadCart();
            ActualizarTotal();
        }

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
            totalItem.Font = new Font(cartListView.Font, FontStyle.Bold); // Negrita

            // Agregar la fila del total
            cartListView.Items.Add(totalItem);
        }


        private void LoadCart()
        {
            foreach (var item in cartItems)
            {
                ListViewItem listItem = new ListViewItem(item.Name);
                listItem.SubItems.Add($"${item.Price}");
                listItem.SubItems.Add(item.Quantity.ToString());
                cartListView.Items.Add(listItem);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                decimal total = cartItems.Sum(item => item.Price * item.Quantity);

                string query = "UPDATE usuarios SET monto = monto + @total WHERE id = @userId";
                using (var cmd = new MySqlCommand(query, db.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@total", total);
                    cmd.Parameters.AddWithValue("@userId", currentUserId);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Purchase completed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cartItems.Clear(); // Limpiar carrito después del pago
                        this.Close(); // Cierra el formulario del carrito
                    }
                    else
                    {
                        MessageBox.Show("Could not update the user's amount. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while processing the purchase: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
