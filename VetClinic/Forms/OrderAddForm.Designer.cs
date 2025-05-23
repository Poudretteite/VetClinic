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
            orderAddMainLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)medAmountPicker).BeginInit();
            SuspendLayout();
            // 
            // orderAddMainLayout
            // 
            orderAddMainLayout.Controls.Add(medAmountPickerLabel);
            orderAddMainLayout.Controls.Add(medAmountPicker);
            orderAddMainLayout.Dock = DockStyle.Fill;
            orderAddMainLayout.FlowDirection = FlowDirection.TopDown;
            orderAddMainLayout.Location = new Point(0, 0);
            orderAddMainLayout.Name = "orderAddMainLayout";
            orderAddMainLayout.Size = new Size(180, 70);
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
            medAmountPicker.Name = "medAmountPicker";
            medAmountPicker.Size = new Size(71, 23);
            medAmountPicker.TabIndex = 4;
            // 
            // OrderAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(orderAddMainLayout);
            Name = "OrderAddForm";
            Size = new Size(180, 70);
            orderAddMainLayout.ResumeLayout(false);
            orderAddMainLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)medAmountPicker).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel orderAddMainLayout;
        private Label medAmountPickerLabel;
        private NumericUpDown medAmountPicker;
    }
}
