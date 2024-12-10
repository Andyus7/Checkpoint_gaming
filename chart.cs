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
using System.Windows.Forms.DataVisualization.Charting;

namespace WinFormsProyectoFinal
{
    public partial class chart : Form
    {
        #region Constructor

        public chart()
        {
            InitializeComponent();
            Cargar_Grafica();
        }
        #endregion

        #region Cargar Grafica
        private void Cargar_Grafica()
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=proyecto; User=root; Password=; Sslmode=none;"))
                {
                    conexion.Open();

                    string consulta = "SELECT Nombre, Monto FROM usuarios";

                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    using (MySqlDataReader lector = comando.ExecuteReader())
                    {
                        chart_Admin.Series.Clear();

                        Series serie = new Series("Montos por Usuario")
                        {
                            ChartType = SeriesChartType.Pie,
                            IsValueShownAsLabel = true // Mostrar valores en las barras
                        };

                        chart_Admin.ChartAreas[0].AxisX.Interval = 1; // Separar cada usuario en el eje X
                        chart_Admin.ChartAreas[0].AxisX.Title = "Usuarios";
                        chart_Admin.ChartAreas[0].AxisY.Title = "Monto";

                        // Agregar datos de cada usuario como un punto individual
                        while (lector.Read())
                        {
                            string nombre = lector["Nombre"].ToString(); // Nombre del usuario
                            double monto = Convert.ToDouble(lector["Monto"]); // Monto del usuario

                            // Añadir punto a la serie
                            serie.Points.AddXY(nombre, monto);
                        }

                        chart_Admin.Series.Add(serie);

                        // Configurar leyenda
                        if (chart_Admin.Legends.Count == 0)
                        {
                            chart_Admin.Legends.Add(new Legend("Leyenda"));
                        }
                        chart_Admin.Legends[0].Docking = Docking.Bottom;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la gráfica: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
