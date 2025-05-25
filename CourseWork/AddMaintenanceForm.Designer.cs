namespace CourseWork
{
    partial class AddMaintenanceForm
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
            this.datePickerService = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dropdownBrigade = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // datePickerService
            // 
            this.datePickerService.Font = new System.Drawing.Font("Aptos", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.datePickerService.Location = new System.Drawing.Point(21, 41);
            this.datePickerService.MinDate = new System.DateTime(2025, 5, 25, 0, 0, 0, 0);
            this.datePickerService.Name = "datePickerService";
            this.datePickerService.Size = new System.Drawing.Size(363, 36);
            this.datePickerService.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Aptos", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Дата проведения";
            // 
            // dropdownBrigade
            // 
            this.dropdownBrigade.Font = new System.Drawing.Font("Aptos", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dropdownBrigade.FormattingEnabled = true;
            this.dropdownBrigade.Location = new System.Drawing.Point(21, 120);
            this.dropdownBrigade.Name = "dropdownBrigade";
            this.dropdownBrigade.Size = new System.Drawing.Size(363, 37);
            this.dropdownBrigade.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Aptos", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(16, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Номер бригады";
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Aptos", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOK.Location = new System.Drawing.Point(21, 185);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(174, 61);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "Добавить";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Aptos", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(210, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 61);
            this.button1.TabIndex = 8;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddMaintenanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 271);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dropdownBrigade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datePickerService);
            this.Name = "AddMaintenanceForm";
            this.Text = "Добавление ТО";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datePickerService;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox dropdownBrigade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button button1;
    }
}