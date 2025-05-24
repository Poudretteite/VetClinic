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
    public partial class OrderAddForm : UserControl
    {
        private readonly MainForm _mainForm;
        public OrderAddForm(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            var factory = new AppDbContextFactory();
            using var context = factory.CreateDbContext(Array.Empty<String>());

            int maxId = context.Zamowienia.Max(z => z.Id);
            int medId = MainForm.medview.selectedMedId;

            Zamowienie zamowienie = new Zamowienie()
            {
                Id = maxId + 1,
                LekId = medId,
                Ilosc = (int)medAmountPicker.Value,
                Data = DateTime.UtcNow
            };

            var lek = context.Leki.Where(l => l.Id == medId).First();
            lek.Ilosc += (int)medAmountPicker.Value;

            context.Leki.Update(lek);
            context.Zamowienia.Add(zamowienie);
            context.SaveChanges();
            MainForm.medview.panelReturn();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            MainForm.medview.panelReturn();
        }
    }
}
