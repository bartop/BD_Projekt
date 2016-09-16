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
    public partial class ApplicationAdministrationPanel : Form
    {
        Worker assistant;
        Recruited recruited;

        public ApplicationAdministrationPanel(Worker worker, Recruited recruitedArg)
        {
            InitializeComponent();
            assistant = worker;
            recruited = recruitedArg;
            recruitedTextBox.Text = recruited.Name + " " + recruited.Surname;
            refreshJobsList();
            refreshApplicationList();
        }

        private void refreshJobsList()
        {
            using (var db = new DataModelContainer())
            {
                var jobList = db.JobSet.ToList();

                jobsComboBox.Items.Clear();
                foreach (var job in jobList)
                {
                    jobsComboBox.Items.Add(job.Name);
                }
            }
        }

        private void refreshApplicationList()
        {
            using (var db = new DataModelContainer())
            {
                var applications = db.ApplicationSet
                    .Where(a => a.Recruited.Id == recruited.Id).ToList();

                applicationsListView.Items.Clear();
                foreach (var application in applications)
                {
                    applicationsListView.Items.Add(application.Job.Name);
                }
            }
        }

        private void refreshJobsLinkClicked(object sender, EventArgs e)
        {
            refreshJobsList();
        }

        private void refreshApplicationsLinkClicked(object sender, EventArgs e)
        {
            refreshApplicationList();
        }

        private void addApplicationButtonClick(object sender, EventArgs e)
        {
            var application = new Application();
            using(var db = new DataModelContainer())
            {
                Worker work = db.WorkerSet.Where(w => w.Id == assistant.Id).Single();
                Recruited rec = db.RecruitedSet.Where(r => r.Id == recruited.Id).Single();
                Job job = db.JobSet.Where(j => j.Name == jobsComboBox.Text).Single();
                application.Assistant = work;
                application.Recruited = rec;
                application.Job = job;
                db.ApplicationSet.Add(application);
                db.SaveChanges();
            }
            refreshApplicationList();
        }

        private void removeApplicationButtonClicked(object sender, EventArgs e)
        {
            foreach (ListViewItem item in applicationsListView.SelectedItems)
            {
                using (var db = new DataModelContainer())
                {
                    db.ApplicationSet.Remove(
                        db.ApplicationSet.Where(a => a.Assistant.Id == assistant.Id
                        && a.Job.Name == item.Text && a.Recruited.Id == recruited.Id)
                        .First());

                    db.SaveChanges();
                }
            }
            refreshApplicationList();
        }
    }
}
