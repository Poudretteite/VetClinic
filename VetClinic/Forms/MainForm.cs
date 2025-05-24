using VetClinic.Forms;

namespace VetClinic
{
    public partial class MainForm : Form
    {
        public static AnimalView animalview = null;
        public static VisitView visitview = null;
        public static OwnerView ownerview = null;

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

        public void MainPageButton_Click(object sender, EventArgs e)
        {
            var mainview = new MainMenuView(this);
            LoadView(mainview);
        }

        public void visitButton_Click(object sender, EventArgs e)
        {
            visitview = new VisitView(this);
            LoadView(visitview);
        }

        public void animalButton_Click(object sender, EventArgs e)
        {
            animalview = new AnimalView(this);
            LoadView(animalview);
        }

        public void ownerButton_Click(object sender, EventArgs e)
        {
            ownerview = new OwnerView(this);
            LoadView(ownerview);
        }

        public void vetButton_Click(object sender, EventArgs e)
        {
            var doctorview = new DoctorView(this);
            LoadView(doctorview);
        }

        public void orderButton_Click(object sender, EventArgs e)
        {
            var orderview = new OrderView(this);
            LoadView(orderview);
        }
        public void medButton_Click(object sender, EventArgs e)
        {
            var medview = new MedicineView(this);
            LoadView(medview);
        }
    }
}
