namespace BD_Projekt.Forms
{
    partial class StageGradePanel
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
            this.label2 = new System.Windows.Forms.Label();
            this.jobTextBox = new System.Windows.Forms.TextBox();
            this.recruitedTextBox = new System.Windows.Forms.TextBox();
            this.stageComboBox = new System.Windows.Forms.ComboBox();
            this.gradeComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.stageGradesListView = new System.Windows.Forms.ListView();
            this.removeStageGradeButton = new System.Windows.Forms.Button();
            this.addStageGradeButton = new System.Windows.Forms.Button();
            this.refreshStageGradesLink = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.refreshStagesLink = new System.Windows.Forms.LinkLabel();
            this.stage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stanowisko";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rekrutowany";
            // 
            // jobTextBox
            // 
            this.jobTextBox.Enabled = false;
            this.jobTextBox.Location = new System.Drawing.Point(88, 38);
            this.jobTextBox.Name = "jobTextBox";
            this.jobTextBox.Size = new System.Drawing.Size(330, 20);
            this.jobTextBox.TabIndex = 2;
            // 
            // recruitedTextBox
            // 
            this.recruitedTextBox.Enabled = false;
            this.recruitedTextBox.Location = new System.Drawing.Point(88, 12);
            this.recruitedTextBox.Name = "recruitedTextBox";
            this.recruitedTextBox.Size = new System.Drawing.Size(330, 20);
            this.recruitedTextBox.TabIndex = 3;
            // 
            // stageComboBox
            // 
            this.stageComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stageComboBox.FormattingEnabled = true;
            this.stageComboBox.Location = new System.Drawing.Point(88, 64);
            this.stageComboBox.Name = "stageComboBox";
            this.stageComboBox.Size = new System.Drawing.Size(218, 21);
            this.stageComboBox.TabIndex = 4;
            // 
            // gradeComboBox
            // 
            this.gradeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gradeComboBox.FormattingEnabled = true;
            this.gradeComboBox.Location = new System.Drawing.Point(88, 91);
            this.gradeComboBox.Name = "gradeComboBox";
            this.gradeComboBox.Size = new System.Drawing.Size(218, 21);
            this.gradeComboBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ocena";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nazwa etapu";
            // 
            // stageGradesListView
            // 
            this.stageGradesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.stage,
            this.grade});
            this.stageGradesListView.FullRowSelect = true;
            this.stageGradesListView.GridLines = true;
            this.stageGradesListView.Location = new System.Drawing.Point(12, 183);
            this.stageGradesListView.Name = "stageGradesListView";
            this.stageGradesListView.Size = new System.Drawing.Size(406, 205);
            this.stageGradesListView.TabIndex = 8;
            this.stageGradesListView.UseCompatibleStateImageBehavior = false;
            this.stageGradesListView.View = System.Windows.Forms.View.Details;
            // 
            // removeStageGradeButton
            // 
            this.removeStageGradeButton.Location = new System.Drawing.Point(12, 394);
            this.removeStageGradeButton.Name = "removeStageGradeButton";
            this.removeStageGradeButton.Size = new System.Drawing.Size(406, 23);
            this.removeStageGradeButton.TabIndex = 9;
            this.removeStageGradeButton.Text = "Usuń ocenę etapu";
            this.removeStageGradeButton.UseVisualStyleBackColor = true;
            this.removeStageGradeButton.Click += new System.EventHandler(this.removeStageGradeButtonClicked);
            // 
            // addStageGradeButton
            // 
            this.addStageGradeButton.Location = new System.Drawing.Point(12, 118);
            this.addStageGradeButton.Name = "addStageGradeButton";
            this.addStageGradeButton.Size = new System.Drawing.Size(406, 23);
            this.addStageGradeButton.TabIndex = 10;
            this.addStageGradeButton.Text = "Dodaj ocenę";
            this.addStageGradeButton.UseVisualStyleBackColor = true;
            this.addStageGradeButton.Click += new System.EventHandler(this.addStageGradeButtonClicked);
            // 
            // refreshStageGradesLink
            // 
            this.refreshStageGradesLink.AutoSize = true;
            this.refreshStageGradesLink.Location = new System.Drawing.Point(350, 167);
            this.refreshStageGradesLink.Name = "refreshStageGradesLink";
            this.refreshStageGradesLink.Size = new System.Drawing.Size(68, 13);
            this.refreshStageGradesLink.TabIndex = 11;
            this.refreshStageGradesLink.TabStop = true;
            this.refreshStageGradesLink.Text = "Odśwież listę";
            this.refreshStageGradesLink.Click += new System.EventHandler(this.refreshStageGradesLinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Oceny etapów w bazie";
            // 
            // refreshStagesLink
            // 
            this.refreshStagesLink.AutoSize = true;
            this.refreshStagesLink.Location = new System.Drawing.Point(312, 67);
            this.refreshStagesLink.Name = "refreshStagesLink";
            this.refreshStagesLink.Size = new System.Drawing.Size(106, 13);
            this.refreshStagesLink.TabIndex = 13;
            this.refreshStagesLink.TabStop = true;
            this.refreshStagesLink.Text = "Odśwież listę etapów";
            this.refreshStagesLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.refreshStagesLinkClicked);
            // 
            // stage
            // 
            this.stage.Text = "Nazwa etapu";
            this.stage.Width = 342;
            // 
            // grade
            // 
            this.grade.Text = "Ocena";
            // 
            // StageGradePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 429);
            this.Controls.Add(this.refreshStagesLink);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.refreshStageGradesLink);
            this.Controls.Add(this.addStageGradeButton);
            this.Controls.Add(this.removeStageGradeButton);
            this.Controls.Add(this.stageGradesListView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gradeComboBox);
            this.Controls.Add(this.stageComboBox);
            this.Controls.Add(this.recruitedTextBox);
            this.Controls.Add(this.jobTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StageGradePanel";
            this.Text = "Panel oceniania etapów";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox jobTextBox;
        private System.Windows.Forms.TextBox recruitedTextBox;
        private System.Windows.Forms.ComboBox stageComboBox;
        private System.Windows.Forms.ComboBox gradeComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView stageGradesListView;
        private System.Windows.Forms.Button removeStageGradeButton;
        private System.Windows.Forms.Button addStageGradeButton;
        private System.Windows.Forms.LinkLabel refreshStageGradesLink;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel refreshStagesLink;
        private System.Windows.Forms.ColumnHeader stage;
        private System.Windows.Forms.ColumnHeader grade;
    }
}