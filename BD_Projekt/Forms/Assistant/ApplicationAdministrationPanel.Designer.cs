namespace BD_Projekt.Forms
{
    partial class ApplicationAdministrationPanel
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
            this.jobsComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.refreshJobsListLink = new System.Windows.Forms.LinkLabel();
            this.applicationsListView = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.addApplicationButton = new System.Windows.Forms.Button();
            this.removeApplicationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // recruitedTextBox
            // 
            this.recruitedTextBox.Enabled = false;
            this.recruitedTextBox.Location = new System.Drawing.Point(88, 12);
            this.recruitedTextBox.Name = "recruitedTextBox";
            this.recruitedTextBox.Size = new System.Drawing.Size(252, 20);
            this.recruitedTextBox.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Rekrutowany";
            // 
            // jobsComboBox
            // 
            this.jobsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.jobsComboBox.FormattingEnabled = true;
            this.jobsComboBox.Location = new System.Drawing.Point(88, 38);
            this.jobsComboBox.Name = "jobsComboBox";
            this.jobsComboBox.Size = new System.Drawing.Size(252, 21);
            this.jobsComboBox.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Stanowisko";
            // 
            // refreshJobsListLink
            // 
            this.refreshJobsListLink.AutoSize = true;
            this.refreshJobsListLink.Location = new System.Drawing.Point(346, 41);
            this.refreshJobsListLink.Name = "refreshJobsListLink";
            this.refreshJobsListLink.Size = new System.Drawing.Size(118, 13);
            this.refreshJobsListLink.TabIndex = 21;
            this.refreshJobsListLink.TabStop = true;
            this.refreshJobsListLink.Text = "Odśwież listę stanowisk";
            this.refreshJobsListLink.Click += new System.EventHandler(this.refreshJobsLinkClicked);
            // 
            // applicationsListView
            // 
            this.applicationsListView.Location = new System.Drawing.Point(12, 135);
            this.applicationsListView.Name = "applicationsListView";
            this.applicationsListView.Size = new System.Drawing.Size(452, 137);
            this.applicationsListView.TabIndex = 22;
            this.applicationsListView.UseCompatibleStateImageBehavior = false;
            this.applicationsListView.View = System.Windows.Forms.View.List;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Stanowiska na które aplikuje rekrutowany";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(355, 119);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(109, 13);
            this.linkLabel2.TabIndex = 24;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Odśwież listę aplikacji";
            this.linkLabel2.Click += new System.EventHandler(this.refreshApplicationsLinkClicked);
            // 
            // addApplicationButton
            // 
            this.addApplicationButton.Location = new System.Drawing.Point(12, 65);
            this.addApplicationButton.Name = "addApplicationButton";
            this.addApplicationButton.Size = new System.Drawing.Size(452, 23);
            this.addApplicationButton.TabIndex = 25;
            this.addApplicationButton.Text = "Dodaj podanie";
            this.addApplicationButton.UseVisualStyleBackColor = true;
            this.addApplicationButton.Click += new System.EventHandler(this.addApplicationButtonClick);
            // 
            // removeApplicationButton
            // 
            this.removeApplicationButton.Location = new System.Drawing.Point(12, 278);
            this.removeApplicationButton.Name = "removeApplicationButton";
            this.removeApplicationButton.Size = new System.Drawing.Size(452, 23);
            this.removeApplicationButton.TabIndex = 26;
            this.removeApplicationButton.Text = "Usuń podanie";
            this.removeApplicationButton.UseVisualStyleBackColor = true;
            this.removeApplicationButton.Click += new System.EventHandler(this.removeApplicationButtonClicked);
            // 
            // ApplicationAdministrationPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 312);
            this.Controls.Add(this.removeApplicationButton);
            this.Controls.Add(this.addApplicationButton);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.applicationsListView);
            this.Controls.Add(this.refreshJobsListLink);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.jobsComboBox);
            this.Controls.Add(this.recruitedTextBox);
            this.Controls.Add(this.label1);
            this.Name = "ApplicationAdministrationPanel";
            this.Text = "Zarządzaj podaniami";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox recruitedTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox jobsComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel refreshJobsListLink;
        private System.Windows.Forms.ListView applicationsListView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Button addApplicationButton;
        private System.Windows.Forms.Button removeApplicationButton;
    }
}