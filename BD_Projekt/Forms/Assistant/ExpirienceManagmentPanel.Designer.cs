namespace BD_Projekt.Forms
{
    partial class ExpirienceManagmentPanel
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
            this.recruitedTextBox = new System.Windows.Forms.TextBox();
            this.fromTimePicker = new System.Windows.Forms.DateTimePicker();
            this.toTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.positionNameTextBox = new System.Windows.Forms.TextBox();
            this.companyNameTextBox = new System.Windows.Forms.TextBox();
            this.expirienceListView = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.companyName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.jobName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.from = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.to = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label6 = new System.Windows.Forms.Label();
            this.addExpirienceButton = new System.Windows.Forms.Button();
            this.refreshExpirienceLink = new System.Windows.Forms.LinkLabel();
            this.removeExpirienceButton = new System.Windows.Forms.Button();
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
            // recruitedTextBox
            // 
            this.recruitedTextBox.Enabled = false;
            this.recruitedTextBox.Location = new System.Drawing.Point(88, 12);
            this.recruitedTextBox.Name = "recruitedTextBox";
            this.recruitedTextBox.Size = new System.Drawing.Size(425, 20);
            this.recruitedTextBox.TabIndex = 1;
            // 
            // fromTimePicker
            // 
            this.fromTimePicker.Location = new System.Drawing.Point(88, 64);
            this.fromTimePicker.Name = "fromTimePicker";
            this.fromTimePicker.Size = new System.Drawing.Size(157, 20);
            this.fromTimePicker.TabIndex = 2;
            // 
            // toTimePicker
            // 
            this.toTimePicker.Location = new System.Drawing.Point(356, 64);
            this.toTimePicker.Name = "toTimePicker";
            this.toTimePicker.Size = new System.Drawing.Size(157, 20);
            this.toTimePicker.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Od";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(329, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Do";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nazwa firmy";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(254, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nazwa stanowiska";
            // 
            // positionNameTextBox
            // 
            this.positionNameTextBox.Location = new System.Drawing.Point(356, 38);
            this.positionNameTextBox.Name = "positionNameTextBox";
            this.positionNameTextBox.Size = new System.Drawing.Size(157, 20);
            this.positionNameTextBox.TabIndex = 8;
            // 
            // companyNameTextBox
            // 
            this.companyNameTextBox.Location = new System.Drawing.Point(88, 38);
            this.companyNameTextBox.Name = "companyNameTextBox";
            this.companyNameTextBox.Size = new System.Drawing.Size(157, 20);
            this.companyNameTextBox.TabIndex = 9;
            // 
            // expirienceListView
            // 
            this.expirienceListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.companyName,
            this.jobName,
            this.from,
            this.to});
            this.expirienceListView.FullRowSelect = true;
            this.expirienceListView.GridLines = true;
            this.expirienceListView.Location = new System.Drawing.Point(12, 147);
            this.expirienceListView.Name = "expirienceListView";
            this.expirienceListView.Size = new System.Drawing.Size(501, 192);
            this.expirienceListView.TabIndex = 10;
            this.expirienceListView.UseCompatibleStateImageBehavior = false;
            this.expirienceListView.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "Numer";
            this.id.Width = 43;
            // 
            // companyName
            // 
            this.companyName.Text = "Nazwa firmy";
            this.companyName.Width = 148;
            // 
            // jobName
            // 
            this.jobName.Text = "Nazwa stanowiska";
            this.jobName.Width = 185;
            // 
            // from
            // 
            this.from.Text = "Od";
            // 
            // to
            // 
            this.to.Text = "Do";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Doświadczenie w bazie danych";
            // 
            // addExpirienceButton
            // 
            this.addExpirienceButton.Location = new System.Drawing.Point(12, 90);
            this.addExpirienceButton.Name = "addExpirienceButton";
            this.addExpirienceButton.Size = new System.Drawing.Size(501, 23);
            this.addExpirienceButton.TabIndex = 12;
            this.addExpirienceButton.Text = "Dodaj doświadczenie";
            this.addExpirienceButton.UseVisualStyleBackColor = true;
            this.addExpirienceButton.Click += new System.EventHandler(this.addExpirienceButtonClicked);
            // 
            // refreshExpirienceLink
            // 
            this.refreshExpirienceLink.AutoSize = true;
            this.refreshExpirienceLink.Location = new System.Drawing.Point(387, 131);
            this.refreshExpirienceLink.Name = "refreshExpirienceLink";
            this.refreshExpirienceLink.Size = new System.Drawing.Size(126, 13);
            this.refreshExpirienceLink.TabIndex = 13;
            this.refreshExpirienceLink.TabStop = true;
            this.refreshExpirienceLink.Text = "Odśwież zawartość tabeli";
            this.refreshExpirienceLink.Click += new System.EventHandler(this.refreshExpiriencesLinkClicked);
            // 
            // removeExpirienceButton
            // 
            this.removeExpirienceButton.Location = new System.Drawing.Point(12, 345);
            this.removeExpirienceButton.Name = "removeExpirienceButton";
            this.removeExpirienceButton.Size = new System.Drawing.Size(501, 23);
            this.removeExpirienceButton.TabIndex = 14;
            this.removeExpirienceButton.Text = "Usuń doświadczenie";
            this.removeExpirienceButton.UseVisualStyleBackColor = true;
            this.removeExpirienceButton.Click += new System.EventHandler(this.removeExpirienceButtonClick);
            // 
            // ExpirienceManagmentPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 384);
            this.Controls.Add(this.removeExpirienceButton);
            this.Controls.Add(this.refreshExpirienceLink);
            this.Controls.Add(this.addExpirienceButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.expirienceListView);
            this.Controls.Add(this.companyNameTextBox);
            this.Controls.Add(this.positionNameTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toTimePicker);
            this.Controls.Add(this.fromTimePicker);
            this.Controls.Add(this.recruitedTextBox);
            this.Controls.Add(this.label1);
            this.Name = "ExpirienceManagmentPanel";
            this.Text = "Zarządzaj doświadczeniem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox recruitedTextBox;
        private System.Windows.Forms.DateTimePicker fromTimePicker;
        private System.Windows.Forms.DateTimePicker toTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox positionNameTextBox;
        private System.Windows.Forms.TextBox companyNameTextBox;
        private System.Windows.Forms.ListView expirienceListView;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader companyName;
        private System.Windows.Forms.ColumnHeader jobName;
        private System.Windows.Forms.ColumnHeader from;
        private System.Windows.Forms.ColumnHeader to;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addExpirienceButton;
        private System.Windows.Forms.LinkLabel refreshExpirienceLink;
        private System.Windows.Forms.Button removeExpirienceButton;
    }
}