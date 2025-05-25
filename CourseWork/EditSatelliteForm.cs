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
    public partial class EditSatelliteForm : Form
    {
        private readonly string _connString;
        private readonly int _satelliteId;

        public EditSatelliteForm(string connectionString, int satelliteId)
        {
            InitializeComponent();
            _connString = connectionString;
            _satelliteId = satelliteId;
            Load += EditSatelliteForm_Load;
        }

        private void EditSatelliteForm_Load(object sender, EventArgs e)
        {
            FillCombo("SELECT Идентификатор_орбиты, Тип_орбиты FROM Орбиты",
                      dropdownOrbitSelect, "Тип_орбиты", "Идентификатор_орбиты");
            FillCombo("SELECT Номер_станции, Название FROM Наземные_станции",
                      dropdownStationSelect, "Название", "Номер_станции");
            FillCombo("SELECT Номер_операции, Название FROM Операции",
                      dropdownSelectOperation, "Название", "Номер_операции");
            FillCombo("SELECT Название FROM Клиентские_компании",
                      dropdownSelectClient, "Название", "Название");

            dropdownStatus.Items.AddRange(new[] {
                "На хранении", "Активен", "Выполняется", "Выведен"
            });

            LoadSatelliteData();
        }

        private void LoadSatelliteData()
        {
            var dt = new DataTable();
            using (var conn = new SqlConnection(_connString))
            using (var da = new SqlDataAdapter(
                "SELECT Название, Статус, Срок_службы, " +
                "Идентификатор_орбиты, Номер_операции, Станция_вылета, Клиент " +
                "FROM Спутники WHERE Идентификатор_спутника = @id", conn))
            {
                da.SelectCommand.Parameters.AddWithValue("@id", _satelliteId);
                da.Fill(dt);
            }
            if (dt.Rows.Count == 0) return;

            var r = dt.Rows[0];
            textBoxSatelliteName.Text = r.Field<string>("Название");
            textBoxSatelliteLife.Text = r.Field<int>("Срок_службы").ToString();
            dropdownStatus.SelectedItem = r.Field<string>("Статус");
            dropdownOrbitSelect.SelectedValue = r.Field<int>("Идентификатор_орбиты");
            dropdownSelectOperation.SelectedValue = r.Field<int>("Номер_операции");
            dropdownStationSelect.SelectedValue = r.Field<int>("Станция_вылета");
            dropdownSelectClient.SelectedValue = r.Field<string>("Клиент");
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxSatelliteName.Text)
                || !int.TryParse(textBoxSatelliteLife.Text, out int lifetime)
                || dropdownOrbitSelect.SelectedIndex < 0
                || dropdownStationSelect.SelectedIndex < 0
                || dropdownSelectOperation.SelectedIndex < 0
                || dropdownSelectClient.SelectedIndex < 0
                || dropdownStatus.SelectedIndex < 0)
            {
                MessageBox.Show("Заполните все поля.", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var conn = new SqlConnection(_connString))
            using (var cmd = new SqlCommand("usp_UpdateSatellite", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SatelliteId", _satelliteId);
                cmd.Parameters.AddWithValue("@Name", textBoxSatelliteName.Text.Trim());
                cmd.Parameters.AddWithValue("@Status", dropdownStatus.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Lifetime", lifetime);
                cmd.Parameters.AddWithValue("@OrbitId", (int)dropdownOrbitSelect.SelectedValue);
                cmd.Parameters.AddWithValue("@OperationId", (int)dropdownSelectOperation.SelectedValue);
                cmd.Parameters.AddWithValue("@StationId", (int)dropdownStationSelect.SelectedValue);
                cmd.Parameters.AddWithValue("@Client", dropdownSelectClient.SelectedValue.ToString());

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void FillCombo(string sql, ComboBox cb, string displayMember, string valueMember)
        {
            var dt = new DataTable();
            using (var conn = new SqlConnection(_connString))
            using (var da = new SqlDataAdapter(sql, conn))
            {
                da.Fill(dt);
            }
            cb.DataSource = dt;
            cb.DisplayMember = displayMember;
            cb.ValueMember = valueMember;
            cb.SelectedIndex = -1;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
