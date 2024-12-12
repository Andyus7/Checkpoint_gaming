namespace WinFormsProyectoFinal
{
    partial class PurchaseSummaryForm
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
            lblTitle = new Label();
            lblClientName = new Label();
            lblPaymentMethod = new Label();
            lblTotal = new Label();
            listProducts = new ListView();
            btnOk = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Times New Roman", 14F);
            lblTitle.Location = new Point(210, 109);
            lblTitle.Margin = new Padding(5, 0, 5, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(70, 27);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "label1";
            // 
            // lblClientName
            // 
            lblClientName.AutoSize = true;
            lblClientName.Font = new Font("Times New Roman", 14F);
            lblClientName.Location = new Point(210, 170);
            lblClientName.Margin = new Padding(5, 0, 5, 0);
            lblClientName.Name = "lblClientName";
            lblClientName.Size = new Size(70, 27);
            lblClientName.TabIndex = 1;
            lblClientName.Text = "label2";
            // 
            // lblPaymentMethod
            // 
            lblPaymentMethod.AutoSize = true;
            lblPaymentMethod.Font = new Font("Times New Roman", 14F);
            lblPaymentMethod.Location = new Point(210, 239);
            lblPaymentMethod.Margin = new Padding(5, 0, 5, 0);
            lblPaymentMethod.Name = "lblPaymentMethod";
            lblPaymentMethod.Size = new Size(70, 27);
            lblPaymentMethod.TabIndex = 2;
            lblPaymentMethod.Text = "label3";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Times New Roman", 14F);
            lblTotal.Location = new Point(210, 310);
            lblTotal.Margin = new Padding(5, 0, 5, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(70, 27);
            lblTotal.TabIndex = 3;
            lblTotal.Text = "label4";
            // 
            // listProducts
            // 
            listProducts.Location = new Point(621, 109);
            listProducts.Margin = new Padding(5, 5, 5, 5);
            listProducts.Name = "listProducts";
            listProducts.Size = new Size(367, 228);
            listProducts.TabIndex = 5;
            listProducts.UseCompatibleStateImageBehavior = false;
            // 
            // btnOk
            // 
            btnOk.FlatAppearance.BorderSize = 0;
            btnOk.FlatStyle = FlatStyle.Flat;
            btnOk.Location = new Point(468, 436);
            btnOk.Margin = new Padding(5, 5, 5, 5);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(153, 38);
            btnOk.TabIndex = 6;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // PurchaseSummaryForm
            // 
            AutoScaleDimensions = new SizeF(13F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1048, 518);
            Controls.Add(btnOk);
            Controls.Add(listProducts);
            Controls.Add(lblTotal);
            Controls.Add(lblPaymentMethod);
            Controls.Add(lblClientName);
            Controls.Add(lblTitle);
            Font = new Font("Times New Roman", 14F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 5, 5, 5);
            Name = "PurchaseSummaryForm";
            Text = "PurchaseSummaryForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblClientName;
        private Label lblPaymentMethod;
        private Label lblTotal;
        private ListView listProducts;
        private Button btnOk;
    }
}