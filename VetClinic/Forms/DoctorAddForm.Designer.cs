namespace VetClinic.Forms
{
    partial class DoctorAddForm
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
            doctorFormLayoutPanel = new FlowLayoutPanel();
            doctorNameTextBox = new TextBox();
            doctorSurnameTextBox = new TextBox();
            doctorBirthDayPicker = new DateTimePicker();
            doctorEmailTextbox = new TextBox();
            doctorPhoneTextBox = new TextBox();
            doctorSpecializationChoiceLabel = new Label();
            doctorSpecializationChoice = new ComboBox();
            doctorWorkPlaceChoiceLabel = new Label();
            doctorWorkPlaceChoice = new ComboBox();
            acceptButton = new Button();
            cancelButton = new Button();
            doctorFormLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // doctorFormLayoutPanel
            // 
            doctorFormLayoutPanel.Controls.Add(doctorNameTextBox);
            doctorFormLayoutPanel.Controls.Add(doctorSurnameTextBox);
            doctorFormLayoutPanel.Controls.Add(doctorBirthDayPicker);
            doctorFormLayoutPanel.Controls.Add(doctorEmailTextbox);
            doctorFormLayoutPanel.Controls.Add(doctorPhoneTextBox);
            doctorFormLayoutPanel.Controls.Add(doctorSpecializationChoiceLabel);
            doctorFormLayoutPanel.Controls.Add(doctorSpecializationChoice);
            doctorFormLayoutPanel.Controls.Add(doctorWorkPlaceChoiceLabel);
            doctorFormLayoutPanel.Controls.Add(doctorWorkPlaceChoice);
            doctorFormLayoutPanel.Controls.Add(acceptButton);
            doctorFormLayoutPanel.Controls.Add(cancelButton);
            doctorFormLayoutPanel.Dock = DockStyle.Fill;
            doctorFormLayoutPanel.FlowDirection = FlowDirection.TopDown;
            doctorFormLayoutPanel.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            doctorFormLayoutPanel.Location = new Point(0, 0);
            doctorFormLayoutPanel.Name = "doctorFormLayoutPanel";
            doctorFormLayoutPanel.Size = new Size(249, 297);
            doctorFormLayoutPanel.TabIndex = 0;
            // 
            // doctorNameTextBox
            // 
            doctorNameTextBox.Location = new Point(3, 3);
            doctorNameTextBox.Name = "doctorNameTextBox";
            doctorNameTextBox.PlaceholderText = "Podaj imię...";
            doctorNameTextBox.Size = new Size(200, 21);
            doctorNameTextBox.TabIndex = 0;
            // 
            // doctorSurnameTextBox
            // 
            doctorSurnameTextBox.Location = new Point(3, 30);
            doctorSurnameTextBox.Name = "doctorSurnameTextBox";
            doctorSurnameTextBox.PlaceholderText = "Podaj nazwisko...";
            doctorSurnameTextBox.Size = new Size(200, 21);
            doctorSurnameTextBox.TabIndex = 1;
            // 
            // doctorBirthDayPicker
            // 
            doctorBirthDayPicker.Location = new Point(3, 57);
            doctorBirthDayPicker.MaxDate = new DateTime(2007, 12, 31, 0, 0, 0, 0);
            doctorBirthDayPicker.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            doctorBirthDayPicker.Name = "doctorBirthDayPicker";
            doctorBirthDayPicker.Size = new Size(200, 21);
            doctorBirthDayPicker.TabIndex = 2;
            doctorBirthDayPicker.Value = new DateTime(2007, 12, 31, 0, 0, 0, 0);
            // 
            // doctorEmailTextbox
            // 
            doctorEmailTextbox.Location = new Point(3, 84);
            doctorEmailTextbox.Name = "doctorEmailTextbox";
            doctorEmailTextbox.PlaceholderText = "Podaj email...";
            doctorEmailTextbox.Size = new Size(200, 21);
            doctorEmailTextbox.TabIndex = 3;
            // 
            // doctorPhoneTextBox
            // 
            doctorPhoneTextBox.Location = new Point(3, 111);
            doctorPhoneTextBox.Name = "doctorPhoneTextBox";
            doctorPhoneTextBox.PlaceholderText = "Podaj numer telefonu...";
            doctorPhoneTextBox.Size = new Size(200, 21);
            doctorPhoneTextBox.TabIndex = 4;
            // 
            // doctorSpecializationChoiceLabel
            // 
            doctorSpecializationChoiceLabel.AutoSize = true;
            doctorSpecializationChoiceLabel.Location = new Point(3, 135);
            doctorSpecializationChoiceLabel.Name = "doctorSpecializationChoiceLabel";
            doctorSpecializationChoiceLabel.RightToLeft = RightToLeft.No;
            doctorSpecializationChoiceLabel.Size = new Size(126, 15);
            doctorSpecializationChoiceLabel.TabIndex = 7;
            doctorSpecializationChoiceLabel.Text = "Wybierz specjalizację:";
            // 
            // doctorSpecializationChoice
            // 
            doctorSpecializationChoice.FormattingEnabled = true;
            doctorSpecializationChoice.Location = new Point(3, 153);
            doctorSpecializationChoice.Name = "doctorSpecializationChoice";
            doctorSpecializationChoice.Size = new Size(200, 23);
            doctorSpecializationChoice.TabIndex = 6;
            // 
            // doctorWorkPlaceChoiceLabel
            // 
            doctorWorkPlaceChoiceLabel.AutoSize = true;
            doctorWorkPlaceChoiceLabel.Location = new Point(3, 179);
            doctorWorkPlaceChoiceLabel.Name = "doctorWorkPlaceChoiceLabel";
            doctorWorkPlaceChoiceLabel.Size = new Size(106, 15);
            doctorWorkPlaceChoiceLabel.TabIndex = 8;
            doctorWorkPlaceChoiceLabel.Text = "Wybierz tryb pracy:";
            // 
            // doctorWorkPlaceChoice
            // 
            doctorWorkPlaceChoice.FormattingEnabled = true;
            doctorWorkPlaceChoice.Location = new Point(3, 197);
            doctorWorkPlaceChoice.Name = "doctorWorkPlaceChoice";
            doctorWorkPlaceChoice.Size = new Size(200, 23);
            doctorWorkPlaceChoice.TabIndex = 5;
            // 
            // acceptButton
            // 
            acceptButton.Location = new Point(3, 225);
            acceptButton.Margin = new Padding(3, 2, 3, 2);
            acceptButton.Name = "acceptButton";
            acceptButton.Size = new Size(82, 22);
            acceptButton.TabIndex = 9;
            acceptButton.Text = "Zatwierdź";
            acceptButton.UseVisualStyleBackColor = true;
            acceptButton.Click += acceptButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(3, 251);
            cancelButton.Margin = new Padding(3, 2, 3, 2);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(82, 22);
            cancelButton.TabIndex = 10;
            cancelButton.Text = "Anuluj";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // DoctorAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(doctorFormLayoutPanel);
            Name = "DoctorAddForm";
            Size = new Size(249, 297);
            doctorFormLayoutPanel.ResumeLayout(false);
            doctorFormLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel doctorFormLayoutPanel;
        private TextBox doctorNameTextBox;
        private TextBox doctorSurnameTextBox;
        private DateTimePicker doctorBirthDayPicker;
        private TextBox doctorEmailTextbox;
        private TextBox doctorPhoneTextBox;
        private ComboBox doctorSpecializationChoice;
        private ComboBox doctorWorkPlaceChoice;
        private Label doctorSpecializationChoiceLabel;
        private Label doctorWorkPlaceChoiceLabel;
        private Button acceptButton;
        private Button cancelButton;
    }
}
