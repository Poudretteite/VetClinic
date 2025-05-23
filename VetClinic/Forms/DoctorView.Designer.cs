namespace VetClinic.Forms
{
    partial class DoctorView
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
            doctorMainTableLayout = new TableLayoutPanel();
            doctorVisitTable = new DataGridView();
            doctorDataPanel = new Panel();
            doctorDataLayoutPanel = new FlowLayoutPanel();
            doctorNameLabel = new Label();
            doctorSpecialization = new Label();
            pastVisitCount = new Label();
            futureVisitCount = new Label();
            doctorAddButton = new Button();
            doctorEditButton = new Button();
            doctorDeleteButton = new Button();
            doctorList = new ListBox();
            doctorMainTableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)doctorVisitTable).BeginInit();
            doctorDataPanel.SuspendLayout();
            doctorDataLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // doctorMainTableLayout
            // 
            doctorMainTableLayout.ColumnCount = 5;
            doctorMainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.8686323F));
            doctorMainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.0777473F));
            doctorMainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            doctorMainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            doctorMainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            doctorMainTableLayout.Controls.Add(doctorVisitTable, 2, 3);
            doctorMainTableLayout.Controls.Add(doctorDataPanel, 0, 3);
            doctorMainTableLayout.Controls.Add(doctorAddButton, 0, 0);
            doctorMainTableLayout.Controls.Add(doctorEditButton, 0, 1);
            doctorMainTableLayout.Controls.Add(doctorDeleteButton, 0, 2);
            doctorMainTableLayout.Controls.Add(doctorList, 1, 0);
            doctorMainTableLayout.Dock = DockStyle.Fill;
            doctorMainTableLayout.Location = new Point(0, 0);
            doctorMainTableLayout.Margin = new Padding(3, 2, 3, 2);
            doctorMainTableLayout.Name = "doctorMainTableLayout";
            doctorMainTableLayout.RowCount = 6;
            doctorMainTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            doctorMainTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            doctorMainTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            doctorMainTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            doctorMainTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            doctorMainTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            doctorMainTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            doctorMainTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            doctorMainTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            doctorMainTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            doctorMainTableLayout.Size = new Size(746, 341);
            doctorMainTableLayout.TabIndex = 0;
            // 
            // doctorVisitTable
            // 
            doctorVisitTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            doctorMainTableLayout.SetColumnSpan(doctorVisitTable, 3);
            doctorVisitTable.Dock = DockStyle.Fill;
            doctorVisitTable.Location = new Point(301, 171);
            doctorVisitTable.Name = "doctorVisitTable";
            doctorMainTableLayout.SetRowSpan(doctorVisitTable, 3);
            doctorVisitTable.Size = new Size(442, 167);
            doctorVisitTable.TabIndex = 2;
            // 
            // doctorDataPanel
            // 
            doctorMainTableLayout.SetColumnSpan(doctorDataPanel, 2);
            doctorDataPanel.Controls.Add(doctorDataLayoutPanel);
            doctorDataPanel.Dock = DockStyle.Fill;
            doctorDataPanel.Location = new Point(3, 171);
            doctorDataPanel.Name = "doctorDataPanel";
            doctorMainTableLayout.SetRowSpan(doctorDataPanel, 3);
            doctorDataPanel.Size = new Size(292, 167);
            doctorDataPanel.TabIndex = 3;
            // 
            // doctorDataLayoutPanel
            // 
            doctorDataLayoutPanel.Controls.Add(doctorNameLabel);
            doctorDataLayoutPanel.Controls.Add(doctorSpecialization);
            doctorDataLayoutPanel.Controls.Add(pastVisitCount);
            doctorDataLayoutPanel.Controls.Add(futureVisitCount);
            doctorDataLayoutPanel.Dock = DockStyle.Fill;
            doctorDataLayoutPanel.FlowDirection = FlowDirection.TopDown;
            doctorDataLayoutPanel.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            doctorDataLayoutPanel.Location = new Point(0, 0);
            doctorDataLayoutPanel.Margin = new Padding(3, 2, 3, 2);
            doctorDataLayoutPanel.Name = "doctorDataLayoutPanel";
            doctorDataLayoutPanel.Size = new Size(292, 167);
            doctorDataLayoutPanel.TabIndex = 1;
            // 
            // doctorNameLabel
            // 
            doctorNameLabel.AutoSize = true;
            doctorNameLabel.Dock = DockStyle.Fill;
            doctorNameLabel.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            doctorNameLabel.ForeColor = Color.FromArgb(215, 122, 97);
            doctorNameLabel.Location = new Point(3, 0);
            doctorNameLabel.Name = "doctorNameLabel";
            doctorNameLabel.Size = new Size(173, 27);
            doctorNameLabel.TabIndex = 6;
            doctorNameLabel.Text = "Imie i nazwisko";
            doctorNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // doctorSpecialization
            // 
            doctorSpecialization.AutoSize = true;
            doctorSpecialization.Location = new Point(3, 27);
            doctorSpecialization.Name = "doctorSpecialization";
            doctorSpecialization.Size = new Size(79, 15);
            doctorSpecialization.TabIndex = 7;
            doctorSpecialization.Text = "Specjalizacja";
            // 
            // pastVisitCount
            // 
            pastVisitCount.AutoSize = true;
            pastVisitCount.Location = new Point(3, 42);
            pastVisitCount.Name = "pastVisitCount";
            pastVisitCount.Size = new Size(154, 15);
            pastVisitCount.TabIndex = 8;
            pastVisitCount.Text = "Liczba zakończonych wizyt: ";
            // 
            // futureVisitCount
            // 
            futureVisitCount.AutoSize = true;
            futureVisitCount.Location = new Point(3, 57);
            futureVisitCount.Name = "futureVisitCount";
            futureVisitCount.Size = new Size(145, 15);
            futureVisitCount.TabIndex = 9;
            futureVisitCount.Text = "Liczba umówionych wizyt:";
            // 
            // doctorAddButton
            // 
            doctorAddButton.Anchor = AnchorStyles.None;
            doctorAddButton.BackColor = Color.FromArgb(219, 211, 216);
            doctorAddButton.FlatStyle = FlatStyle.Flat;
            doctorAddButton.Location = new Point(4, 11);
            doctorAddButton.Margin = new Padding(3, 2, 3, 2);
            doctorAddButton.Name = "doctorAddButton";
            doctorAddButton.Size = new Size(88, 33);
            doctorAddButton.TabIndex = 10;
            doctorAddButton.Text = "Dodaj";
            doctorAddButton.UseVisualStyleBackColor = false;
            // 
            // doctorEditButton
            // 
            doctorEditButton.Anchor = AnchorStyles.None;
            doctorEditButton.BackColor = Color.FromArgb(219, 211, 216);
            doctorEditButton.FlatStyle = FlatStyle.Flat;
            doctorEditButton.Location = new Point(4, 67);
            doctorEditButton.Margin = new Padding(3, 2, 3, 2);
            doctorEditButton.Name = "doctorEditButton";
            doctorEditButton.Size = new Size(88, 33);
            doctorEditButton.TabIndex = 11;
            doctorEditButton.Text = "Edytuj";
            doctorEditButton.UseVisualStyleBackColor = false;
            // 
            // doctorDeleteButton
            // 
            doctorDeleteButton.Anchor = AnchorStyles.None;
            doctorDeleteButton.BackColor = Color.Salmon;
            doctorDeleteButton.FlatStyle = FlatStyle.Flat;
            doctorDeleteButton.Location = new Point(4, 123);
            doctorDeleteButton.Margin = new Padding(3, 2, 3, 2);
            doctorDeleteButton.Name = "doctorDeleteButton";
            doctorDeleteButton.Size = new Size(88, 33);
            doctorDeleteButton.TabIndex = 12;
            doctorDeleteButton.Text = "Usuń";
            doctorDeleteButton.UseVisualStyleBackColor = false;
            // 
            // doctorList
            // 
            doctorMainTableLayout.SetColumnSpan(doctorList, 4);
            doctorList.Dock = DockStyle.Fill;
            doctorList.FormattingEnabled = true;
            doctorList.Location = new Point(99, 3);
            doctorList.Name = "doctorList";
            doctorMainTableLayout.SetRowSpan(doctorList, 3);
            doctorList.Size = new Size(644, 162);
            doctorList.TabIndex = 13;
            // 
            // DoctorView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(doctorMainTableLayout);
            Name = "DoctorView";
            Size = new Size(746, 341);
            doctorMainTableLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)doctorVisitTable).EndInit();
            doctorDataPanel.ResumeLayout(false);
            doctorDataLayoutPanel.ResumeLayout(false);
            doctorDataLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel doctorMainTableLayout;
        private FlowLayoutPanel doctorDataLayoutPanel;
        private Label doctorNameLabel;
        private Label doctorSpecialization;
        private Label pastVisitCount;
        private Label futureVisitCount;
        private DataGridView doctorVisitTable;
        private Panel doctorDataPanel;
        private Button doctorAddButton;
        private Button doctorEditButton;
        private Button doctorDeleteButton;
        private ListBox doctorList;
    }
}
