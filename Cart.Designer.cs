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
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(98, 217);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cartListView
            // 
            cartListView.Location = new Point(269, 81);
            cartListView.Name = "cartListView";
            cartListView.Size = new Size(483, 322);
            cartListView.TabIndex = 1;
            cartListView.UseCompatibleStateImageBehavior = false;
            cartListView.View = View.Details;
            // 
            // Cart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}