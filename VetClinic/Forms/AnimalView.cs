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

namespace VetClinic
{
    public partial class AnimalView : UserControl
    {
        private readonly MainForm _mainForm;

        public AnimalView(MainForm mainForm)
        {
            _mainForm = mainForm;
            InitializeComponent();
            this.Load += AnimalView_Load;
        }

        private void AnimalView_Load(object sender, EventArgs e)
        {
            LoadToAnimalList();
        }

        private void LoadToAnimalList()
        {
            var factory = new AppDbContextFactory();
            using var context = factory.CreateDbContext(Array.Empty<string>());

            var leki = context.Leki.ToList();

            foreach (var lek in leki)
            {
                animalList.Items.Add(lek.Nazwa);
            }

        }
    }
}
