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

    }
}
