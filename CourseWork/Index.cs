using CourseWork.AddForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class Index : Form
    {
        private readonly SateliteDbModel db = new SateliteDbModel();
        private readonly string connString;
        private readonly List<string> _otherTables = new List<string>
        {
            "Орбиты",
            "Ресурсы",
            "Клиентские_компании",
            "Космические_компании",
            "Бригады_специалистов",
            "Наземные_станции"
        };

        public Index()
        {
            InitializeComponent();
            connString = db.Database.Connection.ConnectionString;
            InitSatelliteTab();
            LoadSatellites();
            tabControlMain.SelectedIndexChanged += TabControlMain_SelectedIndexChanged;
        }

        // Переключение вкладок
        private void TabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlMain.SelectedIndex == 0)
            {
                InitSatelliteTab();
                LoadSatellites();
            }
            else if (tabControlMain.SelectedIndex == 1)
            {
                InitHQTab();
                LoadHQs();
            }
            else if (tabControlMain.SelectedIndex == 2)
            {
                InitOtherTab();
            }
        }

        // Вкладка "Спутники"
        private void InitSatelliteTab()
        {
            dataGridSatellites.SelectionChanged += (s, e) => LoadSatelliteDetails();
            dataGridSatellites.CellFormatting += yearFormatting;
            dataGridMaintenance.CellFormatting += yearFormatting;

            dataGridSatellites.AutoGenerateColumns = true;
            dataGridMaintenance.AutoGenerateColumns = true;
            dataGridFailures.AutoGenerateColumns = true;
        }

        private void LoadSatellites()
        {
            dataGridSatellites.DataSource = ExecuteProc("usp_GetSatellites");
        }

        private void LoadSatelliteDetails()
        {
            if (dataGridSatellites.CurrentRow == null) return;

            int satId = Convert.ToInt32(dataGridSatellites.CurrentRow.Cells[0].Value);

            dataGridFailures.DataSource = ExecuteProc(
                "usp_GetFailuresBySatellite",
                new SqlParameter("@SatelliteId", satId));

            dataGridMaintenance.DataSource = ExecuteProc(
                "usp_GetSatelliteMaintenance",
                new SqlParameter("@SatelliteId", satId));
        }

        private void btnAddSatellite_Click(object sender, EventArgs e)
        {
            using (var form = new AddSatelliteForm(connString))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadSatellites();
                }
            }
        }

        private void btnAddFailure_Click(object sender, EventArgs e)
        {
            if (dataGridSatellites.CurrentRow == null)
            {
                MessageBox.Show("Выберите сначала спутник.",
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int satId = Convert.ToInt32(
                dataGridSatellites.CurrentRow.Cells[0].Value);

            using (var form = new AddFailureForm(connString, satId))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadSatelliteDetails();
                }
            }
        }

        private void btnAddMaintenance_Click(object sender, EventArgs e)
        {
            if (dataGridSatellites.CurrentRow == null)
            {
                MessageBox.Show("Сначала выберите спутник.",
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int satId = Convert.ToInt32(dataGridSatellites.CurrentRow.Cells[0].Value);

            using (var form = new AddMaintenanceForm(connString, satId))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadSatelliteDetails();
                }
            }
        }

        private void btnEditSatellite_Click(object sender, EventArgs e)
        {
            if (dataGridSatellites.CurrentRow == null) return;

            int satId = Convert.ToInt32(dataGridSatellites.CurrentRow.Cells[0].Value);

            using (var form = new EditSatelliteForm(connString, satId))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadSatellites();
                }
            }
        }

        private void btnEditMaintenance_Click(object sender, EventArgs e)
        {
            if (dataGridMaintenance.CurrentRow == null)
                return;

            int mtId = Convert.ToInt32(dataGridMaintenance.CurrentRow
                         .Cells["Номер ТО"].Value);

            using (var form = new EditMaintenanceForm(connString, mtId))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadSatelliteDetails();
                }
            }
        }

        private void btnEditFailure_Click(object sender, EventArgs e)
        {
            if (dataGridFailures.CurrentRow == null)
            {
                MessageBox.Show("Сначала выберите сбой.", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int failureId = Convert.ToInt32(
                dataGridFailures.CurrentRow.Cells["Номер_сбоя"].Value);

            using (var form = new EditFailureForm(connString, failureId))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadSatelliteDetails();
                }
            }
        }

        private void btnDeleteSatellite_Click(object sender, EventArgs e)
        {
            if (dataGridSatellites.CurrentRow == null) return;
            int satId = Convert.ToInt32(dataGridSatellites.CurrentRow.Cells[0].Value);

            if (MessageBox.Show("Удалить спутник #" + satId + " и все связанные с ним записи?",
                "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;

            using (var conn = new SqlConnection(connString))
            using (var cmd = new SqlCommand("usp_DeleteSatellite", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SatelliteId", satId);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            LoadSatellites();
        }

        private void btnDeleteMaintenance_Click(object sender, EventArgs e)
        {
            if (dataGridMaintenance.CurrentRow == null)
                return;

            int maintenanceId = Convert.ToInt32(
                dataGridMaintenance.CurrentRow.Cells["Номер ТО"].Value);

            if (MessageBox.Show(
                    $"Удалить техобслуживание №{maintenanceId}?",
                    "Подтверждение",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) != DialogResult.Yes)
            {
                return;
            }

            using (var conn = new SqlConnection(connString))
            using (var cmd = new SqlCommand(
                "DELETE FROM Технические_обслуживания WHERE Номер_ТО = @id", conn))
            {
                cmd.Parameters.AddWithValue("@id", maintenanceId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }

            LoadSatelliteDetails();
        }

        private void btnDeleteFailure_Click(object sender, EventArgs e)
        {
            if (dataGridFailures.CurrentRow == null)
                return;

            int failureId = Convert.ToInt32(
                dataGridFailures.CurrentRow.Cells["Номер_сбоя"].Value);

            if (MessageBox.Show(
                    $"Удалить сбой №{failureId}?",
                    "Подтверждение",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) != DialogResult.Yes)
            {
                return;
            }

            using (var conn = new SqlConnection(connString))
            using (var cmd = new SqlCommand(
                "DELETE FROM Сбои WHERE Номер_сбоя = @id", conn))
            {
                cmd.Parameters.AddWithValue("@id", failureId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }

            LoadSatelliteDetails();
        }

        // Вкладка "Штабы"
        private void InitHQTab()
        {
            dataGridHQ.SelectionChanged += (s, e) => LoadOperationsByHQ();
            dataGridHQ.AutoGenerateColumns = true;
            dataGridOperations.SelectionChanged += (s, e) => LoadOperationResources();
            dataGridOperations.AutoGenerateColumns = true;
            dataGridOpResources.AutoGenerateColumns = true;
            LoadHQs();
        }

        private void LoadHQs()
        {
            dataGridHQ.DataSource = ExecuteProc("usp_GetHQs");
        }

        private void LoadOperationsByHQ()
        {
            if (dataGridHQ.CurrentRow == null) return;

            string hqId = dataGridHQ.CurrentRow.Cells["Идентификатор штаба"].Value.ToString();

            dataGridOperations.DataSource = ExecuteProc(
                "usp_GetOperationsByHQ",
                new SqlParameter("@HQId", hqId));
        }

        private void LoadOperationResources()
        {
            if (dataGridOperations.CurrentRow == null) return;

            int opId = Convert.ToInt32(
                dataGridOperations.CurrentRow.Cells["Номер операции"].Value);

            dataGridOpResources.DataSource = ExecuteProc(
                "usp_GetResourcesByOperation",
                new SqlParameter("@OperationId", opId));
        }

        private void btnAddHQ_Click(object sender, EventArgs e)
        {
            using (var form = new AddHQForm(connString))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadHQs();
                }
            }
        }

        private void btnAddOperation_Click(object sender, EventArgs e)
        {
            if (dataGridHQ.CurrentRow == null)
            {
                MessageBox.Show("Выберите штаб управления.", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string hqId = dataGridHQ.CurrentRow
                .Cells["Идентификатор штаба"].Value
                .ToString();

            using (var form = new AddOperationForm(connString, hqId))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadOperationsByHQ();
                }
            }
        }

        private void btnAddOpResource_Click(object sender, EventArgs e)
        {
            if (dataGridOperations.CurrentRow == null)
            {
                MessageBox.Show("Сначала выберите операцию.", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int opId = Convert.ToInt32(
                dataGridOperations.CurrentRow.Cells["Номер операции"].Value);

            using (var form = new AddOpResourcesForm(connString, opId))
            {
                if (form.ShowDialog() == DialogResult.OK)
                    LoadOperationResources();
            }
        }

        private void btnEditHQ_Click(object sender, EventArgs e)
        {
            if (dataGridHQ.CurrentRow == null)
                return;

            string hqId = dataGridHQ.CurrentRow
                .Cells["Идентификатор штаба"].Value
                .ToString();

            using (var form = new EditHQForm(connString, hqId))
            {
                if (form.ShowDialog() == DialogResult.OK)
                    LoadHQs();
            }
        }

        private void btnEditOperation_Click(object sender, EventArgs e)
        {
            if (dataGridOperations.CurrentRow == null) return;

            int opId = Convert.ToInt32(
                dataGridOperations.CurrentRow.Cells["Номер операции"].Value);
            string hqId = dataGridHQ.CurrentRow.Cells["Идентификатор штаба"].Value.ToString();

            using (var form = new EditOperationForm(connString, opId, hqId))
            {
                if (form.ShowDialog() == DialogResult.OK)
                    LoadOperationsByHQ();
            }
        }

        private void btnEditOpResources_Click(object sender, EventArgs e)
        {
            if (dataGridOperations.CurrentRow == null || dataGridOpResources.CurrentRow == null)
            {
                MessageBox.Show("Сначала выберите операцию и ресурс.", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int opId = Convert.ToInt32(
                dataGridOperations.CurrentRow.Cells["Номер операции"].Value);
            int resId = Convert.ToInt32(
                dataGridOpResources.CurrentRow.Cells["ID ресурса"].Value);

            using (var form = new EditOpResourcesForm(connString, opId, resId))
            {
                if (form.ShowDialog() == DialogResult.OK)
                    LoadOperationResources();
            }
        }

        private void btnDeleteHQ_Click(object sender, EventArgs e)
        {
            if (dataGridHQ.CurrentRow == null)
            {
                MessageBox.Show("Сначала выберите штаб.", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string hqId = dataGridHQ.CurrentRow
                .Cells["Идентификатор штаба"].Value
                .ToString();

            if (MessageBox.Show(
                    $"Вы уверены, что хотите удалить штаб «{hqId}» и всё, что с ним связано?",
                    "Подтверждение удаления",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) != DialogResult.Yes)
            {
                return;
            }

            using (var conn = new SqlConnection(connString))
            using (var cmd = new SqlCommand(
                "DELETE FROM Штабы_управления WHERE Идентификатор_штаба = @id", conn))
            {
                cmd.Parameters.AddWithValue("@id", hqId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }

            LoadHQs();
            dataGridOperations.DataSource = null;
            dataGridOpResources.DataSource = null;
        }


        private void btnDeleteOperation_Click(object sender, EventArgs e)
        {
            if (dataGridOperations.CurrentRow == null)
            {
                MessageBox.Show("Сначала выберите операцию.", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int opId = Convert.ToInt32(
                dataGridOperations.CurrentRow.Cells["Номер операции"].Value);
            string hqId = dataGridHQ.CurrentRow.Cells["Идентификатор штаба"].Value.ToString();

            if (MessageBox.Show(
                    $"Удалить операцию №{opId} и все её ресурсы?",
                    "Подтверждение удаления",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) != DialogResult.Yes)
            {
                return;
            }

            using (var conn = new SqlConnection(connString))
            using (var cmd = new SqlCommand(
                "DELETE FROM Операции WHERE Номер_операции = @id", conn))
            {
                cmd.Parameters.AddWithValue("@id", opId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }

            LoadOperationsByHQ();
            dataGridOpResources.DataSource = null;
        }

        private void btnDeleteResource_Click(object sender, EventArgs e)
        {
            if (dataGridOpResources.CurrentRow == null)
            {
                MessageBox.Show("Сначала выберите ресурс.", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int opId = Convert.ToInt32(
                dataGridOperations.CurrentRow.Cells["Номер операции"].Value);
            int resId = Convert.ToInt32(
                dataGridOpResources.CurrentRow.Cells["ID ресурса"].Value);

            if (MessageBox.Show(
                    $"Удалить ресурс #{resId} из операции #{opId}?",
                    "Подтверждение удаления",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) != DialogResult.Yes)
            {
                return;
            }

            using (var conn = new SqlConnection(connString))
            using (var cmd = new SqlCommand(
                "DELETE FROM Ресурсы_Операции WHERE Номер_операции=@op AND Ресурс_ID=@res", conn))
            {
                cmd.Parameters.AddWithValue("@op", opId);
                cmd.Parameters.AddWithValue("@res", resId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }

            LoadOperationResources();
        }

        // Вкладка "Остальное"
        private void InitOtherTab()
        {   
            if (dropdownOtherTables.Items.Count == 0)
            {
                dropdownOtherTables.Items.AddRange(_otherTables.ToArray());
            }
            dropdownOtherTables.SelectedIndexChanged += (s, e) => LoadDynamicTable();
            dataGridDynamic.AutoGenerateColumns = true;
            dataGridDynamic.DataSource = null;
        }

        private void LoadDynamicTable()
        {
            if (dropdownOtherTables.SelectedIndex < 0)
            {
                dataGridDynamic.DataSource = null;
                return;
            }

            string tableName = dropdownOtherTables.SelectedItem.ToString();
            var dt = new DataTable();
            using (var conn = new SqlConnection(connString))
            using (var cmd = new SqlCommand($"SELECT * FROM [{tableName}]", conn))
            using (var da = new SqlDataAdapter(cmd))
            {
                conn.Open();
                da.Fill(dt);
            }

            dataGridDynamic.DataSource = dt;
        }

        private void BtnAddDynamic_Click(object sender, EventArgs e)
        {
            string table = dropdownOtherTables.SelectedItem as string;
            if (string.IsNullOrEmpty(table))
                return;

            Form form = null;

            switch (table)
            {
                case "Орбиты":
                    form = new AddOrbitsForm(connString);
                    break;
                case "Ресурсы":
                    form = new AddResourcesForm(connString);
                    break;
                case "Клиентские_компании":
                    form = new AddClientCompanyForm(connString);
                    break;
                case "Космические_компании":
                    form = new AddSpaceCompanyForm(connString);
                    break;
                case "Бригады_специалистов":
                    form = new AddBrigadeForm(connString);
                    break;
                case "Наземные_станции":
                    form = new AddGroundStationForm(connString);
                    break;
            }

            if (form != null && form.ShowDialog() == DialogResult.OK)
                LoadDynamicTable();
        }

        private void BtnEditDynamic_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnDeleteDynamic_Click(object sender, EventArgs e)
        {
            string table = dropdownOtherTables.SelectedItem as string;
            if (string.IsNullOrEmpty(table) || dataGridDynamic.CurrentRow == null)
                return;

            object key = dataGridDynamic.CurrentRow.Cells[0].Value;
            string msg = $"Удалить запись в таблице {table} с ключом = {key}?";
            if (MessageBox.Show(msg, "Подтверждение",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;

            string sql = null;
            switch (table)
            {
                case "Орбиты":
                    sql = "DELETE FROM Орбиты WHERE Идентификатор_орбиты = @id";
                    break;
                case "Ресурсы":
                    sql = "DELETE FROM Ресурсы WHERE ID = @id";
                    break;
                case "Клиентские_компании":
                    sql = "DELETE FROM Клиентские_компании WHERE Название = @id";
                    break;
                case "Космические_компании":
                    sql = "DELETE FROM Космические_компании WHERE Название = @id";
                    break;
                case "Бригады_специалистов":
                    sql = "DELETE FROM Бригады_специалистов WHERE Номер_бригады = @id";
                    break;
                case "Наземные_станции":
                    sql = "DELETE FROM Наземные_станции WHERE Номер_станции = @id";
                    break;
                case "Сбои":
                    sql = "DELETE FROM Сбои WHERE Номер_сбоя = @id";
                    break;
                case "Технические_обслуживания":
                    sql = "DELETE FROM Технические_обслуживания WHERE Номер_ТО = @id";
                    break;
            }

            if (sql == null) return;

            using (var conn = new SqlConnection(connString))
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@id", key);
                conn.Open();
                cmd.ExecuteNonQuery();
            }

            LoadDynamicTable();
        }

        // Утилиты
        private void yearFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var grid = (DataGridView)sender;
            var col = grid.Columns[e.ColumnIndex];

            if ((col.Name == "Срок службы" || col.Name == "Стаж бригады")
                && e.Value != null
                && int.TryParse(e.Value.ToString(), out int years))
            {
                string suffix;
                if (years % 10 == 1 && years % 100 != 11)
                    suffix = "год";
                else if (years % 10 >= 2 && years % 10 <= 4
                         && (years % 100 < 10 || years % 100 >= 20))
                    suffix = "года";
                else
                    suffix = "лет";

                e.Value = $"{years} {suffix}";
                e.FormattingApplied = true;
            }
        }

        private DataTable ExecuteProc(string procName, params SqlParameter[] parameters)
        {
            var dt = new DataTable();
            using (var conn = new SqlConnection(connString))
            using (var cmd = new SqlCommand(procName, conn))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                if (parameters != null && parameters.Length > 0)
                    cmd.Parameters.AddRange(parameters);
                da.Fill(dt);
            }
            return dt;
        }
    }
}
