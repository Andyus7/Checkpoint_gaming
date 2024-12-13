namespace WinFormsProyectoFinal
{
    partial class Unsubscribe
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
            panel2 = new Panel();
            lblStocks = new Label();
            lblPrice = new Label();
            lblDescription = new Label();
            pictureBoxProduct = new PictureBox();
            lblName = new Label();
            txtBoxIdToSearch = new TextBox();
            btnSearch = new Button();
            btnDelete = new Button();
            lblCheckGame = new Label();
            label1 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProduct).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.AllowDrop = true;
            panel2.BackColor = Color.FromArgb(19, 45, 70);
            panel2.Controls.Add(lblStocks);
            panel2.Controls.Add(lblPrice);
            panel2.Controls.Add(lblDescription);
            panel2.Controls.Add(pictureBoxProduct);
            panel2.Controls.Add(lblName);
            panel2.Location = new Point(933, 196);
            panel2.Name = "panel2";
            panel2.Size = new Size(354, 519);
            panel2.TabIndex = 63;
            // 
            // lblStocks
            // 
            lblStocks.BackColor = Color.FromArgb(19, 45, 70);
            lblStocks.BorderStyle = BorderStyle.FixedSingle;
            lblStocks.Dock = DockStyle.Top;
            lblStocks.Font = new Font("Century Gothic", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblStocks.ForeColor = Color.White;
            lblStocks.Location = new Point(0, 485);
            lblStocks.Margin = new Padding(0);
            lblStocks.Name = "lblStocks";
            lblStocks.Size = new Size(354, 35);
            lblStocks.TabIndex = 59;
            lblStocks.Text = "1";
            lblStocks.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPrice
            // 
            lblPrice.BackColor = Color.FromArgb(19, 45, 70);
            lblPrice.BorderStyle = BorderStyle.FixedSingle;
            lblPrice.Dock = DockStyle.Top;
            lblPrice.Font = new Font("Century Gothic", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPrice.ForeColor = Color.White;
            lblPrice.Location = new Point(0, 450);
            lblPrice.Margin = new Padding(0);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(354, 35);
            lblPrice.TabIndex = 58;
            lblPrice.Text = "$";
            lblPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDescription
            // 
            lblDescription.BackColor = Color.FromArgb(19, 45, 70);
            lblDescription.BorderStyle = BorderStyle.FixedSingle;
            lblDescription.Dock = DockStyle.Top;
            lblDescription.FlatStyle = FlatStyle.Flat;
            lblDescription.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescription.ForeColor = Color.White;
            lblDescription.Location = new Point(0, 350);
            lblDescription.Margin = new Padding(0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(354, 100);
            lblDescription.TabIndex = 57;
            lblDescription.Text = "Label";
            lblDescription.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBoxProduct
            // 
            pictureBoxProduct.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxProduct.Cursor = Cursors.Hand;
            pictureBoxProduct.Dock = DockStyle.Top;
            pictureBoxProduct.Location = new Point(0, 50);
            pictureBoxProduct.Margin = new Padding(0);
            pictureBoxProduct.Name = "pictureBoxProduct";
            pictureBoxProduct.Size = new Size(354, 300);
            pictureBoxProduct.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxProduct.TabIndex = 41;
            pictureBoxProduct.TabStop = false;
            // 
            // lblName
            // 
            lblName.BackColor = Color.FromArgb(19, 45, 70);
            lblName.BorderStyle = BorderStyle.FixedSingle;
            lblName.Dock = DockStyle.Top;
            lblName.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(0, 0);
            lblName.Margin = new Padding(0);
            lblName.Name = "lblName";
            lblName.Size = new Size(354, 50);
            lblName.TabIndex = 39;
            lblName.Text = "Name";
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtBoxIdToSearch
            // 
            txtBoxIdToSearch.Location = new Point(460, 246);
            txtBoxIdToSearch.Name = "txtBoxIdToSearch";
            txtBoxIdToSearch.PlaceholderText = "Id to search";
            txtBoxIdToSearch.Size = new Size(297, 27);
            txtBoxIdToSearch.TabIndex = 64;
            txtBoxIdToSearch.TextAlign = HorizontalAlignment.Center;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(19, 45, 70);
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatAppearance.MouseOverBackColor = Color.FromArgb(1, 195, 141);
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(537, 341);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(143, 59);
            btnSearch.TabIndex = 65;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += button1_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(19, 45, 70);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatAppearance.MouseOverBackColor = Color.FromArgb(1, 195, 141);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(788, 779);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(177, 65);
            btnDelete.TabIndex = 66;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Visible = false;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // lblCheckGame
            // 
            lblCheckGame.AutoSize = true;
            lblCheckGame.BorderStyle = BorderStyle.FixedSingle;
            lblCheckGame.Font = new Font("Times New Roman", 30F);
            lblCheckGame.ForeColor = Color.Black;
            lblCheckGame.Location = new Point(665, 25);
            lblCheckGame.Margin = new Padding(5, 0, 5, 0);
            lblCheckGame.Name = "lblCheckGame";
            lblCheckGame.Size = new Size(271, 59);
            lblCheckGame.TabIndex = 73;
            lblCheckGame.Text = "Unsubscribe";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(992, 138);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(224, 34);
            label1.TabIndex = 74;
            label1.Text = "Data to be loaded";
            // 
            // Unsubscribe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1634, 986);
            Controls.Add(label1);
            Controls.Add(lblCheckGame);
            Controls.Add(btnDelete);
            Controls.Add(btnSearch);
            Controls.Add(txtBoxIdToSearch);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Unsubscribe";
            Text = "Unsubscribe";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label lblPrice;
        private Label lblDescription;
        private PictureBox pictureBoxProduct;
        private Label lblName;
        private TextBox txtBoxIdToSearch;
        private Button btnSearch;
        private Label lblStocks;
        private Button btnDelete;
        private Label lblCheckGame;
        private Label label1;
    }
}