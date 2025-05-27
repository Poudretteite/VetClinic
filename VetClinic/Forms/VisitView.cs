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
            this.Load += VisitView_Load;
        }

        private async void VisitView_Load(object sender, EventArgs e)
        {
            await LoadToLists();
            await LoadToVisitDataGrid();
        }

        private async Task LoadToLists()
        {
            using var context = Constants.CreateContext();

            if (MainForm.wizyty == null) MainForm.wizyty = await context.Wizyty.Include(w => w.Leki).ToListAsync();
            if (MainForm.lekarze == null) MainForm.lekarze = await context.Lekarze.ToListAsync();
            if (MainForm.leki == null) MainForm.leki = await context.Leki.ToListAsync();
        }

        private async Task DeleteVisit(Wizyta wizyta)
        {
            using var context = Constants.CreateContext();

            context.Wizyty.Update(wizyta);
            context.SaveChanges();

            MainForm.wizyty = await context.Wizyty.ToListAsync();
        }

        public async Task LoadToVisitDataGrid()
        {
            using var context = Constants.CreateContext();

            visitDataGrid.DataSource = null;
            visitDataGrid.Columns.Clear();
            visitDataGrid.Rows.Clear();

            var wizyty = await context.Wizyty
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
                .ToListAsync();

            visitDataGrid.DataSource = wizyty;

            if (visitDataGrid.Rows.Count > 0)
            {
                visitDataGrid.Rows[0].Selected = true;
                visitID = (int)visitDataGrid.Rows[0].Cells["Id"].Value;
                LoadVisitInfo(visitID);
            }
        }

        private async Task LoadVisitInfo(int visitId)
        {
            using var context = Constants.CreateContext();

            var wizyta = await context.Wizyty
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
                .FirstOrDefaultAsync();

            visitAnimalName.Text = wizyta.ZwierzeImie;
            visitAnimalType.Text = wizyta.ZwierzeTyp;
            visitAnimalSpecies.Text = wizyta.ZwierzeGatunek;
            visitAnimalAge.Text = "Wiek: " + wizyta.ZwierzeWiek.ToString();

            visitDateLabel.Text = wizyta.Data;
            visitDescription.Text = wizyta.Opis;

            visitDoctorName.Text = wizyta.Lekarz;
            visitDoctorSpecialization.Text = wizyta.LekarzSpecjalizacja;
        }

        private async void visitDeleteButton_Click(object sender, EventArgs e)
        {
            Wizyta wizyta = MainForm.wizyty.Where(w => w.Id == (int)visitDataGrid.SelectedRows[0].Cells["Id"].Value).FirstOrDefault();

            await DeleteVisit(wizyta);
            await LoadToVisitDataGrid();
        }

        private void visitEditButton_Click(object sender, EventArgs e)
        {
            using var context = Constants.CreateContext();

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
