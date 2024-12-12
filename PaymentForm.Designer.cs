namespace WinFormsProyectoFinal
{
    partial class PaymentForm
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
            button1 = new Button();
            button2 = new Button();
            labelProducto = new Label();
            labelPrecio = new Label();
            button4 = new Button();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(25, 69, 112);
            button1.Dock = DockStyle.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(1, 195, 141);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(104, 0);
            button1.Name = "button1";
            button1.Size = new Size(309, 70);
            button1.TabIndex = 0;
            button1.Text = "Credit or Debit Card";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(25, 69, 112);
            button2.Dock = DockStyle.Right;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(1, 195, 141);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(104, 0);
            button2.Name = "button2";
            button2.Size = new Size(309, 70);
            button2.TabIndex = 1;
            button2.Text = "Cash";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // labelProducto
            // 
            labelProducto.AutoSize = true;
            labelProducto.Location = new Point(154, 123);
            labelProducto.Name = "labelProducto";
            labelProducto.Size = new Size(50, 20);
            labelProducto.TabIndex = 3;
            labelProducto.Text = "label1";
            // 
            // labelPrecio
            // 
            labelPrecio.AutoSize = true;
            labelPrecio.Location = new Point(154, 160);
            labelPrecio.Name = "labelPrecio";
            labelPrecio.Size = new Size(50, 20);
            labelPrecio.TabIndex = 4;
            labelPrecio.Text = "label2";
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button4.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Image = Properties.Resources.FlechaC1;
            button4.Location = new Point(12, 12);
            button4.Name = "button4";
            button4.Size = new Size(84, 88);
            button4.TabIndex = 65;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(154, 9);
            label1.Name = "label1";
            label1.Size = new Size(271, 36);
            label1.TabIndex = 66;
            label1.Text = "Payment Method";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(154, 72);
            label2.Name = "label2";
            label2.Size = new Size(211, 28);
            label2.TabIndex = 68;
            label2.Text = "Purchase summary:";
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(12, 235);
            panel1.Name = "panel1";
            panel1.Size = new Size(413, 70);
            panel1.TabIndex = 69;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Dock = DockStyle.Left;
            pictureBox2.Image = Properties.Resources.CreditCard;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(106, 70);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 69;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(button2);
            panel2.Location = new Point(12, 324);
            panel2.Name = "panel2";
            panel2.Size = new Size(413, 70);
            panel2.TabIndex = 70;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = Properties.Resources.Money_F;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(106, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 68;
            pictureBox1.TabStop = false;
            // 
            // PaymentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(452, 423);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(labelPrecio);
            Controls.Add(labelProducto);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PaymentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PaymentForm";
            Load += PaymentForm_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label labelProducto;
        private Label labelPrecio;
        private Button button4;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}