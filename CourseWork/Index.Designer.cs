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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.dataGridMaintenance = new System.Windows.Forms.DataGridView();
            this.dataGridFailures = new System.Windows.Forms.DataGridView();
            this.dataGridSatellites = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridOperations = new System.Windows.Forms.DataGridView();
            this.dataGridOpResources = new System.Windows.Forms.DataGridView();
            this.tabControlMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartOperationsBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartStatusPie)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMaintenance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFailures)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSatellites)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOperations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOpResources)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPage1);
            this.tabControlMain.Controls.Add(this.tabPage2);
            this.tabControlMain.Controls.Add(this.tabPage3);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Font = new System.Drawing.Font("Aptos", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.Padding = new System.Drawing.Point(26, 6);
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1742, 954);
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
            this.tabPage1.Size = new System.Drawing.Size(1734, 910);
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
            chartArea3.Name = "ChartArea1";
            this.chartOperationsBar.ChartAreas.Add(chartArea3);
            legend3.Enabled = false;
            legend3.Font = new System.Drawing.Font("Aptos", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            legend3.IsTextAutoFit = false;
            legend3.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend3.Name = "Legend1";
            this.chartOperationsBar.Legends.Add(legend3);
            this.chartOperationsBar.Location = new System.Drawing.Point(24, 147);
            this.chartOperationsBar.Name = "chartOperationsBar";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartOperationsBar.Series.Add(series3);
            this.chartOperationsBar.Size = new System.Drawing.Size(953, 590);
            this.chartOperationsBar.TabIndex = 2;
            this.chartOperationsBar.Text = "chart1";
            // 
            // chartStatusPie
            // 
            chartArea4.Name = "ChartArea1";
            this.chartStatusPie.ChartAreas.Add(chartArea4);
            legend4.Enabled = false;
            legend4.Font = new System.Drawing.Font("Aptos", 8F);
            legend4.IsTextAutoFit = false;
            legend4.Name = "Legend1";
            this.chartStatusPie.Legends.Add(legend4);
            this.chartStatusPie.Location = new System.Drawing.Point(1003, 147);
            this.chartStatusPie.Name = "chartStatusPie";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartStatusPie.Series.Add(series4);
            this.chartStatusPie.Size = new System.Drawing.Size(694, 590);
            this.chartStatusPie.TabIndex = 1;
            this.chartStatusPie.Text = "chart1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.toolStrip1);
            this.tabPage2.Controls.Add(this.dataGridMaintenance);
            this.tabPage2.Controls.Add(this.dataGridFailures);
            this.tabPage2.Controls.Add(this.dataGridSatellites);
            this.tabPage2.Location = new System.Drawing.Point(4, 40);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1734, 910);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Спутники";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.toolStrip1.Size = new System.Drawing.Size(1728, 54);
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
            // 
            // btnEditMaintenance
            // 
            this.btnEditMaintenance.Name = "btnEditMaintenance";
            this.btnEditMaintenance.Size = new System.Drawing.Size(278, 30);
            this.btnEditMaintenance.Text = "Выбранное ТО";
            // 
            // btnEditFailure
            // 
            this.btnEditFailure.Name = "btnEditFailure";
            this.btnEditFailure.Size = new System.Drawing.Size(278, 30);
            this.btnEditFailure.Text = "Выбранный сбой";
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
            // 
            // btnDeleteFailure
            // 
            this.btnDeleteFailure.Name = "btnDeleteFailure";
            this.btnDeleteFailure.Size = new System.Drawing.Size(278, 30);
            this.btnDeleteFailure.Text = "Выбранный сбой";
            // 
            // dataGridMaintenance
            // 
            this.dataGridMaintenance.AllowUserToAddRows = false;
            this.dataGridMaintenance.AllowUserToDeleteRows = false;
            this.dataGridMaintenance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridMaintenance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridMaintenance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMaintenance.Location = new System.Drawing.Point(1104, 485);
            this.dataGridMaintenance.Name = "dataGridMaintenance";
            this.dataGridMaintenance.ReadOnly = true;
            this.dataGridMaintenance.RowHeadersWidth = 51;
            this.dataGridMaintenance.RowTemplate.Height = 24;
            this.dataGridMaintenance.Size = new System.Drawing.Size(622, 417);
            this.dataGridMaintenance.TabIndex = 5;
            // 
            // dataGridFailures
            // 
            this.dataGridFailures.AllowUserToAddRows = false;
            this.dataGridFailures.AllowUserToDeleteRows = false;
            this.dataGridFailures.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridFailures.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridFailures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFailures.Location = new System.Drawing.Point(1104, 60);
            this.dataGridFailures.Name = "dataGridFailures";
            this.dataGridFailures.ReadOnly = true;
            this.dataGridFailures.RowHeadersWidth = 51;
            this.dataGridFailures.RowTemplate.Height = 24;
            this.dataGridFailures.Size = new System.Drawing.Size(622, 419);
            this.dataGridFailures.TabIndex = 4;
            // 
            // dataGridSatellites
            // 
            this.dataGridSatellites.AllowUserToAddRows = false;
            this.dataGridSatellites.AllowUserToDeleteRows = false;
            this.dataGridSatellites.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridSatellites.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridSatellites.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSatellites.Location = new System.Drawing.Point(9, 60);
            this.dataGridSatellites.Name = "dataGridSatellites";
            this.dataGridSatellites.ReadOnly = true;
            this.dataGridSatellites.RowHeadersWidth = 51;
            this.dataGridSatellites.RowTemplate.Height = 24;
            this.dataGridSatellites.Size = new System.Drawing.Size(1089, 842);
            this.dataGridSatellites.TabIndex = 3;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.splitContainer1);
            this.tabPage3.Location = new System.Drawing.Point(4, 40);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1734, 910);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Операции";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridOperations);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridOpResources);
            this.splitContainer1.Size = new System.Drawing.Size(1734, 910);
            this.splitContainer1.SplitterDistance = 834;
            this.splitContainer1.TabIndex = 0;
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
            this.dataGridOperations.Size = new System.Drawing.Size(834, 910);
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
            this.dataGridOpResources.Size = new System.Drawing.Size(896, 910);
            this.dataGridOpResources.TabIndex = 0;
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1742, 954);
            this.Controls.Add(this.tabControlMain);
            this.Name = "Index";
            this.Text = "Спутниковая связь и космическая навигация";
            this.tabControlMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartOperationsBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartStatusPie)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMaintenance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFailures)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSatellites)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOperations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOpResources)).EndInit();
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
        private SplitContainer splitContainer1;
        private DataGridView dataGridOperations;
        private DataGridView dataGridOpResources;
    }
}

