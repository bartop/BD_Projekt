namespace BD_Projekt.Forms
{
    partial class EditSkillForm
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
            this.updatedSkillTextBox = new System.Windows.Forms.TextBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // updatedSkillTextBox
            // 
            this.updatedSkillTextBox.Location = new System.Drawing.Point(12, 12);
            this.updatedSkillTextBox.Name = "updatedSkillTextBox";
            this.updatedSkillTextBox.Size = new System.Drawing.Size(260, 20);
            this.updatedSkillTextBox.TabIndex = 0;
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(12, 38);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(125, 23);
            this.confirmButton.TabIndex = 1;
            this.confirmButton.Text = "Potwierdź zmianę";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButtonClick);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(147, 38);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(125, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Anuluj";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButtonClick);
            // 
            // EditSkillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 73);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.updatedSkillTextBox);
            this.Name = "EditSkillForm";
            this.Text = "Zmień nazwę umiejętności";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox updatedSkillTextBox;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button cancelButton;
    }
}