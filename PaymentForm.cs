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
        #region Variables locales privadas

        private AdmonBD db = new AdmonBD();

        private int currentUserId;

        private string Usuario;

        private Producto producto;

        #endregion

        #region Constructor
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

        #region Tarjeta de credito
        private void button1_Click(object sender, EventArgs e)
        {
            using (creditCard creditCardForm = new creditCard())
            {
                creditCardForm.ShowDialog(); // Abrir el formulario de tarjeta de crédito
            }

            // Validar que se completó el pago (puedes agregar lógica específica aquí)
            ProcessPaymentForSingleProduct("Tarjeta de Crédito o Debito");
            this.Close(); // Cerrar el formulario
        }
        #endregion

        #region boton efectivo
        private void button2_Click(object sender, EventArgs e)
        {
            ProcessPaymentForSingleProduct("Efectivo");
            this.Close(); // Cerrar el formulario
        }
        #endregion

        #region Pagar
        private void ProcessPaymentForSingleProduct(string paymentMethod)
        {
            currentUserId = db.ObtenerId(Usuario);
            decimal total = producto.Precio;
            int totalEntero = Convert.ToInt32(total);

            try
            {
                // Actualizar las existencias del producto en la base de datos
                string updateQuery = "UPDATE consolesplay SET Existencias = Existencias - 1 WHERE nombre = @nombre";
                using (var cmd = new MySqlCommand(updateQuery, db.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@nombre", producto.Nombre);
                    cmd.ExecuteNonQuery();
                }

                // Actualizar el monto del usuario en la base de datos
                string userUpdateQuery = "UPDATE usuarios SET Monto = Monto + @total WHERE id = @userId";
                using (var cmd = new MySqlCommand(userUpdateQuery, db.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@total", total);
                    cmd.Parameters.AddWithValue("@userId", currentUserId);
                    cmd.ExecuteNonQuery();
                }

                // Generar el PDF llamando al método existente
                shoppingCartUtils.GeneratePDF(new List<CartItem>
        {
            new CartItem
            {
                Name = producto.Nombre,
                Price = producto.Precio,
                Quantity = 1,
                Image = producto.Imagen
            }
        }, paymentMethod, currentUserId, totalEntero, db);

                // Mostrar mensaje de éxito
                MessageBox.Show("Successful purchase.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close(); // Cerrar el formulario actual
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during the purchase process: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Mandar llamar PDF
        private void GenerarPDFCompra(string metodoPago)
        {
            // Reutilizar lógica del carrito para generar PDF
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

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Inutil por ahora
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
