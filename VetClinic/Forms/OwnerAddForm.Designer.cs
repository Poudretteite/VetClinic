namespace VetClinic.Forms
{
    partial class OwnerAddForm
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
            ownerAddMainLayout = new FlowLayoutPanel();
            ownerNameTextBox = new TextBox();
            ownerSurnameTextBox = new TextBox();
            ownerBirthDayPicker = new DateTimePicker();
            ownerEmailTextbox = new TextBox();
            ownerPhoneTextBox = new TextBox();
            acceptButton = new Button();
            cancelButton = new Button();
            ownerAddMainLayout.SuspendLayout();
            SuspendLayout();
            // 
            // ownerAddMainLayout
            // 
            ownerAddMainLayout.Controls.Add(ownerNameTextBox);
            ownerAddMainLayout.Controls.Add(ownerSurnameTextBox);
            ownerAddMainLayout.Controls.Add(ownerBirthDayPicker);
            ownerAddMainLayout.Controls.Add(ownerEmailTextbox);
            ownerAddMainLayout.Controls.Add(ownerPhoneTextBox);
            ownerAddMainLayout.Controls.Add(acceptButton);
            ownerAddMainLayout.Controls.Add(cancelButton);
            ownerAddMainLayout.Dock = DockStyle.Fill;
            ownerAddMainLayout.FlowDirection = FlowDirection.TopDown;
            ownerAddMainLayout.Location = new Point(0, 0);
            ownerAddMainLayout.Name = "ownerAddMainLayout";
            ownerAddMainLayout.Size = new Size(219, 207);
            ownerAddMainLayout.TabIndex = 0;
            // 
            // ownerNameTextBox
            // 
            ownerNameTextBox.Location = new Point(3, 3);
            ownerNameTextBox.Name = "ownerNameTextBox";
            ownerNameTextBox.PlaceholderText = "Podaj imię...";
            ownerNameTextBox.Size = new Size(200, 23);
            ownerNameTextBox.TabIndex = 5;
            // 
            // ownerSurnameTextBox
            // 
            ownerSurnameTextBox.Location = new Point(3, 32);
            ownerSurnameTextBox.Name = "ownerSurnameTextBox";
            ownerSurnameTextBox.PlaceholderText = "Podaj nazwisko...";
            ownerSurnameTextBox.Size = new Size(200, 23);
            ownerSurnameTextBox.TabIndex = 6;
            // 
            // ownerBirthDayPicker
            // 
            ownerBirthDayPicker.Location = new Point(3, 61);
            ownerBirthDayPicker.MaxDate = new DateTime(2007, 12, 31, 0, 0, 0, 0);
            ownerBirthDayPicker.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            ownerBirthDayPicker.Name = "ownerBirthDayPicker";
            ownerBirthDayPicker.Size = new Size(200, 23);
            ownerBirthDayPicker.TabIndex = 7;
            ownerBirthDayPicker.Value = new DateTime(2007, 12, 31, 0, 0, 0, 0);
            // 
            // ownerEmailTextbox
            // 
            ownerEmailTextbox.Location = new Point(3, 90);
            ownerEmailTextbox.Name = "ownerEmailTextbox";
            ownerEmailTextbox.PlaceholderText = "Podaj email...";
            ownerEmailTextbox.Size = new Size(200, 23);
            ownerEmailTextbox.TabIndex = 8;
            // 
            // ownerPhoneTextBox
            // 
            ownerPhoneTextBox.Location = new Point(3, 119);
            ownerPhoneTextBox.Name = "ownerPhoneTextBox";
            ownerPhoneTextBox.PlaceholderText = "Podaj numer telefonu...";
            ownerPhoneTextBox.Size = new Size(200, 23);
            ownerPhoneTextBox.TabIndex = 9;
            // 
            // acceptButton
            // 
            acceptButton.Location = new Point(3, 147);
            acceptButton.Margin = new Padding(3, 2, 3, 2);
            acceptButton.Name = "acceptButton";
            acceptButton.Size = new Size(82, 22);
            acceptButton.TabIndex = 10;
            acceptButton.Text = "Zatwierdź";
            acceptButton.UseVisualStyleBackColor = true;
            acceptButton.Click += acceptButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(3, 173);
            cancelButton.Margin = new Padding(3, 2, 3, 2);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(82, 22);
            cancelButton.TabIndex = 11;
            cancelButton.Text = "Anuluj";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // OwnerAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ownerAddMainLayout);
            Name = "OwnerAddForm";
            Size = new Size(219, 207);
            ownerAddMainLayout.ResumeLayout(false);
            ownerAddMainLayout.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel ownerAddMainLayout;
        private TextBox ownerNameTextBox;
        private TextBox ownerSurnameTextBox;
        private DateTimePicker ownerBirthDayPicker;
        private TextBox ownerEmailTextbox;
        private TextBox ownerPhoneTextBox;
        private Button acceptButton;
        private Button cancelButton;
    }
}
