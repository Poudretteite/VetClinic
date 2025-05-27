using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Threading.Tasks;
using VetClinic.Models;

namespace VetClinic.Forms
{
    public partial class DoctorAddForm : UserControl
    {
        private readonly MainForm _mainForm;
        private int mode;
        public DoctorAddForm(MainForm mainForm)
        {
            _mainForm = mainForm;
            mode = 1;
            InitializeComponent();
            LoadToDoctorSpecializationChoice();
            LoadToDoctorWorkPlaceChoice();

            doctorSpecializationChoice.Visible = true;
            doctorSpecializationChoiceLabel.Visible = true;
        }

        public DoctorAddForm(MainForm mainForm, string imie, string nazwisko, DateTime data, string email, string phone, string specjalizacja, string tryb)
        {
            _mainForm = mainForm;
            mode = 0;
            InitializeComponent();
            LoadToDoctorSpecializationChoice();
            LoadToDoctorWorkPlaceChoice();

            doctorNameTextBox.Text = imie;
            doctorSurnameTextBox.Text = nazwisko;
            doctorBirthDayPicker.Value = data;
            doctorEmailTextbox.Text = email;
            doctorPhoneTextBox.Text = phone;
            doctorSpecializationChoice.SelectedItem = specjalizacja;
            doctorWorkPlaceChoice.SelectedItem = tryb;
        }

        private async Task AddDoctor(Lekarz lekarz)
        {
            using var context = Constants.CreateContext();

            await context.Lekarze.AddAsync(lekarz);
            await context.SaveChangesAsync();

            MainForm.lekarze = await context.Lekarze.ToListAsync();
        }

        private async Task EditDoctor(Lekarz lekarz)
        {
            using var context = Constants.CreateContext();

            await context.Lekarze.AddAsync(lekarz);
            await context.SaveChangesAsync();

            MainForm.lekarze = await context.Lekarze.ToListAsync();
        }

        private void LoadToDoctorSpecializationChoice()
        {
            var wizyty = MainForm.wizyty.Count(w => w.LekarzId == MainForm.doctorview.selectedLekarzId);
            if (mode == 0 && wizyty > 0)
            {
                MessageBox.Show("Nie można edytować specjalizacji lekarza z odbytymi wizytami");
                doctorSpecializationChoice.Visible = false;
                doctorSpecializationChoiceLabel.Visible = false;
                return;
            }

            doctorSpecializationChoice.Visible = true;
            doctorSpecializationChoiceLabel.Visible = true;

            foreach (var specialization in Constants.AnimalType)
            {
                doctorSpecializationChoice.Items.Add(specialization);
            }

        }

        private void LoadToDoctorWorkPlaceChoice()
        {
            foreach (var tryb in Constants.Tryby)
            {
                doctorWorkPlaceChoice.Items.Add(tryb);
            }
        }

        private async Task acceptButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(doctorNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(doctorSurnameTextBox.Text) ||
                string.IsNullOrWhiteSpace(doctorEmailTextbox.Text) ||
                string.IsNullOrWhiteSpace(doctorPhoneTextBox.Text))
            {
                MessageBox.Show("Wypełnij wszystkie pola.");
                return;
            }

            if (!doctorPhoneTextBox.Text.All(char.IsDigit))
            {
                MessageBox.Show("Numer telefonu powinien zawierać tylko liczby.");
                return;
            }

            if (!Constants.IsValidEmail(doctorEmailTextbox.Text))
            {
                MessageBox.Show("Niepoprawny email.");
                return;
            }

            var emailCheck = MainForm.osoby.FirstOrDefault(o => o.Email == doctorEmailTextbox.Text && o.Id != MainForm.doctorview.selectedLekarzId);
            if (emailCheck != null)
            {
                MessageBox.Show($"Powtarzajacy się email: {doctorEmailTextbox.Text}");
                return;
            }

            var phoneCheck = MainForm.osoby.FirstOrDefault(o => o.Telefon == doctorPhoneTextBox.Text && o.Id != MainForm.doctorview.selectedLekarzId);
            if (phoneCheck != null)
            {
                MessageBox.Show($"Powtarzajacy się numer Telefonu: {doctorPhoneTextBox.Text}");
                return;
            }

            if (mode == 1)
            {
                int maxId = MainForm.osoby.Max(o => o.Id);

                var lekarz = new Lekarz()
                {
                    Id = maxId + 1,
                    Imie = doctorNameTextBox.Text,
                    Nazwisko = doctorSurnameTextBox.Text,
                    Data_ur = doctorBirthDayPicker.Value.ToUniversalTime(),
                    Email = doctorEmailTextbox.Text,
                    Telefon = doctorPhoneTextBox.Text,
                    Specjalizacja = doctorSpecializationChoice.SelectedItem.ToString(),
                    Tryb = doctorWorkPlaceChoice.SelectedItem.ToString()
                };
                await AddDoctor(lekarz);
            }
            else
            {
                var lekarz = MainForm.lekarze.Where(l => l.Id == MainForm.doctorview.selectedLekarzId).FirstOrDefault();

                lekarz.Imie = doctorNameTextBox.Text;
                lekarz.Nazwisko = doctorSurnameTextBox.Text;
                lekarz.Data_ur = doctorBirthDayPicker.Value.ToUniversalTime();
                lekarz.Email = doctorEmailTextbox.Text;
                lekarz.Telefon = doctorPhoneTextBox.Text;
                if(doctorSpecializationChoice.Visible == true)
                {
                    lekarz.Specjalizacja = doctorSpecializationChoice.SelectedItem.ToString();
                }
                lekarz.Tryb = doctorWorkPlaceChoice.SelectedItem.ToString();

                await EditDoctor(lekarz);
            }

            MainForm.doctorview.panelReturn();
            MainForm.doctorview.LoadToDoctorList();
            await MainForm.doctorview.LoadToDoctorVisitTable();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            MainForm.doctorview.panelReturn();
        }
    }
}
