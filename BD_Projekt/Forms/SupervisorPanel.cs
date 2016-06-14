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
    public partial class SupervisorPanel : MainForm
    {
        private Worker worker;
        private int selectedApplicationId;
        public SupervisorPanel(Worker worker)
        {
            InitializeComponent();
            this.worker = worker;
            LoadApplications();
        }

        private void LoadApplications()
        {
            using (var db = new ModelContainer())
            {
                foreach (var application in db.ApplicationSet)
                {
                    string decision = "Brak";
                    if (application.Decision != null)
                    {
                        decision = application.Decision.ToString();
                    }
                    var item = new ListViewItem(new string[] { application.Id.ToString(), application.Job.Name, application.Recruited.Name, application.Recruited.Surname, decision });
                    applicationsList.Items.Add(item);

                }
           
            }

        }

        private void applicationPreview_Click(object sender, EventArgs e)
        {
            if (applicationsList.SelectedItems.Count > 0)
            {
                var form = new Forms.ApplicationPreviewForm(selectedApplicationId);
                form.Show();
            }
        }


        private void approveButton_Click(object sender, EventArgs e)
        {
            if (applicationsList.SelectedItems.Count > 0)
            {
                using (var db = new ModelContainer())
                {
                    var application = db.ApplicationSet.Find(selectedApplicationId);
                    if (application.Decision.Approval == null)
                    {
                        application.Decision.Approval = new Approval();
                        application.Decision.Approval.Approved = true;
                        application.Decision.Approval.Worker = worker;
                    }
                }
            }
        }

        private void disapproveButton_Click(object sender, EventArgs e)
        {
            if (applicationsList.SelectedItems.Count > 0)
            {
                using (var db = new ModelContainer())
                {
                    var application = db.ApplicationSet.Find(selectedApplicationId);
                    if (application.Decision.Approval == null)
                    {
                        application.Decision.Approval = new Approval();
                        application.Decision.Approval.Approved = false;
                        application.Decision.Approval.Worker = worker;
                    }
                }
            }
        }

        private void applicationsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (applicationsList.SelectedItems.Count > 0)
            {
                selectedApplicationId = int.Parse(applicationsList.SelectedItems[0].SubItems[0].Text);
                using (var db = new ModelContainer())
                {
                    var application = db.ApplicationSet.Find(selectedApplicationId);
                    
                }
            }
        }

        private void gradesPreviewButton_Click(object sender, EventArgs e)
        {
            if (applicationsList.SelectedItems.Count > 0)
            {
                using (var db = new ModelContainer())
                {
                    var application = db.ApplicationSet.Find(selectedApplicationId);
                    if (application.Decision != null)
                    {
                        var form = new Forms.GradesPreviewForm(application.Decision.Id);
                        form.Show();
                    }
                }
            }
        }
    }
}
