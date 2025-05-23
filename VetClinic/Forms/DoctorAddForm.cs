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
    public partial class DoctorAddForm : UserControl
    {
        private readonly MainForm _mainForm;
        public DoctorAddForm(MainForm mainForm)
        {
            _mainForm = mainForm;
            InitializeComponent();
        }
    }
}
