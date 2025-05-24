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
    public partial class Index : Form
    {
        private readonly SateliteDbModel db = new SateliteDbModel();
        private readonly string connString;

        public Index()
        {
            InitializeComponent();
            connString = db.Database.Connection.ConnectionString;
            LoadDashboardTab();
            tabControlMain.SelectedIndexChanged += TabControlMain_SelectedIndexChanged;
        }

        private void TabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlMain.SelectedIndex == 1)
            {
                InitSatelliteTab();
                LoadSatellites();
            }
        }

        private void LoadDashboardTab()
        {
            labelTotalSatellites.Text = db.Спутники.Count().ToString();

            labelActiveOperations.Text = db.Операции
                .Count(o => o.Статус == "Выполняется").ToString();

            labelCriticalFailures.Text = db.Сбои
                .Count(s => s.Уровень_серьезности == "Критический").ToString();

            var statusGroups = db.Спутники
                .GroupBy(s => s.Статус)
                .Select(g => new { Status = g.Key, Count = g.Count() })
                .ToList();
            chartStatusPie.Series[0].Points.Clear();
            foreach (var sg in statusGroups)
                chartStatusPie.Series[0].Points.AddXY(sg.Status, sg.Count);

            var opGroups = db.Операции
                .GroupBy(o => o.Статус)
                .Select(g => new { Status = g.Key, Count = g.Count() })
                .ToList();
            chartOperationsBar.Series[0].Points.Clear();
            foreach (var og in opGroups)
                chartOperationsBar.Series[0].Points.AddXY(og.Status, og.Count);
        }

        private void InitSatelliteTab()
        {
            btnAddSatellite.Click += (s, e) => { /* открыть вашу форму добавления */ };
            btnEditSatellite.Click += (s, e) => EditSelectedSatellite();
            btnDeleteSatellite.Click += (s, e) => DeleteSelectedSatellite();

            dataGridSatellites.SelectionChanged += (s, e) => LoadSatelliteDetails();
            dataGridSatellites.CellFormatting += DataGridSatellites_CellFormatting;

            dataGridSatellites.AutoGenerateColumns = true;
            dataGridMaintenance.AutoGenerateColumns = true;
            dataGridFailures.AutoGenerateColumns = true;
        }

        private void DataGridSatellites_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridSatellites.Columns[e.ColumnIndex].DataPropertyName == "Срок службы"
                && e.Value != null && int.TryParse(e.Value.ToString(), out int years))
            {
                string suffix;
                if (years % 10 == 1 && years % 100 != 11) suffix = "год";
                else if (years % 10 >= 2 && years % 10 <= 4
                         && (years % 100 < 10 || years % 100 >= 20)) suffix = "года";
                else suffix = "лет";

                e.Value = $"{years} {suffix}";
                e.FormattingApplied = true;
            }
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

        private void EditSelectedSatellite()
        {
            // if (dataGridSatellites.CurrentRow == null) return;
            // int satId = Convert.ToInt32(dataGridSatellites.CurrentRow
            //                             .Cells["Идентификатор_спутника"].Value);
            // using (var form = new SatelliteForm(satId))
            //    if (form.ShowDialog() == DialogResult.OK)
            //        LoadSatellites();
        }

        private void DeleteSelectedSatellite()
        {
            if (dataGridSatellites.CurrentRow == null) return;
            int satId = Convert.ToInt32(dataGridSatellites.CurrentRow.Cells[0].Value);

            if (MessageBox.Show("Удалить спутник и все связанные с ним записи?",
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
