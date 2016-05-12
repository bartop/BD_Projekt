namespace BD_Projekt.Forms
{
    partial class SkillsAdministrationPanel
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
            this.skillListView = new System.Windows.Forms.ListView();
            this.listBoxLabel = new System.Windows.Forms.Label();
            this.skillNameTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.refreshTimer = new System.Windows.Forms.Timer(this.components);
            this.deleteSkillButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // skillListView
            // 
            this.skillListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.skillListView.HoverSelection = true;
            this.skillListView.Location = new System.Drawing.Point(12, 66);
            this.skillListView.Name = "skillListView";
            this.skillListView.Size = new System.Drawing.Size(425, 161);
            this.skillListView.TabIndex = 0;
            this.skillListView.UseCompatibleStateImageBehavior = false;
            this.skillListView.View = System.Windows.Forms.View.List;
            // 
            // listBoxLabel
            // 
            this.listBoxLabel.AutoSize = true;
            this.listBoxLabel.Location = new System.Drawing.Point(9, 50);
            this.listBoxLabel.Name = "listBoxLabel";
            this.listBoxLabel.Size = new System.Drawing.Size(167, 13);
            this.listBoxLabel.TabIndex = 1;
            this.listBoxLabel.Text = "Lista umiejętności w bazie danych";
            // 
            // skillNameTextBox
            // 
            this.skillNameTextBox.Location = new System.Drawing.Point(119, 14);
            this.skillNameTextBox.Name = "skillNameTextBox";
            this.skillNameTextBox.Size = new System.Drawing.Size(164, 20);
            this.skillNameTextBox.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(289, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Dodaj do listy umiejętności";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.addSkillButtonClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nazwa umiejętności";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(227, 233);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(210, 23);
            this.closeButton.TabIndex = 5;
            this.closeButton.Text = "Zamknij okno";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButtonClick);
            // 
            // refreshTimer
            // 
            this.refreshTimer.Enabled = true;
            this.refreshTimer.Interval = 20000;
            this.refreshTimer.Tick += new System.EventHandler(this.refreshTimerTick);
            // 
            // deleteSkillButton
            // 
            this.deleteSkillButton.Location = new System.Drawing.Point(12, 233);
            this.deleteSkillButton.Name = "deleteSkillButton";
            this.deleteSkillButton.Size = new System.Drawing.Size(210, 23);
            this.deleteSkillButton.TabIndex = 7;
            this.deleteSkillButton.Text = "Usuń umiejętność z listy";
            this.deleteSkillButton.UseVisualStyleBackColor = true;
            this.deleteSkillButton.Click += new System.EventHandler(this.deleteSkillButtonClick);
            // 
            // SkillsAdministrationPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 269);
            this.Controls.Add(this.deleteSkillButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.skillNameTextBox);
            this.Controls.Add(this.listBoxLabel);
            this.Controls.Add(this.skillListView);
            this.Name = "SkillsAdministrationPanel";
            this.Text = "Administracja umiejętnościami";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView skillListView;
        private System.Windows.Forms.Label listBoxLabel;
        private System.Windows.Forms.TextBox skillNameTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Timer refreshTimer;
        private System.Windows.Forms.Button deleteSkillButton;
    }
}