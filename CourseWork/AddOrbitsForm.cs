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
    public partial class AddOrbitsForm : Form
    {
        private readonly string _connString;

        public AddOrbitsForm(string connString)
        {
            InitializeComponent();
            _connString = connString;
            Load += AddOrbitForm_Load;
        }

        private void AddOrbitForm_Load(object sender, EventArgs e)
        {
            textBoxType.MaxLength = 30;

            numericHeight.Minimum = 0;
            numericHeight.DecimalPlaces = 2;
            numericPeriod.Minimum = 0;
            numericPeriod.DecimalPlaces = 2;
            numericInclination.Minimum = 0;
            numericInclination.DecimalPlaces = 2;

            btnCancel.Click += (s, ev) => { DialogResult = DialogResult.Cancel; };
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            var type = textBoxType.Text.Trim();
            if (type.Length == 0)
            {
                MessageBox.Show("Введите тип орбиты.", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal height = numericHeight.Value;
            decimal period = numericPeriod.Value;
            decimal inclination = numericInclination.Value;

            using (var conn = new SqlConnection(_connString))
            using (var cmd = new SqlCommand("usp_AddOrbit", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Type", type);
                cmd.Parameters.AddWithValue("@Height", height);
                cmd.Parameters.AddWithValue("@Period", period);
                cmd.Parameters.AddWithValue("@Inclination", inclination);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            DialogResult = DialogResult.OK;
        }
    }
}
