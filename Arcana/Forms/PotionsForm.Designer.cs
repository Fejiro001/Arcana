namespace Arcana.Forms
{
    partial class PotionsForm
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
            dgvPotions = new DataGridView();
            colPotionName = new DataGridViewTextBoxColumn();
            colElement = new DataGridViewTextBoxColumn();
            colEffect = new DataGridViewTextBoxColumn();
            colBrewedAt = new DataGridViewTextBoxColumn();
            colPotionStatus = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            btnDelete = new Button();
            btnConsume = new Button();
            lblSelectedEffect = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPotions).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblSubtitle
            // 
            lblSubtitle.ForeColor = Color.FromArgb(185, 179, 206);
            lblSubtitle.Location = new Point(31, 84);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(660, 28);
            lblSubtitle.TabIndex = 6;
            lblSubtitle.Text = "Your collection of brewed magical elixirs";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(246, 240, 255);
            lblTitle.Location = new Point(22, 17);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(259, 60);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "My Potions";
            // 
            // dgvPotions
            // 
            dgvPotions.AllowUserToAddRows = false;
            dgvPotions.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvPotions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPotions.BackgroundColor = Color.FromArgb(41, 38, 60);
            dgvPotions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPotions.Columns.AddRange(new DataGridViewColumn[] { colPotionName, colElement, colEffect, colBrewedAt, colPotionStatus });
            dgvPotions.Location = new Point(31, 125);
            dgvPotions.MultiSelect = false;
            dgvPotions.Name = "dgvPotions";
            dgvPotions.ReadOnly = true;
            dgvPotions.RowHeadersVisible = false;
            dgvPotions.RowHeadersWidth = 62;
            dgvPotions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPotions.Size = new Size(982, 252);
            dgvPotions.TabIndex = 7;
            dgvPotions.SelectionChanged += dgvPotions_SelectionChanged;
            // 
            // colPotionName
            // 
            colPotionName.DataPropertyName = "Name";
            colPotionName.HeaderText = "Potion";
            colPotionName.MinimumWidth = 8;
            colPotionName.Name = "colPotionName";
            colPotionName.ReadOnly = true;
            // 
            // colElement
            // 
            colElement.DataPropertyName = "Element";
            colElement.HeaderText = "Element";
            colElement.MinimumWidth = 8;
            colElement.Name = "colElement";
            colElement.ReadOnly = true;
            // 
            // colEffect
            // 
            colEffect.DataPropertyName = "Effect";
            colEffect.HeaderText = "Effect";
            colEffect.MinimumWidth = 8;
            colEffect.Name = "colEffect";
            colEffect.ReadOnly = true;
            // 
            // colBrewedAt
            // 
            colBrewedAt.DataPropertyName = "BrewedAt";
            colBrewedAt.HeaderText = "Brewed At";
            colBrewedAt.MinimumWidth = 8;
            colBrewedAt.Name = "colBrewedAt";
            colBrewedAt.ReadOnly = true;
            // 
            // colPotionStatus
            // 
            colPotionStatus.DataPropertyName = "Status";
            colPotionStatus.HeaderText = "Status";
            colPotionStatus.MinimumWidth = 8;
            colPotionStatus.Name = "colPotionStatus";
            colPotionStatus.ReadOnly = true;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(41, 38, 60);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnConsume);
            panel1.Controls.Add(lblSelectedEffect);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(31, 407);
            panel1.Name = "panel1";
            panel1.Size = new Size(982, 245);
            panel1.TabIndex = 8;
            // 
            // btnDelete
            // 
            btnDelete.AutoSize = true;
            btnDelete.BackColor = Color.FromArgb(73, 48, 68);
            btnDelete.Enabled = false;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(223, 165);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(161, 56);
            btnDelete.TabIndex = 25;
            btnDelete.Text = "Delete Potion";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnConsume
            // 
            btnConsume.AutoSize = true;
            btnConsume.BackColor = Color.FromArgb(128, 90, 202);
            btnConsume.Enabled = false;
            btnConsume.FlatAppearance.BorderSize = 0;
            btnConsume.FlatStyle = FlatStyle.Flat;
            btnConsume.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnConsume.ForeColor = Color.White;
            btnConsume.Location = new Point(22, 165);
            btnConsume.Name = "btnConsume";
            btnConsume.Size = new Size(190, 56);
            btnConsume.TabIndex = 24;
            btnConsume.Text = "Consume Potion";
            btnConsume.UseVisualStyleBackColor = false;
            btnConsume.Click += btnConsume_Click;
            // 
            // lblSelectedEffect
            // 
            lblSelectedEffect.AutoSize = true;
            lblSelectedEffect.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSelectedEffect.ForeColor = Color.FromArgb(185, 179, 206);
            lblSelectedEffect.Location = new Point(22, 111);
            lblSelectedEffect.Name = "lblSelectedEffect";
            lblSelectedEffect.Size = new Size(293, 28);
            lblSelectedEffect.TabIndex = 23;
            lblSelectedEffect.Text = "Select a potion to view its effect.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(196, 167, 255);
            label3.Location = new Point(22, 67);
            label3.Name = "label3";
            label3.Size = new Size(127, 28);
            label3.TabIndex = 22;
            label3.Text = "Special Effect";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(246, 240, 255);
            label4.Location = new Point(22, 17);
            label4.Name = "label4";
            label4.Size = new Size(385, 39);
            label4.TabIndex = 21;
            label4.Text = "Potion Details";
            // 
            // PotionsForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 24, 39);
            ClientSize = new Size(1045, 684);
            Controls.Add(panel1);
            Controls.Add(dgvPotions);
            Controls.Add(lblSubtitle);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PotionsForm";
            Text = "PotionsForm";
            Load += PotionsForm_Load;
            Shown += PotionsForm_Shown;
            ((System.ComponentModel.ISupportInitialize)dgvPotions).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSubtitle;
        private Label lblTitle;
        private DataGridView dgvPotions;
        private Panel panel1;
        private Label label4;
        private Label label3;
        private Label lblSelectedEffect;
        private Button btnDelete;
        private Button btnConsume;
        private DataGridViewTextBoxColumn colPotionName;
        private DataGridViewTextBoxColumn colElement;
        private DataGridViewTextBoxColumn colEffect;
        private DataGridViewTextBoxColumn colBrewedAt;
        private DataGridViewTextBoxColumn colPotionStatus;
    }
}