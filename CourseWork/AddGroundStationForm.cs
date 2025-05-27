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
    public partial class AddGroundStationForm : Form
    {
        private readonly string _connString;

        public AddGroundStationForm(string connString)
        {
            InitializeComponent();
            _connString = connString;
            Load += AddGroundStationForm_Load;
        }

        private void AddGroundStationForm_Load(object sender, EventArgs e)
        {
            numericAntennas.Minimum = 1;
            btnCancel.Click += (s, ev) => { DialogResult = DialogResult.Cancel; };
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            var name = textBoxName.Text.Trim();
            if (name.Length == 0)
            {
                MessageBox.Show("Введите название станции.", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var country = textBoxCountry.Text.Trim();
            if (country.Length == 0)
            {
                MessageBox.Show("Введите страну.", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int antennas = (int)numericAntennas.Value;

            using (var conn = new SqlConnection(_connString))
            using (var cmd = new SqlCommand("usp_AddGroundStation", conn))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Country", country);
                cmd.Parameters.AddWithValue("@AntennaCount", antennas);

                conn.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Ошибка при добавлении станции:\n{ex.Message}",
                                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            DialogResult = DialogResult.OK;
        }
    }
}
