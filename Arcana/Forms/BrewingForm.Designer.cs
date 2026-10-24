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
            lblSubtitle.Location = new Point(32, 75);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(600, 25);
            lblSubtitle.TabIndex = 4;
            lblSubtitle.Text = "Transform magical ingredients into powerful elixirs";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(246, 240, 255);
            lblTitle.Location = new Point(20, 15);
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
            panel1.Location = new Point(32, 115);
            panel1.Name = "panel1";
            panel1.Size = new Size(881, 771);
            panel1.TabIndex = 5;
            // 
            // btnBrew
            // 
            btnBrew.AutoSize = true;
            btnBrew.BackColor = Color.FromArgb(128, 90, 202);
            btnBrew.FlatAppearance.BorderSize = 0;
            btnBrew.FlatStyle = FlatStyle.Flat;
            btnBrew.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnBrew.ForeColor = Color.White;
            btnBrew.Location = new Point(30, 694);
            btnBrew.Name = "btnBrew";
            btnBrew.Size = new Size(808, 55);
            btnBrew.TabIndex = 27;
            btnBrew.Text = "Start Brewing";
            btnBrew.UseVisualStyleBackColor = false;
            btnBrew.Click += btnBrew_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = Color.FromArgb(145, 199, 166);
            lblStatus.Location = new Point(30, 642);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(137, 28);
            lblStatus.TabIndex = 26;
            lblStatus.Text = "Select a recipe";
            // 
            // lblProgress
            // 
            lblProgress.AutoSize = true;
            lblProgress.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProgress.ForeColor = Color.FromArgb(196, 167, 255);
            lblProgress.Location = new Point(795, 544);
            lblProgress.Name = "lblProgress";
            lblProgress.Size = new Size(43, 30);
            lblProgress.TabIndex = 25;
            lblProgress.Text = "0%";
            // 
            // progressBarBrew
            // 
            progressBarBrew.BackColor = Color.FromArgb(25, 24, 39);
            progressBarBrew.Location = new Point(30, 586);
            progressBarBrew.Name = "progressBarBrew";
            progressBarBrew.Size = new Size(811, 34);
            progressBarBrew.TabIndex = 24;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(246, 240, 255);
            label7.Location = new Point(27, 539);
            label7.Name = "label7";
            label7.Size = new Size(350, 35);
            label7.TabIndex = 23;
            label7.Text = "Brewing Progress";
            // 
            // label6
            // 
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Location = new Point(23, 525);
            label6.Name = "label6";
            label6.Size = new Size(818, 2);
            label6.TabIndex = 22;
            // 
            // lstRequirements
            // 
            lstRequirements.BackColor = Color.FromArgb(25, 24, 39);
            lstRequirements.BorderStyle = BorderStyle.FixedSingle;
            lstRequirements.ForeColor = Color.White;
            lstRequirements.FormattingEnabled = true;
            lstRequirements.ItemHeight = 25;
            lstRequirements.Location = new Point(20, 338);
            lstRequirements.Name = "lstRequirements";
            lstRequirements.Size = new Size(818, 152);
            lstRequirements.TabIndex = 21;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(246, 240, 255);
            label4.Location = new Point(20, 285);
            label4.Name = "label4";
            label4.Size = new Size(350, 35);
            label4.TabIndex = 20;
            label4.Text = "Required Ingredients";
            // 
            // divider
            // 
            divider.BorderStyle = BorderStyle.FixedSingle;
            divider.Location = new Point(20, 264);
            divider.Name = "divider";
            divider.Size = new Size(818, 2);
            divider.TabIndex = 19;
            // 
            // lblDuration
            // 
            lblDuration.AutoSize = true;
            lblDuration.ForeColor = Color.FromArgb(196, 167, 255);
            lblDuration.Location = new Point(168, 225);
            lblDuration.Name = "lblDuration";
            lblDuration.Size = new Size(81, 25);
            lblDuration.TabIndex = 16;
            lblDuration.Text = "Duration";
            // 
            // lblBrewingRecipeElement
            // 
            lblBrewingRecipeElement.AutoSize = true;
            lblBrewingRecipeElement.ForeColor = Color.FromArgb(185, 179, 206);
            lblBrewingRecipeElement.Location = new Point(168, 188);
            lblBrewingRecipeElement.Name = "lblBrewingRecipeElement";
            lblBrewingRecipeElement.Size = new Size(75, 25);
            lblBrewingRecipeElement.TabIndex = 13;
            lblBrewingRecipeElement.Text = "Element";
            // 
            // lblBrewingRecipeEffect
            // 
            lblBrewingRecipeEffect.AutoSize = true;
            lblBrewingRecipeEffect.ForeColor = Color.FromArgb(185, 179, 206);
            lblBrewingRecipeEffect.Location = new Point(168, 154);
            lblBrewingRecipeEffect.Name = "lblBrewingRecipeEffect";
            lblBrewingRecipeEffect.Size = new Size(56, 25);
            lblBrewingRecipeEffect.TabIndex = 12;
            lblBrewingRecipeEffect.Text = "Effect";
            // 
            // lblBrewingRecipeName
            // 
            lblBrewingRecipeName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBrewingRecipeName.ForeColor = Color.FromArgb(246, 240, 255);
            lblBrewingRecipeName.Location = new Point(163, 109);
            lblBrewingRecipeName.Name = "lblBrewingRecipeName";
            lblBrewingRecipeName.Size = new Size(350, 35);
            lblBrewingRecipeName.TabIndex = 3;
            lblBrewingRecipeName.Text = "Recipe Name";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(64, 51, 89);
            pictureBox1.ImageLocation = "C:\\Users\\abere\\Desktop\\source\\repos\\assignments\\Arcana\\Arcana\\Assets\\flask.png";
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(20, 123);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(115, 107);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(196, 167, 255);
            label1.Location = new Point(20, 17);
            label1.Name = "label1";
            label1.Size = new Size(241, 30);
            label1.TabIndex = 1;
            label1.Text = "SELECT POTION RECIPE";
            // 
            // cmbRecipes
            // 
            cmbRecipes.BackColor = Color.FromArgb(25, 24, 39);
            cmbRecipes.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRecipes.FlatStyle = FlatStyle.Flat;
            cmbRecipes.FormattingEnabled = true;
            cmbRecipes.Location = new Point(20, 50);
            cmbRecipes.Name = "cmbRecipes";
            cmbRecipes.Size = new Size(821, 33);
            cmbRecipes.TabIndex = 0;
            cmbRecipes.SelectedIndexChanged += cmbRecipes_SelectedIndexChanged;
            // 
            // tmrBrew
            // 
            tmrBrew.Tick += tmrBrew_Tick;
            // 
            // BrewingForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(25, 24, 39);
            ClientSize = new Size(950, 917);
            Controls.Add(panel1);
            Controls.Add(lblSubtitle);
            Controls.Add(lblTitle);
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