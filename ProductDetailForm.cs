﻿using System;
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
        #region Variables locales privadas

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

        #region Cargar Datos
        private void CargarDatos()
        {
            try
            {
                // Verificar si el archivo existe antes de cargarlo
                string rutaImagen = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", producto.Imagen);
                if (!string.IsNullOrEmpty(rutaImagen) && File.Exists(rutaImagen))
                {
                    pictureBoxProcuct.Image = Image.FromFile(rutaImagen);
                    pictureBoxProcuct.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    // Cargar una imagen predeterminada si no se encuentra la imagen
                    pictureBoxProcuct.Image = Properties.Resources.ImageNotFound; // Asegúrate de tener una imagen en los recursos
                    pictureBoxProcuct.SizeMode = PictureBoxSizeMode.StretchImage;
                }

                labelName.Text = producto.Nombre ?? "Nombre no disponible";
                labelDescription.Text = producto.Descripcion ?? "Descripción no disponible";
                labelStocks.Text = $"Existencias: {producto.Existencias}";
                labelPrice.Text = $"Precio: ${producto.Precio:F2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos del producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Pagar Ahora
        private void button1_Click(object sender, EventArgs e)
        {
            if (producto.Existencias > 0)
            {
                using (PaymentForm paymentForm = new PaymentForm(producto,Usuario))
                {
                    this.Close(); // Cerrar el formulario actual
                    paymentForm.ShowDialog(); // Abrir el formulario de pago
                    
                }
                
            }
            else
            {
                MessageBox.Show("There is no stock available for purchase.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Añadir al carrito
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
                MessageBox.Show($"{producto.Nombre} añadido al carrito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No hay existencias disponibles.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Boton Volver
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close(); // Cerrar el formulario actual
        }
        #endregion
    }
}
