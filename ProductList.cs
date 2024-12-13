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
    public partial class ProductList : Form
    {
        #region Constructor
        public ProductList()
        {
            InitializeComponent();
            LoadProducts();
        }
        #endregion

        #region DataGridView load
        private void LoadProducts()
        {
            dataGridViewProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Adjusts all columns to the content
            dataGridViewProducts.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewProducts.ReadOnly = true; // Read only
            AdmonBD db = new AdmonBD();

            try
            {
                // Modified query to sort by stock from smallest to largest
                string query = "SELECT id, nombre, descripcion, precio, existencias, imagen FROM consolesplay ORDER BY existencias ASC";

                using (MySqlCommand cmd = new MySqlCommand(query, db.GetConnection(db.GetConnection())))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        // Assign the table to the DataGridView
                        dataGridViewProducts.DataSource = table;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Button Refresh
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }
        #endregion
    }
}
