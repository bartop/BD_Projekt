namespace BD_Projekt.Forms
{
    partial class SkillLevelForm
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
            this.recruitedNameTextBox = new System.Windows.Forms.TextBox();
            this.skillsComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.skillLevelListView = new System.Windows.Forms.ListView();
            this.skillName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.levelComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addSkillGradeButton = new System.Windows.Forms.Button();
            this.removeSkillGradeButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.refreshSkillGradesList = new System.Windows.Forms.LinkLabel();
            this.refreshSkillsLink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rekrutowany";
            // 
            // recruitedNameTextBox
            // 
            this.recruitedNameTextBox.Enabled = false;
            this.recruitedNameTextBox.Location = new System.Drawing.Point(88, 12);
            this.recruitedNameTextBox.Name = "recruitedNameTextBox";
            this.recruitedNameTextBox.Size = new System.Drawing.Size(292, 20);
            this.recruitedNameTextBox.TabIndex = 1;
            // 
            // skillsComboBox
            // 
            this.skillsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skillsComboBox.FormattingEnabled = true;
            this.skillsComboBox.Location = new System.Drawing.Point(88, 38);
            this.skillsComboBox.Name = "skillsComboBox";
            this.skillsComboBox.Size = new System.Drawing.Size(167, 21);
            this.skillsComboBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Umiejętność";
            // 
            // skillLevelListView
            // 
            this.skillLevelListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.skillName,
            this.grade});
            this.skillLevelListView.FullRowSelect = true;
            this.skillLevelListView.GridLines = true;
            this.skillLevelListView.Location = new System.Drawing.Point(12, 159);
            this.skillLevelListView.Name = "skillLevelListView";
            this.skillLevelListView.Size = new System.Drawing.Size(368, 177);
            this.skillLevelListView.TabIndex = 4;
            this.skillLevelListView.UseCompatibleStateImageBehavior = false;
            this.skillLevelListView.View = System.Windows.Forms.View.Details;
            // 
            // skillName
            // 
            this.skillName.Text = "Nazwa umiejętności";
            this.skillName.Width = 296;
            // 
            // grade
            // 
            this.grade.Text = "Ocena";
            // 
            // levelComboBox
            // 
            this.levelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.levelComboBox.FormattingEnabled = true;
            this.levelComboBox.Location = new System.Drawing.Point(88, 65);
            this.levelComboBox.Name = "levelComboBox";
            this.levelComboBox.Size = new System.Drawing.Size(167, 21);
            this.levelComboBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ocena";
            // 
            // addSkillGradeButton
            // 
            this.addSkillGradeButton.Location = new System.Drawing.Point(12, 92);
            this.addSkillGradeButton.Name = "addSkillGradeButton";
            this.addSkillGradeButton.Size = new System.Drawing.Size(368, 23);
            this.addSkillGradeButton.TabIndex = 7;
            this.addSkillGradeButton.Text = "Dodaj ocenę umiejętności";
            this.addSkillGradeButton.UseVisualStyleBackColor = true;
            this.addSkillGradeButton.Click += new System.EventHandler(this.addSkillGradeButtonClicked);
            // 
            // removeSkillGradeButton
            // 
            this.removeSkillGradeButton.Location = new System.Drawing.Point(12, 342);
            this.removeSkillGradeButton.Name = "removeSkillGradeButton";
            this.removeSkillGradeButton.Size = new System.Drawing.Size(368, 23);
            this.removeSkillGradeButton.TabIndex = 8;
            this.removeSkillGradeButton.Text = "Usuń ocenę umiejętności";
            this.removeSkillGradeButton.UseVisualStyleBackColor = true;
            this.removeSkillGradeButton.Click += new System.EventHandler(this.deleteSkillGradeButtonClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Lista ocenionych umiejętności";
            // 
            // refreshSkillGradesList
            // 
            this.refreshSkillGradesList.AutoSize = true;
            this.refreshSkillGradesList.Location = new System.Drawing.Point(312, 143);
            this.refreshSkillGradesList.Name = "refreshSkillGradesList";
            this.refreshSkillGradesList.Size = new System.Drawing.Size(68, 13);
            this.refreshSkillGradesList.TabIndex = 10;
            this.refreshSkillGradesList.TabStop = true;
            this.refreshSkillGradesList.Text = "Odśwież listę";
            // 
            // refreshSkillsLink
            // 
            this.refreshSkillsLink.AutoSize = true;
            this.refreshSkillsLink.Location = new System.Drawing.Point(261, 41);
            this.refreshSkillsLink.Name = "refreshSkillsLink";
            this.refreshSkillsLink.Size = new System.Drawing.Size(108, 13);
            this.refreshSkillsLink.TabIndex = 11;
            this.refreshSkillsLink.TabStop = true;
            this.refreshSkillsLink.Text = "Odśwież umiejętności";
            this.refreshSkillsLink.Click += new System.EventHandler(this.refreshSkillsLinkClicked);
            // 
            // SkillLevelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 377);
            this.Controls.Add(this.refreshSkillsLink);
            this.Controls.Add(this.refreshSkillGradesList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.removeSkillGradeButton);
            this.Controls.Add(this.addSkillGradeButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.levelComboBox);
            this.Controls.Add(this.skillLevelListView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.skillsComboBox);
            this.Controls.Add(this.recruitedNameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "SkillLevelForm";
            this.Text = "Zarządzaj umiejętnościami";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox recruitedNameTextBox;
        private System.Windows.Forms.ComboBox skillsComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView skillLevelListView;
        private System.Windows.Forms.ColumnHeader skillName;
        private System.Windows.Forms.ColumnHeader grade;
        private System.Windows.Forms.ComboBox levelComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addSkillGradeButton;
        private System.Windows.Forms.Button removeSkillGradeButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel refreshSkillGradesList;
        private System.Windows.Forms.LinkLabel refreshSkillsLink;
    }
}