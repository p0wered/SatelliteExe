using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class EditFailureForm : Form
    {
        private readonly string _connString;
        private readonly int _failureId;

        public EditFailureForm(string connString, int failureId)
        {
            InitializeComponent();
            _connString = connString;
            _failureId = failureId;
            Load += EditFailureForm_Load;
        }

        private void EditFailureForm_Load(object sender, EventArgs e)
        {
            dropdownSeverity.Items.AddRange(new[]
                { "Низкий", "Средний", "Высокий", "Критический" });

            LoadFailureData();
            btnOK.Click += BtnOK_Click;
            btnCancel.Click += (s, ev) => DialogResult = DialogResult.Cancel;
        }

        private void LoadFailureData()
        {
            var dt = new DataTable();
            using (var conn = new SqlConnection(_connString))
            using (var da = new SqlDataAdapter(
                @"SELECT Дата_сбоя, Оборудование, Уровень_серьезности
                  FROM Сбои
                  WHERE Номер_сбоя = @id", conn))
            {
                da.SelectCommand.Parameters.AddWithValue("@id", _failureId);
                da.Fill(dt);
            }
            if (dt.Rows.Count == 0) return;

            var r = dt.Rows[0];
            datePickerFailure.Value = r.Field<DateTime>("Дата_сбоя");
            textBoxEquipment.Text = r.Field<string>("Оборудование");

            string sev = r.Field<string>("Уровень_серьезности");
            if (dropdownSeverity.Items.Contains(sev))
                dropdownSeverity.SelectedItem = sev;
            else
                dropdownSeverity.SelectedIndex = 1;
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxEquipment.Text))
            {
                MessageBox.Show("Введите оборудование.", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dropdownSeverity.SelectedIndex < 0)
            {
                MessageBox.Show("Выберите уровень серьёзности.", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var date = datePickerFailure.Value.Date;
            var eq = textBoxEquipment.Text.Trim();
            var sev = dropdownSeverity.SelectedItem.ToString();

            using (var conn = new SqlConnection(_connString))
            using (var cmd = new SqlCommand("usp_UpdateFailure", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FailureId", _failureId);
                cmd.Parameters.AddWithValue("@FailureDate", date);
                cmd.Parameters.AddWithValue("@Equipment", eq);
                cmd.Parameters.AddWithValue("@Severity", sev);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
