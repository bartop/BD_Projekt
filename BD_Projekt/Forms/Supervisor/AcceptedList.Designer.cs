namespace BD_Projekt.Forms
{
    partial class AcceptedList
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
            this.acceptedListView = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.surname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.jobName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.decision = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.removeSelectedApplicationButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.refreshLink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // acceptedListView
            // 
            this.acceptedListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.surname,
            this.jobName,
            this.decision});
            this.acceptedListView.FullRowSelect = true;
            this.acceptedListView.GridLines = true;
            this.acceptedListView.Location = new System.Drawing.Point(12, 25);
            this.acceptedListView.Name = "acceptedListView";
            this.acceptedListView.Size = new System.Drawing.Size(515, 345);
            this.acceptedListView.TabIndex = 6;
            this.acceptedListView.UseCompatibleStateImageBehavior = false;
            this.acceptedListView.View = System.Windows.Forms.View.Details;
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
            // removeSelectedApplicationButton
            // 
            this.removeSelectedApplicationButton.Location = new System.Drawing.Point(12, 376);
            this.removeSelectedApplicationButton.Name = "removeSelectedApplicationButton";
            this.removeSelectedApplicationButton.Size = new System.Drawing.Size(515, 23);
            this.removeSelectedApplicationButton.TabIndex = 11;
            this.removeSelectedApplicationButton.Text = "Usuń podanie i powiązane informacje";
            this.removeSelectedApplicationButton.UseVisualStyleBackColor = true;
            this.removeSelectedApplicationButton.Click += new System.EventHandler(this.removeSelectedApplicationButtonClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Podania z ocenami rekruterów";
            // 
            // refreshLink
            // 
            this.refreshLink.AutoSize = true;
            this.refreshLink.Location = new System.Drawing.Point(480, 9);
            this.refreshLink.Name = "refreshLink";
            this.refreshLink.Size = new System.Drawing.Size(47, 13);
            this.refreshLink.TabIndex = 7;
            this.refreshLink.TabStop = true;
            this.refreshLink.Text = "Odśwież";
            // 
            // AcceptedList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 411);
            this.Controls.Add(this.acceptedListView);
            this.Controls.Add(this.removeSelectedApplicationButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.refreshLink);
            this.Name = "AcceptedList";
            this.Text = "Zaakceptowane oceny";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView acceptedListView;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader surname;
        private System.Windows.Forms.ColumnHeader jobName;
        private System.Windows.Forms.ColumnHeader decision;
        private System.Windows.Forms.Button removeSelectedApplicationButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel refreshLink;
    }
}