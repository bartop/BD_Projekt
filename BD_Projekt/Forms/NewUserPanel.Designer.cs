namespace BD_Projekt
{
    partial class NewUserPanel
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
            this.SuspendLayout();
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(123, 12);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(168, 20);
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
            this.passwordTextBox.Size = new System.Drawing.Size(168, 20);
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
            this.repeatPasswordTextBox.Size = new System.Drawing.Size(168, 20);
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
            this.roleChooser.FormattingEnabled = true;
            this.roleChooser.Location = new System.Drawing.Point(123, 90);
            this.roleChooser.Name = "roleChooser";
            this.roleChooser.Size = new System.Drawing.Size(168, 21);
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
            this.createNewUserButton.Location = new System.Drawing.Point(15, 117);
            this.createNewUserButton.Name = "createNewUserButton";
            this.createNewUserButton.Size = new System.Drawing.Size(279, 23);
            this.createNewUserButton.TabIndex = 14;
            this.createNewUserButton.Text = "Potwierdź i utwórz użytkownika";
            this.createNewUserButton.UseVisualStyleBackColor = true;
            this.createNewUserButton.Click += new System.EventHandler(this.CreateNewUserClick);
            // 
            // NewUserPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 156);
            this.Controls.Add(this.createNewUserButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.roleChooser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.repeatPasswordTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginTextBox);
            this.Name = "NewUserPanel";
            this.Text = "Tworzenie nowego użytkownika";
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
    }
}