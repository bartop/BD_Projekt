namespace BD_Projekt
{
    partial class AddFilePanel
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
            this.addFileButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addFileButton
            // 
            this.addFileButton.Location = new System.Drawing.Point(12, 113);
            this.addFileButton.Name = "addFileButton";
            this.addFileButton.Size = new System.Drawing.Size(260, 23);
            this.addFileButton.TabIndex = 0;
            this.addFileButton.Text = "Dodaj nowy załącznik";
            this.addFileButton.UseVisualStyleBackColor = true;
            this.addFileButton.Click += new System.EventHandler(this.AddFileButtonClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(260, 95);
            this.listBox1.TabIndex = 1;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(12, 142);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(260, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Potwierdź i zapisz";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // AddFilePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 176);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.addFileButton);
            this.Name = "AddFilePanel";
            this.Text = "Załączanie dokumentów";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addFileButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button saveButton;

    }
}