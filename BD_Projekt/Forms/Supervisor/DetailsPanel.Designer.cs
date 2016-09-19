namespace BD_Projekt.Forms
{
    partial class DetailsPanel
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
            this.recruitedTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.refreshEducationListViewLink = new System.Windows.Forms.LinkLabel();
            this.refreshExpirienceLink = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.positionTextBox = new System.Windows.Forms.TextBox();
            this.refreshSkillLevelListLink = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.refreshStageGradesLink = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.stageAverageLabel = new System.Windows.Forms.Label();
            this.educationListView = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.schoolName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.educationName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.from = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.to = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.expirienceListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.companyName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.jobName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stageGradesListView = new System.Windows.Forms.ListView();
            this.stage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.skillLevelListView = new System.Windows.Forms.ListView();
            this.skillName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.skillsWarning = new System.Windows.Forms.Label();
            this.stagesWarning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // recruitedTextBox
            // 
            this.recruitedTextBox.Enabled = false;
            this.recruitedTextBox.Location = new System.Drawing.Point(88, 12);
            this.recruitedTextBox.Name = "recruitedTextBox";
            this.recruitedTextBox.Size = new System.Drawing.Size(510, 20);
            this.recruitedTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rekrutowany";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Scieżka edukacji";
            // 
            // refreshEducationListViewLink
            // 
            this.refreshEducationListViewLink.AutoSize = true;
            this.refreshEducationListViewLink.Location = new System.Drawing.Point(551, 87);
            this.refreshEducationListViewLink.Name = "refreshEducationListViewLink";
            this.refreshEducationListViewLink.Size = new System.Drawing.Size(47, 13);
            this.refreshEducationListViewLink.TabIndex = 5;
            this.refreshEducationListViewLink.TabStop = true;
            this.refreshEducationListViewLink.Text = "Odśwież";
            this.refreshEducationListViewLink.Click += new System.EventHandler(this.refreshEducationListViewLinkClicked);
            // 
            // refreshExpirienceLink
            // 
            this.refreshExpirienceLink.AutoSize = true;
            this.refreshExpirienceLink.Location = new System.Drawing.Point(551, 255);
            this.refreshExpirienceLink.Name = "refreshExpirienceLink";
            this.refreshExpirienceLink.Size = new System.Drawing.Size(47, 13);
            this.refreshExpirienceLink.TabIndex = 8;
            this.refreshExpirienceLink.TabStop = true;
            this.refreshExpirienceLink.Text = "Odśwież";
            this.refreshExpirienceLink.Click += new System.EventHandler(this.refreshExpirienceLinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Historia zatrudnienia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Stanowisko";
            // 
            // positionTextBox
            // 
            this.positionTextBox.Enabled = false;
            this.positionTextBox.Location = new System.Drawing.Point(88, 38);
            this.positionTextBox.Name = "positionTextBox";
            this.positionTextBox.Size = new System.Drawing.Size(510, 20);
            this.positionTextBox.TabIndex = 9;
            // 
            // refreshSkillLevelListLink
            // 
            this.refreshSkillLevelListLink.AutoSize = true;
            this.refreshSkillLevelListLink.Location = new System.Drawing.Point(551, 600);
            this.refreshSkillLevelListLink.Name = "refreshSkillLevelListLink";
            this.refreshSkillLevelListLink.Size = new System.Drawing.Size(47, 13);
            this.refreshSkillLevelListLink.TabIndex = 16;
            this.refreshSkillLevelListLink.TabStop = true;
            this.refreshSkillLevelListLink.Text = "Odśwież";
            this.refreshSkillLevelListLink.Click += new System.EventHandler(this.refreshSkillLevelListLinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 600);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Oceny umiejętności";
            // 
            // refreshStageGradesLink
            // 
            this.refreshStageGradesLink.AutoSize = true;
            this.refreshStageGradesLink.Location = new System.Drawing.Point(551, 425);
            this.refreshStageGradesLink.Name = "refreshStageGradesLink";
            this.refreshStageGradesLink.Size = new System.Drawing.Size(47, 13);
            this.refreshStageGradesLink.TabIndex = 13;
            this.refreshStageGradesLink.TabStop = true;
            this.refreshStageGradesLink.Text = "Odśwież";
            this.refreshStageGradesLink.Click += new System.EventHandler(this.refreshStageGradesLinkClicked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 425);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Oceny etapów";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 577);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Średnia:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 752);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Średnia:";
            // 
            // stageAverageLabel
            // 
            this.stageAverageLabel.AutoSize = true;
            this.stageAverageLabel.Location = new System.Drawing.Point(64, 577);
            this.stageAverageLabel.Name = "stageAverageLabel";
            this.stageAverageLabel.Size = new System.Drawing.Size(0, 13);
            this.stageAverageLabel.TabIndex = 20;
            // 
            // educationListView
            // 
            this.educationListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.schoolName,
            this.educationName,
            this.from,
            this.to});
            this.educationListView.FullRowSelect = true;
            this.educationListView.GridLines = true;
            this.educationListView.Location = new System.Drawing.Point(12, 103);
            this.educationListView.Name = "educationListView";
            this.educationListView.Size = new System.Drawing.Size(586, 133);
            this.educationListView.TabIndex = 28;
            this.educationListView.UseCompatibleStateImageBehavior = false;
            this.educationListView.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "Numer";
            this.id.Width = 58;
            // 
            // schoolName
            // 
            this.schoolName.Text = "Nazwa szkoły";
            this.schoolName.Width = 170;
            // 
            // educationName
            // 
            this.educationName.Text = "Nazwa kierunku";
            this.educationName.Width = 220;
            // 
            // from
            // 
            this.from.Text = "Od";
            // 
            // to
            // 
            this.to.Text = "Do";
            // 
            // expirienceListView
            // 
            this.expirienceListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.companyName,
            this.jobName,
            this.columnHeader2,
            this.columnHeader3});
            this.expirienceListView.FullRowSelect = true;
            this.expirienceListView.GridLines = true;
            this.expirienceListView.Location = new System.Drawing.Point(12, 271);
            this.expirienceListView.Name = "expirienceListView";
            this.expirienceListView.Size = new System.Drawing.Size(586, 133);
            this.expirienceListView.TabIndex = 29;
            this.expirienceListView.UseCompatibleStateImageBehavior = false;
            this.expirienceListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Numer";
            this.columnHeader1.Width = 75;
            // 
            // companyName
            // 
            this.companyName.Text = "Nazwa firmy";
            this.companyName.Width = 194;
            // 
            // jobName
            // 
            this.jobName.Text = "Nazwa stanowiska";
            this.jobName.Width = 185;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Od";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Do";
            // 
            // stageGradesListView
            // 
            this.stageGradesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.stage,
            this.grade});
            this.stageGradesListView.FullRowSelect = true;
            this.stageGradesListView.GridLines = true;
            this.stageGradesListView.Location = new System.Drawing.Point(12, 441);
            this.stageGradesListView.Name = "stageGradesListView";
            this.stageGradesListView.Size = new System.Drawing.Size(586, 133);
            this.stageGradesListView.TabIndex = 30;
            this.stageGradesListView.UseCompatibleStateImageBehavior = false;
            this.stageGradesListView.View = System.Windows.Forms.View.Details;
            // 
            // stage
            // 
            this.stage.Text = "Nazwa etapu";
            this.stage.Width = 509;
            // 
            // grade
            // 
            this.grade.Text = "Ocena";
            // 
            // skillLevelListView
            // 
            this.skillLevelListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.skillName,
            this.columnHeader4});
            this.skillLevelListView.FullRowSelect = true;
            this.skillLevelListView.GridLines = true;
            this.skillLevelListView.Location = new System.Drawing.Point(12, 616);
            this.skillLevelListView.Name = "skillLevelListView";
            this.skillLevelListView.Size = new System.Drawing.Size(586, 133);
            this.skillLevelListView.TabIndex = 31;
            this.skillLevelListView.UseCompatibleStateImageBehavior = false;
            this.skillLevelListView.View = System.Windows.Forms.View.Details;
            // 
            // skillName
            // 
            this.skillName.Text = "Nazwa umiejętności";
            this.skillName.Width = 515;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ocena";
            // 
            // skillsWarning
            // 
            this.skillsWarning.AutoSize = true;
            this.skillsWarning.ForeColor = System.Drawing.Color.Red;
            this.skillsWarning.Location = new System.Drawing.Point(151, 600);
            this.skillsWarning.Name = "skillsWarning";
            this.skillsWarning.Size = new System.Drawing.Size(352, 13);
            this.skillsWarning.TabIndex = 33;
            this.skillsWarning.Text = "Uwaga! Nie wszystkie umiejętności dotyczące stanowiska są wypełnione";
            this.skillsWarning.Visible = false;
            // 
            // stagesWarning
            // 
            this.stagesWarning.AutoSize = true;
            this.stagesWarning.ForeColor = System.Drawing.Color.Red;
            this.stagesWarning.Location = new System.Drawing.Point(205, 425);
            this.stagesWarning.Name = "stagesWarning";
            this.stagesWarning.Size = new System.Drawing.Size(247, 13);
            this.stagesWarning.TabIndex = 34;
            this.stagesWarning.Text = "Uwaga! Nie wszystkie etapy rekrutacji są ocenione";
            this.stagesWarning.Visible = false;
            // 
            // DetailsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(675, 460);
            this.Controls.Add(this.stagesWarning);
            this.Controls.Add(this.skillsWarning);
            this.Controls.Add(this.skillLevelListView);
            this.Controls.Add(this.stageGradesListView);
            this.Controls.Add(this.expirienceListView);
            this.Controls.Add(this.educationListView);
            this.Controls.Add(this.stageAverageLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.refreshSkillLevelListLink);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.refreshStageGradesLink);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.positionTextBox);
            this.Controls.Add(this.refreshExpirienceLink);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.refreshEducationListViewLink);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.recruitedTextBox);
            this.Name = "DetailsPanel";
            this.Text = "Szczegóły aplikacji";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox recruitedTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel refreshEducationListViewLink;
        private System.Windows.Forms.LinkLabel refreshExpirienceLink;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox positionTextBox;
        private System.Windows.Forms.LinkLabel refreshSkillLevelListLink;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel refreshStageGradesLink;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label stageAverageLabel;
        private System.Windows.Forms.ListView educationListView;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader schoolName;
        private System.Windows.Forms.ColumnHeader educationName;
        private System.Windows.Forms.ColumnHeader from;
        private System.Windows.Forms.ColumnHeader to;
        private System.Windows.Forms.ListView expirienceListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader companyName;
        private System.Windows.Forms.ColumnHeader jobName;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView stageGradesListView;
        private System.Windows.Forms.ColumnHeader stage;
        private System.Windows.Forms.ColumnHeader grade;
        private System.Windows.Forms.ListView skillLevelListView;
        private System.Windows.Forms.ColumnHeader skillName;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label skillsWarning;
        private System.Windows.Forms.Label stagesWarning;
    }
}