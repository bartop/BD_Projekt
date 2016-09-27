namespace BD_Projekt
{
    partial class RecruitedAdministrationPanel
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
            this.label2 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.surname = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.nationalityGui = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.phoneNumber = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.birthDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.refreshListBoxLabel = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.manageDocuments = new System.Windows.Forms.Button();
            this.showDataButton = new System.Windows.Forms.Button();
            this.manageApplications = new System.Windows.Forms.Button();
            this.manageEducation = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.manageExperience = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.recruitedListView = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn4 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recruitedListView)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.helpProvider1.SetHelpKeyword(this.label2, "Imię");
            this.label2.Location = new System.Drawing.Point(12, 10);
            this.label2.Name = "label2";
            this.helpProvider1.SetShowHelp(this.label2, true);
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Imię";
            // 
            // name
            // 
            this.name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.helpProvider1.SetHelpKeyword(this.name, "imie");
            this.helpProvider1.SetHelpNavigator(this.name, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.name.Location = new System.Drawing.Point(80, 7);
            this.name.Name = "name";
            this.helpProvider1.SetShowHelp(this.name, true);
            this.name.Size = new System.Drawing.Size(121, 20);
            this.name.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nazwisko";
            // 
            // surname
            // 
            this.helpProvider1.SetHelpKeyword(this.surname, "nazwisko");
            this.helpProvider1.SetHelpNavigator(this.surname, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.surname.Location = new System.Drawing.Point(80, 33);
            this.surname.Name = "surname";
            this.helpProvider1.SetShowHelp(this.surname, true);
            this.surname.Size = new System.Drawing.Size(121, 20);
            this.surname.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(252, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Obywatelstwo";
            // 
            // nationalityGui
            // 
            this.nationalityGui.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nationalityGui.FormattingEnabled = true;
            this.helpProvider1.SetHelpKeyword(this.nationalityGui, "obywatelstwo");
            this.helpProvider1.SetHelpNavigator(this.nationalityGui, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.nationalityGui.Location = new System.Drawing.Point(356, 6);
            this.nationalityGui.Name = "nationalityGui";
            this.helpProvider1.SetShowHelp(this.nationalityGui, true);
            this.nationalityGui.Size = new System.Drawing.Size(121, 21);
            this.nationalityGui.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(252, 36);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "Data urodzenia";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(252, 62);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 13);
            this.label15.TabIndex = 28;
            this.label15.Text = "Adres e-mail";
            // 
            // email
            // 
            this.helpProvider1.SetHelpKeyword(this.email, "email");
            this.helpProvider1.SetHelpNavigator(this.email, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.helpProvider1.SetHelpString(this.email, "");
            this.email.Location = new System.Drawing.Point(356, 59);
            this.email.Name = "email";
            this.helpProvider1.SetShowHelp(this.email, true);
            this.email.Size = new System.Drawing.Size(121, 20);
            this.email.TabIndex = 6;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 62);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(43, 13);
            this.label16.TabIndex = 30;
            this.label16.Text = "Telefon";
            // 
            // phoneNumber
            // 
            this.helpProvider1.SetHelpKeyword(this.phoneNumber, "telefon");
            this.helpProvider1.SetHelpNavigator(this.phoneNumber, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.phoneNumber.Location = new System.Drawing.Point(80, 59);
            this.phoneNumber.Name = "phoneNumber";
            this.helpProvider1.SetShowHelp(this.phoneNumber, true);
            this.phoneNumber.Size = new System.Drawing.Size(121, 20);
            this.phoneNumber.TabIndex = 3;
            // 
            // button5
            // 
            this.helpProvider1.SetHelpKeyword(this.button5, "dodawanie danych rekrutowanego");
            this.helpProvider1.SetHelpNavigator(this.button5, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.button5.Location = new System.Drawing.Point(12, 85);
            this.button5.Name = "button5";
            this.helpProvider1.SetShowHelp(this.button5, true);
            this.button5.Size = new System.Drawing.Size(465, 25);
            this.button5.TabIndex = 7;
            this.button5.Text = "Potwierdź informacje i dodaj do bazy";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.confirmClick);
            // 
            // birthDate
            // 
            this.birthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.helpProvider1.SetHelpKeyword(this.birthDate, "data urodzenia");
            this.helpProvider1.SetHelpNavigator(this.birthDate, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.birthDate.Location = new System.Drawing.Point(357, 33);
            this.birthDate.Name = "birthDate";
            this.helpProvider1.SetShowHelp(this.birthDate, true);
            this.birthDate.Size = new System.Drawing.Size(120, 20);
            this.birthDate.TabIndex = 5;
            this.birthDate.Value = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Lista rekrutowanych w bazie danych";
            // 
            // refreshListBoxLabel
            // 
            this.refreshListBoxLabel.AutoSize = true;
            this.refreshListBoxLabel.Location = new System.Drawing.Point(362, 147);
            this.refreshListBoxLabel.Name = "refreshListBoxLabel";
            this.refreshListBoxLabel.Size = new System.Drawing.Size(118, 13);
            this.refreshListBoxLabel.TabIndex = 43;
            this.refreshListBoxLabel.TabStop = true;
            this.refreshListBoxLabel.Text = "Odśwież zawartość listy";
            this.refreshListBoxLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.refreshLinkLabelClicked);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.manageDocuments, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.showDataButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.manageApplications, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.manageEducation, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.removeButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.manageExperience, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 453);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(465, 84);
            this.tableLayoutPanel1.TabIndex = 44;
            // 
            // manageDocuments
            // 
            this.manageDocuments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.helpProvider1.SetHelpKeyword(this.manageDocuments, "zarzadzaj dokumentami");
            this.helpProvider1.SetHelpNavigator(this.manageDocuments, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.manageDocuments.Location = new System.Drawing.Point(3, 58);
            this.manageDocuments.Name = "manageDocuments";
            this.helpProvider1.SetShowHelp(this.manageDocuments, true);
            this.manageDocuments.Size = new System.Drawing.Size(226, 23);
            this.manageDocuments.TabIndex = 17;
            this.manageDocuments.Text = "Zarządzaj dokumentami";
            this.manageDocuments.UseVisualStyleBackColor = true;
            this.manageDocuments.Click += new System.EventHandler(this.manageDocumentsButtonClicked);
            // 
            // showDataButton
            // 
            this.showDataButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.helpProvider1.SetHelpKeyword(this.showDataButton, "wyswietl dane osobowe");
            this.helpProvider1.SetHelpNavigator(this.showDataButton, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.showDataButton.Location = new System.Drawing.Point(235, 58);
            this.showDataButton.Name = "showDataButton";
            this.helpProvider1.SetShowHelp(this.showDataButton, true);
            this.showDataButton.Size = new System.Drawing.Size(227, 23);
            this.showDataButton.TabIndex = 16;
            this.showDataButton.Text = "Wyświetl dane osobowe";
            this.showDataButton.UseVisualStyleBackColor = true;
            this.showDataButton.Click += new System.EventHandler(this.showDataButtonClicked);
            // 
            // manageApplications
            // 
            this.manageApplications.Dock = System.Windows.Forms.DockStyle.Fill;
            this.helpProvider1.SetHelpKeyword(this.manageApplications, "zarzadzaj aplikacjami");
            this.helpProvider1.SetHelpNavigator(this.manageApplications, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.manageApplications.Location = new System.Drawing.Point(235, 30);
            this.manageApplications.Name = "manageApplications";
            this.helpProvider1.SetShowHelp(this.manageApplications, true);
            this.manageApplications.Size = new System.Drawing.Size(227, 22);
            this.manageApplications.TabIndex = 15;
            this.manageApplications.Text = "Zarządzaj aplikacjami";
            this.manageApplications.UseVisualStyleBackColor = true;
            this.manageApplications.Click += new System.EventHandler(this.manageApplicationsButtonClicked);
            // 
            // manageEducation
            // 
            this.manageEducation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.helpProvider1.SetHelpKeyword(this.manageEducation, "zarzadzaj edukacja");
            this.helpProvider1.SetHelpNavigator(this.manageEducation, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.manageEducation.Location = new System.Drawing.Point(3, 30);
            this.manageEducation.Name = "manageEducation";
            this.helpProvider1.SetShowHelp(this.manageEducation, true);
            this.manageEducation.Size = new System.Drawing.Size(226, 22);
            this.manageEducation.TabIndex = 14;
            this.manageEducation.Text = "Zarządzaj edukacją";
            this.manageEducation.UseVisualStyleBackColor = true;
            this.manageEducation.Click += new System.EventHandler(this.manageEducationButtonClicked);
            // 
            // removeButton
            // 
            this.removeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.helpProvider1.SetHelpKeyword(this.removeButton, "usun rekrutowanego");
            this.helpProvider1.SetHelpNavigator(this.removeButton, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.removeButton.Location = new System.Drawing.Point(3, 3);
            this.removeButton.Name = "removeButton";
            this.helpProvider1.SetShowHelp(this.removeButton, true);
            this.removeButton.Size = new System.Drawing.Size(226, 21);
            this.removeButton.TabIndex = 11;
            this.removeButton.Text = "Usuń rekrutowanego";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeRecruitedButtonClicked);
            // 
            // manageExperience
            // 
            this.manageExperience.Dock = System.Windows.Forms.DockStyle.Fill;
            this.helpProvider1.SetHelpKeyword(this.manageExperience, "zarzadzaj doswiadczeniem");
            this.helpProvider1.SetHelpNavigator(this.manageExperience, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.manageExperience.Location = new System.Drawing.Point(235, 3);
            this.manageExperience.Name = "manageExperience";
            this.helpProvider1.SetShowHelp(this.manageExperience, true);
            this.manageExperience.Size = new System.Drawing.Size(227, 21);
            this.manageExperience.TabIndex = 12;
            this.manageExperience.Text = "Zarządzaj doświadczeniem";
            this.manageExperience.UseVisualStyleBackColor = true;
            this.manageExperience.Click += new System.EventHandler(this.manageExpirienceButtonClicked);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "Help Files\\help.chm";
            // 
            // recruitedListView
            // 
            this.recruitedListView.AllColumns.Add(this.olvColumn1);
            this.recruitedListView.AllColumns.Add(this.olvColumn2);
            this.recruitedListView.AllColumns.Add(this.olvColumn3);
            this.recruitedListView.AllColumns.Add(this.olvColumn4);
            this.recruitedListView.CellEditUseWholeCell = false;
            this.recruitedListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.olvColumn2,
            this.olvColumn3,
            this.olvColumn4});
            this.recruitedListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.recruitedListView.FullRowSelect = true;
            this.helpProvider1.SetHelpKeyword(this.recruitedListView, "zarzadzanie rekrutowanymi");
            this.helpProvider1.SetHelpNavigator(this.recruitedListView, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.recruitedListView.Location = new System.Drawing.Point(12, 163);
            this.recruitedListView.Name = "recruitedListView";
            this.recruitedListView.ShowGroups = false;
            this.helpProvider1.SetShowHelp(this.recruitedListView, true);
            this.recruitedListView.Size = new System.Drawing.Size(465, 284);
            this.recruitedListView.TabIndex = 47;
            this.recruitedListView.UseCompatibleStateImageBehavior = false;
            this.recruitedListView.UseFilterIndicator = true;
            this.recruitedListView.UseFiltering = true;
            this.recruitedListView.UseTranslucentSelection = true;
            this.recruitedListView.View = System.Windows.Forms.View.Details;
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "Id";
            this.olvColumn1.Text = "Numer";
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "Name";
            this.olvColumn2.Text = "Imię";
            this.olvColumn2.Width = 123;
            // 
            // olvColumn3
            // 
            this.olvColumn3.AspectName = "Surname";
            this.olvColumn3.Text = "Nazwisko";
            this.olvColumn3.Width = 179;
            // 
            // olvColumn4
            // 
            this.olvColumn4.AspectName = "Email";
            this.olvColumn4.Text = "Email";
            this.olvColumn4.Width = 260;
            // 
            // RecruitedAdministrationPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 549);
            this.Controls.Add(this.recruitedListView);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.refreshListBoxLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.birthDate);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.phoneNumber);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.nationalityGui);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label2);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RecruitedAdministrationPanel";
            this.Text = "Panel asystentki - rejestracja";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.recruitedListView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox surname;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox nationalityGui;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox phoneNumber;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DateTimePicker birthDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel refreshListBoxLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button manageExperience;
        private System.Windows.Forms.Button manageApplications;
        private System.Windows.Forms.Button manageEducation;
        private System.Windows.Forms.Button manageDocuments;
        private System.Windows.Forms.Button showDataButton;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private BrightIdeasSoftware.ObjectListView recruitedListView;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private BrightIdeasSoftware.OLVColumn olvColumn3;
        private BrightIdeasSoftware.OLVColumn olvColumn4;
    }
}