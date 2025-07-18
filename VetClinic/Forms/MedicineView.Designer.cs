﻿namespace VetClinic.Forms
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
            mainTableLayout = new TableLayoutPanel();
            medSearchBox = new TextBox();
            medOrderButton = new Button();
            medDeleteButton = new Button();
            medEditButton = new Button();
            medAddButton = new Button();
            medicineList = new ListBox();
            visitDataGrid = new DataGridView();
            medDataPlaceholder = new Panel();
            statsPanel = new FlowLayoutPanel();
            StatsLabel = new Label();
            medCount = new Label();
            medVisitCount = new Label();
            mainTableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)visitDataGrid).BeginInit();
            medDataPlaceholder.SuspendLayout();
            statsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainTableLayout
            // 
            mainTableLayout.ColumnCount = 4;
            mainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.88372F));
            mainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.0531578F));
            mainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.0631237F));
            mainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 196F));
            mainTableLayout.Controls.Add(medSearchBox, 0, 0);
            mainTableLayout.Controls.Add(medOrderButton, 2, 3);
            mainTableLayout.Controls.Add(medDeleteButton, 1, 3);
            mainTableLayout.Controls.Add(medEditButton, 2, 2);
            mainTableLayout.Controls.Add(medAddButton, 1, 2);
            mainTableLayout.Controls.Add(medicineList, 0, 1);
            mainTableLayout.Controls.Add(visitDataGrid, 1, 4);
            mainTableLayout.Controls.Add(medDataPlaceholder, 1, 0);
            mainTableLayout.Dock = DockStyle.Fill;
            mainTableLayout.Location = new Point(0, 0);
            mainTableLayout.Name = "mainTableLayout";
            mainTableLayout.RowCount = 5;
            mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 6.54885674F));
            mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 20.5F));
            mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 7.83333349F));
            mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 7.83333349F));
            mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 57.6666679F));
            mainTableLayout.Size = new Size(800, 600);
            mainTableLayout.TabIndex = 0;
            // 
            // medSearchBox
            // 
            medSearchBox.Dock = DockStyle.Top;
            medSearchBox.Location = new Point(3, 2);
            medSearchBox.Margin = new Padding(3, 2, 3, 2);
            medSearchBox.Name = "medSearchBox";
            medSearchBox.PlaceholderText = "Wyszukaj po nazwie leku...";
            medSearchBox.Size = new Size(204, 21);
            medSearchBox.TabIndex = 15;
            // 
            // medOrderButton
            // 
            medOrderButton.Anchor = AnchorStyles.None;
            medOrderButton.BackColor = Color.FromArgb(34, 56, 67);
            medOrderButton.FlatStyle = FlatStyle.Flat;
            medOrderButton.ForeColor = Color.White;
            medOrderButton.Location = new Point(464, 213);
            medOrderButton.Margin = new Padding(3, 2, 3, 2);
            medOrderButton.Name = "medOrderButton";
            medOrderButton.Size = new Size(88, 33);
            medOrderButton.TabIndex = 14;
            medOrderButton.Text = "Zamów";
            medOrderButton.UseVisualStyleBackColor = false;
            medOrderButton.Click += medOrderButton_Click;
            // 
            // medDeleteButton
            // 
            medDeleteButton.Anchor = AnchorStyles.None;
            medDeleteButton.BackColor = Color.Salmon;
            medDeleteButton.FlatStyle = FlatStyle.Flat;
            medDeleteButton.Location = new Point(268, 213);
            medDeleteButton.Margin = new Padding(3, 2, 3, 2);
            medDeleteButton.Name = "medDeleteButton";
            medDeleteButton.Size = new Size(88, 33);
            medDeleteButton.TabIndex = 13;
            medDeleteButton.Text = "Usuń";
            medDeleteButton.UseVisualStyleBackColor = false;
            medDeleteButton.Click += medDeleteButton_Click;
            // 
            // medEditButton
            // 
            medEditButton.Anchor = AnchorStyles.None;
            medEditButton.BackColor = Color.FromArgb(219, 211, 216);
            medEditButton.FlatStyle = FlatStyle.Flat;
            medEditButton.Location = new Point(464, 167);
            medEditButton.Margin = new Padding(3, 2, 3, 2);
            medEditButton.Name = "medEditButton";
            medEditButton.Size = new Size(88, 33);
            medEditButton.TabIndex = 12;
            medEditButton.Text = "Edytuj";
            medEditButton.UseVisualStyleBackColor = false;
            medEditButton.Click += medEditButton_Click;
            // 
            // medAddButton
            // 
            medAddButton.Anchor = AnchorStyles.None;
            medAddButton.BackColor = Color.FromArgb(219, 211, 216);
            medAddButton.FlatStyle = FlatStyle.Flat;
            medAddButton.Location = new Point(268, 167);
            medAddButton.Margin = new Padding(3, 2, 3, 2);
            medAddButton.Name = "medAddButton";
            medAddButton.Size = new Size(88, 33);
            medAddButton.TabIndex = 11;
            medAddButton.Text = "Dodaj";
            medAddButton.UseVisualStyleBackColor = false;
            medAddButton.Click += medAddButton_Click;
            // 
            // medicineList
            // 
            medicineList.BackColor = Color.White;
            medicineList.Cursor = Cursors.Hand;
            medicineList.Dock = DockStyle.Fill;
            medicineList.Font = new Font("Arial", 9F);
            medicineList.FormattingEnabled = true;
            medicineList.Location = new Point(3, 42);
            medicineList.Name = "medicineList";
            mainTableLayout.SetRowSpan(medicineList, 4);
            medicineList.Size = new Size(204, 555);
            medicineList.Sorted = true;
            medicineList.TabIndex = 0;
            medicineList.SelectedIndexChanged += medicineList_SelectedIndexChanged;
            // 
            // visitDataGrid
            // 
            visitDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            visitDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            mainTableLayout.SetColumnSpan(visitDataGrid, 3);
            visitDataGrid.Dock = DockStyle.Fill;
            visitDataGrid.Location = new Point(213, 256);
            visitDataGrid.Name = "visitDataGrid";
            visitDataGrid.Size = new Size(584, 341);
            visitDataGrid.TabIndex = 1;
            // 
            // medDataPlaceholder
            // 
            mainTableLayout.SetColumnSpan(medDataPlaceholder, 3);
            medDataPlaceholder.Controls.Add(statsPanel);
            medDataPlaceholder.Dock = DockStyle.Fill;
            medDataPlaceholder.Location = new Point(213, 3);
            medDataPlaceholder.Name = "medDataPlaceholder";
            mainTableLayout.SetRowSpan(medDataPlaceholder, 2);
            medDataPlaceholder.Size = new Size(584, 155);
            medDataPlaceholder.TabIndex = 5;
            // 
            // statsPanel
            // 
            statsPanel.Controls.Add(StatsLabel);
            statsPanel.Controls.Add(medCount);
            statsPanel.Controls.Add(medVisitCount);
            statsPanel.Dock = DockStyle.Fill;
            statsPanel.FlowDirection = FlowDirection.TopDown;
            statsPanel.Location = new Point(0, 0);
            statsPanel.Name = "statsPanel";
            statsPanel.Size = new Size(584, 155);
            statsPanel.TabIndex = 3;
            // 
            // StatsLabel
            // 
            StatsLabel.AutoSize = true;
            StatsLabel.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            StatsLabel.ForeColor = Color.FromArgb(215, 122, 97);
            StatsLabel.Location = new Point(3, 0);
            StatsLabel.Name = "StatsLabel";
            StatsLabel.Size = new Size(83, 27);
            StatsLabel.TabIndex = 2;
            StatsLabel.Text = "Nazwa";
            // 
            // medCount
            // 
            medCount.AutoSize = true;
            medCount.Location = new Point(3, 27);
            medCount.Name = "medCount";
            medCount.Size = new Size(36, 15);
            medCount.TabIndex = 4;
            medCount.Text = "ilość:";
            // 
            // medVisitCount
            // 
            medVisitCount.AutoSize = true;
            medVisitCount.Location = new Point(3, 42);
            medVisitCount.Name = "medVisitCount";
            medVisitCount.Size = new Size(163, 15);
            medVisitCount.TabIndex = 5;
            medVisitCount.Text = "Wizyty na których został użyty:";
            // 
            // MedicineView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(mainTableLayout);
            Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Name = "MedicineView";
            Size = new Size(800, 600);
            mainTableLayout.ResumeLayout(false);
            mainTableLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)visitDataGrid).EndInit();
            medDataPlaceholder.ResumeLayout(false);
            statsPanel.ResumeLayout(false);
            statsPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel mainTableLayout;
        private ListBox medicineList;
        private DataGridView visitDataGrid;
        private FlowLayoutPanel statsPanel;
        private Label StatsLabel;
        private Label medCount;
        private Label medVisitCount;
        private Panel medDataPlaceholder;
        private Button medAddButton;
        private Button medEditButton;
        private Button medOrderButton;
        private Button medDeleteButton;
        private TextBox medSearchBox;
    }
}
