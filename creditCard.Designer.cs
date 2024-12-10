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
            button2 = new Button();
            txtCardholder = new TextBox();
            txtCardNumber = new TextBox();
            txtExpirationDate = new TextBox();
            txtCVV = new TextBox();
            SuspendLayout();
            // 
            // btnPay
            // 
            btnPay.Location = new Point(326, 348);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(94, 29);
            btnPay.TabIndex = 0;
            btnPay.Text = "button1";
            btnPay.UseVisualStyleBackColor = true;
            btnPay.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(24, 22);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtCardholder
            // 
            txtCardholder.Location = new Point(319, 51);
            txtCardholder.Name = "txtCardholder";
            txtCardholder.Size = new Size(125, 27);
            txtCardholder.TabIndex = 2;
            // 
            // txtCardNumber
            // 
            txtCardNumber.Location = new Point(316, 118);
            txtCardNumber.Name = "txtCardNumber";
            txtCardNumber.Size = new Size(125, 27);
            txtCardNumber.TabIndex = 3;
            // 
            // txtExpirationDate
            // 
            txtExpirationDate.Location = new Point(362, 204);
            txtExpirationDate.Name = "txtExpirationDate";
            txtExpirationDate.Size = new Size(125, 27);
            txtExpirationDate.TabIndex = 4;
            // 
            // txtCVV
            // 
            txtCVV.Location = new Point(400, 279);
            txtCVV.Name = "txtCVV";
            txtCVV.Size = new Size(125, 27);
            txtCVV.TabIndex = 5;
            // 
            // creditCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtCVV);
            Controls.Add(txtExpirationDate);
            Controls.Add(txtCardNumber);
            Controls.Add(txtCardholder);
            Controls.Add(button2);
            Controls.Add(btnPay);
            FormBorderStyle = FormBorderStyle.None;
            Name = "creditCard";
            Text = "creditCard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPay;
        private Button button2;
        private TextBox txtCardholder;
        private TextBox txtCardNumber;
        private TextBox txtExpirationDate;
        private TextBox txtCVV;
    }
}