namespace BD_Projekt.Forms
{
    partial class GradesPreviewForm
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
            this.gradesList = new System.Windows.Forms.ListView();
            this.stageColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gradeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.jobLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gradesList
            // 
            this.gradesList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gradesList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.stageColumn,
            this.gradeColumn});
            this.gradesList.FullRowSelect = true;
            this.gradesList.Location = new System.Drawing.Point(12, 63);
            this.gradesList.Name = "gradesList";
            this.gradesList.Size = new System.Drawing.Size(250, 213);
            this.gradesList.TabIndex = 7;
            this.gradesList.UseCompatibleStateImageBehavior = false;
            this.gradesList.View = System.Windows.Forms.View.Details;
            // 
            // stageColumn
            // 
            this.stageColumn.Text = "Etap";
            this.stageColumn.Width = 178;
            // 
            // gradeColumn
            // 
            this.gradeColumn.Text = "Ocena";
            this.gradeColumn.Width = 69;
            // 
            // jobLabel
            // 
            this.jobLabel.AutoSize = true;
            this.jobLabel.Location = new System.Drawing.Point(12, 9);
            this.jobLabel.Name = "jobLabel";
            this.jobLabel.Size = new System.Drawing.Size(60, 13);
            this.jobLabel.TabIndex = 8;
            this.jobLabel.Text = "stanowisko";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 33);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nameLabel.Size = new System.Drawing.Size(77, 13);
            this.nameLabel.TabIndex = 9;
            this.nameLabel.Text = "imię i naziwsko";
            // 
            // GradesPreviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 288);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.jobLabel);
            this.Controls.Add(this.gradesList);
            this.Name = "GradesPreviewForm";
            this.Text = "GradesPreviewForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView gradesList;
        private System.Windows.Forms.ColumnHeader stageColumn;
        private System.Windows.Forms.ColumnHeader gradeColumn;
        private System.Windows.Forms.Label jobLabel;
        private System.Windows.Forms.Label nameLabel;
    }
}