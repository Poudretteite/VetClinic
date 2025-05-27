using Microsoft.EntityFrameworkCore;
using System.Data;
using VetClinic.Models;

namespace VetClinic.Forms
{
    public partial class AnimalAddForm : UserControl
    {
        private ListBox resultBox;
        private int selectedOwnerId;
        private readonly MainForm _mainForm;
        private string chosenTyp = null;
        private string chosenGatunek = null;
        private int mode;

        public AnimalAddForm(MainForm mainForm)
        {
            _mainForm = mainForm;
            InitializeComponent();
            initializeView();
            this.mode = 1;
        }

        public AnimalAddForm(MainForm mainForm, string imie, string gatunek, int? ownerId, int wiek, string typ)
        {
            _mainForm = mainForm;
            InitializeComponent();
            initializeView();

            using var context = Constants.CreateContext();

            if (ownerId.HasValue)
            {
                var osoba = MainForm.osoby.Where(o => o.Id == ownerId).FirstOrDefault();

                this.selectedOwnerId = ownerId.Value;
                ownerSearchBox.Text = $"{osoba.Imie} {osoba.Nazwisko}";
            }

            NameBox.Text = imie;
            typBox.SelectedItem = typ;
            gatunekBox.SelectedItem = gatunek;
            ageBox.Value = wiek;
            this.mode = 0;
        }
        private async Task AddAnimal(Zwierze zwierze)
        {
			using var context = Constants.CreateContext();

			context.Zwierzeta.Add(zwierze);
            await context.SaveChangesAsync();

            MainForm.zwierzeta = await context.Zwierzeta.ToListAsync();
		}

        private async Task EditAnimal(Zwierze zwierze)
        {
			using var context = Constants.CreateContext();

			context.Zwierzeta.Update(zwierze);
			await context.SaveChangesAsync();

            MainForm.zwierzeta = await context.Zwierzeta.ToListAsync();
		}

        private async void initializeView()
        {
            InitializeSearchControls();
            LoadToTypBox();
            LoadToGatunekBox(null, EventArgs.Empty);
        }

        private void InitializeSearchControls()
        {
            resultBox = new ListBox
            {
                Location = Location = new Point(ownerSearchBox.Left, ownerSearchBox.Bottom),
                Width = 200,
                Height = 100,
                Visible = false
            };

            this.Controls.Add(resultBox);
            resultBox.BringToFront();

            ownerSearchBox.TextChanged += ownerSearchBox_TextChanged;
            resultBox.Click += ResultBox_Click;
        }

        private void ownerSearchBox_TextChanged(object sender, EventArgs e)
        {
            using var context = Constants.CreateContext();

            var wlasciciele = MainForm.osoby.Take(10);

            string searchText = ownerSearchBox.Text.ToLower();
            var filtered = wlasciciele
                .Where(z => z.Imie.ToLower().Contains(searchText) ||
                            z.Nazwisko.ToLower().Contains(searchText))
                .ToList();

            UpdateResultBox(filtered);
        }

        private void UpdateResultBox(List<Osoba> matches)
        {
            resultBox.Items.Clear();
            resultBox.Visible = matches.Any();

            if (matches.Any())
            {
                resultBox.Items.AddRange(matches.ToArray());
            }
        }

        private void ResultBox_Click(object sender, EventArgs e)
        {
            if (resultBox.SelectedItem is Osoba osoba)
            {
                selectedOwnerId = osoba.Id;
                ownerSearchBox.Text = $"{osoba.Imie} {osoba.Nazwisko}";
                resultBox.Visible = false;
            }
        }

        private void LoadToTypBox()
        {
            typBox.Items.Clear();
            typBox.Items.AddRange(Constants.AnimalSpeciesByType.Keys.ToArray());
            typBox.SelectedIndex = -1;
        }

        private void LoadToGatunekBox(object sender, EventArgs e)
        {
            if (typBox.SelectedItem is not string typ)
            {
                gatunekBox.Items.Clear();
                gatunekBox.Enabled = false;
                chosenTyp = null;
                chosenGatunek = null;
                return;
            }

            chosenTyp = typ;

            gatunekBox.Items.Clear();

            if (Constants.AnimalSpeciesByType.TryGetValue(typ, out var speciesList) && speciesList.Count > 0)
            {
                gatunekBox.Enabled = true;
                gatunekBox.Items.AddRange(speciesList.ToArray());
                gatunekBox.SelectedIndex = -1;
                chosenGatunek = null;
            }
            else
            {
                gatunekBox.Enabled = false;
                chosenGatunek = null;
            }
        }

        private void gatunekBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (gatunekBox.SelectedItem is string species)
            {
                chosenGatunek = species;
            }
            else
            {
                chosenGatunek = null;
            }
        }

        private async void acceptButton_Click(object sender, EventArgs e)
        {
            if(mode == 1)
            {
                int maxId = MainForm.zwierzeta.Max(z => z.Id);

                var zwierze = new Zwierze()
                {
                    Id = maxId + 1,
                    Imie = NameBox.Text,
                    Typ = chosenTyp,
                    Gatunek = chosenGatunek,
                    Wiek = (int)ageBox.Value,
                    WlascicielId = selectedOwnerId
                };

                await AddAnimal(zwierze);

				MainForm.animalview.selectedAnimalId = zwierze.Id;
				string typ = zwierze.Typ;
				MainForm.animalview.RefreshCurrentTab(typ);
			}
            else
            {
				var zwierze = MainForm.zwierzeta.FirstOrDefault(z => z.Id == MainForm.animalview.selectedAnimalId);
				if (zwierze == null) return;

				zwierze.Imie = NameBox.Text;
                zwierze.Typ = chosenTyp;
                zwierze.Gatunek = chosenGatunek;
                zwierze.Wiek = (int)ageBox.Value;
                zwierze.WlascicielId = selectedOwnerId;

                await EditAnimal(zwierze);

				string typ = zwierze.Typ;
				MainForm.animalview.RefreshCurrentTab(typ);
			}

            MainForm.animalview.panelReturn();
            MainForm.animalview.LoadToAnimalTabControl();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            MainForm.animalview.panelReturn();
        }
    }
}
