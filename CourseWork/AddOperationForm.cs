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
    public partial class AddOperationForm : Form
    {
        private readonly string _connString;
        private readonly string _hqId;

        public AddOperationForm(string connString, string hqId)
        {
            InitializeComponent();
            _connString = connString;
            _hqId = hqId;
            Load += AddOperationForm_Load;
        }

        private void AddOperationForm_Load(object sender, EventArgs e)
        {
            dateTimePickerStart.Value = DateTime.Today;

            var dt = new DataTable();
            using (var conn = new SqlConnection(_connString))
            using (var da = new SqlDataAdapter(
                "SELECT Название FROM Космические_компании", conn))
            {
                da.Fill(dt);
            }
            dropdownClient.DataSource = dt;
            dropdownClient.DisplayMember = "Название";
            dropdownClient.ValueMember = "Название";
            dropdownClient.SelectedIndex = -1;
            btnCancel.Click += (s, ev) => { DialogResult = DialogResult.Cancel; };
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                MessageBox.Show("Введите название операции.", "Ошибка",
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
            DateTime dtStart = dateTimePickerStart.Value.Date;
            string clientCo = dropdownClient.SelectedValue.ToString();

            using (var conn = new SqlConnection(_connString))
            using (var cmd = new SqlCommand("usp_AddOperation", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@StartDate", dtStart);
                cmd.Parameters.AddWithValue("@HQId", _hqId);
                cmd.Parameters.AddWithValue("@OrganizerCompany", clientCo);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            DialogResult = DialogResult.OK;
        }
    }
}
