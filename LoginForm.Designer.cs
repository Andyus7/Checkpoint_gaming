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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            txtBoxName = new TextBox();
            txtBoxPassword = new TextBox();
            btnLogin = new Button();
            labelTitle = new Label();
            panelPrincipal = new Panel();
            panelTxtBoxs = new Panel();
            label1 = new Label();
            panelPrincipal.SuspendLayout();
            panelTxtBoxs.SuspendLayout();
            SuspendLayout();
            // 
            // txtBoxName
            // 
            txtBoxName.BorderStyle = BorderStyle.None;
            txtBoxName.Cursor = Cursors.IBeam;
            txtBoxName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxName.Location = new Point(280, 39);
            txtBoxName.MaxLength = 30;
            txtBoxName.Name = "txtBoxName";
            txtBoxName.PlaceholderText = "ID";
            txtBoxName.RightToLeft = RightToLeft.No;
            txtBoxName.Size = new Size(241, 23);
            txtBoxName.TabIndex = 0;
            txtBoxName.TextAlign = HorizontalAlignment.Center;
            // 
            // txtBoxPassword
            // 
            txtBoxPassword.BorderStyle = BorderStyle.None;
            txtBoxPassword.Cursor = Cursors.IBeam;
            txtBoxPassword.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxPassword.Location = new Point(280, 96);
            txtBoxPassword.MaxLength = 30;
            txtBoxPassword.Name = "txtBoxPassword";
            txtBoxPassword.PasswordChar = '*';
            txtBoxPassword.PlaceholderText = "Password";
            txtBoxPassword.Size = new Size(241, 23);
            txtBoxPassword.TabIndex = 1;
            txtBoxPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(25, 30, 41);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(1, 195, 141);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(329, 544);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(146, 29);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // labelTitle
            // 
            labelTitle.BackColor = Color.FromArgb(25, 30, 41);
            labelTitle.Dock = DockStyle.Top;
            labelTitle.Font = new Font("Microsoft Sans Serif", 35F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(0, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(784, 189);
            labelTitle.TabIndex = 3;
            labelTitle.Text = "Checkpoint Games";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.FromArgb(19, 45, 70);
            panelPrincipal.Controls.Add(panelTxtBoxs);
            panelPrincipal.Controls.Add(label1);
            panelPrincipal.Controls.Add(labelTitle);
            panelPrincipal.Controls.Add(btnLogin);
            panelPrincipal.Dock = DockStyle.Fill;
            panelPrincipal.Location = new Point(0, 0);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(784, 739);
            panelPrincipal.TabIndex = 4;
            // 
            // panelTxtBoxs
            // 
            panelTxtBoxs.Controls.Add(txtBoxName);
            panelTxtBoxs.Controls.Add(txtBoxPassword);
            panelTxtBoxs.Dock = DockStyle.Top;
            panelTxtBoxs.Location = new Point(0, 328);
            panelTxtBoxs.Name = "panelTxtBoxs";
            panelTxtBoxs.Size = new Size(784, 161);
            panelTxtBoxs.TabIndex = 5;
            panelTxtBoxs.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 189);
            label1.Name = "label1";
            label1.Size = new Size(784, 139);
            label1.TabIndex = 4;
            label1.Text = "Log In";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LogInForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(784, 739);
            Controls.Add(panelPrincipal);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LogInForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Log In Form";
            panelPrincipal.ResumeLayout(false);
            panelTxtBoxs.ResumeLayout(false);
            panelTxtBoxs.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtBoxName;
        private TextBox txtBoxPassword;
        private Button btnLogin;
        private Label labelTitle;
        private Panel panelPrincipal;
        private Label label1;
        private Panel panelTxtBoxs;
    }
}