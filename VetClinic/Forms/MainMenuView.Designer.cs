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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            visitChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            StatsFlowLayout = new FlowLayoutPanel();
            StatsLabel = new Label();
            petCount = new Label();
            visitCount = new Label();
            medCount = new System.Windows.Forms.DataVisualization.Charting.Chart();
            VisitScheduleGrid = new DataGridView();
            mainTableLayout = new TableLayoutPanel();
            visitGridTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)visitChart).BeginInit();
            StatsFlowLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)medCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)VisitScheduleGrid).BeginInit();
            mainTableLayout.SuspendLayout();
            SuspendLayout();
            // 
            // visitChart
            // 
            chartArea1.Name = "ChartArea1";
            visitChart.ChartAreas.Add(chartArea1);
            visitChart.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            visitChart.Legends.Add(legend1);
            visitChart.Location = new Point(75, 3);
            visitChart.Name = "visitChart";
            visitChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            visitChart.Size = new Size(430, 144);
            visitChart.TabIndex = 2;
            visitChart.Text = "Ilość wizyt w ostatnich miesiącach";
            // 
            // StatsFlowLayout
            // 
            StatsFlowLayout.BackgroundImageLayout = ImageLayout.None;
            StatsFlowLayout.Controls.Add(StatsLabel);
            StatsFlowLayout.Controls.Add(petCount);
            StatsFlowLayout.Controls.Add(visitCount);
            StatsFlowLayout.Dock = DockStyle.Fill;
            StatsFlowLayout.FlowDirection = FlowDirection.TopDown;
            StatsFlowLayout.Location = new Point(511, 3);
            StatsFlowLayout.Name = "StatsFlowLayout";
            mainTableLayout.SetRowSpan(StatsFlowLayout, 2);
            StatsFlowLayout.Size = new Size(286, 174);
            StatsFlowLayout.TabIndex = 1;
            // 
            // StatsLabel
            // 
            StatsLabel.AutoSize = true;
            StatsLabel.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            StatsLabel.ForeColor = Color.FromArgb(215, 122, 97);
            StatsLabel.Location = new Point(3, 0);
            StatsLabel.Name = "StatsLabel";
            StatsLabel.Size = new Size(118, 27);
            StatsLabel.TabIndex = 0;
            StatsLabel.Text = "Statystyki";
            // 
            // petCount
            // 
            petCount.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            petCount.AutoSize = true;
            petCount.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            petCount.Location = new Point(3, 27);
            petCount.Name = "petCount";
            petCount.Size = new Size(175, 16);
            petCount.TabIndex = 1;
            petCount.Text = "Liczba zwierząt: ";
            // 
            // visitCount
            // 
            visitCount.AutoSize = true;
            visitCount.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            visitCount.Location = new Point(3, 43);
            visitCount.Name = "visitCount";
            visitCount.Size = new Size(175, 16);
            visitCount.TabIndex = 2;
            visitCount.Text = "Liczba zakończonych wizyt: ";
            // 
            // medCount
            // 
            chartArea2.Name = "ChartArea1";
            medCount.ChartAreas.Add(chartArea2);
            medCount.Dock = DockStyle.Fill;
            legend2.Name = "Legend1";
            medCount.Legends.Add(legend2);
            medCount.Location = new Point(511, 183);
            medCount.Name = "medCount";
            medCount.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            mainTableLayout.SetRowSpan(medCount, 2);
            medCount.Size = new Size(286, 354);
            medCount.TabIndex = 3;
            medCount.Text = "Ilość leków";
            // 
            // VisitScheduleGrid
            // 
            VisitScheduleGrid.AllowUserToAddRows = false;
            VisitScheduleGrid.AllowUserToDeleteRows = false;
            VisitScheduleGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            VisitScheduleGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            VisitScheduleGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            VisitScheduleGrid.Dock = DockStyle.Fill;
            VisitScheduleGrid.Location = new Point(75, 183);
            VisitScheduleGrid.Name = "VisitScheduleGrid";
            VisitScheduleGrid.ReadOnly = true;
            VisitScheduleGrid.RowHeadersVisible = false;
            mainTableLayout.SetRowSpan(VisitScheduleGrid, 2);
            VisitScheduleGrid.Size = new Size(430, 354);
            VisitScheduleGrid.TabIndex = 0;
            // 
            // mainTableLayout
            // 
            mainTableLayout.ColumnCount = 3;
            mainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.090909F));
            mainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 54.5454559F));
            mainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.363636F));
            mainTableLayout.Controls.Add(visitChart, 1, 0);
            mainTableLayout.Controls.Add(StatsFlowLayout, 2, 0);
            mainTableLayout.Controls.Add(VisitScheduleGrid, 1, 2);
            mainTableLayout.Controls.Add(visitGridTitle, 1, 1);
            mainTableLayout.Controls.Add(medCount, 2, 2);
            mainTableLayout.Dock = DockStyle.Fill;
            mainTableLayout.Location = new Point(0, 0);
            mainTableLayout.Name = "mainTableLayout";
            mainTableLayout.RowCount = 5;
            mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            mainTableLayout.Size = new Size(800, 600);
            mainTableLayout.TabIndex = 3;
            // 
            // visitGridTitle
            // 
            visitGridTitle.AutoSize = true;
            visitGridTitle.Dock = DockStyle.Fill;
            visitGridTitle.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            visitGridTitle.ForeColor = Color.FromArgb(215, 122, 97);
            visitGridTitle.Location = new Point(75, 150);
            visitGridTitle.Name = "visitGridTitle";
            visitGridTitle.Size = new Size(430, 30);
            visitGridTitle.TabIndex = 3;
            visitGridTitle.Text = "Najbliższe wizyty";
            visitGridTitle.TextAlign = ContentAlignment.MiddleCenter;
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
            StatsFlowLayout.ResumeLayout(false);
            StatsFlowLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)medCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)VisitScheduleGrid).EndInit();
            mainTableLayout.ResumeLayout(false);
            mainTableLayout.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView VisitScheduleGrid;
        private System.Windows.Forms.DataVisualization.Charting.Chart visitChart;
        private FlowLayoutPanel StatsFlowLayout;
        private Label StatsLabel;
        private TableLayoutPanel mainTableLayout;
        private Label visitGridTitle;
        private Label petCount;
        private Label visitCount;
        private System.Windows.Forms.DataVisualization.Charting.Chart medCount;
    }
}
