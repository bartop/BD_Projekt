namespace BD_Projekt.Forms
{
    partial class SupervisorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupervisorForm));
            this.openDecidedPanelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openDecidedPanelButton
            // 
            resources.ApplyResources(this.openDecidedPanelButton, "openDecidedPanelButton");
            this.openDecidedPanelButton.Name = "openDecidedPanelButton";
            this.openDecidedPanelButton.UseVisualStyleBackColor = true;
            this.openDecidedPanelButton.Click += new System.EventHandler(this.openDecidedPanelButtonClicked);
            // 
            // SupervisorForm
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.openDecidedPanelButton);
            this.Name = "SupervisorForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openDecidedPanelButton;
    }
}
