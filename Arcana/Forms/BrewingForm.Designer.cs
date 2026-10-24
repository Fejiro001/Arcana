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
            label6 = new Label();
            lstRequirements = new ListBox();
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
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            panel1.Controls.Add(label6);
            panel1.Controls.Add(lstRequirements);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(divider);
            panel1.Controls.Add(lblDuration);
            panel1.Controls.Add(lblBrewingRecipeElement);
            panel1.Controls.Add(lblBrewingRecipeEffect);
            panel1.Controls.Add(lblBrewingRecipeName);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cmbRecipes);
            panel1.Location = new Point(35, 129);
            panel1.Name = "panel1";
            panel1.Size = new Size(874, 864);
            panel1.TabIndex = 5;
            // 
            // btnBrew
            // 
            btnBrew.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnBrew.AutoSize = true;
            btnBrew.BackColor = Color.FromArgb(128, 90, 202);
            btnBrew.FlatAppearance.BorderSize = 0;
            btnBrew.FlatStyle = FlatStyle.Flat;
            btnBrew.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnBrew.ForeColor = Color.White;
            btnBrew.Location = new Point(33, 777);
            btnBrew.Name = "btnBrew";
            btnBrew.Size = new Size(794, 63);
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
            lblStatus.Location = new Point(33, 719);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(137, 28);
            lblStatus.TabIndex = 26;
            lblStatus.Text = "Select a recipe";
            // 
            // lblProgress
            // 
            lblProgress.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblProgress.AutoSize = true;
            lblProgress.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProgress.ForeColor = Color.FromArgb(196, 167, 255);
            lblProgress.Location = new Point(787, 613);
            lblProgress.Name = "lblProgress";
            lblProgress.Size = new Size(43, 30);
            lblProgress.TabIndex = 25;
            lblProgress.Text = "0%";
            // 
            // progressBarBrew
            // 
            progressBarBrew.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            progressBarBrew.BackColor = Color.FromArgb(25, 24, 39);
            progressBarBrew.Location = new Point(33, 656);
            progressBarBrew.Name = "progressBarBrew";
            progressBarBrew.Size = new Size(794, 38);
            progressBarBrew.TabIndex = 24;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(246, 240, 255);
            label7.Location = new Point(30, 604);
            label7.Name = "label7";
            label7.Size = new Size(385, 39);
            label7.TabIndex = 23;
            label7.Text = "Brewing Progress";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Location = new Point(25, 588);
            label6.Name = "label6";
            label6.Size = new Size(805, 2);
            label6.TabIndex = 22;
            // 
            // lstRequirements
            // 
            lstRequirements.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lstRequirements.BackColor = Color.FromArgb(25, 24, 39);
            lstRequirements.BorderStyle = BorderStyle.FixedSingle;
            lstRequirements.ForeColor = Color.White;
            lstRequirements.FormattingEnabled = true;
            lstRequirements.ItemHeight = 28;
            lstRequirements.Location = new Point(22, 379);
            lstRequirements.Name = "lstRequirements";
            lstRequirements.Size = new Size(805, 170);
            lstRequirements.TabIndex = 21;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(246, 240, 255);
            label4.Location = new Point(22, 319);
            label4.Name = "label4";
            label4.Size = new Size(385, 39);
            label4.TabIndex = 20;
            label4.Text = "Required Ingredients";
            // 
            // divider
            // 
            divider.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            divider.BorderStyle = BorderStyle.FixedSingle;
            divider.Location = new Point(22, 296);
            divider.Name = "divider";
            divider.Size = new Size(805, 2);
            divider.TabIndex = 19;
            // 
            // lblDuration
            // 
            lblDuration.AutoSize = true;
            lblDuration.ForeColor = Color.FromArgb(196, 167, 255);
            lblDuration.Location = new Point(185, 252);
            lblDuration.Name = "lblDuration";
            lblDuration.Size = new Size(89, 28);
            lblDuration.TabIndex = 16;
            lblDuration.Text = "Duration";
            // 
            // lblBrewingRecipeElement
            // 
            lblBrewingRecipeElement.AutoSize = true;
            lblBrewingRecipeElement.ForeColor = Color.FromArgb(185, 179, 206);
            lblBrewingRecipeElement.Location = new Point(185, 211);
            lblBrewingRecipeElement.Name = "lblBrewingRecipeElement";
            lblBrewingRecipeElement.Size = new Size(82, 28);
            lblBrewingRecipeElement.TabIndex = 13;
            lblBrewingRecipeElement.Text = "Element";
            // 
            // lblBrewingRecipeEffect
            // 
            lblBrewingRecipeEffect.AutoSize = true;
            lblBrewingRecipeEffect.ForeColor = Color.FromArgb(185, 179, 206);
            lblBrewingRecipeEffect.Location = new Point(185, 172);
            lblBrewingRecipeEffect.Name = "lblBrewingRecipeEffect";
            lblBrewingRecipeEffect.Size = new Size(60, 28);
            lblBrewingRecipeEffect.TabIndex = 12;
            lblBrewingRecipeEffect.Text = "Effect";
            // 
            // lblBrewingRecipeName
            // 
            lblBrewingRecipeName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBrewingRecipeName.ForeColor = Color.FromArgb(246, 240, 255);
            lblBrewingRecipeName.Location = new Point(179, 122);
            lblBrewingRecipeName.Name = "lblBrewingRecipeName";
            lblBrewingRecipeName.Size = new Size(385, 39);
            lblBrewingRecipeName.TabIndex = 3;
            lblBrewingRecipeName.Text = "Recipe Name";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(64, 51, 89);
            pictureBox1.ImageLocation = "C:\\Users\\abere\\Desktop\\source\\repos\\assignments\\Arcana\\Arcana\\Assets\\flask.png";
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(22, 138);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(126, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(196, 167, 255);
            label1.Location = new Point(22, 19);
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
            cmbRecipes.Location = new Point(22, 56);
            cmbRecipes.Name = "cmbRecipes";
            cmbRecipes.Size = new Size(805, 36);
            cmbRecipes.TabIndex = 0;
            cmbRecipes.SelectedIndexChanged += cmbRecipes_SelectedIndexChanged;
            // 
            // tmrBrew
            // 
            tmrBrew.Tick += tmrBrew_Tick;
            // 
            // BrewingForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(25, 24, 39);
            ClientSize = new Size(950, 1027);
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
        private ListBox lstRequirements;
        private Label label7;
        private Label label6;
        private ProgressBar progressBarBrew;
        private Label lblProgress;
        private Label lblStatus;
        private Button btnBrew;
        private System.Windows.Forms.Timer tmrBrew;
    }
}