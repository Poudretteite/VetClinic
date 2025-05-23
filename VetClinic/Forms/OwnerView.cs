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
    public partial class OwnerView : UserControl
    {
        private readonly MainForm _mainForm;
        public OwnerView(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void ownerEditButton_Click(object sender, EventArgs e)
        {

        }

        private void ownerDeleteButton_Click(object sender, EventArgs e)
        {

        }

        private void ownerAddButton_Click(object sender, EventArgs e)
        {

        }
    }
}
