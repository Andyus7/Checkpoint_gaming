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

namespace WinFormsProyectoFinal
{
    public partial class SalesConsultation : Form
    {
        public SalesConsultation()
        {
            InitializeComponent();
            LoadSalesData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadSalesData()
        {
            dataGridViewSales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Ajusta todas las columnas al contenido
            dataGridViewSales.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewSales.ReadOnly = true; // Solo lectura
            AdmonBD db = new AdmonBD();
            try
            {
                // Consulta para obtener los datos de los usuarios
                string query = "SELECT id, nombre, contraseña, cuenta, monto, rol FROM usuarios";
                using (MySqlCommand cmd = new MySqlCommand(query, db.GetConnection()))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        // Calculamos el total del monto
                        decimal totalMonto = 0;
                        foreach (DataRow row in table.Rows)
                        {
                            totalMonto += Convert.ToDecimal(row["monto"]);
                        }

                        // Agregamos una fila extra para el total
                        DataRow totalRow = table.NewRow();
                        totalRow["nombre"] = "TOTAL";
                        totalRow["monto"] = totalMonto; // Alineado con la columna de monto
                        table.Rows.Add(totalRow);

                        // Asignamos los datos al DataGridView
                        dataGridViewSales.DataSource = table;

                        // Estilo para la fila del total (opcional)
                        int lastRowIndex = dataGridViewSales.Rows.Count - 1;
                        if (lastRowIndex >= 0)
                        {
                            dataGridViewSales.Rows[lastRowIndex].DefaultCellStyle.Font = new Font(dataGridViewSales.Font, FontStyle.Bold);
                            dataGridViewSales.Rows[lastRowIndex].DefaultCellStyle.BackColor = Color.LightGray;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading sales data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadSalesData();
        }
    }
}
