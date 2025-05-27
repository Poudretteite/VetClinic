using Microsoft.EntityFrameworkCore;
using System.Data;
using VetClinic.Models;

namespace VetClinic.Forms
{
    public partial class DoctorView : UserControl
    {
        private readonly MainForm _mainForm;
        public int selectedLekarzId;

        public DoctorView(MainForm mainForm)
        {
            _mainForm = mainForm;
            InitializeComponent();
            this.Load += DoctorView_Load;
        }

        private async void DoctorView_Load(object sender, EventArgs e)
        {
            await LoadToLists();

            LoadToDoctorList();
            LoadDoctorData();
            await LoadToDoctorVisitTable();
        }

        private async Task LoadToLists()
        {
            using var context = Constants.CreateContext();
            if (MainForm.lekarze == null) MainForm.lekarze = await context.Lekarze.ToListAsync();
            if (MainForm.wizyty == null) MainForm.wizyty = await context.Wizyty.ToListAsync();
        }

        private async Task DeleteDoctor(Lekarz lekarz)
        {
            using var context = Constants.CreateContext();

            context.Lekarze.Remove(lekarz);
            await context.SaveChangesAsync();

            MainForm.lekarze = await context.Lekarze.ToListAsync();
        }

        public void LoadToDoctorList()
        {
            var lekarze = MainForm.lekarze.ToList();

            doctorList.Items.Clear();

            foreach (var lekarz in lekarze)
            {
                doctorList.Items.Add(lekarz.ToString());
            }

            var selectedLekarzString = lekarze
                    .Where(l => l.Id == selectedLekarzId)
                    .Select(l => l.ToString())
                    .FirstOrDefault();

            if (selectedLekarzString != null)
            {
                doctorList.SelectedItem = selectedLekarzString;
            }

            selectedLekarzId = lekarze[0].Id;
        }

        private void LoadDoctorData()
        {
            var lekarz = MainForm.lekarze.Where(l => l.Id == selectedLekarzId).FirstOrDefault();
            var pastCount = MainForm.wizyty.Count(w => w.LekarzId == selectedLekarzId && w.Data <= DateTime.UtcNow);
            var futureCount = MainForm.wizyty.Count(w => w.LekarzId == selectedLekarzId && w.Data > DateTime.UtcNow);

            doctorNameLabel.Text = $"{lekarz.Imie} {lekarz.Nazwisko}";
            doctorSpecialization.Text = "Specjalizacja: " + lekarz.Specjalizacja;
            doctorWorkplaceLabel.Text = "Tryb pracy: " + lekarz.Tryb;
            doctorPhoneLabel.Text = "Telefon: " + lekarz.Telefon;
            doctorEmailLabel.Text = "Email: " + lekarz.Email;
            pastVisitCount.Text = "Odbyte wizyty: " + pastCount.ToString();
            futureVisitCount.Text = "Przyszłe wizyty: " + futureCount.ToString();
        }

        public async Task LoadToDoctorVisitTable()
        {
            using var context = Constants.CreateContext();

            var wizyty = context.Wizyty.Where(w => w.LekarzId == selectedLekarzId)
                .Include(w => w.Leki)
                .Select(w => new
                {
                    Id = w.Id,
                    Data = w.Data,
                    Leki = string.Join(",", w.Leki.Select(l => l.Nazwa))
                })
                .ToList();

            doctorVisitTable.DataSource = wizyty;
        }

        private void doctorAddButton_Click(object sender, EventArgs e)
        {
            doctorDataPanel.Controls.Clear();
            var view = new DoctorAddForm(this._mainForm);
            doctorDataPanel.Controls.Add(view);
            view.Dock = DockStyle.Fill;

            
        }
        private void doctorEditButton_Click(object sender, EventArgs e)
        {
            var lekarz = MainForm.lekarze.Where(l => l.Id == selectedLekarzId).FirstOrDefault();

            doctorDataPanel.Controls.Clear();
            var view = new DoctorAddForm(this._mainForm, lekarz.Imie, lekarz.Nazwisko, lekarz.Data_ur, lekarz.Email, lekarz.Telefon, lekarz.Specjalizacja, lekarz.Tryb);
            doctorDataPanel.Controls.Add(view);
            view.Dock = DockStyle.Fill;
        }

        private async void doctorDeleteButton_Click(object sender, EventArgs e)
        {
            var wizyty = MainForm.wizyty.Count(w => w.LekarzId == selectedLekarzId);
            if (wizyty > 0)
            {
                MessageBox.Show("Nie można usunąć lekarza z odbytymi wizytami");
                return;
            }

            var lekarz = MainForm.lekarze.Where(l => l.Id == selectedLekarzId).FirstOrDefault();
            if (lekarz != null)
            {
                await DeleteDoctor(lekarz);

                LoadToDoctorList();
                LoadDoctorData();
                await LoadToDoctorVisitTable();
            }
        }

        private async void doctorList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var listBox = sender as ListBox;
            if (listBox?.SelectedItem == null) return;

            string selectedItem = listBox.SelectedItem.ToString();
            selectedLekarzId = int.Parse(selectedItem.Split('.')[0]);

            LoadDoctorData();
            await LoadToDoctorVisitTable();
        }

        public void panelReturn()
        {
            doctorDataPanel.Controls.Clear();
            doctorDataPanel.Controls.Add(doctorDataLayoutPanel);
        }
    }
}
