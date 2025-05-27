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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CourseWork
{
    public partial class EditOperationForm : Form
    {
        private readonly string _connString;
        private readonly int _operationId;
        private readonly string _hqId;

        public EditOperationForm(string connString, int operationId, string hqId)
        {
            InitializeComponent();
            _connString = connString;
            _operationId = operationId;
            _hqId = hqId;
            Load += EditOperationForm_Load;
        }

        private void EditOperationForm_Load(object sender, EventArgs e)
        {
            dropdownStatus.Items.AddRange(new[]
            {
                "Запланирована",
                "Выполняется",
                "Завершена"
            });
            dateTimePickerStart.Value = DateTime.Today;
            dateTimePickerEnd.Value = DateTime.Today;
            dateTimePickerEnd.ShowCheckBox = true; 
            var dtCo = new DataTable();
            using (var conn = new SqlConnection(_connString))
            using (var da = new SqlDataAdapter(
                "SELECT Название FROM Космические_компании", conn))
            {
                da.Fill(dtCo);
            }
            dropdownClient.DataSource = dtCo;
            dropdownClient.DisplayMember = "Название";
            dropdownClient.ValueMember = "Название";
            dropdownClient.SelectedIndex = -1;
            LoadOperationData();
            btnCancel.Click += (s, ev) => { DialogResult = DialogResult.Cancel; };
        }

        private void LoadOperationData()
        {
            var dt = new DataTable();
            using (var conn = new SqlConnection(_connString))
            using (var da = new SqlDataAdapter(
                @"SELECT Название, Статус, Дата_начала, Дата_окончания, Компания_организатор
                  FROM Операции
                  WHERE Номер_операции = @id", conn))
            {
                da.SelectCommand.Parameters.AddWithValue("@id", _operationId);
                da.Fill(dt);
            }
            if (dt.Rows.Count == 0) return;

            var r = dt.Rows[0];
            textBoxName.Text = r.Field<string>("Название");
            var st = r.Field<string>("Статус");
            dropdownStatus.SelectedItem = st;

            dateTimePickerStart.Value = r.Field<DateTime>("Дата_начала");

            if (r.IsNull("Дата_окончания"))
            {
                dateTimePickerEnd.Checked = false;
            }
            else
            {
                dateTimePickerEnd.Checked = true;
                dateTimePickerEnd.Value = r.Field<DateTime>("Дата_окончания");
            }

            dropdownClient.SelectedValue = r.Field<string>("Компания_организатор");
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                MessageBox.Show("Введите название операции.", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dropdownStatus.SelectedIndex < 0)
            {
                MessageBox.Show("Выберите статус операции.", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dropdownClient.SelectedIndex < 0)
            {
                MessageBox.Show("Выберите компанию-организатора.", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string name = textBoxName.Text.Trim();
            string status = dropdownStatus.SelectedItem.ToString();
            DateTime dtSt = dateTimePickerStart.Value.Date;
            object dtEnd = dateTimePickerEnd.Checked
                            ? (object)dateTimePickerEnd.Value.Date
                            : DBNull.Value;
            string client = dropdownClient.SelectedValue.ToString();

            using (var conn = new SqlConnection(_connString))
            using (var cmd = new SqlCommand("usp_UpdateOperation", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@OperationId", _operationId);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Status", status);
                cmd.Parameters.AddWithValue("@StartDate", dtSt);
                cmd.Parameters.AddWithValue("@EndDate", dtEnd);
                cmd.Parameters.AddWithValue("@HQId", _hqId);
                cmd.Parameters.AddWithValue("@OrganizerCompany", client);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            DialogResult = DialogResult.OK;
        }
    }
}