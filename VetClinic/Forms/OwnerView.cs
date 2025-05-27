using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using VetClinic.Models;

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
            this.Load += OwnerView_Load;
        }

        private async void OwnerView_Load(object sender, EventArgs e)
        {
            await LoadToLists();

            LoadToOwnerList();
            LoadOwnerData();
            LoadToOwnerAnimalList();
        }

        private async Task LoadToLists()
        {
            using var context = Constants.CreateContext();

            if (MainForm.osoby == null) MainForm.osoby = await context.Osoby.ToListAsync();
            if (MainForm.zwierzeta == null) MainForm.zwierzeta = await context.Zwierzeta.ToListAsync();
        }

        private async Task DeleteOwner(Osoba osoba, List<Zwierze> zwierzeta)
        {
            using var context = Constants.CreateContext();

            foreach (var zwierze in zwierzeta)
            {
                zwierze.WlascicielId = -1;
                context.Zwierzeta.Update(zwierze);
            }
            context.SaveChanges();

            context.Osoby.Remove(osoba);
            context.SaveChanges();
        }

        private void ownerEditButton_Click(object sender, EventArgs e)
        {

            if (selectedOwnerId == -1)
            {
                MessageBox.Show("Nie można modyfikować wybranego rekordu");
                return;
            }

            var wlasciciel = MainForm.osoby.FirstOrDefault(o => o.Id == selectedOwnerId);

            ownerDataPanel.Controls.Clear();
            var view = new OwnerAddForm(this._mainForm, wlasciciel.Imie, wlasciciel.Nazwisko, wlasciciel.Data_ur, wlasciciel.Email, wlasciciel.Telefon);
            ownerDataPanel.Controls.Add(view);
            view.Dock = DockStyle.Fill;
        }

        private async void ownerDeleteButton_Click(object sender, EventArgs e)
        {
            if(selectedOwnerId == -1)
            {
                MessageBox.Show("Nie można usunąć wybranego rekordu.");
                return;
            }

            var selectedOwner = MainForm.osoby.FirstOrDefault(o => o.Id == selectedOwnerId);
            if (selectedOwner == null)
            {
                MessageBox.Show("Nie wybrano rekordu do usunięcia.");
                return;
            }

            var zwierzeta = MainForm.zwierzeta.Where(z => z.WlascicielId == selectedOwnerId).ToList();
            
            await DeleteOwner(selectedOwner, zwierzeta);
            refreshList();
        }

        private void LoadToOwnerAnimalList()
        {
            var zwierzeta = MainForm.zwierzeta.Where(z => z.WlascicielId == selectedOwnerId).ToList();

            ownerAnimalList.Items.Clear();

            foreach (var zwierze in zwierzeta)
            {
                ownerAnimalList.Items.Add(zwierze);
            }
        }

        public void refreshList()
        {
            ownerList.Items.Clear();
            LoadToOwnerList();
            LoadToOwnerAnimalList();
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
            string searchText = ownerSearchBox.Text.ToLower();

            var filtered = MainForm.osoby
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
            var wlasciciele = MainForm.osoby.OrderBy(o => o.Id).ToList();
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
            var wlasciciel = MainForm.osoby.Where(o => o.Id == selectedOwnerId).FirstOrDefault();
            var zwierzetaCount = MainForm.zwierzeta.Count(z => z.WlascicielId == selectedOwnerId);

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
            LoadToOwnerAnimalList();
        }

        public void panelReturn()
        {
            ownerDataPanel.Controls.Clear();
            ownerDataPanel.Controls.Add(ownerDataFlowLayout);
        }
    }
}
