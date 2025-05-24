namespace BeeBearGUI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.numUpDownBeeCount = new System.Windows.Forms.NumericUpDown();
            this.numUpDownPotCapacity = new System.Windows.Forms.NumericUpDown();
            this.numUpDownMinTime = new System.Windows.Forms.NumericUpDown();
            this.numUpDownMaxTime = new System.Windows.Forms.NumericUpDown();
            this.progressBarPotCapacity = new System.Windows.Forms.ProgressBar();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.listBoxLogs = new System.Windows.Forms.ListBox();
            this.checkBoxLogging = new System.Windows.Forms.CheckBox();
            this.btnShowStats = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.panelInputParametrs = new System.Windows.Forms.Panel();
            this.labelBearEatTime = new System.Windows.Forms.Label();
            this.numUpDownBearEatTime = new System.Windows.Forms.NumericUpDown();
            this.labelMaxTime = new System.Windows.Forms.Label();
            this.labelMinTime = new System.Windows.Forms.Label();
            this.labelPotCapacity = new System.Windows.Forms.Label();
            this.labelBeeCount = new System.Windows.Forms.Label();
            this.labelCurrentCapacity = new System.Windows.Forms.Label();
            this.panelStatsManagement = new System.Windows.Forms.Panel();
            this.btnResetFilters = new System.Windows.Forms.Button();
            this.labelComparisonSet = new System.Windows.Forms.Label();
            this.comboBoxFilterSet = new System.Windows.Forms.ComboBox();
            this.labelChart = new System.Windows.Forms.Label();
            this.labelSaves = new System.Windows.Forms.Label();
            this.btnDeleteSim = new System.Windows.Forms.Button();
            this.btnCompareBeeVsTime = new System.Windows.Forms.Button();
            this.btnLoadStats = new System.Windows.Forms.Button();
            this.comboBoxChartType = new System.Windows.Forms.ComboBox();
            this.btnLoadChart = new System.Windows.Forms.Button();
            this.comboBoxSimulations = new System.Windows.Forms.ComboBox();
            this.chartResult = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.checkBoxSoundEffects = new System.Windows.Forms.CheckBox();
            this.labelQueue = new System.Windows.Forms.Label();
            this.labelQueueStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownBeeCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownPotCapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMinTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMaxTime)).BeginInit();
            this.panelInputParametrs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownBearEatTime)).BeginInit();
            this.panelStatsManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult)).BeginInit();
            this.SuspendLayout();
            // 
            // numUpDownBeeCount
            // 
            this.numUpDownBeeCount.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.numUpDownBeeCount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numUpDownBeeCount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUpDownBeeCount.Location = new System.Drawing.Point(10, 10);
            this.numUpDownBeeCount.Margin = new System.Windows.Forms.Padding(10);
            this.numUpDownBeeCount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numUpDownBeeCount.Name = "numUpDownBeeCount";
            this.numUpDownBeeCount.Size = new System.Drawing.Size(91, 30);
            this.numUpDownBeeCount.TabIndex = 0;
            this.numUpDownBeeCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numUpDownPotCapacity
            // 
            this.numUpDownPotCapacity.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.numUpDownPotCapacity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numUpDownPotCapacity.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUpDownPotCapacity.Location = new System.Drawing.Point(10, 60);
            this.numUpDownPotCapacity.Margin = new System.Windows.Forms.Padding(10);
            this.numUpDownPotCapacity.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numUpDownPotCapacity.Name = "numUpDownPotCapacity";
            this.numUpDownPotCapacity.Size = new System.Drawing.Size(91, 30);
            this.numUpDownPotCapacity.TabIndex = 1;
            this.numUpDownPotCapacity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numUpDownMinTime
            // 
            this.numUpDownMinTime.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.numUpDownMinTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numUpDownMinTime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUpDownMinTime.Location = new System.Drawing.Point(10, 110);
            this.numUpDownMinTime.Margin = new System.Windows.Forms.Padding(10);
            this.numUpDownMinTime.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numUpDownMinTime.Name = "numUpDownMinTime";
            this.numUpDownMinTime.Size = new System.Drawing.Size(91, 30);
            this.numUpDownMinTime.TabIndex = 2;
            this.numUpDownMinTime.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // numUpDownMaxTime
            // 
            this.numUpDownMaxTime.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.numUpDownMaxTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numUpDownMaxTime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUpDownMaxTime.Location = new System.Drawing.Point(10, 160);
            this.numUpDownMaxTime.Margin = new System.Windows.Forms.Padding(10);
            this.numUpDownMaxTime.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numUpDownMaxTime.Name = "numUpDownMaxTime";
            this.numUpDownMaxTime.Size = new System.Drawing.Size(91, 30);
            this.numUpDownMaxTime.TabIndex = 3;
            this.numUpDownMaxTime.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // progressBarPotCapacity
            // 
            this.progressBarPotCapacity.Location = new System.Drawing.Point(12, 428);
            this.progressBarPotCapacity.Name = "progressBarPotCapacity";
            this.progressBarPotCapacity.Size = new System.Drawing.Size(344, 23);
            this.progressBarPotCapacity.TabIndex = 5;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.LightBlue;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStart.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(19, 333);
            this.btnStart.Margin = new System.Windows.Forms.Padding(10);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(90, 40);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "▶️ Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.LightBlue;
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(129, 333);
            this.btnStop.Margin = new System.Windows.Forms.Padding(10);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(90, 40);
            this.btnStop.TabIndex = 8;
            this.btnStop.Text = "🛑 Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // listBoxLogs
            // 
            this.listBoxLogs.BackColor = System.Drawing.SystemColors.Window;
            this.listBoxLogs.FormattingEnabled = true;
            this.listBoxLogs.ItemHeight = 16;
            this.listBoxLogs.Location = new System.Drawing.Point(362, 12);
            this.listBoxLogs.Name = "listBoxLogs";
            this.listBoxLogs.Size = new System.Drawing.Size(492, 628);
            this.listBoxLogs.TabIndex = 9;
            // 
            // checkBoxLogging
            // 
            this.checkBoxLogging.AutoSize = true;
            this.checkBoxLogging.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxLogging.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxLogging.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxLogging.Location = new System.Drawing.Point(19, 287);
            this.checkBoxLogging.Margin = new System.Windows.Forms.Padding(10);
            this.checkBoxLogging.Name = "checkBoxLogging";
            this.checkBoxLogging.Size = new System.Drawing.Size(163, 26);
            this.checkBoxLogging.TabIndex = 10;
            this.checkBoxLogging.Text = "📋 Show Logging";
            this.checkBoxLogging.UseVisualStyleBackColor = true;
            // 
            // btnShowStats
            // 
            this.btnShowStats.BackColor = System.Drawing.Color.LightBlue;
            this.btnShowStats.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowStats.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShowStats.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowStats.Location = new System.Drawing.Point(362, 653);
            this.btnShowStats.Margin = new System.Windows.Forms.Padding(10);
            this.btnShowStats.Name = "btnShowStats";
            this.btnShowStats.Size = new System.Drawing.Size(210, 40);
            this.btnShowStats.TabIndex = 11;
            this.btnShowStats.Text = "📌 Show Last Result";
            this.btnShowStats.UseVisualStyleBackColor = false;
            this.btnShowStats.Click += new System.EventHandler(this.btnShowStats_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightBlue;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(704, 652);
            this.btnClear.Margin = new System.Windows.Forms.Padding(10);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(150, 40);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "📦 Clear Logs";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // panelInputParametrs
            // 
            this.panelInputParametrs.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelInputParametrs.Controls.Add(this.labelBearEatTime);
            this.panelInputParametrs.Controls.Add(this.numUpDownBearEatTime);
            this.panelInputParametrs.Controls.Add(this.labelMaxTime);
            this.panelInputParametrs.Controls.Add(this.labelMinTime);
            this.panelInputParametrs.Controls.Add(this.labelPotCapacity);
            this.panelInputParametrs.Controls.Add(this.labelBeeCount);
            this.panelInputParametrs.Controls.Add(this.numUpDownBeeCount);
            this.panelInputParametrs.Controls.Add(this.numUpDownPotCapacity);
            this.panelInputParametrs.Controls.Add(this.numUpDownMinTime);
            this.panelInputParametrs.Controls.Add(this.numUpDownMaxTime);
            this.panelInputParametrs.Location = new System.Drawing.Point(12, 12);
            this.panelInputParametrs.Name = "panelInputParametrs";
            this.panelInputParametrs.Size = new System.Drawing.Size(344, 250);
            this.panelInputParametrs.TabIndex = 13;
            // 
            // labelBearEatTime
            // 
            this.labelBearEatTime.AutoSize = true;
            this.labelBearEatTime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBearEatTime.Location = new System.Drawing.Point(121, 212);
            this.labelBearEatTime.Margin = new System.Windows.Forms.Padding(10);
            this.labelBearEatTime.Name = "labelBearEatTime";
            this.labelBearEatTime.Size = new System.Drawing.Size(165, 22);
            this.labelBearEatTime.TabIndex = 9;
            this.labelBearEatTime.Text = "Bear Eat Time (ms)";
            // 
            // numUpDownBearEatTime
            // 
            this.numUpDownBearEatTime.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.numUpDownBearEatTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numUpDownBearEatTime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUpDownBearEatTime.Location = new System.Drawing.Point(10, 210);
            this.numUpDownBearEatTime.Margin = new System.Windows.Forms.Padding(10);
            this.numUpDownBearEatTime.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numUpDownBearEatTime.Name = "numUpDownBearEatTime";
            this.numUpDownBearEatTime.Size = new System.Drawing.Size(91, 30);
            this.numUpDownBearEatTime.TabIndex = 8;
            this.numUpDownBearEatTime.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // labelMaxTime
            // 
            this.labelMaxTime.AutoSize = true;
            this.labelMaxTime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaxTime.Location = new System.Drawing.Point(121, 162);
            this.labelMaxTime.Margin = new System.Windows.Forms.Padding(10);
            this.labelMaxTime.Name = "labelMaxTime";
            this.labelMaxTime.Size = new System.Drawing.Size(219, 22);
            this.labelMaxTime.TabIndex = 7;
            this.labelMaxTime.Text = "Max Collection Time (ms)";
            // 
            // labelMinTime
            // 
            this.labelMinTime.AutoSize = true;
            this.labelMinTime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMinTime.Location = new System.Drawing.Point(121, 112);
            this.labelMinTime.Margin = new System.Windows.Forms.Padding(10);
            this.labelMinTime.Name = "labelMinTime";
            this.labelMinTime.Size = new System.Drawing.Size(216, 22);
            this.labelMinTime.TabIndex = 6;
            this.labelMinTime.Text = "Min Collection Time (ms)";
            // 
            // labelPotCapacity
            // 
            this.labelPotCapacity.AutoSize = true;
            this.labelPotCapacity.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPotCapacity.Location = new System.Drawing.Point(121, 62);
            this.labelPotCapacity.Margin = new System.Windows.Forms.Padding(10);
            this.labelPotCapacity.Name = "labelPotCapacity";
            this.labelPotCapacity.Size = new System.Drawing.Size(111, 22);
            this.labelPotCapacity.TabIndex = 5;
            this.labelPotCapacity.Text = "Pot Capacity";
            // 
            // labelBeeCount
            // 
            this.labelBeeCount.AutoSize = true;
            this.labelBeeCount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBeeCount.Location = new System.Drawing.Point(121, 12);
            this.labelBeeCount.Margin = new System.Windows.Forms.Padding(10);
            this.labelBeeCount.Name = "labelBeeCount";
            this.labelBeeCount.Size = new System.Drawing.Size(92, 22);
            this.labelBeeCount.TabIndex = 4;
            this.labelBeeCount.Text = "Bee Count";
            // 
            // labelCurrentCapacity
            // 
            this.labelCurrentCapacity.AutoSize = true;
            this.labelCurrentCapacity.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentCapacity.Location = new System.Drawing.Point(69, 393);
            this.labelCurrentCapacity.Margin = new System.Windows.Forms.Padding(10);
            this.labelCurrentCapacity.Name = "labelCurrentCapacity";
            this.labelCurrentCapacity.Size = new System.Drawing.Size(199, 22);
            this.labelCurrentCapacity.TabIndex = 14;
            this.labelCurrentCapacity.Text = "🍯 Current Pot Capacity";
            // 
            // panelStatsManagement
            // 
            this.panelStatsManagement.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelStatsManagement.Controls.Add(this.btnResetFilters);
            this.panelStatsManagement.Controls.Add(this.labelComparisonSet);
            this.panelStatsManagement.Controls.Add(this.comboBoxFilterSet);
            this.panelStatsManagement.Controls.Add(this.labelChart);
            this.panelStatsManagement.Controls.Add(this.labelSaves);
            this.panelStatsManagement.Controls.Add(this.btnDeleteSim);
            this.panelStatsManagement.Controls.Add(this.btnCompareBeeVsTime);
            this.panelStatsManagement.Controls.Add(this.btnLoadStats);
            this.panelStatsManagement.Controls.Add(this.comboBoxChartType);
            this.panelStatsManagement.Controls.Add(this.btnLoadChart);
            this.panelStatsManagement.Controls.Add(this.comboBoxSimulations);
            this.panelStatsManagement.Controls.Add(this.chartResult);
            this.panelStatsManagement.Location = new System.Drawing.Point(860, 12);
            this.panelStatsManagement.Name = "panelStatsManagement";
            this.panelStatsManagement.Size = new System.Drawing.Size(600, 680);
            this.panelStatsManagement.TabIndex = 26;
            // 
            // btnResetFilters
            // 
            this.btnResetFilters.BackColor = System.Drawing.Color.LightBlue;
            this.btnResetFilters.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetFilters.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnResetFilters.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetFilters.Location = new System.Drawing.Point(166, 586);
            this.btnResetFilters.Margin = new System.Windows.Forms.Padding(10);
            this.btnResetFilters.Name = "btnResetFilters";
            this.btnResetFilters.Size = new System.Drawing.Size(200, 40);
            this.btnResetFilters.TabIndex = 49;
            this.btnResetFilters.Text = "🔄 Reset Filters";
            this.btnResetFilters.UseVisualStyleBackColor = false;
            this.btnResetFilters.Click += new System.EventHandler(this.btnResetFilters_Click);
            // 
            // labelComparisonSet
            // 
            this.labelComparisonSet.AutoSize = true;
            this.labelComparisonSet.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComparisonSet.Location = new System.Drawing.Point(10, 479);
            this.labelComparisonSet.Margin = new System.Windows.Forms.Padding(10);
            this.labelComparisonSet.Name = "labelComparisonSet";
            this.labelComparisonSet.Size = new System.Drawing.Size(133, 22);
            this.labelComparisonSet.TabIndex = 48;
            this.labelComparisonSet.Text = "🔁 Compar. Set";
            // 
            // comboBoxFilterSet
            // 
            this.comboBoxFilterSet.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.comboBoxFilterSet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxFilterSet.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFilterSet.FormattingEnabled = true;
            this.comboBoxFilterSet.Location = new System.Drawing.Point(166, 476);
            this.comboBoxFilterSet.Margin = new System.Windows.Forms.Padding(10);
            this.comboBoxFilterSet.Name = "comboBoxFilterSet";
            this.comboBoxFilterSet.Size = new System.Drawing.Size(420, 30);
            this.comboBoxFilterSet.TabIndex = 47;
            // 
            // labelChart
            // 
            this.labelChart.AutoSize = true;
            this.labelChart.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChart.Location = new System.Drawing.Point(10, 369);
            this.labelChart.Margin = new System.Windows.Forms.Padding(10);
            this.labelChart.Name = "labelChart";
            this.labelChart.Size = new System.Drawing.Size(86, 22);
            this.labelChart.TabIndex = 46;
            this.labelChart.Text = "📈 Charts";
            // 
            // labelSaves
            // 
            this.labelSaves.AutoSize = true;
            this.labelSaves.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSaves.Location = new System.Drawing.Point(10, 319);
            this.labelSaves.Margin = new System.Windows.Forms.Padding(10);
            this.labelSaves.Name = "labelSaves";
            this.labelSaves.Size = new System.Drawing.Size(82, 22);
            this.labelSaves.TabIndex = 45;
            this.labelSaves.Text = "💾 Saves";
            // 
            // btnDeleteSim
            // 
            this.btnDeleteSim.BackColor = System.Drawing.Color.LightBlue;
            this.btnDeleteSim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteSim.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteSim.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSim.Location = new System.Drawing.Point(386, 586);
            this.btnDeleteSim.Margin = new System.Windows.Forms.Padding(10);
            this.btnDeleteSim.Name = "btnDeleteSim";
            this.btnDeleteSim.Size = new System.Drawing.Size(200, 40);
            this.btnDeleteSim.TabIndex = 44;
            this.btnDeleteSim.Text = "🗑️ Delete Simulation";
            this.btnDeleteSim.UseVisualStyleBackColor = false;
            this.btnDeleteSim.Click += new System.EventHandler(this.btnDeleteSim_Click);
            // 
            // btnCompareBeeVsTime
            // 
            this.btnCompareBeeVsTime.BackColor = System.Drawing.Color.LightBlue;
            this.btnCompareBeeVsTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompareBeeVsTime.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCompareBeeVsTime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompareBeeVsTime.Location = new System.Drawing.Point(386, 526);
            this.btnCompareBeeVsTime.Margin = new System.Windows.Forms.Padding(10);
            this.btnCompareBeeVsTime.Name = "btnCompareBeeVsTime";
            this.btnCompareBeeVsTime.Size = new System.Drawing.Size(200, 40);
            this.btnCompareBeeVsTime.TabIndex = 43;
            this.btnCompareBeeVsTime.Text = "Compare 🐝 vs ⏱";
            this.btnCompareBeeVsTime.UseVisualStyleBackColor = false;
            this.btnCompareBeeVsTime.Click += new System.EventHandler(this.btnCompareBeeVsTime_Click);
            // 
            // btnLoadStats
            // 
            this.btnLoadStats.BackColor = System.Drawing.Color.LightBlue;
            this.btnLoadStats.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoadStats.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoadStats.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadStats.Location = new System.Drawing.Point(166, 416);
            this.btnLoadStats.Margin = new System.Windows.Forms.Padding(10);
            this.btnLoadStats.Name = "btnLoadStats";
            this.btnLoadStats.Size = new System.Drawing.Size(200, 40);
            this.btnLoadStats.TabIndex = 42;
            this.btnLoadStats.Text = "📊 Show Load Stats";
            this.btnLoadStats.UseVisualStyleBackColor = false;
            this.btnLoadStats.Click += new System.EventHandler(this.btnLoadStats_Click);
            // 
            // comboBoxChartType
            // 
            this.comboBoxChartType.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.comboBoxChartType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxChartType.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxChartType.FormattingEnabled = true;
            this.comboBoxChartType.Location = new System.Drawing.Point(166, 366);
            this.comboBoxChartType.Margin = new System.Windows.Forms.Padding(10);
            this.comboBoxChartType.Name = "comboBoxChartType";
            this.comboBoxChartType.Size = new System.Drawing.Size(420, 30);
            this.comboBoxChartType.TabIndex = 41;
            // 
            // btnLoadChart
            // 
            this.btnLoadChart.BackColor = System.Drawing.Color.LightBlue;
            this.btnLoadChart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoadChart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoadChart.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadChart.Location = new System.Drawing.Point(386, 416);
            this.btnLoadChart.Margin = new System.Windows.Forms.Padding(10);
            this.btnLoadChart.Name = "btnLoadChart";
            this.btnLoadChart.Size = new System.Drawing.Size(200, 40);
            this.btnLoadChart.TabIndex = 40;
            this.btnLoadChart.Text = "📈 Show Load Chart";
            this.btnLoadChart.UseVisualStyleBackColor = false;
            this.btnLoadChart.Click += new System.EventHandler(this.btnLoadChart_Click);
            // 
            // comboBoxSimulations
            // 
            this.comboBoxSimulations.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.comboBoxSimulations.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxSimulations.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSimulations.FormattingEnabled = true;
            this.comboBoxSimulations.Location = new System.Drawing.Point(166, 316);
            this.comboBoxSimulations.Margin = new System.Windows.Forms.Padding(10);
            this.comboBoxSimulations.Name = "comboBoxSimulations";
            this.comboBoxSimulations.Size = new System.Drawing.Size(420, 30);
            this.comboBoxSimulations.TabIndex = 39;
            // 
            // chartResult
            // 
            chartArea1.Name = "ChartArea1";
            this.chartResult.ChartAreas.Add(chartArea1);
            this.chartResult.Cursor = System.Windows.Forms.Cursors.Hand;
            legend1.Name = "Legend1";
            this.chartResult.Legends.Add(legend1);
            this.chartResult.Location = new System.Drawing.Point(3, 3);
            this.chartResult.Name = "chartResult";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartResult.Series.Add(series1);
            this.chartResult.Size = new System.Drawing.Size(590, 300);
            this.chartResult.TabIndex = 38;
            this.chartResult.Text = "chart1";
            this.chartResult.DoubleClick += new System.EventHandler(this.chartResult_DoubleClick);
            // 
            // checkBoxSoundEffects
            // 
            this.checkBoxSoundEffects.AutoSize = true;
            this.checkBoxSoundEffects.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxSoundEffects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxSoundEffects.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSoundEffects.Location = new System.Drawing.Point(210, 287);
            this.checkBoxSoundEffects.Margin = new System.Windows.Forms.Padding(10);
            this.checkBoxSoundEffects.Name = "checkBoxSoundEffects";
            this.checkBoxSoundEffects.Size = new System.Drawing.Size(111, 26);
            this.checkBoxSoundEffects.TabIndex = 27;
            this.checkBoxSoundEffects.Text = "🔊 Sounds";
            this.checkBoxSoundEffects.UseVisualStyleBackColor = true;
            // 
            // labelQueue
            // 
            this.labelQueue.AutoSize = true;
            this.labelQueue.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQueue.Location = new System.Drawing.Point(69, 488);
            this.labelQueue.Margin = new System.Windows.Forms.Padding(10, 10, 5, 10);
            this.labelQueue.Name = "labelQueue";
            this.labelQueue.Size = new System.Drawing.Size(117, 22);
            this.labelQueue.TabIndex = 28;
            this.labelQueue.Text = "Queue Count:";
            // 
            // labelQueueStatus
            // 
            this.labelQueueStatus.AutoSize = true;
            this.labelQueueStatus.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQueueStatus.Location = new System.Drawing.Point(191, 488);
            this.labelQueueStatus.Margin = new System.Windows.Forms.Padding(0, 10, 10, 10);
            this.labelQueueStatus.Name = "labelQueueStatus";
            this.labelQueueStatus.Size = new System.Drawing.Size(20, 22);
            this.labelQueueStatus.TabIndex = 29;
            this.labelQueueStatus.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1472, 703);
            this.Controls.Add(this.labelQueueStatus);
            this.Controls.Add(this.labelQueue);
            this.Controls.Add(this.checkBoxSoundEffects);
            this.Controls.Add(this.panelStatsManagement);
            this.Controls.Add(this.labelCurrentCapacity);
            this.Controls.Add(this.panelInputParametrs);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnShowStats);
            this.Controls.Add(this.checkBoxLogging);
            this.Controls.Add(this.listBoxLogs);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.progressBarPotCapacity);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bee Bear Simulation";
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownBeeCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownPotCapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMinTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMaxTime)).EndInit();
            this.panelInputParametrs.ResumeLayout(false);
            this.panelInputParametrs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownBearEatTime)).EndInit();
            this.panelStatsManagement.ResumeLayout(false);
            this.panelStatsManagement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numUpDownBeeCount;
        private System.Windows.Forms.NumericUpDown numUpDownPotCapacity;
        private System.Windows.Forms.NumericUpDown numUpDownMinTime;
        private System.Windows.Forms.NumericUpDown numUpDownMaxTime;
        private System.Windows.Forms.ProgressBar progressBarPotCapacity;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.ListBox listBoxLogs;
        private System.Windows.Forms.CheckBox checkBoxLogging;
        private System.Windows.Forms.Button btnShowStats;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel panelInputParametrs;
        private System.Windows.Forms.Label labelMaxTime;
        private System.Windows.Forms.Label labelMinTime;
        private System.Windows.Forms.Label labelPotCapacity;
        private System.Windows.Forms.Label labelBeeCount;
        private System.Windows.Forms.Label labelCurrentCapacity;
        private System.Windows.Forms.Panel panelStatsManagement;
        private System.Windows.Forms.Label labelComparisonSet;
        private System.Windows.Forms.ComboBox comboBoxFilterSet;
        private System.Windows.Forms.Label labelChart;
        private System.Windows.Forms.Label labelSaves;
        private System.Windows.Forms.Button btnDeleteSim;
        private System.Windows.Forms.Button btnCompareBeeVsTime;
        private System.Windows.Forms.Button btnLoadStats;
        private System.Windows.Forms.ComboBox comboBoxChartType;
        private System.Windows.Forms.Button btnLoadChart;
        private System.Windows.Forms.ComboBox comboBoxSimulations;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult;
        private System.Windows.Forms.Button btnResetFilters;
        private System.Windows.Forms.CheckBox checkBoxSoundEffects;
        private System.Windows.Forms.Label labelBearEatTime;
        private System.Windows.Forms.NumericUpDown numUpDownBearEatTime;
        private System.Windows.Forms.Label labelQueue;
        private System.Windows.Forms.Label labelQueueStatus;
    }
}

