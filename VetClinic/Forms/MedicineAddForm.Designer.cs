namespace VetClinic.Forms
{
    partial class MedicineAddForm
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            medNameTextBox = new TextBox();
            medAmountPickerLabel = new Label();
            medAmountPicker = new NumericUpDown();
            acceptButton = new Button();
            cancelButton = new Button();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)medAmountPicker).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(medNameTextBox);
            flowLayoutPanel1.Controls.Add(medAmountPickerLabel);
            flowLayoutPanel1.Controls.Add(medAmountPicker);
            flowLayoutPanel1.Controls.Add(acceptButton);
            flowLayoutPanel1.Controls.Add(cancelButton);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(266, 135);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // medNameTextBox
            // 
            medNameTextBox.Location = new Point(3, 3);
            medNameTextBox.Name = "medNameTextBox";
            medNameTextBox.PlaceholderText = "Podaj nazwę leku...";
            medNameTextBox.Size = new Size(171, 21);
            medNameTextBox.TabIndex = 0;
            // 
            // medAmountPickerLabel
            // 
            medAmountPickerLabel.AutoSize = true;
            medAmountPickerLabel.Location = new Point(3, 27);
            medAmountPickerLabel.Name = "medAmountPickerLabel";
            medAmountPickerLabel.Size = new Size(36, 15);
            medAmountPickerLabel.TabIndex = 1;
            medAmountPickerLabel.Text = "Ilość:";
            // 
            // medAmountPicker
            // 
            medAmountPicker.Location = new Point(3, 45);
            medAmountPicker.Name = "medAmountPicker";
            medAmountPicker.Size = new Size(71, 21);
            medAmountPicker.TabIndex = 2;
            // 
            // acceptButton
            // 
            acceptButton.Location = new Point(3, 71);
            acceptButton.Margin = new Padding(3, 2, 3, 2);
            acceptButton.Name = "acceptButton";
            acceptButton.Size = new Size(82, 22);
            acceptButton.TabIndex = 8;
            acceptButton.Text = "Zatwierdź";
            acceptButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(3, 97);
            cancelButton.Margin = new Padding(3, 2, 3, 2);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(82, 22);
            cancelButton.TabIndex = 9;
            cancelButton.Text = "Anuluj";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // MedicineAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flowLayoutPanel1);
            Name = "MedicineAddForm";
            Size = new Size(266, 135);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)medAmountPicker).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox medNameTextBox;
        private Label medAmountPickerLabel;
        private NumericUpDown medAmountPicker;
        private Button acceptButton;
        private Button cancelButton;
    }
}
