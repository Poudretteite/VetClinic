using VetClinic.Forms;

namespace VetClinic
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            LoadView(new MainMenuView(this));
        }

        public void LoadView(UserControl view)
        {
            viewPanel.Controls.Clear();
            view.Dock = DockStyle.Fill;
            viewPanel.Controls.Add(view);
        }

        private void MainPageButton_Click(object sender, EventArgs e)
        {
            var mainview = new MainMenuView(this);
            LoadView(mainview);
        }

        private void visitButton_Click(object sender, EventArgs e)
        {
            var visitview = new VisitView(this);
            LoadView(visitview);
        }

        private void animalButton_Click(object sender, EventArgs e)
        {
            var animalview = new AnimalView(this);
            LoadView(animalview);
        }

        private void ownerButton_Click(object sender, EventArgs e)
        {
            var ownerview = new OwnerView(this);
            LoadView(ownerview);
        }

        private void vetButton_Click(object sender, EventArgs e)
        {
            var doctorview = new DoctorView(this);
            LoadView(doctorview);
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            var orderview = new OrderView(this);
            LoadView(orderview);
        }
        private void medButton_Click(object sender, EventArgs e)
        {
            var medview = new MedicineView(this);
            LoadView(medview);
        }
    }
}
