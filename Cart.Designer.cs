namespace WinFormsProyectoFinal
{
    partial class Cart
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
            cartListView = new ListView();
            button2 = new Button();
            txtProductDelete = new TextBox();
            btnDelete = new Button();
            lblCheckGame = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(25, 30, 41);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(1, 195, 141);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(407, 613);
            button1.Name = "button1";
            button1.Size = new Size(232, 63);
            button1.TabIndex = 0;
            button1.Text = "Efectivo";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // cartListView
            // 
            cartListView.Location = new Point(223, 113);
            cartListView.Name = "cartListView";
            cartListView.Size = new Size(1125, 385);
            cartListView.TabIndex = 1;
            cartListView.UseCompatibleStateImageBehavior = false;
            cartListView.View = View.Details;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(25, 30, 41);
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(1, 195, 141);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(874, 613);
            button2.Name = "button2";
            button2.Size = new Size(232, 63);
            button2.TabIndex = 2;
            button2.Text = "Credit/Debit Card";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // txtProductDelete
            // 
            txtProductDelete.Location = new Point(815, 804);
            txtProductDelete.Name = "txtProductDelete";
            txtProductDelete.PlaceholderText = "Name of the product to be eliminated";
            txtProductDelete.Size = new Size(365, 27);
            txtProductDelete.TabIndex = 3;
            txtProductDelete.TextAlign = HorizontalAlignment.Center;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(25, 30, 41);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatAppearance.MouseOverBackColor = Color.FromArgb(1, 195, 141);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 12F);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(407, 783);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(232, 63);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Eliminate any product";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblCheckGame
            // 
            lblCheckGame.AutoSize = true;
            lblCheckGame.BorderStyle = BorderStyle.FixedSingle;
            lblCheckGame.Font = new Font("Times New Roman", 30F);
            lblCheckGame.ForeColor = Color.Black;
            lblCheckGame.Location = new Point(720, 45);
            lblCheckGame.Margin = new Padding(5, 0, 5, 0);
            lblCheckGame.Name = "lblCheckGame";
            lblCheckGame.Size = new Size(114, 59);
            lblCheckGame.TabIndex = 71;
            lblCheckGame.Text = "Cart";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(223, 505);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(187, 29);
            label1.TabIndex = 72;
            label1.Text = "Payment Method";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(223, 717);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(235, 29);
            label2.TabIndex = 73;
            label2.Text = "Eliminate any product";
            // 
            // Cart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1639, 973);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblCheckGame);
            Controls.Add(btnDelete);
            Controls.Add(txtProductDelete);
            Controls.Add(button2);
            Controls.Add(cartListView);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Cart";
            Text = "Cart";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ListView cartListView;
        private Button button2;
        private TextBox txtProductDelete;
        private Button btnDelete;
        private Label lblCheckGame;
        private Label label1;
        private Label label2;
    }
}