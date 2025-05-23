using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VetClinic.Forms
{
    public partial class MedicineView : UserControl
    {
        private readonly MainForm _mainForm;

        public MedicineView(MainForm mainForm)
        {
            _mainForm = mainForm;
            InitializeComponent();
            this.Load += MedicineView_Load;
        }

        private void MedicineView_Load(object sender, EventArgs e)
        {
            LoadToMedicineList();
            LoadToVisitDataGrid();
        }

        private void LoadToMedicineList()
        {
            var factory = new AppDbContextFactory();
            using var context = factory.CreateDbContext(Array.Empty<String>());

            var leki = context.Leki.ToList();

            foreach (var lek in leki)
            {
                medicineList.Items.Add(lek.Nazwa);
            }
        }

        private void LoadToVisitDataGrid()
        {
            var factory = new AppDbContextFactory();
            using var context = factory.CreateDbContext(Array.Empty<String>());


            var leki = context.Leki
                .Where(l => l.Ilosc > 90)
                .ToList();

            visitDataGrid.DataSource = leki;
        }

        private void medAddButton_Click(object sender, EventArgs e)
        {

        }

        private void medEditButton_Click(object sender, EventArgs e)
        {

        }

        private void medDeleteButton_Click(object sender, EventArgs e)
        {

        }

        private void medOrderButton_Click(object sender, EventArgs e)
        {

        }
    }
}
