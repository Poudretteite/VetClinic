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
    public partial class OrderAddForm : UserControl
    {
        private readonly MainForm _mainForm;
        public OrderAddForm(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private async Task AddOrder(Zamowienie zamowienie, Lek lek)
        {
            using var context = Constants.CreateContext();

            context.Leki.Update(lek);
            context.Zamowienia.Add(zamowienie);
            context.SaveChanges();

            MainForm.zamowienia = await context.Zamowienia.ToListAsync();
            MainForm.leki = await context.Leki.ToListAsync();
        }

        private async void acceptButton_Click(object sender, EventArgs e)
        {
            

            int maxId = MainForm.zamowienia.Max(z => z.Id);
            int medId = MainForm.medview.selectedMedId;

            Zamowienie zamowienie = new Zamowienie()
            {
                Id = maxId + 1,
                LekId = medId,
                Ilosc = (int)medAmountPicker.Value,
                Data = DateTime.UtcNow
            };

            var lek = MainForm.leki.Where(l => l.Id == medId).FirstOrDefault();
            lek.Ilosc += (int)medAmountPicker.Value;

            await AddOrder(zamowienie, lek);
            
            MainForm.medview.panelReturn();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            MainForm.medview.panelReturn();
        }
    }
}
