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
    public partial class AddClientCompanyForm : Form
    {
        private readonly string _connString;

        public AddClientCompanyForm(string connString)
        {
            InitializeComponent();
            _connString = connString;
            Load += AddClientCompanyForm_Load;
        }

        private void AddClientCompanyForm_Load(object sender, EventArgs e)
        {
            numericEmployees.Minimum = 1;
            numericEmployees.Value = 1;
            datePickerContract.Value = DateTime.Today;
            numericContractLength.Minimum = 1;
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

            var industry = textBoxIndustry.Text.Trim();
            if (string.IsNullOrEmpty(industry))
            {
                MessageBox.Show("Введите сферу деятельности.", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int employees = (int)numericEmployees.Value;
            DateTime contractDate = datePickerContract.Value.Date;
            int contractLength = (int)numericContractLength.Value;

            var phone = textBoxPhone.Text.Trim();
            if (string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Введите контактный телефон.", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var conn = new SqlConnection(_connString))
            using (var cmd = new SqlCommand("usp_AddClientCompany", conn))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Industry", industry);
                cmd.Parameters.AddWithValue("@EmployeeCount", employees);
                cmd.Parameters.AddWithValue("@ContractDate", contractDate);
                cmd.Parameters.AddWithValue("@ContractLength", contractLength);
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
