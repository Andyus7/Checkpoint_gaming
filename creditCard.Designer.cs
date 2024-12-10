namespace WinFormsProyectoFinal
{
    partial class creditCard
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
            btnPay = new Button();
            txtCardholder = new TextBox();
            txtCardNumber = new TextBox();
            txtExpirationDate = new TextBox();
            txtCVV = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnPay
            // 
            btnPay.BackColor = Color.FromArgb(25, 69, 112);
            btnPay.FlatAppearance.BorderSize = 0;
            btnPay.FlatAppearance.MouseOverBackColor = Color.FromArgb(1, 195, 141);
            btnPay.FlatStyle = FlatStyle.Flat;
            btnPay.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPay.ForeColor = Color.White;
            btnPay.Location = new Point(274, 370);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(209, 39);
            btnPay.TabIndex = 0;
            btnPay.Text = "Proceed to payment";
            btnPay.UseVisualStyleBackColor = false;
            btnPay.Click += button1_Click;
            // 
            // txtCardholder
            // 
            txtCardholder.Location = new Point(187, 119);
            txtCardholder.Name = "txtCardholder";
            txtCardholder.Size = new Size(365, 27);
            txtCardholder.TabIndex = 2;
            // 
            // txtCardNumber
            // 
            txtCardNumber.Location = new Point(187, 216);
            txtCardNumber.Name = "txtCardNumber";
            txtCardNumber.Size = new Size(365, 27);
            txtCardNumber.TabIndex = 3;
            // 
            // txtExpirationDate
            // 
            txtExpirationDate.Location = new Point(187, 310);
            txtExpirationDate.Name = "txtExpirationDate";
            txtExpirationDate.Size = new Size(164, 27);
            txtExpirationDate.TabIndex = 4;
            // 
            // txtCVV
            // 
            txtCVV.Location = new Point(409, 310);
            txtCVV.Name = "txtCVV";
            txtCVV.Size = new Size(143, 27);
            txtCVV.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(9, 20);
            label1.Name = "label1";
            label1.Size = new Size(379, 36);
            label1.TabIndex = 6;
            label1.Text = "Credit or Debit Payment";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(187, 78);
            label2.Name = "label2";
            label2.Size = new Size(156, 28);
            label2.TabIndex = 7;
            label2.Text = "Holder's name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(187, 167);
            label3.Name = "label3";
            label3.Size = new Size(144, 28);
            label3.TabIndex = 8;
            label3.Text = "Card number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(187, 269);
            label4.Name = "label4";
            label4.Size = new Size(164, 28);
            label4.TabIndex = 9;
            label4.Text = "Expiration date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(409, 269);
            label5.Name = "label5";
            label5.Size = new Size(54, 28);
            label5.TabIndex = 10;
            label5.Text = "CVV";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Tarjetas_Photoroom;
            pictureBox1.Location = new Point(419, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(257, 44);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // creditCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(688, 450);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCVV);
            Controls.Add(txtExpirationDate);
            Controls.Add(txtCardNumber);
            Controls.Add(txtCardholder);
            Controls.Add(btnPay);
            FormBorderStyle = FormBorderStyle.None;
            Name = "creditCard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "creditCard";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPay;
        private TextBox txtCardholder;
        private TextBox txtCardNumber;
        private TextBox txtExpirationDate;
        private TextBox txtCVV;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox1;
    }
}