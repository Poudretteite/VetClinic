namespace VetClinic.Forms
{
    partial class AnimalAddForm
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
            FormLayoutPanel = new FlowLayoutPanel();
            NameBox = new TextBox();
            ownerSearchBox = new TextBox();
            typBox = new ComboBox();
            gatunekBox = new ComboBox();
            ageLabel = new Label();
            ageBox = new NumericUpDown();
            acceptButton = new Button();
            cancelButton = new Button();
            FormLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ageBox).BeginInit();
            SuspendLayout();
            // 
            // FormLayoutPanel
            // 
            FormLayoutPanel.Controls.Add(NameBox);
            FormLayoutPanel.Controls.Add(ownerSearchBox);
            FormLayoutPanel.Controls.Add(typBox);
            FormLayoutPanel.Controls.Add(gatunekBox);
            FormLayoutPanel.Controls.Add(ageLabel);
            FormLayoutPanel.Controls.Add(ageBox);
            FormLayoutPanel.Controls.Add(acceptButton);
            FormLayoutPanel.Controls.Add(cancelButton);
            FormLayoutPanel.Dock = DockStyle.Fill;
            FormLayoutPanel.FlowDirection = FlowDirection.TopDown;
            FormLayoutPanel.Location = new Point(0, 0);
            FormLayoutPanel.Name = "FormLayoutPanel";
            FormLayoutPanel.Size = new Size(519, 256);
            FormLayoutPanel.TabIndex = 0;
            // 
            // NameBox
            // 
            NameBox.Location = new Point(3, 3);
            NameBox.Name = "NameBox";
            NameBox.PlaceholderText = "Wpisz imię zwierzęcia...";
            NameBox.Size = new Size(216, 27);
            NameBox.TabIndex = 0;
            // 
            // ownerSearchBox
            // 
            ownerSearchBox.Location = new Point(3, 36);
            ownerSearchBox.Name = "ownerSearchBox";
            ownerSearchBox.PlaceholderText = "Wyszukaj właściciela...";
            ownerSearchBox.Size = new Size(216, 27);
            ownerSearchBox.TabIndex = 3;
            ownerSearchBox.TextChanged += ownerSearchBox_TextChanged;
            // 
            // typBox
            // 
            typBox.FormattingEnabled = true;
            typBox.Location = new Point(3, 69);
            typBox.Name = "typBox";
            typBox.Size = new Size(216, 28);
            typBox.TabIndex = 1;
            typBox.Text = "Typ zwierzęcia";
            typBox.SelectedIndexChanged += LoadToGatunekBox;
            // 
            // gatunekBox
            // 
            gatunekBox.Enabled = false;
            gatunekBox.FormattingEnabled = true;
            gatunekBox.Location = new Point(3, 103);
            gatunekBox.Name = "gatunekBox";
            gatunekBox.Size = new Size(216, 28);
            gatunekBox.TabIndex = 2;
            gatunekBox.Text = "Gatunek";
            gatunekBox.SelectedIndexChanged += gatunekBox_SelectedIndexChanged;
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Location = new Point(3, 134);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new Size(45, 20);
            ageLabel.TabIndex = 6;
            ageLabel.Text = "Wiek:";
            // 
            // ageBox
            // 
            ageBox.Location = new Point(3, 157);
            ageBox.Name = "ageBox";
            ageBox.Size = new Size(150, 27);
            ageBox.TabIndex = 5;
            // 
            // acceptButton
            // 
            acceptButton.Location = new Point(3, 190);
            acceptButton.Name = "acceptButton";
            acceptButton.Size = new Size(94, 29);
            acceptButton.TabIndex = 4;
            acceptButton.Text = "Zatwierdź";
            acceptButton.UseVisualStyleBackColor = true;
            acceptButton.Click += acceptButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(225, 3);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(94, 29);
            cancelButton.TabIndex = 7;
            cancelButton.Text = "Anuluj";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // AnimalAddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(FormLayoutPanel);
            Name = "AnimalAddForm";
            Size = new Size(519, 256);
            FormLayoutPanel.ResumeLayout(false);
            FormLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ageBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel FormLayoutPanel;
        private TextBox NameBox;
        private ComboBox typBox;
        private ComboBox gatunekBox;
        private TextBox ownerSearchBox;
        private Button acceptButton;
        private Label ageLabel;
        private NumericUpDown ageBox;
        private Button cancelButton;
    }
}
