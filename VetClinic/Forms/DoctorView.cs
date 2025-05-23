using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetClinic.Forms
{
    public partial class DoctorView : UserControl
    {
        private readonly MainForm _mainForm;
        public DoctorView(MainForm mainForm)
        {
            _mainForm = mainForm;
            InitializeComponent();
        }

        private void doctorAddButton_Click(object sender, EventArgs e)
        {

        }

        private void doctorEditButton_Click(object sender, EventArgs e)
        {

        }

        private void doctorDeleteButton_Click(object sender, EventArgs e)
        {

        }
    }
}
