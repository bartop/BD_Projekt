﻿using System;
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
        private Recruited recruited;
        private Worker recruiter;
        private Application application;

        public DecisionPanel(Recruited recruitedArg,
            Worker recruiterArg,
            Application applicationArg, bool readOnly = false)
        {
            InitializeComponent();

            recruited = recruitedArg;
            recruiter = recruiterArg;
            application = applicationArg;

            try {

                refreshEducationListView();
                refreshExpirienceListView();
                refreshStageGradesList();
                refreshSkillLevelsList();


                using (var db = new DataModelContainer())
                {
                    var job = db.ApplicationSet
                        .Where(a => a.Id == application.Id)
                        .Single().Job;

                    recruitedTextBox.Text = recruited.Name + " " + recruited.Surname;
                    positionTextBox.Text = job.Name;


                    var decision = db.ApplicationSet
                        .Where(a => a.Id == application.Id)
                        .Single()
                        .Decision;

                    if (decision != null)
                    {
                        overwriteWarningLabel.Visible = true;

                        explanationTextBox.Text = decision.Explanation;
                        if (decision.Accepted)
                        {
                            positiveRadioButton.Select();
                        }
                        else
                        {
                            negativeRadioButton.Select();
                        }

                        workerLabel.Text = decision.Worker.Name + " " + decision.Worker.Surname;
                        gradeGivenLabel.Visible = true;
                    }

                    if (readOnly)
                    {
                        overwriteWarningLabel.Visible = false;
                        skillsWarning.Visible = false;
                        stagesWarning.Visible = false;
                        positiveRadioButton.Enabled = false;
                        negativeRadioButton.Enabled = false;
                        addDecisionButton.Visible = false;
                        explanationTextBox.ReadOnly = true;
                        explanationTextBox.BackColor = System.Drawing.SystemColors.Window;
                    }

                    var possesedSkills = db.PosessesSet
                        .Where(p => p.Recruited.Id == recruited.Id)
                        .Select(p => p.Skills);
                    var requiredSkills = db.RequiresSet
                        .Where(r => r.Jobs.Id == job.Id)
                        .Select(r => r.Skills);
                    bool isSubset = !requiredSkills.Except(possesedSkills).Any();
                    if (!isSubset) skillsWarning.Visible = true;

                    var gradedStages = db.StageGradeSet
                        .Where(sg => sg.Application.Id == application.Id)
                        .Select(sg => sg.Stage);
                    var requiredStages = db.ApplicationSet
                        .Where(a => a.Id == application.Id)
                        .Single()
                        .Job
                        .Stage;
                    isSubset = !requiredStages.Except(gradedStages).Any();
                    if (!isSubset) stagesWarning.Visible = true;
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd");
            }
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
                double average = 0;
                double divider = 0;
                var skillLevels = db.PosessesSet.
                    Where(p => p.Recruited.Id == recruited.Id);

                application = db.ApplicationSet.Find(application.Id);
                var skillWeights = application.Job.Requires;

                foreach (var skillLevel in skillLevels)
                {
                    var weight = skillWeights.Where(r => r.Skills.Id == skillLevel.Skills.Id).FirstOrDefault().Weight;
                    average += skillLevel.Level * weight;
                    divider += weight;

                        skillLevelListView.Items.Add(
                            new ListViewItem(
                                new string[] { skillLevel.Skills.Name,
                                skillLevel.Level.ToString(), weight.ToString() }));
                }
                average /= divider;
                skillAverageLabel.Text = average.ToString();
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
                var app = db.ApplicationSet
                    .Where(a => a.Id == application.Id)
                    .Single();
                var rec = db.WorkerSet
                    .Where(r => r.Id == recruiter.Id)
                    .Single();

                Decision dec = new Decision();

                if (app.Decision != null) { 
                    dec = app.Decision;
                }

                dec.Accepted = positiveRadioButton.Checked;
                dec.Application = app;
                dec.Explanation = explanationTextBox.Text;
                dec.Worker = rec;

                if (app.Decision == null)
                {
                    app.Decision = dec;
                    db.DecisionSet.Add(dec);
                }

                db.SaveChanges();
            }
            Close();
        }

        private void DecisionPanel_Load(object sender, EventArgs e)
        {
            int h = Screen.PrimaryScreen.WorkingArea.Height;
            this.Height = h;
        }

        private void showDataButton_Click(object sender, EventArgs e)
        {
            using (var form = new RecruitedPreviewForm(recruited.Id))
            {
                form.ShowDialog();
            }
        }
    }
}
