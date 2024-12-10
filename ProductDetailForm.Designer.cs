namespace WinFormsProyectoFinal
{
    partial class ProductDetailForm
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
            panel1 = new Panel();
            labelStocks = new Label();
            labelPrice = new Label();
            labelDescription = new Label();
            pictureBoxProcuct = new PictureBox();
            labelName = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProcuct).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AllowDrop = true;
            panel1.BackColor = Color.FromArgb(19, 45, 70);
            panel1.Controls.Add(labelStocks);
            panel1.Controls.Add(labelPrice);
            panel1.Controls.Add(labelDescription);
            panel1.Controls.Add(pictureBoxProcuct);
            panel1.Controls.Add(labelName);
            panel1.Location = new Point(279, 44);
            panel1.Name = "panel1";
            panel1.Size = new Size(242, 366);
            panel1.TabIndex = 62;
            // 
            // labelStocks
            // 
            labelStocks.BackColor = Color.FromArgb(19, 45, 70);
            labelStocks.BorderStyle = BorderStyle.FixedSingle;
            labelStocks.Dock = DockStyle.Top;
            labelStocks.Font = new Font("Century Gothic", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelStocks.ForeColor = Color.White;
            labelStocks.Location = new Point(0, 335);
            labelStocks.Margin = new Padding(0);
            labelStocks.Name = "labelStocks";
            labelStocks.Size = new Size(242, 29);
            labelStocks.TabIndex = 59;
            labelStocks.Text = "1";
            labelStocks.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelPrice
            // 
            labelPrice.BackColor = Color.FromArgb(19, 45, 70);
            labelPrice.BorderStyle = BorderStyle.FixedSingle;
            labelPrice.Dock = DockStyle.Top;
            labelPrice.Font = new Font("Century Gothic", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelPrice.ForeColor = Color.White;
            labelPrice.Location = new Point(0, 306);
            labelPrice.Margin = new Padding(0);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(242, 29);
            labelPrice.TabIndex = 58;
            labelPrice.Text = "$";
            labelPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelDescription
            // 
            labelDescription.BackColor = Color.FromArgb(19, 45, 70);
            labelDescription.BorderStyle = BorderStyle.FixedSingle;
            labelDescription.Dock = DockStyle.Top;
            labelDescription.FlatStyle = FlatStyle.Flat;
            labelDescription.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDescription.ForeColor = Color.White;
            labelDescription.Location = new Point(0, 256);
            labelDescription.Margin = new Padding(0);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(242, 50);
            labelDescription.TabIndex = 57;
            labelDescription.Text = "Label";
            labelDescription.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBoxProcuct
            // 
            pictureBoxProcuct.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxProcuct.Cursor = Cursors.Hand;
            pictureBoxProcuct.Dock = DockStyle.Top;
            pictureBoxProcuct.Location = new Point(0, 29);
            pictureBoxProcuct.Margin = new Padding(0);
            pictureBoxProcuct.Name = "pictureBoxProcuct";
            pictureBoxProcuct.Size = new Size(242, 227);
            pictureBoxProcuct.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxProcuct.TabIndex = 41;
            pictureBoxProcuct.TabStop = false;
            // 
            // labelName
            // 
            labelName.BackColor = Color.FromArgb(19, 45, 70);
            labelName.BorderStyle = BorderStyle.FixedSingle;
            labelName.Dock = DockStyle.Top;
            labelName.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelName.ForeColor = Color.White;
            labelName.Location = new Point(0, 0);
            labelName.Margin = new Padding(0);
            labelName.Name = "labelName";
            labelName.Size = new Size(242, 29);
            labelName.TabIndex = 39;
            labelName.Text = "Name";
            labelName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Location = new Point(55, 271);
            button1.Name = "button1";
            button1.Size = new Size(132, 29);
            button1.TabIndex = 60;
            button1.Text = "Pagar Ahora";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(569, 163);
            button2.Name = "button2";
            button2.Size = new Size(162, 48);
            button2.TabIndex = 63;
            button2.Text = "Agregar al carrito";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(45, 25);
            button3.Name = "button3";
            button3.Size = new Size(104, 30);
            button3.TabIndex = 64;
            button3.Text = "back";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // ProductDetailForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Name = "ProductDetailForm";
            Text = "ProductDetailForm";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxProcuct).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label labelPrice;
        private Label labelDescription;
        private PictureBox pictureBoxProcuct;
        private Label labelName;
        private Label labelStocks;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}