using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VetClinic.Models;
using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace VetClinic.Forms
{
    public partial class VisitAddForm : UserControl
    {
        private readonly MainForm _mainForm;
        private ListBox resultBox;
        private int selectedAnimalId;
        private int mode;
        private List<int> selectedMedIds;

        public VisitAddForm(MainForm mainForm)
        {
            _mainForm = mainForm;
            InitializeComponent();
            LoadToMedCheckedList();
            visitDatePicker.MinDate = new DateTime(2024, 1, 1);
            visitDatePicker.MaxDate = DateTime.Now.AddDays(30);

            LoadDoctorData();
            AnimalSearchBox.Enabled = false;
            AnimalSearchBox.Visible = false;
            mode = 1;
        }

        public VisitAddForm(MainForm mainForm, string? animal, string doctor, DateTime date, string opis, List<int> selectedMedicineIds)
        {
            _mainForm = mainForm;
            this.selectedMedIds = selectedMedicineIds;
            InitializeComponent();
            LoadToMedCheckedList();
            visitDatePicker.MinDate = new DateTime(2024, 1, 1);
            visitDatePicker.MaxDate = DateTime.Now.AddDays(30);

            AnimalSearchBox.Text = animal;
            visitDatePicker.Value = date;
            visitDescriptionBox.Text = opis;

            AnimalSearchBox.Enabled = true;
            AnimalSearchBox.Visible = true;
            
            LoadDoctorData();
            visitDoctorChoice.SelectedItem = doctor;

            InitializeSearchControls();
            mode = 0;
        }

        private void LoadDoctorData()
        {
            var factory = new AppDbContextFactory();
            using var context = factory.CreateDbContext(Array.Empty<string>());

            visitDoctorChoice.Items.Clear();
            if (MainForm.animalview == null)
            {
                selectedAnimalId = int.Parse(AnimalSearchBox.Text.Split('.')[0].Trim());
            }
            else
            {
                selectedAnimalId = MainForm.animalview.selectedId;
            }

            var zwierze = context.Zwierzeta.Where(z => z.Id == selectedAnimalId).FirstOrDefault();

            var lekarze = context.Lekarze.Where(l => l.Specjalizacja == zwierze.Typ);

            foreach (var lekarz in lekarze)
            {
                visitDoctorChoice.Items.Add(lekarz.ToString());
            }
            visitDoctorChoice.SelectedIndex = 0;
        }

        private void LoadToMedCheckedList()
        {
            var factory = new AppDbContextFactory();
            using var context = factory.CreateDbContext(Array.Empty<string>());

            var leki = context.Leki.ToList();

            medCheckedList.Items.Clear();
            foreach (var lek in leki)
            {
                medCheckedList.Items.Add(lek.Nazwa);

                if (selectedMedIds != null && selectedMedIds.Contains(lek.Id))
                {
                    int index = medCheckedList.Items.IndexOf(lek.Nazwa);
                    medCheckedList.SetItemChecked(index, true);
                }
            }
        }

        private void InitializeSearchControls()
        {
            resultBox = new ListBox
            {
                Location = Location = new Point(AnimalSearchBox.Left, AnimalSearchBox.Bottom),
                Width = 200,
                Height = 100,
                Visible = false
            };

            this.Controls.Add(resultBox);
            resultBox.BringToFront();

            AnimalSearchBox.TextChanged += animalSearchBox_TextChanged;
            resultBox.Click += ResultBox_Click;
        }

        private void animalSearchBox_TextChanged(object sender, EventArgs e)
        {
            var factory = new AppDbContextFactory();
            using var context = factory.CreateDbContext(Array.Empty<string>());

            var zwierzeta = context.Zwierzeta.Take(10);

            string searchText = AnimalSearchBox.Text.ToLower();
            var filtered = zwierzeta
                .Where(z => z.Imie.ToLower().Contains(searchText) ||
                            z.Gatunek.ToLower().Contains(searchText))
                .ToList();

            UpdateResultBox(filtered);
        }

        private void UpdateResultBox(List<Zwierze> matches)
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
            if (resultBox.SelectedItem is Zwierze zwierze)
            {
                selectedAnimalId = zwierze.Id;
                AnimalSearchBox.Text = zwierze.ToString();
                resultBox.Visible = false;
            }
            LoadDoctorData();
            visitDoctorChoice.SelectedIndex = -1;
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            var factory = new AppDbContextFactory();
            using var context = factory.CreateDbContext(Array.Empty<string>());

            List<Lek> leki = new List<Lek>();

            foreach (string lek in medCheckedList.CheckedItems)
            {
                leki.Add(context.Leki.Where(l => l.Nazwa == lek).FirstOrDefault());
            }

            if (visitDoctorChoice.SelectedItem == null)
            {
                MessageBox.Show("Wybierz lekarza.");
                return;
            }

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

            if (mode == 1)
            {
                int maxId = context.Wizyty.Max(w => w.Id) + 1;

                var newVisit = new Wizyta()
                {
                    Id = maxId+1,
                    ZwierzeId = selectedAnimalId,
                    LekarzId = lekarzId,
                    Data = data,
                    Opis = visitDescriptionBox.Text,
                    Leki = leki
                };

                context.Wizyty.Add(newVisit);
                context.SaveChanges();
            }
            else
            {
                var wizyta = context.Wizyty.Where(w => w.Id == MainForm.visitview.visitID).Include(w => w.Leki).FirstOrDefault();
                if (wizyta == null) { return; }

                wizyta.ZwierzeId = selectedAnimalId;
                wizyta.LekarzId = lekarzId;
                wizyta.Data = data;
                wizyta.Opis = visitDescriptionBox.Text;
                wizyta.Leki.Clear();
                wizyta.Leki = leki;

                context.Wizyty.Update(wizyta);
                context.SaveChanges();
            }

            if (MainForm.animalview == null)
            {
                MainForm.visitview.panelReturn();
                MainForm.visitview.LoadToVisitDataGrid();
            }
            else
            {
                MainForm.animalview.panelReturn();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            
            if (MainForm.animalview == null)
            {
                MainForm.visitview.panelReturn();
            }
            else
            {
                MainForm.animalview.panelReturn();
            }
        }
    }
}
