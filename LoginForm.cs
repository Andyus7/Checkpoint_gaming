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
    public partial class LoginForm : Form
    {
        private AdmonBD adminBD;
        public LoginForm()
        {
            InitializeComponent();
            adminBD = new AdmonBD();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtBoxId.Text;
            string contraseña = txtBoxPassword.Text;

            if (adminBD.ValidarUsuario(usuario, contraseña))
            {
                MessageBox.Show("Inicio de sesión exitoso", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Abre el siguiente formulario
                MenuForm form1 = new MenuForm();
                form1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
