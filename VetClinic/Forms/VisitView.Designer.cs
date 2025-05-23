namespace VetClinic.Forms
{
    partial class VisitView
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
            visitMainTableLayout = new TableLayoutPanel();
            visitDoctorLabel = new Label();
            visitDataLabel = new Label();
            visitAnimalLabel = new Label();
            visitDoctorPanel = new FlowLayoutPanel();
            visitDoctorName = new Label();
            visitDoctorSpecialization = new Label();
            visitDataGrid = new DataGridView();
            visitAnimalPanel = new FlowLayoutPanel();
            visitAnimalName = new Label();
            visitAnimalType = new Label();
            visitAnimalSpecies = new Label();
            visitAnimalAge = new Label();
            visitDataPlaceholder = new Panel();
            visitDataPanel = new FlowLayoutPanel();
            visitDateLabel = new Label();
            visitPlaceLabel = new Label();
            visitDescription = new Label();
            visitEditButton = new Button();
            visitDeleteButton = new Button();
            visitMainTableLayout.SuspendLayout();
            visitDoctorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)visitDataGrid).BeginInit();
            visitAnimalPanel.SuspendLayout();
            visitDataPlaceholder.SuspendLayout();
            visitDataPanel.SuspendLayout();
            SuspendLayout();
            // 
            // visitMainTableLayout
            // 
            visitMainTableLayout.ColumnCount = 6;
            visitMainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666718F));
            visitMainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9F));
            visitMainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.25F));
            visitMainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.375F));
            visitMainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.875F));
            visitMainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            visitMainTableLayout.Controls.Add(visitDoctorLabel, 4, 0);
            visitMainTableLayout.Controls.Add(visitDataLabel, 2, 0);
            visitMainTableLayout.Controls.Add(visitAnimalLabel, 0, 0);
            visitMainTableLayout.Controls.Add(visitDoctorPanel, 4, 1);
            visitMainTableLayout.Controls.Add(visitDataGrid, 0, 3);
            visitMainTableLayout.Controls.Add(visitAnimalPanel, 0, 1);
            visitMainTableLayout.Controls.Add(visitDataPlaceholder, 2, 1);
            visitMainTableLayout.Controls.Add(visitEditButton, 3, 2);
            visitMainTableLayout.Controls.Add(visitDeleteButton, 2, 2);
            visitMainTableLayout.Dock = DockStyle.Fill;
            visitMainTableLayout.Location = new Point(0, 0);
            visitMainTableLayout.Name = "visitMainTableLayout";
            visitMainTableLayout.RowCount = 6;
            visitMainTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 7F));
            visitMainTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 19.833334F));
            visitMainTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 6.5F));
            visitMainTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 17.333334F));
            visitMainTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 15.7962294F));
            visitMainTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3695335F));
            visitMainTableLayout.Size = new Size(800, 600);
            visitMainTableLayout.TabIndex = 0;
            // 
            // visitDoctorLabel
            // 
            visitDoctorLabel.AutoSize = true;
            visitMainTableLayout.SetColumnSpan(visitDoctorLabel, 2);
            visitDoctorLabel.Dock = DockStyle.Fill;
            visitDoctorLabel.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            visitDoctorLabel.ForeColor = Color.FromArgb(215, 122, 97);
            visitDoctorLabel.Location = new Point(581, 0);
            visitDoctorLabel.Name = "visitDoctorLabel";
            visitDoctorLabel.Size = new Size(216, 42);
            visitDoctorLabel.TabIndex = 3;
            visitDoctorLabel.Text = "Lekarz";
            visitDoctorLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // visitDataLabel
            // 
            visitDataLabel.AutoSize = true;
            visitMainTableLayout.SetColumnSpan(visitDataLabel, 2);
            visitDataLabel.Dock = DockStyle.Fill;
            visitDataLabel.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            visitDataLabel.ForeColor = Color.FromArgb(34, 56, 67);
            visitDataLabel.Location = new Point(208, 0);
            visitDataLabel.Name = "visitDataLabel";
            visitDataLabel.Size = new Size(367, 42);
            visitDataLabel.TabIndex = 3;
            visitDataLabel.Text = "Dane Wizyty";
            visitDataLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // visitAnimalLabel
            // 
            visitAnimalLabel.AutoSize = true;
            visitMainTableLayout.SetColumnSpan(visitAnimalLabel, 2);
            visitAnimalLabel.Dock = DockStyle.Fill;
            visitAnimalLabel.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            visitAnimalLabel.ForeColor = Color.FromArgb(215, 122, 97);
            visitAnimalLabel.Location = new Point(3, 0);
            visitAnimalLabel.Name = "visitAnimalLabel";
            visitAnimalLabel.Size = new Size(199, 42);
            visitAnimalLabel.TabIndex = 3;
            visitAnimalLabel.Text = "Zwierze";
            visitAnimalLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // visitDoctorPanel
            // 
            visitMainTableLayout.SetColumnSpan(visitDoctorPanel, 2);
            visitDoctorPanel.Controls.Add(visitDoctorName);
            visitDoctorPanel.Controls.Add(visitDoctorSpecialization);
            visitDoctorPanel.Dock = DockStyle.Fill;
            visitDoctorPanel.FlowDirection = FlowDirection.TopDown;
            visitDoctorPanel.Location = new Point(581, 45);
            visitDoctorPanel.Name = "visitDoctorPanel";
            visitDoctorPanel.Size = new Size(216, 113);
            visitDoctorPanel.TabIndex = 3;
            // 
            // visitDoctorName
            // 
            visitDoctorName.AutoSize = true;
            visitDoctorName.Font = new Font("Arial", 10F, FontStyle.Bold);
            visitDoctorName.Location = new Point(3, 0);
            visitDoctorName.Name = "visitDoctorName";
            visitDoctorName.Size = new Size(112, 16);
            visitDoctorName.TabIndex = 1;
            visitDoctorName.Text = "Imie i nazwisko";
            // 
            // visitDoctorSpecialization
            // 
            visitDoctorSpecialization.AutoSize = true;
            visitDoctorSpecialization.Location = new Point(3, 16);
            visitDoctorSpecialization.Name = "visitDoctorSpecialization";
            visitDoctorSpecialization.Size = new Size(79, 15);
            visitDoctorSpecialization.TabIndex = 2;
            visitDoctorSpecialization.Text = "Specjalizacja";
            // 
            // visitDataGrid
            // 
            visitDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            visitMainTableLayout.SetColumnSpan(visitDataGrid, 6);
            visitDataGrid.Dock = DockStyle.Fill;
            visitDataGrid.Location = new Point(3, 203);
            visitDataGrid.Name = "visitDataGrid";
            visitMainTableLayout.SetRowSpan(visitDataGrid, 3);
            visitDataGrid.Size = new Size(794, 394);
            visitDataGrid.TabIndex = 0;
            // 
            // visitAnimalPanel
            // 
            visitMainTableLayout.SetColumnSpan(visitAnimalPanel, 2);
            visitAnimalPanel.Controls.Add(visitAnimalName);
            visitAnimalPanel.Controls.Add(visitAnimalType);
            visitAnimalPanel.Controls.Add(visitAnimalSpecies);
            visitAnimalPanel.Controls.Add(visitAnimalAge);
            visitAnimalPanel.Dock = DockStyle.Fill;
            visitAnimalPanel.FlowDirection = FlowDirection.TopDown;
            visitAnimalPanel.Location = new Point(3, 45);
            visitAnimalPanel.Name = "visitAnimalPanel";
            visitAnimalPanel.Size = new Size(199, 113);
            visitAnimalPanel.TabIndex = 1;
            // 
            // visitAnimalName
            // 
            visitAnimalName.AutoSize = true;
            visitAnimalName.Font = new Font("Arial", 10F, FontStyle.Bold);
            visitAnimalName.Location = new Point(3, 0);
            visitAnimalName.Name = "visitAnimalName";
            visitAnimalName.Size = new Size(36, 16);
            visitAnimalName.TabIndex = 0;
            visitAnimalName.Text = "Imie";
            // 
            // visitAnimalType
            // 
            visitAnimalType.AutoSize = true;
            visitAnimalType.Location = new Point(3, 16);
            visitAnimalType.Name = "visitAnimalType";
            visitAnimalType.Size = new Size(25, 15);
            visitAnimalType.TabIndex = 2;
            visitAnimalType.Text = "Typ";
            // 
            // visitAnimalSpecies
            // 
            visitAnimalSpecies.AutoSize = true;
            visitAnimalSpecies.Location = new Point(3, 31);
            visitAnimalSpecies.Name = "visitAnimalSpecies";
            visitAnimalSpecies.Size = new Size(53, 15);
            visitAnimalSpecies.TabIndex = 1;
            visitAnimalSpecies.Text = "Gatunek";
            // 
            // visitAnimalAge
            // 
            visitAnimalAge.AutoSize = true;
            visitAnimalAge.Location = new Point(3, 46);
            visitAnimalAge.Name = "visitAnimalAge";
            visitAnimalAge.Size = new Size(34, 15);
            visitAnimalAge.TabIndex = 3;
            visitAnimalAge.Text = "Wiek";
            // 
            // visitDataPlaceholder
            // 
            visitMainTableLayout.SetColumnSpan(visitDataPlaceholder, 2);
            visitDataPlaceholder.Controls.Add(visitDataPanel);
            visitDataPlaceholder.Dock = DockStyle.Fill;
            visitDataPlaceholder.Location = new Point(208, 45);
            visitDataPlaceholder.Name = "visitDataPlaceholder";
            visitDataPlaceholder.Size = new Size(367, 113);
            visitDataPlaceholder.TabIndex = 11;
            // 
            // visitDataPanel
            // 
            visitDataPanel.Controls.Add(visitDateLabel);
            visitDataPanel.Controls.Add(visitPlaceLabel);
            visitDataPanel.Controls.Add(visitDescription);
            visitDataPanel.Dock = DockStyle.Fill;
            visitDataPanel.FlowDirection = FlowDirection.TopDown;
            visitDataPanel.Location = new Point(0, 0);
            visitDataPanel.Name = "visitDataPanel";
            visitDataPanel.Size = new Size(367, 113);
            visitDataPanel.TabIndex = 2;
            // 
            // visitDateLabel
            // 
            visitDateLabel.AutoSize = true;
            visitDateLabel.Font = new Font("Arial", 10F, FontStyle.Bold);
            visitDateLabel.Location = new Point(3, 0);
            visitDateLabel.Name = "visitDateLabel";
            visitDateLabel.Size = new Size(38, 16);
            visitDateLabel.TabIndex = 0;
            visitDateLabel.Text = "Data";
            // 
            // visitPlaceLabel
            // 
            visitPlaceLabel.AutoSize = true;
            visitPlaceLabel.Font = new Font("Arial", 9F, FontStyle.Italic, GraphicsUnit.Point, 238);
            visitPlaceLabel.Location = new Point(3, 16);
            visitPlaceLabel.Name = "visitPlaceLabel";
            visitPlaceLabel.Size = new Size(31, 15);
            visitPlaceLabel.TabIndex = 1;
            visitPlaceLabel.Text = "Tryb";
            // 
            // visitDescription
            // 
            visitDescription.AutoSize = true;
            visitDescription.Location = new Point(3, 31);
            visitDescription.Name = "visitDescription";
            visitDescription.Size = new Size(33, 15);
            visitDescription.TabIndex = 2;
            visitDescription.Text = "Opis";
            // 
            // visitEditButton
            // 
            visitEditButton.Anchor = AnchorStyles.None;
            visitEditButton.BackColor = Color.FromArgb(219, 211, 216);
            visitEditButton.FlatStyle = FlatStyle.Flat;
            visitEditButton.Location = new Point(444, 163);
            visitEditButton.Margin = new Padding(3, 2, 3, 2);
            visitEditButton.Name = "visitEditButton";
            visitEditButton.Size = new Size(88, 35);
            visitEditButton.TabIndex = 10;
            visitEditButton.Text = "Edytuj";
            visitEditButton.UseVisualStyleBackColor = false;
            // 
            // visitDeleteButton
            // 
            visitDeleteButton.Anchor = AnchorStyles.None;
            visitDeleteButton.BackColor = Color.Salmon;
            visitDeleteButton.FlatStyle = FlatStyle.Flat;
            visitDeleteButton.Location = new Point(258, 163);
            visitDeleteButton.Margin = new Padding(3, 2, 3, 2);
            visitDeleteButton.Name = "visitDeleteButton";
            visitDeleteButton.Size = new Size(88, 35);
            visitDeleteButton.TabIndex = 12;
            visitDeleteButton.Text = "Usuń";
            visitDeleteButton.UseVisualStyleBackColor = false;
            // 
            // VisitView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(visitMainTableLayout);
            Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Name = "VisitView";
            Size = new Size(800, 600);
            visitMainTableLayout.ResumeLayout(false);
            visitMainTableLayout.PerformLayout();
            visitDoctorPanel.ResumeLayout(false);
            visitDoctorPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)visitDataGrid).EndInit();
            visitAnimalPanel.ResumeLayout(false);
            visitAnimalPanel.PerformLayout();
            visitDataPlaceholder.ResumeLayout(false);
            visitDataPanel.ResumeLayout(false);
            visitDataPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel visitMainTableLayout;
        private DataGridView visitDataGrid;
        private FlowLayoutPanel visitAnimalPanel;
        private FlowLayoutPanel visitDoctorPanel;
        private Button visitEditButton;
        private Label visitDoctorLabel;
        private Label visitAnimalLabel;
        private Panel visitDataPlaceholder;
        private FlowLayoutPanel visitDataPanel;
        private Label visitDataLabel;
        private Label visitAnimalName;
        private Label visitAnimalSpecies;
        private Label visitAnimalType;
        private Label visitAnimalAge;
        private Label visitDoctorName;
        private Label visitDoctorSpecialization;
        private Label visitDateLabel;
        private Label visitPlaceLabel;
        private Label visitDescription;
        private Button visitDeleteButton;
    }
}
