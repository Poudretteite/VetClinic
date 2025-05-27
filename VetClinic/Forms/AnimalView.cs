using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Threading.Tasks;
using VetClinic.Forms;
using VetClinic.Models;

namespace VetClinic
{
    public partial class AnimalView : UserControl
    {
        private readonly MainForm _mainForm;
        private TabPage searchTab = new TabPage("Wyszukiwanie");
        private ListBox searchList;
        public int selectedAnimalId;
        public int mode;
        private int ownerId;

        public AnimalView(MainForm mainForm)
        {
            _mainForm = mainForm;
            InitializeComponent();
            this.Load += AnimalView_Load;
        }

        private async void AnimalView_Load(object sender, EventArgs e)
        {
            await LoadToLists();
            LoadToAnimalTabControl();
            LoadData();
            await LoadAnimalVisitDataGrid();

            searchList = new ListBox { Dock = DockStyle.Fill };
            searchTab.Controls.Add(searchList);
            animalTabControl.TabPages.Add(searchTab);
        }

        private async Task LoadToLists()
        {
            using var context = Constants.CreateContext();
            if (MainForm.zwierzeta == null) MainForm.zwierzeta = await context.Zwierzeta.ToListAsync();
            if (MainForm.wizyty == null) MainForm.wizyty = await context.Wizyty.ToListAsync();
            if (MainForm.osoby == null) MainForm.osoby = await context.Osoby.ToListAsync();
        }

        private async Task DeleteAnimal(int deleteId)
        {
            using var context = Constants.CreateContext();

            var zwierze = MainForm.zwierzeta.Where(z => z.Id == deleteId).FirstOrDefault();

            context.Zwierzeta.Remove(zwierze);
            await context.SaveChangesAsync();

            MainForm.zwierzeta = await context.Zwierzeta.ToListAsync();
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            string searchText = searchBox.Text.ToLower();

            var filtered = MainForm.zwierzeta
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
            int selectedId = GetSelectedAnimalId();
            selectedId = MainForm.zwierzeta.Where(z => z.Typ == Constants.AnimalType[0]).FirstOrDefault().Id;

            animalDataForm.Controls.Clear();
            Zwierze zwierze = MainForm.zwierzeta.Where(z => z.Id == selectedId).FirstOrDefault();
            var view = new AnimalAddForm(this._mainForm, zwierze.Imie, zwierze.Gatunek, zwierze.WlascicielId, zwierze.Wiek, zwierze.Typ);
            view.Dock = DockStyle.Fill;
            animalDataForm.Controls.Add(view);

        }

        private async void animalDeleteButton_Click(object sender, EventArgs e)
        {

            int selectedId = GetSelectedAnimalId();

            var selectedAnimal = MainForm.zwierzeta.FirstOrDefault(z => z.Id == selectedId);
            if (selectedAnimal == null) { return; }

            string typ = selectedAnimal.Typ;

            var wizytyByZwierze = MainForm.wizyty.FirstOrDefault(w => w.ZwierzeId == selectedId);
            if (wizytyByZwierze != null)
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

            await DeleteAnimal(selectedId);
            RefreshCurrentTab(typ);
            LoadData();
        }

        private async void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var listBox = sender as ListBox;
            if (listBox?.SelectedItem == null) return;

            string selectedItem = listBox.SelectedItem.ToString();
            selectedAnimalId = int.Parse(selectedItem.Split('.')[0]);

            await LoadAnimalVisitDataGrid();
            LoadData(selectedAnimalId);
        }

        private void animalOwnerLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MainForm.ownerview = new OwnerView(this._mainForm, ownerId);
            _mainForm.LoadView(MainForm.ownerview);
        }

        private void animalAddButton_Click(object sender, EventArgs e)
        {
            animalDataForm.Controls.Clear();
            var view = new AnimalAddForm(this._mainForm);
            view.Dock = DockStyle.Fill;
            animalDataForm.Controls.Add(view);
        }

        private void animalAddVisitButtton_Click(object sender, EventArgs e)
        {
            animalDataForm.Controls.Clear();
            var view = new VisitAddForm(this._mainForm);
            view.Dock = DockStyle.Fill;
            animalDataForm.Controls.Add(view);
        }

        private int GetSelectedAnimalId()
        {
            var listBox = (ListBox)animalTabControl.SelectedTab.Controls[0];
            var selectedItem = listBox.SelectedItem.ToString();
            var idPart = selectedItem.Split('.')[0];

            return int.Parse(idPart);
        }

        private void LoadData(int id = 0)
        {
            Zwierze zwierze;

            if (id == 0)
            {
                zwierze = MainForm.zwierzeta.Where(z => z.Typ == Constants.AnimalType[0]).FirstOrDefault();
            }
            else
            {
                zwierze = MainForm.zwierzeta.Where(z => z.Id == selectedAnimalId).FirstOrDefault();
            }

            animalNameLabel.Text = zwierze.Imie;
            animalTypeLabel.Text = zwierze.Typ;
            animalSpeciesLabel.Text = zwierze.Gatunek;
            animalAge.Text = zwierze.Wiek.ToString();
            ownerId = zwierze.WlascicielId;
            Osoba owner = MainForm.osoby.Where(o => o.Id == ownerId).FirstOrDefault();
            animalOwnerNameLabel.Text = $"{owner.Imie} {owner.Nazwisko}";

        }

        public void RefreshCurrentTab(string typ)
        {
            var targetTab = animalTabControl.TabPages
                .Cast<TabPage>()
                .FirstOrDefault(tab => tab.Text == typ);

            if (targetTab == null) return;

            var updatedAnimals = MainForm.zwierzeta
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

        public async Task LoadAnimalVisitDataGrid()
        {
            using var context = Constants.CreateContext();

            var wizytyByZwierze = await context.Wizyty
                .Where(w => w.ZwierzeId == selectedAnimalId)
                .Include(w => w.Lekarz)
                .Select(w => new
                {
                    Data = w.Data.ToString("yyyy-MM-dd"),
                    Opis = w.Opis,
                    Lekarz = w.Lekarz.Imie + " " + w.Lekarz.Nazwisko
                })
                .ToListAsync();

            animalVisitDataGrid.DataSource = null;
            animalVisitDataGrid.Rows.Clear();
            animalVisitDataGrid.Columns.Clear();

            if (wizytyByZwierze.Count == 0)
            {
                animalVisitDataGrid.Columns.Add("Info", "Informacja");
                animalVisitDataGrid.Rows.Add("Brak wizyt dla wybranego zwierzęcia.");
                animalVisitDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                return;
            }

            animalVisitDataGrid.DataSource = wizytyByZwierze;
        }

        public void LoadToAnimalTabControl()
        {
            animalTabControl.TabPages.Clear();
            foreach (var typ in Constants.AnimalType)
            {
                var newTab = new TabPage(typ);
                var list = new ListBox();
                list.SelectedIndexChanged += ListBox_SelectedIndexChanged;
                var zwierzetaByType = MainForm.zwierzeta.Where(z => z.Typ == typ).ToList();
                if (zwierzetaByType.Count > 0)
                {
                    foreach (var zwierze in zwierzetaByType.OrderBy(z => z.Id))
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
                    nullLabel.TextAlign = ContentAlignment.MiddleCenter;
                    nullLabel.Dock = DockStyle.Fill;
                    newTab.Controls.Add(nullLabel);
                }
                animalTabControl.TabPages.Add(newTab);
            }

            animalTabControl.TabPages[0].Controls.OfType<ListBox>().FirstOrDefault().SelectedIndex = 0;
        }

        public void panelReturn()
        {
            animalDataForm.Controls.Clear();
            animalDataForm.Controls.Add(animalDataLayout);
        }
    }
}
