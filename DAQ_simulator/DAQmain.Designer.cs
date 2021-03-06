﻿namespace DAQ_simulator
{
    partial class DAQmain
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timingInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.samplingTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loggingTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutDeveloperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.sensordata = new System.Data.DataSet();
            this.Logging = new System.Data.DataSet();
            this.showSensorData = new System.Windows.Forms.DataGridView();
            this.showLogData = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btnLog = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sensordata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logging)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showSensorData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showLogData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.timingInformationToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1128, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(54, 29);
            this.toolStripMenuItem1.Text = "File";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(148, 34);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // timingInformationToolStripMenuItem
            // 
            this.timingInformationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.samplingTimeToolStripMenuItem,
            this.loggingTimeToolStripMenuItem});
            this.timingInformationToolStripMenuItem.Name = "timingInformationToolStripMenuItem";
            this.timingInformationToolStripMenuItem.Size = new System.Drawing.Size(181, 29);
            this.timingInformationToolStripMenuItem.Text = "Timing Information";
            // 
            // samplingTimeToolStripMenuItem
            // 
            this.samplingTimeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.secToolStripMenuItem});
            this.samplingTimeToolStripMenuItem.Name = "samplingTimeToolStripMenuItem";
            this.samplingTimeToolStripMenuItem.Size = new System.Drawing.Size(232, 34);
            this.samplingTimeToolStripMenuItem.Text = "Sampling Time";
            // 
            // secToolStripMenuItem
            // 
            this.secToolStripMenuItem.Name = "secToolStripMenuItem";
            this.secToolStripMenuItem.Size = new System.Drawing.Size(178, 34);
            this.secToolStripMenuItem.Text = "1.3 (sec)";
            // 
            // loggingTimeToolStripMenuItem
            // 
            this.loggingTimeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.secToolStripMenuItem1});
            this.loggingTimeToolStripMenuItem.Name = "loggingTimeToolStripMenuItem";
            this.loggingTimeToolStripMenuItem.Size = new System.Drawing.Size(232, 34);
            this.loggingTimeToolStripMenuItem.Text = "Logging Time";
            // 
            // secToolStripMenuItem1
            // 
            this.secToolStripMenuItem1.Name = "secToolStripMenuItem1";
            this.secToolStripMenuItem1.Size = new System.Drawing.Size(174, 34);
            this.secToolStripMenuItem1.Text = "51 (sec)";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutApplicationToolStripMenuItem,
            this.aboutDeveloperToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutApplicationToolStripMenuItem
            // 
            this.aboutApplicationToolStripMenuItem.Name = "aboutApplicationToolStripMenuItem";
            this.aboutApplicationToolStripMenuItem.Size = new System.Drawing.Size(259, 34);
            this.aboutApplicationToolStripMenuItem.Text = "About Application";
            this.aboutApplicationToolStripMenuItem.Click += new System.EventHandler(this.aboutApplicationToolStripMenuItem_Click);
            // 
            // aboutDeveloperToolStripMenuItem
            // 
            this.aboutDeveloperToolStripMenuItem.Name = "aboutDeveloperToolStripMenuItem";
            this.aboutDeveloperToolStripMenuItem.Size = new System.Drawing.Size(259, 34);
            this.aboutDeveloperToolStripMenuItem.Text = "About Developer";
            this.aboutDeveloperToolStripMenuItem.Click += new System.EventHandler(this.aboutDeveloperToolStripMenuItem_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(473, 45);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(160, 45);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start Simulation";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(473, 96);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(160, 45);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop Simulation";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // sensordata
            // 
            this.sensordata.DataSetName = "displaydata";
            // 
            // Logging
            // 
            this.Logging.DataSetName = "sumofvalues";
            // 
            // showSensorData
            // 
            this.showSensorData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showSensorData.Location = new System.Drawing.Point(12, 36);
            this.showSensorData.Name = "showSensorData";
            this.showSensorData.RowHeadersWidth = 62;
            this.showSensorData.RowTemplate.Height = 28;
            this.showSensorData.Size = new System.Drawing.Size(405, 600);
            this.showSensorData.TabIndex = 3;
            // 
            // showLogData
            // 
            this.showLogData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showLogData.Location = new System.Drawing.Point(690, 36);
            this.showLogData.Name = "showLogData";
            this.showLogData.RowHeadersWidth = 62;
            this.showLogData.RowTemplate.Height = 28;
            this.showLogData.Size = new System.Drawing.Size(405, 600);
            this.showLogData.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Interval = 1300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 3000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(473, 147);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(160, 38);
            this.btnLog.TabIndex = 5;
            this.btnLog.Text = "Log Data";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.chart1.BorderlineColor = System.Drawing.Color.Black;
            this.chart1.BorderSkin.PageColor = System.Drawing.Color.Gray;
            chartArea3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea3.BackImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Enabled = false;
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(0, 692);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.Blue;
            series3.Legend = "Legend1";
            series3.Name = "sensor1_Value";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(574, 217);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "sensorgraph";
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.DarkSeaGreen;
            chartArea4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea4.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea4);
            legend4.Enabled = false;
            legend4.Name = "Legend1";
            this.chart2.Legends.Add(legend4);
            this.chart2.Location = new System.Drawing.Point(570, 692);
            this.chart2.Name = "chart2";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Color = System.Drawing.Color.Green;
            series4.Legend = "Legend1";
            series4.Name = "sensor1_Average";
            this.chart2.Series.Add(series4);
            this.chart2.Size = new System.Drawing.Size(574, 217);
            this.chart2.TabIndex = 7;
            this.chart2.Text = "chart2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(421, 669);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Unfiltered Signal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(625, 669);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "MA_Filtered Signal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.BlueViolet;
            this.label3.Location = new System.Drawing.Point(108, 650);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(190, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Continous Data Sampling";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.BlueViolet;
            this.label4.Location = new System.Drawing.Point(805, 650);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(180, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Continous Data Filtering";
            // 
            // DAQmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1128, 944);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.showLogData);
            this.Controls.Add(this.showSensorData);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DAQmain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DAQ_Simulator";
            this.Load += new System.EventHandler(this.DAQmain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sensordata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logging)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showSensorData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showLogData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timingInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem samplingTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loggingTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Data.DataSet sensordata;
        private System.Data.DataSet Logging;
        private System.Windows.Forms.DataGridView showSensorData;
        private System.Windows.Forms.DataGridView showLogData;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.ToolStripMenuItem secToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem secToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutDeveloperToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

