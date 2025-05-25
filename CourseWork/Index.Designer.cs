using System.Windows.Forms;

namespace CourseWork
{
    partial class Index
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Index));
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCriticalFailures = new System.Windows.Forms.Label();
            this.labelActiveOperations = new System.Windows.Forms.Label();
            this.labelTotalSatellites = new System.Windows.Forms.Label();
            this.chartOperationsBar = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartStatusPie = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dataGridSatellites = new System.Windows.Forms.DataGridView();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.dataGridFailures = new System.Windows.Forms.DataGridView();
            this.dataGridMaintenance = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.dropdownSatellite = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnAddSatellite = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddMaintenance = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddFailure = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnEditSatellite = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEditMaintenance = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEditFailure = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnDeleteSatillite = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeleteMaintenence = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeleteFailure = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toos = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnAddHQ = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddOperation = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddOpResources = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton5 = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnEditHQ = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEditOperation = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEditOpResources = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnDeleteHQ = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeleteOperation = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeleteOpResources = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridHQ = new System.Windows.Forms.DataGridView();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.dataGridOperations = new System.Windows.Forms.DataGridView();
            this.dataGridOpResources = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.dropdownOtherTables = new System.Windows.Forms.ToolStripComboBox();
            this.btnAddDynamic = new System.Windows.Forms.ToolStripButton();
            this.btnEditDynamic = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteDynamic = new System.Windows.Forms.ToolStripButton();
            this.tabControlMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartOperationsBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartStatusPie)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSatellites)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFailures)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMaintenance)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOperations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOpResources)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPage1);
            this.tabControlMain.Controls.Add(this.tabPage2);
            this.tabControlMain.Controls.Add(this.tabPage3);
            this.tabControlMain.Controls.Add(this.tabPage4);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Font = new System.Drawing.Font("Aptos", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.Padding = new System.Drawing.Point(26, 6);
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1599, 654);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.labelCriticalFailures);
            this.tabPage1.Controls.Add(this.labelActiveOperations);
            this.tabPage1.Controls.Add(this.labelTotalSatellites);
            this.tabPage1.Controls.Add(this.chartOperationsBar);
            this.tabPage1.Controls.Add(this.chartStatusPie);
            this.tabPage1.Location = new System.Drawing.Point(4, 40);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1591, 610);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Главная";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Aptos", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(998, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(300, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "Кол-во спутников по типам:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Aptos", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(19, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(307, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Кол-во операций по статусу:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Aptos", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(608, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Критические сбои:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Aptos", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(334, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Активные операции:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Aptos", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(19, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Общее число спутников:";
            // 
            // labelCriticalFailures
            // 
            this.labelCriticalFailures.AutoSize = true;
            this.labelCriticalFailures.Font = new System.Drawing.Font("Aptos ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCriticalFailures.Location = new System.Drawing.Point(606, 45);
            this.labelCriticalFailures.Name = "labelCriticalFailures";
            this.labelCriticalFailures.Size = new System.Drawing.Size(98, 38);
            this.labelCriticalFailures.TabIndex = 5;
            this.labelCriticalFailures.Text = "count";
            // 
            // labelActiveOperations
            // 
            this.labelActiveOperations.AutoSize = true;
            this.labelActiveOperations.Font = new System.Drawing.Font("Aptos ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelActiveOperations.Location = new System.Drawing.Point(332, 45);
            this.labelActiveOperations.Name = "labelActiveOperations";
            this.labelActiveOperations.Size = new System.Drawing.Size(98, 38);
            this.labelActiveOperations.TabIndex = 4;
            this.labelActiveOperations.Text = "count";
            // 
            // labelTotalSatellites
            // 
            this.labelTotalSatellites.AutoSize = true;
            this.labelTotalSatellites.Font = new System.Drawing.Font("Aptos ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTotalSatellites.Location = new System.Drawing.Point(17, 45);
            this.labelTotalSatellites.Name = "labelTotalSatellites";
            this.labelTotalSatellites.Size = new System.Drawing.Size(98, 38);
            this.labelTotalSatellites.TabIndex = 3;
            this.labelTotalSatellites.Text = "count";
            // 
            // chartOperationsBar
            // 
            chartArea9.Name = "ChartArea1";
            this.chartOperationsBar.ChartAreas.Add(chartArea9);
            legend9.Enabled = false;
            legend9.Font = new System.Drawing.Font("Aptos", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            legend9.IsTextAutoFit = false;
            legend9.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend9.Name = "Legend1";
            this.chartOperationsBar.Legends.Add(legend9);
            this.chartOperationsBar.Location = new System.Drawing.Point(24, 147);
            this.chartOperationsBar.Name = "chartOperationsBar";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series9.Legend = "Legend1";
            series9.Name = "Series1";
            this.chartOperationsBar.Series.Add(series9);
            this.chartOperationsBar.Size = new System.Drawing.Size(953, 590);
            this.chartOperationsBar.TabIndex = 2;
            this.chartOperationsBar.Text = "chart1";
            // 
            // chartStatusPie
            // 
            chartArea10.Name = "ChartArea1";
            this.chartStatusPie.ChartAreas.Add(chartArea10);
            legend10.Enabled = false;
            legend10.Font = new System.Drawing.Font("Aptos", 8F);
            legend10.IsTextAutoFit = false;
            legend10.Name = "Legend1";
            this.chartStatusPie.Legends.Add(legend10);
            this.chartStatusPie.Location = new System.Drawing.Point(1003, 147);
            this.chartStatusPie.Name = "chartStatusPie";
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series10.Legend = "Legend1";
            series10.Name = "Series1";
            this.chartStatusPie.Series.Add(series10);
            this.chartStatusPie.Size = new System.Drawing.Size(694, 590);
            this.chartStatusPie.TabIndex = 1;
            this.chartStatusPie.Text = "chart1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer2);
            this.tabPage2.Controls.Add(this.toolStrip1);
            this.tabPage2.Location = new System.Drawing.Point(4, 40);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1591, 610);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Спутники";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 57);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dataGridSatellites);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(1585, 550);
            this.splitContainer2.SplitterDistance = 788;
            this.splitContainer2.TabIndex = 10;
            // 
            // dataGridSatellites
            // 
            this.dataGridSatellites.AllowUserToAddRows = false;
            this.dataGridSatellites.AllowUserToDeleteRows = false;
            this.dataGridSatellites.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridSatellites.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSatellites.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridSatellites.Location = new System.Drawing.Point(0, 0);
            this.dataGridSatellites.Name = "dataGridSatellites";
            this.dataGridSatellites.ReadOnly = true;
            this.dataGridSatellites.RowHeadersWidth = 51;
            this.dataGridSatellites.RowTemplate.Height = 24;
            this.dataGridSatellites.Size = new System.Drawing.Size(788, 550);
            this.dataGridSatellites.TabIndex = 3;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.dataGridFailures);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.dataGridMaintenance);
            this.splitContainer3.Size = new System.Drawing.Size(793, 550);
            this.splitContainer3.SplitterDistance = 253;
            this.splitContainer3.TabIndex = 0;
            // 
            // dataGridFailures
            // 
            this.dataGridFailures.AllowUserToAddRows = false;
            this.dataGridFailures.AllowUserToDeleteRows = false;
            this.dataGridFailures.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridFailures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFailures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridFailures.Location = new System.Drawing.Point(0, 0);
            this.dataGridFailures.Name = "dataGridFailures";
            this.dataGridFailures.ReadOnly = true;
            this.dataGridFailures.RowHeadersWidth = 51;
            this.dataGridFailures.RowTemplate.Height = 24;
            this.dataGridFailures.Size = new System.Drawing.Size(793, 253);
            this.dataGridFailures.TabIndex = 4;
            // 
            // dataGridMaintenance
            // 
            this.dataGridMaintenance.AllowUserToAddRows = false;
            this.dataGridMaintenance.AllowUserToDeleteRows = false;
            this.dataGridMaintenance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridMaintenance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMaintenance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridMaintenance.Location = new System.Drawing.Point(0, 0);
            this.dataGridMaintenance.Name = "dataGridMaintenance";
            this.dataGridMaintenance.ReadOnly = true;
            this.dataGridMaintenance.RowHeadersWidth = 51;
            this.dataGridMaintenance.RowTemplate.Height = 24;
            this.dataGridMaintenance.Size = new System.Drawing.Size(793, 293);
            this.dataGridMaintenance.TabIndex = 5;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dropdownSatellite,
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1585, 54);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // dropdownSatellite
            // 
            this.dropdownSatellite.BackColor = System.Drawing.Color.Transparent;
            this.dropdownSatellite.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.dropdownSatellite.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddSatellite,
            this.btnAddMaintenance,
            this.btnAddFailure});
            this.dropdownSatellite.Font = new System.Drawing.Font("Aptos", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dropdownSatellite.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.dropdownSatellite.Name = "dropdownSatellite";
            this.dropdownSatellite.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.dropdownSatellite.ShowDropDownArrow = false;
            this.dropdownSatellite.Size = new System.Drawing.Size(134, 51);
            this.dropdownSatellite.Text = "Добавить";
            // 
            // btnAddSatellite
            // 
            this.btnAddSatellite.Name = "btnAddSatellite";
            this.btnAddSatellite.Size = new System.Drawing.Size(233, 30);
            this.btnAddSatellite.Text = "Новый спутник";
            this.btnAddSatellite.Click += new System.EventHandler(this.btnAddSatellite_Click);
            // 
            // btnAddMaintenance
            // 
            this.btnAddMaintenance.Name = "btnAddMaintenance";
            this.btnAddMaintenance.Size = new System.Drawing.Size(233, 30);
            this.btnAddMaintenance.Text = "Новое ТО";
            this.btnAddMaintenance.Click += new System.EventHandler(this.btnAddMaintenance_Click);
            // 
            // btnAddFailure
            // 
            this.btnAddFailure.Name = "btnAddFailure";
            this.btnAddFailure.Size = new System.Drawing.Size(233, 30);
            this.btnAddFailure.Text = "Новый сбой";
            this.btnAddFailure.Click += new System.EventHandler(this.btnAddFailure_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEditSatellite,
            this.btnEditMaintenance,
            this.btnEditFailure});
            this.toolStripDropDownButton1.Font = new System.Drawing.Font("Aptos", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.toolStripDropDownButton1.ShowDropDownArrow = false;
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(184, 51);
            this.toolStripDropDownButton1.Text = "Редактировать";
            // 
            // btnEditSatellite
            // 
            this.btnEditSatellite.Name = "btnEditSatellite";
            this.btnEditSatellite.Size = new System.Drawing.Size(278, 30);
            this.btnEditSatellite.Text = "Выбранный спутник";
            this.btnEditSatellite.Click += new System.EventHandler(this.btnEditSatellite_Click);
            // 
            // btnEditMaintenance
            // 
            this.btnEditMaintenance.Name = "btnEditMaintenance";
            this.btnEditMaintenance.Size = new System.Drawing.Size(278, 30);
            this.btnEditMaintenance.Text = "Выбранное ТО";
            this.btnEditMaintenance.Click += new System.EventHandler(this.btnEditMaintenance_Click);
            // 
            // btnEditFailure
            // 
            this.btnEditFailure.Name = "btnEditFailure";
            this.btnEditFailure.Size = new System.Drawing.Size(278, 30);
            this.btnEditFailure.Text = "Выбранный сбой";
            this.btnEditFailure.Click += new System.EventHandler(this.btnEditFailure_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDeleteSatillite,
            this.btnDeleteMaintenence,
            this.btnDeleteFailure});
            this.toolStripDropDownButton2.Font = new System.Drawing.Font("Aptos", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.toolStripDropDownButton2.ShowDropDownArrow = false;
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(120, 51);
            this.toolStripDropDownButton2.Text = "Удалить";
            // 
            // btnDeleteSatillite
            // 
            this.btnDeleteSatillite.Name = "btnDeleteSatillite";
            this.btnDeleteSatillite.Size = new System.Drawing.Size(278, 30);
            this.btnDeleteSatillite.Text = "Выбранный спутник";
            this.btnDeleteSatillite.Click += new System.EventHandler(this.btnDeleteSatellite_Click);
            // 
            // btnDeleteMaintenence
            // 
            this.btnDeleteMaintenence.Name = "btnDeleteMaintenence";
            this.btnDeleteMaintenence.Size = new System.Drawing.Size(278, 30);
            this.btnDeleteMaintenence.Text = "Выбранное ТО";
            this.btnDeleteMaintenence.Click += new System.EventHandler(this.btnDeleteMaintenance_Click);
            // 
            // btnDeleteFailure
            // 
            this.btnDeleteFailure.Name = "btnDeleteFailure";
            this.btnDeleteFailure.Size = new System.Drawing.Size(278, 30);
            this.btnDeleteFailure.Text = "Выбранный сбой";
            this.btnDeleteFailure.Click += new System.EventHandler(this.btnDeleteFailure_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.toolStrip2);
            this.tabPage3.Controls.Add(this.splitContainer1);
            this.tabPage3.Location = new System.Drawing.Point(4, 40);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1591, 610);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Штабы";
            // 
            // toolStrip2
            // 
            this.toolStrip2.AutoSize = false;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toos,
            this.toolStripDropDownButton5,
            this.toolStripDropDownButton3});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1591, 54);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toos
            // 
            this.toos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddHQ,
            this.btnAddOperation,
            this.btnAddOpResources});
            this.toos.Font = new System.Drawing.Font("Aptos", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toos.Image = ((System.Drawing.Image)(resources.GetObject("toos.Image")));
            this.toos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toos.Name = "toos";
            this.toos.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.toos.ShowDropDownArrow = false;
            this.toos.Size = new System.Drawing.Size(134, 51);
            this.toos.Text = "Добавить";
            // 
            // btnAddHQ
            // 
            this.btnAddHQ.Name = "btnAddHQ";
            this.btnAddHQ.Size = new System.Drawing.Size(282, 30);
            this.btnAddHQ.Text = "Новый штаб";
            // 
            // btnAddOperation
            // 
            this.btnAddOperation.Name = "btnAddOperation";
            this.btnAddOperation.Size = new System.Drawing.Size(282, 30);
            this.btnAddOperation.Text = "Операцию к штабу";
            // 
            // btnAddOpResources
            // 
            this.btnAddOpResources.Name = "btnAddOpResources";
            this.btnAddOpResources.Size = new System.Drawing.Size(282, 30);
            this.btnAddOpResources.Text = "Ресурсы к операции";
            // 
            // toolStripDropDownButton5
            // 
            this.toolStripDropDownButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEditHQ,
            this.btnEditOperation,
            this.btnEditOpResources});
            this.toolStripDropDownButton5.Font = new System.Drawing.Font("Aptos", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripDropDownButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton5.Image")));
            this.toolStripDropDownButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton5.Name = "toolStripDropDownButton5";
            this.toolStripDropDownButton5.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.toolStripDropDownButton5.ShowDropDownArrow = false;
            this.toolStripDropDownButton5.Size = new System.Drawing.Size(184, 51);
            this.toolStripDropDownButton5.Text = "Редактировать";
            // 
            // btnEditHQ
            // 
            this.btnEditHQ.Name = "btnEditHQ";
            this.btnEditHQ.Size = new System.Drawing.Size(301, 30);
            this.btnEditHQ.Text = "Выбранный штаб";
            // 
            // btnEditOperation
            // 
            this.btnEditOperation.Name = "btnEditOperation";
            this.btnEditOperation.Size = new System.Drawing.Size(301, 30);
            this.btnEditOperation.Text = "Выбранную операцию";
            // 
            // btnEditOpResources
            // 
            this.btnEditOpResources.Name = "btnEditOpResources";
            this.btnEditOpResources.Size = new System.Drawing.Size(301, 30);
            this.btnEditOpResources.Text = "Выбранные ресурсы";
            // 
            // toolStripDropDownButton3
            // 
            this.toolStripDropDownButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDeleteHQ,
            this.btnDeleteOperation,
            this.btnDeleteOpResources});
            this.toolStripDropDownButton3.Font = new System.Drawing.Font("Aptos", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripDropDownButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton3.Image")));
            this.toolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton3.Name = "toolStripDropDownButton3";
            this.toolStripDropDownButton3.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.toolStripDropDownButton3.ShowDropDownArrow = false;
            this.toolStripDropDownButton3.Size = new System.Drawing.Size(120, 51);
            this.toolStripDropDownButton3.Text = "Удалить";
            // 
            // btnDeleteHQ
            // 
            this.btnDeleteHQ.Name = "btnDeleteHQ";
            this.btnDeleteHQ.Size = new System.Drawing.Size(301, 30);
            this.btnDeleteHQ.Text = "Выбранный штаб";
            // 
            // btnDeleteOperation
            // 
            this.btnDeleteOperation.Name = "btnDeleteOperation";
            this.btnDeleteOperation.Size = new System.Drawing.Size(301, 30);
            this.btnDeleteOperation.Text = "Выбранную операцию";
            // 
            // btnDeleteOpResources
            // 
            this.btnDeleteOpResources.Name = "btnDeleteOpResources";
            this.btnDeleteOpResources.Size = new System.Drawing.Size(301, 30);
            this.btnDeleteOpResources.Text = "Выбранные ресурсы";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(4, 57);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridHQ);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer1.Size = new System.Drawing.Size(1584, 550);
            this.splitContainer1.SplitterDistance = 420;
            this.splitContainer1.TabIndex = 0;
            // 
            // dataGridHQ
            // 
            this.dataGridHQ.AllowUserToAddRows = false;
            this.dataGridHQ.AllowUserToDeleteRows = false;
            this.dataGridHQ.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridHQ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHQ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridHQ.Location = new System.Drawing.Point(0, 0);
            this.dataGridHQ.Name = "dataGridHQ";
            this.dataGridHQ.ReadOnly = true;
            this.dataGridHQ.RowHeadersWidth = 51;
            this.dataGridHQ.RowTemplate.Height = 24;
            this.dataGridHQ.Size = new System.Drawing.Size(420, 550);
            this.dataGridHQ.TabIndex = 1;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.dataGridOperations);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.dataGridOpResources);
            this.splitContainer4.Size = new System.Drawing.Size(1160, 550);
            this.splitContainer4.SplitterDistance = 300;
            this.splitContainer4.TabIndex = 0;
            // 
            // dataGridOperations
            // 
            this.dataGridOperations.AllowUserToAddRows = false;
            this.dataGridOperations.AllowUserToDeleteRows = false;
            this.dataGridOperations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridOperations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOperations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridOperations.Location = new System.Drawing.Point(0, 0);
            this.dataGridOperations.Name = "dataGridOperations";
            this.dataGridOperations.ReadOnly = true;
            this.dataGridOperations.RowHeadersWidth = 51;
            this.dataGridOperations.RowTemplate.Height = 24;
            this.dataGridOperations.Size = new System.Drawing.Size(1160, 300);
            this.dataGridOperations.TabIndex = 0;
            // 
            // dataGridOpResources
            // 
            this.dataGridOpResources.AllowUserToAddRows = false;
            this.dataGridOpResources.AllowUserToDeleteRows = false;
            this.dataGridOpResources.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridOpResources.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOpResources.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridOpResources.Location = new System.Drawing.Point(0, 0);
            this.dataGridOpResources.Name = "dataGridOpResources";
            this.dataGridOpResources.ReadOnly = true;
            this.dataGridOpResources.RowHeadersWidth = 51;
            this.dataGridOpResources.RowTemplate.Height = 24;
            this.dataGridOpResources.Size = new System.Drawing.Size(1160, 246);
            this.dataGridOpResources.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridView1);
            this.tabPage4.Controls.Add(this.toolStrip3);
            this.tabPage4.Location = new System.Drawing.Point(4, 40);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1591, 610);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Остальное";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1585, 550);
            this.dataGridView1.TabIndex = 3;
            // 
            // toolStrip3
            // 
            this.toolStrip3.AutoSize = false;
            this.toolStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dropdownOtherTables,
            this.btnAddDynamic,
            this.btnEditDynamic,
            this.btnDeleteDynamic});
            this.toolStrip3.Location = new System.Drawing.Point(3, 3);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(1585, 54);
            this.toolStrip3.TabIndex = 2;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // dropdownOtherTables
            // 
            this.dropdownOtherTables.Font = new System.Drawing.Font("Aptos", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dropdownOtherTables.Name = "dropdownOtherTables";
            this.dropdownOtherTables.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.dropdownOtherTables.Size = new System.Drawing.Size(649, 54);
            // 
            // btnAddDynamic
            // 
            this.btnAddDynamic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAddDynamic.Font = new System.Drawing.Font("Aptos", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddDynamic.Image = ((System.Drawing.Image)(resources.GetObject("btnAddDynamic.Image")));
            this.btnAddDynamic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddDynamic.Name = "btnAddDynamic";
            this.btnAddDynamic.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.btnAddDynamic.Size = new System.Drawing.Size(134, 51);
            this.btnAddDynamic.Text = "Добавить";
            // 
            // btnEditDynamic
            // 
            this.btnEditDynamic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnEditDynamic.Font = new System.Drawing.Font("Aptos", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditDynamic.Image = ((System.Drawing.Image)(resources.GetObject("btnEditDynamic.Image")));
            this.btnEditDynamic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditDynamic.Name = "btnEditDynamic";
            this.btnEditDynamic.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.btnEditDynamic.Size = new System.Drawing.Size(184, 51);
            this.btnEditDynamic.Text = "Редактировать";
            // 
            // btnDeleteDynamic
            // 
            this.btnDeleteDynamic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnDeleteDynamic.Font = new System.Drawing.Font("Aptos", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteDynamic.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteDynamic.Image")));
            this.btnDeleteDynamic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteDynamic.Name = "btnDeleteDynamic";
            this.btnDeleteDynamic.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.btnDeleteDynamic.Size = new System.Drawing.Size(120, 51);
            this.btnDeleteDynamic.Text = "Удалить";
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1599, 654);
            this.Controls.Add(this.tabControlMain);
            this.Name = "Index";
            this.Text = "Спутниковая связь и космическая навигация";
            this.tabControlMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartOperationsBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartStatusPie)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSatellites)).EndInit();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFailures)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMaintenance)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHQ)).EndInit();
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOperations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOpResources)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStatusPie;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartOperationsBar;
        private System.Windows.Forms.Label labelCriticalFailures;
        private System.Windows.Forms.Label labelActiveOperations;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTotalSatellites;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridMaintenance;
        private System.Windows.Forms.DataGridView dataGridFailures;
        private System.Windows.Forms.DataGridView dataGridSatellites;
        private TabPage tabPage3;
        private SplitContainer splitContainer1;
        private DataGridView dataGridOperations;
        private DataGridView dataGridOpResources;
        private SplitContainer splitContainer2;
        private SplitContainer splitContainer3;
        private ToolStrip toolStrip1;
        private ToolStripDropDownButton dropdownSatellite;
        private ToolStripMenuItem btnAddSatellite;
        private ToolStripMenuItem btnAddMaintenance;
        private ToolStripMenuItem btnAddFailure;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem btnEditSatellite;
        private ToolStripMenuItem btnEditMaintenance;
        private ToolStripMenuItem btnEditFailure;
        private ToolStripDropDownButton toolStripDropDownButton2;
        private ToolStripMenuItem btnDeleteSatillite;
        private ToolStripMenuItem btnDeleteMaintenence;
        private ToolStripMenuItem btnDeleteFailure;
        private ToolStrip toolStrip2;
        private TabPage tabPage4;
        private SplitContainer splitContainer4;
        private DataGridView dataGridHQ;
        private ToolStripDropDownButton toolStripDropDownButton3;
        private ToolStripMenuItem btnDeleteHQ;
        private ToolStripMenuItem btnDeleteOperation;
        private ToolStripMenuItem btnDeleteOpResources;
        private ToolStripDropDownButton toos;
        private ToolStripMenuItem btnAddHQ;
        private ToolStripMenuItem btnAddOperation;
        private ToolStripMenuItem btnAddOpResources;
        private ToolStripDropDownButton toolStripDropDownButton5;
        private ToolStripMenuItem btnEditHQ;
        private ToolStripMenuItem btnEditOperation;
        private ToolStripMenuItem btnEditOpResources;
        private ToolStrip toolStrip3;
        private ToolStripButton btnDeleteDynamic;
        private ToolStripComboBox dropdownOtherTables;
        private ToolStripButton btnAddDynamic;
        private ToolStripButton btnEditDynamic;
        private DataGridView dataGridView1;
    }
}

