namespace BD_Projekt.Forms
{
    partial class JobStagesAdministration
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.stageAdministrationButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.refreshStagesBoxLinkLabel = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.refreshStagesLinkLabel = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.stage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stagesListView = new System.Windows.Forms.ListView();
            this.stagesComboBox = new System.Windows.Forms.ComboBox();
            this.addNewStageButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.jobNameTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.40807F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.40807F));
            this.tableLayoutPanel1.Controls.Add(this.stageAdministrationButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.removeButton, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(16, 295);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(455, 33);
            this.tableLayoutPanel1.TabIndex = 29;
            // 
            // stageAdministrationButton
            // 
            this.stageAdministrationButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stageAdministrationButton.Location = new System.Drawing.Point(230, 3);
            this.stageAdministrationButton.Name = "stageAdministrationButton";
            this.stageAdministrationButton.Size = new System.Drawing.Size(222, 27);
            this.stageAdministrationButton.TabIndex = 10;
            this.stageAdministrationButton.Text = "Zarządzaj etapami";
            this.stageAdministrationButton.UseVisualStyleBackColor = true;
            this.stageAdministrationButton.Click += new System.EventHandler(this.stageAdministrationButtonClicked);
            // 
            // removeButton
            // 
            this.removeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.removeButton.Location = new System.Drawing.Point(3, 3);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(221, 27);
            this.removeButton.TabIndex = 11;
            this.removeButton.Text = "Usuń etap rekrutacji";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButtonClick);
            // 
            // refreshStagesBoxLinkLabel
            // 
            this.refreshStagesBoxLinkLabel.AutoSize = true;
            this.refreshStagesBoxLinkLabel.Location = new System.Drawing.Point(365, 45);
            this.refreshStagesBoxLinkLabel.Name = "refreshStagesBoxLinkLabel";
            this.refreshStagesBoxLinkLabel.Size = new System.Drawing.Size(106, 13);
            this.refreshStagesBoxLinkLabel.TabIndex = 28;
            this.refreshStagesBoxLinkLabel.TabStop = true;
            this.refreshStagesBoxLinkLabel.Text = "Odśwież listę etapów";
            this.refreshStagesBoxLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.refreshStagesBoxCliked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Nazwa stanowiska";
            // 
            // refreshStagesLinkLabel
            // 
            this.refreshStagesLinkLabel.AutoSize = true;
            this.refreshStagesLinkLabel.Location = new System.Drawing.Point(201, 101);
            this.refreshStagesLinkLabel.Name = "refreshStagesLinkLabel";
            this.refreshStagesLinkLabel.Size = new System.Drawing.Size(270, 13);
            this.refreshStagesLinkLabel.TabIndex = 26;
            this.refreshStagesLinkLabel.TabStop = true;
            this.refreshStagesLinkLabel.Text = "Kliknij by odświeżyć listę etapów wybranego stanowiska";
            this.refreshStagesLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.refreshStagesListClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Lista etapów dotyczących stanowiska";
            // 
            // stage
            // 
            this.stage.Tag = "";
            this.stage.Text = "Etap";
            this.stage.Width = 376;
            // 
            // id
            // 
            this.id.Text = "Nr";
            this.id.Width = 70;
            // 
            // stagesListView
            // 
            this.stagesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.stage});
            this.stagesListView.FullRowSelect = true;
            this.stagesListView.Location = new System.Drawing.Point(16, 117);
            this.stagesListView.Name = "stagesListView";
            this.stagesListView.Size = new System.Drawing.Size(455, 172);
            this.stagesListView.TabIndex = 24;
            this.stagesListView.UseCompatibleStateImageBehavior = false;
            this.stagesListView.View = System.Windows.Forms.View.Details;
            // 
            // stagesComboBox
            // 
            this.stagesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stagesComboBox.Location = new System.Drawing.Point(117, 42);
            this.stagesComboBox.Name = "stagesComboBox";
            this.stagesComboBox.Size = new System.Drawing.Size(242, 21);
            this.stagesComboBox.TabIndex = 23;
            // 
            // addNewStageButton
            // 
            this.addNewStageButton.Location = new System.Drawing.Point(16, 69);
            this.addNewStageButton.Name = "addNewStageButton";
            this.addNewStageButton.Size = new System.Drawing.Size(455, 24);
            this.addNewStageButton.TabIndex = 20;
            this.addNewStageButton.Text = "Dodaj etap rekrutacji";
            this.addNewStageButton.UseVisualStyleBackColor = true;
            this.addNewStageButton.Click += new System.EventHandler(this.addStageButtonClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nazwa etapu";
            // 
            // jobNameTextBox
            // 
            this.jobNameTextBox.Location = new System.Drawing.Point(117, 12);
            this.jobNameTextBox.Name = "jobNameTextBox";
            this.jobNameTextBox.ReadOnly = true;
            this.jobNameTextBox.Size = new System.Drawing.Size(242, 20);
            this.jobNameTextBox.TabIndex = 18;
            this.jobNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // JobStagesAdministration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 340);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.refreshStagesBoxLinkLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.refreshStagesLinkLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stagesListView);
            this.Controls.Add(this.stagesComboBox);
            this.Controls.Add(this.addNewStageButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.jobNameTextBox);
            this.Name = "JobStagesAdministration";
            this.Text = "JobStagesAdministration";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button stageAdministrationButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.LinkLabel refreshStagesBoxLinkLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel refreshStagesLinkLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader stage;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ListView stagesListView;
        private System.Windows.Forms.ComboBox stagesComboBox;
        private System.Windows.Forms.Button addNewStageButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox jobNameTextBox;
    }
}