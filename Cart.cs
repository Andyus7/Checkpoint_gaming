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
            LoadCart();
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
            decimal total = cartItems.Sum(item => item.Price * item.Quantity); // Usar cartItems

            string query = "UPDATE usuarios SET monto = monto + @total WHERE id = @userId";
            using (var cmd = new MySqlCommand(query, db.GetConnection(db.GetConnection())))
            {
                cmd.Parameters.AddWithValue("@total", total);
                cmd.Parameters.AddWithValue("@userId", currentUserId); // Variable del usuario logueado
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Purchase completed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cartItems.Clear(); // Limpiar carrito después del pago
        }
    }
}
