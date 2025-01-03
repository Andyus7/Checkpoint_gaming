﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using WinFormsProyectoFinal.Models;

namespace WinFormsProyectoFinal
{
    public partial class DischargeForm : Form
    {
        #region Private local variables
        private AdmonBD db = new AdmonBD();
        #endregion

        #region Builder
        public DischargeForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Btn Discharge Config
        private void btnDischarge_Click(object sender, EventArgs e)
        {

            try
            {
                // Verificar si algún campo está vacío
                if (string.IsNullOrWhiteSpace(txtBoxId.Text) ||
                    string.IsNullOrWhiteSpace(txtBoxName.Text) ||
                    string.IsNullOrWhiteSpace(txtBoxDescription.Text) ||
                    string.IsNullOrWhiteSpace(txtBoxPrice.Text) ||
                    string.IsNullOrWhiteSpace(txtBoxStocks.Text) ||
                    string.IsNullOrWhiteSpace(txtBoxImageName.Text))
                {
                    MessageBox.Show("Please fill in all fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validar los datos numéricos
                if (!int.TryParse(txtBoxId.Text, out int id) ||
                    !int.TryParse(txtBoxStocks.Text, out int stocks) ||
                    !decimal.TryParse(txtBoxPrice.Text, out decimal price))
                {
                    MessageBox.Show("Please enter valid numeric values for ID, Price, and Stocks.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Capturar los demás datos
                string name = txtBoxName.Text;
                string description = txtBoxDescription.Text;
                string imageName = txtBoxImageName.Text;

                // Consulta SQL para insertar datos en la tabla 'consolesplay'
                string query = $"INSERT INTO consolesplay (id, nombre, descripcion, precio, existencias, imagen) " +
                               "VALUES (@id, @name, @description, @price, @stocks, @imageName)";

                // Ejecutar la consulta con parámetros
                using (MySqlCommand cmd = new MySqlCommand(query, db.GetConnection(db.GetConnection())))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@description", description);
                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.Parameters.AddWithValue("@stocks", stocks);
                    cmd.Parameters.AddWithValue("@imageName", imageName);

                    int affectedLines = cmd.ExecuteNonQuery();

                    if (affectedLines > 0)
                        MessageBox.Show("Product added correctly.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("The product could not be added.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error when adding the product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion

        #region Btn Search
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string id = txtboxIdProduct.Text.Trim();
            try
            {
                string query = "SELECT nombre, existencias, imagen FROM consolesplay WHERE id = @id";
                using (MySqlCommand cmd = new MySqlCommand(query, db.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lblName.Text = reader.GetString("nombre");
                            lblStocks.Text = reader.GetInt32("existencias").ToString();

                            string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", reader.GetString("imagen"));
                            if (File.Exists(imagePath))
                            {
                                pictureBoxProduct.Image = Image.FromFile(imagePath);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Product not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error when searching for the product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Btn Add
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string id = txtboxIdProduct.Text.Trim();
            int addStock = int.TryParse(txtAddStocks.Text.Trim(), out int result) ? result : 0;

            if (addStock <= 0)
            {
                MessageBox.Show("Please enter a valid number for the stock to be added.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string query = "UPDATE consolesplay SET Existencias = Existencias + @addStock WHERE id = @id";
                using (MySqlCommand cmd = new MySqlCommand(query, db.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@addStock", addStock);
                    cmd.Parameters.AddWithValue("@id", id);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Stock successfully added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Extraer solo el número del texto actual
                        string currentStockText = lblStocks.Text.Replace("Stocks: ", "").Trim();
                        int currentStock = int.TryParse(currentStockText, out int stockResult) ? stockResult : 0;

                        // Actualizar visualmente el stock
                        int updatedStock = currentStock + addStock;
                        lblStocks.Text = "Stocks: " + updatedStock;
                    }
                    else
                    {
                        MessageBox.Show("The product could not be updated. Please check the ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error when adding stock: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Useless for now
        private void panelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }
        #endregion
    }
}
