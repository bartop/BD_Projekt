namespace BD_Projekt.Forms
{
    partial class DecidedApplicationsPanel
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
            this.decidedListView = new System.Windows.Forms.ListView();
            this.refreshLink = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.surname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.jobName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.decision = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.approveButton = new System.Windows.Forms.Button();
            this.disapproveButton = new System.Windows.Forms.Button();
            this.detailsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // decidedListView
            // 
            this.decidedListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.surname,
            this.jobName,
            this.decision});
            this.decidedListView.FullRowSelect = true;
            this.decidedListView.GridLines = true;
            this.decidedListView.Location = new System.Drawing.Point(12, 25);
            this.decidedListView.Name = "decidedListView";
            this.decidedListView.Size = new System.Drawing.Size(513, 283);
            this.decidedListView.TabIndex = 0;
            this.decidedListView.UseCompatibleStateImageBehavior = false;
            this.decidedListView.View = System.Windows.Forms.View.Details;
            // 
            // refreshLink
            // 
            this.refreshLink.AutoSize = true;
            this.refreshLink.Location = new System.Drawing.Point(478, 9);
            this.refreshLink.Name = "refreshLink";
            this.refreshLink.Size = new System.Drawing.Size(47, 13);
            this.refreshLink.TabIndex = 1;
            this.refreshLink.TabStop = true;
            this.refreshLink.Text = "Odśwież";
            this.refreshLink.Click += new System.EventHandler(this.refreshLinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Podania z ocenami rekruterów";
            // 
            // name
            // 
            this.name.Text = "Imię";
            this.name.Width = 75;
            // 
            // surname
            // 
            this.surname.Text = "Nazwisko";
            this.surname.Width = 108;
            // 
            // jobName
            // 
            this.jobName.Text = "Nazwa stanowiska";
            this.jobName.Width = 220;
            // 
            // decision
            // 
            this.decision.Text = "Ocena rekrutera";
            this.decision.Width = 103;
            // 
            // approveButton
            // 
            this.approveButton.Location = new System.Drawing.Point(11, 314);
            this.approveButton.Name = "approveButton";
            this.approveButton.Size = new System.Drawing.Size(253, 23);
            this.approveButton.TabIndex = 3;
            this.approveButton.Text = "Zaakceptuj ocenę";
            this.approveButton.UseVisualStyleBackColor = true;
            this.approveButton.Click += new System.EventHandler(this.aproveButtonClicked);
            // 
            // disapproveButton
            // 
            this.disapproveButton.Location = new System.Drawing.Point(272, 314);
            this.disapproveButton.Name = "disapproveButton";
            this.disapproveButton.Size = new System.Drawing.Size(253, 23);
            this.disapproveButton.TabIndex = 4;
            this.disapproveButton.Text = "Odrzuć ocenę";
            this.disapproveButton.UseVisualStyleBackColor = true;
            this.disapproveButton.Click += new System.EventHandler(this.disapproveButtonClicked);
            // 
            // detailsButton
            // 
            this.detailsButton.Location = new System.Drawing.Point(11, 343);
            this.detailsButton.Name = "detailsButton";
            this.detailsButton.Size = new System.Drawing.Size(514, 23);
            this.detailsButton.TabIndex = 5;
            this.detailsButton.Text = "Szczegóły podania";
            this.detailsButton.UseVisualStyleBackColor = true;
            this.detailsButton.Click += new System.EventHandler(this.datailsButtonClicked);
            // 
            // DecidedApplicationsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 378);
            this.Controls.Add(this.detailsButton);
            this.Controls.Add(this.disapproveButton);
            this.Controls.Add(this.approveButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.refreshLink);
            this.Controls.Add(this.decidedListView);
            this.Name = "DecidedApplicationsPanel";
            this.Text = "Zaakceptuj oceny podań";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView decidedListView;
        private System.Windows.Forms.LinkLabel refreshLink;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader surname;
        private System.Windows.Forms.ColumnHeader jobName;
        private System.Windows.Forms.ColumnHeader decision;
        private System.Windows.Forms.Button approveButton;
        private System.Windows.Forms.Button disapproveButton;
        private System.Windows.Forms.Button detailsButton;
    }
}