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
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
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
            var hqId = textBoxID.Text.Trim();
            if (string.IsNullOrEmpty(hqId))
            {
                MessageBox.Show("Введите идентификатор штаба.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(textBoxStaffCount.Text, out int staffCount) || staffCount <= 0)
            {
                MessageBox.Show("Введите корректное положительное число сотрудников.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dropdownSecurity.SelectedIndex < 0)
            {
                MessageBox.Show("Выберите уровень безопасности.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var security = dropdownSecurity.SelectedItem.ToString();

            try
            {
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
            catch (SqlException ex)
            {
                if (ex.Message.Contains("правилом"))
                {
                    MessageBox.Show("Нарушено правило формата кода штаба. Используйте шаблон A123-4.",
                                    "Ошибка формата", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Ошибка при добавлении штаба:\n" + ex.Message,
                                    "Ошибка БД", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

