namespace WinFormsProyectoFinal
{
    partial class LoginForm
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
            txtBoxId = new TextBox();
            txtBoxPassword = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // txtBoxId
            // 
            txtBoxId.Location = new Point(329, 95);
            txtBoxId.Name = "txtBoxId";
            txtBoxId.Size = new Size(125, 27);
            txtBoxId.TabIndex = 0;
            // 
            // txtBoxPassword
            // 
            txtBoxPassword.Location = new Point(329, 154);
            txtBoxPassword.Name = "txtBoxPassword";
            txtBoxPassword.Size = new Size(125, 27);
            txtBoxPassword.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(329, 217);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogin);
            Controls.Add(txtBoxPassword);
            Controls.Add(txtBoxId);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxId;
        private TextBox txtBoxPassword;
        private Button btnLogin;
    }
}