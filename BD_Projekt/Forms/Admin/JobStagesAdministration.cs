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
    public partial class JobStagesAdministration : Form
    {
        private Job referencedJob;

        public JobStagesAdministration(Job job)
        {
            InitializeComponent();
            referencedJob = job;
            jobNameTextBox.Text = referencedJob.Name;
            refreshStagesBox();
            refreshStagesList();
        }

        private void refreshStagesBox()
        {
            List<string> stageNames;
            using (var db = new DataModelContainer())
            {
                stageNames = db.StageSet.Select(s => s.Name).ToList();
            }
            stagesComboBox.Items.Clear();
            foreach (var skillName in stageNames)
            {
                stagesComboBox.Items.Add(skillName);
            }
        }

        private void refreshStagesList()
        {
            using (var db = new DataModelContainer())
            {
                var job = db.JobSet.Where(j => j.Id == referencedJob.Id && j.Name == referencedJob.Name).
                    First();
                var stages = db.StageSet.AsEnumerable()
                    .Where(s => s.Jobs.Contains(job)).ToList();

                stagesListView.Items.Clear();
                foreach (var stage in stages)
                {
                    stagesListView.Items.Add(new ListViewItem(
                        new string[] { stage.Id.ToString(), stage.Name }));
                }
            }
        }

        private void stageAdministrationButtonClicked(object sender, EventArgs e)
        {
            using (var stagesPanel = new StagesAdministrationPanel())
            {
                stagesPanel.ShowDialog();
            }
            refreshStagesBox();
        }

        private void removeButtonClick(object sender, EventArgs e)
        {
            foreach (ListViewItem stageItem in stagesListView.SelectedItems)
            {
                var stage = new Stage();
                stage.Id = int.Parse(stageItem.SubItems[0].Text);
                stage.Name = stageItem.SubItems[1].Text;
                using (var db = new DataModelContainer())
                {
                    var job = db.JobSet.AsEnumerable().Where(j => j.Equals(referencedJob)).First();
                    job = db.JobSet.Attach(job);
                    stage = db.StageSet.Where(j => j.Id == stage.Id && j.Name == stage.Name)
                        .First();
                    stage = db.StageSet.Attach(stage);
                    job.Stage.Remove(stage);
                    stage.Jobs.Remove(job);
                    db.SaveChanges();
                }
            }
            refreshStagesList();
        }

        private void addStageButtonClicked(object sender, EventArgs e)
        {
            using (var db = new DataModelContainer())
            {
                var job = db.JobSet.AsEnumerable().Where(j => j.Equals(referencedJob)).First();
                var stage = db.StageSet.Where(s => s.Name == stagesComboBox.Text).First();
                job = db.JobSet.Attach(job);
                stage = db.StageSet.Attach(stage);
                job.Stage.Add(stage);
                stage.Jobs.Add(job);
                db.SaveChanges();
            }
            refreshStagesList();
        }

        private void refreshStagesBoxCliked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            refreshStagesBox();
        }

        private void refreshStagesListClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            refreshStagesList();
        }
    }
}
