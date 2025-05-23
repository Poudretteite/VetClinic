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
    public partial class VisitAddForm : UserControl
    {
        private readonly MainForm _mainForm;
        public VisitAddForm(MainForm mainForm)
        {
            _mainForm = mainForm;
            InitializeComponent();
            LoadDoctorData();
        }

        private void LoadDoctorData()
        {
            var factory = new AppDbContextFactory();
            using var context = factory.CreateDbContext(Array.Empty<string>());

            var lekarze = context.Lekarze;

            foreach (var lekarz in lekarze)
            {
                visitDoctorChoice.Items.Add(lekarz.ToString());
            }
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            var factory = new AppDbContextFactory();
            using var context = factory.CreateDbContext(Array.Empty<string>());
            int maxId = context.Wizyty.Max(w => w.Id)+1;

            if (visitDoctorChoice.SelectedItem == null)
            {
                MessageBox.Show("Wybierz lekarza.");
                return;
            }

            var lekarzWizyty = new Dictionary<int, Dictionary<DateTime, int>>();

            var lekarz = visitDoctorChoice.SelectedItem.ToString();
            int lekarzId = int.Parse(lekarz.Split('.')[0].Trim());

            var data = visitDatePicker.Value.Date;

            int visitCount = context.Wizyty
            .Where(w => w.LekarzId == lekarzId && w.Data.Date == data)
            .Count();

            if (visitCount >= 5)
            {
                MessageBox.Show("Ten lekarz ma już 5 wizyt w tym dniu.");
                return;
            }

            if (data.DayOfWeek == DayOfWeek.Saturday || data.DayOfWeek == DayOfWeek.Sunday)
            {
                MessageBox.Show("Nie można zarezerwować wizyty na weekend");
                return;
            }

            var newVisit = new Wizyta()
            {
                Id = maxId,
                ZwierzeId = MainForm.animalview.selectedId,
                LekarzId = lekarzId,
                Data = data,
                Opis = visitDescriptionBox.Text
            };

            context.Wizyty.Add(newVisit);
            context.SaveChanges();

            MainForm.animalview.panelReturn();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            MainForm.animalview.panelReturn();
        }
    }
}
