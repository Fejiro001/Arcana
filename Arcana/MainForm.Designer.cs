namespace Arcana
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
            tblMainLayout = new TableLayoutPanel();
            pnlSidebar = new Panel();
            btnReports = new Button();
            btnPotions = new Button();
            btnBrewing = new Button();
            btnRecipes = new Button();
            btnIngredients = new Button();
            btnDashboard = new Button();
            lblSubtitle = new Label();
            lblLogo = new Label();
            pnlContent = new Panel();
            pnlRecentActivity = new Panel();
            lblRecentActivityEmpty = new Label();
            lblRecentActivityTitle = new Label();
            pnlBrewingStation = new Panel();
            btnStartBrewing = new Button();
            lblBrewingDescription = new Label();
            lblBrewingTitle = new Label();
            pnlPotionCard = new Panel();
            lblPotionTitle = new Label();
            lblPotionCount = new Label();
            pnlRecipeCard = new Panel();
            lblRecipeTitle = new Label();
            lblRecipeCount = new Label();
            pnlIngredientCard = new Panel();
            lblIngredientTitle = new Label();
            lblIngredientCount = new Label();
            lblPageSubtitle = new Label();
            lblPageTitle = new Label();
            tblMainLayout.SuspendLayout();
            pnlSidebar.SuspendLayout();
            pnlContent.SuspendLayout();
            pnlRecentActivity.SuspendLayout();
            pnlBrewingStation.SuspendLayout();
            pnlPotionCard.SuspendLayout();
            pnlRecipeCard.SuspendLayout();
            pnlIngredientCard.SuspendLayout();
            SuspendLayout();
            // 
            // tblMainLayout
            // 
            tblMainLayout.ColumnCount = 2;
            tblMainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 220F));
            tblMainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMainLayout.Controls.Add(pnlSidebar, 0, 0);
            tblMainLayout.Controls.Add(pnlContent, 1, 0);
            tblMainLayout.Dock = DockStyle.Fill;
            tblMainLayout.Location = new Point(0, 0);
            tblMainLayout.Margin = new Padding(0);
            tblMainLayout.Name = "tblMainLayout";
            tblMainLayout.RowCount = 1;
            tblMainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblMainLayout.Size = new Size(1178, 704);
            tblMainLayout.TabIndex = 0;
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(36, 34, 53);
            pnlSidebar.Controls.Add(btnReports);
            pnlSidebar.Controls.Add(btnPotions);
            pnlSidebar.Controls.Add(btnBrewing);
            pnlSidebar.Controls.Add(btnRecipes);
            pnlSidebar.Controls.Add(btnIngredients);
            pnlSidebar.Controls.Add(btnDashboard);
            pnlSidebar.Controls.Add(lblSubtitle);
            pnlSidebar.Controls.Add(lblLogo);
            pnlSidebar.Dock = DockStyle.Fill;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Margin = new Padding(0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(220, 704);
            pnlSidebar.TabIndex = 0;
            // 
            // btnReports
            // 
            btnReports.BackColor = Color.FromArgb(41, 38, 60);
            btnReports.Cursor = Cursors.Hand;
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.ForeColor = Color.FromArgb(246, 240, 255);
            btnReports.Location = new Point(20, 415);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(180, 45);
            btnReports.TabIndex = 7;
            btnReports.Text = "Reports";
            btnReports.TextAlign = ContentAlignment.MiddleLeft;
            btnReports.UseVisualStyleBackColor = false;
            btnReports.Click += btnReports_Click;
            // 
            // btnPotions
            // 
            btnPotions.BackColor = Color.FromArgb(41, 38, 60);
            btnPotions.Cursor = Cursors.Hand;
            btnPotions.FlatAppearance.BorderSize = 0;
            btnPotions.FlatStyle = FlatStyle.Flat;
            btnPotions.ForeColor = Color.FromArgb(246, 240, 255);
            btnPotions.Location = new Point(20, 360);
            btnPotions.Name = "btnPotions";
            btnPotions.Size = new Size(180, 45);
            btnPotions.TabIndex = 6;
            btnPotions.Text = "My Potions";
            btnPotions.TextAlign = ContentAlignment.MiddleLeft;
            btnPotions.UseVisualStyleBackColor = false;
            btnPotions.Click += btnPotions_Click;
            // 
            // btnBrewing
            // 
            btnBrewing.BackColor = Color.FromArgb(41, 38, 60);
            btnBrewing.Cursor = Cursors.Hand;
            btnBrewing.FlatAppearance.BorderSize = 0;
            btnBrewing.FlatStyle = FlatStyle.Flat;
            btnBrewing.ForeColor = Color.FromArgb(246, 240, 255);
            btnBrewing.Location = new Point(20, 305);
            btnBrewing.Name = "btnBrewing";
            btnBrewing.Size = new Size(180, 45);
            btnBrewing.TabIndex = 5;
            btnBrewing.Text = "Brewing Station";
            btnBrewing.TextAlign = ContentAlignment.MiddleLeft;
            btnBrewing.UseVisualStyleBackColor = false;
            btnBrewing.Click += btnBrewing_Click;
            // 
            // btnRecipes
            // 
            btnRecipes.BackColor = Color.FromArgb(41, 38, 60);
            btnRecipes.Cursor = Cursors.Hand;
            btnRecipes.FlatAppearance.BorderSize = 0;
            btnRecipes.FlatStyle = FlatStyle.Flat;
            btnRecipes.ForeColor = Color.FromArgb(246, 240, 255);
            btnRecipes.Location = new Point(20, 250);
            btnRecipes.Name = "btnRecipes";
            btnRecipes.Size = new Size(180, 45);
            btnRecipes.TabIndex = 4;
            btnRecipes.Text = "Recipes";
            btnRecipes.TextAlign = ContentAlignment.MiddleLeft;
            btnRecipes.UseVisualStyleBackColor = false;
            btnRecipes.Click += btnRecipes_Click;
            // 
            // btnIngredients
            // 
            btnIngredients.BackColor = Color.FromArgb(41, 38, 60);
            btnIngredients.Cursor = Cursors.Hand;
            btnIngredients.FlatAppearance.BorderSize = 0;
            btnIngredients.FlatStyle = FlatStyle.Flat;
            btnIngredients.ForeColor = Color.FromArgb(246, 240, 255);
            btnIngredients.Location = new Point(20, 195);
            btnIngredients.Name = "btnIngredients";
            btnIngredients.Size = new Size(180, 45);
            btnIngredients.TabIndex = 3;
            btnIngredients.Text = "Ingredients";
            btnIngredients.TextAlign = ContentAlignment.MiddleLeft;
            btnIngredients.UseVisualStyleBackColor = false;
            btnIngredients.Click += btnIngredients_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(41, 38, 60);
            btnDashboard.Cursor = Cursors.Hand;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.ForeColor = Color.FromArgb(246, 240, 255);
            btnDashboard.Location = new Point(20, 140);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(180, 45);
            btnDashboard.TabIndex = 2;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitle.ForeColor = Color.FromArgb(185, 179, 206);
            lblSubtitle.Location = new Point(20, 75);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(195, 21);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "ALCHEMIST'S WORKSHOP";
            // 
            // lblLogo
            // 
            lblLogo.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogo.ForeColor = Color.FromArgb(167, 139, 250);
            lblLogo.Location = new Point(15, 30);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(195, 45);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "✦ ARCANA";
            // 
            // pnlContent
            // 
            pnlContent.AutoScroll = true;
            pnlContent.Controls.Add(pnlRecentActivity);
            pnlContent.Controls.Add(pnlBrewingStation);
            pnlContent.Controls.Add(pnlPotionCard);
            pnlContent.Controls.Add(pnlRecipeCard);
            pnlContent.Controls.Add(pnlIngredientCard);
            pnlContent.Controls.Add(lblPageSubtitle);
            pnlContent.Controls.Add(lblPageTitle);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnlContent.Location = new Point(220, 0);
            pnlContent.Margin = new Padding(0);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(958, 704);
            pnlContent.TabIndex = 1;
            // 
            // pnlRecentActivity
            // 
            pnlRecentActivity.BackColor = Color.FromArgb(41, 38, 60);
            pnlRecentActivity.Controls.Add(lblRecentActivityEmpty);
            pnlRecentActivity.Controls.Add(lblRecentActivityTitle);
            pnlRecentActivity.Location = new Point(30, 480);
            pnlRecentActivity.Name = "pnlRecentActivity";
            pnlRecentActivity.Size = new Size(820, 160);
            pnlRecentActivity.TabIndex = 6;
            // 
            // lblRecentActivityEmpty
            // 
            lblRecentActivityEmpty.AutoSize = true;
            lblRecentActivityEmpty.ForeColor = Color.FromArgb(185, 179, 206);
            lblRecentActivityEmpty.Location = new Point(20, 85);
            lblRecentActivityEmpty.Name = "lblRecentActivityEmpty";
            lblRecentActivityEmpty.Size = new Size(264, 32);
            lblRecentActivityEmpty.TabIndex = 1;
            lblRecentActivityEmpty.Text = "No potions brewed yet.";
            // 
            // lblRecentActivityTitle
            // 
            lblRecentActivityTitle.AutoSize = true;
            lblRecentActivityTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecentActivityTitle.ForeColor = Color.FromArgb(246, 240, 255);
            lblRecentActivityTitle.Location = new Point(20, 15);
            lblRecentActivityTitle.Name = "lblRecentActivityTitle";
            lblRecentActivityTitle.Size = new Size(377, 45);
            lblRecentActivityTitle.TabIndex = 0;
            lblRecentActivityTitle.Text = "Recent Brewing Activity";
            // 
            // pnlBrewingStation
            // 
            pnlBrewingStation.BackColor = Color.FromArgb(41, 38, 60);
            pnlBrewingStation.Controls.Add(btnStartBrewing);
            pnlBrewingStation.Controls.Add(lblBrewingDescription);
            pnlBrewingStation.Controls.Add(lblBrewingTitle);
            pnlBrewingStation.Location = new Point(30, 280);
            pnlBrewingStation.Name = "pnlBrewingStation";
            pnlBrewingStation.Size = new Size(820, 180);
            pnlBrewingStation.TabIndex = 5;
            // 
            // btnStartBrewing
            // 
            btnStartBrewing.BackColor = Color.FromArgb(128, 90, 202);
            btnStartBrewing.FlatAppearance.BorderSize = 0;
            btnStartBrewing.FlatStyle = FlatStyle.Flat;
            btnStartBrewing.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStartBrewing.ForeColor = Color.White;
            btnStartBrewing.Location = new Point(20, 120);
            btnStartBrewing.Name = "btnStartBrewing";
            btnStartBrewing.Size = new Size(160, 40);
            btnStartBrewing.TabIndex = 2;
            btnStartBrewing.Text = "Brew a Potion";
            btnStartBrewing.UseVisualStyleBackColor = false;
            btnStartBrewing.Click += btnStartBrewing_Click;
            // 
            // lblBrewingDescription
            // 
            lblBrewingDescription.AutoSize = true;
            lblBrewingDescription.ForeColor = Color.FromArgb(185, 179, 206);
            lblBrewingDescription.Location = new Point(20, 75);
            lblBrewingDescription.Name = "lblBrewingDescription";
            lblBrewingDescription.Size = new Size(579, 32);
            lblBrewingDescription.TabIndex = 1;
            lblBrewingDescription.Text = "Select a recipe and begin your next magical creation.";
            // 
            // lblBrewingTitle
            // 
            lblBrewingTitle.AutoSize = true;
            lblBrewingTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBrewingTitle.ForeColor = Color.FromArgb(246, 240, 255);
            lblBrewingTitle.Location = new Point(20, 15);
            lblBrewingTitle.Name = "lblBrewingTitle";
            lblBrewingTitle.Size = new Size(260, 45);
            lblBrewingTitle.TabIndex = 0;
            lblBrewingTitle.Text = "Brewing Station";
            // 
            // pnlPotionCard
            // 
            pnlPotionCard.BackColor = Color.FromArgb(41, 38, 60);
            pnlPotionCard.Controls.Add(lblPotionTitle);
            pnlPotionCard.Controls.Add(lblPotionCount);
            pnlPotionCard.Location = new Point(590, 125);
            pnlPotionCard.Name = "pnlPotionCard";
            pnlPotionCard.Size = new Size(260, 125);
            pnlPotionCard.TabIndex = 4;
            // 
            // lblPotionTitle
            // 
            lblPotionTitle.AutoSize = true;
            lblPotionTitle.ForeColor = Color.FromArgb(185, 179, 206);
            lblPotionTitle.Location = new Point(20, 85);
            lblPotionTitle.Name = "lblPotionTitle";
            lblPotionTitle.Size = new Size(178, 32);
            lblPotionTitle.TabIndex = 1;
            lblPotionTitle.Text = "Brewed Potions";
            // 
            // lblPotionCount
            // 
            lblPotionCount.AutoSize = true;
            lblPotionCount.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            lblPotionCount.ForeColor = Color.FromArgb(167, 139, 250);
            lblPotionCount.Location = new Point(20, 15);
            lblPotionCount.Name = "lblPotionCount";
            lblPotionCount.Size = new Size(60, 70);
            lblPotionCount.TabIndex = 0;
            lblPotionCount.Text = "0";
            // 
            // pnlRecipeCard
            // 
            pnlRecipeCard.BackColor = Color.FromArgb(41, 38, 60);
            pnlRecipeCard.Controls.Add(lblRecipeTitle);
            pnlRecipeCard.Controls.Add(lblRecipeCount);
            pnlRecipeCard.Location = new Point(310, 125);
            pnlRecipeCard.Name = "pnlRecipeCard";
            pnlRecipeCard.Size = new Size(260, 125);
            pnlRecipeCard.TabIndex = 3;
            // 
            // lblRecipeTitle
            // 
            lblRecipeTitle.AutoSize = true;
            lblRecipeTitle.ForeColor = Color.FromArgb(185, 179, 206);
            lblRecipeTitle.Location = new Point(20, 85);
            lblRecipeTitle.Name = "lblRecipeTitle";
            lblRecipeTitle.Size = new Size(197, 32);
            lblRecipeTitle.TabIndex = 1;
            lblRecipeTitle.Text = "Available Recipes";
            // 
            // lblRecipeCount
            // 
            lblRecipeCount.AutoSize = true;
            lblRecipeCount.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            lblRecipeCount.ForeColor = Color.FromArgb(167, 139, 250);
            lblRecipeCount.Location = new Point(20, 15);
            lblRecipeCount.Name = "lblRecipeCount";
            lblRecipeCount.Size = new Size(60, 70);
            lblRecipeCount.TabIndex = 0;
            lblRecipeCount.Text = "0";
            // 
            // pnlIngredientCard
            // 
            pnlIngredientCard.BackColor = Color.FromArgb(41, 38, 60);
            pnlIngredientCard.Controls.Add(lblIngredientTitle);
            pnlIngredientCard.Controls.Add(lblIngredientCount);
            pnlIngredientCard.Location = new Point(30, 125);
            pnlIngredientCard.Name = "pnlIngredientCard";
            pnlIngredientCard.Size = new Size(260, 125);
            pnlIngredientCard.TabIndex = 2;
            // 
            // lblIngredientTitle
            // 
            lblIngredientTitle.AutoSize = true;
            lblIngredientTitle.ForeColor = Color.FromArgb(185, 179, 206);
            lblIngredientTitle.Location = new Point(20, 85);
            lblIngredientTitle.Name = "lblIngredientTitle";
            lblIngredientTitle.Size = new Size(134, 32);
            lblIngredientTitle.TabIndex = 1;
            lblIngredientTitle.Text = "Ingredients";
            // 
            // lblIngredientCount
            // 
            lblIngredientCount.AutoSize = true;
            lblIngredientCount.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            lblIngredientCount.ForeColor = Color.FromArgb(167, 139, 250);
            lblIngredientCount.Location = new Point(20, 15);
            lblIngredientCount.Name = "lblIngredientCount";
            lblIngredientCount.Size = new Size(60, 70);
            lblIngredientCount.TabIndex = 0;
            lblIngredientCount.Text = "0";
            // 
            // lblPageSubtitle
            // 
            lblPageSubtitle.AutoSize = true;
            lblPageSubtitle.ForeColor = Color.FromArgb(185, 179, 206);
            lblPageSubtitle.Location = new Point(32, 80);
            lblPageSubtitle.Name = "lblPageSubtitle";
            lblPageSubtitle.Size = new Size(299, 32);
            lblPageSubtitle.TabIndex = 1;
            lblPageSubtitle.Text = "Your laboratory at a glance";
            // 
            // lblPageTitle
            // 
            lblPageTitle.AutoSize = true;
            lblPageTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPageTitle.ForeColor = Color.FromArgb(246, 240, 255);
            lblPageTitle.Location = new Point(30, 25);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(446, 60);
            lblPageTitle.TabIndex = 0;
            lblPageTitle.Text = "Workshop Overview";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 24, 39);
            ClientSize = new Size(1178, 704);
            Controls.Add(tblMainLayout);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MinimumSize = new Size(1050, 680);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Arcana - The Alchemist's Workshop";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            tblMainLayout.ResumeLayout(false);
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            pnlContent.ResumeLayout(false);
            pnlContent.PerformLayout();
            pnlRecentActivity.ResumeLayout(false);
            pnlRecentActivity.PerformLayout();
            pnlBrewingStation.ResumeLayout(false);
            pnlBrewingStation.PerformLayout();
            pnlPotionCard.ResumeLayout(false);
            pnlPotionCard.PerformLayout();
            pnlRecipeCard.ResumeLayout(false);
            pnlRecipeCard.PerformLayout();
            pnlIngredientCard.ResumeLayout(false);
            pnlIngredientCard.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMainLayout;
        private Panel pnlSidebar;
        private Panel pnlContent;
        private Label lblLogo;
        private Label lblSubtitle;
        private Button btnDashboard;
        private Button btnIngredients;
        private Button btnRecipes;
        private Button btnBrewing;
        private Button btnPotions;
        private Button btnReports;
        private Label lblPageTitle;
        private Label lblPageSubtitle;
        private Panel pnlIngredientCard;
        private Panel pnlRecipeCard;
        private Panel pnlPotionCard;
        private Label lblIngredientCount;
        private Label lblIngredientTitle;
        private Label lblRecipeCount;
        private Label lblRecipeTitle;
        private Label lblPotionCount;
        private Label lblPotionTitle;
        private Panel pnlBrewingStation;
        private Label lblBrewingTitle;
        private Label lblBrewingDescription;
        private Panel pnlRecentActivity;
        private Label lblRecentActivityTitle;
        private Label lblRecentActivityEmpty;
        private Button btnStartBrewing;
    }
}
