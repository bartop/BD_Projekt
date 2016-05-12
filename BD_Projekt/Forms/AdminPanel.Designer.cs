namespace BD_Projekt
{
    partial class AdminPanel
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
            this.createNewUserButton = new System.Windows.Forms.Button();
            this.createNewJobButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createNewUserButton
            // 
            this.createNewUserButton.Location = new System.Drawing.Point(12, 13);
            this.createNewUserButton.Name = "createNewUserButton";
            this.createNewUserButton.Size = new System.Drawing.Size(285, 23);
            this.createNewUserButton.TabIndex = 0;
            this.createNewUserButton.Text = "Utwórz nowe konto użytkownika";
            this.createNewUserButton.UseVisualStyleBackColor = true;
            this.createNewUserButton.Click += new System.EventHandler(this.createNewUserButtonClick);
            // 
            // createNewJobButton
            // 
            this.createNewJobButton.Location = new System.Drawing.Point(12, 42);
            this.createNewJobButton.Name = "createNewJobButton";
            this.createNewJobButton.Size = new System.Drawing.Size(285, 23);
            this.createNewJobButton.TabIndex = 1;
            this.createNewJobButton.Text = "Utwórz nowe stanowisko";
            this.createNewJobButton.UseVisualStyleBackColor = true;
            this.createNewJobButton.Click += new System.EventHandler(this.createNewJobButtonClick);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 73);
            this.Controls.Add(this.createNewJobButton);
            this.Controls.Add(this.createNewUserButton);
            this.Name = "AdminPanel";
            this.Text = "Panel administratora - zarządzanie";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createNewUserButton;
        private System.Windows.Forms.Button createNewJobButton;
    }
}