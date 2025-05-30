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
            "Наземные_станции",
            "Операции",
            "Спутники",
            "Сбои",
            "Технические_обслуживания"
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
            else if (tabControlMain.SelectedIndex == 3)
            {
                InitReportTab();
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
                MessageBox.Show("Сначала выберите сбой.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            {
                MessageBox.Show("Сначала выберите ТО.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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
            {
                MessageBox.Show("Сначала выберите сбой.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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

        // Вкладка "Отчет"
        private void InitReportTab()
        {
            if (dropdownReportType.Items.Count == 0)
            {
                dropdownReportType.Items.AddRange(new object[]
                {
                    "Активные операции",
                    "Спутники по орбитам",
                    "Клиенты и количество спутников"
                });
            }
            dropdownReportType.SelectedIndex = 0;
            dataGridReport.AutoGenerateColumns = true;
        }

        private void BtnCreateReport_Click(object sender, EventArgs e)
        {
            if (dropdownReportType.SelectedIndex < 0)
            {
                MessageBox.Show("Выберите тип отчёта.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string viewName;
            switch (dropdownReportType.SelectedIndex)
            {
                case 0:
                    viewName = "View_ActiveOperations";
                    break;
                case 1:
                    viewName = "View_SatellitesByOrbit";
                    break;
                case 2:
                    viewName = "View_ClientsSatelliteCount";
                    break;
                default:
                    throw new InvalidOperationException("Неподдерживаемый тип отчёта");
            }

            var dt = new DataTable();
            using (var conn = new SqlConnection(connString))
            using (var da = new SqlDataAdapter($"SELECT * FROM {viewName}", conn))
            {
                da.Fill(dt);
            }

            dataGridReport.DataSource = dt;
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
