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
                decidedListView.Items.Clear();
                foreach(var application in applications)
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
                }
            }
        }

        private void addApproval(bool approved)
        {
            foreach (ListViewItem item in decidedListView.SelectedItems) {
                Approval app = new Approval();
                app.Approved = approved;
                using (var db = new DataModelContainer())
                {
                    string recruitedName = item.SubItems[0].Text;
                    string recruitedSurname = item.SubItems[1].Text;
                    string jobName = item.SubItems[2].Text;

                    app.Worker = db.WorkerSet
                        .Where(w => w.Id == supervisor.Id)
                        .Single();
                    app.Decision = db.ApplicationSet
                        .Where(a => a.Job.Name == jobName
                        && a.Recruited.Name == recruitedName
                        && a.Recruited.Surname == recruitedSurname)
                        .First().Decision;

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
            foreach (ListViewItem item in decidedListView.SelectedItems)
            {
                Application application;
                Recruited recruited;
                using (var db = new DataModelContainer())
                {
                    string recruitedName = item.SubItems[0].Text;
                    string recruitedSurname = item.SubItems[1].Text;
                    string jobName = item.SubItems[2].Text;

                    application = db.ApplicationSet
                            .Where(a => a.Job.Name == jobName
                            && a.Recruited.Name == recruitedName
                            && a.Recruited.Surname == recruitedSurname)
                            .First();
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
