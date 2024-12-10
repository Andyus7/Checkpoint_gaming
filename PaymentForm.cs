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
        private AdmonBD db = new AdmonBD();

        private int currentUserId;
        

        private Producto producto;

        public PaymentForm(Producto producto)
        {
            InitializeComponent();
            this.producto = producto;

            CargarDatos();
        }

        private void CargarDatos()
        {
            // Mostrar los datos del producto
            labelProducto.Text = $"Producto: {producto.Nombre}";
            labelPrecio.Text = $"Precio: ${producto.Precio:F2}";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            using (creditCard creditCardForm = new creditCard())
            {
                creditCardForm.ShowDialog(); // Abrir el formulario de tarjeta de crédito
            }

            // Validar que se completó el pago (puedes agregar lógica específica aquí)
            GenerarPDFCompra("Tarjeta de Crédito");
            MessageBox.Show("Compra realizada con éxito. Detalles guardados en el PDF.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close(); // Cerrar el formulario
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GenerarPDFCompra("Efectivo");
            MessageBox.Show("Compra realizada con éxito. Detalles guardados en el PDF.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close(); // Cerrar el formulario
        }

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
            shoppingCartUtils.GeneratePDF(new List<CartItem> {itemCompra},metodoPago,currentUserId,total,db);
        }
    }
}
