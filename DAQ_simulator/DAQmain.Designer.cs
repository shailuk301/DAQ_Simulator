namespace DAQ_simulator
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timingInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.samplingTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loggingTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.sensordata = new System.Data.DataSet();
            this.Logging = new System.Data.DataSet();
            this.showSensorData = new System.Windows.Forms.DataGridView();
            this.showLogData = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sensordata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logging)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showSensorData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showLogData)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(1435, 33);
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
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.quitToolStripMenuItem.Text = "Quit";
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
            this.samplingTimeToolStripMenuItem.Name = "samplingTimeToolStripMenuItem";
            this.samplingTimeToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.samplingTimeToolStripMenuItem.Text = "Sampling Time";
            // 
            // loggingTimeToolStripMenuItem
            // 
            this.loggingTimeToolStripMenuItem.Name = "loggingTimeToolStripMenuItem";
            this.loggingTimeToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.loggingTimeToolStripMenuItem.Text = "Logging Time";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 52);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(160, 45);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start Simulation";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(12, 152);
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
            this.showSensorData.Location = new System.Drawing.Point(235, 52);
            this.showSensorData.Name = "showSensorData";
            this.showSensorData.RowHeadersWidth = 62;
            this.showSensorData.RowTemplate.Height = 28;
            this.showSensorData.Size = new System.Drawing.Size(530, 459);
            this.showSensorData.TabIndex = 3;
            // 
            // showLogData
            // 
            this.showLogData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showLogData.Location = new System.Drawing.Point(771, 52);
            this.showLogData.Name = "showLogData";
            this.showLogData.RowHeadersWidth = 62;
            this.showLogData.RowTemplate.Height = 28;
            this.showLogData.Size = new System.Drawing.Size(626, 459);
            this.showLogData.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Interval = 1300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 10000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // DAQmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1435, 462);
            this.Controls.Add(this.showLogData);
            this.Controls.Add(this.showSensorData);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DAQmain";
            this.Text = "DAQ_Simulator";
            this.Load += new System.EventHandler(this.DAQmain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sensordata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logging)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showSensorData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showLogData)).EndInit();
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
    }
}

