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

namespace WinFormsProyectoFinal
{
    public partial class PaymentForm : Form
    {
        #region Private local variables

        private AdmonBD db = new AdmonBD();

        private int currentUserId;

        private string Usuario;

        private Producto producto;

        #endregion

        #region Builder
        public PaymentForm(Producto producto, string usuario)
        {
            InitializeComponent();
            this.producto = producto;
            this.Usuario = usuario;
            CargarDatos();
        }
        #endregion

        #region Cargar nombre y precio
        private void CargarDatos()
        {
            // Mostrar los datos del producto
            labelProducto.Text = $"Producto: {producto.Nombre}";
            labelPrecio.Text = $"Precio: ${producto.Precio:F2}";
        }
        #endregion

        #region Credit Card
        private void button1_Click(object sender, EventArgs e)
        {
            using (creditCard creditCardForm = new creditCard())
            {
                creditCardForm.ShowDialog(); // Open the credit card form
            }
            this.Close(); // Close the form
            ProcessPaymentForSingleProduct("Credit or Debit Card");
            
        }
        #endregion

        #region Btn Cash
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            ProcessPaymentForSingleProduct("Cash");
            
        }
        #endregion

        #region Pay
        private void ProcessPaymentForSingleProduct(string paymentMethod)
        {
            currentUserId = db.ObtenerId(Usuario);
            decimal total = producto.Precio;
            decimal taxes = (total*6)/100; // Tax calculation
            decimal totalWithTaxes = taxes + total; // Total with taxes

            try
            {
                // Update product stock in the database
                string updateQuery = "UPDATE consolesplay SET Existencias = Existencias - 1 WHERE nombre = @nombre";
                using (var cmd = new MySqlCommand(updateQuery, db.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@nombre", producto.Nombre);
                    cmd.ExecuteNonQuery();
                }

                // Update user amount in the database
                string userUpdateQuery = "UPDATE usuarios SET Monto = Monto + @totalWithTaxes WHERE id = @userId";
                using (var cmd = new MySqlCommand(userUpdateQuery, db.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@totalWithTaxes", totalWithTaxes);
                    cmd.Parameters.AddWithValue("@userId", currentUserId);
                    cmd.ExecuteNonQuery();
                }

                // Create a temporary list for the processed product
                var singleProductList = new List<CartItem>
        {
            new CartItem
            {
                Name = producto.Nombre,
                Price = producto.Precio,
                Quantity = 1,
                Image = producto.Imagen
            }
        };

                this.Close(); // Close the current form
                // Show purchase summary
                var summaryForm = new PurchaseSummaryForm(singleProductList, totalWithTaxes, paymentMethod, db.GetUserName(currentUserId, db));
                summaryForm.ShowDialog();

                // PDF Generate
                shoppingCartUtils.GeneratePDF(singleProductList, paymentMethod, currentUserId, total, db);

                // Show success message
                MessageBox.Show("Successful purchase.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during the purchase process: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Send call PDF
        private void GenerarPDFCompra(string metodoPago)
        {
            // Reuse cart logic to generate PDFs
            CartItem itemCompra = new CartItem
            {
                Name = producto.Nombre,
                Price = producto.Precio,
                Quantity = 1,
                Image = producto.Imagen

            };
            int total = (int)producto.Precio;
            shoppingCartUtils.GeneratePDF(new List<CartItem> { itemCompra }, metodoPago, currentUserId, total, db);
        }
        #endregion

        #region Btn Back
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Useless for now
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        #endregion
    }
}
