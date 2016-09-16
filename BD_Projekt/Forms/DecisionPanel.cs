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
    public partial class DecisionPanel : Form
    {
        Recruited recruited;
        Worker recruiter;
        Application application;

        public DecisionPanel(Recruited recruitedArg,
            Worker recruiterArg,
            Application applicationArg)
        {
            InitializeComponent();

            recruited = recruitedArg;
            recruiter = recruiterArg;
            application = applicationArg;

            refreshEducationListView();
            refreshExpirienceListView();
            refreshStageGradesList();
            refreshSkillLevelsList();

        }

        private void refreshEducationListView()
        {
            using (var db = new DataModelContainer())
            {
                var educationList = db.RecruitedSet
                    .Where(r => r.Id == recruited.Id)
                    .Single().Education;
                educationListView.Items.Clear();
                foreach (var education in educationList)
                {
                    string[] item =
                    {
                        education.Id.ToString(),
                        education.SchoolName,
                        education.Name,
                        education.FromYear.Date.ToString(),
                        education.ToYear.Date.ToString()
                    };
                    educationListView.Items.Add(new ListViewItem(item));
                }
            }
        }

        private void refreshExpirienceListView()
        {
            using (var db = new DataModelContainer())
            {
                var expiriences = db.ProfessionalExperienceSet
                    .Where(e => e.Recruited.Id == recruited.Id).ToList();
                expirienceListView.Items.Clear();
                foreach (var expirience in expiriences)
                {
                    string[] item =
                    {
                        expirience.Id.ToString(),
                        expirience.Company,
                        expirience.Job,
                        expirience.From.Date.ToString(),
                        expirience.To.Date.ToString()
                    };
                    expirienceListView.Items.Add(new ListViewItem(item));
                }
            }
        }

        private void refreshStageGradesList()
        {
            double average = 0;
            using (var db = new DataModelContainer())
            {
                var stageGrades = db.StageGradeSet
                    .Where(sg => sg.Application.Id == application.Id)
                    .ToList();
                var grades = stageGrades.Select(sg => sg.Grade).ToList();
                foreach (var grade in grades)
                {
                    average +=(double) grade.Value / grades.Count;
                }

                stageGradesListView.Items.Clear();
                foreach (var stageGrade in stageGrades)
                {
                    stageGradesListView.Items.Add(new ListViewItem(new string[]{
                        stageGrade.Stage.Name,
                        stageGrade.Grade.ToString()
                    }));
                }
            }
            stageAverageLabel.Text = average.ToString();
        }

        private void refreshSkillLevelsList()
        {
            skillLevelListView.Items.Clear();
            using (var db = new DataModelContainer())
            {
                var skillLevels = db.PosessesSet.
                    Where(p => p.Recruited.Id == recruited.Id);

                foreach (var skillLevel in skillLevels)
                {
                    skillLevelListView.Items.Add(
                        new ListViewItem(
                            new string[] { skillLevel.Skills.Name,
                                skillLevel.Level.ToString() }));
                }
                //TODO: trzeba zrobić tą średnią
            }
        }


        private void refreshEducationListViewLinkClicked(object sender, EventArgs e)
        {
            refreshEducationListView();
        }

        private void refreshExpirienceLinkClicked(object sender, EventArgs e)
        {
            refreshExpirienceListView();
        }

        private void refreshStageGradesLinkClicked(object sender, EventArgs e)
        {
            refreshStageGradesList();
        }

        private void refreshSkillLevelListLinkClicked(object sender, EventArgs e)
        {
            refreshSkillLevelsList();
        }

        private void addDecisionButtonClicked(object sender, EventArgs e)
        {
            using (var db = new DataModelContainer())
            {
                var app = db.ApplicationSet.Where(a => a.Id == application.Id).Single();
                if (app.Decision != null)
                    db.DecisionSet.Remove(app.Decision);
                Decision dec = new Decision();
                dec.Accepted = positiveRadioButton.Checked;
                dec.Application = app;
                dec.Explanation = explanationTextBox.Text;
                db.DecisionSet.Add(dec);
                db.SaveChanges();
            }
        }
    }
}
