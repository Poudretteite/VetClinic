using Microsoft.EntityFrameworkCore;
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
    public partial class DoctorView : UserControl
    {
        private readonly MainForm _mainForm;
        public int selectedLekarzId;
        public DoctorView(MainForm mainForm)
        {
            _mainForm = mainForm;
            InitializeComponent();
            LoadToDoctorList();
            LoadDoctorData();
            LoadToDoctorVisitTable();
        }

        public void LoadToDoctorList()
        {
            var factory = new AppDbContextFactory();
            using var context = factory.CreateDbContext(Array.Empty<string>());

            var lekarze = context.Lekarze.ToList();

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
            var factory = new AppDbContextFactory();
            using var context = factory.CreateDbContext(Array.Empty<string>());

            var lekarz = context.Lekarze.Where(l => l.Id == selectedLekarzId).FirstOrDefault();
            var pastCount = context.Wizyty.Count(w => w.LekarzId == selectedLekarzId && w.Data <= DateTime.UtcNow);
            var futureCount = context.Wizyty.Count(w => w.LekarzId == selectedLekarzId && w.Data > DateTime.UtcNow);

            doctorNameLabel.Text = $"{lekarz.Imie} {lekarz.Nazwisko}";
            doctorSpecialization.Text = "Specjalizacja: " + lekarz.Specjalizacja;
            doctorWorkplaceLabel.Text = "Tryb pracy: " + lekarz.Tryb;
            doctorPhoneLabel.Text = "Telefon: " + lekarz.Telefon;
            doctorEmailLabel.Text = "Email: " + lekarz.Email;
            pastVisitCount.Text = "Odbyte wizyty: " + pastCount.ToString();
            futureVisitCount.Text = "Przyszłe wizyty: " + futureCount.ToString();
        }

        public void LoadToDoctorVisitTable()
        {
            var factory = new AppDbContextFactory();
            using var context = factory.CreateDbContext(Array.Empty<string>());

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
            var factory = new AppDbContextFactory();
            using var context = factory.CreateDbContext(Array.Empty<string>());

            var lekarz = context.Lekarze.Where(l => l.Id == selectedLekarzId).First();

            doctorDataPanel.Controls.Clear();
            var view = new DoctorAddForm(this._mainForm, lekarz.Imie, lekarz.Nazwisko, lekarz.Data_ur, lekarz.Email, lekarz.Telefon, lekarz.Specjalizacja, lekarz.Tryb);
            doctorDataPanel.Controls.Add(view);
            view.Dock = DockStyle.Fill;
        }

        private void doctorDeleteButton_Click(object sender, EventArgs e)
        {
            var factory = new AppDbContextFactory();
            using var context = factory.CreateDbContext(Array.Empty<string>());

            var wizyty = context.Wizyty.Count(w => w.LekarzId == selectedLekarzId);
            if (wizyty > 0)
            {
                MessageBox.Show("Nie można usunąć lekarza z odbytymi wizytami");
                return;
            }

            var lekarz = context.Lekarze.Where(l => l.Id == selectedLekarzId).FirstOrDefault();
            if (lekarz != null)
            {
                context.Lekarze.Remove(lekarz);
                context.SaveChanges();

                LoadToDoctorList();
                LoadDoctorData();
                LoadToDoctorVisitTable();
            }
        }

        private void doctorList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var listBox = sender as ListBox;
            if (listBox?.SelectedItem == null) return;

            string selectedItem = listBox.SelectedItem.ToString();
            selectedLekarzId = int.Parse(selectedItem.Split('.')[0]);

            LoadDoctorData();
            LoadToDoctorVisitTable();
        }

        public void panelReturn()
        {
            doctorDataPanel.Controls.Clear();
            doctorDataPanel.Controls.Add(doctorDataLayoutPanel);
        }
    }
}
