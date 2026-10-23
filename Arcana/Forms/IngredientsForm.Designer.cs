namespace Arcana.Forms
{
    partial class IngredientsForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblTitle = new Label();
            lblSubtitle = new Label();
            txtSearch = new TextBox();
            dgvIngredients = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colStock = new DataGridViewTextBoxColumn();
            colUnit = new DataGridViewTextBoxColumn();
            colRarity = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            pnlIngredientEditor = new Panel();
            lblRarity = new Label();
            lblStock = new Label();
            lblUnit = new Label();
            lblIngredientName = new Label();
            btnClear = new Button();
            btnRetire = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            cmbRarity = new ComboBox();
            nudStock = new NumericUpDown();
            txtUnit = new TextBox();
            txtIngredientName = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvIngredients).BeginInit();
            pnlIngredientEditor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudStock).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(246, 240, 255);
            lblTitle.Location = new Point(30, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.RightToLeft = RightToLeft.No;
            lblTitle.Size = new Size(459, 60);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Ingredient Inventory";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.ForeColor = Color.FromArgb(185, 179, 206);
            lblSubtitle.Location = new Point(30, 75);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(402, 28);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Manage your magical resources and supplies";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(30, 120);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(350, 34);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // dgvIngredients
            // 
            dgvIngredients.AllowUserToAddRows = false;
            dgvIngredients.AllowUserToDeleteRows = false;
            dgvIngredients.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvIngredients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvIngredients.BackgroundColor = Color.FromArgb(41, 38, 60);
            dgvIngredients.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(55, 50, 72);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(167, 139, 250);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvIngredients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvIngredients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIngredients.Columns.AddRange(new DataGridViewColumn[] { colId, colName, colStock, colUnit, colRarity, colStatus });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(41, 38, 60);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(185, 179, 206);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvIngredients.DefaultCellStyle = dataGridViewCellStyle2;
            dgvIngredients.EnableHeadersVisualStyles = false;
            dgvIngredients.Location = new Point(30, 155);
            dgvIngredients.MultiSelect = false;
            dgvIngredients.Name = "dgvIngredients";
            dgvIngredients.ReadOnly = true;
            dgvIngredients.RowHeadersWidth = 62;
            dgvIngredients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvIngredients.Size = new Size(820, 255);
            dgvIngredients.TabIndex = 3;
            dgvIngredients.SelectionChanged += dgvIngredients_SelectionChanged;
            // 
            // colId
            // 
            colId.DataPropertyName = "Id";
            colId.HeaderText = "ID";
            colId.MinimumWidth = 8;
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Visible = false;
            // 
            // colName
            // 
            colName.DataPropertyName = "Name";
            colName.HeaderText = "Ingredient";
            colName.MinimumWidth = 8;
            colName.Name = "colName";
            colName.ReadOnly = true;
            // 
            // colStock
            // 
            colStock.DataPropertyName = "Stock";
            colStock.HeaderText = "Stock";
            colStock.MinimumWidth = 8;
            colStock.Name = "colStock";
            colStock.ReadOnly = true;
            // 
            // colUnit
            // 
            colUnit.DataPropertyName = "Unit";
            colUnit.HeaderText = "Unit";
            colUnit.MinimumWidth = 8;
            colUnit.Name = "colUnit";
            colUnit.ReadOnly = true;
            // 
            // colRarity
            // 
            colRarity.DataPropertyName = "Rarity";
            colRarity.HeaderText = "Rarity";
            colRarity.MinimumWidth = 8;
            colRarity.Name = "colRarity";
            colRarity.ReadOnly = true;
            // 
            // colStatus
            // 
            colStatus.DataPropertyName = "IsActive";
            colStatus.HeaderText = "Active";
            colStatus.MinimumWidth = 8;
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            // 
            // pnlIngredientEditor
            // 
            pnlIngredientEditor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlIngredientEditor.BackColor = Color.FromArgb(41, 38, 60);
            pnlIngredientEditor.Controls.Add(lblRarity);
            pnlIngredientEditor.Controls.Add(lblStock);
            pnlIngredientEditor.Controls.Add(lblUnit);
            pnlIngredientEditor.Controls.Add(lblIngredientName);
            pnlIngredientEditor.Controls.Add(btnClear);
            pnlIngredientEditor.Controls.Add(btnRetire);
            pnlIngredientEditor.Controls.Add(btnUpdate);
            pnlIngredientEditor.Controls.Add(btnAdd);
            pnlIngredientEditor.Controls.Add(cmbRarity);
            pnlIngredientEditor.Controls.Add(nudStock);
            pnlIngredientEditor.Controls.Add(txtUnit);
            pnlIngredientEditor.Controls.Add(txtIngredientName);
            pnlIngredientEditor.Controls.Add(label1);
            pnlIngredientEditor.Location = new Point(30, 435);
            pnlIngredientEditor.Name = "pnlIngredientEditor";
            pnlIngredientEditor.Size = new Size(820, 225);
            pnlIngredientEditor.TabIndex = 4;
            // 
            // lblRarity
            // 
            lblRarity.AutoSize = true;
            lblRarity.ForeColor = Color.FromArgb(185, 179, 206);
            lblRarity.Location = new Point(610, 50);
            lblRarity.Name = "lblRarity";
            lblRarity.Size = new Size(63, 28);
            lblRarity.TabIndex = 12;
            lblRarity.Text = "Rarity";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.ForeColor = Color.FromArgb(185, 179, 206);
            lblStock.Location = new Point(411, 50);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(60, 28);
            lblStock.TabIndex = 11;
            lblStock.Text = "Stock";
            // 
            // lblUnit
            // 
            lblUnit.AutoSize = true;
            lblUnit.ForeColor = Color.FromArgb(185, 179, 206);
            lblUnit.Location = new Point(230, 49);
            lblUnit.Name = "lblUnit";
            lblUnit.Size = new Size(49, 28);
            lblUnit.TabIndex = 10;
            lblUnit.Text = "Unit";
            // 
            // lblIngredientName
            // 
            lblIngredientName.AutoSize = true;
            lblIngredientName.ForeColor = Color.FromArgb(185, 179, 206);
            lblIngredientName.Location = new Point(15, 50);
            lblIngredientName.Name = "lblIngredientName";
            lblIngredientName.Size = new Size(64, 28);
            lblIngredientName.TabIndex = 9;
            lblIngredientName.Text = "Name";
            // 
            // btnClear
            // 
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(424, 173);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 34);
            btnClear.TabIndex = 8;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnRetire
            // 
            btnRetire.Enabled = false;
            btnRetire.FlatAppearance.BorderSize = 0;
            btnRetire.FlatStyle = FlatStyle.Flat;
            btnRetire.ForeColor = Color.White;
            btnRetire.Location = new Point(295, 173);
            btnRetire.Name = "btnRetire";
            btnRetire.Size = new Size(112, 34);
            btnRetire.TabIndex = 7;
            btnRetire.Text = "Retire";
            btnRetire.UseVisualStyleBackColor = true;
            btnRetire.Click += btnRetire_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Enabled = false;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(177, 176);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 34);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.AutoSize = true;
            btnAdd.BackColor = Color.FromArgb(128, 90, 202);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(15, 173);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(156, 40);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add Ingredient";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // cmbRarity
            // 
            cmbRarity.BackColor = Color.FromArgb(25, 24, 39);
            cmbRarity.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRarity.ForeColor = Color.FromArgb(185, 179, 206);
            cmbRarity.FormattingEnabled = true;
            cmbRarity.Location = new Point(610, 81);
            cmbRarity.Name = "cmbRarity";
            cmbRarity.Size = new Size(182, 36);
            cmbRarity.TabIndex = 4;
            // 
            // nudStock
            // 
            nudStock.BackColor = Color.FromArgb(25, 24, 39);
            nudStock.ForeColor = Color.FromArgb(185, 179, 206);
            nudStock.Location = new Point(411, 81);
            nudStock.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudStock.Name = "nudStock";
            nudStock.Size = new Size(180, 34);
            nudStock.TabIndex = 3;
            // 
            // txtUnit
            // 
            txtUnit.BackColor = Color.FromArgb(25, 24, 39);
            txtUnit.ForeColor = Color.FromArgb(185, 179, 206);
            txtUnit.Location = new Point(230, 80);
            txtUnit.Name = "txtUnit";
            txtUnit.Size = new Size(150, 34);
            txtUnit.TabIndex = 2;
            txtUnit.Text = "e.g. pinches";
            // 
            // txtIngredientName
            // 
            txtIngredientName.BackColor = Color.FromArgb(25, 24, 39);
            txtIngredientName.BorderStyle = BorderStyle.FixedSingle;
            txtIngredientName.ForeColor = Color.FromArgb(185, 179, 206);
            txtIngredientName.Location = new Point(15, 80);
            txtIngredientName.Name = "txtIngredientName";
            txtIngredientName.Size = new Size(150, 34);
            txtIngredientName.TabIndex = 1;
            txtIngredientName.Text = "e.g. Fairy Dust";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(246, 240, 255);
            label1.Location = new Point(3, 7);
            label1.Name = "label1";
            label1.Size = new Size(219, 32);
            label1.TabIndex = 0;
            label1.Text = "Ingredient Details";
            // 
            // IngredientsForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(25, 24, 39);
            ClientSize = new Size(900, 690);
            Controls.Add(pnlIngredientEditor);
            Controls.Add(dgvIngredients);
            Controls.Add(lblTitle);
            Controls.Add(txtSearch);
            Controls.Add(lblSubtitle);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "IngredientsForm";
            Text = "Ingredient Inventory";
            Load += IngredientsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvIngredients).EndInit();
            pnlIngredientEditor.ResumeLayout(false);
            pnlIngredientEditor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblSubtitle;
        private TextBox txtSearch;
        private DataGridView dgvIngredients;
        private Panel pnlIngredientEditor;
        private Label label1;
        private TextBox txtIngredientName;
        private TextBox txtUnit;
        private NumericUpDown nudStock;
        private ComboBox cmbRarity;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnRetire;
        private Button btnClear;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colStock;
        private DataGridViewTextBoxColumn colUnit;
        private DataGridViewTextBoxColumn colRarity;
        private DataGridViewTextBoxColumn colStatus;
        private Label lblIngredientName;
        private Label lblUnit;
        private Label lblStock;
        private Label lblRarity;
    }
}