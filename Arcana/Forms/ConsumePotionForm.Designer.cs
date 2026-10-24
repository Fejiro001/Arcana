namespace Arcana.Forms
{
    partial class ConsumePotionForm
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
            lblPotionName = new Label();
            lblEffect = new Label();
            lblMessage = new Label();
            btnConfirmConsume = new Button();
            btnCancelConsume = new Button();
            SuspendLayout();
            // 
            // lblPotionName
            // 
            lblPotionName.AutoSize = true;
            lblPotionName.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPotionName.ForeColor = Color.FromArgb(185, 179, 206);
            lblPotionName.Location = new Point(27, 35);
            lblPotionName.Name = "lblPotionName";
            lblPotionName.Size = new Size(138, 30);
            lblPotionName.TabIndex = 0;
            lblPotionName.Text = "Potion Name";
            // 
            // lblEffect
            // 
            lblEffect.AutoSize = true;
            lblEffect.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEffect.ForeColor = Color.FromArgb(185, 179, 206);
            lblEffect.Location = new Point(27, 87);
            lblEffect.Name = "lblEffect";
            lblEffect.Size = new Size(122, 28);
            lblEffect.TabIndex = 1;
            lblEffect.Text = "Potion Effect";
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.ForeColor = Color.FromArgb(185, 179, 206);
            lblMessage.Location = new Point(27, 138);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(312, 25);
            lblMessage.TabIndex = 2;
            lblMessage.Text = "Do you want to consume this potion?";
            // 
            // btnConfirmConsume
            // 
            btnConfirmConsume.BackColor = Color.FromArgb(128, 90, 202);
            btnConfirmConsume.DialogResult = DialogResult.OK;
            btnConfirmConsume.FlatAppearance.BorderColor = Color.FromArgb(128, 90, 202);
            btnConfirmConsume.FlatAppearance.BorderSize = 0;
            btnConfirmConsume.FlatStyle = FlatStyle.Flat;
            btnConfirmConsume.ForeColor = Color.White;
            btnConfirmConsume.Location = new Point(27, 234);
            btnConfirmConsume.Name = "btnConfirmConsume";
            btnConfirmConsume.Size = new Size(112, 34);
            btnConfirmConsume.TabIndex = 3;
            btnConfirmConsume.Text = "Consume";
            btnConfirmConsume.UseVisualStyleBackColor = false;
            // 
            // btnCancelConsume
            // 
            btnCancelConsume.BackColor = Color.FromArgb(73, 48, 68);
            btnCancelConsume.DialogResult = DialogResult.Cancel;
            btnCancelConsume.FlatAppearance.BorderColor = Color.FromArgb(128, 90, 202);
            btnCancelConsume.FlatAppearance.BorderSize = 0;
            btnCancelConsume.FlatStyle = FlatStyle.Flat;
            btnCancelConsume.ForeColor = Color.White;
            btnCancelConsume.Location = new Point(281, 234);
            btnCancelConsume.Name = "btnCancelConsume";
            btnCancelConsume.Size = new Size(112, 34);
            btnCancelConsume.TabIndex = 4;
            btnCancelConsume.Text = "Cancel";
            btnCancelConsume.UseVisualStyleBackColor = false;
            // 
            // ConsumePotionForm
            // 
            AcceptButton = btnConfirmConsume;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 38, 60);
            CancelButton = btnCancelConsume;
            ClientSize = new Size(420, 280);
            Controls.Add(btnCancelConsume);
            Controls.Add(btnConfirmConsume);
            Controls.Add(lblMessage);
            Controls.Add(lblEffect);
            Controls.Add(lblPotionName);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ConsumePotionForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ConsumePotionForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPotionName;
        private Label lblEffect;
        private Label lblMessage;
        private Button btnConfirmConsume;
        private Button btnCancelConsume;
    }
}