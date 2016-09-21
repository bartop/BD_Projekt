namespace BD_Projekt.Forms
{
    partial class RecruiterForm
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
            this.recruitedListOpenButton = new System.Windows.Forms.Button();
            this.addRecruitedButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // recruitedListOpenButton
            // 
            this.recruitedListOpenButton.Location = new System.Drawing.Point(12, 44);
            this.recruitedListOpenButton.Name = "recruitedListOpenButton";
            this.recruitedListOpenButton.Size = new System.Drawing.Size(260, 26);
            this.recruitedListOpenButton.TabIndex = 0;
            this.recruitedListOpenButton.Text = "Oceń rekrutowanych";
            this.recruitedListOpenButton.UseVisualStyleBackColor = true;
            this.recruitedListOpenButton.Click += new System.EventHandler(this.openRecruitedListButtonClicked);
            // 
            // addRecruitedButton
            // 
            this.addRecruitedButton.Location = new System.Drawing.Point(12, 12);
            this.addRecruitedButton.Name = "addRecruitedButton";
            this.addRecruitedButton.Size = new System.Drawing.Size(260, 26);
            this.addRecruitedButton.TabIndex = 1;
            this.addRecruitedButton.Text = "Dodaj rekrutowanych";
            this.addRecruitedButton.UseVisualStyleBackColor = true;
            this.addRecruitedButton.Click += new System.EventHandler(this.addRecruitedButton_Click);
            // 
            // RecruiterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 83);
            this.Controls.Add(this.addRecruitedButton);
            this.Controls.Add(this.recruitedListOpenButton);
            this.Name = "RecruiterForm";
            this.Text = "Panel rekrutera";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button recruitedListOpenButton;
        private System.Windows.Forms.Button addRecruitedButton;
    }
}