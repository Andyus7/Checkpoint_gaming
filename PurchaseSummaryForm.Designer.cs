namespace WinFormsProyectoFinal
{
    partial class PurchaseSummaryForm
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
            lblTitle = new Label();
            lblClientName = new Label();
            lblPaymentMethod = new Label();
            lblTotal = new Label();
            listProducts = new ListView();
            btnOk = new Button();
            lblSlogan = new Label();
            pictureBox1 = new PictureBox();
            lblTime = new Label();
            lblDate = new Label();
            lblCheckGame = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Times New Roman", 14F);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(14, 113);
            lblTitle.Margin = new Padding(5, 0, 5, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(197, 27);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Purchase Summary";
            // 
            // lblClientName
            // 
            lblClientName.AutoSize = true;
            lblClientName.Font = new Font("Times New Roman", 14F);
            lblClientName.ForeColor = Color.White;
            lblClientName.Location = new Point(140, 164);
            lblClientName.Margin = new Padding(5, 0, 5, 0);
            lblClientName.Name = "lblClientName";
            lblClientName.Size = new Size(70, 27);
            lblClientName.TabIndex = 1;
            lblClientName.Text = "label2";
            lblClientName.Click += lblClientName_Click;
            // 
            // lblPaymentMethod
            // 
            lblPaymentMethod.AutoSize = true;
            lblPaymentMethod.Font = new Font("Times New Roman", 14F);
            lblPaymentMethod.ForeColor = Color.White;
            lblPaymentMethod.Location = new Point(140, 207);
            lblPaymentMethod.Margin = new Padding(5, 0, 5, 0);
            lblPaymentMethod.Name = "lblPaymentMethod";
            lblPaymentMethod.Size = new Size(70, 27);
            lblPaymentMethod.TabIndex = 2;
            lblPaymentMethod.Text = "label3";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Times New Roman", 14F);
            lblTotal.ForeColor = Color.White;
            lblTotal.Location = new Point(140, 246);
            lblTotal.Margin = new Padding(5, 0, 5, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(70, 27);
            lblTotal.TabIndex = 3;
            lblTotal.Text = "label4";
            // 
            // listProducts
            // 
            listProducts.Location = new Point(14, 296);
            listProducts.Margin = new Padding(5);
            listProducts.Name = "listProducts";
            listProducts.Size = new Size(666, 275);
            listProducts.TabIndex = 5;
            listProducts.UseCompatibleStateImageBehavior = false;
            // 
            // btnOk
            // 
            btnOk.BackColor = Color.FromArgb(25, 69, 112);
            btnOk.FlatAppearance.BorderSize = 0;
            btnOk.FlatAppearance.MouseOverBackColor = Color.FromArgb(1, 195, 141);
            btnOk.FlatStyle = FlatStyle.Flat;
            btnOk.ForeColor = Color.White;
            btnOk.Location = new Point(246, 600);
            btnOk.Margin = new Padding(5);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(153, 38);
            btnOk.TabIndex = 6;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = false;
            btnOk.Click += btnOk_Click;
            // 
            // lblSlogan
            // 
            lblSlogan.AutoSize = true;
            lblSlogan.Font = new Font("Times New Roman", 10F);
            lblSlogan.ForeColor = Color.White;
            lblSlogan.Location = new Point(288, 89);
            lblSlogan.Margin = new Padding(5, 0, 5, 0);
            lblSlogan.Name = "lblSlogan";
            lblSlogan.Size = new Size(237, 19);
            lblSlogan.TabIndex = 7;
            lblSlogan.Text = "Where the gamers find their level";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logos;
            pictureBox1.Location = new Point(32, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(78, 59);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Times New Roman", 8F);
            lblTime.ForeColor = Color.White;
            lblTime.Location = new Point(524, 593);
            lblTime.Margin = new Padding(5, 0, 5, 0);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(36, 16);
            lblTime.TabIndex = 9;
            lblTime.Text = "Time";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Times New Roman", 8F);
            lblDate.ForeColor = Color.White;
            lblDate.Location = new Point(524, 622);
            lblDate.Margin = new Padding(5, 0, 5, 0);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(33, 16);
            lblDate.TabIndex = 10;
            lblDate.Text = "Date";
            // 
            // lblCheckGame
            // 
            lblCheckGame.AutoSize = true;
            lblCheckGame.BorderStyle = BorderStyle.FixedSingle;
            lblCheckGame.Font = new Font("Times New Roman", 30F);
            lblCheckGame.ForeColor = Color.White;
            lblCheckGame.Location = new Point(140, 19);
            lblCheckGame.Margin = new Padding(5, 0, 5, 0);
            lblCheckGame.Name = "lblCheckGame";
            lblCheckGame.Size = new Size(385, 59);
            lblCheckGame.TabIndex = 11;
            lblCheckGame.Text = "Checkpoint Game";
            // 
            // PurchaseSummaryForm
            // 
            AutoScaleDimensions = new SizeF(13F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 30, 41);
            ClientSize = new Size(694, 685);
            Controls.Add(lblCheckGame);
            Controls.Add(lblDate);
            Controls.Add(lblTime);
            Controls.Add(pictureBox1);
            Controls.Add(lblSlogan);
            Controls.Add(btnOk);
            Controls.Add(listProducts);
            Controls.Add(lblTotal);
            Controls.Add(lblPaymentMethod);
            Controls.Add(lblClientName);
            Controls.Add(lblTitle);
            Font = new Font("Times New Roman", 14F);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "PurchaseSummaryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PurchaseSummaryForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblClientName;
        private Label lblPaymentMethod;
        private Label lblTotal;
        private ListView listProducts;
        private Button btnOk;
        private Label lblSlogan;
        private PictureBox pictureBox1;
        private Label lblTime;
        private Label lblDate;
        private Label lblCheckGame;
    }
}