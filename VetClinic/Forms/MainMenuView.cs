using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VetClinic.Utils;
using Npgsql;
using System.Windows.Forms.DataVisualization.Charting;

namespace VetClinic
{
    public partial class MainMenuView : UserControl
    {
        private readonly MainForm _mainForm;

        public MainMenuView(MainForm mainForm)
        {
            _mainForm = mainForm;
            InitializeComponent();
            this.Load += MainMenuView_Load;

        }

        private void MainMenuView_Load(object sender, EventArgs e)
        {
            LoadDataToGrid();
            LoadDataToChart();
        }

        public void LoadDataToGrid()
        {
            string connStr = ConfigHelper.GetConnectionString();

            using var conn = new NpgsqlConnection(connStr);
            try
            {
                conn.Open();
                string query = "SELECT * FROM wizyty";

                using var da = new NpgsqlDataAdapter(query, conn);
                var table = new DataTable();
                da.Fill(table);

                VisitScheduleGrid.DataSource = table;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void LoadDataToChart()
        {
            string connStr = ConfigHelper.GetConnectionString();

            List<(DateTime Month, int Count)> visitCounts = new();

            using var conn = new NpgsqlConnection(connStr);
            try
            {
                conn.Open();
                string query = @"
                    SELECT 
                        DATE_TRUNC('month', data) AS month,
                        COUNT(*) AS visit_count
                    FROM wizyty
                    GROUP BY month
                    ORDER BY month;
                ";

                using var cmd = new NpgsqlCommand(query, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var month = reader.GetDateTime(0);
                        var count = reader.GetInt32(1);
                        visitCounts.Add((month, count));
                    }
                }

                conn.Close();

                Series series = new Series("Liczba wizyt")
                {
                    ChartType = SeriesChartType.Column,
                    XValueType = ChartValueType.DateTime
                };

                foreach (var (month, count) in visitCounts)
                {
                    series.Points.AddXY(month, count);
                }

                visitChart.Series.Clear();
                visitChart.Series.Add(series);
                visitChart.ChartAreas[0].AxisX.LabelStyle.Format = "yyyy-MM";
                visitChart.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


    }
}
