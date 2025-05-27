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
    public partial class EditHQForm : Form
    {
        private readonly string _connString;
        private readonly string _oldHQId;

        public EditHQForm(string connString, string hqId)
        {
            InitializeComponent();
            _connString = connString;
            _oldHQId = hqId;
            Load += EditHQForm_Load;
        }

        private void EditHQForm_Load(object sender, EventArgs e)
        {
            textBoxID.ReadOnly = false;
            textBoxID.Text = _oldHQId;

            var dt = new DataTable();
            using (var conn = new SqlConnection(_connString))
            using (var da = new SqlDataAdapter(
                @"SELECT Количество_сотрудников, Уровень_безопасности
              FROM Штабы_управления
              WHERE Идентификатор_штаба = @id", conn))
            {
                da.SelectCommand.Parameters.AddWithValue("@id", _oldHQId);
                da.Fill(dt);
            }
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Штаб не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.Cancel;
                return;
            }

            var r = dt.Rows[0];
            textBoxStaffCount.Text = r.Field<int>("Количество_сотрудников").ToString();

            dropdownSecurity.Items.AddRange(new[] { "Низкий", "Средний", "Высокий", "Критический" });
            var sec = r.Field<string>("Уровень_безопасности");
            dropdownSecurity.SelectedItem = sec ?? dropdownSecurity.Items[0];

            btnOK.Click += BtnOK_Click;
            btnCancel.Click += (s, ev) => { DialogResult = DialogResult.Cancel; };
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            string newHQId = textBoxID.Text.Trim();
            if (string.IsNullOrEmpty(newHQId))
            {
                MessageBox.Show("ID не может быть пустым.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(textBoxStaffCount.Text, out int staffCount))
            {
                MessageBox.Show("Неверное число сотрудников.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dropdownSecurity.SelectedIndex < 0)
            {
                MessageBox.Show("Выберите уровень безопасности.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string security = dropdownSecurity.SelectedItem.ToString();

            using (var conn = new SqlConnection(_connString))
            using (var cmd = new SqlCommand("usp_UpdateHQ", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@OldHQId", _oldHQId);
                cmd.Parameters.AddWithValue("@NewHQId", newHQId);
                cmd.Parameters.AddWithValue("@StaffCount", staffCount);
                cmd.Parameters.AddWithValue("@SecurityLevel", security);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            DialogResult = DialogResult.OK;
        }
    }
}