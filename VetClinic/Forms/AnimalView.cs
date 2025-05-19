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

namespace VetClinic
{
    public partial class AnimalView : UserControl
    {
        private readonly MainForm _mainForm;
        private int tabIndex = 0;
        private TabPage searchTab;
        private ListBox searchList;
        private int selectedId;

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


        private void LoadToAnimalTabControl()
        {
            var factory = new AppDbContextFactory();
            using var context = factory.CreateDbContext(Array.Empty<string>());

            var defaultSelected = 0;
            var typy = Constants.AnimalType;

            foreach (var typ in typy)
            {
                var newTab = new TabPage($"{typ}");
                var list = new ListBox();
                list.SelectedIndexChanged += ListBox_SelectedIndexChanged;
                var zwierzeta = context.Zwierzeta.Where(z => z.Typ == typ).ToList();
                if (zwierzeta.Count > 0)
                {
                    foreach (var zwierze in zwierzeta)
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
                MessageBox.Show("Wybierz zwierzę z listy.");
                return;
            }


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

            Zwierze zwierze = context.Zwierzeta.Where(z => z.Id == selectedId).FirstOrDefault();

            context.Zwierzeta.Remove(zwierze);
            context.SaveChanges();
            RefreshCurrentTab();
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
            int ownerId = zwierze.WlascicielId;
            Osoba owner = context.Osoby.Where(o => o.Id == ownerId).FirstOrDefault();
            animalOwnerNameLabel.Text = $"{owner.Imie} {owner.Nazwisko}";

        }

        private void RefreshCurrentTab()
        {
            var factory = new AppDbContextFactory();
            using var context = factory.CreateDbContext(Array.Empty<string>());

            var selectedTab = animalTabControl.SelectedTab;
            if (selectedTab == null) return;

            if (selectedTab == searchTab)
            {
                searchBox_TextChanged(null, null);
                return;
            }

            string tabType = selectedTab.Text;
            var updated = context.Zwierzeta.Where(z => z.Typ == tabType).ToList();

            var listBox = selectedTab.Controls.OfType<ListBox>().FirstOrDefault();
            if (listBox == null) return;

            listBox.Items.Clear();
            foreach (var zwierze in updated)
            {
                listBox.Items.Add($"{zwierze.Id}. {zwierze.Imie}  -  {zwierze.Gatunek}");
            }

            LoadData();
        }

        private void LoadAnimalVisitDataGrid()
        {
            var factory = new AppDbContextFactory();
            using var context = factory.CreateDbContext(Array.Empty<string>());

            var wizyty = context.Wizyty.Where(w => w.ZwierzeId == selectedId).ToList();
            animalVisitDataGrid.DataSource = wizyty;
        }

        private void animalOwnerLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
