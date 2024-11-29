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
    public partial class LogInForm : Form
    {
        private AdmonBD adminBD;
        public LogInForm()
        {
            InitializeComponent();
            adminBD = new AdmonBD();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtBoxName.Text;
            string contraseña = txtBoxPassword.Text;

            if (adminBD.ValidarUsuario(usuario, contraseña))
            {
                string rol = adminBD.ObtenerRol(usuario);
                string nombre = adminBD.ObtenerNombre(usuario);

                // Mensaje de bienvenida
                MessageBox.Show($"Bienvenido, {nombre}", "Inicio de Sesión Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Abrir el formulario correspondiente según el rol
                MenuForm menuForm = new MenuForm(usuario, nombre, rol);
                menuForm.Show();
                this.Hide(); // Oculta el formulario de login
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
