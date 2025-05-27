using VetClinic.Forms;
using VetClinic.Models;

namespace VetClinic
{
    public partial class MainForm : Form
    {
        public static AnimalView animalview = null;
        public static VisitView visitview = null;
        public static OwnerView ownerview = null;
        public static DoctorView doctorview = null;
        public static MedicineView medview = null;
        public static OrderView orderview = null;
        public static MainMenuView mainmenuview = null;

        static public List<Zwierze> zwierzeta;
        static public List<Wizyta> wizyty;
        static public List<Osoba> osoby;
        static public List<Zamowienie> zamowienia;
        static public List<Lek> leki;
        static public List<Lekarz> lekarze;

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
            if (mainmenuview == null)
            {
                mainmenuview = new MainMenuView(this);
            }
            LoadView(mainmenuview);
        }

        public void visitButton_Click(object sender, EventArgs e)
        {
            if (visitview == null)
            {
                visitview = new VisitView(this);
            }
            LoadView(visitview);
        }

        public void animalButton_Click(object sender, EventArgs e)
        {
            if (animalview == null)
            {
                animalview = new AnimalView(this);
            }
            LoadView(animalview);
        }

        public void ownerButton_Click(object sender, EventArgs e)
        {
            if (ownerview == null)
            {
                ownerview = new OwnerView(this);
            }
            LoadView(ownerview);
        }

        public void vetButton_Click(object sender, EventArgs e)
        {
            if (doctorview == null)
            {
                doctorview = new DoctorView(this);
            }
            LoadView(doctorview);
        }

        public void orderButton_Click(object sender, EventArgs e)
        {
            if (orderview == null)
            {
                orderview = new OrderView(this);
            }
            LoadView(orderview);
        }
        public void medButton_Click(object sender, EventArgs e)
        {
            if (medview == null)
            {
                medview = new MedicineView(this);
            }
            LoadView(medview);
        }
    }
}
