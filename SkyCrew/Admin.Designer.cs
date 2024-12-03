using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MaterialSkin.Controls;

namespace SkyCrew
{
    partial class Admin
    {
        private System.ComponentModel.IContainer components = null;

        // Dispose method remains the same
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.pnlDataAnalytics = new System.Windows.Forms.Panel();
            this.lblDataAnalytics = new MaterialSkin.Controls.MaterialLabel();
            this.btnGenerateReport = new MaterialSkin.Controls.MaterialButton();
            this.comboBoxReportType = new MaterialSkin.Controls.MaterialComboBox();
            this.pnlTrends = new System.Windows.Forms.Panel();
            this.chartReport = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblTrends = new MaterialSkin.Controls.MaterialLabel();
            this.dataGridViewReport = new System.Windows.Forms.DataGridView();
            this.lblWelcome = new MaterialSkin.Controls.MaterialLabel();
            this.pnlDataAnalytics.SuspendLayout();
            this.pnlTrends.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDataAnalytics
            // 
            this.pnlDataAnalytics.BackColor = System.Drawing.Color.White;
            this.pnlDataAnalytics.Controls.Add(this.lblDataAnalytics);
            this.pnlDataAnalytics.Controls.Add(this.btnGenerateReport);
            this.pnlDataAnalytics.Controls.Add(this.comboBoxReportType);
            this.pnlDataAnalytics.Location = new System.Drawing.Point(20, 100);
            this.pnlDataAnalytics.Name = "pnlDataAnalytics";
            this.pnlDataAnalytics.Size = new System.Drawing.Size(810, 150);
            this.pnlDataAnalytics.TabIndex = 2;
            this.pnlDataAnalytics.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDataAnalytics_Paint);
            // 
            // lblDataAnalytics
            // 
            this.lblDataAnalytics.AutoSize = true;
            this.lblDataAnalytics.Depth = 0;
            this.lblDataAnalytics.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblDataAnalytics.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.lblDataAnalytics.Location = new System.Drawing.Point(10, 10);
            this.lblDataAnalytics.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDataAnalytics.Name = "lblDataAnalytics";
            this.lblDataAnalytics.Size = new System.Drawing.Size(187, 29);
            this.lblDataAnalytics.TabIndex = 0;
            this.lblDataAnalytics.Text = "Generate Reports";
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGenerateReport.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGenerateReport.Depth = 0;
            this.btnGenerateReport.HighEmphasis = true;
            this.btnGenerateReport.Icon = null;
            this.btnGenerateReport.Location = new System.Drawing.Point(10, 100);
            this.btnGenerateReport.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGenerateReport.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGenerateReport.Size = new System.Drawing.Size(154, 36);
            this.btnGenerateReport.TabIndex = 1;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGenerateReport.UseAccentColor = false;
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // comboBoxReportType
            // 
            this.comboBoxReportType.AutoResize = false;
            this.comboBoxReportType.BackColor = System.Drawing.Color.White;
            this.comboBoxReportType.Depth = 0;
            this.comboBoxReportType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxReportType.DropDownHeight = 174;
            this.comboBoxReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxReportType.DropDownWidth = 121;
            this.comboBoxReportType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboBoxReportType.ForeColor = System.Drawing.Color.Black;
            this.comboBoxReportType.FormattingEnabled = true;
            this.comboBoxReportType.Hint = "Select Report Type";
            this.comboBoxReportType.IntegralHeight = false;
            this.comboBoxReportType.ItemHeight = 43;
            this.comboBoxReportType.Items.AddRange(new object[] {
            "Flight Report",
            "Staff Report",
            "Bookings Report"});
            this.comboBoxReportType.Location = new System.Drawing.Point(10, 50);
            this.comboBoxReportType.MaxDropDownItems = 4;
            this.comboBoxReportType.MouseState = MaterialSkin.MouseState.OUT;
            this.comboBoxReportType.Name = "comboBoxReportType";
            this.comboBoxReportType.Size = new System.Drawing.Size(250, 49);
            this.comboBoxReportType.StartIndex = -1;
            this.comboBoxReportType.TabIndex = 10;
            // 
            // pnlTrends
            // 
            this.pnlTrends.BackColor = System.Drawing.Color.White;
            this.pnlTrends.Controls.Add(this.chartReport);
            this.pnlTrends.Controls.Add(this.lblTrends);
            this.pnlTrends.Location = new System.Drawing.Point(20, 260);
            this.pnlTrends.Name = "pnlTrends";
            this.pnlTrends.Size = new System.Drawing.Size(810, 300);
            this.pnlTrends.TabIndex = 3;
            // 
            // chartReport
            // 
            chartArea1.Name = "ChartArea1";
            this.chartReport.ChartAreas.Add(chartArea1);
            this.chartReport.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chartReport.Location = new System.Drawing.Point(0, 50);
            this.chartReport.Name = "chartReport";
            this.chartReport.Size = new System.Drawing.Size(810, 250);
            this.chartReport.TabIndex = 2;
            this.chartReport.Text = "chartReport";
            // 
            // lblTrends
            // 
            this.lblTrends.AutoSize = true;
            this.lblTrends.Depth = 0;
            this.lblTrends.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblTrends.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.lblTrends.Location = new System.Drawing.Point(10, 10);
            this.lblTrends.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTrends.Name = "lblTrends";
            this.lblTrends.Size = new System.Drawing.Size(161, 29);
            this.lblTrends.TabIndex = 1;
            this.lblTrends.Text = "Data Visualizer";
            // 
            // dataGridViewReport
            // 
            this.dataGridViewReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewReport.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewReport.ColumnHeadersHeight = 34;
            this.dataGridViewReport.Location = new System.Drawing.Point(20, 570);
            this.dataGridViewReport.Name = "dataGridViewReport";
            this.dataGridViewReport.ReadOnly = true;
            this.dataGridViewReport.RowHeadersWidth = 62;
            this.dataGridViewReport.Size = new System.Drawing.Size(810, 200);
            this.dataGridViewReport.TabIndex = 9;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Depth = 0;
            this.lblWelcome.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblWelcome.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblWelcome.Location = new System.Drawing.Point(20, 70);
            this.lblWelcome.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(193, 24);
            this.lblWelcome.TabIndex = 13;
            this.lblWelcome.Text = "Welcome back, Emily!";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(850, 800);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.dataGridViewReport);
            this.Controls.Add(this.pnlDataAnalytics);
            this.Controls.Add(this.pnlTrends);
            this.Name = "Admin";
            this.Text = "Admin Dashboard";
            this.pnlDataAnalytics.ResumeLayout(false);
            this.pnlDataAnalytics.PerformLayout();
            this.pnlTrends.ResumeLayout(false);
            this.pnlTrends.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDataAnalytics;
        private MaterialLabel lblDataAnalytics;
        private MaterialButton btnGenerateReport;
        private MaterialComboBox comboBoxReportType;
        private System.Windows.Forms.Panel pnlTrends;
        private MaterialLabel lblTrends;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartReport;
        private System.Windows.Forms.DataGridView dataGridViewReport;
        private MaterialLabel lblWelcome;
    }
}
