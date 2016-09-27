namespace BD_Projekt.Forms
{
    partial class UserAdministrationPanel
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
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.repeatPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.roleChooser = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.createNewUserButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.refreshLabel = new System.Windows.Forms.LinkLabel();
            this.removeUserButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.usersListView = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn5 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn4 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersListView)).BeginInit();
            this.SuspendLayout();
            // 
            // loginTextBox
            // 
            this.loginTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.helpProvider1.SetHelpKeyword(this.loginTextBox, "login");
            this.helpProvider1.SetHelpNavigator(this.loginTextBox, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.loginTextBox.Location = new System.Drawing.Point(123, 12);
            this.loginTextBox.Name = "loginTextBox";
            this.helpProvider1.SetShowHelp(this.loginTextBox, true);
            this.loginTextBox.Size = new System.Drawing.Size(324, 20);
            this.loginTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.helpProvider1.SetHelpKeyword(this.passwordTextBox, "haslo");
            this.helpProvider1.SetHelpNavigator(this.passwordTextBox, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.passwordTextBox.Location = new System.Drawing.Point(123, 90);
            this.passwordTextBox.Name = "passwordTextBox";
            this.helpProvider1.SetShowHelp(this.passwordTextBox, true);
            this.passwordTextBox.Size = new System.Drawing.Size(324, 20);
            this.passwordTextBox.TabIndex = 3;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hasło";
            // 
            // repeatPasswordTextBox
            // 
            this.repeatPasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.helpProvider1.SetHelpKeyword(this.repeatPasswordTextBox, "powtorz haslo");
            this.helpProvider1.SetHelpNavigator(this.repeatPasswordTextBox, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.repeatPasswordTextBox.Location = new System.Drawing.Point(123, 116);
            this.repeatPasswordTextBox.Name = "repeatPasswordTextBox";
            this.helpProvider1.SetShowHelp(this.repeatPasswordTextBox, true);
            this.repeatPasswordTextBox.Size = new System.Drawing.Size(324, 20);
            this.repeatPasswordTextBox.TabIndex = 4;
            this.repeatPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Potwierdź hasło";
            // 
            // roleChooser
            // 
            this.roleChooser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roleChooser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roleChooser.FormattingEnabled = true;
            this.helpProvider1.SetHelpKeyword(this.roleChooser, "grupa");
            this.helpProvider1.SetHelpNavigator(this.roleChooser, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.roleChooser.Location = new System.Drawing.Point(123, 142);
            this.roleChooser.Name = "roleChooser";
            this.helpProvider1.SetShowHelp(this.roleChooser, true);
            this.roleChooser.Size = new System.Drawing.Size(324, 21);
            this.roleChooser.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Grupa";
            // 
            // createNewUserButton
            // 
            this.createNewUserButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.helpProvider1.SetHelpKeyword(this.createNewUserButton, "dodaj uzytkownika");
            this.helpProvider1.SetHelpNavigator(this.createNewUserButton, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.createNewUserButton.Location = new System.Drawing.Point(12, 169);
            this.createNewUserButton.Name = "createNewUserButton";
            this.helpProvider1.SetShowHelp(this.createNewUserButton, true);
            this.createNewUserButton.Size = new System.Drawing.Size(436, 23);
            this.createNewUserButton.TabIndex = 6;
            this.createNewUserButton.Text = "Potwierdź i utwórz użytkownika";
            this.createNewUserButton.UseVisualStyleBackColor = true;
            this.createNewUserButton.Click += new System.EventHandler(this.createNewUserButtonClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Lista użytkowników w bazie";
            // 
            // refreshLabel
            // 
            this.refreshLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshLabel.AutoSize = true;
            this.refreshLabel.Location = new System.Drawing.Point(310, 227);
            this.refreshLabel.Name = "refreshLabel";
            this.refreshLabel.Size = new System.Drawing.Size(138, 13);
            this.refreshLabel.TabIndex = 17;
            this.refreshLabel.TabStop = true;
            this.refreshLabel.Text = "Odśwież listę użytkowników";
            this.refreshLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.refreshLabelClick);
            // 
            // removeUserButton
            // 
            this.removeUserButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.helpProvider1.SetHelpKeyword(this.removeUserButton, "lista uzytkownikow");
            this.helpProvider1.SetHelpNavigator(this.removeUserButton, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.removeUserButton.Location = new System.Drawing.Point(83, 3);
            this.removeUserButton.Name = "removeUserButton";
            this.helpProvider1.SetShowHelp(this.removeUserButton, true);
            this.removeUserButton.Size = new System.Drawing.Size(130, 23);
            this.removeUserButton.TabIndex = 18;
            this.removeUserButton.Text = "Usuń użytkownika";
            this.removeUserButton.UseVisualStyleBackColor = true;
            this.removeUserButton.Click += new System.EventHandler(this.removeUserButtonClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(219, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Zamknij okno ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.closeButtonClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Nazwisko";
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.helpProvider1.SetHelpKeyword(this.surnameTextBox, "nazwisko uzytkownika");
            this.helpProvider1.SetHelpNavigator(this.surnameTextBox, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.surnameTextBox.Location = new System.Drawing.Point(123, 64);
            this.surnameTextBox.Name = "surnameTextBox";
            this.helpProvider1.SetShowHelp(this.surnameTextBox, true);
            this.surnameTextBox.Size = new System.Drawing.Size(324, 20);
            this.surnameTextBox.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Imię";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.helpProvider1.SetHelpKeyword(this.nameTextBox, "imie uzytkownika");
            this.helpProvider1.SetHelpNavigator(this.nameTextBox, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.nameTextBox.Location = new System.Drawing.Point(123, 38);
            this.nameTextBox.Name = "nameTextBox";
            this.helpProvider1.SetShowHelp(this.nameTextBox, true);
            this.nameTextBox.Size = new System.Drawing.Size(324, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.removeUserButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 389);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(433, 32);
            this.tableLayoutPanel1.TabIndex = 24;
            // 
            // usersListView
            // 
            this.usersListView.AllColumns.Add(this.olvColumn1);
            this.usersListView.AllColumns.Add(this.olvColumn5);
            this.usersListView.AllColumns.Add(this.olvColumn2);
            this.usersListView.AllColumns.Add(this.olvColumn3);
            this.usersListView.AllColumns.Add(this.olvColumn4);
            this.usersListView.CellEditUseWholeCell = false;
            this.usersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.olvColumn5,
            this.olvColumn2,
            this.olvColumn3,
            this.olvColumn4});
            this.usersListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.usersListView.FullRowSelect = true;
            this.helpProvider1.SetHelpKeyword(this.usersListView, "lista uzytkownikow");
            this.helpProvider1.SetHelpNavigator(this.usersListView, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.usersListView.Location = new System.Drawing.Point(15, 243);
            this.usersListView.Name = "usersListView";
            this.usersListView.ShowGroups = false;
            this.helpProvider1.SetShowHelp(this.usersListView, true);
            this.usersListView.Size = new System.Drawing.Size(433, 140);
            this.usersListView.TabIndex = 46;
            this.usersListView.UseCompatibleStateImageBehavior = false;
            this.usersListView.UseFilterIndicator = true;
            this.usersListView.UseFiltering = true;
            this.usersListView.UseTranslucentSelection = true;
            this.usersListView.View = System.Windows.Forms.View.Details;
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "Id";
            this.olvColumn1.Text = "Numer";
            this.olvColumn1.Width = 45;
            // 
            // olvColumn5
            // 
            this.olvColumn5.AspectName = "Login";
            this.olvColumn5.Text = "Login";
            this.olvColumn5.Width = 69;
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "Name";
            this.olvColumn2.Text = "Imię";
            this.olvColumn2.Width = 90;
            // 
            // olvColumn3
            // 
            this.olvColumn3.AspectName = "Surname";
            this.olvColumn3.Text = "Nazwisko";
            this.olvColumn3.Width = 111;
            // 
            // olvColumn4
            // 
            this.olvColumn4.AspectName = "Roles.Name";
            this.olvColumn4.Text = "Email";
            this.olvColumn4.Width = 260;
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "Help Files\\help.chm";
            // 
            // UserAdministrationPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 426);
            this.Controls.Add(this.usersListView);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.refreshLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.createNewUserButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.roleChooser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.repeatPasswordTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginTextBox);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserAdministrationPanel";
            this.Text = "Zarządzanie użytkownikami";
            this.Load += new System.EventHandler(this.formLoad);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usersListView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox repeatPasswordTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox roleChooser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button createNewUserButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel refreshLabel;
        private System.Windows.Forms.Button removeUserButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private BrightIdeasSoftware.ObjectListView usersListView;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvColumn5;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private BrightIdeasSoftware.OLVColumn olvColumn3;
        private BrightIdeasSoftware.OLVColumn olvColumn4;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}