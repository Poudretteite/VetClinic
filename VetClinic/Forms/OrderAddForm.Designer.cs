namespace VetClinic.Forms
{
    partial class OrderAddForm
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
            orderAddMainLayout = new FlowLayoutPanel();
            medAmountPickerLabel = new Label();
            medAmountPicker = new NumericUpDown();
            acceptButton = new Button();
            cancelButton = new Button();
            orderAddMainLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)medAmountPicker).BeginInit();
            SuspendLayout();
            // 
            // orderAddMainLayout
            // 
            orderAddMainLayout.Controls.Add(medAmountPickerLabel);
            orderAddMainLayout.Controls.Add(medAmountPicker);
            orderAddMainLayout.Controls.Add(acceptButton);
            orderAddMainLayout.Controls.Add(cancelButton);
            orderAddMainLayout.Dock = DockStyle.Fill;
            orderAddMainLayout.FlowDirection = FlowDirection.TopDown;
            orderAddMainLayout.Location = new Point(0, 0);
            orderAddMainLayout.Name = "orderAddMainLayout";
            orderAddMainLayout.Size = new Size(180, 110);
            orderAddMainLayout.TabIndex = 0;
            // 
            // medAmountPickerLabel
            // 
            medAmountPickerLabel.AutoSize = true;
            medAmountPickerLabel.Location = new Point(3, 0);
            medAmountPickerLabel.Name = "medAmountPickerLabel";
            medAmountPickerLabel.Size = new Size(34, 15);
            medAmountPickerLabel.TabIndex = 3;
            medAmountPickerLabel.Text = "Ilość:";
            // 
            // medAmountPicker
            // 
            medAmountPicker.Location = new Point(3, 18);
            medAmountPicker.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            medAmountPicker.Name = "medAmountPicker";
            medAmountPicker.Size = new Size(71, 23);
            medAmountPicker.TabIndex = 4;
            medAmountPicker.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // acceptButton
            // 
            acceptButton.Location = new Point(3, 46);
            acceptButton.Margin = new Padding(3, 2, 3, 2);
            acceptButton.Name = "acceptButton";
            acceptButton.Size = new Size(82, 22);
            acceptButton.TabIndex = 8;
            acceptButton.Text = "Zatwierdź";
            acceptButton.UseVisualStyleBackColor = true;
            acceptButton.Click += acceptButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(3, 72);
            cancelButton.Margin = new Padding(3, 2, 3, 2);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(82, 22);
            cancelButton.TabIndex = 9;
            cancelButton.Text = "Anuluj";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // OrderAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(orderAddMainLayout);
            Name = "OrderAddForm";
            Size = new Size(180, 110);
            orderAddMainLayout.ResumeLayout(false);
            orderAddMainLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)medAmountPicker).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel orderAddMainLayout;
        private Label medAmountPickerLabel;
        private NumericUpDown medAmountPicker;
        private Button acceptButton;
        private Button cancelButton;
    }
}
