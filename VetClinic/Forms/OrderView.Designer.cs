namespace VetClinic.Forms
{
    partial class OrderView
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
            tableLayoutPanel1 = new TableLayoutPanel();
            orderDataGrid = new DataGridView();
            orderViewTitle = new Label();
            orderStatsFlowLayout = new FlowLayoutPanel();
            label1 = new Label();
            orderLastMonthCount = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)orderDataGrid).BeginInit();
            orderStatsFlowLayout.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.8064518F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.1290321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.1290321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.1290321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.8064518F));
            tableLayoutPanel1.Controls.Add(orderDataGrid, 0, 2);
            tableLayoutPanel1.Controls.Add(orderViewTitle, 1, 0);
            tableLayoutPanel1.Controls.Add(orderStatsFlowLayout, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Size = new Size(800, 600);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // orderDataGrid
            // 
            orderDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel1.SetColumnSpan(orderDataGrid, 5);
            orderDataGrid.Dock = DockStyle.Fill;
            orderDataGrid.Location = new Point(3, 123);
            orderDataGrid.Name = "orderDataGrid";
            tableLayoutPanel1.SetRowSpan(orderDataGrid, 4);
            orderDataGrid.Size = new Size(794, 474);
            orderDataGrid.TabIndex = 0;
            // 
            // orderViewTitle
            // 
            orderViewTitle.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(orderViewTitle, 3);
            orderViewTitle.Dock = DockStyle.Fill;
            orderViewTitle.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            orderViewTitle.ForeColor = Color.FromArgb(215, 122, 97);
            orderViewTitle.Location = new Point(209, 0);
            orderViewTitle.Name = "orderViewTitle";
            orderViewTitle.Size = new Size(381, 60);
            orderViewTitle.TabIndex = 1;
            orderViewTitle.Text = "Historia zamówień leków";
            orderViewTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // orderStatsFlowLayout
            // 
            orderStatsFlowLayout.Controls.Add(label1);
            orderStatsFlowLayout.Controls.Add(orderLastMonthCount);
            orderStatsFlowLayout.Dock = DockStyle.Fill;
            orderStatsFlowLayout.FlowDirection = FlowDirection.TopDown;
            orderStatsFlowLayout.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            orderStatsFlowLayout.Location = new Point(3, 63);
            orderStatsFlowLayout.Name = "orderStatsFlowLayout";
            orderStatsFlowLayout.Size = new Size(200, 54);
            orderStatsFlowLayout.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(133, 15);
            label1.TabIndex = 0;
            label1.Text = "Wszystkie zamówienia:";
            // 
            // orderLastMonthCount
            // 
            orderLastMonthCount.AutoSize = true;
            orderLastMonthCount.Location = new Point(3, 15);
            orderLastMonthCount.Name = "orderLastMonthCount";
            orderLastMonthCount.Size = new Size(175, 30);
            orderLastMonthCount.TabIndex = 1;
            orderLastMonthCount.Text = "Liczba zamówień przez ostatni miesiąc:";
            // 
            // OrderView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "OrderView";
            Size = new Size(800, 600);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)orderDataGrid).EndInit();
            orderStatsFlowLayout.ResumeLayout(false);
            orderStatsFlowLayout.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView orderDataGrid;
        private Label orderViewTitle;
        private FlowLayoutPanel orderStatsFlowLayout;
        private Label label1;
        private Label orderLastMonthCount;
    }
}
