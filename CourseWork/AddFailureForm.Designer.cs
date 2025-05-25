namespace CourseWork
{
    partial class AddFailureForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.datePickerMaintenance = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxEquipment = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dropdownSeverity = new System.Windows.Forms.ComboBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Aptos", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(17, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дата сбоя";
            // 
            // datePickerMaintenance
            // 
            this.datePickerMaintenance.Font = new System.Drawing.Font("Aptos", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.datePickerMaintenance.Location = new System.Drawing.Point(22, 43);
            this.datePickerMaintenance.MinDate = new System.DateTime(2025, 5, 25, 0, 0, 0, 0);
            this.datePickerMaintenance.Name = "datePickerMaintenance";
            this.datePickerMaintenance.Size = new System.Drawing.Size(369, 36);
            this.datePickerMaintenance.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Aptos", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(17, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Оборудование";
            // 
            // textBoxEquipment
            // 
            this.textBoxEquipment.Font = new System.Drawing.Font("Aptos", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEquipment.Location = new System.Drawing.Point(22, 123);
            this.textBoxEquipment.Name = "textBoxEquipment";
            this.textBoxEquipment.Size = new System.Drawing.Size(369, 36);
            this.textBoxEquipment.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Aptos", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(17, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Уровень серьезности";
            // 
            // dropdownSeverity
            // 
            this.dropdownSeverity.Font = new System.Drawing.Font("Aptos", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dropdownSeverity.FormattingEnabled = true;
            this.dropdownSeverity.Location = new System.Drawing.Point(22, 204);
            this.dropdownSeverity.Name = "dropdownSeverity";
            this.dropdownSeverity.Size = new System.Drawing.Size(369, 37);
            this.dropdownSeverity.TabIndex = 5;
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Aptos", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOK.Location = new System.Drawing.Point(22, 276);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(174, 61);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "Добавить";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Aptos", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.Location = new System.Drawing.Point(213, 276);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(178, 61);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddFailureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 357);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.dropdownSeverity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxEquipment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.datePickerMaintenance);
            this.Controls.Add(this.label1);
            this.Name = "AddFailureForm";
            this.Text = "Добавление сбоя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datePickerMaintenance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxEquipment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox dropdownSeverity;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}