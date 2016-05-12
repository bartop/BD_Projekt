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
            List<string> jobsList;
            using (var db = new ModelContainer())
            {
                jobsList = db.JobSet.Select(s => s.Name).ToList();
            }
            jobsListView.Items.Clear();
            foreach (var skillName in jobsList)
            {
                jobsListView.Items.Add(skillName);
            }
        }

        private void refreshTimerTick(object sender, EventArgs e)
        {
            refreshJobsList();
        }

        private void detailsButtonClick(object sender, EventArgs e)
        {
            foreach (ListViewItem item in jobsListView.SelectedItems)
            {
            }
        }

        private void changeNameButtonClick(object sender, EventArgs e)
        {
            foreach (ListViewItem item in jobsListView.SelectedItems)
            {

            }
        }

        private void closeButtonClick(object sender, EventArgs e)
        {
            Close();
        }

        private void removeJobClick(object sender, EventArgs e)
        {
            using (var db = new ModelContainer())
            {
                foreach (ListViewItem item in jobsListView.SelectedItems)
                {
                    db.JobSet.RemoveRange(db.JobSet.Where(j => j.Name == item.Text).ToList());
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
    }
}
