namespace BD_Projekt.Forms
{
    partial class SupervisorPanel
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
            this.applicationPreview = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.disapproveButton = new System.Windows.Forms.Button();
            this.approveButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.applicationsList = new System.Windows.Forms.ListView();
            this.idColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.jobName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.surnameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.decisionColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.acceptationColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // applicationPreview
            // 
            this.applicationPreview.Location = new System.Drawing.Point(3, 3);
            this.applicationPreview.Name = "applicationPreview";
            this.applicationPreview.Size = new System.Drawing.Size(96, 23);
            this.applicationPreview.TabIndex = 1;
            this.applicationPreview.Text = "Podgląd podania";
            this.applicationPreview.UseVisualStyleBackColor = true;
            this.applicationPreview.Click += new System.EventHandler(this.applicationPreview_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(105, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Podgląd oceny";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // disapproveButton
            // 
            this.disapproveButton.Location = new System.Drawing.Point(105, 32);
            this.disapproveButton.Name = "disapproveButton";
            this.disapproveButton.Size = new System.Drawing.Size(96, 23);
            this.disapproveButton.TabIndex = 3;
            this.disapproveButton.Text = "Odrzuć ocenę";
            this.disapproveButton.UseVisualStyleBackColor = true;
            this.disapproveButton.Click += new System.EventHandler(this.disapproveButton_Click);
            // 
            // approveButton
            // 
            this.approveButton.Location = new System.Drawing.Point(3, 32);
            this.approveButton.Name = "approveButton";
            this.approveButton.Size = new System.Drawing.Size(96, 23);
            this.approveButton.TabIndex = 4;
            this.approveButton.Text = "Potwierdź ocenę";
            this.approveButton.UseVisualStyleBackColor = true;
            this.approveButton.Click += new System.EventHandler(this.approveButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.applicationPreview, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.disapproveButton, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.approveButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(102, 213);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(204, 59);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // applicationsList
            // 
            this.applicationsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.applicationsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idColumn,
            this.jobName,
            this.nameColumn,
            this.surnameColumn,
            this.decisionColumn,
            this.acceptationColumn});
            this.applicationsList.FullRowSelect = true;
            this.applicationsList.Location = new System.Drawing.Point(13, 13);
            this.applicationsList.Name = "applicationsList";
            this.applicationsList.Size = new System.Drawing.Size(378, 194);
            this.applicationsList.TabIndex = 6;
            this.applicationsList.UseCompatibleStateImageBehavior = false;
            this.applicationsList.View = System.Windows.Forms.View.Details;
            // 
            // idColumn
            // 
            this.idColumn.Text = "ID";
            this.idColumn.Width = 32;
            // 
            // jobName
            // 
            this.jobName.Text = "Stanowisko";
            this.jobName.Width = 69;
            // 
            // nameColumn
            // 
            this.nameColumn.Text = "Imię";
            this.nameColumn.Width = 36;
            // 
            // surnameColumn
            // 
            this.surnameColumn.Text = "Nazwisko";
            // 
            // decisionColumn
            // 
            this.decisionColumn.Text = "Decyzja";
            this.decisionColumn.Width = 69;
            // 
            // acceptationColumn
            // 
            this.acceptationColumn.Text = "Akceptacja decyzji";
            this.acceptationColumn.Width = 107;
            // 
            // SupervisorPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 279);
            this.Controls.Add(this.applicationsList);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SupervisorPanel";
            this.Text = "Panel kierownika - weryfikacja";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button applicationPreview;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button disapproveButton;
        private System.Windows.Forms.Button approveButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListView applicationsList;
        private System.Windows.Forms.ColumnHeader idColumn;
        private System.Windows.Forms.ColumnHeader jobName;
        private System.Windows.Forms.ColumnHeader nameColumn;
        private System.Windows.Forms.ColumnHeader surnameColumn;
        private System.Windows.Forms.ColumnHeader decisionColumn;
        private System.Windows.Forms.ColumnHeader acceptationColumn;
    }
}