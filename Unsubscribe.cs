using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsProyectoFinal
{
    public partial class Unsubscribe : Form
    {
        public Unsubscribe()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdmonBD db = new AdmonBD();

            try
            {
                if (string.IsNullOrWhiteSpace(txtBoxIdToSearch.Text))
                {
                    MessageBox.Show("Please enter a valid product ID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int id = int.Parse(txtBoxIdToSearch.Text);

                // Consulta para obtener los datos del producto
                string query = "SELECT * FROM consolesplay WHERE id = @id";

                using (MySqlCommand cmd = new MySqlCommand(query, db.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Cargar datos en los labels y picture box
                            lblName.Text = "Name: " + reader["nombre"].ToString();
                            lblDescription.Text = "Description: " + reader["descripcion"].ToString();
                            lblPrice.Text = "Price: $" + reader["precio"].ToString();
                            lblStocks.Text = "Stocks: " + reader["existencias"].ToString();

                            string imageName = reader["imagen"].ToString();
                            pictureBoxProduct.Image = System.Drawing.Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", imageName));

                            // Mostrar botón de eliminar
                            btnDelete.Visible = true;
                        }
                        else
                        {
                            MessageBox.Show("No product found with the given ID.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while fetching the product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento del botón Eliminar
        
        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            AdmonBD db = new AdmonBD();

            try
            {
                DialogResult result = MessageBox.Show("Do you want to delete all units of this product?\n" +
                                                      "Click 'Yes' to delete all, 'No' to reduce specific quantity.",
                                                      "Delete Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (result == DialogResult.Cancel)
                {
                    return; // Cancelar operación
                }

                int id = int.Parse(txtBoxIdToSearch.Text);

                if (result == DialogResult.Yes)
                {
                    // Eliminar completamente el producto
                    string queryDelete = "DELETE FROM consolesplay WHERE id = @id";

                    using (MySqlCommand cmd = new MySqlCommand(queryDelete, db.GetConnection()))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Product deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (result == DialogResult.No)
                {
                    // Preguntar por la cantidad a reducir
                    string input = Microsoft.VisualBasic.Interaction.InputBox("Enter the quantity to remove:", "Reduce Stocks", "0");

                    if (int.TryParse(input, out int reduceQuantity))
                    {
                        string queryUpdate = "UPDATE consolesplay SET Existencias = Existencias - @reduceQuantity WHERE id = @id AND existencias >= @reduceQuantity";

                        using (MySqlCommand cmd = new MySqlCommand(queryUpdate, db.GetConnection()))
                        {
                            cmd.Parameters.AddWithValue("@id", id);
                            cmd.Parameters.AddWithValue("@reduceQuantity", reduceQuantity);

                            int affectedRows = cmd.ExecuteNonQuery();

                            if (affectedRows > 0)
                            {
                                MessageBox.Show("Stocks reduced successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                // Actualizar label de existencias
                                int currentStocks = int.Parse(lblStocks.Text.Split(':')[1].Trim());
                                lblStocks.Text = "Stocks: " + (currentStocks - reduceQuantity).ToString();
                            }
                            else
                            {
                                MessageBox.Show("Cannot reduce stocks below zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid quantity entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while deleting/reducing stocks: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
