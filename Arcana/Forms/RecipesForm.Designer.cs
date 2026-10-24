namespace Arcana.Forms
{
    partial class RecipesForm
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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            lblTitle = new Label();
            lblSubtitle = new Label();
            dgvRecipes = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            colRecipeName = new DataGridViewTextBoxColumn();
            colEffect = new DataGridViewTextBoxColumn();
            colElement = new DataGridViewTextBoxColumn();
            colDuration = new DataGridViewTextBoxColumn();
            colRecipeStatus = new DataGridViewTextBoxColumn();
            label1 = new Label();
            pnlRecipeLibrary = new Panel();
            pnlRequiredIngredients = new Panel();
            divider = new Label();
            btnClearRecipe = new Button();
            btnRetireRecipe = new Button();
            btnUpdateRecipe = new Button();
            btnAddRecipe = new Button();
            btnRemoveIngredientFromRecipe = new Button();
            dgvRecipeIngredients = new DataGridView();
            colIngredientName = new DataGridViewTextBoxColumn();
            colRequiredQuantity = new DataGridViewTextBoxColumn();
            colIngredientUnit = new DataGridViewTextBoxColumn();
            btnAddIngredientToRecipe = new Button();
            nudQuantity = new NumericUpDown();
            cmbIngredient = new ComboBox();
            label3 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            tblRecipeInputs = new TableLayoutPanel();
            nudDuration = new NumericUpDown();
            lblDuration = new Label();
            lblRecipeName = new Label();
            txtRecipeName = new TextBox();
            txtEffect = new TextBox();
            lblEffect = new Label();
            txtElement = new TextBox();
            lblElement = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvRecipes).BeginInit();
            pnlRecipeLibrary.SuspendLayout();
            pnlRequiredIngredients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecipeIngredients).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            panel2.SuspendLayout();
            tblRecipeInputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudDuration).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(246, 240, 255);
            lblTitle.Location = new Point(13, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(330, 60);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Potion Recipes";
            // 
            // lblSubtitle
            // 
            lblSubtitle.ForeColor = Color.FromArgb(185, 179, 206);
            lblSubtitle.Location = new Point(13, 77);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(660, 28);
            lblSubtitle.TabIndex = 2;
            lblSubtitle.Text = "Create and manage your magical formulas";
            // 
            // dgvRecipes
            // 
            dgvRecipes.AllowUserToAddRows = false;
            dgvRecipes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvRecipes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecipes.BackgroundColor = Color.FromArgb(41, 38, 60);
            dgvRecipes.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(196, 167, 255);
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvRecipes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvRecipes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecipes.Columns.AddRange(new DataGridViewColumn[] { ID, colRecipeName, colEffect, colElement, colDuration, colRecipeStatus });
            dgvRecipes.Location = new Point(20, 50);
            dgvRecipes.Name = "dgvRecipes";
            dgvRecipes.ReadOnly = true;
            dgvRecipes.RowHeadersWidth = 62;
            dgvRecipes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecipes.Size = new Size(819, 145);
            dgvRecipes.TabIndex = 3;
            dgvRecipes.CellFormatting += dgvRecipes_CellFormatting;
            dgvRecipes.SelectionChanged += dgvRecipes_SelectionChanged;
            // 
            // ID
            // 
            ID.DataPropertyName = "Id";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 8;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Visible = false;
            // 
            // colRecipeName
            // 
            colRecipeName.DataPropertyName = "Name";
            colRecipeName.HeaderText = "Recipe";
            colRecipeName.MinimumWidth = 8;
            colRecipeName.Name = "colRecipeName";
            colRecipeName.ReadOnly = true;
            // 
            // colEffect
            // 
            colEffect.DataPropertyName = "Effect";
            colEffect.HeaderText = "Effect";
            colEffect.MinimumWidth = 8;
            colEffect.Name = "colEffect";
            colEffect.ReadOnly = true;
            // 
            // colElement
            // 
            colElement.DataPropertyName = "Element";
            colElement.HeaderText = "Element";
            colElement.MinimumWidth = 8;
            colElement.Name = "colElement";
            colElement.ReadOnly = true;
            // 
            // colDuration
            // 
            colDuration.DataPropertyName = "DurationSeconds";
            colDuration.HeaderText = "Duration";
            colDuration.MinimumWidth = 8;
            colDuration.Name = "colDuration";
            colDuration.ReadOnly = true;
            // 
            // colRecipeStatus
            // 
            colRecipeStatus.DataPropertyName = "IsActive";
            colRecipeStatus.HeaderText = "Status";
            colRecipeStatus.MinimumWidth = 8;
            colRecipeStatus.Name = "colRecipeStatus";
            colRecipeStatus.ReadOnly = true;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(246, 240, 255);
            label1.Location = new Point(20, 12);
            label1.Name = "label1";
            label1.Size = new Size(385, 39);
            label1.TabIndex = 4;
            label1.Text = "Recipe Library";
            // 
            // pnlRecipeLibrary
            // 
            pnlRecipeLibrary.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlRecipeLibrary.BackColor = Color.FromArgb(41, 38, 60);
            pnlRecipeLibrary.Controls.Add(dgvRecipes);
            pnlRecipeLibrary.Controls.Add(label1);
            pnlRecipeLibrary.Location = new Point(13, 123);
            pnlRecipeLibrary.Margin = new Padding(3, 3, 12, 3);
            pnlRecipeLibrary.Name = "pnlRecipeLibrary";
            pnlRecipeLibrary.Size = new Size(926, 308);
            pnlRecipeLibrary.TabIndex = 6;
            // 
            // pnlRequiredIngredients
            // 
            pnlRequiredIngredients.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlRequiredIngredients.BackColor = Color.FromArgb(41, 38, 60);
            pnlRequiredIngredients.Controls.Add(divider);
            pnlRequiredIngredients.Controls.Add(btnClearRecipe);
            pnlRequiredIngredients.Controls.Add(btnRetireRecipe);
            pnlRequiredIngredients.Controls.Add(btnUpdateRecipe);
            pnlRequiredIngredients.Controls.Add(btnAddRecipe);
            pnlRequiredIngredients.Controls.Add(btnRemoveIngredientFromRecipe);
            pnlRequiredIngredients.Controls.Add(dgvRecipeIngredients);
            pnlRequiredIngredients.Controls.Add(btnAddIngredientToRecipe);
            pnlRequiredIngredients.Controls.Add(nudQuantity);
            pnlRequiredIngredients.Controls.Add(cmbIngredient);
            pnlRequiredIngredients.Controls.Add(label3);
            pnlRequiredIngredients.Location = new Point(13, 705);
            pnlRequiredIngredients.Name = "pnlRequiredIngredients";
            pnlRequiredIngredients.Size = new Size(925, 407);
            pnlRequiredIngredients.TabIndex = 7;
            // 
            // divider
            // 
            divider.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            divider.BorderStyle = BorderStyle.FixedSingle;
            divider.Location = new Point(20, 329);
            divider.Name = "divider";
            divider.Size = new Size(852, 2);
            divider.TabIndex = 18;
            // 
            // btnClearRecipe
            // 
            btnClearRecipe.BackColor = Color.FromArgb(55, 51, 72);
            btnClearRecipe.FlatAppearance.BorderSize = 0;
            btnClearRecipe.FlatStyle = FlatStyle.Flat;
            btnClearRecipe.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnClearRecipe.ForeColor = Color.White;
            btnClearRecipe.Location = new Point(430, 350);
            btnClearRecipe.Name = "btnClearRecipe";
            btnClearRecipe.Size = new Size(110, 36);
            btnClearRecipe.TabIndex = 38;
            btnClearRecipe.Tag = "Neutral";
            btnClearRecipe.Text = "Clear";
            btnClearRecipe.UseVisualStyleBackColor = false;
            btnClearRecipe.Click += btnClearRecipe_Click;
            // 
            // btnRetireRecipe
            // 
            btnRetireRecipe.BackColor = Color.FromArgb(73, 48, 68);
            btnRetireRecipe.Enabled = false;
            btnRetireRecipe.FlatAppearance.BorderSize = 0;
            btnRetireRecipe.FlatStyle = FlatStyle.Flat;
            btnRetireRecipe.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnRetireRecipe.ForeColor = Color.White;
            btnRetireRecipe.Location = new Point(305, 350);
            btnRetireRecipe.Name = "btnRetireRecipe";
            btnRetireRecipe.Size = new Size(110, 36);
            btnRetireRecipe.TabIndex = 37;
            btnRetireRecipe.Tag = "Danger";
            btnRetireRecipe.Text = "Retire";
            btnRetireRecipe.UseVisualStyleBackColor = false;
            btnRetireRecipe.Click += btnRetireRecipe_Click;
            // 
            // btnUpdateRecipe
            // 
            btnUpdateRecipe.BackColor = Color.FromArgb(81, 65, 123);
            btnUpdateRecipe.Enabled = false;
            btnUpdateRecipe.FlatAppearance.BorderSize = 0;
            btnUpdateRecipe.FlatStyle = FlatStyle.Flat;
            btnUpdateRecipe.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnUpdateRecipe.ForeColor = Color.White;
            btnUpdateRecipe.Location = new Point(180, 350);
            btnUpdateRecipe.Name = "btnUpdateRecipe";
            btnUpdateRecipe.Size = new Size(110, 36);
            btnUpdateRecipe.TabIndex = 36;
            btnUpdateRecipe.Tag = "Secondary";
            btnUpdateRecipe.Text = "Update";
            btnUpdateRecipe.UseVisualStyleBackColor = false;
            btnUpdateRecipe.Click += btnUpdateRecipe_Click;
            // 
            // btnAddRecipe
            // 
            btnAddRecipe.AutoSize = true;
            btnAddRecipe.BackColor = Color.FromArgb(128, 90, 202);
            btnAddRecipe.FlatAppearance.BorderSize = 0;
            btnAddRecipe.FlatStyle = FlatStyle.Flat;
            btnAddRecipe.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnAddRecipe.ForeColor = Color.White;
            btnAddRecipe.Location = new Point(20, 350);
            btnAddRecipe.Name = "btnAddRecipe";
            btnAddRecipe.Size = new Size(145, 38);
            btnAddRecipe.TabIndex = 35;
            btnAddRecipe.Tag = "Primary";
            btnAddRecipe.Text = "Create Recipe";
            btnAddRecipe.UseVisualStyleBackColor = false;
            btnAddRecipe.Click += btnAddRecipe_Click;
            // 
            // btnRemoveIngredientFromRecipe
            // 
            btnRemoveIngredientFromRecipe.AutoSize = true;
            btnRemoveIngredientFromRecipe.BackColor = Color.FromArgb(128, 90, 202);
            btnRemoveIngredientFromRecipe.FlatAppearance.BorderSize = 0;
            btnRemoveIngredientFromRecipe.FlatStyle = FlatStyle.Flat;
            btnRemoveIngredientFromRecipe.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnRemoveIngredientFromRecipe.ForeColor = Color.White;
            btnRemoveIngredientFromRecipe.Location = new Point(26, 264);
            btnRemoveIngredientFromRecipe.Name = "btnRemoveIngredientFromRecipe";
            btnRemoveIngredientFromRecipe.Size = new Size(216, 45);
            btnRemoveIngredientFromRecipe.TabIndex = 34;
            btnRemoveIngredientFromRecipe.Tag = "Primary";
            btnRemoveIngredientFromRecipe.Text = "Remove Ingredient";
            btnRemoveIngredientFromRecipe.UseVisualStyleBackColor = false;
            btnRemoveIngredientFromRecipe.Click += btnRemoveIngredientFromRecipe_Click;
            // 
            // dgvRecipeIngredients
            // 
            dgvRecipeIngredients.AllowUserToAddRows = false;
            dgvRecipeIngredients.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvRecipeIngredients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecipeIngredients.BackgroundColor = Color.FromArgb(41, 38, 60);
            dgvRecipeIngredients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecipeIngredients.Columns.AddRange(new DataGridViewColumn[] { colIngredientName, colRequiredQuantity, colIngredientUnit });
            dgvRecipeIngredients.Location = new Point(20, 98);
            dgvRecipeIngredients.Name = "dgvRecipeIngredients";
            dgvRecipeIngredients.ReadOnly = true;
            dgvRecipeIngredients.RowHeadersWidth = 62;
            dgvRecipeIngredients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecipeIngredients.Size = new Size(827, 156);
            dgvRecipeIngredients.TabIndex = 33;
            // 
            // colIngredientName
            // 
            colIngredientName.DataPropertyName = "IngredientName";
            colIngredientName.HeaderText = "Ingredient";
            colIngredientName.MinimumWidth = 8;
            colIngredientName.Name = "colIngredientName";
            colIngredientName.ReadOnly = true;
            // 
            // colRequiredQuantity
            // 
            colRequiredQuantity.DataPropertyName = "QuantityRequired";
            colRequiredQuantity.HeaderText = "Quantity";
            colRequiredQuantity.MinimumWidth = 8;
            colRequiredQuantity.Name = "colRequiredQuantity";
            colRequiredQuantity.ReadOnly = true;
            // 
            // colIngredientUnit
            // 
            colIngredientUnit.DataPropertyName = "Unit";
            colIngredientUnit.HeaderText = "Unit";
            colIngredientUnit.MinimumWidth = 8;
            colIngredientUnit.Name = "colIngredientUnit";
            colIngredientUnit.ReadOnly = true;
            // 
            // btnAddIngredientToRecipe
            // 
            btnAddIngredientToRecipe.BackColor = Color.FromArgb(128, 90, 202);
            btnAddIngredientToRecipe.FlatAppearance.BorderSize = 0;
            btnAddIngredientToRecipe.FlatStyle = FlatStyle.Flat;
            btnAddIngredientToRecipe.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnAddIngredientToRecipe.ForeColor = Color.White;
            btnAddIngredientToRecipe.Location = new Point(560, 55);
            btnAddIngredientToRecipe.Name = "btnAddIngredientToRecipe";
            btnAddIngredientToRecipe.Size = new Size(155, 35);
            btnAddIngredientToRecipe.TabIndex = 32;
            btnAddIngredientToRecipe.Tag = "Primary";
            btnAddIngredientToRecipe.Text = "+ Add";
            btnAddIngredientToRecipe.UseVisualStyleBackColor = false;
            btnAddIngredientToRecipe.Click += btnAddIngredientToRecipe_Click;
            // 
            // nudQuantity
            // 
            nudQuantity.BackColor = Color.FromArgb(25, 24, 39);
            nudQuantity.BorderStyle = BorderStyle.FixedSingle;
            nudQuantity.ForeColor = Color.FromArgb(246, 240, 255);
            nudQuantity.Location = new Point(420, 55);
            nudQuantity.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(120, 34);
            nudQuantity.TabIndex = 31;
            nudQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cmbIngredient
            // 
            cmbIngredient.BackColor = Color.FromArgb(25, 24, 39);
            cmbIngredient.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbIngredient.ForeColor = Color.FromArgb(246, 240, 255);
            cmbIngredient.FormattingEnabled = true;
            cmbIngredient.Location = new Point(20, 55);
            cmbIngredient.Name = "cmbIngredient";
            cmbIngredient.Size = new Size(380, 36);
            cmbIngredient.TabIndex = 30;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(246, 240, 255);
            label3.Location = new Point(20, 12);
            label3.Name = "label3";
            label3.Size = new Size(385, 39);
            label3.TabIndex = 29;
            label3.Text = "Required Ingredients";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(41, 38, 60);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(tblRecipeInputs);
            panel2.Location = new Point(14, 453);
            panel2.Name = "panel2";
            panel2.Size = new Size(925, 232);
            panel2.TabIndex = 6;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(246, 240, 255);
            label2.Location = new Point(20, 12);
            label2.Name = "label2";
            label2.Size = new Size(385, 39);
            label2.TabIndex = 18;
            label2.Text = "Recipe Details";
            // 
            // tblRecipeInputs
            // 
            tblRecipeInputs.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tblRecipeInputs.ColumnCount = 2;
            tblRecipeInputs.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblRecipeInputs.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblRecipeInputs.Controls.Add(nudDuration, 1, 3);
            tblRecipeInputs.Controls.Add(lblDuration, 1, 2);
            tblRecipeInputs.Controls.Add(lblRecipeName, 0, 0);
            tblRecipeInputs.Controls.Add(txtRecipeName, 0, 1);
            tblRecipeInputs.Controls.Add(txtEffect, 1, 1);
            tblRecipeInputs.Controls.Add(lblEffect, 1, 0);
            tblRecipeInputs.Controls.Add(txtElement, 0, 3);
            tblRecipeInputs.Controls.Add(lblElement, 0, 2);
            tblRecipeInputs.Location = new Point(20, 60);
            tblRecipeInputs.Name = "tblRecipeInputs";
            tblRecipeInputs.RowCount = 4;
            tblRecipeInputs.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tblRecipeInputs.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tblRecipeInputs.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tblRecipeInputs.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tblRecipeInputs.Size = new Size(830, 130);
            tblRecipeInputs.TabIndex = 0;
            // 
            // nudDuration
            // 
            nudDuration.BackColor = Color.FromArgb(25, 24, 39);
            nudDuration.BorderStyle = BorderStyle.FixedSingle;
            nudDuration.Dock = DockStyle.Fill;
            nudDuration.ForeColor = Color.FromArgb(246, 240, 255);
            nudDuration.Location = new Point(420, 90);
            nudDuration.Margin = new Padding(5, 2, 15, 3);
            nudDuration.Maximum = new decimal(new int[] { 3600, 0, 0, 0 });
            nudDuration.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudDuration.Name = "nudDuration";
            nudDuration.Size = new Size(395, 34);
            nudDuration.TabIndex = 25;
            nudDuration.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblDuration
            // 
            lblDuration.ForeColor = Color.FromArgb(185, 179, 206);
            lblDuration.Location = new Point(418, 63);
            lblDuration.Name = "lblDuration";
            lblDuration.Size = new Size(209, 25);
            lblDuration.TabIndex = 26;
            lblDuration.Text = "Brewing Duration";
            // 
            // lblRecipeName
            // 
            lblRecipeName.ForeColor = Color.FromArgb(185, 179, 206);
            lblRecipeName.Location = new Point(3, 0);
            lblRecipeName.Name = "lblRecipeName";
            lblRecipeName.Size = new Size(209, 25);
            lblRecipeName.TabIndex = 20;
            lblRecipeName.Text = "Recipe Name";
            // 
            // txtRecipeName
            // 
            txtRecipeName.BackColor = Color.FromArgb(25, 24, 39);
            txtRecipeName.BorderStyle = BorderStyle.FixedSingle;
            txtRecipeName.Dock = DockStyle.Fill;
            txtRecipeName.ForeColor = Color.FromArgb(246, 240, 255);
            txtRecipeName.Location = new Point(5, 27);
            txtRecipeName.Margin = new Padding(5, 2, 15, 3);
            txtRecipeName.Name = "txtRecipeName";
            txtRecipeName.PlaceholderText = "Enter recipe name";
            txtRecipeName.Size = new Size(395, 34);
            txtRecipeName.TabIndex = 19;
            // 
            // txtEffect
            // 
            txtEffect.BackColor = Color.FromArgb(25, 24, 39);
            txtEffect.BorderStyle = BorderStyle.FixedSingle;
            txtEffect.Dock = DockStyle.Fill;
            txtEffect.ForeColor = Color.FromArgb(246, 240, 255);
            txtEffect.Location = new Point(420, 27);
            txtEffect.Margin = new Padding(5, 2, 15, 3);
            txtEffect.Name = "txtEffect";
            txtEffect.PlaceholderText = "e.g. Restores vitality";
            txtEffect.Size = new Size(395, 34);
            txtEffect.TabIndex = 21;
            // 
            // lblEffect
            // 
            lblEffect.ForeColor = Color.FromArgb(185, 179, 206);
            lblEffect.Location = new Point(418, 0);
            lblEffect.Name = "lblEffect";
            lblEffect.Size = new Size(209, 25);
            lblEffect.TabIndex = 22;
            lblEffect.Text = "Special Effect";
            // 
            // txtElement
            // 
            txtElement.BackColor = Color.FromArgb(25, 24, 39);
            txtElement.BorderStyle = BorderStyle.FixedSingle;
            txtElement.Dock = DockStyle.Fill;
            txtElement.ForeColor = Color.FromArgb(246, 240, 255);
            txtElement.Location = new Point(5, 90);
            txtElement.Margin = new Padding(5, 2, 15, 3);
            txtElement.Name = "txtElement";
            txtElement.PlaceholderText = "e.g. Fire";
            txtElement.Size = new Size(395, 34);
            txtElement.TabIndex = 23;
            // 
            // lblElement
            // 
            lblElement.ForeColor = Color.FromArgb(185, 179, 206);
            lblElement.Location = new Point(3, 63);
            lblElement.Name = "lblElement";
            lblElement.Size = new Size(209, 25);
            lblElement.TabIndex = 24;
            lblElement.Text = "Element";
            // 
            // RecipesForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(25, 24, 39);
            ClientSize = new Size(950, 1137);
            Controls.Add(panel2);
            Controls.Add(pnlRequiredIngredients);
            Controls.Add(pnlRecipeLibrary);
            Controls.Add(lblSubtitle);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RecipesForm";
            Text = "RecipesForm";
            Load += RecipesForm_Load;
            Shown += RecipesForm_Shown;
            ((System.ComponentModel.ISupportInitialize)dgvRecipes).EndInit();
            pnlRecipeLibrary.ResumeLayout(false);
            pnlRequiredIngredients.ResumeLayout(false);
            pnlRequiredIngredients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecipeIngredients).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            panel2.ResumeLayout(false);
            tblRecipeInputs.ResumeLayout(false);
            tblRecipeInputs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudDuration).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblSubtitle;
        private DataGridView dgvRecipes;
        private Label label1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn colRecipeName;
        private DataGridViewTextBoxColumn colEffect;
        private DataGridViewTextBoxColumn colElement;
        private DataGridViewTextBoxColumn colDuration;
        private DataGridViewTextBoxColumn colRecipeStatus;
        private Panel pnlRecipeLibrary;
        private Panel pnlRequiredIngredients;
        private Label divider;
        private Button btnClearRecipe;
        private Button btnRetireRecipe;
        private Button btnUpdateRecipe;
        private Button btnAddRecipe;
        private Button btnRemoveIngredientFromRecipe;
        private DataGridView dgvRecipeIngredients;
        private DataGridViewTextBoxColumn colIngredientName;
        private DataGridViewTextBoxColumn colRequiredQuantity;
        private DataGridViewTextBoxColumn colIngredientUnit;
        private Button btnAddIngredientToRecipe;
        private NumericUpDown nudQuantity;
        private ComboBox cmbIngredient;
        private Label label3;
        private Panel panel2;
        private Label lblDuration;
        private NumericUpDown nudDuration;
        private Label lblElement;
        private TextBox txtElement;
        private Label lblEffect;
        private TextBox txtEffect;
        private Label lblRecipeName;
        private TextBox txtRecipeName;
        private Label label2;
        private TableLayoutPanel tblRecipeInputs;
    }
}