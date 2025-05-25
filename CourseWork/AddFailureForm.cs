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
    public partial class AddFailureForm : Form
    {
        private readonly string _connString;
        private readonly int _satelliteId;

        public AddFailureForm(string connString, int satelliteId)
        {
            InitializeComponent();
            _connString = connString;
            _satelliteId = satelliteId;

            dropdownSeverity.Items.AddRange(new[] { "Низкий", "Средний", "Высокий", "Критический" });
            dropdownSeverity.SelectedIndex = 1;
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxEquipment.Text))
            {
                MessageBox.Show("Введите оборудование.",
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dropdownSeverity.SelectedIndex < 0)
            {
                MessageBox.Show("Выберите уровень серьёзности.",
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var date = datePickerMaintenance.Value.Date;
            var eq = textBoxEquipment.Text.Trim();
            var sev = dropdownSeverity.SelectedItem.ToString();

            using (var conn = new SqlConnection(_connString))
            using (var cmd = new SqlCommand("usp_AddFailure", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SatelliteId", _satelliteId);
                cmd.Parameters.AddWithValue("@FailureDate", date);
                cmd.Parameters.AddWithValue("@Equipment", eq);
                cmd.Parameters.AddWithValue("@Severity", sev);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
