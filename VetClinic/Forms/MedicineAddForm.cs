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
using VetClinic.Models;

namespace VetClinic.Forms
{
    public partial class MedicineAddForm : UserControl
    {
        private readonly MainForm _mainForm;
        private int mode;
        public MedicineAddForm(MainForm mainForm)
        {
            mode = 1;
            _mainForm = mainForm;
            InitializeComponent();
        }

        public MedicineAddForm(MainForm mainForm, string nazwa, int ilosc)
        {
            mode = 0;
            _mainForm = mainForm;
            InitializeComponent();

            medNameTextBox.Text = nazwa;
            medAmountPicker.Value = ilosc;
        }

        private async Task AddMed(Lek lek)
        {
            using var context = Constants.CreateContext();

            context.Leki.Add(lek);
            await context.SaveChangesAsync();

            MainForm.leki = await context.Leki.ToListAsync();
        }

        private async Task EditMed(Lek lek)
        {
            using var context = Constants.CreateContext();

            context.Leki.Update(lek);
            await context.SaveChangesAsync();

            MainForm.leki = await context.Leki.ToListAsync();
        }

        private async void acceptButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(medNameTextBox.Text))
            {
                MessageBox.Show("Podaj nazwę leku");
                return;
            }

            if (mode == 1)
            {
                var maxId = MainForm.leki.Max(l => l.Id);

                var lek = new Lek()
                {
                    Id = maxId+1,
                    Nazwa = medNameTextBox.Text,
                    Ilosc = (int)medAmountPicker.Value
                };

                await AddMed(lek);
            }
            else
            {
                var lek = MainForm.leki.Where(l => l.Id == MainForm.medview.selectedMedId).FirstOrDefault();

                lek.Nazwa = medNameTextBox.Text;
                lek.Ilosc = (int)medAmountPicker.Value;

                await EditMed(lek);
            }

            MainForm.medview.panelReturn();
            MainForm.medview.refresh();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            MainForm.medview.panelReturn();
        }
    }
}
