namespace BD_Projekt.Forms
{
    partial class EducationAdministrationForm
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
            this.removeEducationButton = new System.Windows.Forms.Button();
            this.addEducationButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.to = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.from = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.educationName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.schoolName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.refreshEducationLink = new System.Windows.Forms.LinkLabel();
            this.educationListView = new System.Windows.Forms.ListView();
            this.schoolNameTextBox = new System.Windows.Forms.TextBox();
            this.educationNameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fromTimePicker = new System.Windows.Forms.DateTimePicker();
            this.recruitedTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // removeEducationButton
            // 
            this.removeEducationButton.Location = new System.Drawing.Point(12, 345);
            this.removeEducationButton.Name = "removeEducationButton";
            this.removeEducationButton.Size = new System.Drawing.Size(504, 23);
            this.removeEducationButton.TabIndex = 29;
            this.removeEducationButton.Text = "Usuń wpis";
            this.removeEducationButton.UseVisualStyleBackColor = true;
            this.removeEducationButton.Click += new System.EventHandler(this.removeEducationButtonClick);
            // 
            // addEducationButton
            // 
            this.addEducationButton.Location = new System.Drawing.Point(12, 90);
            this.addEducationButton.Name = "addEducationButton";
            this.addEducationButton.Size = new System.Drawing.Size(504, 23);
            this.addEducationButton.TabIndex = 27;
            this.addEducationButton.Text = "Dodaj ścieżkę edukacji";
            this.addEducationButton.UseVisualStyleBackColor = true;
            this.addEducationButton.Click += new System.EventHandler(this.addEducationButtonClicked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Doświadczenie w bazie danych";
            // 
            // to
            // 
            this.to.Text = "Do";
            // 
            // from
            // 
            this.from.Text = "Od";
            // 
            // educationName
            // 
            this.educationName.Text = "Nazwa kierunku";
            this.educationName.Width = 185;
            // 
            // schoolName
            // 
            this.schoolName.Text = "Nazwa szkoły";
            this.schoolName.Width = 148;
            // 
            // id
            // 
            this.id.Text = "Numer";
            this.id.Width = 43;
            // 
            // refreshEducationLink
            // 
            this.refreshEducationLink.AutoSize = true;
            this.refreshEducationLink.Location = new System.Drawing.Point(390, 131);
            this.refreshEducationLink.Name = "refreshEducationLink";
            this.refreshEducationLink.Size = new System.Drawing.Size(126, 13);
            this.refreshEducationLink.TabIndex = 28;
            this.refreshEducationLink.TabStop = true;
            this.refreshEducationLink.Text = "Odśwież zawartość tabeli";
            this.refreshEducationLink.Click += new System.EventHandler(this.refreshEducationLinkClicked);
            // 
            // educationListView
            // 
            this.educationListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.schoolName,
            this.educationName,
            this.from,
            this.to});
            this.educationListView.FullRowSelect = true;
            this.educationListView.GridLines = true;
            this.educationListView.Location = new System.Drawing.Point(12, 147);
            this.educationListView.Name = "educationListView";
            this.educationListView.Size = new System.Drawing.Size(504, 192);
            this.educationListView.TabIndex = 25;
            this.educationListView.UseCompatibleStateImageBehavior = false;
            this.educationListView.View = System.Windows.Forms.View.Details;
            // 
            // schoolNameTextBox
            // 
            this.schoolNameTextBox.Location = new System.Drawing.Point(88, 38);
            this.schoolNameTextBox.Name = "schoolNameTextBox";
            this.schoolNameTextBox.Size = new System.Drawing.Size(157, 20);
            this.schoolNameTextBox.TabIndex = 24;
            // 
            // educationNameTextBox
            // 
            this.educationNameTextBox.Location = new System.Drawing.Point(359, 38);
            this.educationNameTextBox.Name = "educationNameTextBox";
            this.educationNameTextBox.Size = new System.Drawing.Size(157, 20);
            this.educationNameTextBox.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(269, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Nazwa kierunku";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Szkoła";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(332, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Do";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Od";
            // 
            // toTimePicker
            // 
            this.toTimePicker.Location = new System.Drawing.Point(359, 64);
            this.toTimePicker.Name = "toTimePicker";
            this.toTimePicker.Size = new System.Drawing.Size(157, 20);
            this.toTimePicker.TabIndex = 18;
            // 
            // fromTimePicker
            // 
            this.fromTimePicker.Location = new System.Drawing.Point(88, 64);
            this.fromTimePicker.Name = "fromTimePicker";
            this.fromTimePicker.Size = new System.Drawing.Size(157, 20);
            this.fromTimePicker.TabIndex = 17;
            // 
            // recruitedTextBox
            // 
            this.recruitedTextBox.Enabled = false;
            this.recruitedTextBox.Location = new System.Drawing.Point(88, 12);
            this.recruitedTextBox.Name = "recruitedTextBox";
            this.recruitedTextBox.Size = new System.Drawing.Size(428, 20);
            this.recruitedTextBox.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Rekrutowany";
            // 
            // EducationAdministrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 382);
            this.Controls.Add(this.removeEducationButton);
            this.Controls.Add(this.addEducationButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.refreshEducationLink);
            this.Controls.Add(this.educationListView);
            this.Controls.Add(this.schoolNameTextBox);
            this.Controls.Add(this.educationNameTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toTimePicker);
            this.Controls.Add(this.fromTimePicker);
            this.Controls.Add(this.recruitedTextBox);
            this.Controls.Add(this.label1);
            this.Name = "EducationAdministrationForm";
            this.Text = "EducationAdministrationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button removeEducationButton;
        private System.Windows.Forms.Button addEducationButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ColumnHeader to;
        private System.Windows.Forms.ColumnHeader from;
        private System.Windows.Forms.ColumnHeader educationName;
        private System.Windows.Forms.ColumnHeader schoolName;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.LinkLabel refreshEducationLink;
        private System.Windows.Forms.ListView educationListView;
        private System.Windows.Forms.TextBox schoolNameTextBox;
        private System.Windows.Forms.TextBox educationNameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker toTimePicker;
        private System.Windows.Forms.DateTimePicker fromTimePicker;
        private System.Windows.Forms.TextBox recruitedTextBox;
        private System.Windows.Forms.Label label1;
    }
}