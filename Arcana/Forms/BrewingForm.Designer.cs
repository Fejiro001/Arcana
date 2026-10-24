namespace Arcana.Forms
{
    partial class BrewingForm
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
            components = new System.ComponentModel.Container();
            lblSubtitle = new Label();
            lblTitle = new Label();
            panel1 = new Panel();
            btnBrew = new Button();
            lblStatus = new Label();
            lblProgress = new Label();
            progressBarBrew = new ProgressBar();
            label7 = new Label();
            label4 = new Label();
            divider = new Label();
            lblDuration = new Label();
            lblBrewingRecipeElement = new Label();
            lblBrewingRecipeEffect = new Label();
            lblBrewingRecipeName = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            cmbRecipes = new ComboBox();
            tmrBrew = new System.Windows.Forms.Timer(components);
            pnlRecipeSelector = new Panel();
            tblBrewDetails = new TableLayoutPanel();
            pnlRecipeDetails = new Panel();
            label8 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            pnlRequirements = new Panel();
            dgvRequirements = new DataGridView();
            colIngredient = new DataGridViewTextBoxColumn();
            colRequired = new DataGridViewTextBoxColumn();
            colAvailable = new DataGridViewTextBoxColumn();
            colAvailability = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlRecipeSelector.SuspendLayout();
            tblBrewDetails.SuspendLayout();
            pnlRecipeDetails.SuspendLayout();
            pnlRequirements.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRequirements).BeginInit();
            SuspendLayout();
            // 
            // lblSubtitle
            // 
            lblSubtitle.ForeColor = Color.FromArgb(185, 179, 206);
            lblSubtitle.Location = new Point(35, 84);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(660, 28);
            lblSubtitle.TabIndex = 4;
            lblSubtitle.Text = "Transform magical ingredients into powerful elixirs";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(246, 240, 255);
            lblTitle.Location = new Point(35, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(358, 60);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "Brewing Station";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(41, 38, 60);
            panel1.Controls.Add(btnBrew);
            panel1.Controls.Add(lblStatus);
            panel1.Controls.Add(lblProgress);
            panel1.Controls.Add(progressBarBrew);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(35, 629);
            panel1.Margin = new Padding(3, 3, 12, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(907, 170);
            panel1.TabIndex = 5;
            // 
            // btnBrew
            // 
            btnBrew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBrew.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnBrew.BackColor = Color.FromArgb(128, 90, 202);
            btnBrew.FlatAppearance.BorderSize = 0;
            btnBrew.FlatStyle = FlatStyle.Flat;
            btnBrew.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnBrew.ForeColor = Color.White;
            btnBrew.Location = new Point(677, 104);
            btnBrew.Name = "btnBrew";
            btnBrew.Size = new Size(170, 42);
            btnBrew.TabIndex = 27;
            btnBrew.Tag = "Primary";
            btnBrew.Text = "Start Brewing";
            btnBrew.UseVisualStyleBackColor = false;
            btnBrew.Click += btnBrew_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = Color.FromArgb(145, 199, 166);
            lblStatus.Location = new Point(23, 104);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(137, 28);
            lblStatus.TabIndex = 26;
            lblStatus.Text = "Select a recipe";
            // 
            // lblProgress
            // 
            lblProgress.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblProgress.AutoSize = true;
            lblProgress.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProgress.ForeColor = Color.FromArgb(196, 167, 255);
            lblProgress.Location = new Point(798, 18);
            lblProgress.Name = "lblProgress";
            lblProgress.Size = new Size(60, 41);
            lblProgress.TabIndex = 25;
            lblProgress.Text = "0%";
            // 
            // progressBarBrew
            // 
            progressBarBrew.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            progressBarBrew.BackColor = Color.FromArgb(25, 24, 39);
            progressBarBrew.Location = new Point(23, 65);
            progressBarBrew.Name = "progressBarBrew";
            progressBarBrew.Size = new Size(827, 22);
            progressBarBrew.Style = ProgressBarStyle.Continuous;
            progressBarBrew.TabIndex = 24;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(246, 240, 255);
            label7.Location = new Point(15, 23);
            label7.Name = "label7";
            label7.Size = new Size(385, 39);
            label7.TabIndex = 23;
            label7.Text = "Brewing Progress";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(246, 240, 255);
            label4.Location = new Point(20, 15);
            label4.Name = "label4";
            label4.Size = new Size(385, 39);
            label4.TabIndex = 20;
            label4.Text = "Required Ingredients";
            // 
            // divider
            // 
            divider.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            divider.BorderStyle = BorderStyle.FixedSingle;
            divider.Location = new Point(20, 60);
            divider.Name = "divider";
            divider.Size = new Size(500, 2);
            divider.TabIndex = 19;
            // 
            // lblDuration
            // 
            lblDuration.AutoSize = true;
            lblDuration.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDuration.ForeColor = Color.FromArgb(246, 240, 255);
            lblDuration.Location = new Point(23, 254);
            lblDuration.Name = "lblDuration";
            lblDuration.Size = new Size(35, 30);
            lblDuration.TabIndex = 16;
            lblDuration.Text = "—";
            // 
            // lblBrewingRecipeElement
            // 
            lblBrewingRecipeElement.AutoSize = true;
            lblBrewingRecipeElement.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBrewingRecipeElement.ForeColor = Color.FromArgb(246, 240, 255);
            lblBrewingRecipeElement.Location = new Point(20, 106);
            lblBrewingRecipeElement.Name = "lblBrewingRecipeElement";
            lblBrewingRecipeElement.Size = new Size(35, 30);
            lblBrewingRecipeElement.TabIndex = 13;
            lblBrewingRecipeElement.Text = "—";
            // 
            // lblBrewingRecipeEffect
            // 
            lblBrewingRecipeEffect.AutoSize = true;
            lblBrewingRecipeEffect.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBrewingRecipeEffect.ForeColor = Color.FromArgb(246, 240, 255);
            lblBrewingRecipeEffect.Location = new Point(20, 177);
            lblBrewingRecipeEffect.Name = "lblBrewingRecipeEffect";
            lblBrewingRecipeEffect.Size = new Size(35, 30);
            lblBrewingRecipeEffect.TabIndex = 12;
            lblBrewingRecipeEffect.Text = "—";
            // 
            // lblBrewingRecipeName
            // 
            lblBrewingRecipeName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblBrewingRecipeName.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBrewingRecipeName.ForeColor = Color.FromArgb(196, 167, 255);
            lblBrewingRecipeName.Location = new Point(86, 17);
            lblBrewingRecipeName.Name = "lblBrewingRecipeName";
            lblBrewingRecipeName.Size = new Size(261, 39);
            lblBrewingRecipeName.TabIndex = 3;
            lblBrewingRecipeName.Text = "Select a Recipe";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.ImageLocation = "C:\\Users\\abere\\Desktop\\source\\repos\\assignments\\Arcana\\Arcana\\Assets\\flask.png";
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(20, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(61, 43);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(196, 167, 255);
            label1.Location = new Point(20, 15);
            label1.Name = "label1";
            label1.Size = new Size(241, 30);
            label1.TabIndex = 1;
            label1.Text = "SELECT POTION RECIPE";
            // 
            // cmbRecipes
            // 
            cmbRecipes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbRecipes.BackColor = Color.FromArgb(25, 24, 39);
            cmbRecipes.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRecipes.FlatStyle = FlatStyle.Flat;
            cmbRecipes.FormattingEnabled = true;
            cmbRecipes.ItemHeight = 28;
            cmbRecipes.Location = new Point(20, 64);
            cmbRecipes.Name = "cmbRecipes";
            cmbRecipes.Size = new Size(838, 36);
            cmbRecipes.TabIndex = 0;
            cmbRecipes.SelectedIndexChanged += cmbRecipes_SelectedIndexChanged;
            // 
            // tmrBrew
            // 
            tmrBrew.Tick += tmrBrew_Tick;
            // 
            // pnlRecipeSelector
            // 
            pnlRecipeSelector.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlRecipeSelector.BackColor = Color.FromArgb(41, 38, 60);
            pnlRecipeSelector.Controls.Add(label1);
            pnlRecipeSelector.Controls.Add(cmbRecipes);
            pnlRecipeSelector.Location = new Point(35, 135);
            pnlRecipeSelector.Margin = new Padding(3, 3, 12, 3);
            pnlRecipeSelector.Name = "pnlRecipeSelector";
            pnlRecipeSelector.Size = new Size(907, 135);
            pnlRecipeSelector.TabIndex = 28;
            // 
            // tblBrewDetails
            // 
            tblBrewDetails.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tblBrewDetails.ColumnCount = 2;
            tblBrewDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tblBrewDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tblBrewDetails.Controls.Add(pnlRecipeDetails, 0, 0);
            tblBrewDetails.Controls.Add(pnlRequirements, 1, 0);
            tblBrewDetails.Location = new Point(35, 300);
            tblBrewDetails.Margin = new Padding(3, 3, 12, 3);
            tblBrewDetails.Name = "tblBrewDetails";
            tblBrewDetails.RowCount = 1;
            tblBrewDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblBrewDetails.Size = new Size(907, 309);
            tblBrewDetails.TabIndex = 29;
            // 
            // pnlRecipeDetails
            // 
            pnlRecipeDetails.BackColor = Color.FromArgb(41, 38, 60);
            pnlRecipeDetails.Controls.Add(label8);
            pnlRecipeDetails.Controls.Add(label5);
            pnlRecipeDetails.Controls.Add(label3);
            pnlRecipeDetails.Controls.Add(label2);
            pnlRecipeDetails.Controls.Add(pictureBox1);
            pnlRecipeDetails.Controls.Add(lblBrewingRecipeName);
            pnlRecipeDetails.Controls.Add(lblBrewingRecipeEffect);
            pnlRecipeDetails.Controls.Add(lblBrewingRecipeElement);
            pnlRecipeDetails.Controls.Add(lblDuration);
            pnlRecipeDetails.Dock = DockStyle.Fill;
            pnlRecipeDetails.Location = new Point(0, 0);
            pnlRecipeDetails.Margin = new Padding(0, 0, 12, 0);
            pnlRecipeDetails.Name = "pnlRecipeDetails";
            pnlRecipeDetails.Size = new Size(350, 309);
            pnlRecipeDetails.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.FromArgb(185, 179, 206);
            label8.Location = new Point(23, 226);
            label8.Name = "label8";
            label8.Size = new Size(146, 28);
            label8.TabIndex = 31;
            label8.Text = "BREWING TIME";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(185, 179, 206);
            label5.Location = new Point(23, 149);
            label5.Name = "label5";
            label5.Size = new Size(150, 28);
            label5.TabIndex = 30;
            label5.Text = "SPECIAL EFFECT";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(185, 179, 206);
            label3.Location = new Point(20, 78);
            label3.Name = "label3";
            label3.Size = new Size(94, 28);
            label3.TabIndex = 29;
            label3.Text = "ELEMENT";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Location = new Point(15, 66);
            label2.Name = "label2";
            label2.Size = new Size(309, 2);
            label2.TabIndex = 28;
            // 
            // pnlRequirements
            // 
            pnlRequirements.BackColor = Color.FromArgb(41, 38, 60);
            pnlRequirements.Controls.Add(dgvRequirements);
            pnlRequirements.Controls.Add(label4);
            pnlRequirements.Controls.Add(divider);
            pnlRequirements.Dock = DockStyle.Fill;
            pnlRequirements.Location = new Point(362, 0);
            pnlRequirements.Margin = new Padding(0);
            pnlRequirements.Name = "pnlRequirements";
            pnlRequirements.Size = new Size(545, 309);
            pnlRequirements.TabIndex = 1;
            // 
            // dgvRequirements
            // 
            dgvRequirements.AllowUserToAddRows = false;
            dgvRequirements.AllowUserToDeleteRows = false;
            dgvRequirements.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvRequirements.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRequirements.BackgroundColor = Color.FromArgb(41, 38, 60);
            dgvRequirements.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRequirements.Columns.AddRange(new DataGridViewColumn[] { colIngredient, colRequired, colAvailable, colAvailability });
            dgvRequirements.Location = new Point(20, 78);
            dgvRequirements.Name = "dgvRequirements";
            dgvRequirements.ReadOnly = true;
            dgvRequirements.RowHeadersVisible = false;
            dgvRequirements.RowHeadersWidth = 62;
            dgvRequirements.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRequirements.Size = new Size(505, 175);
            dgvRequirements.TabIndex = 21;
            // 
            // colIngredient
            // 
            colIngredient.HeaderText = "Ingredient";
            colIngredient.MinimumWidth = 8;
            colIngredient.Name = "colIngredient";
            colIngredient.ReadOnly = true;
            // 
            // colRequired
            // 
            colRequired.HeaderText = "Required";
            colRequired.MinimumWidth = 8;
            colRequired.Name = "colRequired";
            colRequired.ReadOnly = true;
            // 
            // colAvailable
            // 
            colAvailable.HeaderText = "Available";
            colAvailable.MinimumWidth = 8;
            colAvailable.Name = "colAvailable";
            colAvailable.ReadOnly = true;
            // 
            // colAvailability
            // 
            colAvailability.HeaderText = "Status";
            colAvailability.MinimumWidth = 8;
            colAvailability.Name = "colAvailability";
            colAvailability.ReadOnly = true;
            // 
            // BrewingForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(25, 24, 39);
            ClientSize = new Size(950, 825);
            Controls.Add(tblBrewDetails);
            Controls.Add(pnlRecipeSelector);
            Controls.Add(panel1);
            Controls.Add(lblSubtitle);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BrewingForm";
            Text = "BrewingForm";
            Load += BrewingForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlRecipeSelector.ResumeLayout(false);
            pnlRecipeSelector.PerformLayout();
            tblBrewDetails.ResumeLayout(false);
            pnlRecipeDetails.ResumeLayout(false);
            pnlRecipeDetails.PerformLayout();
            pnlRequirements.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRequirements).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSubtitle;
        private Label lblTitle;
        private Panel panel1;
        private ComboBox cmbRecipes;
        private Label label1;
        private PictureBox pictureBox1;
        private Label lblBrewingRecipeName;
        private Label lblBrewingRecipeEffect;
        private Label lblBrewingRecipeElement;
        private Label lblDuration;
        private Label divider;
        private Label label4;
        private Label label7;
        private ProgressBar progressBarBrew;
        private Label lblProgress;
        private Label lblStatus;
        private Button btnBrew;
        private System.Windows.Forms.Timer tmrBrew;
        private Panel pnlRecipeSelector;
        private TableLayoutPanel tblBrewDetails;
        private Panel pnlRecipeDetails;
        private Panel pnlRequirements;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label8;
        private DataGridView dgvRequirements;
        private DataGridViewTextBoxColumn colIngredient;
        private DataGridViewTextBoxColumn colRequired;
        private DataGridViewTextBoxColumn colAvailable;
        private DataGridViewTextBoxColumn colAvailability;
    }
}