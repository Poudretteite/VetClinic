namespace VetClinic.Forms
{
    partial class MedicineView
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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            mainTableLayout = new TableLayoutPanel();
            medicineList = new ListBox();
            visitDataGrid = new DataGridView();
            statsPanel = new FlowLayoutPanel();
            StatsLabel = new Label();
            label1 = new Label();
            visitCountChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            mainTableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)visitDataGrid).BeginInit();
            statsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)visitCountChart).BeginInit();
            SuspendLayout();
            // 
            // mainTableLayout
            // 
            mainTableLayout.ColumnCount = 3;
            mainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            mainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            mainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            mainTableLayout.Controls.Add(medicineList, 0, 0);
            mainTableLayout.Controls.Add(visitDataGrid, 1, 1);
            mainTableLayout.Controls.Add(statsPanel, 1, 0);
            mainTableLayout.Controls.Add(visitCountChart, 2, 0);
            mainTableLayout.Dock = DockStyle.Fill;
            mainTableLayout.Location = new Point(0, 0);
            mainTableLayout.Name = "mainTableLayout";
            mainTableLayout.RowCount = 3;
            mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            mainTableLayout.Size = new Size(800, 600);
            mainTableLayout.TabIndex = 0;
            // 
            // medicineList
            // 
            medicineList.BackColor = Color.White;
            medicineList.Cursor = Cursors.Hand;
            medicineList.Dock = DockStyle.Fill;
            medicineList.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            medicineList.FormattingEnabled = true;
            medicineList.Location = new Point(3, 3);
            medicineList.Name = "medicineList";
            mainTableLayout.SetRowSpan(medicineList, 3);
            medicineList.Size = new Size(260, 594);
            medicineList.Sorted = true;
            medicineList.TabIndex = 0;
            // 
            // visitDataGrid
            // 
            visitDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            mainTableLayout.SetColumnSpan(visitDataGrid, 2);
            visitDataGrid.Dock = DockStyle.Fill;
            visitDataGrid.Location = new Point(269, 203);
            visitDataGrid.Name = "visitDataGrid";
            mainTableLayout.SetRowSpan(visitDataGrid, 2);
            visitDataGrid.Size = new Size(528, 394);
            visitDataGrid.TabIndex = 1;
            // 
            // statsPanel
            // 
            statsPanel.Controls.Add(StatsLabel);
            statsPanel.Controls.Add(label1);
            statsPanel.Dock = DockStyle.Fill;
            statsPanel.FlowDirection = FlowDirection.TopDown;
            statsPanel.Location = new Point(269, 3);
            statsPanel.Name = "statsPanel";
            statsPanel.Size = new Size(260, 194);
            statsPanel.TabIndex = 3;
            // 
            // StatsLabel
            // 
            StatsLabel.AutoSize = true;
            StatsLabel.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            StatsLabel.ForeColor = Color.FromArgb(215, 122, 97);
            StatsLabel.Location = new Point(3, 0);
            StatsLabel.Name = "StatsLabel";
            StatsLabel.Size = new Size(118, 27);
            StatsLabel.TabIndex = 2;
            StatsLabel.Text = "Statystyki";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 27);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 4;
            label1.Text = "label1";
            // 
            // visitCountChart
            // 
            chartArea1.Name = "ChartArea1";
            visitCountChart.ChartAreas.Add(chartArea1);
            visitCountChart.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            visitCountChart.Legends.Add(legend1);
            visitCountChart.Location = new Point(535, 3);
            visitCountChart.Name = "visitCountChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            visitCountChart.Series.Add(series1);
            visitCountChart.Size = new Size(262, 194);
            visitCountChart.TabIndex = 4;
            visitCountChart.Text = "chart1";
            // 
            // MedicineView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(mainTableLayout);
            Name = "MedicineView";
            Size = new Size(800, 600);
            mainTableLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)visitDataGrid).EndInit();
            statsPanel.ResumeLayout(false);
            statsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)visitCountChart).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel mainTableLayout;
        private ListBox medicineList;
        private DataGridView visitDataGrid;
        private FlowLayoutPanel statsPanel;
        private Label StatsLabel;
        private Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart visitCountChart;
    }
}
