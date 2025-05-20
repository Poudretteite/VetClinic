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
            typBox = new ComboBox();
            gatunekBox = new ComboBox();
            ownerSearchBox = new TextBox();
            acceptButton = new Button();
            FormLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // FormLayoutPanel
            // 
            FormLayoutPanel.Controls.Add(NameBox);
            FormLayoutPanel.Controls.Add(typBox);
            FormLayoutPanel.Controls.Add(gatunekBox);
            FormLayoutPanel.Controls.Add(ownerSearchBox);
            FormLayoutPanel.Controls.Add(acceptButton);
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
            // typBox
            // 
            typBox.FormattingEnabled = true;
            typBox.Location = new Point(3, 36);
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
            gatunekBox.Location = new Point(3, 70);
            gatunekBox.Name = "gatunekBox";
            gatunekBox.Size = new Size(216, 28);
            gatunekBox.TabIndex = 2;
            gatunekBox.Text = "Gatunek";
            gatunekBox.SelectedIndexChanged += gatunekBox_SelectedIndexChanged;
            // 
            // ownerSearchBox
            // 
            ownerSearchBox.Location = new Point(3, 104);
            ownerSearchBox.Name = "ownerSearchBox";
            ownerSearchBox.PlaceholderText = "Wyszukaj właściciela...";
            ownerSearchBox.Size = new Size(216, 27);
            ownerSearchBox.TabIndex = 3;
            ownerSearchBox.TextChanged += ownerSearchBox_TextChanged;
            // 
            // acceptButton
            // 
            acceptButton.Location = new Point(3, 137);
            acceptButton.Name = "acceptButton";
            acceptButton.Size = new Size(94, 29);
            acceptButton.TabIndex = 4;
            acceptButton.Text = "Zatwierdź";
            acceptButton.UseVisualStyleBackColor = true;
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
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel FormLayoutPanel;
        private TextBox NameBox;
        private ComboBox typBox;
        private ComboBox gatunekBox;
        private TextBox ownerSearchBox;
        private Button acceptButton;
    }
}
