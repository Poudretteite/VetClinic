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

        private void MedicineView_Load(object sender, EventArgs e)
        {
            LoadToMedicineList();
            LoadToVisitDataGrid();
            LoadMedData();
        }

        private void LoadToMedicineList()
        {
            var factory = new AppDbContextFactory();
            using var context = factory.CreateDbContext(Array.Empty<String>());

            var leki = context.Leki.ToList();

            medicineList.Items.Clear();

            foreach (var lek in leki)
            {
                medicineList.Items.Add(lek.Nazwa);
            }

            selectedMedId = context.Leki.Min(l => l.Id);
        }

        private void LoadToVisitDataGrid()
        {
            var factory = new AppDbContextFactory();
            using var context = factory.CreateDbContext(Array.Empty<String>());

            var wizyty = context.Wizyty
                .Where(w => w.Leki.Any(l => l.Id == selectedMedId))
                .Include(w => w.Lekarz)
                .Select(w => new
                {
                    Id = w.Id,
                    Data = w.Data,
                    Lekarz = $"{w.Lekarz.Imie} {w.Lekarz.Nazwisko}"

                })
                .ToList();

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
            var factory = new AppDbContextFactory();
            using var context = factory.CreateDbContext(Array.Empty<String>());

            var lek = context.Leki.Where(l => l.Id == selectedMedId).First();
            StatsLabel.Text = lek.Nazwa;
            medCount.Text = "Ilość: " + lek.Ilosc;
            medVisitCount.Text = "Liczba wizyt, na których został użyty: " + context.Wizyty.Count(w => w.Leki.Any(l => l.Id == selectedMedId));
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
            var factory = new AppDbContextFactory();
            using var context = factory.CreateDbContext(Array.Empty<String>());

            var lek = context.Leki.Where(l => l.Id == selectedMedId).First();

            medDataPlaceholder.Controls.Clear();
            var view = new MedicineAddForm(this._mainForm, lek.Nazwa, lek.Ilosc);
            medDataPlaceholder.Controls.Add(view);
            view.Dock = DockStyle.Fill;
        }

        private void medDeleteButton_Click(object sender, EventArgs e)
        {
            var factory = new AppDbContextFactory();
            using var context = factory.CreateDbContext(Array.Empty<String>());

            if (context.Wizyty.Count(w => w.Leki.Any(l => l.Id == selectedMedId)) > 0)
            {
                MessageBox.Show("Usuwanie leków, które były już wykorzystane jest niemożliwe");
                return;
            }
            
            var lek = context.Leki.Where(l => l.Id == selectedMedId).First();
            if (lek != null)
            {
                context.Leki.Remove(lek);
                context.SaveChanges();

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

        private void medicineList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var listBox = sender as ListBox;
            if (listBox?.SelectedItem == null) return;

            var factory = new AppDbContextFactory();
            using var context = factory.CreateDbContext(Array.Empty<String>());

            string selectedItem = listBox.SelectedItem.ToString();
            selectedMedId = context.Leki.Where(l => l.Nazwa == selectedItem).First().Id;

            LoadMedData();
            LoadToVisitDataGrid();
        }

        public void panelReturn()
        {
            medDataPlaceholder.Controls.Clear();
            medDataPlaceholder.Controls.Add(statsPanel);
        }

        public void refresh()
        {
            LoadToMedicineList();
            LoadMedData();
            LoadToVisitDataGrid();
        }
    }
}
