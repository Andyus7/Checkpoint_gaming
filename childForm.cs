using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;
using WinFormsProyectoFinal.Models;
using Org.BouncyCastle.Asn1.Cmp;

namespace WinFormsProyectoFinal
{
    public partial class childForm : Form
    {
        #region Variables locales privadas

        private AdmonBD adminBD = new AdmonBD();

        private List<CartItem> shoppingCart = new List<CartItem>();

        private List<Producto> productos = new List<Producto>();

        private string usuario;

        private int userId;

        private string rol;

        #endregion

        #region Constructor
        public childForm(string rol, string usuario)
        {
            InitializeComponent();
            this.rol = rol;
            this.usuario = usuario;
            this.cargar_imagenes();
            this.initializeImageSwitcher();
            this.AsignarEventosCompra();
        }
        #endregion

        #region ImageSwitcher

        private List<string> imagePaths = new List<string>();
        private int currentIndex = 0;
        private System.Windows.Forms.Timer imageSwitcherTimer;

        private void initializeImageSwitcher()
        {
            string imageFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ImagesSwitcher");

            if (Directory.Exists(imageFolder))
            {
                // Cargar todas las imágenes de la carpeta
                imagePaths.AddRange(Directory.GetFiles(imageFolder, "*.png"));
            }

            pictureBoxPrincipal.Image = Image.FromFile(imagePaths[currentIndex]);
            pictureBoxPrincipal.SizeMode = PictureBoxSizeMode.StretchImage;

            imageSwitcherTimer = new System.Windows.Forms.Timer();
            imageSwitcherTimer.Interval = 3000; // 3000 ms = 3 seconds
            imageSwitcherTimer.Tick += OnTimerTick;
            imageSwitcherTimer.Start();
        }

        private void OnTimerTick(object sender, EventArgs e)
        {
            if (imagePaths.Count == 0) return;

            //Update the index
            currentIndex = (currentIndex + 1) % imagePaths.Count;

            //Load the following image into the PictureBox
            pictureBoxPrincipal.Image = Image.FromFile(imagePaths[currentIndex]);
            pictureBoxPrincipal.SizeMode = PictureBoxSizeMode.StretchImage; //Adjust the size

        }

        #endregion

        #region Load All
        private void cargar_imagenes()
        {
            adminBD.Connect();
            List<Producto> productos = new List<Producto>();

            try
            {
                string query = "SELECT nombre, descripcion, precio, existencias, imagen FROM consolesplay";
                MySqlCommand cmd = new MySqlCommand(query, adminBD.GetConnection(adminBD.GetConnection()));
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    productos.Add(new Producto
                    {
                        Nombre = reader.GetString("nombre"),
                        Descripcion = reader.GetString("descripcion"),
                        Precio = reader.GetDecimal("precio"),
                        Existencias = reader.GetInt32("existencias"),
                        Imagen = reader.GetString("imagen")
                    });
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los productos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Mostrar los productos en los controles
            for (int i = 0; i < 10; i++)
            {
                Panel? panel = this.Controls.Find($"panel{i + 1}", true).FirstOrDefault() as Panel;
                if (i < productos.Count)
                {
                    Producto producto = productos[i];
                    string rutaImagen = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", producto.Imagen);

                    if (panel != null)
                    {
                        panel.Visible = true; // Mostrar el panel si se está usando

                        PictureBox? pictureBox = panel.Controls.Find($"pictureBox{i + 1}", true).FirstOrDefault() as PictureBox;
                        if (pictureBox != null && File.Exists(rutaImagen))
                        {
                            pictureBox.Image = Image.FromFile(rutaImagen);
                        }

                        Label? labelName = panel.Controls.Find($"labelName{i + 1}", true).FirstOrDefault() as Label;
                        if (labelName != null)
                        {
                            labelName.Text = producto.Nombre;
                        }

                        Label? labelDescription = panel.Controls.Find($"labelDescription{i + 1}", true).FirstOrDefault() as Label;
                        if (labelDescription != null)
                        {
                            labelDescription.Text = producto.Descripcion;
                        }

                        Label? labelPrice = panel.Controls.Find($"labelPrice{i + 1}", true).FirstOrDefault() as Label;
                        if (labelPrice != null)
                        {
                            labelPrice.Text = $"$ {producto.Precio:F2}";
                        }

                        Button? btnBuy = panel.Controls.Find($"btnBuy{i + 1}", true).FirstOrDefault() as Button;
                        if (btnBuy != null)
                        {
                            btnBuy.Tag = producto;
                            btnBuy.Click += BtnBuy_Click;
                            btnBuy.Visible = rol != "admin";
                        }
                    }
                }
                else
                {
                    if (panel != null) // Hide unused panels
                    {
                        panel.Visible = false;
                    }
                }
            }
        }
        #endregion

        #region Buton Buy Options
        private void BtnBuy_Click(object sender, EventArgs e)
        {
            Button? btnBuy = sender as Button;
            if (btnBuy?.Tag is Producto producto) // Recuperar el producto desde el Tag
            {
                if (producto.Existencias <= 0)
                {
                    MessageBox.Show($"No stock available for {producto.Nombre}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Agregar el producto al carrito
                shoppingCart.Add(new CartItem
                {
                    Name = producto.Nombre,
                    Price = producto.Precio,
                    Image = producto.Imagen,
                    Quantity = 1
                });

                // Actualizar existencias del producto
                producto.Existencias--;

                MessageBox.Show($"{producto.Nombre} added to the cart successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AsignarEventosCompra()
        {
            for (int i = 1; i <= 10; i++)
            {
                Button? button = this.Controls.Find($"btnBuy{i}", true).FirstOrDefault() as Button;
                if (button != null)
                {
                    button.Click -= AgregarAlCarrito; // Quitar cualquier suscripción previa
                    button.Click += AgregarAlCarrito; // Agregar el evento una sola vez
                }
            }
        }

        private void AgregarAlCarrito(object sender, EventArgs e)
        {
            Button? clickedButton = sender as Button;

            if (clickedButton == null)
                return;

            int indice = int.Parse(clickedButton.Name.Replace("btnBuy", "")) - 1;

            if (indice < 0 || indice >= productos.Count)
                return;

            Producto productoSeleccionado = productos[indice];

            if (productoSeleccionado.Existencias <= 0)
            {
                MessageBox.Show("There is no stock available for this product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            shoppingCart.Add(new CartItem
            {
                Name = productoSeleccionado.Nombre,
                Price = productoSeleccionado.Precio,
                Quantity = 1,
                Image = productoSeleccionado.Imagen
            });

            productoSeleccionado.Existencias--; // Reducir las existencias locales

            MessageBox.Show("Product successfully added to cart.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            userId = adminBD.ObtenerId(usuario);
            Cart cartForm = new Cart(shoppingCart, adminBD, userId);
            cartForm.ShowDialog();
        }
        #endregion

        #region Inutiles por ahora
        private void btnBuy1_Click(object sender, EventArgs e)
        {

        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void labelDescription1_Click(object sender, EventArgs e)
        {

        }

        private void labelDescription1_Click_1(object sender, EventArgs e)
        {

        }

        private void panelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void labelPrice1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxPrincipal_Click(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
