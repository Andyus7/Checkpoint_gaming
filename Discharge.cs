using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WinFormsProyectoFinal
{
    public partial class DischargeForm : Form
    {
        public DischargeForm()
        {
            InitializeComponent();
            this.cargar_imagenes2();
        }

        private void cargar_imagenes2()
        {
            AdmonBD adminBD = new AdmonBD(); // Crea una instancia de AdmonBD
            adminBD.Connect(); // Establece la conexión con la base de datos
            // Lista para guardar los datos de los productos
            List<Producto> productos = new List<Producto>();

            try
            {
                // Consulta para obtener los datos de los productos
                string query = "SELECT nombre, descripcion, precio, imagen FROM productosx";
                MySqlCommand cmd = new MySqlCommand(query, adminBD.GetConnection());
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    productos.Add(new Producto
                    {
                        Nombre = reader.GetString("nombre"),
                        Descripcion = reader.GetString("descripcion"),
                        Precio = reader.GetDecimal("precio"),
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
            for (int i = 0; i < productos.Count && i < 5; i++)
            {
                Producto producto = productos[i];
                string rutaImagen = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", producto.Imagen);

                // Cargar imagen en el PictureBox correspondiente
                PictureBox? pictureBox = this.Controls.Find($"pictureBox{i + 1}", true).FirstOrDefault() as PictureBox;
                if (pictureBox != null && File.Exists(rutaImagen))
                {
                    pictureBox.Image = Image.FromFile(rutaImagen);
                }

                Label? labelName = this.Controls.Find($"labelName{i + 1}", true).FirstOrDefault() as Label;
                if (labelName != null)
                {
                    labelName.Text = producto.Nombre;
                }


                // Actualizar la descripción y el precio
                Label? labelDescription = this.Controls.Find($"labelDescription{i + 1}", true).FirstOrDefault() as Label;
                if (labelDescription != null)
                {
                    labelDescription.Text = producto.Descripcion;
                }

                Label? labelPrice = this.Controls.Find($"labelPrice{i + 1}", true).FirstOrDefault() as Label;
                if (labelPrice != null)
                {
                    labelPrice.Text = $"$ {producto.Precio:F2}";
                }
            }
        }

        private void DischargeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
