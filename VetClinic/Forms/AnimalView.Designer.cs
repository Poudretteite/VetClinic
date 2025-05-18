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
            animalList = new ListBox();
            mainTableLayout.SuspendLayout();
            SuspendLayout();
            // 
            // mainTableLayout
            // 
            mainTableLayout.ColumnCount = 3;
            mainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            mainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            mainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            mainTableLayout.Controls.Add(animalList, 0, 0);
            mainTableLayout.Dock = DockStyle.Fill;
            mainTableLayout.Location = new Point(0, 0);
            mainTableLayout.Name = "mainTableLayout";
            mainTableLayout.RowCount = 3;
            mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            mainTableLayout.Size = new Size(800, 600);
            mainTableLayout.TabIndex = 1;
            // 
            // animalList
            // 
            animalList.Dock = DockStyle.Fill;
            animalList.FormattingEnabled = true;
            animalList.Location = new Point(3, 3);
            animalList.Name = "animalList";
            mainTableLayout.SetRowSpan(animalList, 3);
            animalList.Size = new Size(260, 594);
            animalList.TabIndex = 1;
            // 
            // AnimalView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(mainTableLayout);
            Name = "AnimalView";
            Size = new Size(800, 600);
            mainTableLayout.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel mainTableLayout;
        private ListBox animalList;
    }
}
