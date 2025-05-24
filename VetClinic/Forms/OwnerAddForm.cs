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

        private void acceptButton_Click(object sender, EventArgs e)
        {
            var factory = new AppDbContextFactory();
            using var context = factory.CreateDbContext(Array.Empty<string>());

            Osoba wlasciciel;

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
            }

            if (!Constants.IsValidEmail(ownerEmailTextbox.Text))
            {
                MessageBox.Show("Niepoprawny email.");
            }

            var emailCheck = context.Osoby.Where(o => o.Email == ownerEmailTextbox.Text && o.Id != MainForm.ownerview.selectedOwnerId).FirstOrDefault();
            if (emailCheck != null)
            {
                MessageBox.Show($"Powtarzajacy się email: {ownerEmailTextbox.Text}");
                return;
            }

            var phoneCheck = context.Osoby.Where(o => o.Telefon == ownerPhoneTextBox.Text && o.Id != MainForm.ownerview.selectedOwnerId).FirstOrDefault();
            if (phoneCheck != null)
            {
                MessageBox.Show($"Powtarzajacy się numer Telefonu: {ownerEmailTextbox.Text}");
                return;
            }

            if (mode == 1)
            {
                int maxId = context.Osoby.Max(o => o.Id);

                wlasciciel = new Osoba()
                {
                    Id = maxId+1,
                    Imie = ownerNameTextBox.Text,
                    Nazwisko = ownerSurnameTextBox.Text,
                    Data_ur = ownerBirthDayPicker.Value.ToUniversalTime(),
                    Email = ownerEmailTextbox.Text,
                    Telefon = ownerPhoneTextBox.Text
                };

                context.Osoby.Add(wlasciciel);
            }
            else
            {
                wlasciciel = context.Osoby.Where(o => o.Id == MainForm.ownerview.selectedOwnerId).FirstOrDefault();

                wlasciciel.Imie = ownerNameTextBox.Text;
                wlasciciel.Nazwisko = ownerSurnameTextBox.Text;
                wlasciciel.Data_ur = ownerBirthDayPicker.Value.ToUniversalTime();
                wlasciciel.Email = ownerEmailTextbox.Text;
                wlasciciel.Telefon = ownerPhoneTextBox.Text;

                context.Osoby.Update(wlasciciel);
            }

            context.SaveChanges();

            MainForm.ownerview.panelReturn();
            MainForm.ownerview.refreshList();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            MainForm.ownerview.panelReturn();
        }
    }
}
