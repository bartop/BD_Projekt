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
    public partial class ApplicationList : Form
    {
        Recruited recruited;
        Worker recruiter;

        public ApplicationList(Recruited recruitedArg, Worker recruiterArg)
        {
            InitializeComponent();
            recruited = recruitedArg;
            recruiter = recruiterArg;
            recruitedNameTextBox.Text = recruited.Name + " " + recruited.Surname;
            refreshApplicationsListView();
        }

        private void refreshApplicationsListView()
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

        private void refereshApplicationsListLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            refreshApplicationsListView();
        }

        private void addStageGradesButtonCllicked(object sender, EventArgs e)
        {
            foreach(ListViewItem item in applicationsListView.SelectedItems)
            {
                Job job;
                using (var db = new DataModelContainer())
                {
                    job = db.JobSet.Where(j => j.Name == item.Text).Single();
                }
                using(var dialog = new StageGradePanel(recruited, job))
                {
                    dialog.ShowDialog();
                }
            }
        }

        private void addDecisionButtonClicked(object sender, EventArgs e)
        {
            foreach (ListViewItem item in applicationsListView.SelectedItems)
            {
                Application application;
                bool readOnly = false;
                using (var db = new DataModelContainer())
                {
                    var jobName = item.Text;
                    application = db.ApplicationSet.Where(a => a.Job.Name == jobName
                    && a.Recruited.Id == recruited.Id).Single();
                    if (application.Decision != null && application.Decision.Approval != null && application.Decision.Approval.Approved)
                    {
                        //Jeśli kierownik zaackeptował decyzję, to nie można jej zmienić
                        readOnly = true;
                    }
                }

                using(var dialog = new DecisionPanel(recruited, recruiter, application, readOnly))
                {
                    dialog.ShowDialog();
                }
            }
        }
    }
}
