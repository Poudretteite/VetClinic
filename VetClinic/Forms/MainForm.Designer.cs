namespace VetClinic
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            leftTableLayout = new TableLayoutPanel();
            buttonFlowLayout = new FlowLayoutPanel();
            visitButton = new Button();
            animalButton = new Button();
            ownerButton = new Button();
            vetButton = new Button();
            orderButton = new Button();
            medButton = new Button();
            MainPageButton = new Button();
            viewPanel = new Panel();
            tableLayoutPanel1.SuspendLayout();
            leftTableLayout.SuspendLayout();
            buttonFlowLayout.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(leftTableLayout, 0, 0);
            tableLayoutPanel1.Controls.Add(viewPanel, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(884, 661);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // leftTableLayout
            // 
            leftTableLayout.BackColor = Color.FromArgb(34, 56, 67);
            leftTableLayout.ColumnCount = 1;
            leftTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            leftTableLayout.Controls.Add(buttonFlowLayout, 0, 2);
            leftTableLayout.Controls.Add(MainPageButton, 0, 1);
            leftTableLayout.Dock = DockStyle.Fill;
            leftTableLayout.Location = new Point(0, 0);
            leftTableLayout.Margin = new Padding(0);
            leftTableLayout.Name = "leftTableLayout";
            leftTableLayout.RowCount = 4;
            leftTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            leftTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            leftTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            leftTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            leftTableLayout.Size = new Size(200, 661);
            leftTableLayout.TabIndex = 1;
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
            buttonFlowLayout.Location = new Point(0, 132);
            buttonFlowLayout.Margin = new Padding(0);
            buttonFlowLayout.Name = "buttonFlowLayout";
            buttonFlowLayout.Size = new Size(200, 462);
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
            visitButton.Click += visitButton_Click;
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
            animalButton.Click += animalButton_Click;
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
            ownerButton.Click += ownerButton_Click;
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
            vetButton.Click += vetButton_Click;
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
            orderButton.Click += orderButton_Click;
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
            medButton.Click += medButton_Click;
            // 
            // MainPageButton
            // 
            MainPageButton.BackColor = Color.FromArgb(34, 56, 67);
            MainPageButton.Cursor = Cursors.Hand;
            MainPageButton.Dock = DockStyle.Fill;
            MainPageButton.FlatAppearance.BorderSize = 0;
            MainPageButton.FlatStyle = FlatStyle.Flat;
            MainPageButton.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            MainPageButton.ForeColor = Color.White;
            MainPageButton.Location = new Point(0, 66);
            MainPageButton.Margin = new Padding(0);
            MainPageButton.Name = "MainPageButton";
            MainPageButton.Size = new Size(200, 66);
            MainPageButton.TabIndex = 0;
            MainPageButton.Text = "Strona główna";
            MainPageButton.TextAlign = ContentAlignment.MiddleLeft;
            MainPageButton.UseVisualStyleBackColor = false;
            MainPageButton.Click += MainPageButton_Click;
            // 
            // viewPanel
            // 
            viewPanel.Dock = DockStyle.Fill;
            viewPanel.Location = new Point(203, 3);
            viewPanel.Name = "viewPanel";
            viewPanel.Size = new Size(678, 655);
            viewPanel.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 661);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(600, 700);
            Name = "MainForm";
            Text = "Klinika Weterynaryjna";
            tableLayoutPanel1.ResumeLayout(false);
            leftTableLayout.ResumeLayout(false);
            buttonFlowLayout.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel leftTableLayout;
        private FlowLayoutPanel buttonFlowLayout;
        private Button visitButton;
        private Button animalButton;
        private Button ownerButton;
        private Button vetButton;
        private Button orderButton;
        private Button medButton;
        private Button MainPageButton;
        private Panel viewPanel;
    }
}
