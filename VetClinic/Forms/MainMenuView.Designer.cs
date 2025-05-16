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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            visitChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            StatsFlowLayout = new FlowLayoutPanel();
            StatsLabel = new Label();
            VisitScheduleGrid = new DataGridView();
            mainTableLayout = new TableLayoutPanel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)visitChart).BeginInit();
            StatsFlowLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)VisitScheduleGrid).BeginInit();
            mainTableLayout.SuspendLayout();
            SuspendLayout();
            // 
            // visitChart
            // 
            chartArea2.Name = "ChartArea1";
            visitChart.ChartAreas.Add(chartArea2);
            visitChart.Dock = DockStyle.Fill;
            legend2.Name = "Legend1";
            visitChart.Legends.Add(legend2);
            visitChart.Location = new Point(75, 3);
            visitChart.Name = "visitChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            visitChart.Series.Add(series2);
            visitChart.Size = new Size(430, 144);
            visitChart.TabIndex = 2;
            visitChart.Text = "Ilość wizyt w ostatnich miesiącach";
            // 
            // StatsFlowLayout
            // 
            StatsFlowLayout.Controls.Add(StatsLabel);
            StatsFlowLayout.Dock = DockStyle.Fill;
            StatsFlowLayout.Location = new Point(511, 3);
            StatsFlowLayout.Name = "StatsFlowLayout";
            StatsFlowLayout.Size = new Size(286, 144);
            StatsFlowLayout.TabIndex = 1;
            // 
            // StatsLabel
            // 
            StatsLabel.AutoSize = true;
            StatsLabel.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            StatsLabel.Location = new Point(3, 0);
            StatsLabel.Name = "StatsLabel";
            StatsLabel.Size = new Size(63, 15);
            StatsLabel.TabIndex = 0;
            StatsLabel.Text = "Statystyki";
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
            mainTableLayout.Controls.Add(label1, 1, 1);
            mainTableLayout.Dock = DockStyle.Fill;
            mainTableLayout.Location = new Point(0, 0);
            mainTableLayout.Name = "mainTableLayout";
            mainTableLayout.RowCount = 4;
            mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            mainTableLayout.Size = new Size(800, 600);
            mainTableLayout.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(75, 150);
            label1.Name = "label1";
            label1.Size = new Size(430, 30);
            label1.TabIndex = 3;
            label1.Text = "Najbliższe wizyty";
            label1.TextAlign = ContentAlignment.MiddleCenter;
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
        private Label label1;
    }
}
