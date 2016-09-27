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
    public partial class DecidedApplicationsPanel : Form
    {
        private Worker supervisor;

        public DecidedApplicationsPanel(Worker supervisorArg)
        {
            InitializeComponent();
            supervisor = supervisorArg;

            refreshDecidedListView();
        }

        private void refreshDecidedListView()
        {
            using (var db = new DataModelContainer())
            {
                var applications = db.DecisionSet.Select(d => d.Application);
                decidedListView.SetObjects(applications);
               /* foreach(var application in applications)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        application.Recruited.Name,
                        application.Recruited.Surname,
                        application.Job.Name,
                        application.Decision.ToString()
                    });
                    if(application.Decision.Approval != null)
                    {
                        if (application.Decision.Approval.Approved == true)
                            item.ForeColor = Color.Green;
                        else
                            item.ForeColor = Color.Red;
                    }
                    decidedListView.Items.Add(item);
                }*/
            }
        }

        private void addApproval(bool approved)
        {
            foreach (var item in decidedListView.SelectedObjects) {
                Approval app = new Approval();
                app.Approved = approved;
                using (var db = new DataModelContainer())
                {
                    int id = ((Application)item).Id;

                    app.Worker = db.WorkerSet
                        .Where(w => w.Id == supervisor.Id)
                        .Single();
                    app.Decision = db.ApplicationSet
                        .Find(id)
                        .Decision;

                    if (app.Decision.Approval != null)
                        db.ApprovalSet.Remove(app.Decision.Approval);

                    db.ApprovalSet.Add(app);
                    db.SaveChanges();
                }
            }
        }

        private void disapproveButtonClicked(object sender, EventArgs e)
        {
            addApproval(false);
            refreshDecidedListView();
        }

        private void refreshLinkClicked(object sender, EventArgs e)
        {
            refreshDecidedListView();
        }

        private void datailsButtonClicked(object sender, EventArgs e)
        {
            foreach (var item in decidedListView.SelectedObjects)
            {
                Application application;
                Recruited recruited;
                using (var db = new DataModelContainer())
                {
                    application = db.ApplicationSet
                            .Find(((Application)item).Id);
                    recruited = application.Recruited;
                }
                using (var dialog = new DecisionPanel(recruited, supervisor, application, true))
                {
                    dialog.ShowDialog();
                }
            }
        }

        private void aproveButtonClicked(object sender, EventArgs e)
        {
            addApproval(true);
            refreshDecidedListView();
        }
    }
}
