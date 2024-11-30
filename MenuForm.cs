using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinFormsProyectoFinal
{
    public partial class MenuForm : Form
    {
        private string usuario;
        private string nombre;
        private string rol;

        #region Constructor
        public MenuForm(string usuario, string nombre, string rol)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.nombre = nombre;
            this.rol = rol;
            customizeDesign();
            CargarDatos();
        }

        #endregion

        #region SubMenus
        private void customizeDesign()
        {
            panelConsolesSubMenu.Visible = false;
            panelVideoGamesSubMenu.Visible = false;
            panelAdminSubMenu.Visible = false;
        }

        private void hideSubmenu()
        {
            if (panelConsolesSubMenu.Visible == true)
                panelConsolesSubMenu.Visible = false;
            if (panelVideoGamesSubMenu.Visible == true)
                panelVideoGamesSubMenu.Visible = false;
            if (panelAdminSubMenu.Visible == true)
                panelAdminSubMenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubmenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        #endregion

        #region ConsolesPanel
        private void btnConsoles_Click(object sender, EventArgs e)
        {
            showSubMenu(panelConsolesSubMenu);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new childForm());
            hideSubmenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        #endregion

        #region VideogamesPanel
        private void btnVideoGames_Click(object sender, EventArgs e)
        {
            showSubMenu(panelVideoGamesSubMenu);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }
        #endregion

       

        #region Help_and_Logout_btn
        private void btnHelp_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }
        #endregion

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {
        }


        private void CargarDatos()
        {
            lblName.Text = $"Welcome: {nombre}";

            if (rol == "admin")
            {
                // Mostrar opciones de administrador
                btnAdmin.Visible = true;
            }
            else
            {
                btnAdmin.Visible = false;
            }
        }

        //Todo para cargar formularios hijos
        private Form? acitveForm = null;

        private void openChildForm(Form childForm)
        {
            if (acitveForm != null)
                acitveForm.Close();
            acitveForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(childForm);
            panelContenedor.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            // Volver al formulario de login
            LogInForm loginForm = new LogInForm();
            loginForm.Show();
            this.Close(); // Cierra el formulario actual
        }

        private void panelSideMenu_Paint(object sender, PaintEventArgs e)
        {

        }





        private void btnAdmin_Click(object sender, EventArgs e)
        {
            showSubMenu(panelAdminSubMenu);
        }
    }
}
