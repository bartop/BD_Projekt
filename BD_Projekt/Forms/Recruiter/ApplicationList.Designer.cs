namespace BD_Projekt.Forms
{
    partial class ApplicationList
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
            this.applicationsListView = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.refreshApplicationsListViewLink = new System.Windows.Forms.LinkLabel();
            this.addStageGradesButton = new System.Windows.Forms.Button();
            this.addDecisionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recruited";
            // 
            // recruitedNameTextBox
            // 
            this.recruitedNameTextBox.Enabled = false;
            this.recruitedNameTextBox.Location = new System.Drawing.Point(71, 12);
            this.recruitedNameTextBox.Name = "recruitedNameTextBox";
            this.recruitedNameTextBox.Size = new System.Drawing.Size(425, 20);
            this.recruitedNameTextBox.TabIndex = 1;
            // 
            // applicationsListView
            // 
            this.applicationsListView.Location = new System.Drawing.Point(12, 66);
            this.applicationsListView.Name = "applicationsListView";
            this.applicationsListView.Size = new System.Drawing.Size(484, 144);
            this.applicationsListView.TabIndex = 2;
            this.applicationsListView.UseCompatibleStateImageBehavior = false;
            this.applicationsListView.View = System.Windows.Forms.View.List;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lista stanowisk na które aplikuje rekrutowany";
            // 
            // refreshApplicationsListViewLink
            // 
            this.refreshApplicationsListViewLink.AutoSize = true;
            this.refreshApplicationsListViewLink.Location = new System.Drawing.Point(428, 50);
            this.refreshApplicationsListViewLink.Name = "refreshApplicationsListViewLink";
            this.refreshApplicationsListViewLink.Size = new System.Drawing.Size(68, 13);
            this.refreshApplicationsListViewLink.TabIndex = 4;
            this.refreshApplicationsListViewLink.TabStop = true;
            this.refreshApplicationsListViewLink.Text = "Odśwież listę";
            this.refreshApplicationsListViewLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.refereshApplicationsListLinkClicked);
            // 
            // addStageGradesButton
            // 
            this.addStageGradesButton.Location = new System.Drawing.Point(12, 216);
            this.addStageGradesButton.Name = "addStageGradesButton";
            this.addStageGradesButton.Size = new System.Drawing.Size(234, 23);
            this.addStageGradesButton.TabIndex = 5;
            this.addStageGradesButton.Text = "Dodaj oceny etapów rekrutacji";
            this.addStageGradesButton.UseVisualStyleBackColor = true;
            this.addStageGradesButton.Click += new System.EventHandler(this.addStageGradesButtonCllicked);
            // 
            // addDecisionButton
            // 
            this.addDecisionButton.Location = new System.Drawing.Point(262, 216);
            this.addDecisionButton.Name = "addDecisionButton";
            this.addDecisionButton.Size = new System.Drawing.Size(234, 23);
            this.addDecisionButton.TabIndex = 6;
            this.addDecisionButton.Text = "Podsumowanie informacji i decyzja";
            this.addDecisionButton.UseVisualStyleBackColor = true;
            this.addDecisionButton.Click += new System.EventHandler(this.addDecisionButtonClicked);
            // 
            // ApplicationList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 251);
            this.Controls.Add(this.addDecisionButton);
            this.Controls.Add(this.addStageGradesButton);
            this.Controls.Add(this.refreshApplicationsListViewLink);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.applicationsListView);
            this.Controls.Add(this.recruitedNameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "ApplicationList";
            this.Text = "Lista podań";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox recruitedNameTextBox;
        private System.Windows.Forms.ListView applicationsListView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel refreshApplicationsListViewLink;
        private System.Windows.Forms.Button addStageGradesButton;
        private System.Windows.Forms.Button addDecisionButton;
    }
}