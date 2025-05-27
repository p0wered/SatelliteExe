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
    public partial class AddHQForm : Form
    {
        private readonly string _connString;

        public AddHQForm(string connString)
        {
            InitializeComponent();
            _connString = connString;
            Load += AddHQForm_Load;
        }

        private void AddHQForm_Load(object sender, EventArgs e)
        {
            dropdownSecurity.Items.AddRange(new[] { "Низкий", "Средний", "Высокий", "Критический" });
            dropdownSecurity.SelectedIndex = 0;
            btnCancel.Click += (s, ev) => DialogResult = DialogResult.Cancel;
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxID.Text))
            {
                MessageBox.Show("Введите идентификатор штаба.",
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(textBoxStaffCount.Text, out int staffCount))
            {
                MessageBox.Show("Введите корректное число сотрудников.",
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dropdownSecurity.SelectedIndex < 0)
            {
                MessageBox.Show("Выберите уровень безопасности.",
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string hqId = textBoxID.Text.Trim();
            string security = dropdownSecurity.SelectedItem.ToString();

            using (var conn = new SqlConnection(_connString))
            using (var cmd = new SqlCommand("usp_AddHQ", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@HQId", hqId);
                cmd.Parameters.AddWithValue("@StaffCount", staffCount);
                cmd.Parameters.AddWithValue("@SecurityLevel", security);

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
