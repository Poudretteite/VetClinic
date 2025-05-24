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
            LoadMedQuantityChart();
        }


        public void LoadDataToGrid()
        {

            var factory = new AppDbContextFactory();
            using var context = factory.CreateDbContext(Array.Empty<string>());

            var wizyty = context.Wizyty
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
                .ToList();

            VisitScheduleGrid.DataSource = wizyty;
        }

        public void LoadMedQuantityChart()
        {

            var factory = new AppDbContextFactory();
            using var context = factory.CreateDbContext(Array.Empty<string>());

            Series medinfo = new Series("Liczba wizyt")
            {
                ChartType = SeriesChartType.Bar,
                XValueType = ChartValueType.String,
            };

            var leki = context.Leki.ToList();
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
            var factory = new AppDbContextFactory();
            using var context = factory.CreateDbContext(Array.Empty<string>());

            Series visitCount = new Series("Liczba wizyt");

            var wizytyMiesiac = context.Wizyty
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




    }
}
