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
            this.usersListView = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.login = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.role = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.refreshLabel = new System.Windows.Forms.LinkLabel();
            this.removeUserButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(123, 12);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(240, 20);
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
            this.passwordTextBox.Location = new System.Drawing.Point(123, 38);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(240, 20);
            this.passwordTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hasło";
            // 
            // repeatPasswordTextBox
            // 
            this.repeatPasswordTextBox.Location = new System.Drawing.Point(123, 64);
            this.repeatPasswordTextBox.Name = "repeatPasswordTextBox";
            this.repeatPasswordTextBox.Size = new System.Drawing.Size(240, 20);
            this.repeatPasswordTextBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Potwierdź hasło";
            // 
            // roleChooser
            // 
            this.roleChooser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roleChooser.FormattingEnabled = true;
            this.roleChooser.Location = new System.Drawing.Point(123, 90);
            this.roleChooser.Name = "roleChooser";
            this.roleChooser.Size = new System.Drawing.Size(240, 21);
            this.roleChooser.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Grupa";
            // 
            // createNewUserButton
            // 
            this.createNewUserButton.Location = new System.Drawing.Point(12, 117);
            this.createNewUserButton.Name = "createNewUserButton";
            this.createNewUserButton.Size = new System.Drawing.Size(351, 23);
            this.createNewUserButton.TabIndex = 14;
            this.createNewUserButton.Text = "Potwierdź i utwórz użytkownika";
            this.createNewUserButton.UseVisualStyleBackColor = true;
            this.createNewUserButton.Click += new System.EventHandler(this.createNewUserButtonClick);
            // 
            // usersListView
            // 
            this.usersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.login,
            this.role});
            this.usersListView.FullRowSelect = true;
            this.usersListView.Location = new System.Drawing.Point(12, 183);
            this.usersListView.Name = "usersListView";
            this.usersListView.Size = new System.Drawing.Size(351, 175);
            this.usersListView.TabIndex = 15;
            this.usersListView.UseCompatibleStateImageBehavior = false;
            this.usersListView.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "Nr";
            this.id.Width = 50;
            // 
            // login
            // 
            this.login.Text = "Login";
            this.login.Width = 200;
            // 
            // role
            // 
            this.role.Text = "Rola";
            this.role.Width = 90;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Lista użytkowników w bazie";
            // 
            // refreshLabel
            // 
            this.refreshLabel.AutoSize = true;
            this.refreshLabel.Location = new System.Drawing.Point(225, 167);
            this.refreshLabel.Name = "refreshLabel";
            this.refreshLabel.Size = new System.Drawing.Size(138, 13);
            this.refreshLabel.TabIndex = 17;
            this.refreshLabel.TabStop = true;
            this.refreshLabel.Text = "Odśwież listę użytkowników";
            this.refreshLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.refreshLabelClick);
            // 
            // removeUserButton
            // 
            this.removeUserButton.Location = new System.Drawing.Point(12, 364);
            this.removeUserButton.Name = "removeUserButton";
            this.removeUserButton.Size = new System.Drawing.Size(172, 23);
            this.removeUserButton.TabIndex = 18;
            this.removeUserButton.Text = "Usuń użytkownika";
            this.removeUserButton.UseVisualStyleBackColor = true;
            this.removeUserButton.Click += new System.EventHandler(this.removeUserButtonClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(190, 364);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Zamknij okno ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.closeButtonClick);
            // 
            // UserAdministrationPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 399);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.removeUserButton);
            this.Controls.Add(this.refreshLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.usersListView);
            this.Controls.Add(this.createNewUserButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.roleChooser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.repeatPasswordTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginTextBox);
            this.Name = "UserAdministrationPanel";
            this.Text = "Zarządzanie użytkownikami";
            this.Load += new System.EventHandler(this.formLoad);
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
        private System.Windows.Forms.ListView usersListView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel refreshLabel;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader login;
        private System.Windows.Forms.ColumnHeader role;
        private System.Windows.Forms.Button removeUserButton;
        private System.Windows.Forms.Button button2;
    }
}