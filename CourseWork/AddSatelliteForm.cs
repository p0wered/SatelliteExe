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
using System.Xml.Linq;

namespace CourseWork
{
    public partial class AddSatelliteForm : Form
    {
        private readonly string connString;

        public AddSatelliteForm(string connectionString)
        {
            InitializeComponent();
            connString = connectionString;
            Load += AddSatelliteForm_Load;
        }

        private void AddSatelliteForm_Load(object sender, EventArgs e)
        {
            FillCombo("SELECT Номер_операции, Название FROM Операции", dropdownSelectOperation,
                      "Название", "Номер_операции");
            FillCombo("SELECT Название FROM Клиентские_компании", dropdownSelectClient,
                      "Название", "Название");
        }

        private void FillCombo(string sql, ComboBox cb, string displayMember, string valueMember)
        {
            var dt = new DataTable();
            using (var conn = new SqlConnection(connString))
            using (var da = new SqlDataAdapter(sql, conn))
            {
                da.Fill(dt);
            }
            cb.DataSource = dt;
            cb.DisplayMember = displayMember;
            cb.ValueMember = valueMember;
            cb.SelectedIndex = -1;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxSatelliteLife.Text, out int lifetime))
            {
                MessageBox.Show("Некорректный срок службы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxSatelliteName.Text))
            {
                MessageBox.Show("Введите название", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dropdownSelectOperation.SelectedIndex < 0)
            {
                MessageBox.Show("Выберите операцию", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dropdownSelectClient.SelectedIndex < 0)
            {
                MessageBox.Show("Выберите клиентскую компанию", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var conn = new SqlConnection(connString))
            using (var cmd = new SqlCommand("usp_AddSatellite", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", textBoxSatelliteName.Text.Trim());
                cmd.Parameters.AddWithValue("@Lifetime", lifetime);
                cmd.Parameters.AddWithValue("@OperationId", (int)dropdownSelectOperation.SelectedValue);
                cmd.Parameters.AddWithValue("@Client", dropdownSelectClient.SelectedValue.ToString());

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
