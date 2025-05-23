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
    public partial class VisitView : UserControl
    {
        private readonly MainForm _mainForm;
        public VisitView(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void visitDeleteButton_Click(object sender, EventArgs e)
        {

        }

        private void visitEditButton_Click(object sender, EventArgs e)
        {

        }
    }
}
