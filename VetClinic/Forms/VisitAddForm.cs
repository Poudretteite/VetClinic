﻿using System;
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
using Microsoft.IdentityModel.Tokens;
using System.Text.RegularExpressions;

namespace VetClinic.Forms
{
    public partial class VisitAddForm : UserControl
    {
        private readonly MainForm _mainForm;
        private ListBox resultBox;
        private int mode;
        private List<int> selectedMedIds;

        public VisitAddForm(MainForm mainForm)
        {
            _mainForm = mainForm;
            InitializeComponent();
            this.Load += VisitAddForm_LoadAdd;
        }

        private async Task AddVisit(Wizyta wizyta)
        {
            using var context = Constants.CreateContext();

            context.Wizyty.Add(wizyta);
            await context.SaveChangesAsync();

            MainForm.wizyty = await context.Wizyty.ToListAsync();
        }

        private async Task EditVisit(Wizyta wizyta)
        {
            using var context = Constants.CreateContext();

            context.Wizyty.Update(wizyta);
            await context.SaveChangesAsync();

            MainForm.wizyty = await context.Wizyty.ToListAsync();
        }

        public VisitAddForm(MainForm mainForm, string? animal, string doctor, DateTime date, string opis, List<int> selectedMedicineIds)
        {
            _mainForm = mainForm;
            this.selectedMedIds = selectedMedicineIds;
            InitializeComponent();
            this.Load += VisitAddForm_LoadEdit;

            AnimalSearchBox.Text = animal;
            visitDatePicker.Value = date;
            visitDescriptionBox.Text = opis;
            visitDoctorChoice.SelectedItem = doctor;
        }

        private async void VisitAddForm_LoadAdd(object sender, EventArgs e)
        {
            LoadDoctorData();
            LoadToMedCheckedList();

            visitDatePicker.MinDate = new DateTime(2024, 1, 1);
            visitDatePicker.MaxDate = DateTime.Now.AddDays(30);

            AnimalSearchBox.Enabled = false;
            AnimalSearchBox.Visible = false;

            mode = 1;
        }

        private async void VisitAddForm_LoadEdit(object sender, EventArgs e)
        {
            LoadDoctorData();
            LoadToMedCheckedList();

            visitDatePicker.MinDate = new DateTime(2024, 1, 1);
            visitDatePicker.MaxDate = DateTime.Now.AddDays(30);

            AnimalSearchBox.Enabled = true;
            AnimalSearchBox.Visible = true;
            InitializeSearchControls();
            mode = 0;
        }

        private void LoadDoctorData()
        {
            visitDoctorChoice.Items.Clear();
            if (!AnimalSearchBox.Text.IsNullOrEmpty())
            {
                MainForm.animalview.selectedAnimalId = int.Parse(AnimalSearchBox.Text.Split('.')[0].Trim());
            }


            var zwierze = MainForm.zwierzeta.FirstOrDefault(z => z.Id == MainForm.animalview.selectedAnimalId);
            if (zwierze == null) return;

            var lekarze = MainForm.lekarze
                .Where(l => l.Specjalizacja == zwierze.Typ)
                .ToList();

            foreach (var lekarz in lekarze)
            {
                visitDoctorChoice.Items.Add(lekarz.ToString());
            }

            if (visitDoctorChoice.Items.Count > 0)
                visitDoctorChoice.SelectedIndex = 0;
        }

        private void LoadToMedCheckedList()
        {
            medCheckedList.Items.Clear();
            foreach (var lek in MainForm.leki)
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
            string searchText = AnimalSearchBox.Text.ToLower();

            var filtered = MainForm.zwierzeta
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
                MainForm.animalview.selectedAnimalId = zwierze.Id;
                AnimalSearchBox.Text = zwierze.ToString();
                resultBox.Visible = false;
            }
            LoadDoctorData();
            visitDoctorChoice.SelectedIndex = -1;
        }

        private async void acceptButton_Click(object sender, EventArgs e)
        {
            if (visitDoctorChoice.SelectedItem == null)
            {
                MessageBox.Show("Wybierz lekarza.");
                return;
            }

            if (string.IsNullOrEmpty(AnimalSearchBox.Text) ||
                string.IsNullOrEmpty(visitDescriptionBox.Text))
            {
                MessageBox.Show("Wypełnij wszystkie pola.");
                return;
            }

            if (visitDoctorChoice.SelectedItem == null)
            {
                MessageBox.Show("Wybierz lekarza.");
                return;
            }

            if(!Regex.IsMatch(AnimalSearchBox.Text, @"^\d") ||
                !MainForm.zwierzeta.Where(z => z.Id == MainForm.animalview.selectedAnimalId).Any())
            {
                MessageBox.Show("Wybierz poprawne zwierze.");
                return;
            }

            using var context = Constants.CreateContext();

            List<Lek> leki = new List<Lek>();

            foreach (string lek in medCheckedList.CheckedItems)
            {
                var med = MainForm.leki.First(l => l.Nazwa == lek);
                if (med != null)
                    leki.Add(med);
            }

            var lekarz = visitDoctorChoice.SelectedItem.ToString();
            int lekarzId = int.Parse(lekarz.Split('.')[0].Trim());

            var data = visitDatePicker.Value.Date;

            int visitCount = MainForm.wizyty
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
                int maxId = 0;
                if (MainForm.wizyty.Any())
                {
                    maxId = MainForm.wizyty.Max(w => w.Id);
                }

                var newVisit = new Wizyta()
                {
                    Id = maxId + 1,
                    ZwierzeId = MainForm.animalview.selectedAnimalId,
                    LekarzId = lekarzId,
                    Data = data,
                    Opis = visitDescriptionBox.Text,
                    Leki = leki
                };

                await AddVisit(newVisit);
            }
            else
            {
                var wizyta = context.Wizyty
                    .Where(w => w.Id == MainForm.visitview.visitID)
                    .Include(w => w.Leki)
                    .First();

                if (wizyta == null) { return; }

                wizyta.ZwierzeId = MainForm.animalview.selectedAnimalId;
                wizyta.LekarzId = lekarzId;
                wizyta.Data = data;
                wizyta.Opis = visitDescriptionBox.Text;

                wizyta.Leki.Clear();
                wizyta.Leki = leki;

                await EditVisit(wizyta);
            }

            if (MainForm.animalview == null)
            {
                MainForm.visitview.panelReturn();
                MainForm.visitview.LoadToVisitDataGrid();
            }
            else
            {
                MainForm.animalview.LoadAnimalVisitDataGrid();
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
