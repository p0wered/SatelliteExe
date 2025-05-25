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
    public partial class AddMaintenanceForm : Form
    {
        private readonly string _connString;
        private readonly int _satelliteId;

        public AddMaintenanceForm(string connString, int satelliteId)
        {
            InitializeComponent();
            _connString = connString;
            _satelliteId = satelliteId;
            LoadBrigades();
            datePickerService.Value = DateTime.Today;
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

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (dropdownBrigade.SelectedIndex < 0)
            {
                MessageBox.Show("Выберите бригаду.",
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var serviceDate = datePickerService.Value.Date;
            var brigadeId = (int)dropdownBrigade.SelectedValue;

            using (var conn = new SqlConnection(_connString))
            using (var cmd = new SqlCommand("usp_AddMaintenance", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SatelliteId", _satelliteId);
                cmd.Parameters.AddWithValue("@ServiceDate", serviceDate);
                cmd.Parameters.AddWithValue("@BrigadeId", brigadeId);

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
