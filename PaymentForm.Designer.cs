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
            button3 = new Button();
            labelProducto = new Label();
            labelPrecio = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(98, 106);
            button1.Name = "button1";
            button1.Size = new Size(185, 36);
            button1.TabIndex = 0;
            button1.Text = "Credit or Debit Card";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(98, 211);
            button2.Name = "button2";
            button2.Size = new Size(185, 29);
            button2.TabIndex = 1;
            button2.Text = "Cash";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(48, 33);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 2;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = true;
            // 
            // labelProducto
            // 
            labelProducto.AutoSize = true;
            labelProducto.Location = new Point(381, 122);
            labelProducto.Name = "labelProducto";
            labelProducto.Size = new Size(50, 20);
            labelProducto.TabIndex = 3;
            labelProducto.Text = "label1";
            // 
            // labelPrecio
            // 
            labelPrecio.AutoSize = true;
            labelPrecio.Location = new Point(375, 215);
            labelPrecio.Name = "labelPrecio";
            labelPrecio.Size = new Size(50, 20);
            labelPrecio.TabIndex = 4;
            labelPrecio.Text = "label2";
            // 
            // PaymentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelPrecio);
            Controls.Add(labelProducto);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "PaymentForm";
            Text = "PaymentForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Label labelProducto;
        private Label labelPrecio;
    }
}