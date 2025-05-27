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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace VetClinic.Forms
{
    public partial class OwnerAddForm : UserControl
    {
        private readonly MainForm _mainForm;
        private int mode;
        public OwnerAddForm(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
            mode = 1;
        }

        public OwnerAddForm(MainForm mainForm, string imie, string nazwisko, DateTime data, string email, string phone)
        {
            InitializeComponent();
            _mainForm = mainForm;

            ownerNameTextBox.Text = imie;
            ownerSurnameTextBox.Text = nazwisko;
            ownerBirthDayPicker.Value = data;
            ownerEmailTextbox.Text = email;
            ownerPhoneTextBox.Text = phone;

            mode = 0;
        }

        private async Task AddOwner(Osoba osoba)
        {
            using var context = Constants.CreateContext();

            context.Osoby.Add(osoba);
            await context.SaveChangesAsync();

            MainForm.osoby = await context.Osoby.ToListAsync();
        }

        private async Task EditOwner(Osoba osoba)
        {
            using var context = Constants.CreateContext();

            context.Osoby.Update(osoba);
            await context.SaveChangesAsync();

            MainForm.osoby = await context.Osoby.ToListAsync();
        }

        private async void acceptButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ownerNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(ownerSurnameTextBox.Text) ||
                string.IsNullOrWhiteSpace(ownerEmailTextbox.Text) ||
                string.IsNullOrWhiteSpace(ownerPhoneTextBox.Text))
            {
                MessageBox.Show("Wypełnij wszystkie pola.");
                return;
            }

            if (!ownerPhoneTextBox.Text.All(char.IsDigit))
            {
                MessageBox.Show("Numer telefonu powinien zawierać tylko liczby.");
                return;
            }

            if (!Constants.IsValidEmail(ownerEmailTextbox.Text))
            {
                MessageBox.Show("Niepoprawny email.");
                return;
            }

            var emailCheck = MainForm.osoby.Where(o => o.Email == ownerEmailTextbox.Text && o.Id != MainForm.ownerview.selectedOwnerId).FirstOrDefault();
            if (emailCheck != null)
            {
                MessageBox.Show($"Powtarzajacy się email: {ownerEmailTextbox.Text}");
                return;
            }

            var phoneCheck = MainForm.osoby.Where(o => o.Telefon == ownerPhoneTextBox.Text && o.Id != MainForm.ownerview.selectedOwnerId).FirstOrDefault();
            if (phoneCheck != null)
            {
                MessageBox.Show($"Powtarzajacy się numer Telefonu: {ownerEmailTextbox.Text}");
                return;
            }

            if (mode == 1)
            {
                int maxId = MainForm.osoby.Max(o => o.Id);

                var wlasciciel = new Osoba()
                {
                    Id = maxId+1,
                    Imie = ownerNameTextBox.Text,
                    Nazwisko = ownerSurnameTextBox.Text,
                    Data_ur = ownerBirthDayPicker.Value.ToUniversalTime(),
                    Email = ownerEmailTextbox.Text,
                    Telefon = ownerPhoneTextBox.Text
                };

                await AddOwner(wlasciciel);
            }
            else
            {
                var wlasciciel = MainForm.osoby.Where(o => o.Id == MainForm.ownerview.selectedOwnerId).FirstOrDefault();

                wlasciciel.Imie = ownerNameTextBox.Text;
                wlasciciel.Nazwisko = ownerSurnameTextBox.Text;
                wlasciciel.Data_ur = ownerBirthDayPicker.Value.ToUniversalTime();
                wlasciciel.Email = ownerEmailTextbox.Text;
                wlasciciel.Telefon = ownerPhoneTextBox.Text;

                await EditOwner(wlasciciel);
            }

            MainForm.ownerview.panelReturn();
            MainForm.ownerview.refreshList();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            MainForm.ownerview.panelReturn();
        }
    }
}
