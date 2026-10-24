namespace Arcana.Forms
{
    partial class ReportsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblSubtitle = new Label();
            lblTitle = new Label();
            dtpStart = new DateTimePicker();
            dtpEnd = new DateTimePicker();
            btnGenerate = new Button();
            panel1 = new Panel();
            label3 = new Label();
            lblTotalBrewed = new Label();
            label1 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            lblTotalConsumed = new Label();
            label2 = new Label();
            dgvPopularPotions = new DataGridView();
            colPotionName = new DataGridViewTextBoxColumn();
            colBrewCount = new DataGridViewTextBoxColumn();
            dgvIngredientUsage = new DataGridView();
            colIngredientName = new DataGridViewTextBoxColumn();
            colQuantityUsed = new DataGridViewTextBoxColumn();
            colUnit = new DataGridViewTextBoxColumn();
            label5 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPopularPotions).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvIngredientUsage).BeginInit();
            SuspendLayout();
            // 
            // lblSubtitle
            // 
            lblSubtitle.ForeColor = Color.FromArgb(185, 179, 206);
            lblSubtitle.Location = new Point(21, 84);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(660, 28);
            lblSubtitle.TabIndex = 6;
            lblSubtitle.Text = "Track your workshop's production and ingredient usage";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(246, 240, 255);
            lblTitle.Location = new Point(21, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(377, 60);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "Alchemy Reports";
            // 
            // dtpStart
            // 
            dtpStart.CustomFormat = "MMM dd, yyyy";
            dtpStart.Format = DateTimePickerFormat.Custom;
            dtpStart.Location = new Point(21, 160);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(300, 34);
            dtpStart.TabIndex = 7;
            // 
            // dtpEnd
            // 
            dtpEnd.CustomFormat = "MMM dd, yyyy";
            dtpEnd.Format = DateTimePickerFormat.Custom;
            dtpEnd.Location = new Point(344, 160);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.Size = new Size(300, 34);
            dtpEnd.TabIndex = 8;
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(675, 160);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(112, 34);
            btnGenerate.TabIndex = 9;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(41, 38, 60);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lblTotalBrewed);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(21, 227);
            panel1.Name = "panel1";
            panel1.Size = new Size(377, 150);
            panel1.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(185, 179, 206);
            label3.Location = new Point(20, 107);
            label3.Name = "label3";
            label3.Size = new Size(185, 28);
            label3.TabIndex = 7;
            label3.Text = "Selected date range";
            // 
            // lblTotalBrewed
            // 
            lblTotalBrewed.AutoSize = true;
            lblTotalBrewed.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            lblTotalBrewed.ForeColor = Color.FromArgb(167, 139, 250);
            lblTotalBrewed.Location = new Point(20, 46);
            lblTotalBrewed.Name = "lblTotalBrewed";
            lblTotalBrewed.Size = new Size(60, 70);
            lblTotalBrewed.TabIndex = 6;
            lblTotalBrewed.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(185, 179, 206);
            label1.Location = new Point(20, 15);
            label1.Name = "label1";
            label1.Size = new Size(233, 28);
            label1.TabIndex = 5;
            label1.Text = "TOTAL POTIONS BREWED";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(41, 38, 60);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(lblTotalConsumed);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(424, 227);
            panel2.Name = "panel2";
            panel2.Size = new Size(363, 150);
            panel2.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(185, 179, 206);
            label4.Location = new Point(20, 107);
            label4.Name = "label4";
            label4.Size = new Size(190, 28);
            label4.TabIndex = 8;
            label4.Text = "From selected brews";
            // 
            // lblTotalConsumed
            // 
            lblTotalConsumed.AutoSize = true;
            lblTotalConsumed.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            lblTotalConsumed.ForeColor = Color.FromArgb(167, 139, 250);
            lblTotalConsumed.Location = new Point(20, 46);
            lblTotalConsumed.Name = "lblTotalConsumed";
            lblTotalConsumed.Size = new Size(60, 70);
            lblTotalConsumed.TabIndex = 7;
            lblTotalConsumed.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(185, 179, 206);
            label2.Location = new Point(20, 15);
            label2.Name = "label2";
            label2.Size = new Size(206, 28);
            label2.TabIndex = 6;
            label2.Text = "POTIONS CONSUMED";
            // 
            // dgvPopularPotions
            // 
            dgvPopularPotions.AllowUserToAddRows = false;
            dgvPopularPotions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPopularPotions.BackgroundColor = Color.FromArgb(41, 38, 60);
            dgvPopularPotions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPopularPotions.Columns.AddRange(new DataGridViewColumn[] { colPotionName, colBrewCount });
            dgvPopularPotions.Location = new Point(21, 429);
            dgvPopularPotions.Name = "dgvPopularPotions";
            dgvPopularPotions.ReadOnly = true;
            dgvPopularPotions.RowHeadersVisible = false;
            dgvPopularPotions.RowHeadersWidth = 62;
            dgvPopularPotions.Size = new Size(766, 175);
            dgvPopularPotions.TabIndex = 12;
            // 
            // colPotionName
            // 
            colPotionName.DataPropertyName = "PotionName";
            colPotionName.HeaderText = "Potion";
            colPotionName.MinimumWidth = 8;
            colPotionName.Name = "colPotionName";
            colPotionName.ReadOnly = true;
            // 
            // colBrewCount
            // 
            colBrewCount.DataPropertyName = "BrewCount";
            colBrewCount.HeaderText = "Times Brewed";
            colBrewCount.MinimumWidth = 8;
            colBrewCount.Name = "colBrewCount";
            colBrewCount.ReadOnly = true;
            // 
            // dgvIngredientUsage
            // 
            dgvIngredientUsage.AllowUserToAddRows = false;
            dgvIngredientUsage.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvIngredientUsage.BackgroundColor = Color.FromArgb(41, 38, 60);
            dgvIngredientUsage.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIngredientUsage.Columns.AddRange(new DataGridViewColumn[] { colIngredientName, colQuantityUsed, colUnit });
            dgvIngredientUsage.Location = new Point(21, 658);
            dgvIngredientUsage.Name = "dgvIngredientUsage";
            dgvIngredientUsage.ReadOnly = true;
            dgvIngredientUsage.RowHeadersVisible = false;
            dgvIngredientUsage.RowHeadersWidth = 62;
            dgvIngredientUsage.Size = new Size(766, 180);
            dgvIngredientUsage.TabIndex = 13;
            // 
            // colIngredientName
            // 
            colIngredientName.DataPropertyName = "IngredientName";
            colIngredientName.HeaderText = "Ingredient";
            colIngredientName.MinimumWidth = 8;
            colIngredientName.Name = "colIngredientName";
            colIngredientName.ReadOnly = true;
            // 
            // colQuantityUsed
            // 
            colQuantityUsed.DataPropertyName = "QuantityUsed";
            colQuantityUsed.HeaderText = "Quantity Used";
            colQuantityUsed.MinimumWidth = 8;
            colQuantityUsed.Name = "colQuantityUsed";
            colQuantityUsed.ReadOnly = true;
            // 
            // colUnit
            // 
            colUnit.DataPropertyName = "Unit";
            colUnit.HeaderText = "Unit";
            colUnit.MinimumWidth = 8;
            colUnit.Name = "colUnit";
            colUnit.ReadOnly = true;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(246, 240, 255);
            label5.Location = new Point(21, 387);
            label5.Name = "label5";
            label5.Size = new Size(385, 39);
            label5.TabIndex = 14;
            label5.Text = "Most Brewed Potions";
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(246, 240, 255);
            label6.Location = new Point(21, 616);
            label6.Name = "label6";
            label6.Size = new Size(385, 39);
            label6.TabIndex = 15;
            label6.Text = "Most Consumed Ingredients";
            // 
            // ReportsForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(25, 24, 39);
            ClientSize = new Size(900, 850);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(dgvIngredientUsage);
            Controls.Add(dgvPopularPotions);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnGenerate);
            Controls.Add(dtpEnd);
            Controls.Add(dtpStart);
            Controls.Add(lblSubtitle);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ReportsForm";
            Text = "ReportsForm";
            Load += ReportsForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPopularPotions).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvIngredientUsage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSubtitle;
        private Label lblTitle;
        private DateTimePicker dtpStart;
        private DateTimePicker dtpEnd;
        private Button btnGenerate;
        private Panel panel1;
        private Panel panel2;
        private DataGridView dgvPopularPotions;
        private DataGridView dgvIngredientUsage;
        private Label label1;
        private Label label2;
        private Label lblTotalBrewed;
        private Label lblTotalConsumed;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DataGridViewTextBoxColumn colPotionName;
        private DataGridViewTextBoxColumn colBrewCount;
        private DataGridViewTextBoxColumn colIngredientName;
        private DataGridViewTextBoxColumn colQuantityUsed;
        private DataGridViewTextBoxColumn colUnit;
    }
}