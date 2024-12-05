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

        private AdmonBD db;

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
            ActualizarTotal();
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

        #endregion

        #region Button Buy
        private void button1_Click(object sender, EventArgs e)
        {
            decimal total = cartItems.Sum(item => item.Price * item.Quantity);

            try
            {
                foreach (var item in cartItems)
                {
                    string updateQuery = "UPDATE consolesplay SET existencias = existencias - @cantidad WHERE nombre = @nombre";
                    using (var cmd = new MySqlCommand(updateQuery, db.GetConnection()))
                    {
                        cmd.Parameters.AddWithValue("@cantidad", item.Quantity);
                        cmd.Parameters.AddWithValue("@nombre", item.Name);
                        cmd.ExecuteNonQuery();
                    }
                }

                string userUpdateQuery = "UPDATE usuarios SET monto = monto + @total WHERE id = @userId";
                using (var cmd = new MySqlCommand(userUpdateQuery, db.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@total", total);
                    cmd.Parameters.AddWithValue("@userId", currentUserId);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Compra realizada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cartItems.Clear(); // Limpiar el carrito
                this.Close(); // Cerrar el formulario del carrito
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error durante la compra: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
