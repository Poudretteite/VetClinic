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
    public partial class OrderView : UserControl
    {
        private readonly MainForm _mainForm;
        public OrderView(MainForm mainForm)
        {
            _mainForm = mainForm;
            InitializeComponent();
            this.Load += OrderView_Load;
        }

        private async void OrderView_Load(object sender, EventArgs e)
        {
            await LoadLists();
            await LoadToOrderDataGrid();
            LoadData();
        }

        private async Task DeleteOrder(Zamowienie zamowienie)
        {
            using var context = Constants.CreateContext();

            context.Zamowienia.Remove(zamowienie);
            context.SaveChanges();

            MainForm.zamowienia = await context.Zamowienia.ToListAsync();
        }

        private async Task LoadLists()
        {
            using var context = Constants.CreateContext();

            if (MainForm.zamowienia == null) MainForm.zamowienia = await context.Zamowienia.ToListAsync();
            if (MainForm.leki == null) MainForm.leki = await context.Leki.ToListAsync();
        }

        private async Task LoadToOrderDataGrid()
        {
            using var context = Constants.CreateContext();

            var zamowienia = context.Zamowienia.
                Include(z => z.Lek).
                Select(z => new
                {
                    Id = z.Id,
                    Lek = z.Lek.Nazwa,
                    Ilość = z.Ilosc,
                    Data = z.Data
                }).
            ToList();

            orderDataGrid.DataSource = zamowienia;
        }

        private void LoadData()
        {
            orderCount.Text = "Wszystkie zamówienia: " + MainForm.zamowienia.Count().ToString();
        }

        private async void orderDeleteButton_Click(object sender, EventArgs e)
        {
            if (orderDataGrid.SelectedRows.Count == 0)
                return;

            int selectedId = (int)orderDataGrid.SelectedRows[0].Cells["Id"].Value;

            var order = MainForm.zamowienia.FirstOrDefault(z => z.Id == selectedId);
            if (order != null)
            {
                await DeleteOrder(order);
                await LoadToOrderDataGrid();
            }
        }
    }
}
