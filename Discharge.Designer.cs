namespace WinFormsProyectoFinal
{
    partial class DischargeForm
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
            panelPrincipal = new Panel();
            btnAdd = new Button();
            txtAddStocks = new TextBox();
            panel2 = new Panel();
            lblStocks = new Label();
            pictureBoxProduct = new PictureBox();
            lblName = new Label();
            btnSearch = new Button();
            txtboxIdProduct = new TextBox();
            btnDischarge = new Button();
            txtBoxImageName = new TextBox();
            txtBoxStocks = new TextBox();
            txtBoxPrice = new TextBox();
            txtBoxDescription = new TextBox();
            txtBoxName = new TextBox();
            txtBoxId = new TextBox();
            lblCheckGame = new Label();
            label1 = new Label();
            panelPrincipal.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProduct).BeginInit();
            SuspendLayout();
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.White;
            panelPrincipal.Controls.Add(label1);
            panelPrincipal.Controls.Add(lblCheckGame);
            panelPrincipal.Controls.Add(btnAdd);
            panelPrincipal.Controls.Add(txtAddStocks);
            panelPrincipal.Controls.Add(panel2);
            panelPrincipal.Controls.Add(btnSearch);
            panelPrincipal.Controls.Add(txtboxIdProduct);
            panelPrincipal.Controls.Add(btnDischarge);
            panelPrincipal.Controls.Add(txtBoxImageName);
            panelPrincipal.Controls.Add(txtBoxStocks);
            panelPrincipal.Controls.Add(txtBoxPrice);
            panelPrincipal.Controls.Add(txtBoxDescription);
            panelPrincipal.Controls.Add(txtBoxName);
            panelPrincipal.Controls.Add(txtBoxId);
            panelPrincipal.Dock = DockStyle.Fill;
            panelPrincipal.Location = new Point(0, 0);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(1652, 1033);
            panelPrincipal.TabIndex = 0;
            panelPrincipal.Paint += panelPrincipal_Paint;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(19, 45, 70);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(1, 195, 141);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 14F);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(1234, 763);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(144, 48);
            btnAdd.TabIndex = 69;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtAddStocks
            // 
            txtAddStocks.Location = new Point(882, 774);
            txtAddStocks.Name = "txtAddStocks";
            txtAddStocks.PlaceholderText = "Amounts to be recorded";
            txtAddStocks.Size = new Size(292, 27);
            txtAddStocks.TabIndex = 68;
            txtAddStocks.TextAlign = HorizontalAlignment.Center;
            // 
            // panel2
            // 
            panel2.AllowDrop = true;
            panel2.BackColor = Color.FromArgb(19, 45, 70);
            panel2.Controls.Add(lblStocks);
            panel2.Controls.Add(pictureBoxProduct);
            panel2.Controls.Add(lblName);
            panel2.Location = new Point(988, 385);
            panel2.Name = "panel2";
            panel2.Size = new Size(267, 332);
            panel2.TabIndex = 67;
            // 
            // lblStocks
            // 
            lblStocks.BackColor = Color.FromArgb(19, 45, 70);
            lblStocks.BorderStyle = BorderStyle.FixedSingle;
            lblStocks.Dock = DockStyle.Top;
            lblStocks.Font = new Font("Century Gothic", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblStocks.ForeColor = Color.White;
            lblStocks.Location = new Point(0, 290);
            lblStocks.Margin = new Padding(0);
            lblStocks.Name = "lblStocks";
            lblStocks.Size = new Size(267, 40);
            lblStocks.TabIndex = 59;
            lblStocks.Text = "Stocks";
            lblStocks.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBoxProduct
            // 
            pictureBoxProduct.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxProduct.Cursor = Cursors.Hand;
            pictureBoxProduct.Dock = DockStyle.Top;
            pictureBoxProduct.Location = new Point(0, 40);
            pictureBoxProduct.Margin = new Padding(0);
            pictureBoxProduct.Name = "pictureBoxProduct";
            pictureBoxProduct.Size = new Size(267, 250);
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
            lblName.Size = new Size(267, 40);
            lblName.TabIndex = 39;
            lblName.Text = "Name";
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(19, 45, 70);
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatAppearance.MouseOverBackColor = Color.FromArgb(1, 195, 141);
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 14F);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(1234, 288);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(144, 48);
            btnSearch.TabIndex = 66;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtboxIdProduct
            // 
            txtboxIdProduct.Location = new Point(882, 303);
            txtboxIdProduct.Name = "txtboxIdProduct";
            txtboxIdProduct.PlaceholderText = "Id to search";
            txtboxIdProduct.Size = new Size(292, 27);
            txtboxIdProduct.TabIndex = 9;
            txtboxIdProduct.TextAlign = HorizontalAlignment.Center;
            // 
            // btnDischarge
            // 
            btnDischarge.BackColor = Color.FromArgb(25, 30, 41);
            btnDischarge.Cursor = Cursors.Hand;
            btnDischarge.FlatAppearance.BorderSize = 0;
            btnDischarge.FlatAppearance.MouseOverBackColor = Color.FromArgb(1, 195, 141);
            btnDischarge.FlatStyle = FlatStyle.Flat;
            btnDischarge.Font = new Font("GodOfWar", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDischarge.ForeColor = Color.White;
            btnDischarge.Location = new Point(304, 708);
            btnDischarge.Name = "btnDischarge";
            btnDischarge.Size = new Size(198, 52);
            btnDischarge.TabIndex = 8;
            btnDischarge.Text = "Discharge";
            btnDischarge.UseVisualStyleBackColor = false;
            btnDischarge.Click += btnDischarge_Click;
            // 
            // txtBoxImageName
            // 
            txtBoxImageName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtBoxImageName.BorderStyle = BorderStyle.FixedSingle;
            txtBoxImageName.Cursor = Cursors.IBeam;
            txtBoxImageName.Font = new Font("Arial Narrow", 12F);
            txtBoxImageName.Location = new Point(239, 636);
            txtBoxImageName.Name = "txtBoxImageName";
            txtBoxImageName.PlaceholderText = "Image Name";
            txtBoxImageName.Size = new Size(322, 30);
            txtBoxImageName.TabIndex = 6;
            txtBoxImageName.TextAlign = HorizontalAlignment.Center;
            // 
            // txtBoxStocks
            // 
            txtBoxStocks.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtBoxStocks.BorderStyle = BorderStyle.FixedSingle;
            txtBoxStocks.Cursor = Cursors.IBeam;
            txtBoxStocks.Font = new Font("Arial Narrow", 12F);
            txtBoxStocks.Location = new Point(239, 560);
            txtBoxStocks.Name = "txtBoxStocks";
            txtBoxStocks.PlaceholderText = "Stocks";
            txtBoxStocks.Size = new Size(322, 30);
            txtBoxStocks.TabIndex = 5;
            txtBoxStocks.TextAlign = HorizontalAlignment.Center;
            // 
            // txtBoxPrice
            // 
            txtBoxPrice.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtBoxPrice.BorderStyle = BorderStyle.FixedSingle;
            txtBoxPrice.Cursor = Cursors.IBeam;
            txtBoxPrice.Font = new Font("Arial Narrow", 12F);
            txtBoxPrice.Location = new Point(239, 488);
            txtBoxPrice.Name = "txtBoxPrice";
            txtBoxPrice.PlaceholderText = "Price";
            txtBoxPrice.Size = new Size(322, 30);
            txtBoxPrice.TabIndex = 4;
            txtBoxPrice.TextAlign = HorizontalAlignment.Center;
            // 
            // txtBoxDescription
            // 
            txtBoxDescription.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtBoxDescription.BorderStyle = BorderStyle.FixedSingle;
            txtBoxDescription.Cursor = Cursors.IBeam;
            txtBoxDescription.Font = new Font("Arial Narrow", 12F);
            txtBoxDescription.Location = new Point(239, 410);
            txtBoxDescription.Name = "txtBoxDescription";
            txtBoxDescription.PlaceholderText = "Description";
            txtBoxDescription.Size = new Size(322, 30);
            txtBoxDescription.TabIndex = 3;
            txtBoxDescription.TextAlign = HorizontalAlignment.Center;
            // 
            // txtBoxName
            // 
            txtBoxName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtBoxName.BorderStyle = BorderStyle.FixedSingle;
            txtBoxName.Cursor = Cursors.IBeam;
            txtBoxName.Font = new Font("Arial Narrow", 12F);
            txtBoxName.Location = new Point(239, 340);
            txtBoxName.Name = "txtBoxName";
            txtBoxName.PlaceholderText = "Name";
            txtBoxName.Size = new Size(322, 30);
            txtBoxName.TabIndex = 2;
            txtBoxName.TextAlign = HorizontalAlignment.Center;
            // 
            // txtBoxId
            // 
            txtBoxId.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtBoxId.BorderStyle = BorderStyle.FixedSingle;
            txtBoxId.Cursor = Cursors.IBeam;
            txtBoxId.Font = new Font("Arial Narrow", 12F);
            txtBoxId.Location = new Point(239, 268);
            txtBoxId.Name = "txtBoxId";
            txtBoxId.PlaceholderText = "Id";
            txtBoxId.Size = new Size(322, 30);
            txtBoxId.TabIndex = 1;
            txtBoxId.TextAlign = HorizontalAlignment.Center;
            // 
            // lblCheckGame
            // 
            lblCheckGame.AutoSize = true;
            lblCheckGame.BorderStyle = BorderStyle.FixedSingle;
            lblCheckGame.Font = new Font("Times New Roman", 30F);
            lblCheckGame.ForeColor = Color.Black;
            lblCheckGame.Location = new Point(282, 159);
            lblCheckGame.Margin = new Padding(5, 0, 5, 0);
            lblCheckGame.Name = "lblCheckGame";
            lblCheckGame.Size = new Size(244, 59);
            lblCheckGame.TabIndex = 70;
            lblCheckGame.Text = "Discharges";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Times New Roman", 30F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(936, 159);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(373, 59);
            label1.TabIndex = 71;
            label1.Text = "Stock Discharges";
            // 
            // DischargeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1652, 1033);
            Controls.Add(panelPrincipal);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DischargeForm";
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxProduct).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelPrincipal;
        private TextBox txtBoxImageName;
        private TextBox txtBoxStocks;
        private TextBox txtBoxPrice;
        private TextBox txtBoxDescription;
        private TextBox txtBoxName;
        private TextBox txtBoxId;
        private Button btnDischarge;
        private TextBox txtboxIdProduct;
        private Button btnSearch;
        private Button btnAdd;
        private TextBox txtAddStocks;
        private Panel panel2;
        private Label lblStocks;
        private PictureBox pictureBoxProduct;
        private Label lblName;
        private Label lblCheckGame;
        private Label label1;
    }
}