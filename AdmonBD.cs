using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WinFormsProyectoFinal
{
    public class AdmonBD
    {
        private MySqlConnection connection;

        public MySqlConnection? GetConnection()
        {
            return connection;
        }

        public MySqlConnection GetConnection(MySqlConnection? connection)
        {
            if (connection == null || connection.State == System.Data.ConnectionState.Closed)
            {
                Connect();
            }
            return connection;
        }

        public AdmonBD()
        {
            this.Connect();
        }

        public void Disconnect()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public bool ValidarUsuario(string idUsuario, string password)
        {
            try
            {
                string query = "SELECT COUNT(*) FROM usuarios WHERE id = @idUsuario AND contraseña = @password";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                cmd.Parameters.AddWithValue("@password", password);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al validar las credenciales: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public string ObtenerRol(string idUsuario)
        {
            try
            {
                string query = "SELECT rol FROM usuarios WHERE id = @idUsuario";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@idUsuario", idUsuario);

                object result = cmd.ExecuteScalar();
                return result?.ToString() ?? "usuario"; // Devuelve "usuario" si no se encuentra.
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener el rol: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "usuario";
            }
        }

        public string ObtenerNombre(string idUsuario)
        {
            try
            {
                string query = "SELECT nombre FROM usuarios WHERE id = @idUsuario";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@idUsuario", idUsuario);

                object result = cmd.ExecuteScalar();
                return result?.ToString() ?? "Desconocido";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener el nombre: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "Desconocido";
            }
        }

        public void Connect()
        {
            string cadena = "Server=localhost; Database=proyecto; User=root; Password=; SslMode=none;";
            try
            {
                connection = new MySqlConnection(cadena);
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al conectar con la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
