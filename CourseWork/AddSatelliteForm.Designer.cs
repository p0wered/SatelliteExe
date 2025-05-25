namespace CourseWork
{
    partial class AddSatelliteForm
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
            this.textBoxSatelliteName = new System.Windows.Forms.TextBox();
            this.textBoxSatelliteLife = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dropdownOrbitSelect = new System.Windows.Forms.ComboBox();
            this.dropdownStationSelect = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dropdownSelectOperation = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dropdownSelectClient = new System.Windows.Forms.ComboBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxSatelliteName
            // 
            this.textBoxSatelliteName.Font = new System.Drawing.Font("Aptos", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSatelliteName.Location = new System.Drawing.Point(20, 43);
            this.textBoxSatelliteName.Name = "textBoxSatelliteName";
            this.textBoxSatelliteName.Size = new System.Drawing.Size(228, 36);
            this.textBoxSatelliteName.TabIndex = 0;
            // 
            // textBoxSatelliteLife
            // 
            this.textBoxSatelliteLife.Font = new System.Drawing.Font("Aptos", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSatelliteLife.Location = new System.Drawing.Point(264, 43);
            this.textBoxSatelliteLife.Name = "textBoxSatelliteLife";
            this.textBoxSatelliteLife.Size = new System.Drawing.Size(171, 36);
            this.textBoxSatelliteLife.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Aptos", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Aptos", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(259, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Срок службы (лет)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Aptos", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(15, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Орбита";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Aptos", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(15, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Наземная станция";
            // 
            // dropdownOrbitSelect
            // 
            this.dropdownOrbitSelect.Font = new System.Drawing.Font("Aptos", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dropdownOrbitSelect.FormattingEnabled = true;
            this.dropdownOrbitSelect.Location = new System.Drawing.Point(20, 123);
            this.dropdownOrbitSelect.Name = "dropdownOrbitSelect";
            this.dropdownOrbitSelect.Size = new System.Drawing.Size(415, 37);
            this.dropdownOrbitSelect.TabIndex = 9;
            // 
            // dropdownStationSelect
            // 
            this.dropdownStationSelect.Font = new System.Drawing.Font("Aptos", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dropdownStationSelect.FormattingEnabled = true;
            this.dropdownStationSelect.Location = new System.Drawing.Point(20, 202);
            this.dropdownStationSelect.Name = "dropdownStationSelect";
            this.dropdownStationSelect.Size = new System.Drawing.Size(415, 37);
            this.dropdownStationSelect.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Aptos", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(15, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Операция";
            // 
            // dropdownSelectOperation
            // 
            this.dropdownSelectOperation.Font = new System.Drawing.Font("Aptos", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dropdownSelectOperation.FormattingEnabled = true;
            this.dropdownSelectOperation.Location = new System.Drawing.Point(20, 284);
            this.dropdownSelectOperation.Name = "dropdownSelectOperation";
            this.dropdownSelectOperation.Size = new System.Drawing.Size(415, 37);
            this.dropdownSelectOperation.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Aptos", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(15, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Клиент";
            // 
            // dropdownSelectClient
            // 
            this.dropdownSelectClient.Font = new System.Drawing.Font("Aptos", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dropdownSelectClient.FormattingEnabled = true;
            this.dropdownSelectClient.Location = new System.Drawing.Point(20, 368);
            this.dropdownSelectClient.Name = "dropdownSelectClient";
            this.dropdownSelectClient.Size = new System.Drawing.Size(415, 37);
            this.dropdownSelectClient.TabIndex = 14;
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Aptos", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOK.Location = new System.Drawing.Point(20, 423);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(202, 57);
            this.btnOK.TabIndex = 15;
            this.btnOK.Text = "Добавить";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Aptos", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.Location = new System.Drawing.Point(239, 423);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(196, 57);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddSatelliteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 504);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.dropdownSelectClient);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dropdownSelectOperation);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dropdownStationSelect);
            this.Controls.Add(this.dropdownOrbitSelect);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSatelliteLife);
            this.Controls.Add(this.textBoxSatelliteName);
            this.Name = "AddSatelliteForm";
            this.Text = "Новый спутник";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSatelliteName;
        private System.Windows.Forms.TextBox textBoxSatelliteLife;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox dropdownOrbitSelect;
        private System.Windows.Forms.ComboBox dropdownStationSelect;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox dropdownSelectOperation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox dropdownSelectClient;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}