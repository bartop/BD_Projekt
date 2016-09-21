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
    public partial class StageGradePanel : Form
    {
        private Recruited recruited;
        private Job job;

        public StageGradePanel(Recruited recruitedArg, Job jobArg)
        {
            InitializeComponent();
            recruited = recruitedArg;
            job = jobArg;
            refreshStagesBox();
            refreshStageGradesList();
            for(int i = 0; i < 10; ++i)
            {
                gradeComboBox.Items.Add(i);
            }
            recruitedTextBox.Text = recruited.Name + " " + recruited.Surname;
            jobTextBox.Text = job.Name;
        }

        private void refreshStagesBox()
        {
            List<Stage> stages;
            using (var db = new DataModelContainer())
            {
                var jo = db.JobSet.Where(j => j.Id == job.Id).Single();
                stages = jo.Stage.ToList();
                var gradedStages = db.ApplicationSet
                    .Where(a => a.Recruited.Id == recruited.Id
                    && a.Job.Id == job.Id)
                    .Single()
                    .StageGrade
                    .Select(sg => sg.Stage);
                stages = new List<Stage>(stages.Except(gradedStages));
            }
            stageComboBox.Items.Clear();
            foreach(var stage in stages)
            {
                stageComboBox.Items.Add(stage.Name);
            }
        }

        private void refreshStageGradesList()
        {
            using (var db = new DataModelContainer())
            {
                var stageGrades = db.StageGradeSet
                    .Where(sg => sg.Application.Job.Id == job.Id 
                    && sg.Application.Recruited.Id == recruited.Id).ToList();

                stageGradesListView.Items.Clear();
                foreach(var stageGrade in stageGrades)
                {
                    stageGradesListView.Items.Add(new ListViewItem(new string[]{
                        stageGrade.Stage.Name,
                        stageGrade.Grade.ToString()
                    }));
                }
            }
        }

        private void refreshStagesLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            refreshStagesBox();
        }

        private void refreshStageGradesLinkClicked(object sender, EventArgs e)
        {
            refreshStageGradesList();
        }

        private void addStageGradeButtonClicked(object sender, EventArgs e)
        {
            if (!validateFormFields())
            {
                return;
            }

            try
            {
                var stageGrade = new StageGrade();
                stageGrade.Grade = byte.Parse(gradeComboBox.Text);
                using (var db = new DataModelContainer())
                {
                    Stage stage = db.StageSet.Where(s => s.Name == stageComboBox.Text).Single();
                    Application app = db.ApplicationSet
                        .Where(a => a.Recruited.Id == recruited.Id &&
                        a.Job.Id == job.Id).Single();
                    stageGrade.Stage = stage;
                    stageGrade.Application = app;
                    db.StageGradeSet.Add(stageGrade);
                    db.SaveChanges();
                }
                refreshStageGradesList();
                refreshStagesBox();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd");
            }
        }

        private void removeStageGradeButtonClicked(object sender, EventArgs e)
        {
            foreach (ListViewItem item in stageGradesListView.SelectedItems)
            {
                using (var db = new DataModelContainer())
                {
                    var stageName = item.SubItems[0].Text;
                    int recruitedId = recruited.Id;
                    db.StageGradeSet.Remove(
                        db.StageSet
                        .Where(s => s.Name == stageName)
                        .Single()
                        .StageGrades
                        .Where(sg => sg.Application.Recruited.Id ==recruitedId)
                        .Single()
                        );
                    db.SaveChanges();
                }
            }
            refreshStageGradesList();
            refreshStagesBox();
        }

        private bool validateFormFields()
        {
            if (gradeComboBox.SelectedIndex < 0 || stageComboBox.SelectedIndex < 0)
            {
                MessageBox.Show("Wypełnij wszystkie pola!", "Błąd");
                return false;
            }

            return true;
        }
    }
}
