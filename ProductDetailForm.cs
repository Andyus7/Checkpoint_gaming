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
    public partial class ProductDetailForm : Form
    {
        #region Private local variables

        private Producto producto;

        private List<CartItem> shoppingCart;

        private string Usuario;

        private AdmonBD db = new AdmonBD();

        #endregion

        #region Constructor
        public ProductDetailForm(Producto producto, List<CartItem> shoppingCart,string usuario)
        {
            InitializeComponent();
            this.producto = producto;
            this.shoppingCart = shoppingCart;
            this.Usuario = usuario;
            CargarDatos();
        }
        #endregion

        #region Load Data
        private void CargarDatos()
        {
            try
            {
                // Check if the file exists before uploading it
                string rutaImagen = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", producto.Imagen);
                if (!string.IsNullOrEmpty(rutaImagen) && File.Exists(rutaImagen))
                {
                    pictureBoxProcuct.Image = Image.FromFile(rutaImagen);
                    pictureBoxProcuct.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    // Load a default image if the image is not found
                    pictureBoxProcuct.Image = Properties.Resources.ImageNotFound; // Make sure you have an image in resources
                    pictureBoxProcuct.SizeMode = PictureBoxSizeMode.StretchImage;
                }

                labelName.Text = producto.Nombre ?? "Name not available";
                labelDescription.Text = producto.Descripcion ?? "Description not available";
                labelStocks.Text = $"Stocks: {producto.Existencias}";
                labelPrice.Text = $"Price: ${producto.Precio:F2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading product data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Pay Now
        private void button1_Click(object sender, EventArgs e)
        {
            if (producto.Existencias > 0)
            {
                using (PaymentForm paymentForm = new PaymentForm(producto,Usuario))
                {
                    this.Close(); // Close the current form
                    paymentForm.ShowDialog(); // Open the payment form

                }
                
            }
            else
            {
                MessageBox.Show("There is no stock available for purchase.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Add to cart
        private void button2_Click(object sender, EventArgs e)
        {
            if (producto.Existencias > 0)
            {
                shoppingCart.Add(new CartItem
                {
                    Name = producto.Nombre,
                    Price = producto.Precio,
                    Quantity = 1,
                    Image = producto.Imagen
                });

                producto.Existencias--;
                MessageBox.Show($"{producto.Nombre} added to cart.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("No stock available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region BtnBack
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide(); // Close the current form
        }
        #endregion
    }
}
