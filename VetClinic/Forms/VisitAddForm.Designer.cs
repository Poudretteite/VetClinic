namespace VetClinic.Forms
{
    partial class VisitAddForm
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
            visitFormLayout = new FlowLayoutPanel();
            visitDoctorChoice = new ComboBox();
            visitDatePicker = new DateTimePicker();
            visitDescription = new Label();
            visitDescriptionBox = new TextBox();
            acceptButton = new Button();
            cancelButton = new Button();
            visitFormLayout.SuspendLayout();
            SuspendLayout();
            // 
            // visitFormLayout
            // 
            visitFormLayout.Controls.Add(visitDoctorChoice);
            visitFormLayout.Controls.Add(visitDatePicker);
            visitFormLayout.Controls.Add(visitDescription);
            visitFormLayout.Controls.Add(visitDescriptionBox);
            visitFormLayout.Controls.Add(acceptButton);
            visitFormLayout.Controls.Add(cancelButton);
            visitFormLayout.Dock = DockStyle.Fill;
            visitFormLayout.FlowDirection = FlowDirection.TopDown;
            visitFormLayout.Location = new Point(0, 0);
            visitFormLayout.Name = "visitFormLayout";
            visitFormLayout.Size = new Size(304, 170);
            visitFormLayout.TabIndex = 0;
            // 
            // visitDoctorChoice
            // 
            visitDoctorChoice.FormattingEnabled = true;
            visitDoctorChoice.Location = new Point(3, 3);
            visitDoctorChoice.Name = "visitDoctorChoice";
            visitDoctorChoice.Size = new Size(200, 23);
            visitDoctorChoice.TabIndex = 0;
            // 
            // visitDatePicker
            // 
            visitDatePicker.Location = new Point(3, 32);
            visitDatePicker.MaxDate = new DateTime(2025, 12, 31, 0, 0, 0, 0);
            visitDatePicker.MinDate = new DateTime(2025, 5, 23, 0, 0, 0, 0);
            visitDatePicker.Name = "visitDatePicker";
            visitDatePicker.Size = new Size(200, 23);
            visitDatePicker.TabIndex = 2;
            visitDatePicker.Value = new DateTime(2025, 5, 23, 0, 0, 0, 0);
            // 
            // visitDescription
            // 
            visitDescription.AutoSize = true;
            visitDescription.Location = new Point(3, 58);
            visitDescription.Name = "visitDescription";
            visitDescription.Size = new Size(31, 15);
            visitDescription.TabIndex = 3;
            visitDescription.Text = "Opis";
            // 
            // visitDescriptionBox
            // 
            visitDescriptionBox.Location = new Point(3, 76);
            visitDescriptionBox.Name = "visitDescriptionBox";
            visitDescriptionBox.Size = new Size(200, 23);
            visitDescriptionBox.TabIndex = 13;
            // 
            // acceptButton
            // 
            acceptButton.Location = new Point(3, 104);
            acceptButton.Margin = new Padding(3, 2, 3, 2);
            acceptButton.Name = "acceptButton";
            acceptButton.Size = new Size(82, 22);
            acceptButton.TabIndex = 11;
            acceptButton.Text = "Zatwierdź";
            acceptButton.UseVisualStyleBackColor = true;
            acceptButton.Click += acceptButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(3, 130);
            cancelButton.Margin = new Padding(3, 2, 3, 2);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(82, 22);
            cancelButton.TabIndex = 12;
            cancelButton.Text = "Anuluj";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // VisitAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(visitFormLayout);
            Name = "VisitAddForm";
            Size = new Size(304, 170);
            visitFormLayout.ResumeLayout(false);
            visitFormLayout.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel visitFormLayout;
        private ComboBox visitDoctorChoice;
        private DateTimePicker visitDatePicker;
        private Label visitDescription;
        private Button acceptButton;
        private Button cancelButton;
        private TextBox visitDescriptionBox;
    }
}
