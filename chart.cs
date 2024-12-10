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
       
        public chart()
        {
            InitializeComponent();
            Cargar_Grafica();
        }

        private void Cargar_Grafica()
        {
            // Indicamos nuestra conexion a la base de datos
            MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=proyecto; User=root; Password=; Sslmode=none;");
            // Nos conectamos a nuestra base de datos
            conexion.Open();

            // Linea de comando SQL (solamente seleccionamos el monto de las cuentas que son clientes)
            string consulta = "SELECT Nombre, Monto FROM usuarios WHERE Tipo = 1";
            // Cargamos nuestro comando
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            // Ejecutamos nuestro comando
            MySqlDataReader lector = comando.ExecuteReader();

            // Al iniciar la grafica, se limpian los datos
            chart_Admin.Series.Clear();
            // Creamos nuestra serie para la grafica y la llamamos "Montos por Usuario"
            Series serie = new Series("Montos por Usuario");
            // Declaramos el tipo de grafico que vamos a usar, en este caso de pastel
            serie.ChartType = SeriesChartType.Pie;

            // Mientras haya algo que leer en nuestra base de datos
            while (lector.Read())
            {
                // Extraemos el valor Nombre de nuestra base de datos, el cual usaremos como nuestra leyenda
                string nombre = lector["Nombre"].ToString();
                // Extraemos el valor Monto de nuestra base de datos, el cual convertimos a double para que sea mejor trabajar con el en el grafico
                double monto = Convert.ToDouble(lector["Monto"]);

                // Agregamos esta informacion a la grafica (creamos un nuevo punto para la grafica)
                DataPoint punto = new DataPoint(0, monto);  // Al ser una grafica de pastel, no hay categorias por lo que se manda un "0"
                punto.LegendText = nombre;  // Asignamos el nombre a la leyenda
                serie.Points.Add(punto);    // Añadimos el punto al gráfico
            }

            // Tras haber llenado nuestra serie con la informacion necesaria, la agregamos a la grafica para que esta se muestre
            chart_Admin.Series.Add(serie);

            // Mostramos la leyenda en la parte inferior
            chart_Admin.Legends[0].Docking = Docking.Bottom;

            // Quitamos los nombres (etiquetas) para que estos no se muestren sobre nuestra grafica
            foreach (var point in serie.Points)
            {
                point.IsValueShownAsLabel = false;
            }
        }



    }
}
