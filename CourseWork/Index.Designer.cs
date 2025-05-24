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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend11 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend12 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnNewFailure = new System.Windows.Forms.Button();
            this.btnNewOperation = new System.Windows.Forms.Button();
            this.btnNewSatelite = new System.Windows.Forms.Button();
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
            this.dataGridMaintenance = new System.Windows.Forms.DataGridView();
            this.dataGridFailures = new System.Windows.Forms.DataGridView();
            this.dataGridSatellites = new System.Windows.Forms.DataGridView();
            this.btnEditSatellite = new System.Windows.Forms.Button();
            this.btnDeleteSatellite = new System.Windows.Forms.Button();
            this.btnAddSatellite = new System.Windows.Forms.Button();
            this.tabControlMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartOperationsBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartStatusPie)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMaintenance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFailures)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSatellites)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPage1);
            this.tabControlMain.Controls.Add(this.tabPage2);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Font = new System.Drawing.Font("Aptos", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.Padding = new System.Drawing.Point(26, 6);
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1577, 787);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.btnNewFailure);
            this.tabPage1.Controls.Add(this.btnNewOperation);
            this.tabPage1.Controls.Add(this.btnNewSatelite);
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
            this.tabPage1.Size = new System.Drawing.Size(1333, 743);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Главная";
            // 
            // btnNewFailure
            // 
            this.btnNewFailure.BackColor = System.Drawing.Color.MistyRose;
            this.btnNewFailure.Font = new System.Drawing.Font("Aptos", 16F);
            this.btnNewFailure.Location = new System.Drawing.Point(671, 659);
            this.btnNewFailure.Name = "btnNewFailure";
            this.btnNewFailure.Size = new System.Drawing.Size(246, 71);
            this.btnNewFailure.TabIndex = 13;
            this.btnNewFailure.Text = "Отметить сбой";
            this.btnNewFailure.UseVisualStyleBackColor = false;
            // 
            // btnNewOperation
            // 
            this.btnNewOperation.BackColor = System.Drawing.Color.Azure;
            this.btnNewOperation.Font = new System.Drawing.Font("Aptos", 16F);
            this.btnNewOperation.Location = new System.Drawing.Point(328, 659);
            this.btnNewOperation.Name = "btnNewOperation";
            this.btnNewOperation.Size = new System.Drawing.Size(328, 71);
            this.btnNewOperation.TabIndex = 12;
            this.btnNewOperation.Text = "Добавить операцию";
            this.btnNewOperation.UseVisualStyleBackColor = false;
            // 
            // btnNewSatelite
            // 
            this.btnNewSatelite.BackColor = System.Drawing.Color.Azure;
            this.btnNewSatelite.Font = new System.Drawing.Font("Aptos", 16F);
            this.btnNewSatelite.Location = new System.Drawing.Point(24, 659);
            this.btnNewSatelite.Name = "btnNewSatelite";
            this.btnNewSatelite.Size = new System.Drawing.Size(289, 71);
            this.btnNewSatelite.TabIndex = 11;
            this.btnNewSatelite.Text = "Добавить спутник";
            this.btnNewSatelite.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Aptos", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(761, 109);
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
            chartArea11.Name = "ChartArea1";
            this.chartOperationsBar.ChartAreas.Add(chartArea11);
            legend11.Enabled = false;
            legend11.Font = new System.Drawing.Font("Aptos", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            legend11.IsTextAutoFit = false;
            legend11.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend11.Name = "Legend1";
            this.chartOperationsBar.Legends.Add(legend11);
            this.chartOperationsBar.Location = new System.Drawing.Point(24, 147);
            this.chartOperationsBar.Name = "chartOperationsBar";
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series11.Legend = "Legend1";
            series11.Name = "Series1";
            this.chartOperationsBar.Series.Add(series11);
            this.chartOperationsBar.Size = new System.Drawing.Size(716, 497);
            this.chartOperationsBar.TabIndex = 2;
            this.chartOperationsBar.Text = "chart1";
            // 
            // chartStatusPie
            // 
            chartArea12.Name = "ChartArea1";
            this.chartStatusPie.ChartAreas.Add(chartArea12);
            legend12.Enabled = false;
            legend12.Font = new System.Drawing.Font("Aptos", 8F);
            legend12.IsTextAutoFit = false;
            legend12.Name = "Legend1";
            this.chartStatusPie.Legends.Add(legend12);
            this.chartStatusPie.Location = new System.Drawing.Point(766, 147);
            this.chartStatusPie.Name = "chartStatusPie";
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series12.Legend = "Legend1";
            series12.Name = "Series1";
            this.chartStatusPie.Series.Add(series12);
            this.chartStatusPie.Size = new System.Drawing.Size(543, 497);
            this.chartStatusPie.TabIndex = 1;
            this.chartStatusPie.Text = "chart1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridMaintenance);
            this.tabPage2.Controls.Add(this.dataGridFailures);
            this.tabPage2.Controls.Add(this.dataGridSatellites);
            this.tabPage2.Controls.Add(this.btnEditSatellite);
            this.tabPage2.Controls.Add(this.btnDeleteSatellite);
            this.tabPage2.Controls.Add(this.btnAddSatellite);
            this.tabPage2.Location = new System.Drawing.Point(4, 40);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1569, 743);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Спутники";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridMaintenance
            // 
            this.dataGridMaintenance.AllowUserToAddRows = false;
            this.dataGridMaintenance.AllowUserToDeleteRows = false;
            this.dataGridMaintenance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridMaintenance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridMaintenance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMaintenance.Location = new System.Drawing.Point(1002, 398);
            this.dataGridMaintenance.Name = "dataGridMaintenance";
            this.dataGridMaintenance.ReadOnly = true;
            this.dataGridMaintenance.RowHeadersWidth = 51;
            this.dataGridMaintenance.RowTemplate.Height = 24;
            this.dataGridMaintenance.Size = new System.Drawing.Size(559, 337);
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
            this.dataGridFailures.Location = new System.Drawing.Point(1002, 74);
            this.dataGridFailures.Name = "dataGridFailures";
            this.dataGridFailures.ReadOnly = true;
            this.dataGridFailures.RowHeadersWidth = 51;
            this.dataGridFailures.RowTemplate.Height = 24;
            this.dataGridFailures.Size = new System.Drawing.Size(559, 318);
            this.dataGridFailures.TabIndex = 4;
            // 
            // dataGridSatellites
            // 
            this.dataGridSatellites.AllowUserToAddRows = false;
            this.dataGridSatellites.AllowUserToDeleteRows = false;
            this.dataGridSatellites.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridSatellites.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridSatellites.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSatellites.Location = new System.Drawing.Point(9, 74);
            this.dataGridSatellites.Name = "dataGridSatellites";
            this.dataGridSatellites.ReadOnly = true;
            this.dataGridSatellites.RowHeadersWidth = 51;
            this.dataGridSatellites.RowTemplate.Height = 24;
            this.dataGridSatellites.Size = new System.Drawing.Size(987, 661);
            this.dataGridSatellites.TabIndex = 3;
            // 
            // btnEditSatellite
            // 
            this.btnEditSatellite.Location = new System.Drawing.Point(167, 9);
            this.btnEditSatellite.Name = "btnEditSatellite";
            this.btnEditSatellite.Size = new System.Drawing.Size(203, 59);
            this.btnEditSatellite.TabIndex = 2;
            this.btnEditSatellite.Text = "Редактировать";
            this.btnEditSatellite.UseVisualStyleBackColor = true;
            // 
            // btnDeleteSatellite
            // 
            this.btnDeleteSatellite.Location = new System.Drawing.Point(376, 9);
            this.btnDeleteSatellite.Name = "btnDeleteSatellite";
            this.btnDeleteSatellite.Size = new System.Drawing.Size(138, 59);
            this.btnDeleteSatellite.TabIndex = 1;
            this.btnDeleteSatellite.Text = "Удалить";
            this.btnDeleteSatellite.UseVisualStyleBackColor = true;
            // 
            // btnAddSatellite
            // 
            this.btnAddSatellite.Location = new System.Drawing.Point(9, 9);
            this.btnAddSatellite.Name = "btnAddSatellite";
            this.btnAddSatellite.Size = new System.Drawing.Size(152, 59);
            this.btnAddSatellite.TabIndex = 0;
            this.btnAddSatellite.Text = "Добавить";
            this.btnAddSatellite.UseVisualStyleBackColor = true;
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1577, 787);
            this.Controls.Add(this.tabControlMain);
            this.Name = "Index";
            this.Text = "Спутниковая связь и космическая навигация";
            this.tabControlMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartOperationsBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartStatusPie)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMaintenance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFailures)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSatellites)).EndInit();
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
        private System.Windows.Forms.Button btnNewSatelite;
        private System.Windows.Forms.Button btnNewFailure;
        private System.Windows.Forms.Button btnNewOperation;
        private System.Windows.Forms.Button btnAddSatellite;
        private System.Windows.Forms.Button btnEditSatellite;
        private System.Windows.Forms.Button btnDeleteSatellite;
        private System.Windows.Forms.DataGridView dataGridMaintenance;
        private System.Windows.Forms.DataGridView dataGridFailures;
        private System.Windows.Forms.DataGridView dataGridSatellites;
    }
}

