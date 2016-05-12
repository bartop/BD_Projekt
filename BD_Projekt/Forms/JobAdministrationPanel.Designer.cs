namespace BD_Projekt.Forms
{
    partial class JobAdministrationPanel
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
            this.closeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.addJobButton = new System.Windows.Forms.Button();
            this.jobNameTextBox = new System.Windows.Forms.TextBox();
            this.listBoxLabel = new System.Windows.Forms.Label();
            this.jobsListView = new System.Windows.Forms.ListView();
            this.refreshTimer = new System.Windows.Forms.Timer(this.components);
            this.deleteJobButton = new System.Windows.Forms.Button();
            this.changeJobNameButton = new System.Windows.Forms.Button();
            this.jobDetailsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(12, 261);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(425, 23);
            this.closeButton.TabIndex = 13;
            this.closeButton.Text = "Zamknij okno";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButtonClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nazwa stanowiska";
            // 
            // addJobButton
            // 
            this.addJobButton.Location = new System.Drawing.Point(307, 10);
            this.addJobButton.Name = "addJobButton";
            this.addJobButton.Size = new System.Drawing.Size(130, 23);
            this.addJobButton.TabIndex = 11;
            this.addJobButton.Text = "Dodaj do listy stanowisk";
            this.addJobButton.UseVisualStyleBackColor = true;
            // 
            // jobNameTextBox
            // 
            this.jobNameTextBox.Location = new System.Drawing.Point(111, 12);
            this.jobNameTextBox.Name = "jobNameTextBox";
            this.jobNameTextBox.Size = new System.Drawing.Size(190, 20);
            this.jobNameTextBox.TabIndex = 10;
            // 
            // listBoxLabel
            // 
            this.listBoxLabel.AutoSize = true;
            this.listBoxLabel.Location = new System.Drawing.Point(9, 48);
            this.listBoxLabel.Name = "listBoxLabel";
            this.listBoxLabel.Size = new System.Drawing.Size(156, 13);
            this.listBoxLabel.TabIndex = 9;
            this.listBoxLabel.Text = "Lista stanowisk w bazie danych";
            // 
            // jobsListView
            // 
            this.jobsListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.jobsListView.HoverSelection = true;
            this.jobsListView.Location = new System.Drawing.Point(12, 64);
            this.jobsListView.Name = "jobsListView";
            this.jobsListView.Size = new System.Drawing.Size(425, 161);
            this.jobsListView.TabIndex = 8;
            this.jobsListView.UseCompatibleStateImageBehavior = false;
            this.jobsListView.View = System.Windows.Forms.View.List;
            // 
            // refreshTimer
            // 
            this.refreshTimer.Enabled = true;
            this.refreshTimer.Interval = 20000;
            this.refreshTimer.Tick += new System.EventHandler(this.refreshTimerTick);
            // 
            // deleteJobButton
            // 
            this.deleteJobButton.Location = new System.Drawing.Point(12, 231);
            this.deleteJobButton.Name = "deleteJobButton";
            this.deleteJobButton.Size = new System.Drawing.Size(138, 23);
            this.deleteJobButton.TabIndex = 14;
            this.deleteJobButton.Text = "Usuń stanowisko z listy";
            this.deleteJobButton.UseVisualStyleBackColor = true;
            this.deleteJobButton.Click += new System.EventHandler(this.removeJobClick);
            // 
            // changeJobNameButton
            // 
            this.changeJobNameButton.Location = new System.Drawing.Point(156, 231);
            this.changeJobNameButton.Name = "changeJobNameButton";
            this.changeJobNameButton.Size = new System.Drawing.Size(138, 23);
            this.changeJobNameButton.TabIndex = 15;
            this.changeJobNameButton.Text = "Zmień nazwę stanowiska";
            this.changeJobNameButton.UseVisualStyleBackColor = true;
            this.changeJobNameButton.Click += new System.EventHandler(this.changeNameButtonClick);
            // 
            // jobDetailsButton
            // 
            this.jobDetailsButton.Location = new System.Drawing.Point(300, 232);
            this.jobDetailsButton.Name = "jobDetailsButton";
            this.jobDetailsButton.Size = new System.Drawing.Size(137, 23);
            this.jobDetailsButton.TabIndex = 16;
            this.jobDetailsButton.Text = "Szczególy stanowiska";
            this.jobDetailsButton.UseVisualStyleBackColor = true;
            this.jobDetailsButton.Click += new System.EventHandler(this.detailsButtonClick);
            // 
            // JobAdministrationPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 296);
            this.Controls.Add(this.jobDetailsButton);
            this.Controls.Add(this.changeJobNameButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addJobButton);
            this.Controls.Add(this.jobNameTextBox);
            this.Controls.Add(this.listBoxLabel);
            this.Controls.Add(this.jobsListView);
            this.Controls.Add(this.deleteJobButton);
            this.Name = "JobAdministrationPanel";
            this.Text = "JobAdministrationPanel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addJobButton;
        private System.Windows.Forms.TextBox jobNameTextBox;
        private System.Windows.Forms.Label listBoxLabel;
        private System.Windows.Forms.ListView jobsListView;
        private System.Windows.Forms.Timer refreshTimer;
        private System.Windows.Forms.Button deleteJobButton;
        private System.Windows.Forms.Button changeJobNameButton;
        private System.Windows.Forms.Button jobDetailsButton;
    }
}