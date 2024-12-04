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
        }
        

        private void panelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDischarge_Click(object sender, EventArgs e)
        {
            AdmonBD db = new AdmonBD();
            try
            {
                if (string.IsNullOrWhiteSpace(txtBoxBD.Text) || string.IsNullOrWhiteSpace(txtBoxId.Text) ||
                    string.IsNullOrWhiteSpace(txtBoxName.Text) || string.IsNullOrWhiteSpace(txtBoxDescription.Text) ||
                    string.IsNullOrWhiteSpace(txtBoxPrice.Text) || string.IsNullOrWhiteSpace(txtBoxStocks.Text) || string.IsNullOrWhiteSpace(txtBoxImageName.Text))
                {
                    MessageBox.Show("Please fill in all fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validar datos
                if (!int.TryParse(txtBoxId.Text, out int id) || !int.TryParse(txtBoxStocks.Text, out int stocks) ||
                    !decimal.TryParse(txtBoxPrice.Text, out decimal price))
                {
                    MessageBox.Show("Please enter valid numeric values for ID, Price, and Stocks.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string name = txtBoxName.Text;
                string description = txtBoxDescription.Text;
                string imageName = txtBoxImageName.Text;
                string table = txtBoxBD.Text;

                // Validar tabla permitida
                List<string> allowedTables = new List<string> { "consolesplay" }; // Agrega más si es necesario
                if (!allowedTables.Contains(table))
                {
                    MessageBox.Show("Invalid table name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string query = $"INSERT INTO {table} (id, nombre, descripcion, precio, existencias, imagen) " +
                               "VALUES (@id, @name, @description, @price, @stocks, @imageName)";

                using (MySqlCommand cmd = new MySqlCommand(query, db.GetConnection()))
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
    }
}
