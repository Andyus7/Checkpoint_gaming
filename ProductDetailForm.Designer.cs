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
            labelStocks = new Label();
            labelPrice = new Label();
            labelDescription = new Label();
            pictureBoxProcuct = new PictureBox();
            labelName = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProcuct).BeginInit();
            SuspendLayout();
            // 
            // labelStocks
            // 
            labelStocks.BackColor = Color.FromArgb(19, 45, 70);
            labelStocks.BorderStyle = BorderStyle.FixedSingle;
            labelStocks.Font = new Font("Century Gothic", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelStocks.ForeColor = Color.White;
            labelStocks.Location = new Point(100, 289);
            labelStocks.Margin = new Padding(0);
            labelStocks.Name = "labelStocks";
            labelStocks.Padding = new Padding(10, 0, 0, 0);
            labelStocks.Size = new Size(380, 35);
            labelStocks.TabIndex = 59;
            labelStocks.Text = "1";
            labelStocks.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelPrice
            // 
            labelPrice.BackColor = Color.FromArgb(19, 45, 70);
            labelPrice.BorderStyle = BorderStyle.FixedSingle;
            labelPrice.Font = new Font("Century Gothic", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelPrice.ForeColor = Color.White;
            labelPrice.Location = new Point(100, 243);
            labelPrice.Margin = new Padding(0);
            labelPrice.Name = "labelPrice";
            labelPrice.Padding = new Padding(10, 0, 0, 0);
            labelPrice.Size = new Size(380, 35);
            labelPrice.TabIndex = 58;
            labelPrice.Text = "$";
            labelPrice.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelDescription
            // 
            labelDescription.BackColor = Color.FromArgb(19, 45, 70);
            labelDescription.BorderStyle = BorderStyle.FixedSingle;
            labelDescription.FlatStyle = FlatStyle.Flat;
            labelDescription.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDescription.ForeColor = Color.White;
            labelDescription.Location = new Point(100, 56);
            labelDescription.Margin = new Padding(0);
            labelDescription.Name = "labelDescription";
            labelDescription.Padding = new Padding(10);
            labelDescription.Size = new Size(380, 177);
            labelDescription.TabIndex = 57;
            labelDescription.Text = "Label";
            // 
            // pictureBoxProcuct
            // 
            pictureBoxProcuct.BorderStyle = BorderStyle.Fixed3D;
            pictureBoxProcuct.Cursor = Cursors.Hand;
            pictureBoxProcuct.Location = new Point(497, 56);
            pictureBoxProcuct.Margin = new Padding(0);
            pictureBoxProcuct.Name = "pictureBoxProcuct";
            pictureBoxProcuct.Size = new Size(294, 385);
            pictureBoxProcuct.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxProcuct.TabIndex = 41;
            pictureBoxProcuct.TabStop = false;
            // 
            // labelName
            // 
            labelName.BackColor = Color.FromArgb(19, 45, 70);
            labelName.BorderStyle = BorderStyle.FixedSingle;
            labelName.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelName.ForeColor = Color.White;
            labelName.Location = new Point(100, 9);
            labelName.Margin = new Padding(0);
            labelName.Name = "labelName";
            labelName.Size = new Size(691, 38);
            labelName.TabIndex = 39;
            labelName.Text = "Name";
            labelName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Properties.Resources.El_texto_del_párrafo__1_;
            button1.Location = new Point(100, 375);
            button1.Name = "button1";
            button1.Size = new Size(175, 48);
            button1.TabIndex = 60;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = Properties.Resources.Add_to_cart;
            button2.Location = new Point(297, 375);
            button2.Name = "button2";
            button2.Size = new Size(175, 48);
            button2.TabIndex = 63;
            button2.Text = "\r\n";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button3.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Image = Properties.Resources.FlechaC1;
            button3.Location = new Point(0, -1);
            button3.Name = "button3";
            button3.Size = new Size(84, 88);
            button3.TabIndex = 64;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // ProductDetailForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelName);
            Controls.Add(labelDescription);
            Controls.Add(labelPrice);
            Controls.Add(labelStocks);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBoxProcuct);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProductDetailForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProductDetailForm";
            ((System.ComponentModel.ISupportInitialize)pictureBoxProcuct).EndInit();
            ResumeLayout(false);
        }

        #endregion
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