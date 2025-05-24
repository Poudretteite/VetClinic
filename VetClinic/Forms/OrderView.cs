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
            InitializeComponent();
            _mainForm = mainForm;
            LoadToOrderDataGrid();
            LoadData();
        }

        private void LoadToOrderDataGrid()
        {
            var factory = new AppDbContextFactory();
            using var context = factory.CreateDbContext(Array.Empty<string>());

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
            var factory = new AppDbContextFactory();
            using var context = factory.CreateDbContext(Array.Empty<string>());

            orderCount.Text = "Wszystkie zamówienia: " + context.Zamowienia.Count().ToString();
        }
    }
}
