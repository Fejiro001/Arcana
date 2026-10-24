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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
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
            panel1 = new Panel();
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
            divider = new Label();
            lblDuration = new Label();
            nudDuration = new NumericUpDown();
            lblElement = new Label();
            txtElement = new TextBox();
            lblEffect = new Label();
            txtEffect = new TextBox();
            lblRecipeName = new Label();
            txtRecipeName = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvRecipes).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecipeIngredients).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(196, 167, 255);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvRecipes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvRecipes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecipes.Columns.AddRange(new DataGridViewColumn[] { ID, colRecipeName, colEffect, colElement, colDuration, colRecipeStatus });
            dgvRecipes.Location = new Point(13, 178);
            dgvRecipes.Name = "dgvRecipes";
            dgvRecipes.ReadOnly = true;
            dgvRecipes.RowHeadersWidth = 62;
            dgvRecipes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecipes.Size = new Size(895, 252);
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
            label1.BackColor = Color.FromArgb(25, 24, 39);
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(246, 240, 255);
            label1.Location = new Point(13, 120);
            label1.Name = "label1";
            label1.Size = new Size(385, 39);
            label1.TabIndex = 4;
            label1.Text = "Recipe Library";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(41, 38, 60);
            panel1.Controls.Add(btnClearRecipe);
            panel1.Controls.Add(btnRetireRecipe);
            panel1.Controls.Add(btnUpdateRecipe);
            panel1.Controls.Add(btnAddRecipe);
            panel1.Controls.Add(btnRemoveIngredientFromRecipe);
            panel1.Controls.Add(dgvRecipeIngredients);
            panel1.Controls.Add(btnAddIngredientToRecipe);
            panel1.Controls.Add(nudQuantity);
            panel1.Controls.Add(cmbIngredient);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(divider);
            panel1.Controls.Add(lblDuration);
            panel1.Controls.Add(nudDuration);
            panel1.Controls.Add(lblElement);
            panel1.Controls.Add(txtElement);
            panel1.Controls.Add(lblEffect);
            panel1.Controls.Add(txtEffect);
            panel1.Controls.Add(lblRecipeName);
            panel1.Controls.Add(txtRecipeName);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(13, 458);
            panel1.Name = "panel1";
            panel1.Size = new Size(895, 872);
            panel1.TabIndex = 5;
            // 
            // btnClearRecipe
            // 
            btnClearRecipe.BackColor = Color.FromArgb(55, 51, 72);
            btnClearRecipe.FlatAppearance.BorderSize = 0;
            btnClearRecipe.FlatStyle = FlatStyle.Flat;
            btnClearRecipe.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnClearRecipe.ForeColor = Color.White;
            btnClearRecipe.Location = new Point(474, 778);
            btnClearRecipe.Name = "btnClearRecipe";
            btnClearRecipe.Size = new Size(126, 45);
            btnClearRecipe.TabIndex = 28;
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
            btnRetireRecipe.Location = new Point(326, 778);
            btnRetireRecipe.Name = "btnRetireRecipe";
            btnRetireRecipe.Size = new Size(126, 45);
            btnRetireRecipe.TabIndex = 27;
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
            btnUpdateRecipe.Location = new Point(176, 778);
            btnUpdateRecipe.Name = "btnUpdateRecipe";
            btnUpdateRecipe.Size = new Size(126, 45);
            btnUpdateRecipe.TabIndex = 26;
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
            btnAddRecipe.Location = new Point(28, 778);
            btnAddRecipe.Name = "btnAddRecipe";
            btnAddRecipe.Size = new Size(126, 45);
            btnAddRecipe.TabIndex = 25;
            btnAddRecipe.Tag = "Primary";
            btnAddRecipe.Text = "Create";
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
            btnRemoveIngredientFromRecipe.Location = new Point(639, 712);
            btnRemoveIngredientFromRecipe.Name = "btnRemoveIngredientFromRecipe";
            btnRemoveIngredientFromRecipe.Size = new Size(216, 45);
            btnRemoveIngredientFromRecipe.TabIndex = 24;
            btnRemoveIngredientFromRecipe.Tag = "Primary";
            btnRemoveIngredientFromRecipe.Text = "Remove Ingredient";
            btnRemoveIngredientFromRecipe.UseVisualStyleBackColor = false;
            btnRemoveIngredientFromRecipe.Click += btnRemoveIngredientFromRecipe_Click;
            // 
            // dgvRecipeIngredients
            // 
            dgvRecipeIngredients.AllowUserToAddRows = false;
            dgvRecipeIngredients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecipeIngredients.BackgroundColor = Color.FromArgb(41, 38, 60);
            dgvRecipeIngredients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecipeIngredients.Columns.AddRange(new DataGridViewColumn[] { colIngredientName, colRequiredQuantity, colIngredientUnit });
            dgvRecipeIngredients.Location = new Point(28, 400);
            dgvRecipeIngredients.Name = "dgvRecipeIngredients";
            dgvRecipeIngredients.ReadOnly = true;
            dgvRecipeIngredients.RowHeadersWidth = 62;
            dgvRecipeIngredients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecipeIngredients.Size = new Size(827, 281);
            dgvRecipeIngredients.TabIndex = 23;
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
            btnAddIngredientToRecipe.AutoSize = true;
            btnAddIngredientToRecipe.BackColor = Color.FromArgb(128, 90, 202);
            btnAddIngredientToRecipe.FlatAppearance.BorderSize = 0;
            btnAddIngredientToRecipe.FlatStyle = FlatStyle.Flat;
            btnAddIngredientToRecipe.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnAddIngredientToRecipe.ForeColor = Color.White;
            btnAddIngredientToRecipe.Location = new Point(729, 333);
            btnAddIngredientToRecipe.Name = "btnAddIngredientToRecipe";
            btnAddIngredientToRecipe.Size = new Size(126, 45);
            btnAddIngredientToRecipe.TabIndex = 22;
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
            nudQuantity.Location = new Point(489, 340);
            nudQuantity.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(211, 34);
            nudQuantity.TabIndex = 21;
            nudQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cmbIngredient
            // 
            cmbIngredient.BackColor = Color.FromArgb(25, 24, 39);
            cmbIngredient.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbIngredient.ForeColor = Color.FromArgb(246, 240, 255);
            cmbIngredient.FormattingEnabled = true;
            cmbIngredient.Location = new Point(28, 338);
            cmbIngredient.Name = "cmbIngredient";
            cmbIngredient.Size = new Size(432, 36);
            cmbIngredient.TabIndex = 20;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(246, 240, 255);
            label3.Location = new Point(19, 283);
            label3.Name = "label3";
            label3.Size = new Size(385, 39);
            label3.TabIndex = 19;
            label3.Text = "Required Ingredients";
            // 
            // divider
            // 
            divider.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            divider.BorderStyle = BorderStyle.FixedSingle;
            divider.Location = new Point(11, 263);
            divider.Name = "divider";
            divider.Size = new Size(731, 2);
            divider.TabIndex = 18;
            // 
            // lblDuration
            // 
            lblDuration.ForeColor = Color.FromArgb(185, 179, 206);
            lblDuration.Location = new Point(432, 162);
            lblDuration.Name = "lblDuration";
            lblDuration.Size = new Size(209, 28);
            lblDuration.TabIndex = 17;
            lblDuration.Text = "Brewing Duration";
            // 
            // nudDuration
            // 
            nudDuration.BackColor = Color.FromArgb(25, 24, 39);
            nudDuration.BorderStyle = BorderStyle.FixedSingle;
            nudDuration.ForeColor = Color.FromArgb(246, 240, 255);
            nudDuration.Location = new Point(432, 196);
            nudDuration.Maximum = new decimal(new int[] { 3600, 0, 0, 0 });
            nudDuration.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudDuration.Name = "nudDuration";
            nudDuration.Size = new Size(423, 34);
            nudDuration.TabIndex = 16;
            nudDuration.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblElement
            // 
            lblElement.ForeColor = Color.FromArgb(185, 179, 206);
            lblElement.Location = new Point(19, 162);
            lblElement.Name = "lblElement";
            lblElement.Size = new Size(209, 28);
            lblElement.TabIndex = 15;
            lblElement.Text = "Element";
            // 
            // txtElement
            // 
            txtElement.BackColor = Color.FromArgb(25, 24, 39);
            txtElement.BorderStyle = BorderStyle.FixedSingle;
            txtElement.ForeColor = Color.FromArgb(246, 240, 255);
            txtElement.Location = new Point(19, 196);
            txtElement.Name = "txtElement";
            txtElement.PlaceholderText = "e.g. Fire";
            txtElement.Size = new Size(373, 34);
            txtElement.TabIndex = 14;
            // 
            // lblEffect
            // 
            lblEffect.ForeColor = Color.FromArgb(185, 179, 206);
            lblEffect.Location = new Point(432, 58);
            lblEffect.Name = "lblEffect";
            lblEffect.Size = new Size(209, 28);
            lblEffect.TabIndex = 13;
            lblEffect.Text = "Special Effect";
            // 
            // txtEffect
            // 
            txtEffect.BackColor = Color.FromArgb(25, 24, 39);
            txtEffect.BorderStyle = BorderStyle.FixedSingle;
            txtEffect.ForeColor = Color.FromArgb(246, 240, 255);
            txtEffect.Location = new Point(432, 92);
            txtEffect.Name = "txtEffect";
            txtEffect.PlaceholderText = "e.g. Restores vitality";
            txtEffect.Size = new Size(423, 34);
            txtEffect.TabIndex = 12;
            // 
            // lblRecipeName
            // 
            lblRecipeName.ForeColor = Color.FromArgb(185, 179, 206);
            lblRecipeName.Location = new Point(19, 58);
            lblRecipeName.Name = "lblRecipeName";
            lblRecipeName.Size = new Size(209, 28);
            lblRecipeName.TabIndex = 11;
            lblRecipeName.Text = "Recipe Name";
            // 
            // txtRecipeName
            // 
            txtRecipeName.BackColor = Color.FromArgb(25, 24, 39);
            txtRecipeName.BorderStyle = BorderStyle.FixedSingle;
            txtRecipeName.ForeColor = Color.FromArgb(246, 240, 255);
            txtRecipeName.Location = new Point(19, 92);
            txtRecipeName.Name = "txtRecipeName";
            txtRecipeName.PlaceholderText = "Enter recipe name";
            txtRecipeName.Size = new Size(373, 34);
            txtRecipeName.TabIndex = 10;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(246, 240, 255);
            label2.Location = new Point(7, 7);
            label2.Name = "label2";
            label2.Size = new Size(385, 39);
            label2.TabIndex = 1;
            label2.Text = "Recipe Details";
            // 
            // RecipesForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(25, 24, 39);
            ClientSize = new Size(950, 1344);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(dgvRecipes);
            Controls.Add(lblSubtitle);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RecipesForm";
            Text = "RecipesForm";
            Load += RecipesForm_Load;
            Shown += RecipesForm_Shown;
            ((System.ComponentModel.ISupportInitialize)dgvRecipes).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecipeIngredients).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudDuration).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblSubtitle;
        private DataGridView dgvRecipes;
        private Label label1;
        private Panel panel1;
        private Label label2;
        private Label lblRecipeName;
        private TextBox txtRecipeName;
        private Label lblEffect;
        private TextBox txtEffect;
        private Label lblElement;
        private TextBox txtElement;
        private Label lblDuration;
        private NumericUpDown nudDuration;
        private Label divider;
        private Label label3;
        private ComboBox cmbIngredient;
        private NumericUpDown nudQuantity;
        private Button btnAddIngredientToRecipe;
        private DataGridView dgvRecipeIngredients;
        private Button btnRemoveIngredientFromRecipe;
        private Button btnClearRecipe;
        private Button btnRetireRecipe;
        private Button btnUpdateRecipe;
        private Button btnAddRecipe;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn colRecipeName;
        private DataGridViewTextBoxColumn colEffect;
        private DataGridViewTextBoxColumn colElement;
        private DataGridViewTextBoxColumn colDuration;
        private DataGridViewTextBoxColumn colRecipeStatus;
        private DataGridViewTextBoxColumn colIngredientName;
        private DataGridViewTextBoxColumn colRequiredQuantity;
        private DataGridViewTextBoxColumn colIngredientUnit;
    }
}