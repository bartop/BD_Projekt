namespace BD_Projekt.Forms
{
    partial class RecruitedList
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
            this.recruitedListView = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.surname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.refreshListLink = new System.Windows.Forms.LinkLabel();
            this.manageApplicationsButton = new System.Windows.Forms.Button();
            this.manageSkillsButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.closeWindowButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // recruitedListView
            // 
            this.recruitedListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.name,
            this.surname,
            this.email});
            this.recruitedListView.FullRowSelect = true;
            this.recruitedListView.GridLines = true;
            this.recruitedListView.Location = new System.Drawing.Point(12, 25);
            this.recruitedListView.Name = "recruitedListView";
            this.recruitedListView.Size = new System.Drawing.Size(513, 457);
            this.recruitedListView.TabIndex = 0;
            this.recruitedListView.UseCompatibleStateImageBehavior = false;
            this.recruitedListView.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "Nr";
            this.id.Width = 34;
            // 
            // name
            // 
            this.name.Text = "Imię";
            this.name.Width = 124;
            // 
            // surname
            // 
            this.surname.Text = "Nazwisko";
            this.surname.Width = 212;
            // 
            // email
            // 
            this.email.Text = "Email";
            this.email.Width = 136;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Użytkownicy w bazie";
            // 
            // refreshListLink
            // 
            this.refreshListLink.AutoSize = true;
            this.refreshListLink.Location = new System.Drawing.Point(457, 9);
            this.refreshListLink.Name = "refreshListLink";
            this.refreshListLink.Size = new System.Drawing.Size(68, 13);
            this.refreshListLink.TabIndex = 2;
            this.refreshListLink.TabStop = true;
            this.refreshListLink.Text = "Odśwież listę";
            this.refreshListLink.Click += new System.EventHandler(this.refreshListLinkCliked);
            // 
            // manageApplicationsButton
            // 
            this.manageApplicationsButton.Location = new System.Drawing.Point(277, 488);
            this.manageApplicationsButton.Name = "manageApplicationsButton";
            this.manageApplicationsButton.Size = new System.Drawing.Size(248, 23);
            this.manageApplicationsButton.TabIndex = 3;
            this.manageApplicationsButton.Text = "Zarządzaj podaniami";
            this.manageApplicationsButton.UseVisualStyleBackColor = true;
            this.manageApplicationsButton.Click += new System.EventHandler(this.manageApplicationsButtonClicked);
            // 
            // manageSkillsButton
            // 
            this.manageSkillsButton.Location = new System.Drawing.Point(12, 488);
            this.manageSkillsButton.Name = "manageSkillsButton";
            this.manageSkillsButton.Size = new System.Drawing.Size(248, 23);
            this.manageSkillsButton.TabIndex = 4;
            this.manageSkillsButton.Text = "Zarządzaj umiejętnościami";
            this.manageSkillsButton.UseVisualStyleBackColor = true;
            this.manageSkillsButton.Click += new System.EventHandler(this.manageSkillsButtonClicked);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 517);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(248, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Pokaż dokumenty";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // closeWindowButton
            // 
            this.closeWindowButton.Location = new System.Drawing.Point(277, 517);
            this.closeWindowButton.Name = "closeWindowButton";
            this.closeWindowButton.Size = new System.Drawing.Size(248, 23);
            this.closeWindowButton.TabIndex = 6;
            this.closeWindowButton.Text = "Zamknij okno";
            this.closeWindowButton.UseVisualStyleBackColor = true;
            this.closeWindowButton.Click += new System.EventHandler(this.closeWindowButtonClicked);
            // 
            // RecruitedList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 556);
            this.Controls.Add(this.closeWindowButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.manageSkillsButton);
            this.Controls.Add(this.manageApplicationsButton);
            this.Controls.Add(this.refreshListLink);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.recruitedListView);
            this.Name = "RecruitedList";
            this.Text = "Lista rekrutowanych";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView recruitedListView;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader surname;
        private System.Windows.Forms.ColumnHeader email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel refreshListLink;
        private System.Windows.Forms.Button manageApplicationsButton;
        private System.Windows.Forms.Button manageSkillsButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button closeWindowButton;
    }
}