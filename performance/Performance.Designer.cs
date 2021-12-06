namespace Utility.performance
{
    partial class FormCPUandRAM
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pRam = new System.Diagnostics.PerformanceCounter();
            this.pCPU = new System.Diagnostics.PerformanceCounter();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.ProgressBarCpu = new MetroFramework.Controls.MetroProgressBar();
            this.lbcpu = new MetroFramework.Controls.MetroLabel();
            this.lbram = new MetroFramework.Controls.MetroLabel();
            this.ProgressBarRam = new MetroFramework.Controls.MetroProgressBar();
            this.perRam = new MetroFramework.Controls.MetroLabel();
            this.perCpu = new MetroFramework.Controls.MetroLabel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.pRam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // pRam
            // 
            this.pRam.CategoryName = "Memory";
            this.pRam.CounterName = "% committed Bytes in use";
            // 
            // pCPU
            // 
            this.pCPU.CategoryName = "Processor";
            this.pCPU.CounterName = "% Processor Time";
            this.pCPU.InstanceName = "_Total";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // ProgressBarCpu
            // 
            this.ProgressBarCpu.Location = new System.Drawing.Point(146, 74);
            this.ProgressBarCpu.Name = "ProgressBarCpu";
            this.ProgressBarCpu.Size = new System.Drawing.Size(458, 36);
            this.ProgressBarCpu.TabIndex = 0;
            // 
            // lbcpu
            // 
            this.lbcpu.Location = new System.Drawing.Point(628, 74);
            this.lbcpu.Name = "lbcpu";
            this.lbcpu.Size = new System.Drawing.Size(111, 36);
            this.lbcpu.TabIndex = 1;
            this.lbcpu.Text = "0%";
            this.lbcpu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbram
            // 
            this.lbram.Location = new System.Drawing.Point(628, 136);
            this.lbram.Name = "lbram";
            this.lbram.Size = new System.Drawing.Size(111, 36);
            this.lbram.TabIndex = 3;
            this.lbram.Text = "0%";
            this.lbram.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProgressBarRam
            // 
            this.ProgressBarRam.Location = new System.Drawing.Point(146, 136);
            this.ProgressBarRam.Name = "ProgressBarRam";
            this.ProgressBarRam.Size = new System.Drawing.Size(458, 36);
            this.ProgressBarRam.TabIndex = 2;
            // 
            // perRam
            // 
            this.perRam.Location = new System.Drawing.Point(9, 136);
            this.perRam.Name = "perRam";
            this.perRam.Size = new System.Drawing.Size(111, 36);
            this.perRam.TabIndex = 5;
            this.perRam.Text = "RAM";
            this.perRam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // perCpu
            // 
            this.perCpu.Location = new System.Drawing.Point(9, 74);
            this.perCpu.Name = "perCpu";
            this.perCpu.Size = new System.Drawing.Size(111, 36);
            this.perCpu.TabIndex = 4;
            this.perCpu.Text = "CPU";
            this.perCpu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(51, 199);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "CPU";
            series2.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Left;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series2.Legend = "Legend1";
            series2.Name = "RAM";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(688, 271);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            // 
            // FormCPUandRAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 515);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.perRam);
            this.Controls.Add(this.perCpu);
            this.Controls.Add(this.lbram);
            this.Controls.Add(this.ProgressBarRam);
            this.Controls.Add(this.lbcpu);
            this.Controls.Add(this.ProgressBarCpu);
            this.MaximizeBox = false;
            this.Name = "FormCPUandRAM";
            this.Resizable = false;
            this.Text = "Performance";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pRam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Diagnostics.PerformanceCounter pRam;
        private System.Diagnostics.PerformanceCounter pCPU;
        private System.Windows.Forms.Timer timer;
        private MetroFramework.Controls.MetroProgressBar ProgressBarCpu;
        private MetroFramework.Controls.MetroLabel lbcpu;
        private MetroFramework.Controls.MetroLabel lbram;
        private MetroFramework.Controls.MetroProgressBar ProgressBarRam;
        private MetroFramework.Controls.MetroLabel perRam;
        private MetroFramework.Controls.MetroLabel perCpu;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}