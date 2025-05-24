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

        private void acceptButton_Click(object sender, EventArgs e)
        {
            var factory = new AppDbContextFactory();
            using var context = factory.CreateDbContext(Array.Empty<String>());

            Lek lek;

            if (mode == 1)
            {
                var maxId = context.Leki.Max(l => l.Id);

                lek = new Lek()
                {
                    Id = maxId+1,
                    Nazwa = medNameTextBox.Text,
                    Ilosc = (int)medAmountPicker.Value
                };

                context.Leki.Add(lek);
            }
            else
            {
                lek = context.Leki.Where(l => l.Id == MainForm.medview.selectedMedId).FirstOrDefault();

                lek.Nazwa = medNameTextBox.Text;
                lek.Ilosc = (int)medAmountPicker.Value;

                context.Leki.Update(lek);
            }
            context.SaveChanges();

            MainForm.medview.panelReturn();
            MainForm.medview.refresh();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            MainForm.medview.panelReturn();
        }
    }
}
