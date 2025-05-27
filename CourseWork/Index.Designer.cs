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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Index));
            this.tabControlMain = new System.Windows.Forms.TabControl();
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
            this.dataGridDynamic = new System.Windows.Forms.DataGridView();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.dropdownOtherTables = new System.Windows.Forms.ToolStripComboBox();
            this.btnAddDynamic = new System.Windows.Forms.ToolStripButton();
            this.btnEditDynamic = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteDynamic = new System.Windows.Forms.ToolStripButton();
            this.tabControlMain.SuspendLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDynamic)).BeginInit();
            this.toolStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
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
            this.btnAddHQ.Click += new System.EventHandler(this.btnAddHQ_Click);
            // 
            // btnAddOperation
            // 
            this.btnAddOperation.Name = "btnAddOperation";
            this.btnAddOperation.Size = new System.Drawing.Size(282, 30);
            this.btnAddOperation.Text = "Операцию к штабу";
            this.btnAddOperation.Click += new System.EventHandler(this.btnAddOperation_Click);
            // 
            // btnAddOpResources
            // 
            this.btnAddOpResources.Name = "btnAddOpResources";
            this.btnAddOpResources.Size = new System.Drawing.Size(282, 30);
            this.btnAddOpResources.Text = "Ресурсы к операции";
            this.btnAddOpResources.Click += new System.EventHandler(this.btnAddOpResource_Click);
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
            this.btnEditHQ.Click += new System.EventHandler(this.btnEditHQ_Click);
            // 
            // btnEditOperation
            // 
            this.btnEditOperation.Name = "btnEditOperation";
            this.btnEditOperation.Size = new System.Drawing.Size(301, 30);
            this.btnEditOperation.Text = "Выбранную операцию";
            this.btnEditOperation.Click += new System.EventHandler(this.btnEditOperation_Click);
            // 
            // btnEditOpResources
            // 
            this.btnEditOpResources.Name = "btnEditOpResources";
            this.btnEditOpResources.Size = new System.Drawing.Size(301, 30);
            this.btnEditOpResources.Text = "Выбранные ресурсы";
            this.btnEditOpResources.Click += new System.EventHandler(this.btnEditOpResources_Click);
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
            this.btnDeleteHQ.Click += new System.EventHandler(this.btnDeleteHQ_Click);
            // 
            // btnDeleteOperation
            // 
            this.btnDeleteOperation.Name = "btnDeleteOperation";
            this.btnDeleteOperation.Size = new System.Drawing.Size(301, 30);
            this.btnDeleteOperation.Text = "Выбранную операцию";
            this.btnDeleteOperation.Click += new System.EventHandler(this.btnDeleteOperation_Click);
            // 
            // btnDeleteOpResources
            // 
            this.btnDeleteOpResources.Name = "btnDeleteOpResources";
            this.btnDeleteOpResources.Size = new System.Drawing.Size(301, 30);
            this.btnDeleteOpResources.Text = "Выбранные ресурсы";
            this.btnDeleteOpResources.Click += new System.EventHandler(this.btnDeleteResource_Click);
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
            this.tabPage4.Controls.Add(this.dataGridDynamic);
            this.tabPage4.Controls.Add(this.toolStrip3);
            this.tabPage4.Location = new System.Drawing.Point(4, 40);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1591, 610);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Остальное";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridDynamic
            // 
            this.dataGridDynamic.AllowUserToAddRows = false;
            this.dataGridDynamic.AllowUserToDeleteRows = false;
            this.dataGridDynamic.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridDynamic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDynamic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridDynamic.Location = new System.Drawing.Point(3, 57);
            this.dataGridDynamic.Name = "dataGridDynamic";
            this.dataGridDynamic.ReadOnly = true;
            this.dataGridDynamic.RowHeadersWidth = 51;
            this.dataGridDynamic.Size = new System.Drawing.Size(1585, 550);
            this.dataGridDynamic.TabIndex = 3;
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
            this.dropdownOtherTables.Padding = new System.Windows.Forms.Padding(0, 0, 16, 0);
            this.dropdownOtherTables.Size = new System.Drawing.Size(505, 54);
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
            this.btnAddDynamic.Click += new System.EventHandler(this.BtnAddDynamic_Click);
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
            this.btnEditDynamic.Click += new System.EventHandler(this.BtnEditDynamic_Click);
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
            this.btnDeleteDynamic.Click += new System.EventHandler(this.BtnDeleteDynamic_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDynamic)).EndInit();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPage2;
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
        private DataGridView dataGridDynamic;
    }
}

