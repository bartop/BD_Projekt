namespace BD_Projekt.Forms
{
    partial class JobRequirementsPanel
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
            this.jobNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addNewRequirementButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.skillWeightTextBox = new System.Windows.Forms.TextBox();
            this.skillAdministrationButton = new System.Windows.Forms.Button();
            this.skillsComboBox = new System.Windows.Forms.ComboBox();
            this.requirementsListView = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.skill = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.weight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.refreshRequirementsLinkLabel = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.removeButton = new System.Windows.Forms.Button();
            this.editWeightButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // jobNameTextBox
            // 
            this.jobNameTextBox.Location = new System.Drawing.Point(116, 15);
            this.jobNameTextBox.Name = "jobNameTextBox";
            this.jobNameTextBox.ReadOnly = true;
            this.jobNameTextBox.Size = new System.Drawing.Size(193, 20);
            this.jobNameTextBox.TabIndex = 1;
            this.jobNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nazwa umiejętności";
            // 
            // addNewRequirementButton
            // 
            this.addNewRequirementButton.Location = new System.Drawing.Point(315, 72);
            this.addNewRequirementButton.Name = "addNewRequirementButton";
            this.addNewRequirementButton.Size = new System.Drawing.Size(143, 24);
            this.addNewRequirementButton.TabIndex = 4;
            this.addNewRequirementButton.Text = "Dodaj wymaganie";
            this.addNewRequirementButton.UseVisualStyleBackColor = true;
            this.addNewRequirementButton.Click += new System.EventHandler(this.addNewRequirementButtonClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Waga umiejętności";
            // 
            // skillWeightTextBox
            // 
            this.skillWeightTextBox.Location = new System.Drawing.Point(116, 75);
            this.skillWeightTextBox.Name = "skillWeightTextBox";
            this.skillWeightTextBox.Size = new System.Drawing.Size(193, 20);
            this.skillWeightTextBox.TabIndex = 8;
            // 
            // skillAdministrationButton
            // 
            this.skillAdministrationButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skillAdministrationButton.Location = new System.Drawing.Point(299, 3);
            this.skillAdministrationButton.Name = "skillAdministrationButton";
            this.skillAdministrationButton.Size = new System.Drawing.Size(144, 24);
            this.skillAdministrationButton.TabIndex = 10;
            this.skillAdministrationButton.Text = "Zarządzaj umiejętnościami";
            this.skillAdministrationButton.UseVisualStyleBackColor = true;
            this.skillAdministrationButton.Click += new System.EventHandler(this.skillsAdministrationButtonClick);
            // 
            // skillsComboBox
            // 
            this.skillsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skillsComboBox.Location = new System.Drawing.Point(116, 45);
            this.skillsComboBox.Name = "skillsComboBox";
            this.skillsComboBox.Size = new System.Drawing.Size(193, 21);
            this.skillsComboBox.TabIndex = 11;
            // 
            // requirementsListView
            // 
            this.requirementsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.skill,
            this.weight});
            this.requirementsListView.FullRowSelect = true;
            this.requirementsListView.GridLines = true;
            this.requirementsListView.Location = new System.Drawing.Point(12, 123);
            this.requirementsListView.Name = "requirementsListView";
            this.requirementsListView.Size = new System.Drawing.Size(443, 172);
            this.requirementsListView.TabIndex = 12;
            this.requirementsListView.UseCompatibleStateImageBehavior = false;
            this.requirementsListView.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "Nr";
            this.id.Width = 57;
            // 
            // skill
            // 
            this.skill.Tag = "";
            this.skill.Text = "Umiejętność";
            this.skill.Width = 309;
            // 
            // weight
            // 
            this.weight.Text = "Waga";
            this.weight.Width = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Lista wymagań dotyczących stanowiska";
            // 
            // refreshRequirementsLinkLabel
            // 
            this.refreshRequirementsLinkLabel.AutoSize = true;
            this.refreshRequirementsLinkLabel.Location = new System.Drawing.Point(292, 104);
            this.refreshRequirementsLinkLabel.Name = "refreshRequirementsLinkLabel";
            this.refreshRequirementsLinkLabel.Size = new System.Drawing.Size(169, 13);
            this.refreshRequirementsLinkLabel.TabIndex = 14;
            this.refreshRequirementsLinkLabel.TabStop = true;
            this.refreshRequirementsLinkLabel.Text = "Kliknij by odświeżyć listę wymagań";
            this.refreshRequirementsLinkLabel.Click += new System.EventHandler(this.refreshRequirementsLinkClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Nazwa stanowiska";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(329, 48);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(129, 13);
            this.linkLabel1.TabIndex = 16;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Odśwież listę umiejętności";
            this.linkLabel1.Click += new System.EventHandler(this.refershSkillsLinkClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel1.Controls.Add(this.skillAdministrationButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.removeButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.editWeightButton, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 298);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(446, 30);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // removeButton
            // 
            this.removeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.removeButton.Location = new System.Drawing.Point(3, 3);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(142, 24);
            this.removeButton.TabIndex = 11;
            this.removeButton.Text = "Usuń wymóg";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeRequirementButtonClick);
            // 
            // editWeightButton
            // 
            this.editWeightButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editWeightButton.Location = new System.Drawing.Point(151, 3);
            this.editWeightButton.Name = "editWeightButton";
            this.editWeightButton.Size = new System.Drawing.Size(142, 24);
            this.editWeightButton.TabIndex = 12;
            this.editWeightButton.Text = "Zmień wagę wymagania";
            this.editWeightButton.UseVisualStyleBackColor = true;
            this.editWeightButton.Click += new System.EventHandler(this.changeWeightButtonClick);
            // 
            // JobRequirementsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 340);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.refreshRequirementsLinkLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.requirementsListView);
            this.Controls.Add(this.skillsComboBox);
            this.Controls.Add(this.skillWeightTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addNewRequirementButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.jobNameTextBox);
            this.Name = "JobRequirementsPanel";
            this.Text = "Określanie wymagań pracy";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox jobNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addNewRequirementButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox skillWeightTextBox;
        private System.Windows.Forms.Button skillAdministrationButton;
        private System.Windows.Forms.ComboBox skillsComboBox;
        private System.Windows.Forms.ListView requirementsListView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel refreshRequirementsLinkLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button editWeightButton;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader skill;
        private System.Windows.Forms.ColumnHeader weight;
    }
}