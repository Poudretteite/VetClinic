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
            this.Controls.Clear();
            view.Dock = DockStyle.Fill;
            this.Controls.Add(view);
        }

    }
}
