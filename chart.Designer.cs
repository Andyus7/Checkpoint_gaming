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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            chart_Admin = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)chart_Admin).BeginInit();
            SuspendLayout();
            // 
            // chart_Admin
            // 
            chartArea2.Name = "ChartArea1";
            chart_Admin.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chart_Admin.Legends.Add(legend2);
            chart_Admin.Location = new Point(228, 217);
            chart_Admin.Name = "chart_Admin";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chart_Admin.Series.Add(series2);
            chart_Admin.Size = new Size(375, 375);
            chart_Admin.TabIndex = 0;
            chart_Admin.Text = "chart1";
            // 
            // chart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1639, 973);
            Controls.Add(chart_Admin);
            FormBorderStyle = FormBorderStyle.None;
            Name = "chart";
            Text = "chart";
            ((System.ComponentModel.ISupportInitialize)chart_Admin).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Admin;
    }
}