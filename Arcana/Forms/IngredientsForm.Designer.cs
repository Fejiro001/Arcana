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
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
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
            lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(246, 240, 255);
            lblTitle.Location = new Point(30, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.RightToLeft = RightToLeft.No;
            lblTitle.Size = new Size(550, 50);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Ingredient Inventory";
            // 
            // lblSubtitle
            // 
            lblSubtitle.ForeColor = Color.FromArgb(185, 179, 206);
            lblSubtitle.Location = new Point(30, 75);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(600, 25);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Manage your magical resources and supplies";
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.FromArgb(25, 24, 39);
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.ForeColor = Color.FromArgb(246, 240, 255);
            txtSearch.Location = new Point(30, 115);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search ingredients...";
            txtSearch.Size = new Size(370, 34);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // dgvIngredients
            // 
            dgvIngredients.AllowUserToAddRows = false;
            dgvIngredients.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(47, 43, 67);
            dataGridViewCellStyle10.ForeColor = Color.FromArgb(230, 220, 245);
            dgvIngredients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            dgvIngredients.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvIngredients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvIngredients.BackgroundColor = Color.FromArgb(41, 38, 60);
            dgvIngredients.BorderStyle = BorderStyle.None;
            dgvIngredients.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = Color.FromArgb(55, 50, 72);
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle11.ForeColor = Color.FromArgb(196, 167, 255);
            dataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(55, 50, 72);
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            dgvIngredients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dgvIngredients.ColumnHeadersHeight = 34;
            dgvIngredients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvIngredients.Columns.AddRange(new DataGridViewColumn[] { colId, colName, colStock, colUnit, colRarity, colStatus });
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = Color.FromArgb(41, 38, 60);
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle12.ForeColor = Color.FromArgb(230, 220, 245);
            dataGridViewCellStyle12.Padding = new Padding(4, 2, 4, 2);
            dataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(81, 65, 123);
            dataGridViewCellStyle12.SelectionForeColor = Color.White;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.False;
            dgvIngredients.DefaultCellStyle = dataGridViewCellStyle12;
            dgvIngredients.EnableHeadersVisualStyles = false;
            dgvIngredients.GridColor = Color.FromArgb(65, 58, 85);
            dgvIngredients.Location = new Point(30, 160);
            dgvIngredients.MultiSelect = false;
            dgvIngredients.Name = "dgvIngredients";
            dgvIngredients.ReadOnly = true;
            dgvIngredients.RowHeadersVisible = false;
            dgvIngredients.RowHeadersWidth = 62;
            dgvIngredients.RowTemplate.Height = 30;
            dgvIngredients.ScrollBars = ScrollBars.Vertical;
            dgvIngredients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvIngredients.Size = new Size(880, 250);
            dgvIngredients.TabIndex = 3;
            dgvIngredients.CellFormatting += dgvIngredients_CellFormatting;
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
            colName.FillWeight = 150F;
            colName.HeaderText = "Ingredient";
            colName.MinimumWidth = 8;
            colName.Name = "colName";
            colName.ReadOnly = true;
            // 
            // colStock
            // 
            colStock.DataPropertyName = "Stock";
            colStock.FillWeight = 50F;
            colStock.HeaderText = "Stock";
            colStock.MinimumWidth = 8;
            colStock.Name = "colStock";
            colStock.ReadOnly = true;
            // 
            // colUnit
            // 
            colUnit.DataPropertyName = "Unit";
            colUnit.FillWeight = 80F;
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
            colStatus.FillWeight = 60F;
            colStatus.HeaderText = "Status";
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
            pnlIngredientEditor.Size = new Size(880, 230);
            pnlIngredientEditor.TabIndex = 4;
            // 
            // lblRarity
            // 
            lblRarity.ForeColor = Color.FromArgb(185, 179, 206);
            lblRarity.Location = new Point(650, 55);
            lblRarity.Name = "lblRarity";
            lblRarity.Size = new Size(190, 25);
            lblRarity.TabIndex = 12;
            lblRarity.Text = "Rarity";
            // 
            // lblStock
            // 
            lblStock.ForeColor = Color.FromArgb(185, 179, 206);
            lblStock.Location = new Point(440, 55);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(190, 25);
            lblStock.TabIndex = 11;
            lblStock.Text = "Stock Quantity";
            // 
            // lblUnit
            // 
            lblUnit.ForeColor = Color.FromArgb(185, 179, 206);
            lblUnit.Location = new Point(230, 55);
            lblUnit.Name = "lblUnit";
            lblUnit.Size = new Size(190, 25);
            lblUnit.TabIndex = 10;
            lblUnit.Text = "Measurement Unit";
            // 
            // lblIngredientName
            // 
            lblIngredientName.ForeColor = Color.FromArgb(185, 179, 206);
            lblIngredientName.Location = new Point(20, 55);
            lblIngredientName.Name = "lblIngredientName";
            lblIngredientName.Size = new Size(190, 25);
            lblIngredientName.TabIndex = 9;
            lblIngredientName.Text = "Ingredient Name";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(55, 51, 72);
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(455, 165);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(115, 40);
            btnClear.TabIndex = 8;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnRetire
            // 
            btnRetire.BackColor = Color.FromArgb(73, 48, 68);
            btnRetire.Enabled = false;
            btnRetire.FlatAppearance.BorderSize = 0;
            btnRetire.FlatStyle = FlatStyle.Flat;
            btnRetire.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnRetire.ForeColor = Color.White;
            btnRetire.Location = new Point(325, 165);
            btnRetire.Name = "btnRetire";
            btnRetire.Size = new Size(115, 40);
            btnRetire.TabIndex = 7;
            btnRetire.Text = "Retire";
            btnRetire.UseVisualStyleBackColor = false;
            btnRetire.Click += btnRetire_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(81, 65, 123);
            btnUpdate.Enabled = false;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(195, 165);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(115, 40);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.AutoSize = true;
            btnAdd.BackColor = Color.FromArgb(128, 90, 202);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(20, 165);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(160, 40);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add Ingredient";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // cmbRarity
            // 
            cmbRarity.BackColor = Color.FromArgb(25, 24, 39);
            cmbRarity.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRarity.ForeColor = Color.FromArgb(246, 240, 255);
            cmbRarity.FormattingEnabled = true;
            cmbRarity.Location = new Point(650, 85);
            cmbRarity.Name = "cmbRarity";
            cmbRarity.Size = new Size(190, 36);
            cmbRarity.TabIndex = 4;
            // 
            // nudStock
            // 
            nudStock.BackColor = Color.FromArgb(25, 24, 39);
            nudStock.BorderStyle = BorderStyle.FixedSingle;
            nudStock.ForeColor = Color.FromArgb(246, 240, 255);
            nudStock.Location = new Point(440, 85);
            nudStock.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudStock.Name = "nudStock";
            nudStock.Size = new Size(190, 34);
            nudStock.TabIndex = 3;
            // 
            // txtUnit
            // 
            txtUnit.BackColor = Color.FromArgb(25, 24, 39);
            txtUnit.BorderStyle = BorderStyle.FixedSingle;
            txtUnit.ForeColor = Color.FromArgb(246, 240, 255);
            txtUnit.Location = new Point(230, 85);
            txtUnit.Name = "txtUnit";
            txtUnit.PlaceholderText = "e.g. pinches";
            txtUnit.Size = new Size(190, 34);
            txtUnit.TabIndex = 2;
            // 
            // txtIngredientName
            // 
            txtIngredientName.BackColor = Color.FromArgb(25, 24, 39);
            txtIngredientName.BorderStyle = BorderStyle.FixedSingle;
            txtIngredientName.ForeColor = Color.FromArgb(246, 240, 255);
            txtIngredientName.Location = new Point(20, 85);
            txtIngredientName.Name = "txtIngredientName";
            txtIngredientName.PlaceholderText = "e.g. Fairy Dust";
            txtIngredientName.Size = new Size(190, 34);
            txtIngredientName.TabIndex = 1;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(246, 240, 255);
            label1.Location = new Point(20, 12);
            label1.Name = "label1";
            label1.Size = new Size(350, 35);
            label1.TabIndex = 0;
            label1.Text = "Ingredient Details";
            // 
            // IngredientsForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(25, 24, 39);
            ClientSize = new Size(950, 690);
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
            Shown += IngredientsForm_Shown;
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
        private Label lblIngredientName;
        private Label lblUnit;
        private Label lblStock;
        private Label lblRarity;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colStock;
        private DataGridViewTextBoxColumn colUnit;
        private DataGridViewTextBoxColumn colRarity;
        private DataGridViewTextBoxColumn colStatus;
    }
}