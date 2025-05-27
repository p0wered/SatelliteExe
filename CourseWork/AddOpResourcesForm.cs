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
    public partial class AddOpResourcesForm : Form
    {
        private readonly string _connString;
        private readonly int _operationId;

        public AddOpResourcesForm(string connString, int operationId)
        {
            InitializeComponent();
            _connString = connString;
            _operationId = operationId;
            Load += AddOpResourcesForm_Load;
        }

        private void AddOpResourcesForm_Load(object sender, EventArgs e)
        {
            var dt = new DataTable();
            using (var conn = new SqlConnection(_connString))
            using (var da = new SqlDataAdapter(
                "SELECT ID, Название FROM Ресурсы", conn))
            {
                da.Fill(dt);
            }
            dropdownResource.DataSource = dt;
            dropdownResource.DisplayMember = "Название";
            dropdownResource.ValueMember = "ID";
            dropdownResource.SelectedIndex = -1;

            numericQuantity.Minimum = 1;
            numericQuantity.Maximum = 1000000;
            numericQuantity.Value = 1;

            btnOK.Click += BtnOK_Click;
            btnCancel.Click += (s, ev) => { DialogResult = DialogResult.Cancel; };
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (dropdownResource.SelectedIndex < 0)
            {
                MessageBox.Show("Выберите ресурс.", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int resourceId = (int)dropdownResource.SelectedValue;
            int qty = (int)numericQuantity.Value;

            using (var conn = new SqlConnection(_connString))
            using (var cmd = new SqlCommand("usp_AddResourceToOperation", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@OperationId", _operationId);
                cmd.Parameters.AddWithValue("@ResourceId", resourceId);
                cmd.Parameters.AddWithValue("@Quantity", qty);

                conn.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex) when (ex.Number == 2627)
                {
                    MessageBox.Show("Этот ресурс уже добавлен к операции.", "Ошибка",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            DialogResult = DialogResult.OK;
        }
    }
}
