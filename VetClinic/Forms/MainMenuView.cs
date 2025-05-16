using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VetClinic.Utils;
using Npgsql;

namespace VetClinic
{
    public partial class MainMenuView : UserControl
    {
        private readonly MainForm _mainForm;

        public MainMenuView(MainForm mainForm)
        {
            _mainForm = mainForm;
            InitializeComponent();
            this.Load += MainMenuView_Load;

        }

        private void MainMenuView_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            string connStr = ConfigHelper.GetConnectionString();

            using var conn = new NpgsqlConnection(connStr);
            try
            {
                conn.Open();
                string query = "SELECT * FROM wizyty";

                using var da = new NpgsqlDataAdapter(query, conn);
                var table = new DataTable();
                da.Fill(table);

                VisitScheduleGrid.DataSource = table;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
