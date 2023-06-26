namespace MemTest
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tabSetting = new MetroFramework.Controls.MetroTabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.nbMemory = new System.Windows.Forms.NumericUpDown();
            this.nbNumMemory = new System.Windows.Forms.NumericUpDown();
            this.lbMemoryFree = new MetroFramework.Controls.MetroLabel();
            this.nudHoldMemory = new System.Windows.Forms.NumericUpDown();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btCalculate = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btStart = new MetroFramework.Controls.MetroButton();
            this.btBurning = new MetroFramework.Controls.MetroButton();
            this.btColse = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroToggle1 = new MetroFramework.Controls.MetroToggle();
            this.togAutoCal = new MetroFramework.Controls.MetroToggle();
            this.lvMemoryState = new System.Windows.Forms.ListView();
            this.tabMonitor = new MetroFramework.Controls.MetroTabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lvMonitorState = new System.Windows.Forms.ListView();
            this.btMStart = new MetroFramework.Controls.MetroButton();
            this.btMBurning = new MetroFramework.Controls.MetroButton();
            this.btMColse = new MetroFramework.Controls.MetroButton();
            this.lvMonitor = new System.Windows.Forms.ListView();
            this.btMStopBurning = new MetroFramework.Controls.MetroButton();
            this.tabAdvanced = new MetroFramework.Controls.MetroTabPage();
            this.metroPanel4 = new MetroFramework.Controls.MetroPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.bgMemoryFree = new System.ComponentModel.BackgroundWorker();
            this.bgAutoCal = new System.ComponentModel.BackgroundWorker();
            this.bgMonitor = new System.ComponentModel.BackgroundWorker();
            this.metroPanel1.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.tabSetting.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbMemory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbNumMemory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoldMemory)).BeginInit();
            this.metroPanel3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tabMonitor.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tabAdvanced.SuspendLayout();
            this.metroPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroTabControl1);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(564, 313);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTabControl1.Controls.Add(this.tabSetting);
            this.metroTabControl1.Controls.Add(this.tabMonitor);
            this.metroTabControl1.Controls.Add(this.tabAdvanced);
            this.metroTabControl1.Location = new System.Drawing.Point(3, 3);
            this.metroTabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(558, 307);
            this.metroTabControl1.TabIndex = 2;
            this.metroTabControl1.UseSelectable = true;
            this.metroTabControl1.SelectedIndexChanged += new System.EventHandler(this.metroTabControl1_SelectedIndexChanged);
            // 
            // tabSetting
            // 
            this.tabSetting.Controls.Add(this.tableLayoutPanel1);
            this.tabSetting.Font = new System.Drawing.Font("Consolas", 11F);
            this.tabSetting.HorizontalScrollbarBarColor = true;
            this.tabSetting.HorizontalScrollbarHighlightOnWheel = false;
            this.tabSetting.HorizontalScrollbarSize = 10;
            this.tabSetting.Location = new System.Drawing.Point(4, 38);
            this.tabSetting.Margin = new System.Windows.Forms.Padding(1);
            this.tabSetting.Name = "tabSetting";
            this.tabSetting.Size = new System.Drawing.Size(550, 265);
            this.tabSetting.TabIndex = 0;
            this.tabSetting.Text = "Setting";
            this.tabSetting.VerticalScrollbarBarColor = true;
            this.tabSetting.VerticalScrollbarHighlightOnWheel = false;
            this.tabSetting.VerticalScrollbarSize = 10;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.Controls.Add(this.metroLabel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.metroPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.metroPanel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lvMemoryState, 0, 3);
            this.tableLayoutPanel1.ForeColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(544, 262);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.metroLabel1.Location = new System.Drawing.Point(3, 13);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(538, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "(Memory X Num of Memtest) = Memory Used";
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.tableLayoutPanel2);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(0, 45);
            this.metroPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(544, 45);
            this.metroPanel2.TabIndex = 1;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.Controls.Add(this.nbMemory, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.nbNumMemory, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbMemoryFree, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.nudHoldMemory, 3, 0);
            this.tableLayoutPanel2.ForeColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(544, 45);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // nbMemory
            // 
            this.nbMemory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nbMemory.Location = new System.Drawing.Point(3, 10);
            this.nbMemory.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.nbMemory.Name = "nbMemory";
            this.nbMemory.Size = new System.Drawing.Size(94, 25);
            this.nbMemory.TabIndex = 4;
            this.nbMemory.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nbMemory.ValueChanged += new System.EventHandler(this.nbMemory_ValueChanged);
            // 
            // nbNumMemory
            // 
            this.nbNumMemory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nbNumMemory.Location = new System.Drawing.Point(103, 10);
            this.nbNumMemory.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nbNumMemory.Name = "nbNumMemory";
            this.nbNumMemory.Size = new System.Drawing.Size(94, 25);
            this.nbNumMemory.TabIndex = 5;
            this.nbNumMemory.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nbNumMemory.ValueChanged += new System.EventHandler(this.nbNumMemory_ValueChanged);
            // 
            // lbMemoryFree
            // 
            this.lbMemoryFree.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbMemoryFree.AutoSize = true;
            this.lbMemoryFree.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbMemoryFree.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbMemoryFree.Location = new System.Drawing.Point(203, 13);
            this.lbMemoryFree.Name = "lbMemoryFree";
            this.lbMemoryFree.Size = new System.Drawing.Size(238, 19);
            this.lbMemoryFree.TabIndex = 2;
            this.lbMemoryFree.Text = "10000MB;12MB";
            this.lbMemoryFree.UseCustomForeColor = true;
            // 
            // nudHoldMemory
            // 
            this.nudHoldMemory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudHoldMemory.Location = new System.Drawing.Point(447, 10);
            this.nudHoldMemory.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.nudHoldMemory.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudHoldMemory.Name = "nudHoldMemory";
            this.nudHoldMemory.Size = new System.Drawing.Size(94, 25);
            this.nudHoldMemory.TabIndex = 3;
            this.nudHoldMemory.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.tableLayoutPanel3);
            this.metroPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(0, 90);
            this.metroPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(544, 90);
            this.metroPanel3.TabIndex = 3;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.btCalculate, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.metroLabel3, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.btStart, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btBurning, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.btColse, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.metroLabel4, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.metroToggle1, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.togAutoCal, 3, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(544, 90);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // btCalculate
            // 
            this.btCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btCalculate.BackColor = System.Drawing.Color.RoyalBlue;
            this.btCalculate.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btCalculate.Location = new System.Drawing.Point(3, 11);
            this.btCalculate.Name = "btCalculate";
            this.btCalculate.Size = new System.Drawing.Size(144, 23);
            this.btCalculate.TabIndex = 0;
            this.btCalculate.Text = "Calculate";
            this.btCalculate.UseCustomBackColor = true;
            this.btCalculate.UseCustomForeColor = true;
            this.btCalculate.UseSelectable = true;
            this.btCalculate.Click += new System.EventHandler(this.btCalculate_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.ForeColor = System.Drawing.Color.Black;
            this.metroLabel3.Location = new System.Drawing.Point(303, 13);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(154, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Run in Background";
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // btStart
            // 
            this.btStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btStart.BackColor = System.Drawing.Color.RoyalBlue;
            this.btStart.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btStart.Location = new System.Drawing.Point(153, 11);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(144, 23);
            this.btStart.TabIndex = 0;
            this.btStart.Text = "Start MemTest";
            this.btStart.UseCustomBackColor = true;
            this.btStart.UseCustomForeColor = true;
            this.btStart.UseSelectable = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // btBurning
            // 
            this.btBurning.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btBurning.BackColor = System.Drawing.Color.RoyalBlue;
            this.btBurning.Enabled = false;
            this.btBurning.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btBurning.Location = new System.Drawing.Point(3, 56);
            this.btBurning.Name = "btBurning";
            this.btBurning.Size = new System.Drawing.Size(144, 23);
            this.btBurning.TabIndex = 0;
            this.btBurning.Text = "Start Burning";
            this.btBurning.UseCustomBackColor = true;
            this.btBurning.UseCustomForeColor = true;
            this.btBurning.UseSelectable = true;
            this.btBurning.Click += new System.EventHandler(this.btBurning_Click);
            // 
            // btColse
            // 
            this.btColse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btColse.BackColor = System.Drawing.Color.RoyalBlue;
            this.btColse.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btColse.Location = new System.Drawing.Point(153, 56);
            this.btColse.Name = "btColse";
            this.btColse.Size = new System.Drawing.Size(144, 23);
            this.btColse.TabIndex = 0;
            this.btColse.Text = "Close MemTest";
            this.btColse.UseCustomBackColor = true;
            this.btColse.UseCustomForeColor = true;
            this.btColse.UseSelectable = true;
            this.btColse.Click += new System.EventHandler(this.btColse_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.ForeColor = System.Drawing.Color.Black;
            this.metroLabel4.Location = new System.Drawing.Point(303, 58);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(154, 19);
            this.metroLabel4.TabIndex = 2;
            this.metroLabel4.Text = "Auto Calculate";
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // metroToggle1
            // 
            this.metroToggle1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.metroToggle1.AutoSize = true;
            this.metroToggle1.Location = new System.Drawing.Point(463, 11);
            this.metroToggle1.Name = "metroToggle1";
            this.metroToggle1.Size = new System.Drawing.Size(78, 22);
            this.metroToggle1.TabIndex = 4;
            this.metroToggle1.Text = "Off";
            this.metroToggle1.UseSelectable = true;
            // 
            // togAutoCal
            // 
            this.togAutoCal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.togAutoCal.AutoSize = true;
            this.togAutoCal.Location = new System.Drawing.Point(463, 56);
            this.togAutoCal.Name = "togAutoCal";
            this.togAutoCal.Size = new System.Drawing.Size(78, 22);
            this.togAutoCal.TabIndex = 4;
            this.togAutoCal.Text = "Off";
            this.togAutoCal.UseSelectable = true;
            this.togAutoCal.CheckedChanged += new System.EventHandler(this.metroToggle2_CheckedChanged);
            // 
            // lvMemoryState
            // 
            this.lvMemoryState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvMemoryState.Location = new System.Drawing.Point(3, 183);
            this.lvMemoryState.Name = "lvMemoryState";
            this.lvMemoryState.Size = new System.Drawing.Size(538, 76);
            this.lvMemoryState.TabIndex = 4;
            this.lvMemoryState.UseCompatibleStateImageBehavior = false;
            // 
            // tabMonitor
            // 
            this.tabMonitor.Controls.Add(this.tableLayoutPanel4);
            this.tabMonitor.Font = new System.Drawing.Font("Consolas", 11F);
            this.tabMonitor.HorizontalScrollbarBarColor = true;
            this.tabMonitor.HorizontalScrollbarHighlightOnWheel = false;
            this.tabMonitor.HorizontalScrollbarSize = 10;
            this.tabMonitor.Location = new System.Drawing.Point(4, 38);
            this.tabMonitor.Name = "tabMonitor";
            this.tabMonitor.Size = new System.Drawing.Size(550, 265);
            this.tabMonitor.TabIndex = 1;
            this.tabMonitor.Text = "Monitor";
            this.tabMonitor.VerticalScrollbarBarColor = true;
            this.tabMonitor.VerticalScrollbarHighlightOnWheel = false;
            this.tabMonitor.VerticalScrollbarSize = 10;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.lvMonitorState, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btMStart, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.btMBurning, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.btMColse, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.lvMonitor, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.btMStopBurning, 0, 3);
            this.tableLayoutPanel4.ForeColor = System.Drawing.Color.White;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 6;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(547, 262);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // lvMonitorState
            // 
            this.tableLayoutPanel4.SetColumnSpan(this.lvMonitorState, 2);
            this.lvMonitorState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvMonitorState.Location = new System.Drawing.Point(3, 3);
            this.lvMonitorState.Name = "lvMonitorState";
            this.lvMonitorState.Size = new System.Drawing.Size(541, 54);
            this.lvMonitorState.TabIndex = 5;
            this.lvMonitorState.UseCompatibleStateImageBehavior = false;
            // 
            // btMStart
            // 
            this.btMStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btMStart.BackColor = System.Drawing.Color.RoyalBlue;
            this.btMStart.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btMStart.Location = new System.Drawing.Point(3, 71);
            this.btMStart.Name = "btMStart";
            this.btMStart.Size = new System.Drawing.Size(144, 23);
            this.btMStart.TabIndex = 1;
            this.btMStart.Text = "Start MemTest";
            this.btMStart.UseCustomBackColor = true;
            this.btMStart.UseCustomForeColor = true;
            this.btMStart.UseSelectable = true;
            this.btMStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // btMBurning
            // 
            this.btMBurning.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btMBurning.BackColor = System.Drawing.Color.RoyalBlue;
            this.btMBurning.Enabled = false;
            this.btMBurning.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btMBurning.Location = new System.Drawing.Point(3, 116);
            this.btMBurning.Name = "btMBurning";
            this.btMBurning.Size = new System.Drawing.Size(144, 23);
            this.btMBurning.TabIndex = 2;
            this.btMBurning.Text = "Start Burning";
            this.btMBurning.UseCustomBackColor = true;
            this.btMBurning.UseCustomForeColor = true;
            this.btMBurning.UseSelectable = true;
            this.btMBurning.Click += new System.EventHandler(this.btBurning_Click);
            // 
            // btMColse
            // 
            this.btMColse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btMColse.BackColor = System.Drawing.Color.RoyalBlue;
            this.btMColse.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btMColse.Location = new System.Drawing.Point(3, 206);
            this.btMColse.Name = "btMColse";
            this.btMColse.Size = new System.Drawing.Size(144, 23);
            this.btMColse.TabIndex = 3;
            this.btMColse.Text = "Close MemTest";
            this.btMColse.UseCustomBackColor = true;
            this.btMColse.UseCustomForeColor = true;
            this.btMColse.UseSelectable = true;
            this.btMColse.Click += new System.EventHandler(this.btColse_Click);
            // 
            // lvMonitor
            // 
            this.lvMonitor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvMonitor.Location = new System.Drawing.Point(153, 63);
            this.lvMonitor.Name = "lvMonitor";
            this.tableLayoutPanel4.SetRowSpan(this.lvMonitor, 5);
            this.lvMonitor.Size = new System.Drawing.Size(391, 196);
            this.lvMonitor.TabIndex = 4;
            this.lvMonitor.UseCompatibleStateImageBehavior = false;
            // 
            // btMStopBurning
            // 
            this.btMStopBurning.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btMStopBurning.BackColor = System.Drawing.Color.RoyalBlue;
            this.btMStopBurning.Enabled = false;
            this.btMStopBurning.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btMStopBurning.Location = new System.Drawing.Point(3, 161);
            this.btMStopBurning.Name = "btMStopBurning";
            this.btMStopBurning.Size = new System.Drawing.Size(144, 23);
            this.btMStopBurning.TabIndex = 3;
            this.btMStopBurning.Text = "Stop Burning";
            this.btMStopBurning.UseCustomBackColor = true;
            this.btMStopBurning.UseCustomForeColor = true;
            this.btMStopBurning.UseSelectable = true;
            this.btMStopBurning.Click += new System.EventHandler(this.btMSBurning_Click);
            // 
            // tabAdvanced
            // 
            this.tabAdvanced.Controls.Add(this.metroPanel4);
            this.tabAdvanced.Font = new System.Drawing.Font("Consolas", 11F);
            this.tabAdvanced.HorizontalScrollbarBarColor = true;
            this.tabAdvanced.HorizontalScrollbarHighlightOnWheel = false;
            this.tabAdvanced.HorizontalScrollbarSize = 10;
            this.tabAdvanced.Location = new System.Drawing.Point(4, 38);
            this.tabAdvanced.Margin = new System.Windows.Forms.Padding(1);
            this.tabAdvanced.Name = "tabAdvanced";
            this.tabAdvanced.Size = new System.Drawing.Size(550, 265);
            this.tabAdvanced.TabIndex = 2;
            this.tabAdvanced.Text = "Advanced";
            this.tabAdvanced.VerticalScrollbarBarColor = true;
            this.tabAdvanced.VerticalScrollbarHighlightOnWheel = false;
            this.tabAdvanced.VerticalScrollbarSize = 10;
            // 
            // metroPanel4
            // 
            this.metroPanel4.Controls.Add(this.tableLayoutPanel5);
            this.metroPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel4.HorizontalScrollbarBarColor = true;
            this.metroPanel4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel4.HorizontalScrollbarSize = 10;
            this.metroPanel4.Location = new System.Drawing.Point(0, 0);
            this.metroPanel4.Name = "metroPanel4";
            this.metroPanel4.Size = new System.Drawing.Size(550, 265);
            this.metroPanel4.TabIndex = 2;
            this.metroPanel4.VerticalScrollbarBarColor = true;
            this.metroPanel4.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel4.VerticalScrollbarSize = 10;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(544, 259);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // bgMemoryFree
            // 
            this.bgMemoryFree.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgMemoryFree_DoWork);
            this.bgMemoryFree.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgMemoryFree_ProgressChanged);
            // 
            // bgAutoCal
            // 
            this.bgAutoCal.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgAutoCal_DoWork);
            this.bgAutoCal.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgAutoCal_ProgressChanged);
            // 
            // bgMonitor
            // 
            this.bgMonitor.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgMonitor_DoWork);
            this.bgMonitor.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgMonitor_ProgressChanged);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(604, 393);
            this.Controls.Add(this.metroPanel1);
            this.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroTabControl1.ResumeLayout(false);
            this.tabSetting.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbMemory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbNumMemory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoldMemory)).EndInit();
            this.metroPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tabMonitor.ResumeLayout(false);
            this.tabMonitor.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tabAdvanced.ResumeLayout(false);
            this.metroPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage tabSetting;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroTabPage tabMonitor;
        private MetroFramework.Controls.MetroTabPage tabAdvanced;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lbMemoryFree;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private MetroFramework.Controls.MetroButton btCalculate;
        private MetroFramework.Controls.MetroButton btStart;
        private MetroFramework.Controls.MetroButton btBurning;
        private MetroFramework.Controls.MetroButton btColse;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroToggle metroToggle1;
        private MetroFramework.Controls.MetroToggle togAutoCal;
        private System.Windows.Forms.NumericUpDown nudHoldMemory;
        private System.ComponentModel.BackgroundWorker bgMemoryFree;
        private System.Windows.Forms.NumericUpDown nbNumMemory;
        private System.Windows.Forms.NumericUpDown nbMemory;
        private System.Windows.Forms.ListView lvMemoryState;
        private System.ComponentModel.BackgroundWorker bgAutoCal;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private MetroFramework.Controls.MetroButton btMStart;
        private MetroFramework.Controls.MetroButton btMBurning;
        private MetroFramework.Controls.MetroButton btMColse;
        private System.Windows.Forms.ListView lvMonitor;
        private System.ComponentModel.BackgroundWorker bgMonitor;
        private MetroFramework.Controls.MetroButton btMStopBurning;
        private System.Windows.Forms.ListView lvMonitorState;
        private MetroFramework.Controls.MetroPanel metroPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
    }
}

