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
    public partial class EditOpResourcesForm : Form
    {
        private readonly string _connString;
        private readonly int _operationId;
        private readonly int _resourceId;

        public EditOpResourcesForm(string connString, int operationId, int resourceId)
        {
            InitializeComponent();
            _connString = connString;
            _operationId = operationId;
            _resourceId = resourceId;
            Load += EditOpResourcesForm_Load;
        }

        private void EditOpResourcesForm_Load(object sender, EventArgs e)
        {
            var dt = new DataTable();
            using (var conn = new SqlConnection(_connString))
            using (var da = new SqlDataAdapter("SELECT ID, Название FROM Ресурсы", conn))
            {
                da.Fill(dt);
            }
            dropdownResource.DataSource = dt;
            dropdownResource.DisplayMember = "Название";
            dropdownResource.ValueMember = "ID";
            dropdownResource.SelectedValue = _resourceId;
            dropdownResource.Enabled = false; 

            using (var conn = new SqlConnection(_connString))
            using (var cmd = new SqlCommand(
                "SELECT Количество FROM Ресурсы_Операции " +
                "WHERE Номер_операции=@op AND Ресурс_ID=@res", conn))
            {
                cmd.Parameters.AddWithValue("@op", _operationId);
                cmd.Parameters.AddWithValue("@res", _resourceId);
                conn.Open();
                var obj = cmd.ExecuteScalar();
                numericQuantity.Value = obj != null
                    ? Convert.ToDecimal(obj)
                    : 1;
            }

            btnCancel.Click += (s, ev) => { DialogResult = DialogResult.Cancel; };
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            int qty = (int)numericQuantity.Value;

            using (var conn = new SqlConnection(_connString))
            using (var cmd = new SqlCommand("usp_UpdateResourceOfOperation", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@OperationId", _operationId);
                cmd.Parameters.AddWithValue("@ResourceId", _resourceId);
                cmd.Parameters.AddWithValue("@Quantity", qty);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            DialogResult = DialogResult.OK;
        }
    }
}