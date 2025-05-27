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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VetClinic.Forms
{
    public partial class MedicineView : UserControl
    {
        private readonly MainForm _mainForm;
        public int selectedMedId;

        public MedicineView(MainForm mainForm)
        {
            _mainForm = mainForm;
            InitializeComponent();
            this.Load += MedicineView_Load;
        }

        private async void MedicineView_Load(object sender, EventArgs e)
        {
            await LoadToLists();
            LoadToMedicineList();
            await LoadToVisitDataGrid();
            LoadMedData();
        }

        private async Task LoadToLists()
        {
            using var context = Constants.CreateContext();

            if (MainForm.leki == null) MainForm.leki = await context.Leki.ToListAsync();
            if (MainForm.wizyty == null) MainForm.wizyty = await context.Wizyty.ToListAsync();
        }

        private async Task DeleteMed(Lek lek)
        {
            using var context = Constants.CreateContext();

            context.Leki.Remove(lek);
            await context.SaveChangesAsync();

            MainForm.leki = await context.Leki.ToListAsync();
        }

        private void LoadToMedicineList()
        {
            var leki = MainForm.leki.ToList();

            medicineList.Items.Clear();

            foreach (var lek in leki)
            {
                medicineList.Items.Add(lek.Nazwa);
            }

            selectedMedId = MainForm.leki.Min(l => l.Id);
        }

        private async Task LoadToVisitDataGrid()
        {
            using var context = Constants.CreateContext();

            var wizyty = await context.Wizyty
                .Where(w => w.Leki.Any(l => l.Id == selectedMedId))
                .Include(w => w.Lekarz)
                .Select(w => new
                {
                    Id = w.Id,
                    Data = w.Data,
                    Lekarz = $"{w.Lekarz.Imie} {w.Lekarz.Nazwisko}"

                })
                .ToListAsync();

            visitDataGrid.DataSource = null;
            visitDataGrid.Rows.Clear();
            visitDataGrid.Columns.Clear();

            if (wizyty.Count == 0)
            {
                visitDataGrid.Columns.Add("Info", "Informacja");
                visitDataGrid.Rows.Add("Brak wizyt z użyciem wybranego leku.");
                visitDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                return;
            }

            visitDataGrid.DataSource = wizyty;
        }

        private void LoadMedData()
        {
            var lek = MainForm.leki.Where(l => l.Id == selectedMedId).FirstOrDefault();
            StatsLabel.Text = lek.Nazwa;
            medCount.Text = "Ilość: " + lek.Ilosc;
            medVisitCount.Text = "Liczba wizyt, na których został użyty: " + MainForm.wizyty.Count(w => w.Leki.Any(l => l.Id == selectedMedId));
        }

        private void medAddButton_Click(object sender, EventArgs e)
        {
            medDataPlaceholder.Controls.Clear();
            var view = new MedicineAddForm(this._mainForm);
            medDataPlaceholder.Controls.Add(view);
            view.Dock = DockStyle.Fill;
        }

        private void medEditButton_Click(object sender, EventArgs e)
        {
            var lek = MainForm.leki.Where(l => l.Id == selectedMedId).FirstOrDefault();

            medDataPlaceholder.Controls.Clear();
            var view = new MedicineAddForm(this._mainForm, lek.Nazwa, lek.Ilosc);
            medDataPlaceholder.Controls.Add(view);
            view.Dock = DockStyle.Fill;
        }

        private async void medDeleteButton_Click(object sender, EventArgs e)
        {
            if (MainForm.wizyty.Count(w => w.Leki.Any(l => l.Id == selectedMedId)) > 0)
            {
                MessageBox.Show("Usuwanie leków, które były już wykorzystane jest niemożliwe");
                return;
            }
            
            var lek = MainForm.leki.Where(l => l.Id == selectedMedId).FirstOrDefault();
            if (lek != null)
            {
                await DeleteMed(lek);
                refresh();
            }
        }

        private void medOrderButton_Click(object sender, EventArgs e)
        {
            medDataPlaceholder.Controls.Clear();
            var view = new OrderAddForm(this._mainForm);
            medDataPlaceholder.Controls.Add(view);
            view.Dock = DockStyle.Fill;
        }

        private async void medicineList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var listBox = sender as ListBox;
            if (listBox?.SelectedItem == null) return;

            var factory = new AppDbContextFactory();
            using var context = factory.CreateDbContext(Array.Empty<String>());

            string selectedItem = listBox.SelectedItem.ToString();
            selectedMedId = MainForm.leki.Where(l => l.Nazwa == selectedItem).FirstOrDefault().Id;

            LoadMedData();
            await LoadToVisitDataGrid();
        }

        public void panelReturn()
        {
            medDataPlaceholder.Controls.Clear();
            medDataPlaceholder.Controls.Add(statsPanel);
        }

        public async void refresh()
        {
            LoadToMedicineList();
            LoadMedData();
            await LoadToVisitDataGrid();
        }
    }
}
