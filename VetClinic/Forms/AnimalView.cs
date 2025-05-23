using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VetClinic.Forms;
using VetClinic.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VetClinic
{
    public partial class AnimalView : UserControl
    {
        private readonly MainForm _mainForm;
        private int tabIndex = 0;
        private TabPage searchTab;
        private ListBox searchList;
        public int selectedId;
        public int mode;

        public AnimalView(MainForm mainForm)
        {
            _mainForm = mainForm;
            InitializeComponent();
            this.Load += AnimalView_Load;
        }

        private void AnimalView_Load(object sender, EventArgs e)
        {
            LoadToAnimalTabControl();
            LoadData();
            LoadAnimalVisitDataGrid();

            searchTab = new TabPage("Wyszukiwanie");
            searchList = new ListBox { Dock = DockStyle.Fill };
            searchTab.Controls.Add(searchList);
            animalTabControl.TabPages.Add(searchTab);
        }


        public void LoadToAnimalTabControl()
        {
            var factory = new AppDbContextFactory();
            using var context = factory.CreateDbContext(Array.Empty<string>());

            foreach (var typ in Constants.AnimalType)
            {
                var newTab = new TabPage(typ);
                var list = new ListBox();
                list.SelectedIndexChanged += ListBox_SelectedIndexChanged;
                var zwierzeta = context.Zwierzeta.Where(z => z.Typ == typ).ToList();
                if (zwierzeta.Count > 0)
                {
                    foreach (var zwierze in zwierzeta.OrderBy(z => z.Id))
                    {
                        list.Items.Add($"{zwierze.Id}. {zwierze.Imie}  -  {zwierze.Gatunek}");
                    }

                    list.Dock = DockStyle.Fill;
                    newTab.Controls.Add(list);
                }
                else
                {
                    var nullLabel = new Label();
                    nullLabel.Text = "Brak rekordów";
                    nullLabel.Dock = DockStyle.Fill;

                    newTab.Controls.Add(nullLabel);
                }
                animalTabControl.TabPages.Add(newTab);
            }

            animalTabControl.TabPages[0].Controls.OfType<ListBox>().First().SelectedIndex = 0;
        }

        private int? GetSelectedAnimalId()
        {
            if (animalTabControl.SelectedTab.Controls.Count == 0)
                return null;

            var listBox = animalTabControl.SelectedTab.Controls[0] as ListBox;
            if (listBox == null || listBox.SelectedItem == null)
                return null;

            var selectedItem = listBox.SelectedItem.ToString();
            var idPart = selectedItem.Split('.')[0];

            if (int.TryParse(idPart, out int id))
                return id;

            return null;
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            var factory = new AppDbContextFactory();
            using var context = factory.CreateDbContext(Array.Empty<string>());

            string searchText = searchBox.Text.ToLower();

            var filtered = context.Zwierzeta
                .Where(z => z.Imie.ToLower().Contains(searchText) ||
                            z.Gatunek.ToLower().Contains(searchText))
                .ToList();

            searchList.Items.Clear();

            foreach (var zwierze in filtered)
            {
                searchList.Items.Add($"{zwierze.Id}. {zwierze.Imie}  -  {zwierze.Gatunek}");
            }

            if (animalTabControl.SelectedTab != searchTab)
            {
                animalTabControl.SelectedTab = searchTab;
                BeginInvoke(new Action(() => searchBox.Focus()));
            }
        }

        private void animalEditButton_Click(object sender, EventArgs e)
        {
            var factory = new AppDbContextFactory();
            using var context = factory.CreateDbContext(Array.Empty<string>());

            int? selectedId = GetSelectedAnimalId();
            if (selectedId == null)
            {
                selectedId = context.Zwierzeta.Where(z => z.Typ == Constants.AnimalType[0]).FirstOrDefault().Id;
            }

            animalDataForm.Controls.Clear();
            Zwierze zwierze = context.Zwierzeta.Where(z => z.Id == selectedId).FirstOrDefault();
            var view = new AnimalAddForm(this._mainForm, zwierze.Imie, zwierze.Gatunek, zwierze.WlascicielId, zwierze.Wiek, zwierze.Typ);
            view.Dock = DockStyle.Fill;
            animalDataForm.Controls.Add(view);

        }

        private void animalDeleteButton_Click(object sender, EventArgs e)
        {
            var factory = new AppDbContextFactory();
            using var context = factory.CreateDbContext(Array.Empty<string>());

            int? selectedId = GetSelectedAnimalId();
            if (selectedId == null)
            {
                MessageBox.Show("Wybierz zwierzę z listy.");
                return;
            }

            var selectedAnimal = context.Zwierzeta.FirstOrDefault(z => z.Id == selectedId);
            if (selectedAnimal == null) { return; }

            string typ = selectedAnimal.Typ;

            var wizyty = context.Wizyty.Where(w => w.ZwierzeId == selectedId).FirstOrDefault();
            if (wizyty != null)
            {
                var result = MessageBox.Show(
                    "Nie zaleca się usuwania zwierząt z zarejestrowanymi wizytami. Czy na pewno chcesz kontynuować?",
                    "Potwierdzenie usunięcia",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.No)
                {
                    return;
                }
            }

            Zwierze zwierze = context.Zwierzeta.Where(z => z.Id == selectedId).FirstOrDefault();

            context.Zwierzeta.Remove(zwierze);
            context.SaveChanges();

            RefreshCurrentTab(typ);
        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var listBox = sender as ListBox;
            if (listBox?.SelectedItem == null) return;

            string selectedItem = listBox.SelectedItem.ToString();
            selectedId = int.Parse(selectedItem.Split('.')[0]);

            LoadAnimalVisitDataGrid();
            LoadData(selectedId);
        }

        private void LoadData(int id = 0)
        {
            var factory = new AppDbContextFactory();
            using var context = factory.CreateDbContext(Array.Empty<string>());
            Zwierze zwierze;

            if (id == 0)
            {
                zwierze = context.Zwierzeta.Where(z => z.Typ == Constants.AnimalType[0]).FirstOrDefault();
            }
            else
            {
                zwierze = context.Zwierzeta.Where(z => z.Id == selectedId).FirstOrDefault();
            }

            animalNameLabel.Text = zwierze.Imie;
            animalTypeLabel.Text = zwierze.Typ;
            animalSpeciesLabel.Text = zwierze.Gatunek;
            animalAge.Text = zwierze.Wiek.ToString();
            int ownerId = zwierze.WlascicielId;
            Osoba owner = context.Osoby.Where(o => o.Id == ownerId).FirstOrDefault();
            animalOwnerNameLabel.Text = $"{owner.Imie} {owner.Nazwisko}";

        }

        public void RefreshCurrentTab(string typ)
        {
            var factory = new AppDbContextFactory();
            using var context = factory.CreateDbContext(Array.Empty<string>());

            var targetTab = animalTabControl.TabPages
                .Cast<TabPage>()
                .FirstOrDefault(tab => tab.Text == typ);

            if (targetTab == null) return;

            var updatedAnimals = context.Zwierzeta
                .Where(z => z.Typ == typ)
                .ToList();

            var listBox = targetTab.Controls.OfType<ListBox>().FirstOrDefault();
            if (listBox == null) return;

            listBox.Items.Clear();

            foreach (var zwierze in updatedAnimals.OrderBy(z => z.Id))
            {
                listBox.Items.Add($"{zwierze.Id}. {zwierze.Imie}  -  {zwierze.Gatunek}");
            }

            LoadData();
        }


        private void LoadAnimalVisitDataGrid()
        {
            var factory = new AppDbContextFactory();
            using var context = factory.CreateDbContext(Array.Empty<string>());

            var wizyty = context.Wizyty
            .Where(w => w.ZwierzeId == selectedId)
            .Include(w => w.Lekarz)
            .Select(w => new
            {
                Data = w.Data.ToString("yyyy-MM-dd"),
                Opis = w.Opis,
                Lekarz = w.Lekarz.Imie + " " + w.Lekarz.Nazwisko
            })
            .ToList();

            animalVisitDataGrid.DataSource = null;
            animalVisitDataGrid.Rows.Clear();
            animalVisitDataGrid.Columns.Clear();

            if (wizyty.Count == 0)
            {
                animalVisitDataGrid.Columns.Add("Info", "Informacja");
                animalVisitDataGrid.Rows.Add("Brak wizyt dla wybranego zwierzęcia.");
                animalVisitDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                return;
            }

            animalVisitDataGrid.DataSource = wizyty;

            animalVisitDataGrid.Columns[0].HeaderText = "Data wizyty";
            animalVisitDataGrid.Columns[1].HeaderText = "Opis";
            animalVisitDataGrid.Columns[2].HeaderText = "Lekarz prowadzący";
        }

        private void animalOwnerLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void animalAddButton_Click(object sender, EventArgs e)
        {
            animalDataForm.Controls.Clear();
            var view = new AnimalAddForm(this._mainForm);
            view.Dock = DockStyle.Fill;
            animalDataForm.Controls.Add(view);
        }

        public void panelReturn()
        {
            animalDataForm.Controls.Clear();
            animalDataForm.Controls.Add(animalDataLayout);
        }

        private void animalAddVisitButtton_Click(object sender, EventArgs e)
        {
            animalDataForm.Controls.Clear();
            var view = new VisitAddForm(this._mainForm);
            view.Dock = DockStyle.Fill;
            animalDataForm.Controls.Add(view);
        }
    }
}
