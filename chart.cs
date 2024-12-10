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
        private AdmonBD db;

        public chart(AdmonBD db)
        {
            InitializeComponent();
            this.db = db;

            ConfigurarGrafico();
            CargarDatos();
        }

        private void ConfigurarGrafico()
        {
            // Crear un objeto Chart
            Chart chart = new Chart
            {
                Name = "chartProductos",
                Dock = DockStyle.None,
                Width = 800,
                Height = 400,
                Location = new System.Drawing.Point(50, 20)
            };

            // Crear el área del gráfico
            ChartArea chartArea = new ChartArea
            {
                Name = "MainChartArea",
                AxisX = { Title = "Productos", Interval = 1 },
                AxisY = { Title = "Cantidad" }
            };
            chart.ChartAreas.Add(chartArea);

            // Crear una serie para los datos
            Series series = new Series
            {
                Name = "Cantidad",
                ChartType = SeriesChartType.Column, // Barras verticales
                XValueType = ChartValueType.String,
                YValueType = ChartValueType.Int32
            };
            chart.Series.Add(series);

            // Márgenes
            chartArea.AxisX.LabelStyle.Angle = -45; // Rotar etiquetas en X si son muchas
            chartArea.AxisX.MajorGrid.Enabled = false; // Deshabilitar líneas en el fondo
            chartArea.AxisY.MajorGrid.Enabled = true; // Mostrar líneas del eje Y

            this.Controls.Add(chart);

            // Agregar un botón para refrescar debajo de la gráfica
            Button refreshButton = new Button
            {
                Text = "Refrescar Gráfica",
                Location = new System.Drawing.Point(50, 450), // Ajustar posición debajo del gráfico
                Width = 200,
                Height = 40
            };
            refreshButton.Click += (s, e) => RefrescarGrafico();
            this.Controls.Add(refreshButton);
        }

        private void CargarDatos()
        {
            try
            {
                string query = "SELECT nombre, existencias FROM consolesplay";

                using (var cmd = new MySqlCommand(query, db.GetConnection()))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        Chart chart = this.Controls.OfType<Chart>().FirstOrDefault();
                        if (chart == null)
                        {
                            throw new Exception("No se encontró ningún gráfico en el formulario.");
                        }

                        Series series = chart.Series["Cantidad"];
                        series.Points.Clear(); // Limpiar puntos anteriores

                        int maxCantidad = 0; // Para ajustar el eje Y
                        bool datosEncontrados = false; // Verificar si hay datos

                        while (reader.Read())
                        {
                            datosEncontrados = true;

                            string producto = reader.GetString("nombre");
                            int cantidad = reader.GetInt32("existencias");

                            // Agregar datos a la gráfica
                            series.Points.AddXY(producto, cantidad);

                            // Encontrar el valor máximo
                            if (cantidad > maxCantidad)
                                maxCantidad = cantidad;
                        }

                        if (!datosEncontrados)
                        {
                            MessageBox.Show("No se encontraron datos en la base de datos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                        // Ajustar el eje Y con un margen adicional del 20%
                        chart.ChartAreas["MainChartArea"].AxisY.Maximum = maxCantidad == 0 ? 10 : maxCantidad * 1.2;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefrescarGrafico()
        {
            CargarDatos();
            MessageBox.Show("Gráfica actualizada correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
