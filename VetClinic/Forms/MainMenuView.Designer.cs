namespace VetClinic
{
    partial class MainMenuView
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            visitChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            medCount = new System.Windows.Forms.DataVisualization.Charting.Chart();
            VisitScheduleGrid = new DataGridView();
            mainTableLayout = new TableLayoutPanel();
            visitGridTitle = new Label();
            DatabaseConnectionInfo = new Panel();
            connectButton = new Button();
            databasePassword = new TextBox();
            databaseUsername = new TextBox();
            databaseName = new TextBox();
            databasePasswordLabel = new Label();
            databaseUsernameLabel = new Label();
            databaseNameLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)visitChart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)medCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)VisitScheduleGrid).BeginInit();
            mainTableLayout.SuspendLayout();
            DatabaseConnectionInfo.SuspendLayout();
            SuspendLayout();
            // 
            // visitChart
            // 
            chartArea3.Name = "ChartArea1";
            visitChart.ChartAreas.Add(chartArea3);
            visitChart.Dock = DockStyle.Fill;
            legend3.Name = "Legend1";
            visitChart.Legends.Add(legend3);
            visitChart.Location = new Point(15, 3);
            visitChart.Name = "visitChart";
            visitChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            visitChart.Size = new Size(490, 179);
            visitChart.TabIndex = 2;
            visitChart.Text = "Ilość wizyt w ostatnich miesiącach";
            // 
            // medCount
            // 
            chartArea4.Name = "ChartArea1";
            medCount.ChartAreas.Add(chartArea4);
            medCount.Dock = DockStyle.Fill;
            legend4.Name = "Legend1";
            medCount.Legends.Add(legend4);
            medCount.Location = new Point(511, 3);
            medCount.Name = "medCount";
            medCount.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            mainTableLayout.SetRowSpan(medCount, 5);
            medCount.Size = new Size(286, 594);
            medCount.TabIndex = 3;
            medCount.Text = "Ilość leków";
            // 
            // VisitScheduleGrid
            // 
            VisitScheduleGrid.AllowUserToAddRows = false;
            VisitScheduleGrid.AllowUserToDeleteRows = false;
            VisitScheduleGrid.AllowUserToResizeRows = false;
            VisitScheduleGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            VisitScheduleGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            VisitScheduleGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            VisitScheduleGrid.Dock = DockStyle.Fill;
            VisitScheduleGrid.Location = new Point(15, 219);
            VisitScheduleGrid.Name = "VisitScheduleGrid";
            VisitScheduleGrid.ReadOnly = true;
            VisitScheduleGrid.RowHeadersVisible = false;
            VisitScheduleGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            mainTableLayout.SetRowSpan(VisitScheduleGrid, 2);
            VisitScheduleGrid.Size = new Size(490, 276);
            VisitScheduleGrid.TabIndex = 0;
            // 
            // mainTableLayout
            // 
            mainTableLayout.ColumnCount = 3;
            mainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1.5F));
            mainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62F));
            mainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.363636F));
            mainTableLayout.Controls.Add(visitChart, 1, 0);
            mainTableLayout.Controls.Add(VisitScheduleGrid, 1, 2);
            mainTableLayout.Controls.Add(visitGridTitle, 1, 1);
            mainTableLayout.Controls.Add(medCount, 2, 0);
            mainTableLayout.Controls.Add(DatabaseConnectionInfo, 1, 4);
            mainTableLayout.Dock = DockStyle.Fill;
            mainTableLayout.Location = new Point(0, 0);
            mainTableLayout.Name = "mainTableLayout";
            mainTableLayout.RowCount = 5;
            mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 30.833334F));
            mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 5.16666651F));
            mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 24F));
            mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 23F));
            mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 17F));
            mainTableLayout.Size = new Size(800, 600);
            mainTableLayout.TabIndex = 3;
            // 
            // visitGridTitle
            // 
            visitGridTitle.AutoSize = true;
            visitGridTitle.Dock = DockStyle.Fill;
            visitGridTitle.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            visitGridTitle.ForeColor = Color.FromArgb(215, 122, 97);
            visitGridTitle.Location = new Point(15, 185);
            visitGridTitle.Name = "visitGridTitle";
            visitGridTitle.Size = new Size(490, 31);
            visitGridTitle.TabIndex = 3;
            visitGridTitle.Text = "Najbliższe wizyty";
            visitGridTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DatabaseConnectionInfo
            // 
            DatabaseConnectionInfo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            DatabaseConnectionInfo.Controls.Add(connectButton);
            DatabaseConnectionInfo.Controls.Add(databasePassword);
            DatabaseConnectionInfo.Controls.Add(databaseUsername);
            DatabaseConnectionInfo.Controls.Add(databaseName);
            DatabaseConnectionInfo.Controls.Add(databasePasswordLabel);
            DatabaseConnectionInfo.Controls.Add(databaseUsernameLabel);
            DatabaseConnectionInfo.Controls.Add(databaseNameLabel);
            DatabaseConnectionInfo.Dock = DockStyle.Fill;
            DatabaseConnectionInfo.Location = new Point(15, 501);
            DatabaseConnectionInfo.Name = "DatabaseConnectionInfo";
            DatabaseConnectionInfo.Size = new Size(490, 96);
            DatabaseConnectionInfo.TabIndex = 4;
            // 
            // connectButton
            // 
            connectButton.BackColor = Color.FromArgb(34, 56, 67);
            connectButton.FlatStyle = FlatStyle.Flat;
            connectButton.ForeColor = Color.White;
            connectButton.Location = new Point(140, 56);
            connectButton.Name = "connectButton";
            connectButton.Size = new Size(114, 30);
            connectButton.TabIndex = 6;
            connectButton.Text = "Połącz";
            connectButton.UseVisualStyleBackColor = false;
            connectButton.Click += connectButton_Click;
            // 
            // databasePassword
            // 
            databasePassword.Location = new Point(1, 61);
            databasePassword.Name = "databasePassword";
            databasePassword.PasswordChar = '*';
            databasePassword.Size = new Size(114, 23);
            databasePassword.TabIndex = 5;
            // 
            // databaseUsername
            // 
            databaseUsername.Location = new Point(1, 19);
            databaseUsername.Name = "databaseUsername";
            databaseUsername.Size = new Size(114, 23);
            databaseUsername.TabIndex = 4;
            // 
            // databaseName
            // 
            databaseName.Location = new Point(140, 19);
            databaseName.Name = "databaseName";
            databaseName.Size = new Size(114, 23);
            databaseName.TabIndex = 3;
            // 
            // databasePasswordLabel
            // 
            databasePasswordLabel.AutoSize = true;
            databasePasswordLabel.Location = new Point(1, 43);
            databasePasswordLabel.Name = "databasePasswordLabel";
            databasePasswordLabel.Size = new Size(40, 15);
            databasePasswordLabel.TabIndex = 2;
            databasePasswordLabel.Text = "Hasło:";
            // 
            // databaseUsernameLabel
            // 
            databaseUsernameLabel.AutoSize = true;
            databaseUsernameLabel.Location = new Point(1, 1);
            databaseUsernameLabel.Name = "databaseUsernameLabel";
            databaseUsernameLabel.Size = new Size(114, 15);
            databaseUsernameLabel.TabIndex = 1;
            databaseUsernameLabel.Text = "Nazwa użytkownika:";
            // 
            // databaseNameLabel
            // 
            databaseNameLabel.AutoSize = true;
            databaseNameLabel.Location = new Point(140, 1);
            databaseNameLabel.Name = "databaseNameLabel";
            databaseNameLabel.Size = new Size(114, 15);
            databaseNameLabel.TabIndex = 0;
            databaseNameLabel.Text = "Nazwa bazy danych:";
            // 
            // MainMenuView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(mainTableLayout);
            Margin = new Padding(0);
            Name = "MainMenuView";
            Size = new Size(800, 600);
            ((System.ComponentModel.ISupportInitialize)visitChart).EndInit();
            ((System.ComponentModel.ISupportInitialize)medCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)VisitScheduleGrid).EndInit();
            mainTableLayout.ResumeLayout(false);
            mainTableLayout.PerformLayout();
            DatabaseConnectionInfo.ResumeLayout(false);
            DatabaseConnectionInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView VisitScheduleGrid;
        private System.Windows.Forms.DataVisualization.Charting.Chart visitChart;
        private TableLayoutPanel mainTableLayout;
        private Label visitGridTitle;
        private System.Windows.Forms.DataVisualization.Charting.Chart medCount;
        private Panel DatabaseConnectionInfo;
        private Label databaseUsernameLabel;
        private Label databaseNameLabel;
        private TextBox databasePassword;
        private TextBox databaseUsername;
        private TextBox databaseName;
        private Label databasePasswordLabel;
        private Button connectButton;
    }
}
