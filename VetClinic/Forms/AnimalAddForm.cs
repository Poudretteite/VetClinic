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
    public partial class AnimalAddForm : UserControl
    {
        private ListBox resultBox;
        private Osoba selectedOwner;
        private readonly MainForm _mainForm;
        private string chosenTyp = null;
        private string chosenGatunek = null;

        public AnimalAddForm(MainForm mainForm)
        {
            _mainForm = mainForm;
            InitializeComponent();
            InitializeSearchControls();
            LoadToTypBox();
            LoadToGatunekBox(null, EventArgs.Empty);
            gatunekBox.Enabled = false;
        }

        private void InitializeSearchControls()
        {
            resultBox = new ListBox
            {
                Location = Location = new Point(ownerSearchBox.Left, ownerSearchBox.Bottom + 2),
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
            var factory = new AppDbContextFactory();
            using var context = factory.CreateDbContext(Array.Empty<string>());

            var wlasciciele = context.Osoby.ToList();

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
                selectedOwner = osoba;
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

    }
}
