namespace WinFormsProyectoFinal
{
    partial class LogInForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            txtBoxName = new TextBox();
            txtBoxPassword = new TextBox();
            btnLogin = new Button();
            panelPrincipal = new Panel();
            panel1 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            panel2 = new Panel();
            label3 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panelPrincipal.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // txtBoxName
            // 
            txtBoxName.BorderStyle = BorderStyle.FixedSingle;
            txtBoxName.Cursor = Cursors.IBeam;
            txtBoxName.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxName.Location = new Point(833, 50);
            txtBoxName.MaxLength = 30;
            txtBoxName.Name = "txtBoxName";
            txtBoxName.PlaceholderText = "ID";
            txtBoxName.RightToLeft = RightToLeft.No;
            txtBoxName.Size = new Size(241, 32);
            txtBoxName.TabIndex = 0;
            txtBoxName.TextAlign = HorizontalAlignment.Center;
            // 
            // txtBoxPassword
            // 
            txtBoxPassword.BorderStyle = BorderStyle.FixedSingle;
            txtBoxPassword.Cursor = Cursors.IBeam;
            txtBoxPassword.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxPassword.Location = new Point(833, 107);
            txtBoxPassword.MaxLength = 30;
            txtBoxPassword.Name = "txtBoxPassword";
            txtBoxPassword.PasswordChar = '*';
            txtBoxPassword.PlaceholderText = "Password";
            txtBoxPassword.Size = new Size(241, 32);
            txtBoxPassword.TabIndex = 1;
            txtBoxPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(19, 45, 70);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(1, 195, 141);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(884, 554);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(146, 40);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.White;
            panelPrincipal.Controls.Add(panel1);
            panelPrincipal.Controls.Add(panel3);
            panelPrincipal.Controls.Add(panel2);
            panelPrincipal.Controls.Add(label3);
            panelPrincipal.Controls.Add(btnLogin);
            panelPrincipal.Dock = DockStyle.Fill;
            panelPrincipal.Location = new Point(0, 0);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(1902, 973);
            panelPrincipal.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(25, 30, 41);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1902, 157);
            panel1.TabIndex = 5;
            panel1.Paint += panel1_Paint_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(1591, 12);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 10;
            label5.Text = "label5";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(1826, 12);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 9;
            label4.Text = "label4";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(315, 110);
            label2.Name = "label2";
            label2.Size = new Size(294, 23);
            label2.TabIndex = 8;
            label2.Text = "Where gamers find their level";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(264, 12);
            label1.Name = "label1";
            label1.Size = new Size(798, 98);
            label1.TabIndex = 7;
            label1.Text = "Checkpoint Games";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logos3;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(216, 132);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(25, 30, 41);
            panel3.Location = new Point(-8, 908);
            panel3.Name = "panel3";
            panel3.Size = new Size(1916, 65);
            panel3.TabIndex = 12;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtBoxName);
            panel2.Controls.Add(txtBoxPassword);
            panel2.Location = new Point(0, 321);
            panel2.Name = "panel2";
            panel2.Size = new Size(1902, 211);
            panel2.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(908, 271);
            label3.Name = "label3";
            label3.Size = new Size(96, 34);
            label3.TabIndex = 9;
            label3.Text = "Log In";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // LogInForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1902, 973);
            Controls.Add(panelPrincipal);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LogInForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Form";
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtBoxName;
        private TextBox txtBoxPassword;
        private Button btnLogin;
        private Panel panelPrincipal;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel2;
        private Panel panel3;
        private Label label5;
        private Label label4;
        private System.Windows.Forms.Timer timer1;
    }
}