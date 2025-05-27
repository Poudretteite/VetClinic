using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using Microsoft.EntityFrameworkCore;
using System.Windows.Forms.DataVisualization.Charting;
using System.Reflection;
using System.Security.Cryptography.Xml;
using System.Xml.Linq;
using VetClinic.Models;
using VetClinic.Data;

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
            databaseUsername.Text = "postgres";
            databasePassword.Text = "haslo";
            databaseName.Text = "VetClinic";
        }

        private async void MainMenuView_Load(object sender, EventArgs e)
        {
            await LoadToLists();
            await LoadDataToGrid();
            LoadDataToChart();
            LoadMedQuantityChart();
        }

        private async Task LoadToLists()
        {
            using var context = Constants.CreateContext();

            if (MainForm.leki == null) MainForm.leki = await context.Leki.ToListAsync();
            if (MainForm.wizyty == null) MainForm.wizyty = await context.Wizyty.ToListAsync();
        }

        public async Task LoadDataToGrid()
        {
            using var context = Constants.CreateContext();

            var wizyty = await context.Wizyty
                .Where(w => w.Data > DateTime.Now)
                .Include(w => w.Lekarz)
                .Include(w => w.Zwierze)
                .Select(w => new
                {
                    Data = w.Data.ToString("dd-MM-yyyy"),
                    Lekarz = w.Lekarz.Imie + " " + w.Lekarz.Nazwisko,
                    Zwierze = w.Zwierze.Imie,
                    Opis = w.Opis
                })
                .ToListAsync();

            VisitScheduleGrid.DataSource = wizyty;

            foreach (DataGridViewColumn column in VisitScheduleGrid.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }
        }

        public void LoadMedQuantityChart()
        {
            Series medinfo = new Series("Liczba wizyt")
            {
                ChartType = SeriesChartType.Bar,
                XValueType = ChartValueType.String,
            };

            var leki = MainForm.leki;
            leki.Sort((a, b) => b.Ilosc.CompareTo(a.Ilosc));

            int n = 1;
            foreach (var lek in leki)
            {
                int pointIndex = medinfo.Points.AddXY(n, lek.Ilosc);
                medinfo.Points[pointIndex].Label = $"{lek.Nazwa}";
                n++;
            }

            medCount.Series.Clear();
            medCount.Series.Add(medinfo);

            medCount.ChartAreas[0].AxisX.CustomLabels.Clear();
            medCount.ChartAreas[0].AxisX.LabelStyle.Angle = -60;

            medCount.Legends.Clear();

        }

        public void LoadDataToChart()
        {
            Series visitCount = new Series("Liczba wizyt");

            var wizytyMiesiac = MainForm.wizyty
                .GroupBy(w => new { w.Data.Year, w.Data.Month })
                .Select(g => new
                {
                    Year = g.Key.Year,
                    Month = g.Key.Month,
                    Count = g.Count()
                })
                .ToList();

            foreach (var visit in wizytyMiesiac)
            {
                DateTime date = new DateTime(visit.Year, visit.Month, 1);
                visitCount.Points.AddXY(date, visit.Count);
            }

            visitChart.Series.Clear();
            visitChart.Series.Add(visitCount);

            visitChart.ChartAreas[0].AxisX.LabelStyle.Angle = -30;
        }

        private async void connectButton_Click(object sender, EventArgs e)
        {
            Constants.username = databaseUsername.Text;
            Constants.password = databasePassword.Text;
            Constants.name = databaseName.Text;

            Constants.CurrentConnectionString = $"Host=localhost;Port=5432;Database={Constants.name};Username={Constants.username};Password={Constants.password}";

            databaseUsername.Text = Constants.username;
            databasePassword.Text = Constants.password;
            databaseName.Text = Constants.name;

            try
            {
                using var context = Constants.CreateContext();
                DbSeeder.SeedDatabase(context);

                if (context.Database.CanConnect())
                {
                    MessageBox.Show("Połączenie z bazą danych powiodło się.");

                    await LoadDataToGrid();
                    LoadDataToChart();
                    LoadMedQuantityChart();
                }
                else
                {
                    MessageBox.Show("Nie udało się połączyć z bazą danych.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd połączenia: " + ex.Message);
            }
        }
    }
}
