namespace VetClinic.Forms
{
    partial class OwnerView
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
            ownerMainTableLayout = new TableLayoutPanel();
            ownerSearchBox = new TextBox();
            ownerDeleteButton = new Button();
            ownerEditButton = new Button();
            ownerList = new ListBox();
            ownerAddButton = new Button();
            ownerDataPanel = new Panel();
            ownerDataFlowLayout = new FlowLayoutPanel();
            ownerNameLabel = new Label();
            ownerAge = new Label();
            birthdayLabel = new Label();
            animalCount = new Label();
            ownerContact = new Label();
            ownerPhone = new Label();
            ownerEmail = new Label();
            ownerAnimalList = new ListBox();
            ownerMainTableLayout.SuspendLayout();
            ownerDataPanel.SuspendLayout();
            ownerDataFlowLayout.SuspendLayout();
            SuspendLayout();
            // 
            // ownerMainTableLayout
            // 
            ownerMainTableLayout.ColumnCount = 5;
            ownerMainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            ownerMainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            ownerMainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            ownerMainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            ownerMainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            ownerMainTableLayout.Controls.Add(ownerSearchBox, 0, 0);
            ownerMainTableLayout.Controls.Add(ownerDeleteButton, 3, 0);
            ownerMainTableLayout.Controls.Add(ownerEditButton, 2, 0);
            ownerMainTableLayout.Controls.Add(ownerList, 0, 1);
            ownerMainTableLayout.Controls.Add(ownerAddButton, 4, 0);
            ownerMainTableLayout.Controls.Add(ownerDataPanel, 2, 1);
            ownerMainTableLayout.Controls.Add(ownerAnimalList, 2, 3);
            ownerMainTableLayout.Dock = DockStyle.Fill;
            ownerMainTableLayout.Location = new Point(0, 0);
            ownerMainTableLayout.Margin = new Padding(3, 2, 3, 2);
            ownerMainTableLayout.Name = "ownerMainTableLayout";
            ownerMainTableLayout.RowCount = 5;
            ownerMainTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            ownerMainTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            ownerMainTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            ownerMainTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            ownerMainTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            ownerMainTableLayout.Size = new Size(714, 379);
            ownerMainTableLayout.TabIndex = 0;
            // 
            // ownerSearchBox
            // 
            ownerMainTableLayout.SetColumnSpan(ownerSearchBox, 2);
            ownerSearchBox.Dock = DockStyle.Top;
            ownerSearchBox.Location = new Point(3, 2);
            ownerSearchBox.Margin = new Padding(3, 2, 3, 2);
            ownerSearchBox.Name = "ownerSearchBox";
            ownerSearchBox.PlaceholderText = "Wyszukaj po imieniu lub nazwisku...";
            ownerSearchBox.Size = new Size(278, 23);
            ownerSearchBox.TabIndex = 13;
            ownerSearchBox.TextChanged += ownerSearchBox_TextChanged;
            // 
            // ownerDeleteButton
            // 
            ownerDeleteButton.BackColor = Color.Salmon;
            ownerDeleteButton.FlatStyle = FlatStyle.Flat;
            ownerDeleteButton.Location = new Point(429, 2);
            ownerDeleteButton.Margin = new Padding(3, 2, 3, 2);
            ownerDeleteButton.Name = "ownerDeleteButton";
            ownerDeleteButton.Size = new Size(88, 33);
            ownerDeleteButton.TabIndex = 10;
            ownerDeleteButton.Text = "Usuń";
            ownerDeleteButton.UseVisualStyleBackColor = false;
            ownerDeleteButton.Click += ownerDeleteButton_Click;
            // 
            // ownerEditButton
            // 
            ownerEditButton.BackColor = Color.FromArgb(219, 211, 216);
            ownerEditButton.FlatStyle = FlatStyle.Flat;
            ownerEditButton.Location = new Point(287, 2);
            ownerEditButton.Margin = new Padding(3, 2, 3, 2);
            ownerEditButton.Name = "ownerEditButton";
            ownerEditButton.Size = new Size(88, 33);
            ownerEditButton.TabIndex = 8;
            ownerEditButton.Text = "Edytuj";
            ownerEditButton.UseVisualStyleBackColor = false;
            ownerEditButton.Click += ownerEditButton_Click;
            // 
            // ownerList
            // 
            ownerMainTableLayout.SetColumnSpan(ownerList, 2);
            ownerList.Dock = DockStyle.Fill;
            ownerList.FormattingEnabled = true;
            ownerList.Location = new Point(3, 39);
            ownerList.Margin = new Padding(3, 2, 3, 2);
            ownerList.Name = "ownerList";
            ownerMainTableLayout.SetRowSpan(ownerList, 4);
            ownerList.Size = new Size(278, 338);
            ownerList.TabIndex = 0;
            ownerList.SelectedIndexChanged += ownerList_SelectedIndexChanged;
            // 
            // ownerAddButton
            // 
            ownerAddButton.BackColor = Color.FromArgb(219, 211, 216);
            ownerAddButton.FlatStyle = FlatStyle.Flat;
            ownerAddButton.Location = new Point(571, 2);
            ownerAddButton.Margin = new Padding(3, 2, 3, 2);
            ownerAddButton.Name = "ownerAddButton";
            ownerAddButton.Size = new Size(88, 33);
            ownerAddButton.TabIndex = 9;
            ownerAddButton.Text = "Dodaj";
            ownerAddButton.UseVisualStyleBackColor = false;
            ownerAddButton.Click += ownerAddButton_Click;
            // 
            // ownerDataPanel
            // 
            ownerMainTableLayout.SetColumnSpan(ownerDataPanel, 3);
            ownerDataPanel.Controls.Add(ownerDataFlowLayout);
            ownerDataPanel.Dock = DockStyle.Fill;
            ownerDataPanel.Location = new Point(287, 39);
            ownerDataPanel.Margin = new Padding(3, 2, 3, 2);
            ownerDataPanel.Name = "ownerDataPanel";
            ownerMainTableLayout.SetRowSpan(ownerDataPanel, 2);
            ownerDataPanel.Size = new Size(424, 184);
            ownerDataPanel.TabIndex = 11;
            // 
            // ownerDataFlowLayout
            // 
            ownerDataFlowLayout.Controls.Add(ownerNameLabel);
            ownerDataFlowLayout.Controls.Add(ownerAge);
            ownerDataFlowLayout.Controls.Add(birthdayLabel);
            ownerDataFlowLayout.Controls.Add(animalCount);
            ownerDataFlowLayout.Controls.Add(ownerContact);
            ownerDataFlowLayout.Controls.Add(ownerPhone);
            ownerDataFlowLayout.Controls.Add(ownerEmail);
            ownerDataFlowLayout.Dock = DockStyle.Top;
            ownerDataFlowLayout.FlowDirection = FlowDirection.TopDown;
            ownerDataFlowLayout.Location = new Point(0, 0);
            ownerDataFlowLayout.Margin = new Padding(3, 2, 3, 2);
            ownerDataFlowLayout.Name = "ownerDataFlowLayout";
            ownerDataFlowLayout.Size = new Size(424, 147);
            ownerDataFlowLayout.TabIndex = 0;
            // 
            // ownerNameLabel
            // 
            ownerNameLabel.AutoSize = true;
            ownerNameLabel.Dock = DockStyle.Fill;
            ownerNameLabel.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            ownerNameLabel.ForeColor = Color.FromArgb(215, 122, 97);
            ownerNameLabel.Location = new Point(3, 0);
            ownerNameLabel.Name = "ownerNameLabel";
            ownerNameLabel.Size = new Size(173, 27);
            ownerNameLabel.TabIndex = 5;
            ownerNameLabel.Text = "Imie i nazwisko";
            ownerNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ownerAge
            // 
            ownerAge.AutoSize = true;
            ownerAge.Location = new Point(3, 27);
            ownerAge.Name = "ownerAge";
            ownerAge.Size = new Size(33, 15);
            ownerAge.TabIndex = 6;
            ownerAge.Text = "Wiek";
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Location = new Point(3, 42);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new Size(86, 15);
            birthdayLabel.TabIndex = 7;
            birthdayLabel.Text = "Data urodzenia";
            // 
            // animalCount
            // 
            animalCount.AutoSize = true;
            animalCount.Location = new Point(3, 57);
            animalCount.Name = "animalCount";
            animalCount.Size = new Size(138, 15);
            animalCount.TabIndex = 8;
            animalCount.Text = "Zarejestrowane zwierzęta";
            // 
            // ownerContact
            // 
            ownerContact.AutoSize = true;
            ownerContact.Dock = DockStyle.Fill;
            ownerContact.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            ownerContact.ForeColor = Color.FromArgb(215, 122, 97);
            ownerContact.Location = new Point(3, 72);
            ownerContact.Name = "ownerContact";
            ownerContact.Size = new Size(173, 19);
            ownerContact.TabIndex = 11;
            ownerContact.Text = "Kontakt";
            ownerContact.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ownerPhone
            // 
            ownerPhone.AutoSize = true;
            ownerPhone.Location = new Point(3, 91);
            ownerPhone.Name = "ownerPhone";
            ownerPhone.Size = new Size(45, 15);
            ownerPhone.TabIndex = 10;
            ownerPhone.Text = "Telefon";
            // 
            // ownerEmail
            // 
            ownerEmail.AutoSize = true;
            ownerEmail.Location = new Point(3, 106);
            ownerEmail.Name = "ownerEmail";
            ownerEmail.Size = new Size(36, 15);
            ownerEmail.TabIndex = 9;
            ownerEmail.Text = "Email";
            // 
            // ownerAnimalList
            // 
            ownerMainTableLayout.SetColumnSpan(ownerAnimalList, 3);
            ownerAnimalList.Dock = DockStyle.Fill;
            ownerAnimalList.FormattingEnabled = true;
            ownerAnimalList.Location = new Point(287, 227);
            ownerAnimalList.Margin = new Padding(3, 2, 3, 2);
            ownerAnimalList.Name = "ownerAnimalList";
            ownerMainTableLayout.SetRowSpan(ownerAnimalList, 2);
            ownerAnimalList.Size = new Size(424, 150);
            ownerAnimalList.TabIndex = 12;
            // 
            // OwnerView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ownerMainTableLayout);
            Name = "OwnerView";
            Size = new Size(714, 379);
            ownerMainTableLayout.ResumeLayout(false);
            ownerMainTableLayout.PerformLayout();
            ownerDataPanel.ResumeLayout(false);
            ownerDataFlowLayout.ResumeLayout(false);
            ownerDataFlowLayout.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel ownerMainTableLayout;
        private ListBox ownerList;
        private Button ownerEditButton;
        private Button ownerAddButton;
        private Button ownerDeleteButton;
        private Panel ownerDataPanel;
        private ListBox ownerAnimalList;
        private FlowLayoutPanel ownerDataFlowLayout;
        private Label ownerNameLabel;
        private Label ownerAge;
        private Label birthdayLabel;
        private Label ownerEmail;
        private Label ownerPhone;
        private Label animalCount;
        private Label ownerContact;
        private TextBox ownerSearchBox;
    }
}
