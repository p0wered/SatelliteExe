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
    public partial class EditMaintenanceForm : Form
    {
        private readonly string _connString;
        private readonly int _maintenanceId;

        public EditMaintenanceForm(string connString, int maintenanceId)
        {
            InitializeComponent();
            _connString = connString;
            _maintenanceId = maintenanceId;

            Load += EditMaintenanceForm_Load;
        }

        private void EditMaintenanceForm_Load(object sender, EventArgs e)
        {
            LoadBrigades();

            dropdownStatus.Items.AddRange(new[]
            {
                "Запланирован", "Выполняется", "Завершено"
            });

            LoadMaintenanceData();
        }

        private void LoadBrigades()
        {
            var dt = new DataTable();
            using (var conn = new SqlConnection(_connString))
            using (var da = new SqlDataAdapter(
                "SELECT Номер_бригады FROM Бригады_специалистов", conn))
            {
                da.Fill(dt);
            }
            dropdownBrigade.DataSource = dt;
            dropdownBrigade.DisplayMember = "Номер_бригады";
            dropdownBrigade.ValueMember = "Номер_бригады";
            dropdownBrigade.SelectedIndex = -1;
        }

        private void LoadMaintenanceData()
        {
            var dt = new DataTable();
            using (var conn = new SqlConnection(_connString))
            using (var da = new SqlDataAdapter(
                @"SELECT Дата_проведения, Статус, Номер_бригады 
          FROM Технические_обслуживания 
          WHERE Номер_ТО = @id", conn))
            {
                da.SelectCommand.Parameters.AddWithValue("@id", _maintenanceId);
                da.Fill(dt);
            }
            if (dt.Rows.Count == 0) return;

            var r = dt.Rows[0];
            datePickerService.Value = r.Field<DateTime>("Дата_проведения");

            var statusValue = r.Field<string>("Статус");
            int idx = dropdownStatus.Items.IndexOf(statusValue);
            if (idx >= 0)
                dropdownStatus.SelectedIndex = idx;
            else
                dropdownStatus.SelectedIndex = 0;

            dropdownBrigade.SelectedValue = r.Field<int>("Номер_бригады");
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (dropdownBrigade.SelectedIndex < 0)
            {
                MessageBox.Show("Выберите бригаду.",
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dropdownStatus.SelectedIndex < 0)
            {
                MessageBox.Show("Выберите статус.",
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime date = datePickerService.Value.Date;
            string status = dropdownStatus.SelectedItem.ToString();
            int brigadeId = (int)dropdownBrigade.SelectedValue;

            using (var conn = new SqlConnection(_connString))
            using (var cmd = new SqlCommand("usp_UpdateMaintenance", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaintenanceId", _maintenanceId);
                cmd.Parameters.AddWithValue("@ServiceDate", date);
                cmd.Parameters.AddWithValue("@Status", status);
                cmd.Parameters.AddWithValue("@BrigadeId", brigadeId);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
