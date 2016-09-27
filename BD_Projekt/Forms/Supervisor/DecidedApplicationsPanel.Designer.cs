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
            this.refreshLink = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.approveButton = new System.Windows.Forms.Button();
            this.disapproveButton = new System.Windows.Forms.Button();
            this.detailsButton = new System.Windows.Forms.Button();
            this.decidedListView = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn4 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn5 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn6 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.decidedListView)).BeginInit();
            this.SuspendLayout();
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
            // decidedListView
            // 
            this.decidedListView.AllColumns.Add(this.olvColumn1);
            this.decidedListView.AllColumns.Add(this.olvColumn2);
            this.decidedListView.AllColumns.Add(this.olvColumn3);
            this.decidedListView.AllColumns.Add(this.olvColumn4);
            this.decidedListView.AllColumns.Add(this.olvColumn5);
            this.decidedListView.AllColumns.Add(this.olvColumn6);
            this.decidedListView.CellEditUseWholeCell = false;
            this.decidedListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.olvColumn2,
            this.olvColumn3,
            this.olvColumn4,
            this.olvColumn5,
            this.olvColumn6});
            this.decidedListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.decidedListView.FullRowSelect = true;
            this.decidedListView.Location = new System.Drawing.Point(15, 25);
            this.decidedListView.Name = "decidedListView";
            this.decidedListView.ShowGroups = false;
            this.decidedListView.Size = new System.Drawing.Size(510, 284);
            this.decidedListView.TabIndex = 48;
            this.decidedListView.UseCompatibleStateImageBehavior = false;
            this.decidedListView.UseFilterIndicator = true;
            this.decidedListView.UseFiltering = true;
            this.decidedListView.UseTranslucentSelection = true;
            this.decidedListView.View = System.Windows.Forms.View.Details;
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "Id";
            this.olvColumn1.Text = "Numer";
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "Recruited.Name";
            this.olvColumn2.Text = "Imię";
            this.olvColumn2.Width = 81;
            // 
            // olvColumn3
            // 
            this.olvColumn3.AspectName = "Recruited.Surname";
            this.olvColumn3.Text = "Nazwisko";
            this.olvColumn3.Width = 102;
            // 
            // olvColumn4
            // 
            this.olvColumn4.AspectName = "Job.Name";
            this.olvColumn4.Text = "Stanowisko";
            this.olvColumn4.Width = 107;
            // 
            // olvColumn5
            // 
            this.olvColumn5.AspectName = "Decision";
            this.olvColumn5.Text = "Decyzja";
            // 
            // olvColumn6
            // 
            this.olvColumn6.AspectName = "Decision.Approval";
            this.olvColumn6.Text = "Akceptacja";
            this.olvColumn6.Width = 81;
            // 
            // DecidedApplicationsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 378);
            this.Controls.Add(this.decidedListView);
            this.Controls.Add(this.detailsButton);
            this.Controls.Add(this.disapproveButton);
            this.Controls.Add(this.approveButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.refreshLink);
            this.Name = "DecidedApplicationsPanel";
            this.Text = "Zaakceptuj oceny podań";
            ((System.ComponentModel.ISupportInitialize)(this.decidedListView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel refreshLink;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button approveButton;
        private System.Windows.Forms.Button disapproveButton;
        private System.Windows.Forms.Button detailsButton;
        private BrightIdeasSoftware.ObjectListView decidedListView;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private BrightIdeasSoftware.OLVColumn olvColumn3;
        private BrightIdeasSoftware.OLVColumn olvColumn4;
        private BrightIdeasSoftware.OLVColumn olvColumn5;
        private BrightIdeasSoftware.OLVColumn olvColumn6;
    }
}