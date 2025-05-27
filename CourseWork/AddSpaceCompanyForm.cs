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
    public partial class AddSpaceCompanyForm : Form
    {
        private readonly string _connString;

        public AddSpaceCompanyForm(string connString)
        {
            InitializeComponent();
            _connString = connString;
            Load += AddSpaceCompanyForm_Load;
        }

        private void AddSpaceCompanyForm_Load(object sender, EventArgs e)
        {
            datePickerFounded.Value = DateTime.Today;
            numericEmployees.Minimum = 1;
            textBoxPhone.MaxLength = 20;
            btnCancel.Click += (s, ev) => { DialogResult = DialogResult.Cancel; };
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            var name = textBoxName.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Введите название компании.", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var country = textBoxCountry.Text.Trim();
            if (string.IsNullOrEmpty(country))
            {
                MessageBox.Show("Введите страну.", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime founded = datePickerFounded.Value.Date;

            int employees = (int)numericEmployees.Value;

            var phone = textBoxPhone.Text.Trim();
            if (string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Введите контактный телефон.", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var conn = new SqlConnection(_connString))
            using (var cmd = new SqlCommand("usp_AddSpaceCompany", conn))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Country", country);
                cmd.Parameters.AddWithValue("@FoundedDate", founded);
                cmd.Parameters.AddWithValue("@EmployeeCount", employees);
                cmd.Parameters.AddWithValue("@Phone", phone);

                conn.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Ошибка при добавлении: {ex.Message}", "Ошибка",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            DialogResult = DialogResult.OK;
        }
    }
}
