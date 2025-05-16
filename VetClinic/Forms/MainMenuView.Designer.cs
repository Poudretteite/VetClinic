namespace VetClinic
{
    partial class MainMenuView
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
            leftTableLayout = new TableLayoutPanel();
            buttonFlowLayout = new FlowLayoutPanel();
            visitButton = new Button();
            animalButton = new Button();
            ownerButton = new Button();
            vetButton = new Button();
            orderButton = new Button();
            medButton = new Button();
            addVisitButton = new Button();
            rightTableLayout = new TableLayoutPanel();
            VisitScheduleGrid = new DataGridView();
            mainTableLayout.SuspendLayout();
            leftTableLayout.SuspendLayout();
            buttonFlowLayout.SuspendLayout();
            rightTableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)VisitScheduleGrid).BeginInit();
            SuspendLayout();
            // 
            // mainTableLayout
            // 
            mainTableLayout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mainTableLayout.ColumnCount = 2;
            mainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            mainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainTableLayout.Controls.Add(leftTableLayout, 0, 0);
            mainTableLayout.Controls.Add(rightTableLayout, 1, 0);
            mainTableLayout.Dock = DockStyle.Fill;
            mainTableLayout.Location = new Point(0, 0);
            mainTableLayout.Margin = new Padding(0);
            mainTableLayout.Name = "mainTableLayout";
            mainTableLayout.RowCount = 1;
            mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainTableLayout.Size = new Size(800, 600);
            mainTableLayout.TabIndex = 0;
            // 
            // leftTableLayout
            // 
            leftTableLayout.BackColor = Color.FromArgb(34, 56, 67);
            leftTableLayout.ColumnCount = 1;
            leftTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            leftTableLayout.Controls.Add(buttonFlowLayout, 0, 2);
            leftTableLayout.Controls.Add(addVisitButton, 0, 1);
            leftTableLayout.Dock = DockStyle.Fill;
            leftTableLayout.Location = new Point(0, 0);
            leftTableLayout.Margin = new Padding(0);
            leftTableLayout.Name = "leftTableLayout";
            leftTableLayout.RowCount = 4;
            leftTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            leftTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            leftTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            leftTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            leftTableLayout.Size = new Size(200, 600);
            leftTableLayout.TabIndex = 0;
            // 
            // buttonFlowLayout
            // 
            buttonFlowLayout.Controls.Add(visitButton);
            buttonFlowLayout.Controls.Add(animalButton);
            buttonFlowLayout.Controls.Add(ownerButton);
            buttonFlowLayout.Controls.Add(vetButton);
            buttonFlowLayout.Controls.Add(orderButton);
            buttonFlowLayout.Controls.Add(medButton);
            buttonFlowLayout.Dock = DockStyle.Fill;
            buttonFlowLayout.Location = new Point(0, 120);
            buttonFlowLayout.Margin = new Padding(0);
            buttonFlowLayout.Name = "buttonFlowLayout";
            buttonFlowLayout.Size = new Size(200, 420);
            buttonFlowLayout.TabIndex = 1;
            // 
            // visitButton
            // 
            visitButton.FlatAppearance.BorderSize = 0;
            visitButton.FlatStyle = FlatStyle.Flat;
            visitButton.Font = new Font("Arial", 12F);
            visitButton.ForeColor = Color.White;
            visitButton.Location = new Point(0, 0);
            visitButton.Margin = new Padding(0);
            visitButton.Name = "visitButton";
            visitButton.Padding = new Padding(15, 0, 0, 0);
            visitButton.Size = new Size(200, 50);
            visitButton.TabIndex = 1;
            visitButton.Text = "Wizyty";
            visitButton.TextAlign = ContentAlignment.MiddleLeft;
            visitButton.UseVisualStyleBackColor = true;
            // 
            // animalButton
            // 
            animalButton.FlatAppearance.BorderSize = 0;
            animalButton.FlatStyle = FlatStyle.Flat;
            animalButton.Font = new Font("Arial", 12F);
            animalButton.ForeColor = Color.White;
            animalButton.Location = new Point(0, 50);
            animalButton.Margin = new Padding(0);
            animalButton.Name = "animalButton";
            animalButton.Padding = new Padding(15, 0, 0, 0);
            animalButton.Size = new Size(194, 44);
            animalButton.TabIndex = 2;
            animalButton.Text = "Zwierzęta";
            animalButton.TextAlign = ContentAlignment.MiddleLeft;
            animalButton.UseVisualStyleBackColor = true;
            // 
            // ownerButton
            // 
            ownerButton.FlatAppearance.BorderSize = 0;
            ownerButton.FlatStyle = FlatStyle.Flat;
            ownerButton.Font = new Font("Arial", 12F);
            ownerButton.ForeColor = Color.White;
            ownerButton.Location = new Point(0, 94);
            ownerButton.Margin = new Padding(0);
            ownerButton.Name = "ownerButton";
            ownerButton.Padding = new Padding(15, 0, 0, 0);
            ownerButton.Size = new Size(194, 44);
            ownerButton.TabIndex = 3;
            ownerButton.Text = "Właściciele";
            ownerButton.TextAlign = ContentAlignment.MiddleLeft;
            ownerButton.UseVisualStyleBackColor = true;
            // 
            // vetButton
            // 
            vetButton.FlatAppearance.BorderSize = 0;
            vetButton.FlatStyle = FlatStyle.Flat;
            vetButton.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            vetButton.ForeColor = Color.White;
            vetButton.Location = new Point(0, 138);
            vetButton.Margin = new Padding(0);
            vetButton.Name = "vetButton";
            vetButton.Padding = new Padding(15, 0, 0, 0);
            vetButton.Size = new Size(194, 44);
            vetButton.TabIndex = 4;
            vetButton.Text = "Lekarze";
            vetButton.TextAlign = ContentAlignment.MiddleLeft;
            vetButton.UseVisualStyleBackColor = true;
            // 
            // orderButton
            // 
            orderButton.FlatAppearance.BorderSize = 0;
            orderButton.FlatStyle = FlatStyle.Flat;
            orderButton.Font = new Font("Arial", 12F);
            orderButton.ForeColor = Color.White;
            orderButton.Location = new Point(0, 182);
            orderButton.Margin = new Padding(0);
            orderButton.Name = "orderButton";
            orderButton.Padding = new Padding(15, 0, 0, 0);
            orderButton.Size = new Size(194, 44);
            orderButton.TabIndex = 5;
            orderButton.Text = "Zamówienia";
            orderButton.TextAlign = ContentAlignment.MiddleLeft;
            orderButton.UseVisualStyleBackColor = true;
            // 
            // medButton
            // 
            medButton.FlatAppearance.BorderSize = 0;
            medButton.FlatStyle = FlatStyle.Flat;
            medButton.Font = new Font("Arial", 12F);
            medButton.ForeColor = Color.White;
            medButton.Location = new Point(0, 226);
            medButton.Margin = new Padding(0);
            medButton.Name = "medButton";
            medButton.Padding = new Padding(15, 0, 0, 0);
            medButton.Size = new Size(194, 44);
            medButton.TabIndex = 6;
            medButton.Text = "Leki";
            medButton.TextAlign = ContentAlignment.MiddleLeft;
            medButton.UseVisualStyleBackColor = true;
            // 
            // addVisitButton
            // 
            addVisitButton.BackColor = Color.FromArgb(34, 56, 67);
            addVisitButton.Cursor = Cursors.Hand;
            addVisitButton.Dock = DockStyle.Fill;
            addVisitButton.FlatAppearance.BorderSize = 0;
            addVisitButton.FlatStyle = FlatStyle.Flat;
            addVisitButton.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            addVisitButton.ForeColor = Color.White;
            addVisitButton.Location = new Point(0, 60);
            addVisitButton.Margin = new Padding(0);
            addVisitButton.Name = "addVisitButton";
            addVisitButton.Size = new Size(200, 60);
            addVisitButton.TabIndex = 0;
            addVisitButton.Text = "Dodaj wizytę";
            addVisitButton.TextAlign = ContentAlignment.MiddleLeft;
            addVisitButton.UseVisualStyleBackColor = false;
            // 
            // rightTableLayout
            // 
            rightTableLayout.ColumnCount = 3;
            rightTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            rightTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            rightTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            rightTableLayout.Controls.Add(VisitScheduleGrid, 1, 1);
            rightTableLayout.Dock = DockStyle.Fill;
            rightTableLayout.Location = new Point(203, 3);
            rightTableLayout.Name = "rightTableLayout";
            rightTableLayout.RowCount = 3;
            rightTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            rightTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            rightTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            rightTableLayout.Size = new Size(594, 594);
            rightTableLayout.TabIndex = 1;
            // 
            // VisitScheduleGrid
            // 
            VisitScheduleGrid.AllowUserToAddRows = false;
            VisitScheduleGrid.AllowUserToDeleteRows = false;
            VisitScheduleGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            VisitScheduleGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            VisitScheduleGrid.Dock = DockStyle.Fill;
            VisitScheduleGrid.Location = new Point(62, 121);
            VisitScheduleGrid.Name = "VisitScheduleGrid";
            VisitScheduleGrid.ReadOnly = true;
            VisitScheduleGrid.RowHeadersVisible = false;
            VisitScheduleGrid.Size = new Size(409, 409);
            VisitScheduleGrid.TabIndex = 0;
            // 
            // MainMenuView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(mainTableLayout);
            Margin = new Padding(0);
            Name = "MainMenuView";
            Size = new Size(800, 600);
            mainTableLayout.ResumeLayout(false);
            leftTableLayout.ResumeLayout(false);
            buttonFlowLayout.ResumeLayout(false);
            rightTableLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)VisitScheduleGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel mainTableLayout;
        private TableLayoutPanel leftTableLayout;
        private Button visitButton;
        private Button animalButton;
        private Button ownerButton;
        private Button vetButton;
        private Button orderButton;
        private Button medButton;
        private Button addVisitButton;
        private FlowLayoutPanel buttonFlowLayout;
        private TableLayoutPanel rightTableLayout;
        private DataGridView VisitScheduleGrid;
    }
}
