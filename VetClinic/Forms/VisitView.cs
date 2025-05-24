using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VetClinic.Models;

namespace VetClinic.Forms
{
    public partial class VisitView : UserControl
    {
        public int visitID;

        private readonly MainForm _mainForm;
        public VisitView(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
            LoadToVisitDataGrid();
        }

        public void LoadToVisitDataGrid()
        {
            var factory = new AppDbContextFactory();
            using var context = factory.CreateDbContext(Array.Empty<string>());

            visitDataGrid.DataSource = null;
            visitDataGrid.Columns.Clear();
            visitDataGrid.Rows.Clear();

            var wizyty = context.Wizyty
                .Include(w => w.Lekarz)
                .Include(w => w.Zwierze)
                .Include(w => w.Leki)
                .OrderBy(w => w.Id)
                .Select(w => new
                {
                    Id = w.Id,
                    Data = w.Data.ToString("dd-MM-yyyy"),
                    Zwierze = w.Zwierze != null ? w.Zwierze.Imie : "Brak danych",
                    Lekarz = w.Lekarz.Imie + " " + w.Lekarz.Nazwisko,
                    Leki = string.Join(", ", w.Leki.Select(l => l.Nazwa)),
                    Opis = w.Opis
                })
                .ToList();

            visitDataGrid.DataSource = wizyty;

            if (visitDataGrid.Rows.Count > 0)
            {
                visitDataGrid.Rows[0].Selected = true;
                visitID = (int)visitDataGrid.Rows[0].Cells["Id"].Value;
                LoadVisitInfo(visitID);
            }
        }

        private void LoadVisitInfo(int visitId)
        {
            var factory = new AppDbContextFactory();
            using var context = factory.CreateDbContext(Array.Empty<string>());

            var wizyta = context.Wizyty
                .Where(w => w.Id == visitId)
                .Include(w => w.Lekarz)
                .Include(w => w.Zwierze)
                .Select(w => new
                {
                    Id = w.Id,
                    ZwierzeImie = w.Zwierze.Imie,
                    ZwierzeTyp = w.Zwierze.Typ,
                    ZwierzeGatunek = w.Zwierze.Gatunek,
                    ZwierzeWiek = w.Zwierze.Wiek,
                    Data = w.Data.ToString("dd-MM-yyyy"),
                    Zwierze = w.Zwierze != null ? w.Zwierze.Imie : "Brak danych",
                    Lekarz = w.Lekarz.Imie + " " + w.Lekarz.Nazwisko,
                    LekarzSpecjalizacja = w.Lekarz.Specjalizacja,
                    Opis = w.Opis
                })
                .FirstOrDefault();

            visitAnimalName.Text = wizyta.ZwierzeImie;
            visitAnimalType.Text = wizyta.ZwierzeTyp;
            visitAnimalSpecies.Text = wizyta.ZwierzeGatunek;
            visitAnimalAge.Text = "Wiek: " + wizyta.ZwierzeWiek.ToString();

            visitDateLabel.Text = wizyta.Data;
            visitDescription.Text = wizyta.Opis;

            visitDoctorName.Text = wizyta.Lekarz;
            visitDoctorSpecialization.Text = wizyta.LekarzSpecjalizacja;
        }

        private void visitDeleteButton_Click(object sender, EventArgs e)
        {
            var factory = new AppDbContextFactory();
            using var context = factory.CreateDbContext(Array.Empty<string>());

            Wizyta wizyta = context.Wizyty.Where(w => w.Id == (int)visitDataGrid.SelectedRows[0].Cells["Id"].Value).FirstOrDefault();

            context.Wizyty.Remove(wizyta);
            context.SaveChanges();
            LoadToVisitDataGrid();
        }

        private void visitEditButton_Click(object sender, EventArgs e)
        {
            var factory = new AppDbContextFactory();
            using var context = factory.CreateDbContext(Array.Empty<string>());

            var wizyta = context.Wizyty
                .Include(w => w.Lekarz)
                .Include(w => w.Zwierze)
                .Include(w => w.Leki)
                .FirstOrDefault(w => w.Id == visitID);

            var medIds = wizyta.Leki.Select(l => l.Id).ToList();

            visitDataPlaceholder.Controls.Clear();
            var view = new VisitAddForm(this._mainForm, wizyta.Zwierze.ToString(), wizyta.Lekarz.ToString(), wizyta.Data, wizyta.Opis, medIds);
            view.Dock = DockStyle.Fill;
            visitDataPlaceholder.Controls.Add(view);
        }

        private void visitDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            visitID = (int)visitDataGrid.SelectedRows[0].Cells["Id"].Value;
            LoadVisitInfo(visitID);
        }

        public void panelReturn()
        {
            visitDataPlaceholder.Controls.Clear();
            visitDataPlaceholder.Controls.Add(visitDataPanel);
        }
    }
}
