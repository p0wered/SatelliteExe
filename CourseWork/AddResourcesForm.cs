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

namespace CourseWork.AddForms
{
    public partial class AddResourcesForm : Form
    {
        private readonly string _connString;

        public AddResourcesForm(string connString)
        {
            InitializeComponent();
            _connString = connString;
            Load += AddResourceForm_Load;
        }

        private void AddResourceForm_Load(object sender, EventArgs e)
        {
            numericQuantity.Minimum = 0;
            numericQuantity.Value = 1;
            textBoxUnit.MaxLength = 8;
            btnCancel.Click += (s, ev) => { DialogResult = DialogResult.Cancel; };
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Введите название ресурса.", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int qty = (int)numericQuantity.Value;

            string unit = textBoxUnit.Text.Trim();
            if (string.IsNullOrEmpty(unit))
            {
                MessageBox.Show("Введите единицу измерения.", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var conn = new SqlConnection(_connString))
            using (var cmd = new SqlCommand("usp_AddResource", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Quantity", qty);
                cmd.Parameters.AddWithValue("@Unit", unit);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            DialogResult = DialogResult.OK;
        }
    }
}
