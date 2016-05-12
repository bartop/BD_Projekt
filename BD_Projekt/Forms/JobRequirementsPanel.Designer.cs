namespace BD_Projekt
{
    partial class JobRequirementsPanel
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
            this.components = new System.ComponentModel.Container();
            this.jobNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addNewSkillButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.skillWeightTextBox = new System.Windows.Forms.TextBox();
            this.skillsTable = new System.Windows.Forms.DataGridView();
            this.newSkillButton = new System.Windows.Forms.Button();
            this.skillsComboBox = new System.Windows.Forms.ComboBox();
            this.refreshTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.skillsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // jobNameTextBox
            // 
            this.jobNameTextBox.Location = new System.Drawing.Point(12, 15);
            this.jobNameTextBox.Name = "jobNameTextBox";
            this.jobNameTextBox.ReadOnly = true;
            this.jobNameTextBox.Size = new System.Drawing.Size(446, 20);
            this.jobNameTextBox.TabIndex = 1;
            this.jobNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nazwa umiejętności";
            // 
            // addNewSkillButton
            // 
            this.addNewSkillButton.Location = new System.Drawing.Point(291, 72);
            this.addNewSkillButton.Name = "addNewSkillButton";
            this.addNewSkillButton.Size = new System.Drawing.Size(170, 24);
            this.addNewSkillButton.TabIndex = 4;
            this.addNewSkillButton.Text = "Dodaj umiejętność z wagą";
            this.addNewSkillButton.UseVisualStyleBackColor = true;
            this.addNewSkillButton.Click += new System.EventHandler(this.addSkillClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Waga umiejętności";
            // 
            // skillWeightTextBox
            // 
            this.skillWeightTextBox.Location = new System.Drawing.Point(116, 75);
            this.skillWeightTextBox.Name = "skillWeightTextBox";
            this.skillWeightTextBox.Size = new System.Drawing.Size(169, 20);
            this.skillWeightTextBox.TabIndex = 8;
            // 
            // skillsTable
            // 
            this.skillsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.skillsTable.Location = new System.Drawing.Point(12, 112);
            this.skillsTable.Name = "skillsTable";
            this.skillsTable.Size = new System.Drawing.Size(446, 180);
            this.skillsTable.TabIndex = 9;
            // 
            // newSkillButton
            // 
            this.newSkillButton.Location = new System.Drawing.Point(291, 42);
            this.newSkillButton.Name = "newSkillButton";
            this.newSkillButton.Size = new System.Drawing.Size(167, 24);
            this.newSkillButton.TabIndex = 10;
            this.newSkillButton.Text = "Zarządzaj umiejętnościami";
            this.newSkillButton.UseVisualStyleBackColor = true;
            this.newSkillButton.Click += new System.EventHandler(this.newSkillButtonClick);
            // 
            // skillsComboBox
            // 
            this.skillsComboBox.FormattingEnabled = true;
            this.skillsComboBox.Location = new System.Drawing.Point(116, 45);
            this.skillsComboBox.Name = "skillsComboBox";
            this.skillsComboBox.Size = new System.Drawing.Size(169, 21);
            this.skillsComboBox.TabIndex = 11;
            // 
            // refreshTimer
            // 
            this.refreshTimer.Interval = 20000;
            this.refreshTimer.Tick += new System.EventHandler(this.refreshTimerTick);
            // 
            // JobRequirementsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 304);
            this.Controls.Add(this.skillsComboBox);
            this.Controls.Add(this.newSkillButton);
            this.Controls.Add(this.skillsTable);
            this.Controls.Add(this.skillWeightTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addNewSkillButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.jobNameTextBox);
            this.Name = "JobRequirementsPanel";
            this.Text = "Określanie wymagań pracy";
            ((System.ComponentModel.ISupportInitialize)(this.skillsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox jobNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addNewSkillButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox skillWeightTextBox;
        private System.Windows.Forms.DataGridView skillsTable;
        private System.Windows.Forms.Button newSkillButton;
        private System.Windows.Forms.ComboBox skillsComboBox;
        private System.Windows.Forms.Timer refreshTimer;
    }
}