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
    public partial class coverPage : Form
    {
        #region Variables privadas locales

        #endregion

        #region Constructor
        public coverPage()
        {
            InitializeComponent();
        }
        #endregion

        #region Btn Exit
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Btn System
        private void btnSystem_Click(object sender, EventArgs e)
        {
            LogInForm logInForm = new LogInForm();
            logInForm.ShowDialog();
            this.Hide();
        }
        #endregion

        #region Inutil por ahora
        private void label2_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
