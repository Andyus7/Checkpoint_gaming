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
            components = new System.ComponentModel.Container();
            panelPrincipal = new Panel();
            btnDischarge = new Button();
            labelTitle = new Label();
            txtBoxImageName = new TextBox();
            txtBoxStocks = new TextBox();
            txtBoxPrice = new TextBox();
            txtBoxDescription = new TextBox();
            txtBoxName = new TextBox();
            txtBoxId = new TextBox();
            bindingSource1 = new BindingSource(components);
            panelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // panelPrincipal
            // 
            panelPrincipal.Controls.Add(btnDischarge);
            panelPrincipal.Controls.Add(labelTitle);
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
            // btnDischarge
            // 
            btnDischarge.BackColor = Color.FromArgb(25, 30, 41);
            btnDischarge.Cursor = Cursors.Hand;
            btnDischarge.FlatAppearance.BorderSize = 0;
            btnDischarge.FlatAppearance.MouseOverBackColor = Color.FromArgb(1, 195, 141);
            btnDischarge.FlatStyle = FlatStyle.Flat;
            btnDischarge.Font = new Font("GodOfWar", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDischarge.ForeColor = Color.White;
            btnDischarge.Location = new Point(555, 619);
            btnDischarge.Name = "btnDischarge";
            btnDischarge.Size = new Size(155, 29);
            btnDischarge.TabIndex = 8;
            btnDischarge.Text = "Discharge";
            btnDischarge.UseVisualStyleBackColor = false;
            btnDischarge.Click += btnDischarge_Click;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Location = new Point(582, 53);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(81, 20);
            labelTitle.TabIndex = 7;
            labelTitle.Text = "Discharges";
            // 
            // txtBoxImageName
            // 
            txtBoxImageName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtBoxImageName.BorderStyle = BorderStyle.FixedSingle;
            txtBoxImageName.Cursor = Cursors.IBeam;
            txtBoxImageName.Font = new Font("Arial Narrow", 12F);
            txtBoxImageName.Location = new Point(463, 539);
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
            txtBoxStocks.Location = new Point(463, 468);
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
            txtBoxPrice.Location = new Point(463, 394);
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
            txtBoxDescription.Location = new Point(463, 330);
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
            txtBoxName.Location = new Point(463, 267);
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
            txtBoxId.Location = new Point(463, 201);
            txtBoxId.Name = "txtBoxId";
            txtBoxId.PlaceholderText = "Id";
            txtBoxId.Size = new Size(322, 30);
            txtBoxId.TabIndex = 1;
            txtBoxId.TextAlign = HorizontalAlignment.Center;
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
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelPrincipal;
        private Label labelTitle;
        private TextBox txtBoxImageName;
        private TextBox txtBoxStocks;
        private TextBox txtBoxPrice;
        private TextBox txtBoxDescription;
        private TextBox txtBoxName;
        private TextBox txtBoxId;
        private Button btnDischarge;
        private BindingSource bindingSource1;
    }
}