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
            Product = new ColumnHeader();
            Price = new ColumnHeader();
            Quantity = new ColumnHeader();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(143, 112);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cartListView
            // 
            cartListView.Columns.AddRange(new ColumnHeader[] { Product, Price, Quantity });
            cartListView.Location = new Point(382, 81);
            cartListView.Name = "cartListView";
            cartListView.Size = new Size(334, 166);
            cartListView.TabIndex = 1;
            cartListView.UseCompatibleStateImageBehavior = false;
            cartListView.View = View.Details;
            // 
            // Product
            // 
            Product.Text = "Product";
            // 
            // Price
            // 
            Price.Text = "Price";
            Price.TextAlign = HorizontalAlignment.Center;
            // 
            // Quantity
            // 
            Quantity.Text = "Quantity";
            // 
            // Cart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cartListView);
            Controls.Add(button1);
            Name = "Cart";
            Text = "Cart";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private ListView cartListView;
        private ColumnHeader Product;
        private ColumnHeader Price;
        private ColumnHeader Quantity;
    }
}