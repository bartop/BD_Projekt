namespace BD_Projekt
{
    partial class AsistantPanel
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxPosition = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxNationality = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxExp = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonInclude = new System.Windows.Forms.Button();
            this.buttonAddExp = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxEducation = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxSkills = new System.Windows.Forms.ComboBox();
            this.comboBoxLavel = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonAddPerson = new System.Windows.Forms.Button();
            this.buttonFindPerson = new System.Windows.Forms.Button();
            this.textBoxStoryState = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxStoryCompany = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateStartJob = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dateEndJob = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonAddStory = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stanowisko";
            // 
            // comboBoxPosition
            // 
            this.comboBoxPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPosition.Enabled = false;
            this.comboBoxPosition.FormattingEnabled = true;
            this.comboBoxPosition.Location = new System.Drawing.Point(77, 230);
            this.comboBoxPosition.Name = "comboBoxPosition";
            this.comboBoxPosition.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPosition.TabIndex = 1;
            this.comboBoxPosition.SelectedIndexChanged += new System.EventHandler(this.positionChoose);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Imię";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(117, 6);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(121, 20);
            this.textBoxName.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nazwisko";
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(117, 32);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(121, 20);
            this.textBoxSurname.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Obywatelstwo";
            // 
            // comboBoxNationality
            // 
            this.comboBoxNationality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNationality.FormattingEnabled = true;
            this.comboBoxNationality.Location = new System.Drawing.Point(118, 84);
            this.comboBoxNationality.Name = "comboBoxNationality";
            this.comboBoxNationality.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNationality.TabIndex = 19;
            this.comboBoxNationality.SelectedIndexChanged += new System.EventHandler(this.nationalityChoose);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(204, 233);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Doświadczenie (lata)";
            // 
            // textBoxExp
            // 
            this.textBoxExp.Enabled = false;
            this.textBoxExp.Location = new System.Drawing.Point(315, 230);
            this.textBoxExp.Name = "textBoxExp";
            this.textBoxExp.Size = new System.Drawing.Size(121, 20);
            this.textBoxExp.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 115);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "Data urodzenia";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 141);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 13);
            this.label15.TabIndex = 28;
            this.label15.Text = "Adres e-mail";
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(118, 138);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(121, 20);
            this.textBoxMail.TabIndex = 29;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 61);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(43, 13);
            this.label16.TabIndex = 30;
            this.label16.Text = "Telefon";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(117, 58);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(121, 20);
            this.textBoxPhone.TabIndex = 31;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(20, 412);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(421, 23);
            this.buttonAdd.TabIndex = 34;
            this.buttonAdd.Text = "Dodaj umiejętność";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.skillsFormClick);
            // 
            // buttonInclude
            // 
            this.buttonInclude.Location = new System.Drawing.Point(20, 441);
            this.buttonInclude.Name = "buttonInclude";
            this.buttonInclude.Size = new System.Drawing.Size(421, 23);
            this.buttonInclude.TabIndex = 35;
            this.buttonInclude.Text = "Załączanie dokumentów";
            this.buttonInclude.UseVisualStyleBackColor = true;
            this.buttonInclude.Click += new System.EventHandler(this.documentsAddClick);
            // 
            // buttonAddExp
            // 
            this.buttonAddExp.Location = new System.Drawing.Point(15, 257);
            this.buttonAddExp.Name = "buttonAddExp";
            this.buttonAddExp.Size = new System.Drawing.Size(421, 23);
            this.buttonAddExp.TabIndex = 36;
            this.buttonAddExp.Text = "Dodaj aplikację";
            this.buttonAddExp.UseVisualStyleBackColor = true;
            this.buttonAddExp.Click += new System.EventHandler(this.addExpClick);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(20, 470);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(421, 23);
            this.buttonClear.TabIndex = 37;
            this.buttonClear.Text = "Wyczyść informacje";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.clearClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Wykształcenie\r\n";
            // 
            // comboBoxEducation
            // 
            this.comboBoxEducation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEducation.FormattingEnabled = true;
            this.comboBoxEducation.Location = new System.Drawing.Point(118, 164);
            this.comboBoxEducation.Name = "comboBoxEducation";
            this.comboBoxEducation.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEducation.TabIndex = 39;
            this.comboBoxEducation.SelectedIndexChanged += new System.EventHandler(this.educationChoose);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(118, 112);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(120, 20);
            this.dateTimePicker1.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 386);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Umiejetności";
            // 
            // comboBoxSkills
            // 
            this.comboBoxSkills.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSkills.FormattingEnabled = true;
            this.comboBoxSkills.Location = new System.Drawing.Point(94, 383);
            this.comboBoxSkills.Name = "comboBoxSkills";
            this.comboBoxSkills.Size = new System.Drawing.Size(227, 21);
            this.comboBoxSkills.TabIndex = 42;
            // 
            // comboBoxLavel
            // 
            this.comboBoxLavel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLavel.FormattingEnabled = true;
            this.comboBoxLavel.Location = new System.Drawing.Point(389, 383);
            this.comboBoxLavel.Name = "comboBoxLavel";
            this.comboBoxLavel.Size = new System.Drawing.Size(52, 21);
            this.comboBoxLavel.TabIndex = 43;
            this.comboBoxLavel.SelectedIndexChanged += new System.EventHandler(this.levelChoose);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(327, 386);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Poziom";
            // 
            // buttonAddPerson
            // 
            this.buttonAddPerson.Location = new System.Drawing.Point(15, 191);
            this.buttonAddPerson.Name = "buttonAddPerson";
            this.buttonAddPerson.Size = new System.Drawing.Size(224, 23);
            this.buttonAddPerson.TabIndex = 45;
            this.buttonAddPerson.Text = "Dodaj nową osobę";
            this.buttonAddPerson.UseVisualStyleBackColor = true;
            this.buttonAddPerson.Click += new System.EventHandler(this.addPersonClick);
            // 
            // buttonFindPerson
            // 
            this.buttonFindPerson.Location = new System.Drawing.Point(260, 191);
            this.buttonFindPerson.Name = "buttonFindPerson";
            this.buttonFindPerson.Size = new System.Drawing.Size(176, 23);
            this.buttonFindPerson.TabIndex = 46;
            this.buttonFindPerson.Text = "Znajdź osobę";
            this.buttonFindPerson.UseVisualStyleBackColor = true;
            this.buttonFindPerson.Click += new System.EventHandler(this.findClick);
            // 
            // textBoxStoryState
            // 
            this.textBoxStoryState.Enabled = false;
            this.textBoxStoryState.Location = new System.Drawing.Point(85, 325);
            this.textBoxStoryState.Name = "textBoxStoryState";
            this.textBoxStoryState.Size = new System.Drawing.Size(121, 20);
            this.textBoxStoryState.TabIndex = 50;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 328);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 49;
            this.label7.Text = "Firma";
            // 
            // textBoxStoryCompany
            // 
            this.textBoxStoryCompany.Enabled = false;
            this.textBoxStoryCompany.Location = new System.Drawing.Point(85, 299);
            this.textBoxStoryCompany.Name = "textBoxStoryCompany";
            this.textBoxStoryCompany.Size = new System.Drawing.Size(121, 20);
            this.textBoxStoryCompany.TabIndex = 48;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 302);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 47;
            this.label8.Text = "Stanowisko";
            // 
            // dateStartJob
            // 
            this.dateStartJob.Enabled = false;
            this.dateStartJob.Location = new System.Drawing.Point(321, 302);
            this.dateStartJob.Name = "dateStartJob";
            this.dateStartJob.Size = new System.Drawing.Size(120, 20);
            this.dateStartJob.TabIndex = 52;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(216, 302);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 51;
            this.label9.Text = "Początek pracy";
            // 
            // dateEndJob
            // 
            this.dateEndJob.Enabled = false;
            this.dateEndJob.Location = new System.Drawing.Point(321, 328);
            this.dateEndJob.Name = "dateEndJob";
            this.dateEndJob.Size = new System.Drawing.Size(120, 20);
            this.dateEndJob.TabIndex = 54;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(216, 331);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 13);
            this.label12.TabIndex = 53;
            this.label12.Text = "Koniec pracy";
            // 
            // buttonAddStory
            // 
            this.buttonAddStory.Enabled = false;
            this.buttonAddStory.Location = new System.Drawing.Point(20, 354);
            this.buttonAddStory.Name = "buttonAddStory";
            this.buttonAddStory.Size = new System.Drawing.Size(421, 23);
            this.buttonAddStory.TabIndex = 55;
            this.buttonAddStory.Text = "Dodaj  hisotrię pracy";
            this.buttonAddStory.UseVisualStyleBackColor = true;
            this.buttonAddStory.Click += new System.EventHandler(this.addStoryClick);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(260, 6);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(176, 173);
            this.listBox.TabIndex = 56;
            this.listBox.Click += new System.EventHandler(this.selectPerson);
            // 
            // AsistantPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(454, 502);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.buttonAddStory);
            this.Controls.Add(this.dateEndJob);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dateStartJob);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxStoryState);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxStoryCompany);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonFindPerson);
            this.Controls.Add(this.buttonAddPerson);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxLavel);
            this.Controls.Add(this.comboBoxSkills);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBoxEducation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonAddExp);
            this.Controls.Add(this.buttonInclude);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBoxExp);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comboBoxNationality);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxPosition);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "AsistantPanel";
            this.ShowIcon = false;
            this.Text = "Panel asystentki - rejestracja";
            this.Load += new System.EventHandler(this.educationChoose);
            this.Load += new System.EventHandler(this.nationalityChoose);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxPosition;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxNationality;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxExp;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonInclude;
        private System.Windows.Forms.Button buttonAddExp;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxEducation;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxSkills;
        private System.Windows.Forms.ComboBox comboBoxLavel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonAddPerson;
        private System.Windows.Forms.Button buttonFindPerson;
        private System.Windows.Forms.TextBox textBoxStoryState;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxStoryCompany;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateStartJob;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateEndJob;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button buttonAddStory;
        private System.Windows.Forms.ListBox listBox;
    }
}