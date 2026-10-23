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
            lblTitle = new Label();
            lblSubtitle = new Label();
            dgvRecipes = new DataGridView();
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            lblRecipeName = new Label();
            txtRecipeName = new TextBox();
            lblEffect = new Label();
            txtEffect = new TextBox();
            lblElement = new Label();
            txtElement = new TextBox();
            lblDuration = new Label();
            nudDuration = new NumericUpDown();
            divider = new Label();
            label3 = new Label();
            cmbIngredient = new ComboBox();
            nudQuantity = new NumericUpDown();
            btnAddIngredientToRecipe = new Button();
            dgvRecipeIngredients = new DataGridView();
            btnRemoveIngredientFromRecipe = new Button();
            btnClearRecipe = new Button();
            btnRetireRecipe = new Button();
            btnUpdateRecipe = new Button();
            btnAddRecipe = new Button();
            ID = new DataGridViewTextBoxColumn();
            colRecipeName = new DataGridViewTextBoxColumn();
            colEffect = new DataGridViewTextBoxColumn();
            colElement = new DataGridViewTextBoxColumn();
            colDuration = new DataGridViewTextBoxColumn();
            colRecipeStatus = new DataGridViewTextBoxColumn();
            colIngredientName = new DataGridViewTextBoxColumn();
            colRequiredQuantity = new DataGridViewTextBoxColumn();
            colIngredientUnit = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvRecipes).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudDuration).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRecipeIngredients).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(246, 240, 255);
            lblTitle.Location = new Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(330, 60);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Potion Recipes";
            // 
            // lblSubtitle
            // 
            lblSubtitle.ForeColor = Color.FromArgb(185, 179, 206);
            lblSubtitle.Location = new Point(12, 69);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(600, 25);
            lblSubtitle.TabIndex = 2;
            lblSubtitle.Text = "Create and manage your magical formulas";
            // 
            // dgvRecipes
            // 
            dgvRecipes.AllowUserToAddRows = false;
            dgvRecipes.BackgroundColor = Color.FromArgb(41, 38, 60);
            dgvRecipes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecipes.Columns.AddRange(new DataGridViewColumn[] { ID, colRecipeName, colEffect, colElement, colDuration, colRecipeStatus });
            dgvRecipes.Location = new Point(12, 159);
            dgvRecipes.Name = "dgvRecipes";
            dgvRecipes.ReadOnly = true;
            dgvRecipes.RowHeadersWidth = 62;
            dgvRecipes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecipes.Size = new Size(816, 225);
            dgvRecipes.TabIndex = 3;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(25, 24, 39);
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(246, 240, 255);
            label1.Location = new Point(12, 107);
            label1.Name = "label1";
            label1.Size = new Size(350, 35);
            label1.TabIndex = 4;
            label1.Text = "Recipe Library";
            // 
            // panel1
            // 
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
            panel1.Location = new Point(12, 409);
            panel1.Name = "panel1";
            panel1.Size = new Size(816, 779);
            panel1.TabIndex = 5;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(246, 240, 255);
            label2.Location = new Point(6, 6);
            label2.Name = "label2";
            label2.Size = new Size(350, 35);
            label2.TabIndex = 1;
            label2.Text = "Recipe Details";
            // 
            // lblRecipeName
            // 
            lblRecipeName.ForeColor = Color.FromArgb(185, 179, 206);
            lblRecipeName.Location = new Point(17, 52);
            lblRecipeName.Name = "lblRecipeName";
            lblRecipeName.Size = new Size(190, 25);
            lblRecipeName.TabIndex = 11;
            lblRecipeName.Text = "Recipe Name";
            // 
            // txtRecipeName
            // 
            txtRecipeName.BackColor = Color.FromArgb(25, 24, 39);
            txtRecipeName.BorderStyle = BorderStyle.FixedSingle;
            txtRecipeName.ForeColor = Color.FromArgb(246, 240, 255);
            txtRecipeName.Location = new Point(17, 82);
            txtRecipeName.Name = "txtRecipeName";
            txtRecipeName.PlaceholderText = "Enter recipe name";
            txtRecipeName.Size = new Size(190, 31);
            txtRecipeName.TabIndex = 10;
            // 
            // lblEffect
            // 
            lblEffect.ForeColor = Color.FromArgb(185, 179, 206);
            lblEffect.Location = new Point(263, 52);
            lblEffect.Name = "lblEffect";
            lblEffect.Size = new Size(190, 25);
            lblEffect.TabIndex = 13;
            lblEffect.Text = "Special Effect";
            // 
            // txtEffect
            // 
            txtEffect.BackColor = Color.FromArgb(25, 24, 39);
            txtEffect.BorderStyle = BorderStyle.FixedSingle;
            txtEffect.ForeColor = Color.FromArgb(246, 240, 255);
            txtEffect.Location = new Point(263, 82);
            txtEffect.Name = "txtEffect";
            txtEffect.PlaceholderText = "e.g. Restores vitality";
            txtEffect.Size = new Size(190, 31);
            txtEffect.TabIndex = 12;
            // 
            // lblElement
            // 
            lblElement.ForeColor = Color.FromArgb(185, 179, 206);
            lblElement.Location = new Point(17, 145);
            lblElement.Name = "lblElement";
            lblElement.Size = new Size(190, 25);
            lblElement.TabIndex = 15;
            lblElement.Text = "Element";
            // 
            // txtElement
            // 
            txtElement.BackColor = Color.FromArgb(25, 24, 39);
            txtElement.BorderStyle = BorderStyle.FixedSingle;
            txtElement.ForeColor = Color.FromArgb(246, 240, 255);
            txtElement.Location = new Point(17, 175);
            txtElement.Name = "txtElement";
            txtElement.PlaceholderText = "e.g. Fire";
            txtElement.Size = new Size(190, 31);
            txtElement.TabIndex = 14;
            // 
            // lblDuration
            // 
            lblDuration.ForeColor = Color.FromArgb(185, 179, 206);
            lblDuration.Location = new Point(245, 145);
            lblDuration.Name = "lblDuration";
            lblDuration.Size = new Size(190, 25);
            lblDuration.TabIndex = 17;
            lblDuration.Text = "Brewing Duration";
            // 
            // nudDuration
            // 
            nudDuration.BackColor = Color.FromArgb(25, 24, 39);
            nudDuration.BorderStyle = BorderStyle.FixedSingle;
            nudDuration.ForeColor = Color.FromArgb(246, 240, 255);
            nudDuration.Location = new Point(245, 175);
            nudDuration.Maximum = new decimal(new int[] { 3600, 0, 0, 0 });
            nudDuration.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudDuration.Name = "nudDuration";
            nudDuration.Size = new Size(190, 31);
            nudDuration.TabIndex = 16;
            nudDuration.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // divider
            // 
            divider.BorderStyle = BorderStyle.FixedSingle;
            divider.Location = new Point(10, 235);
            divider.Name = "divider";
            divider.Size = new Size(667, 2);
            divider.TabIndex = 18;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(246, 240, 255);
            label3.Location = new Point(17, 253);
            label3.Name = "label3";
            label3.Size = new Size(350, 35);
            label3.TabIndex = 19;
            label3.Text = "Required Ingredients";
            // 
            // cmbIngredient
            // 
            cmbIngredient.BackColor = Color.FromArgb(25, 24, 39);
            cmbIngredient.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbIngredient.ForeColor = Color.FromArgb(246, 240, 255);
            cmbIngredient.FormattingEnabled = true;
            cmbIngredient.Location = new Point(25, 302);
            cmbIngredient.Name = "cmbIngredient";
            cmbIngredient.Size = new Size(250, 33);
            cmbIngredient.TabIndex = 20;
            // 
            // nudQuantity
            // 
            nudQuantity.BackColor = Color.FromArgb(25, 24, 39);
            nudQuantity.BorderStyle = BorderStyle.FixedSingle;
            nudQuantity.ForeColor = Color.FromArgb(246, 240, 255);
            nudQuantity.Location = new Point(296, 304);
            nudQuantity.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(225, 31);
            nudQuantity.TabIndex = 21;
            nudQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAddIngredientToRecipe
            // 
            btnAddIngredientToRecipe.AutoSize = true;
            btnAddIngredientToRecipe.BackColor = Color.FromArgb(128, 90, 202);
            btnAddIngredientToRecipe.FlatAppearance.BorderSize = 0;
            btnAddIngredientToRecipe.FlatStyle = FlatStyle.Flat;
            btnAddIngredientToRecipe.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnAddIngredientToRecipe.ForeColor = Color.White;
            btnAddIngredientToRecipe.Location = new Point(527, 296);
            btnAddIngredientToRecipe.Name = "btnAddIngredientToRecipe";
            btnAddIngredientToRecipe.Size = new Size(115, 40);
            btnAddIngredientToRecipe.TabIndex = 22;
            btnAddIngredientToRecipe.Text = "+ Add";
            btnAddIngredientToRecipe.UseVisualStyleBackColor = false;
            // 
            // dgvRecipeIngredients
            // 
            dgvRecipeIngredients.AllowUserToAddRows = false;
            dgvRecipeIngredients.BackgroundColor = Color.FromArgb(41, 38, 60);
            dgvRecipeIngredients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecipeIngredients.Columns.AddRange(new DataGridViewColumn[] { colIngredientName, colRequiredQuantity, colIngredientUnit });
            dgvRecipeIngredients.Location = new Point(25, 357);
            dgvRecipeIngredients.Name = "dgvRecipeIngredients";
            dgvRecipeIngredients.ReadOnly = true;
            dgvRecipeIngredients.RowHeadersWidth = 62;
            dgvRecipeIngredients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecipeIngredients.Size = new Size(521, 251);
            dgvRecipeIngredients.TabIndex = 23;
            // 
            // btnRemoveIngredientFromRecipe
            // 
            btnRemoveIngredientFromRecipe.AutoSize = true;
            btnRemoveIngredientFromRecipe.BackColor = Color.FromArgb(128, 90, 202);
            btnRemoveIngredientFromRecipe.FlatAppearance.BorderSize = 0;
            btnRemoveIngredientFromRecipe.FlatStyle = FlatStyle.Flat;
            btnRemoveIngredientFromRecipe.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnRemoveIngredientFromRecipe.ForeColor = Color.White;
            btnRemoveIngredientFromRecipe.Location = new Point(25, 627);
            btnRemoveIngredientFromRecipe.Name = "btnRemoveIngredientFromRecipe";
            btnRemoveIngredientFromRecipe.Size = new Size(196, 40);
            btnRemoveIngredientFromRecipe.TabIndex = 24;
            btnRemoveIngredientFromRecipe.Text = "Remove Ingredient";
            btnRemoveIngredientFromRecipe.UseVisualStyleBackColor = false;
            // 
            // btnClearRecipe
            // 
            btnClearRecipe.BackColor = Color.FromArgb(55, 51, 72);
            btnClearRecipe.FlatAppearance.BorderSize = 0;
            btnClearRecipe.FlatStyle = FlatStyle.Flat;
            btnClearRecipe.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnClearRecipe.ForeColor = Color.White;
            btnClearRecipe.Location = new Point(431, 695);
            btnClearRecipe.Name = "btnClearRecipe";
            btnClearRecipe.Size = new Size(115, 40);
            btnClearRecipe.TabIndex = 28;
            btnClearRecipe.Text = "Clear";
            btnClearRecipe.UseVisualStyleBackColor = false;
            // 
            // btnRetireRecipe
            // 
            btnRetireRecipe.BackColor = Color.FromArgb(73, 48, 68);
            btnRetireRecipe.Enabled = false;
            btnRetireRecipe.FlatAppearance.BorderSize = 0;
            btnRetireRecipe.FlatStyle = FlatStyle.Flat;
            btnRetireRecipe.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnRetireRecipe.ForeColor = Color.White;
            btnRetireRecipe.Location = new Point(296, 695);
            btnRetireRecipe.Name = "btnRetireRecipe";
            btnRetireRecipe.Size = new Size(115, 40);
            btnRetireRecipe.TabIndex = 27;
            btnRetireRecipe.Text = "Retire";
            btnRetireRecipe.UseVisualStyleBackColor = false;
            // 
            // btnUpdateRecipe
            // 
            btnUpdateRecipe.BackColor = Color.FromArgb(81, 65, 123);
            btnUpdateRecipe.Enabled = false;
            btnUpdateRecipe.FlatAppearance.BorderSize = 0;
            btnUpdateRecipe.FlatStyle = FlatStyle.Flat;
            btnUpdateRecipe.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnUpdateRecipe.ForeColor = Color.White;
            btnUpdateRecipe.Location = new Point(160, 695);
            btnUpdateRecipe.Name = "btnUpdateRecipe";
            btnUpdateRecipe.Size = new Size(115, 40);
            btnUpdateRecipe.TabIndex = 26;
            btnUpdateRecipe.Text = "Update";
            btnUpdateRecipe.UseVisualStyleBackColor = false;
            // 
            // btnAddRecipe
            // 
            btnAddRecipe.AutoSize = true;
            btnAddRecipe.BackColor = Color.FromArgb(128, 90, 202);
            btnAddRecipe.FlatAppearance.BorderSize = 0;
            btnAddRecipe.FlatStyle = FlatStyle.Flat;
            btnAddRecipe.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnAddRecipe.ForeColor = Color.White;
            btnAddRecipe.Location = new Point(25, 695);
            btnAddRecipe.Name = "btnAddRecipe";
            btnAddRecipe.Size = new Size(115, 40);
            btnAddRecipe.TabIndex = 25;
            btnAddRecipe.Text = "Create";
            btnAddRecipe.UseVisualStyleBackColor = false;
            // 
            // ID
            // 
            ID.DataPropertyName = "Id";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 8;
            ID.Name = "ID";
            ID.Visible = false;
            ID.Width = 150;
            // 
            // colRecipeName
            // 
            colRecipeName.DataPropertyName = "Name";
            colRecipeName.HeaderText = "Recipe";
            colRecipeName.MinimumWidth = 8;
            colRecipeName.Name = "colRecipeName";
            colRecipeName.Width = 150;
            // 
            // colEffect
            // 
            colEffect.DataPropertyName = "Effect";
            colEffect.HeaderText = "Effect";
            colEffect.MinimumWidth = 8;
            colEffect.Name = "colEffect";
            colEffect.Width = 150;
            // 
            // colElement
            // 
            colElement.DataPropertyName = "Element";
            colElement.HeaderText = "Element";
            colElement.MinimumWidth = 8;
            colElement.Name = "colElement";
            colElement.Width = 150;
            // 
            // colDuration
            // 
            colDuration.DataPropertyName = "DurationSeconds";
            colDuration.HeaderText = "Duration";
            colDuration.MinimumWidth = 8;
            colDuration.Name = "colDuration";
            colDuration.Width = 150;
            // 
            // colRecipeStatus
            // 
            colRecipeStatus.DataPropertyName = "IsActive";
            colRecipeStatus.HeaderText = "Status";
            colRecipeStatus.MinimumWidth = 8;
            colRecipeStatus.Name = "colRecipeStatus";
            colRecipeStatus.Width = 150;
            // 
            // colIngredientName
            // 
            colIngredientName.DataPropertyName = "IngredientName";
            colIngredientName.HeaderText = "Ingredient";
            colIngredientName.MinimumWidth = 8;
            colIngredientName.Name = "colIngredientName";
            colIngredientName.Width = 150;
            // 
            // colRequiredQuantity
            // 
            colRequiredQuantity.DataPropertyName = "QuantityRequired";
            colRequiredQuantity.HeaderText = "Quantity";
            colRequiredQuantity.MinimumWidth = 8;
            colRequiredQuantity.Name = "colRequiredQuantity";
            colRequiredQuantity.Width = 150;
            // 
            // colIngredientUnit
            // 
            colIngredientUnit.DataPropertyName = "Unit";
            colIngredientUnit.HeaderText = "Unit";
            colIngredientUnit.MinimumWidth = 8;
            colIngredientUnit.Name = "colIngredientUnit";
            colIngredientUnit.Width = 150;
            // 
            // RecipesForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(25, 24, 39);
            ClientSize = new Size(961, 1200);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(dgvRecipes);
            Controls.Add(lblSubtitle);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RecipesForm";
            Text = "RecipesForm";
            ((System.ComponentModel.ISupportInitialize)dgvRecipes).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudDuration).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRecipeIngredients).EndInit();
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