using WinFormsProyectoFinal.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinFormsProyectoFinal
{
    public partial class MenuForm : Form
    {
        #region Variables locales Privadas
        //Everything to load child forms
        private Form? acitveForm = null;

        public List<CartItem> shoppingCart { get; private set; } = new List<CartItem>();

        private AdmonBD adminBD = new AdmonBD();

        private int currentUserId;

        private string usuario;

        private string nombre;

        private string rol;

        #endregion

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
            panelAdminSubMenu.Visible = false;

        }

        private void hideSubmenu()
        {

            if (panelConsolesSubMenu.Visible == true)
                panelConsolesSubMenu.Visible = false;
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
            openChildForm(new childForm(this.shoppingCart,rol,usuario));
            hideSubmenu();
        }
        #endregion

        #region Hora
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label1.Text = DateTime.Now.ToString("hh:mm:ss");
            this.label2.Text = DateTime.Now.ToShortDateString();
        }
        #endregion

        #region ChildForm
        private void button5_Click_1(object sender, EventArgs e)
        {
            MenuForm menu = new MenuForm(usuario, nombre, rol);
            menu.Show();
            this.Close(); // Cierra el formulario actual
        }
        private void openChildForm(Form childForm)
        {
            if (acitveForm != null)
                acitveForm.Close();
            acitveForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMenu2.Controls.Add(childForm);
            panelMenu2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        #endregion

        #region Admin Options
        private void CargarDatos()
        {
            buttonName.Text = $"{nombre}";

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
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            showSubMenu(panelAdminSubMenu);
        }

        private void btnUnsubscribe_Click(object sender, EventArgs e)
        {
            openChildForm(new Unsubscribe());
            hideSubmenu();
        }

        private void btnDischarge_Click(object sender, EventArgs e)
        {
            openChildForm(new DischargeForm());
            hideSubmenu();

        }

        private void btnProductList_Click(object sender, EventArgs e)
        {
            openChildForm(new ProductList());
            hideSubmenu();
        }

        private void btnSalesConsultation_Click(object sender, EventArgs e)
        {
            openChildForm(new SalesConsultation());
            hideSubmenu();
        }
        private void btnGraphic_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region LogOut
        private void button10_Click(object sender, EventArgs e)
        {
            // Volver al formulario de login
            LogInForm loginForm = new LogInForm();
            loginForm.Show();
            this.Close(); // Cierra el formulario actual
        }
        #endregion

        #region Cart
        private void button1_Click_2(object sender, EventArgs e)
        {
            openChildForm(new Cart(shoppingCart,adminBD,currentUserId));
            hideSubmenu();
        }
        #endregion

        #region Inutil Por ahora
        private void buttonName_Click(object sender, EventArgs e)
        {

        }
        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            hideSubmenu();
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            hideSubmenu();
        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            hideSubmenu();
        }
        private void panelSideMenu_Paint(object sender, PaintEventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void btnHelp_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }
        private void labelName_Click(object sender, EventArgs e)
        {

        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelLogo_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnVideoGames_Click(object sender, EventArgs e)
        {

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
    }
}
