using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD_Projekt.Forms
{
    public partial class ApplicationPreviewForm : RefreshableForm
    {
        int applicationId;
        public ApplicationPreviewForm(int applicationId)
        {
            this.applicationId = applicationId;
            InitializeComponent();
            LoadData();

        }

        private void ApplicationPreviewForm_Load(object sender, EventArgs e)
        {

        }

        override public void LoadData()
        {
            using (var db = new ModelContainer())
            {
                var application = db.ApplicationSet.Find(applicationId);
                nameLabel.Text = application.Recruited.Name;
                surnameLabel.Text = application.Recruited.Surname;
                dateOfBirthLabel.Text = application.Recruited.DateOfBirth.ToString();
                phoneLabel.Text = application.Recruited.PhoneNumber;
                emailLabel.Text = application.Recruited.Email;
                educationLabel.Text = application.Recruited.Education;

                jobLabel.Text = application.Job.Name;

                /*foreach (var stageGrade in application.StageGrades)
                {
                    gradesList.Items.Add(stageGrade.Stage.Name + ": " + stageGrade.Grade);
                }*/
                skillsList.Items.Clear();
                foreach (var skill in application.Recruited.Posesses)
                {
                    skillsList.Items.Add(new ListViewItem(new string[] { skill.Skills.Name, skill.Level.ToString() }));
                }

                decisionPreview.Enabled = (application.Decision != null);
                gradesPreviewButton.Enabled = (application.StageGrades != null && application.StageGrades.Count != 0);
            }
        }

        private void decisionPreview_Click(object sender, EventArgs e)
        {
            using (var db = new ModelContainer())
            {
                var application = db.ApplicationSet.Find(applicationId);
                new DecisionPreviewForm(application.Decision.Id).Show();
            }
        }

        private void gradesPreviewButton_Click(object sender, EventArgs e)
        {
            new GradesPreviewForm(applicationId).Show();
        }
    }
}
