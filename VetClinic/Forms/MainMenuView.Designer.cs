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
            medCount = new System.Windows.Forms.DataVisualization.Charting.Chart();
            VisitScheduleGrid = new DataGridView();
            mainTableLayout = new TableLayoutPanel();
            visitGridTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)visitChart).BeginInit();
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
            visitChart.Size = new Size(430, 179);
            visitChart.TabIndex = 2;
            visitChart.Text = "Ilość wizyt w ostatnich miesiącach";
            // 
            // medCount
            // 
            chartArea2.Name = "ChartArea1";
            medCount.ChartAreas.Add(chartArea2);
            medCount.Dock = DockStyle.Fill;
            legend2.Name = "Legend1";
            medCount.Legends.Add(legend2);
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
            VisitScheduleGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            VisitScheduleGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            VisitScheduleGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            VisitScheduleGrid.Dock = DockStyle.Fill;
            VisitScheduleGrid.Location = new Point(75, 219);
            VisitScheduleGrid.Name = "VisitScheduleGrid";
            VisitScheduleGrid.ReadOnly = true;
            VisitScheduleGrid.RowHeadersVisible = false;
            VisitScheduleGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            mainTableLayout.SetRowSpan(VisitScheduleGrid, 2);
            VisitScheduleGrid.Size = new Size(430, 318);
            VisitScheduleGrid.TabIndex = 0;
            // 
            // mainTableLayout
            // 
            mainTableLayout.ColumnCount = 3;
            mainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.090909F));
            mainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 54.5454559F));
            mainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.363636F));
            mainTableLayout.Controls.Add(visitChart, 1, 0);
            mainTableLayout.Controls.Add(VisitScheduleGrid, 1, 2);
            mainTableLayout.Controls.Add(visitGridTitle, 1, 1);
            mainTableLayout.Controls.Add(medCount, 2, 0);
            mainTableLayout.Dock = DockStyle.Fill;
            mainTableLayout.Location = new Point(0, 0);
            mainTableLayout.Name = "mainTableLayout";
            mainTableLayout.RowCount = 5;
            mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 30.833334F));
            mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 5.16666651F));
            mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 24F));
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
            visitGridTitle.Location = new Point(75, 185);
            visitGridTitle.Name = "visitGridTitle";
            visitGridTitle.Size = new Size(430, 31);
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
            ((System.ComponentModel.ISupportInitialize)medCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)VisitScheduleGrid).EndInit();
            mainTableLayout.ResumeLayout(false);
            mainTableLayout.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView VisitScheduleGrid;
        private System.Windows.Forms.DataVisualization.Charting.Chart visitChart;
        private TableLayoutPanel mainTableLayout;
        private Label visitGridTitle;
        private System.Windows.Forms.DataVisualization.Charting.Chart medCount;
    }
}
