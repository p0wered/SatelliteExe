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
    public partial class AddBrigadeForm : Form
    {
        private readonly string _connString;

        public AddBrigadeForm(string connString)
        {
            InitializeComponent();
            _connString = connString;
            Load += AddBrigadeForm_Load;
        }

        private void AddBrigadeForm_Load(object sender, EventArgs e)
        {
            numericBrigadeId.Minimum = 1;
            numericBrigadeId.Value = 1;
            numericSpecialists.Minimum = 1;
            numericExperience.Minimum = 0;
            btnCancel.Click += (s, ev) => { DialogResult = DialogResult.Cancel; };
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            int brigadeId = (int)numericBrigadeId.Value;
            int specialists = (int)numericSpecialists.Value;
            int experience = (int)numericExperience.Value;

            using (var conn = new SqlConnection(_connString))
            using (var cmd = new SqlCommand("usp_AddBrigade", conn))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BrigadeId", brigadeId);
                cmd.Parameters.AddWithValue("@Specialists", specialists);
                cmd.Parameters.AddWithValue("@Experience", experience);

                conn.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Ошибка при добавлении бригады:\n{ex.Message}",
                                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            DialogResult = DialogResult.OK;
        }
    }
}
