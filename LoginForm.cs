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
using Timer = System.Windows.Forms.Timer;

namespace WinFormsProyectoFinal
{
    public partial class LogInForm : Form
    {
        #region Private local variables

        private AdmonBD adminBD;

        #endregion

        #region Builder
        public LogInForm()
        {
            InitializeComponent();
            adminBD = new AdmonBD();
        }
        #endregion

        #region Button Login
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtBoxName.Text;
            string contraseña = txtBoxPassword.Text;

            if (adminBD.ValidarUsuario(usuario, contraseña))
            {
                string rol = adminBD.ObtenerRol(usuario);
                string nombre = adminBD.ObtenerNombre(usuario);

                // Welcome message
                MessageBox.Show($"Welcome, {nombre}", "Successful login", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Open the corresponding form according to the role
                MenuForm menu = new MenuForm(usuario, nombre, rol);
                menu.Show();
                this.Close(); //Hide login form
            }
            else
            {
                MessageBox.Show("Incorrect username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region Btn Close
        private void btnBack_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        #endregion

        #region Timer Config
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            this.label4.Text = DateTime.Now.ToString("hh:mm:ss");
            this.label5.Text = DateTime.Now.ToLongDateString();
        }

        #endregion

        #region Useless For now
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        #endregion
    }
}
