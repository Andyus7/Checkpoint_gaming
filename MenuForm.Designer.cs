namespace WinFormsProyectoFinal
{
    partial class MenuForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelSideMenu = new Panel();
            panelAdminSubMenu = new Panel();
            btnUnsubscribe = new Button();
            btnDischarge = new Button();
            btnSalesConsultation = new Button();
            btnProductList = new Button();
            btnGraphic = new Button();
            btnAdmin = new Button();
            button10 = new Button();
            panelVideoGamesSubMenu = new Panel();
            btnXboxGames = new Button();
            btnPlayStationGames = new Button();
            btnVideoGames = new Button();
            panelConsolesSubMenu = new Panel();
            btnXboxs = new Button();
            btnPlayStation = new Button();
            btnConsoles = new Button();
            panelLogo = new Panel();
            lblName = new Label();
            labelTitle = new Label();
            button3 = new Button();
            panelContenedor = new Panel();
            panelSideMenu.SuspendLayout();
            panelAdminSubMenu.SuspendLayout();
            panelVideoGamesSubMenu.SuspendLayout();
            panelConsolesSubMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            SuspendLayout();
            // 
            // panelSideMenu
            // 
            panelSideMenu.AutoScroll = true;
            panelSideMenu.BackColor = Color.FromArgb(25, 30, 41);
            panelSideMenu.Controls.Add(panelAdminSubMenu);
            panelSideMenu.Controls.Add(btnAdmin);
            panelSideMenu.Controls.Add(button10);
            panelSideMenu.Controls.Add(panelVideoGamesSubMenu);
            panelSideMenu.Controls.Add(btnVideoGames);
            panelSideMenu.Controls.Add(panelConsolesSubMenu);
            panelSideMenu.Controls.Add(btnConsoles);
            panelSideMenu.Controls.Add(panelLogo);
            panelSideMenu.Dock = DockStyle.Left;
            panelSideMenu.Location = new Point(0, 0);
            panelSideMenu.Name = "panelSideMenu";
            panelSideMenu.Size = new Size(250, 1033);
            panelSideMenu.TabIndex = 0;
            panelSideMenu.Paint += panelSideMenu_Paint;
            // 
            // panelAdminSubMenu
            // 
            panelAdminSubMenu.BackColor = Color.FromArgb(19, 45, 70);
            panelAdminSubMenu.Controls.Add(btnUnsubscribe);
            panelAdminSubMenu.Controls.Add(btnDischarge);
            panelAdminSubMenu.Controls.Add(btnSalesConsultation);
            panelAdminSubMenu.Controls.Add(btnProductList);
            panelAdminSubMenu.Controls.Add(btnGraphic);
            panelAdminSubMenu.Dock = DockStyle.Top;
            panelAdminSubMenu.Location = new Point(0, 397);
            panelAdminSubMenu.Name = "panelAdminSubMenu";
            panelAdminSubMenu.Size = new Size(250, 230);
            panelAdminSubMenu.TabIndex = 16;
            // 
            // btnUnsubscribe
            // 
            btnUnsubscribe.Dock = DockStyle.Bottom;
            btnUnsubscribe.FlatAppearance.BorderSize = 0;
            btnUnsubscribe.FlatAppearance.MouseOverBackColor = Color.FromArgb(1, 195, 141);
            btnUnsubscribe.FlatStyle = FlatStyle.Flat;
            btnUnsubscribe.ForeColor = Color.White;
            btnUnsubscribe.Location = new Point(0, 5);
            btnUnsubscribe.Name = "btnUnsubscribe";
            btnUnsubscribe.Padding = new Padding(35, 0, 0, 0);
            btnUnsubscribe.Size = new Size(250, 45);
            btnUnsubscribe.TabIndex = 20;
            btnUnsubscribe.Text = "Unsubscribe";
            btnUnsubscribe.TextAlign = ContentAlignment.MiddleLeft;
            btnUnsubscribe.UseVisualStyleBackColor = true;
            // 
            // btnDischarge
            // 
            btnDischarge.Dock = DockStyle.Bottom;
            btnDischarge.FlatAppearance.BorderSize = 0;
            btnDischarge.FlatAppearance.MouseOverBackColor = Color.FromArgb(1, 195, 141);
            btnDischarge.FlatStyle = FlatStyle.Flat;
            btnDischarge.ForeColor = Color.White;
            btnDischarge.Location = new Point(0, 50);
            btnDischarge.Name = "btnDischarge";
            btnDischarge.Padding = new Padding(35, 0, 0, 0);
            btnDischarge.Size = new Size(250, 45);
            btnDischarge.TabIndex = 19;
            btnDischarge.Text = "Discharge";
            btnDischarge.TextAlign = ContentAlignment.MiddleLeft;
            btnDischarge.UseVisualStyleBackColor = true;
            // 
            // btnSalesConsultation
            // 
            btnSalesConsultation.Dock = DockStyle.Bottom;
            btnSalesConsultation.FlatAppearance.BorderSize = 0;
            btnSalesConsultation.FlatAppearance.MouseOverBackColor = Color.FromArgb(1, 195, 141);
            btnSalesConsultation.FlatStyle = FlatStyle.Flat;
            btnSalesConsultation.ForeColor = Color.White;
            btnSalesConsultation.Location = new Point(0, 95);
            btnSalesConsultation.Name = "btnSalesConsultation";
            btnSalesConsultation.Padding = new Padding(35, 0, 0, 0);
            btnSalesConsultation.Size = new Size(250, 45);
            btnSalesConsultation.TabIndex = 18;
            btnSalesConsultation.Text = "Sales Consultation";
            btnSalesConsultation.TextAlign = ContentAlignment.MiddleLeft;
            btnSalesConsultation.UseVisualStyleBackColor = true;
            // 
            // btnProductList
            // 
            btnProductList.Dock = DockStyle.Bottom;
            btnProductList.FlatAppearance.BorderSize = 0;
            btnProductList.FlatAppearance.MouseOverBackColor = Color.FromArgb(1, 195, 141);
            btnProductList.FlatStyle = FlatStyle.Flat;
            btnProductList.ForeColor = Color.White;
            btnProductList.Location = new Point(0, 140);
            btnProductList.Name = "btnProductList";
            btnProductList.Padding = new Padding(35, 0, 0, 0);
            btnProductList.Size = new Size(250, 45);
            btnProductList.TabIndex = 17;
            btnProductList.Text = "Product List";
            btnProductList.TextAlign = ContentAlignment.MiddleLeft;
            btnProductList.UseVisualStyleBackColor = true;
            // 
            // btnGraphic
            // 
            btnGraphic.Dock = DockStyle.Bottom;
            btnGraphic.FlatAppearance.BorderSize = 0;
            btnGraphic.FlatAppearance.MouseOverBackColor = Color.FromArgb(1, 195, 141);
            btnGraphic.FlatStyle = FlatStyle.Flat;
            btnGraphic.ForeColor = Color.White;
            btnGraphic.Location = new Point(0, 185);
            btnGraphic.Name = "btnGraphic";
            btnGraphic.Padding = new Padding(35, 0, 0, 0);
            btnGraphic.Size = new Size(250, 45);
            btnGraphic.TabIndex = 16;
            btnGraphic.Text = "Graphic";
            btnGraphic.TextAlign = ContentAlignment.MiddleLeft;
            btnGraphic.UseVisualStyleBackColor = true;
            // 
            // btnAdmin
            // 
            btnAdmin.Dock = DockStyle.Top;
            btnAdmin.FlatAppearance.BorderSize = 0;
            btnAdmin.FlatAppearance.MouseOverBackColor = Color.FromArgb(1, 195, 141);
            btnAdmin.FlatStyle = FlatStyle.Flat;
            btnAdmin.ForeColor = Color.White;
            btnAdmin.Location = new Point(0, 352);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Padding = new Padding(10, 0, 0, 0);
            btnAdmin.Size = new Size(250, 45);
            btnAdmin.TabIndex = 11;
            btnAdmin.Text = "Admin Options";
            btnAdmin.TextAlign = ContentAlignment.MiddleLeft;
            btnAdmin.UseVisualStyleBackColor = true;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // button10
            // 
            button10.Dock = DockStyle.Bottom;
            button10.FlatAppearance.BorderSize = 0;
            button10.FlatStyle = FlatStyle.Flat;
            button10.ForeColor = Color.White;
            button10.Location = new Point(0, 988);
            button10.Name = "button10";
            button10.Padding = new Padding(10, 0, 0, 0);
            button10.Size = new Size(250, 45);
            button10.TabIndex = 10;
            button10.Text = "Log Out";
            button10.TextAlign = ContentAlignment.MiddleLeft;
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // panelVideoGamesSubMenu
            // 
            panelVideoGamesSubMenu.BackColor = Color.FromArgb(19, 45, 70);
            panelVideoGamesSubMenu.Controls.Add(btnXboxGames);
            panelVideoGamesSubMenu.Controls.Add(btnPlayStationGames);
            panelVideoGamesSubMenu.Dock = DockStyle.Top;
            panelVideoGamesSubMenu.Location = new Point(0, 267);
            panelVideoGamesSubMenu.Name = "panelVideoGamesSubMenu";
            panelVideoGamesSubMenu.Size = new Size(250, 85);
            panelVideoGamesSubMenu.TabIndex = 4;
            // 
            // btnXboxGames
            // 
            btnXboxGames.Dock = DockStyle.Top;
            btnXboxGames.FlatAppearance.BorderSize = 0;
            btnXboxGames.FlatAppearance.MouseOverBackColor = Color.FromArgb(1, 195, 141);
            btnXboxGames.FlatStyle = FlatStyle.Flat;
            btnXboxGames.ForeColor = Color.White;
            btnXboxGames.Location = new Point(0, 40);
            btnXboxGames.Name = "btnXboxGames";
            btnXboxGames.Padding = new Padding(35, 0, 0, 0);
            btnXboxGames.Size = new Size(250, 40);
            btnXboxGames.TabIndex = 2;
            btnXboxGames.Text = "Xbox";
            btnXboxGames.TextAlign = ContentAlignment.MiddleLeft;
            btnXboxGames.UseVisualStyleBackColor = true;
            btnXboxGames.Click += button5_Click;
            // 
            // btnPlayStationGames
            // 
            btnPlayStationGames.Dock = DockStyle.Top;
            btnPlayStationGames.FlatAppearance.BorderSize = 0;
            btnPlayStationGames.FlatAppearance.MouseOverBackColor = Color.FromArgb(1, 195, 141);
            btnPlayStationGames.FlatStyle = FlatStyle.Flat;
            btnPlayStationGames.ForeColor = Color.White;
            btnPlayStationGames.Location = new Point(0, 0);
            btnPlayStationGames.Name = "btnPlayStationGames";
            btnPlayStationGames.Padding = new Padding(35, 0, 0, 0);
            btnPlayStationGames.Size = new Size(250, 40);
            btnPlayStationGames.TabIndex = 1;
            btnPlayStationGames.Text = "PlayStation";
            btnPlayStationGames.TextAlign = ContentAlignment.MiddleLeft;
            btnPlayStationGames.UseVisualStyleBackColor = true;
            btnPlayStationGames.Click += button6_Click;
            // 
            // btnVideoGames
            // 
            btnVideoGames.Dock = DockStyle.Top;
            btnVideoGames.FlatAppearance.BorderSize = 0;
            btnVideoGames.FlatAppearance.MouseOverBackColor = Color.FromArgb(1, 195, 141);
            btnVideoGames.FlatStyle = FlatStyle.Flat;
            btnVideoGames.ForeColor = Color.White;
            btnVideoGames.Location = new Point(0, 222);
            btnVideoGames.Name = "btnVideoGames";
            btnVideoGames.Padding = new Padding(10, 0, 0, 0);
            btnVideoGames.Size = new Size(250, 45);
            btnVideoGames.TabIndex = 3;
            btnVideoGames.Text = "VideoGames";
            btnVideoGames.TextAlign = ContentAlignment.MiddleLeft;
            btnVideoGames.UseVisualStyleBackColor = true;
            btnVideoGames.Click += btnVideoGames_Click;
            // 
            // panelConsolesSubMenu
            // 
            panelConsolesSubMenu.BackColor = Color.FromArgb(19, 45, 70);
            panelConsolesSubMenu.Controls.Add(btnXboxs);
            panelConsolesSubMenu.Controls.Add(btnPlayStation);
            panelConsolesSubMenu.Dock = DockStyle.Top;
            panelConsolesSubMenu.Location = new Point(0, 137);
            panelConsolesSubMenu.Name = "panelConsolesSubMenu";
            panelConsolesSubMenu.Size = new Size(250, 85);
            panelConsolesSubMenu.TabIndex = 2;
            // 
            // btnXboxs
            // 
            btnXboxs.Dock = DockStyle.Top;
            btnXboxs.FlatAppearance.BorderSize = 0;
            btnXboxs.FlatAppearance.MouseOverBackColor = Color.FromArgb(1, 195, 141);
            btnXboxs.FlatStyle = FlatStyle.Flat;
            btnXboxs.ForeColor = Color.White;
            btnXboxs.Location = new Point(0, 40);
            btnXboxs.Name = "btnXboxs";
            btnXboxs.Padding = new Padding(35, 0, 0, 0);
            btnXboxs.Size = new Size(250, 40);
            btnXboxs.TabIndex = 3;
            btnXboxs.Text = "Xbox";
            btnXboxs.TextAlign = ContentAlignment.MiddleLeft;
            btnXboxs.UseVisualStyleBackColor = true;
            // 
            // btnPlayStation
            // 
            btnPlayStation.Dock = DockStyle.Top;
            btnPlayStation.FlatAppearance.BorderSize = 0;
            btnPlayStation.FlatAppearance.MouseOverBackColor = Color.FromArgb(1, 195, 141);
            btnPlayStation.FlatStyle = FlatStyle.Flat;
            btnPlayStation.ForeColor = Color.White;
            btnPlayStation.Location = new Point(0, 0);
            btnPlayStation.Name = "btnPlayStation";
            btnPlayStation.Padding = new Padding(35, 0, 0, 0);
            btnPlayStation.Size = new Size(250, 40);
            btnPlayStation.TabIndex = 1;
            btnPlayStation.Text = "PlayStation";
            btnPlayStation.TextAlign = ContentAlignment.MiddleLeft;
            btnPlayStation.UseVisualStyleBackColor = true;
            btnPlayStation.Click += button2_Click;
            // 
            // btnConsoles
            // 
            btnConsoles.Dock = DockStyle.Top;
            btnConsoles.FlatAppearance.BorderSize = 0;
            btnConsoles.FlatAppearance.MouseOverBackColor = Color.FromArgb(1, 195, 141);
            btnConsoles.FlatStyle = FlatStyle.Flat;
            btnConsoles.ForeColor = Color.White;
            btnConsoles.Location = new Point(0, 92);
            btnConsoles.Name = "btnConsoles";
            btnConsoles.Padding = new Padding(10, 0, 0, 0);
            btnConsoles.Size = new Size(250, 45);
            btnConsoles.TabIndex = 1;
            btnConsoles.Text = "Consoles";
            btnConsoles.TextAlign = ContentAlignment.MiddleLeft;
            btnConsoles.UseVisualStyleBackColor = true;
            btnConsoles.Click += btnConsoles_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.Transparent;
            panelLogo.BackgroundImageLayout = ImageLayout.Stretch;
            panelLogo.Controls.Add(lblName);
            panelLogo.Controls.Add(labelTitle);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(250, 92);
            panelLogo.TabIndex = 0;
            // 
            // lblName
            // 
            lblName.Dock = DockStyle.Top;
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(0, 50);
            lblName.Name = "lblName";
            lblName.Padding = new Padding(10, 0, 0, 0);
            lblName.Size = new Size(250, 30);
            lblName.TabIndex = 0;
            lblName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelTitle
            // 
            labelTitle.Dock = DockStyle.Top;
            labelTitle.FlatStyle = FlatStyle.Flat;
            labelTitle.Font = new Font("GodOfWar", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(0, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(250, 50);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "Checkpoint Gaming";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            button3.Location = new Point(0, 0);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 0;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.FromArgb(19, 45, 70);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(250, 0);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1652, 1033);
            panelContenedor.TabIndex = 1;
            panelContenedor.Paint += panelContenedor_Paint;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(panelContenedor);
            Controls.Add(panelSideMenu);
            Name = "MenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panelSideMenu.ResumeLayout(false);
            panelAdminSubMenu.ResumeLayout(false);
            panelVideoGamesSubMenu.ResumeLayout(false);
            panelConsolesSubMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSideMenu;
        private Panel panelLogo;
        private Panel panelConsolesSubMenu;
        private Button button3;
        private Button btnPlayStation;
        private Button btnConsoles;
        private Panel panelVideoGamesSubMenu;
        private Button btnXboxGames;
        private Button btnPlayStationGames;
        private Button btnVideoGames;
        private Panel panelContenedor;
        private Button button10;
        private Label lblName;
        private Label labelTitle;
        private Panel panelAdminSubMenu;
        private Button btnDischarge;
        private Button btnSalesConsultation;
        private Button btnProductList;
        private Button btnGraphic;
        private Button btnAdmin;
        private Button btnUnsubscribe;
        private Button btnXboxs;
    }
}
