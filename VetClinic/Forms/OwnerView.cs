using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetClinic.Forms
{
    public partial class OwnerView : UserControl
    {
        private readonly MainForm _mainForm;
        public int selectedOwnerId;
        public OwnerView(MainForm mainForm, int selectedOwnerId = -1)
        {
            InitializeComponent();
            _mainForm = mainForm;
            this.selectedOwnerId = selectedOwnerId;
            LoadToOwnerList();
            LoadOwnerData();
        }

        private void ownerEditButton_Click(object sender, EventArgs e)
        {
            var factory = new AppDbContextFactory();
            using var context = factory.CreateDbContext(Array.Empty<string>());

            var wlasciciel = context.Osoby.Where(o => o.Id == selectedOwnerId).FirstOrDefault();

            ownerDataPanel.Controls.Clear();
            var view = new OwnerAddForm(this._mainForm, wlasciciel.Imie, wlasciciel.Nazwisko, wlasciciel.Data_ur, wlasciciel.Email, wlasciciel.Telefon);
            ownerDataPanel.Controls.Add(view);
            view.Dock = DockStyle.Fill;
        }

        private void ownerDeleteButton_Click(object sender, EventArgs e)
        {
            var factory = new AppDbContextFactory();
            using var context = factory.CreateDbContext(Array.Empty<string>());

            if(selectedOwnerId == -1)
            {
                MessageBox.Show("Nie można usunąć wybranego rekordu.");
                return;
            }

            var selectedOwner = context.Osoby.Where(o => o.Id == selectedOwnerId).FirstOrDefault();
            if (selectedOwner == null)
            {
                MessageBox.Show("Nie wybrano rekordu do usunięcia.");
                return;
            }

            var zwierzeta = context.Zwierzeta.Where(z => z.WlascicielId == selectedOwnerId).ToList();
            foreach(var zwierze in zwierzeta)
            {
                zwierze.WlascicielId = -1;
                context.Zwierzeta.Update(zwierze);
            }
            context.SaveChanges();

            context.Osoby.Remove(selectedOwner);
            context.SaveChanges();

            refreshList();
        }

        public void refreshList()
        {
            ownerList.Items.Clear();
            LoadToOwnerList();
        }

        private void ownerAddButton_Click(object sender, EventArgs e)
        {
            ownerDataPanel.Controls.Clear();
            var view = new OwnerAddForm(this._mainForm);
            ownerDataPanel.Controls.Add(view);
            view.Dock = DockStyle.Fill;
        }

        private void ownerSearchBox_TextChanged(object sender, EventArgs e)
        {
            var factory = new AppDbContextFactory();
            using var context = factory.CreateDbContext(Array.Empty<string>());

            string searchText = ownerSearchBox.Text.ToLower();

            var filtered = context.Osoby
                .Where(o => o.Imie.ToLower().Contains(searchText) ||
                            o.Nazwisko.ToLower().Contains(searchText))
                .OrderBy(o => o.Id)
                .ToList();

            ownerList.Items.Clear();

            foreach (var osoba in filtered)
            {
                ownerList.Items.Add(osoba.ToString());
            }
        }

        private void LoadToOwnerList()
        {
            var factory = new AppDbContextFactory();
            using var context = factory.CreateDbContext(Array.Empty<string>());

            var wlasciciele = context.Osoby.OrderBy(o => o.Id).ToList();
            foreach (var owner in wlasciciele)
            {
                ownerList.Items.Add(owner.ToString());
            }

            var selectedOwnerString = wlasciciele
                    .Where(o => o.Id == selectedOwnerId)
                    .Select(o => o.ToString())
                    .FirstOrDefault();

            if (selectedOwnerString != null)
            {
                ownerList.SelectedItem = selectedOwnerString;
            }
        }

        private void LoadOwnerData()
        {
            var factory = new AppDbContextFactory();
            using var context = factory.CreateDbContext(Array.Empty<string>());

            var wlasciciel = context.Osoby.Where(o => o.Id == selectedOwnerId).FirstOrDefault();
            var zwierzetaCount = context.Zwierzeta.Count(z => z.WlascicielId == selectedOwnerId);

            var today = DateTime.Today;
            int age = today.Year - wlasciciel.Data_ur.Year;

            if (wlasciciel.Data_ur.Date > today.AddYears(-age))
            {
                age--;
            }

            ownerNameLabel.Text = $"{wlasciciel.Imie} {wlasciciel.Nazwisko}";
            ownerAge.Text = "Wiek: " + age.ToString();
            birthdayLabel.Text = "Data urodzenia: " + wlasciciel.Data_ur.ToString("dd.MM.yyyy");
            animalCount.Text = "Liczba zarejestrowanych zwierząt: " + zwierzetaCount.ToString();
            ownerPhone.Text = "Numer Telefonu: " + wlasciciel.Telefon;
            ownerEmail.Text = "Email: " + wlasciciel.Email;
        }

        private void ownerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var listBox = sender as ListBox;
            if (listBox?.SelectedItem == null) return;

            string selectedItem = listBox.SelectedItem.ToString();
            selectedOwnerId = int.Parse(selectedItem.Split('.')[0]);

            LoadOwnerData();
        }

        public void panelReturn()
        {
            ownerDataPanel.Controls.Clear();
            ownerDataPanel.Controls.Add(ownerDataFlowLayout);
        }
    }
}
