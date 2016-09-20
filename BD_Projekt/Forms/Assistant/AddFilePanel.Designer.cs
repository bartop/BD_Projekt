namespace BD_Projekt.Forms
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
            this.removeFileButton = new System.Windows.Forms.Button();
            this.recuitedTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.documentsListView = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.originalName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addFileButton
            // 
            this.addFileButton.Location = new System.Drawing.Point(12, 253);
            this.addFileButton.Name = "addFileButton";
            this.addFileButton.Size = new System.Drawing.Size(541, 23);
            this.addFileButton.TabIndex = 0;
            this.addFileButton.Text = "Dodaj nowy załącznik";
            this.addFileButton.UseVisualStyleBackColor = true;
            this.addFileButton.Click += new System.EventHandler(this.AddFileButtonClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // removeFileButton
            // 
            this.removeFileButton.Location = new System.Drawing.Point(12, 282);
            this.removeFileButton.Name = "removeFileButton";
            this.removeFileButton.Size = new System.Drawing.Size(541, 23);
            this.removeFileButton.TabIndex = 2;
            this.removeFileButton.Text = "Usuń plik";
            this.removeFileButton.UseVisualStyleBackColor = true;
            this.removeFileButton.Click += new System.EventHandler(this.removeFileButtonClicked);
            // 
            // recuitedTextBox
            // 
            this.recuitedTextBox.Enabled = false;
            this.recuitedTextBox.Location = new System.Drawing.Point(88, 12);
            this.recuitedTextBox.Name = "recuitedTextBox";
            this.recuitedTextBox.Size = new System.Drawing.Size(465, 20);
            this.recuitedTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lista plików";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Rekrutowany";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(452, 50);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(101, 13);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Odśwież listę plików";
            this.linkLabel1.Click += new System.EventHandler(this.refreshLabelCliked);
            // 
            // documentsListView
            // 
            this.documentsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.originalName});
            this.documentsListView.FullRowSelect = true;
            this.documentsListView.GridLines = true;
            this.documentsListView.Location = new System.Drawing.Point(12, 66);
            this.documentsListView.Name = "documentsListView";
            this.documentsListView.Size = new System.Drawing.Size(541, 147);
            this.documentsListView.TabIndex = 7;
            this.documentsListView.UseCompatibleStateImageBehavior = false;
            this.documentsListView.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "Numer";
            // 
            // originalName
            // 
            this.originalName.Text = "Nazwa";
            this.originalName.Width = 463;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(541, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Otwórz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.openFileButtonClicked);
            // 
            // AddFilePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 312);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.documentsListView);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.recuitedTextBox);
            this.Controls.Add(this.removeFileButton);
            this.Controls.Add(this.addFileButton);
            this.Name = "AddFilePanel";
            this.Text = "Załączanie dokumentów";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addFileButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button removeFileButton;
        private System.Windows.Forms.TextBox recuitedTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ListView documentsListView;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader originalName;
        private System.Windows.Forms.Button button1;
    }
}