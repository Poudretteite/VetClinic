namespace VetClinic
{
    partial class AnimalView
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
            animalAddVisitButtton = new Button();
            animalTabControl = new TabControl();
            animalVisitDataGrid = new DataGridView();
            searchBox = new TextBox();
            animalEditButton = new Button();
            animalDataForm = new Panel();
            animalDataLayout = new FlowLayoutPanel();
            animalNameLabel = new Label();
            animalTypeLabel = new Label();
            animalSpeciesLabel = new Label();
            animalAge = new Label();
            animalOwnerDataLabel = new Label();
            animalOwnerNameLabel = new Label();
            animalOwnerLink = new LinkLabel();
            animalAddButton = new Button();
            animalDeleteButton = new Button();
            mainTableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)animalVisitDataGrid).BeginInit();
            animalDataForm.SuspendLayout();
            animalDataLayout.SuspendLayout();
            SuspendLayout();
            // 
            // mainTableLayout
            // 
            mainTableLayout.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainTableLayout.ColumnCount = 5;
            mainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            mainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            mainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            mainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            mainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            mainTableLayout.Controls.Add(animalAddVisitButtton, 3, 0);
            mainTableLayout.Controls.Add(animalTabControl, 0, 1);
            mainTableLayout.Controls.Add(animalVisitDataGrid, 1, 2);
            mainTableLayout.Controls.Add(searchBox, 0, 0);
            mainTableLayout.Controls.Add(animalEditButton, 1, 0);
            mainTableLayout.Controls.Add(animalDataForm, 1, 1);
            mainTableLayout.Controls.Add(animalAddButton, 2, 0);
            mainTableLayout.Controls.Add(animalDeleteButton, 4, 0);
            mainTableLayout.Font = new Font("Arial", 9F);
            mainTableLayout.Location = new Point(0, 0);
            mainTableLayout.Name = "mainTableLayout";
            mainTableLayout.RowCount = 4;
            mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 7.894737F));
            mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 33.4476852F));
            mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 19.0394516F));
            mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 39.4736862F));
            mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            mainTableLayout.Size = new Size(800, 600);
            mainTableLayout.TabIndex = 1;
            // 
            // animalAddVisitButtton
            // 
            animalAddVisitButtton.Anchor = AnchorStyles.None;
            animalAddVisitButtton.BackColor = Color.FromArgb(34, 56, 67);
            animalAddVisitButtton.FlatStyle = FlatStyle.Flat;
            animalAddVisitButtton.ForeColor = Color.White;
            animalAddVisitButtton.Location = new Point(606, 4);
            animalAddVisitButtton.Margin = new Padding(3, 2, 3, 2);
            animalAddVisitButtton.Name = "animalAddVisitButtton";
            animalAddVisitButtton.Size = new Size(88, 38);
            animalAddVisitButtton.TabIndex = 15;
            animalAddVisitButtton.Text = "Wizyta";
            animalAddVisitButtton.UseVisualStyleBackColor = false;
            animalAddVisitButtton.Click += animalAddVisitButtton_Click;
            // 
            // animalTabControl
            // 
            animalTabControl.Dock = DockStyle.Fill;
            animalTabControl.Location = new Point(3, 48);
            animalTabControl.Margin = new Padding(3, 2, 3, 2);
            animalTabControl.Name = "animalTabControl";
            mainTableLayout.SetRowSpan(animalTabControl, 3);
            animalTabControl.SelectedIndex = 0;
            animalTabControl.Size = new Size(394, 533);
            animalTabControl.TabIndex = 2;
            // 
            // animalVisitDataGrid
            // 
            animalVisitDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            mainTableLayout.SetColumnSpan(animalVisitDataGrid, 4);
            animalVisitDataGrid.Dock = DockStyle.Fill;
            animalVisitDataGrid.Location = new Point(403, 243);
            animalVisitDataGrid.Margin = new Padding(3, 2, 3, 2);
            animalVisitDataGrid.Name = "animalVisitDataGrid";
            animalVisitDataGrid.RowHeadersWidth = 51;
            mainTableLayout.SetRowSpan(animalVisitDataGrid, 3);
            animalVisitDataGrid.Size = new Size(394, 355);
            animalVisitDataGrid.TabIndex = 3;
            // 
            // searchBox
            // 
            searchBox.Dock = DockStyle.Top;
            searchBox.Location = new Point(3, 2);
            searchBox.Margin = new Padding(3, 2, 3, 2);
            searchBox.Name = "searchBox";
            searchBox.PlaceholderText = "Wyszukaj zwierze po imieniu lub gatunku...";
            searchBox.Size = new Size(394, 21);
            searchBox.TabIndex = 5;
            searchBox.TextChanged += searchBox_TextChanged;
            // 
            // animalEditButton
            // 
            animalEditButton.Anchor = AnchorStyles.None;
            animalEditButton.BackColor = Color.FromArgb(219, 211, 216);
            animalEditButton.FlatStyle = FlatStyle.Flat;
            animalEditButton.Location = new Point(406, 4);
            animalEditButton.Margin = new Padding(3, 2, 3, 2);
            animalEditButton.Name = "animalEditButton";
            animalEditButton.Size = new Size(88, 38);
            animalEditButton.TabIndex = 7;
            animalEditButton.Text = "Edytuj";
            animalEditButton.UseVisualStyleBackColor = false;
            animalEditButton.Click += animalEditButton_Click;
            // 
            // animalDataForm
            // 
            mainTableLayout.SetColumnSpan(animalDataForm, 4);
            animalDataForm.Controls.Add(animalDataLayout);
            animalDataForm.Dock = DockStyle.Fill;
            animalDataForm.Location = new Point(403, 48);
            animalDataForm.Margin = new Padding(3, 2, 3, 2);
            animalDataForm.Name = "animalDataForm";
            animalDataForm.Size = new Size(394, 191);
            animalDataForm.TabIndex = 9;
            // 
            // animalDataLayout
            // 
            animalDataLayout.AutoScroll = true;
            animalDataLayout.AutoScrollMinSize = new Size(0, 180);
            animalDataLayout.Controls.Add(animalNameLabel);
            animalDataLayout.Controls.Add(animalTypeLabel);
            animalDataLayout.Controls.Add(animalSpeciesLabel);
            animalDataLayout.Controls.Add(animalAge);
            animalDataLayout.Controls.Add(animalOwnerDataLabel);
            animalDataLayout.Controls.Add(animalOwnerNameLabel);
            animalDataLayout.Controls.Add(animalOwnerLink);
            animalDataLayout.Dock = DockStyle.Fill;
            animalDataLayout.FlowDirection = FlowDirection.TopDown;
            animalDataLayout.Location = new Point(0, 0);
            animalDataLayout.Margin = new Padding(3, 2, 3, 2);
            animalDataLayout.Name = "animalDataLayout";
            animalDataLayout.Size = new Size(394, 191);
            animalDataLayout.TabIndex = 4;
            // 
            // animalNameLabel
            // 
            animalNameLabel.AutoSize = true;
            animalNameLabel.Dock = DockStyle.Fill;
            animalNameLabel.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            animalNameLabel.ForeColor = Color.FromArgb(215, 122, 97);
            animalNameLabel.Location = new Point(3, 0);
            animalNameLabel.Name = "animalNameLabel";
            animalNameLabel.Size = new Size(139, 27);
            animalNameLabel.TabIndex = 4;
            animalNameLabel.Text = "Imie";
            animalNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // animalTypeLabel
            // 
            animalTypeLabel.AutoSize = true;
            animalTypeLabel.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            animalTypeLabel.ForeColor = Color.FromArgb(216, 180, 160);
            animalTypeLabel.Location = new Point(9, 27);
            animalTypeLabel.Margin = new Padding(9, 0, 3, 0);
            animalTypeLabel.Name = "animalTypeLabel";
            animalTypeLabel.Size = new Size(25, 16);
            animalTypeLabel.TabIndex = 5;
            animalTypeLabel.Text = "Typ";
            // 
            // animalSpeciesLabel
            // 
            animalSpeciesLabel.AutoSize = true;
            animalSpeciesLabel.Location = new Point(3, 45);
            animalSpeciesLabel.Margin = new Padding(3, 2, 3, 2);
            animalSpeciesLabel.Name = "animalSpeciesLabel";
            animalSpeciesLabel.Size = new Size(53, 15);
            animalSpeciesLabel.TabIndex = 6;
            animalSpeciesLabel.Text = "Gatunek";
            // 
            // animalAge
            // 
            animalAge.AutoSize = true;
            animalAge.Location = new Point(3, 62);
            animalAge.Name = "animalAge";
            animalAge.Size = new Size(34, 15);
            animalAge.TabIndex = 10;
            animalAge.Text = "Wiek";
            // 
            // animalOwnerDataLabel
            // 
            animalOwnerDataLabel.AutoSize = true;
            animalOwnerDataLabel.Dock = DockStyle.Fill;
            animalOwnerDataLabel.Font = new Font("Arial Black", 10.25F, FontStyle.Bold);
            animalOwnerDataLabel.ForeColor = Color.FromArgb(215, 122, 97);
            animalOwnerDataLabel.Location = new Point(3, 92);
            animalOwnerDataLabel.Margin = new Padding(3, 15, 3, 0);
            animalOwnerDataLabel.Name = "animalOwnerDataLabel";
            animalOwnerDataLabel.Size = new Size(139, 19);
            animalOwnerDataLabel.TabIndex = 7;
            animalOwnerDataLabel.Text = "Właściciel";
            animalOwnerDataLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // animalOwnerNameLabel
            // 
            animalOwnerNameLabel.AutoSize = true;
            animalOwnerNameLabel.Location = new Point(3, 111);
            animalOwnerNameLabel.Name = "animalOwnerNameLabel";
            animalOwnerNameLabel.Size = new Size(85, 15);
            animalOwnerNameLabel.TabIndex = 8;
            animalOwnerNameLabel.Text = "imie nazwisko";
            // 
            // animalOwnerLink
            // 
            animalOwnerLink.ActiveLinkColor = Color.FromArgb(215, 122, 97);
            animalOwnerLink.AutoSize = true;
            animalOwnerLink.LinkColor = Color.FromArgb(215, 122, 97);
            animalOwnerLink.Location = new Point(3, 126);
            animalOwnerLink.Name = "animalOwnerLink";
            animalOwnerLink.Size = new Size(139, 15);
            animalOwnerLink.TabIndex = 9;
            animalOwnerLink.TabStop = true;
            animalOwnerLink.Text = "Informacje o właścicielu";
            animalOwnerLink.VisitedLinkColor = Color.FromArgb(215, 122, 97);
            animalOwnerLink.LinkClicked += animalOwnerLink_LinkClicked;
            // 
            // animalAddButton
            // 
            animalAddButton.Anchor = AnchorStyles.None;
            animalAddButton.BackColor = Color.FromArgb(219, 211, 216);
            animalAddButton.FlatStyle = FlatStyle.Flat;
            animalAddButton.Location = new Point(506, 4);
            animalAddButton.Margin = new Padding(3, 2, 3, 2);
            animalAddButton.Name = "animalAddButton";
            animalAddButton.Size = new Size(88, 38);
            animalAddButton.TabIndex = 8;
            animalAddButton.Text = "Dodaj";
            animalAddButton.UseVisualStyleBackColor = false;
            animalAddButton.Click += animalAddButton_Click;
            // 
            // animalDeleteButton
            // 
            animalDeleteButton.Anchor = AnchorStyles.None;
            animalDeleteButton.BackColor = Color.Salmon;
            animalDeleteButton.FlatStyle = FlatStyle.Flat;
            animalDeleteButton.Location = new Point(706, 4);
            animalDeleteButton.Margin = new Padding(3, 2, 3, 2);
            animalDeleteButton.Name = "animalDeleteButton";
            animalDeleteButton.Size = new Size(88, 38);
            animalDeleteButton.TabIndex = 6;
            animalDeleteButton.Text = "Usuń";
            animalDeleteButton.UseVisualStyleBackColor = false;
            animalDeleteButton.Click += animalDeleteButton_Click;
            // 
            // AnimalView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(mainTableLayout);
            Name = "AnimalView";
            Size = new Size(800, 600);
            mainTableLayout.ResumeLayout(false);
            mainTableLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)animalVisitDataGrid).EndInit();
            animalDataForm.ResumeLayout(false);
            animalDataLayout.ResumeLayout(false);
            animalDataLayout.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel mainTableLayout;
        private DataGridView animalVisitDataGrid;
        private TabControl animalTabControl;
        private FlowLayoutPanel animalDataLayout;
        private Label animalNameLabel;
        private Label animalTypeLabel;
        private Label animalSpeciesLabel;
        private Label animalOwnerDataLabel;
        private Label animalOwnerNameLabel;
        private LinkLabel animalOwnerLink;
        private TextBox searchBox;
        private Button animalDeleteButton;
        private Button animalEditButton;
        private Button animalAddButton;
        private Panel animalDataForm;
        private Label animalAge;
        private Button animalAddVisitButtton;
    }
}
