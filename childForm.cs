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
        private List<CartItem> shoppingCart;
        private List<Producto> productos = new List<Producto>();
        private string usuario;
        private string rol;

        #endregion

        #region Constructor
        public childForm(List<CartItem> shoppingCart, string rol, string usuario)
        {
            InitializeComponent(); 
            initializeImageSwitcher();
            this.rol = rol;
            this.usuario = usuario;
            this.shoppingCart = shoppingCart;
            this.CargarImagenes();
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

        #region Cargar Productos en el Panel
        private void CargarImagenes()
        {
            adminBD.Connect();
            productos.Clear();

            try
            {
                string query = "SELECT nombre, descripcion, precio, existencias, imagen FROM consolesplay";
                using (MySqlCommand cmd = new MySqlCommand(query, adminBD.GetConnection()))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
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
                }

                // Mostrar los productos en los controles
                for (int i = 0; i < 10; i++)
                {
                    Panel? panel = this.Controls.Find($"panel{i + 1}", true).FirstOrDefault() as Panel;

                    if (i < productos.Count && panel != null)
                    {
                        Producto producto = productos[i];
                        string rutaImagen = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", producto.Imagen);

                        panel.Visible = true; // Mostrar el panel

                        PictureBox? pictureBox = panel.Controls.Find($"pictureBox{i + 1}", true).FirstOrDefault() as PictureBox;
                        if (pictureBox != null && File.Exists(rutaImagen))
                        {
                            pictureBox.Image = Image.FromFile(rutaImagen);
                            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                            pictureBox.Tag = producto; // Asignar el producto al Tag
                            pictureBox.Click += AbrirDetalleProducto;
                        }

                        Label? labelName = panel.Controls.Find($"labelName{i + 1}", true).FirstOrDefault() as Label;
                        if (labelName != null)
                        {
                            labelName.Text = producto.Nombre;
                        }
                    }
                    else if (panel != null)
                    {
                        panel.Visible = false; // Ocultar paneles no utilizados
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los productos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Abrir Formulario Detalle de Producto
        private void AbrirDetalleProducto(object sender, EventArgs e)
        {
            if (sender is PictureBox pictureBox && pictureBox.Tag is Producto producto)
            {
                using (ProductDetailForm detailForm = new ProductDetailForm(producto, shoppingCart))
                {
                    detailForm.ShowDialog(); // Mostrar el formulario emergente
                }
            }
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
