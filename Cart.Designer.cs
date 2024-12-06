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
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(25, 30, 41);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(1, 195, 141);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(82, 127);
            button1.Name = "button1";
            button1.Size = new Size(232, 63);
            button1.TabIndex = 0;
            button1.Text = "Efectivo";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // cartListView
            // 
            cartListView.Location = new Point(416, 33);
            cartListView.Name = "cartListView";
            cartListView.Size = new Size(921, 355);
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
            button2.ForeColor = Color.White;
            button2.Location = new Point(82, 276);
            button2.Name = "button2";
            button2.Size = new Size(232, 63);
            button2.TabIndex = 2;
            button2.Text = "Credit/Debit Card";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Cart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1639, 973);
            Controls.Add(button2);
            Controls.Add(cartListView);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Cart";
            Text = "Cart";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private ListView cartListView;
        private Button button2;
    }
}