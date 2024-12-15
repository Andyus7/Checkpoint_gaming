using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WinFormsProyectoFinal.Models
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
            Connect();
        }

        public void Disconnect()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public string GetUserName(int userId, AdmonBD db)
        {
            string query = "SELECT nombre FROM usuarios WHERE id = @userId";
            using (var cmd = new MySqlCommand(query, db.GetConnection()))
            {
                cmd.Parameters.AddWithValue("@userId", userId);
                object result = cmd.ExecuteScalar();
                return result?.ToString() ?? "Desconocido";
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
                MessageBox.Show($"Error validating credentials: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show($"Error when obtaining the role: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "usuario";
            }
        }

        public int ObtenerId(string idUsuario)
        {
            try
            {
                string query = "SELECT id FROM usuarios WHERE id = @idUsuario";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@idUsuario", idUsuario);

                object result = cmd.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : -1; // Devuelve -1 si no encuentra el usuario.
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error obtaining the ID: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1; // -1 indica un error al obtener el ID.
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
                return result?.ToString() ?? "Unknown";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error getting the name: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "Unknown";
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
                MessageBox.Show($"Error connecting to the database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
