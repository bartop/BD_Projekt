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
    public partial class JobAdministrationPanel : Form
    {
        public JobAdministrationPanel()
        {
            InitializeComponent();
            refreshJobsList();
        }

        private void refreshJobsList()
        {
            List<Job> jobsList;
            using (var db = new DataModelContainer())
            {
                jobsList = db.JobSet.ToList();

                jobsListView.Items.Clear();
                foreach (var job in jobsList)
                {
                    string skillsString = "";
                    foreach (var requirement in job.Requires)
                    {
                        skillsString += requirement.Skills.Name + " ";
                    }
                    var viewItem = new ListViewItem(new string[] { job.Id.ToString(), job.Name, skillsString });
                    jobsListView.Items.Add(viewItem);
                }
            }
        }

        private void detailsButtonClick(object sender, EventArgs e)
        {
            foreach (ListViewItem item in jobsListView.SelectedItems)
            {
                Job job;
                using(var db = new DataModelContainer())
                {
                    int jid = int.Parse(item.SubItems[0].Text);
                    job = db.JobSet.Where(j => j.Id == jid).First();
                }
                using (var requirementsDialog = new JobRequirementsPanel(job))
                {
                    requirementsDialog.ShowDialog();
                }
                refreshJobsList();
            }
        }

        private void changeNameButtonClick(object sender, EventArgs e)
        {
            foreach (ListViewItem item in jobsListView.SelectedItems)
            {
                Job job;
                using(var db = new DataModelContainer())
                {
                    int jobId = int.Parse(item.SubItems[0].Text);
                    job = db.JobSet.Where(j => j.Id == jobId).First();
                }
                using (var dialog = new ChangeJobNameForm(job))
                {
                    dialog.ShowDialog();
                }
                refreshJobsList();
            }
        }

        private void closeButtonClick(object sender, EventArgs e)
        {
            Close();
        }

        private void removeJobClick(object sender, EventArgs e)
        {
            using (var db = new DataModelContainer())
            {
                foreach (ListViewItem item in jobsListView.SelectedItems)
                {
                    int jid = int.Parse(item.SubItems[0].Text);
                    db.JobSet.Remove(db.JobSet.Where(j => j.Id == jid).First());
                    try
                    {
                        db.SaveChanges();
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message);
                    }
                }
            }
            refreshJobsList();
        }

        private void addJobButtonClick(object sender, EventArgs e)
        {
            try {
                if (String.IsNullOrWhiteSpace(jobNameTextBox.Text))
                {
                    MessageBox.Show("Wprowadź poprawną nazwę stanowiska!", "Błąd");
                }
                else
                {
                    using (var db = new DataModelContainer())
                    {
                        var job = new Job();
                        job.Name = jobNameTextBox.Text;
                        db.JobSet.Add(job);
                        db.SaveChanges();
                    }
                    refreshJobsList();
                    jobNameTextBox.Text = "";
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd");
            }
        }

        private void refreshLabelLinkCliked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            refreshJobsList();
        }

        private void stageDetailsButtonClick(object sender, EventArgs e)
        {
            foreach (ListViewItem item in jobsListView.SelectedItems)
            {
                Job job;
                using (var db = new DataModelContainer())
                {
                    int jid = int.Parse(item.SubItems[0].Text);
                    job = db.JobSet.Where(j => j.Id == jid).First();
                }
                using (var stagesDialog = new JobStagesAdministration(job))
                {
                    stagesDialog.ShowDialog();
                }
                refreshJobsList();
            }
        }
    }
}
