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
            this.label1 = new System.Windows.Forms.Label();
            this.refreshListLink = new System.Windows.Forms.LinkLabel();
            this.manageApplicationsButton = new System.Windows.Forms.Button();
            this.manageSkillsButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.closeWindowButton = new System.Windows.Forms.Button();
            this.recruitedListView = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn4 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.recruitedListView)).BeginInit();
            this.SuspendLayout();
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
            this.button2.Text = "Pokaż dane";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.showDocumentsButtonClicked);
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
            // recruitedListView
            // 
            this.recruitedListView.AllColumns.Add(this.olvColumn1);
            this.recruitedListView.AllColumns.Add(this.olvColumn2);
            this.recruitedListView.AllColumns.Add(this.olvColumn3);
            this.recruitedListView.AllColumns.Add(this.olvColumn4);
            this.recruitedListView.CellEditUseWholeCell = false;
            this.recruitedListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.olvColumn2,
            this.olvColumn3,
            this.olvColumn4});
            this.recruitedListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.recruitedListView.FullRowSelect = true;
            this.recruitedListView.Location = new System.Drawing.Point(15, 25);
            this.recruitedListView.Name = "recruitedListView";
            this.recruitedListView.ShowGroups = false;
            this.recruitedListView.Size = new System.Drawing.Size(510, 457);
            this.recruitedListView.TabIndex = 46;
            this.recruitedListView.UseCompatibleStateImageBehavior = false;
            this.recruitedListView.UseFilterIndicator = true;
            this.recruitedListView.UseFiltering = true;
            this.recruitedListView.UseTranslucentSelection = true;
            this.recruitedListView.View = System.Windows.Forms.View.Details;
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "Id";
            this.olvColumn1.Text = "Numer";
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "Name";
            this.olvColumn2.Text = "Imię";
            this.olvColumn2.Width = 123;
            // 
            // olvColumn3
            // 
            this.olvColumn3.AspectName = "Surname";
            this.olvColumn3.Text = "Nazwisko";
            this.olvColumn3.Width = 179;
            // 
            // olvColumn4
            // 
            this.olvColumn4.AspectName = "Email";
            this.olvColumn4.Text = "Email";
            this.olvColumn4.Width = 260;
            // 
            // RecruitedList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 556);
            this.Controls.Add(this.recruitedListView);
            this.Controls.Add(this.closeWindowButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.manageSkillsButton);
            this.Controls.Add(this.manageApplicationsButton);
            this.Controls.Add(this.refreshListLink);
            this.Controls.Add(this.label1);
            this.Name = "RecruitedList";
            this.Text = "Lista rekrutowanych";
            ((System.ComponentModel.ISupportInitialize)(this.recruitedListView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel refreshListLink;
        private System.Windows.Forms.Button manageApplicationsButton;
        private System.Windows.Forms.Button manageSkillsButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button closeWindowButton;
        private BrightIdeasSoftware.ObjectListView recruitedListView;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private BrightIdeasSoftware.OLVColumn olvColumn3;
        private BrightIdeasSoftware.OLVColumn olvColumn4;
    }
}