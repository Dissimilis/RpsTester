namespace RpsTest
{
    partial class FormMain
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
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.rbClient = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbClientAsync = new System.Windows.Forms.RadioButton();
            this.rbServer = new System.Windows.Forms.RadioButton();
            this.tbLog = new System.Windows.Forms.TextBox();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnStartAb = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maxConnections = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tbLog2 = new System.Windows.Forms.TextBox();
            this.labelCnt = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbKeepAlive = new System.Windows.Forms.CheckBox();
            this.tbServerBinding = new System.Windows.Forms.TextBox();
            this.tasksCount = new System.Windows.Forms.NumericUpDown();
            this.chartInterval = new System.Windows.Forms.NumericUpDown();
            this.tbUrl = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxConnections)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // chart
            // 
            chartArea1.AxisX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Milliseconds;
            chartArea1.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Milliseconds;
            chartArea1.AxisX.IsMarginVisible = false;
            chartArea1.AxisX.MaximumAutoSize = 80F;
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(0, 0);
            this.chart.Name = "chart";
            this.chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series1.Legend = "Legend1";
            series1.MarkerStep = 10;
            series1.Name = "Series1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            this.chart.Series.Add(series1);
            this.chart.Series.Add(series2);
            this.chart.Size = new System.Drawing.Size(1048, 421);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart1";
            this.chart.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.Normal;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "URL";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(901, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(63, 67);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // rbClient
            // 
            this.rbClient.AutoSize = true;
            this.rbClient.Checked = true;
            this.rbClient.Location = new System.Drawing.Point(6, 19);
            this.rbClient.Name = "rbClient";
            this.rbClient.Size = new System.Drawing.Size(96, 17);
            this.rbClient.TabIndex = 4;
            this.rbClient.TabStop = true;
            this.rbClient.Text = "Client threaded";
            this.rbClient.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbClientAsync);
            this.groupBox1.Controls.Add(this.rbServer);
            this.groupBox1.Controls.Add(this.rbClient);
            this.groupBox1.Location = new System.Drawing.Point(641, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 72);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mode";
            // 
            // rbClientAsync
            // 
            this.rbClientAsync.AutoSize = true;
            this.rbClientAsync.Location = new System.Drawing.Point(114, 19);
            this.rbClientAsync.Name = "rbClientAsync";
            this.rbClientAsync.Size = new System.Drawing.Size(82, 17);
            this.rbClientAsync.TabIndex = 6;
            this.rbClientAsync.Text = "Client async";
            this.rbClientAsync.UseVisualStyleBackColor = true;
            // 
            // rbServer
            // 
            this.rbServer.AutoSize = true;
            this.rbServer.Location = new System.Drawing.Point(6, 45);
            this.rbServer.Name = "rbServer";
            this.rbServer.Size = new System.Drawing.Size(56, 17);
            this.rbServer.TabIndex = 5;
            this.rbServer.Text = "Server";
            this.rbServer.UseVisualStyleBackColor = true;
            // 
            // tbLog
            // 
            this.tbLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLog.Location = new System.Drawing.Point(0, 0);
            this.tbLog.Multiline = true;
            this.tbLog.Name = "tbLog";
            this.tbLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbLog.Size = new System.Drawing.Size(800, 200);
            this.tbLog.TabIndex = 6;
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.cbKeepAlive);
            this.panelButtons.Controls.Add(this.label5);
            this.panelButtons.Controls.Add(this.tbServerBinding);
            this.panelButtons.Controls.Add(this.btnStartAb);
            this.panelButtons.Controls.Add(this.label4);
            this.panelButtons.Controls.Add(this.tasksCount);
            this.panelButtons.Controls.Add(this.label3);
            this.panelButtons.Controls.Add(this.maxConnections);
            this.panelButtons.Controls.Add(this.label2);
            this.panelButtons.Controls.Add(this.chartInterval);
            this.panelButtons.Controls.Add(this.btnStart);
            this.panelButtons.Controls.Add(this.label1);
            this.panelButtons.Controls.Add(this.groupBox1);
            this.panelButtons.Controls.Add(this.tbUrl);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons.Location = new System.Drawing.Point(0, 0);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(1048, 87);
            this.panelButtons.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(356, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Binding addess";
            // 
            // btnStartAb
            // 
            this.btnStartAb.Location = new System.Drawing.Point(970, 12);
            this.btnStartAb.Name = "btnStartAb";
            this.btnStartAb.Size = new System.Drawing.Size(58, 67);
            this.btnStartAb.TabIndex = 12;
            this.btnStartAb.Text = "Start AB";
            this.btnStartAb.UseVisualStyleBackColor = true;
            this.btnStartAb.Click += new System.EventHandler(this.btnStartAb_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(187, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tasks";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Client max connections";
            // 
            // maxConnections
            // 
            this.maxConnections.Location = new System.Drawing.Point(128, 52);
            this.maxConnections.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.maxConnections.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.maxConnections.Name = "maxConnections";
            this.maxConnections.Size = new System.Drawing.Size(53, 20);
            this.maxConnections.TabIndex = 8;
            this.maxConnections.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.maxConnections.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Chart interval (ms)";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 87);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.chart);
            this.splitContainer1.Panel2.Controls.Add(this.labelCnt);
            this.splitContainer1.Size = new System.Drawing.Size(1048, 625);
            this.splitContainer1.SplitterDistance = 200;
            this.splitContainer1.TabIndex = 8;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tbLog);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tbLog2);
            this.splitContainer2.Size = new System.Drawing.Size(1048, 200);
            this.splitContainer2.SplitterDistance = 800;
            this.splitContainer2.TabIndex = 8;
            // 
            // tbLog2
            // 
            this.tbLog2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLog2.Location = new System.Drawing.Point(0, 0);
            this.tbLog2.Multiline = true;
            this.tbLog2.Name = "tbLog2";
            this.tbLog2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbLog2.Size = new System.Drawing.Size(244, 200);
            this.tbLog2.TabIndex = 0;
            // 
            // labelCnt
            // 
            this.labelCnt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCnt.AutoSize = true;
            this.labelCnt.BackColor = System.Drawing.Color.Transparent;
            this.labelCnt.Location = new System.Drawing.Point(967, 2);
            this.labelCnt.Name = "labelCnt";
            this.labelCnt.Size = new System.Drawing.Size(13, 13);
            this.labelCnt.TabIndex = 7;
            this.labelCnt.Text = "0";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cbKeepAlive
            // 
            this.cbKeepAlive.AutoSize = true;
            this.cbKeepAlive.Location = new System.Drawing.Point(306, 55);
            this.cbKeepAlive.Name = "cbKeepAlive";
            this.cbKeepAlive.Size = new System.Drawing.Size(74, 17);
            this.cbKeepAlive.TabIndex = 15;
            this.cbKeepAlive.Text = "KeppAlive";
            this.cbKeepAlive.UseVisualStyleBackColor = true;
            // 
            // tbServerBinding
            // 
            this.tbServerBinding.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::RpsTest.Properties.Settings.Default, "Binding", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbServerBinding.Location = new System.Drawing.Point(437, 4);
            this.tbServerBinding.Name = "tbServerBinding";
            this.tbServerBinding.Size = new System.Drawing.Size(198, 20);
            this.tbServerBinding.TabIndex = 14;
            this.tbServerBinding.Text = global::RpsTest.Properties.Settings.Default.Binding;
            // 
            // tasksCount
            // 
            this.tasksCount.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::RpsTest.Properties.Settings.Default, "MaxTasks", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tasksCount.Location = new System.Drawing.Point(229, 52);
            this.tasksCount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.tasksCount.Name = "tasksCount";
            this.tasksCount.Size = new System.Drawing.Size(46, 20);
            this.tasksCount.TabIndex = 10;
            this.tasksCount.Value = global::RpsTest.Properties.Settings.Default.MaxTasks;
            this.tasksCount.ValueChanged += new System.EventHandler(this.tasksCount_ValueChanged);
            // 
            // chartInterval
            // 
            this.chartInterval.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::RpsTest.Properties.Settings.Default, "ChartInterval", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chartInterval.Location = new System.Drawing.Point(128, 29);
            this.chartInterval.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.chartInterval.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.chartInterval.Name = "chartInterval";
            this.chartInterval.Size = new System.Drawing.Size(53, 20);
            this.chartInterval.TabIndex = 6;
            this.chartInterval.Value = global::RpsTest.Properties.Settings.Default.ChartInterval;
            // 
            // tbUrl
            // 
            this.tbUrl.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::RpsTest.Properties.Settings.Default, "URL", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbUrl.Location = new System.Drawing.Point(38, 4);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(303, 20);
            this.tbUrl.TabIndex = 2;
            this.tbUrl.Text = global::RpsTest.Properties.Settings.Default.URL;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 712);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panelButtons);
            this.Name = "FormMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.panelButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxConnections)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartInterval)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.RadioButton rbClient;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbServer;
        private System.Windows.Forms.TextBox tbLog;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label labelCnt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown chartInterval;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TextBox tbLog2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown maxConnections;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown tasksCount;
        private System.Windows.Forms.Button btnStartAb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbServerBinding;
        private System.Windows.Forms.RadioButton rbClientAsync;
        private System.Windows.Forms.CheckBox cbKeepAlive;
    }
}

