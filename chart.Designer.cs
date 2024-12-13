namespace WinFormsProyectoFinal
{
    partial class chart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            chart_Admin = new System.Windows.Forms.DataVisualization.Charting.Chart();
            btnRefresh = new Button();
            lblCheckGame = new Label();
            ((System.ComponentModel.ISupportInitialize)chart_Admin).BeginInit();
            SuspendLayout();
            // 
            // chart_Admin
            // 
            chartArea1.Name = "ChartArea1";
            chart_Admin.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart_Admin.Legends.Add(legend1);
            chart_Admin.Location = new Point(380, 87);
            chart_Admin.Name = "chart_Admin";
            chart_Admin.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series1.BackSecondaryColor = Color.White;
            series1.BorderColor = Color.DimGray;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.LabelBackColor = Color.White;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart_Admin.Series.Add(series1);
            chart_Admin.Size = new Size(916, 592);
            chart_Admin.TabIndex = 0;
            chart_Admin.Text = "chart1";
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(25, 30, 41);
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatAppearance.MouseOverBackColor = Color.FromArgb(1, 195, 141);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 14F);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(736, 749);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(199, 54);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // lblCheckGame
            // 
            lblCheckGame.AutoSize = true;
            lblCheckGame.BorderStyle = BorderStyle.FixedSingle;
            lblCheckGame.Font = new Font("Times New Roman", 30F);
            lblCheckGame.ForeColor = Color.Black;
            lblCheckGame.Location = new Point(758, 25);
            lblCheckGame.Margin = new Padding(5, 0, 5, 0);
            lblCheckGame.Name = "lblCheckGame";
            lblCheckGame.Size = new Size(138, 59);
            lblCheckGame.TabIndex = 72;
            lblCheckGame.Text = "Chart";
            // 
            // chart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1639, 973);
            Controls.Add(lblCheckGame);
            Controls.Add(btnRefresh);
            Controls.Add(chart_Admin);
            FormBorderStyle = FormBorderStyle.None;
            Name = "chart";
            Text = "chart";
            ((System.ComponentModel.ISupportInitialize)chart_Admin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Admin;
        private Button btnRefresh;
        private Label lblCheckGame;
    }
}