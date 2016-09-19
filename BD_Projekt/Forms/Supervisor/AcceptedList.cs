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
    public partial class AcceptedList : Form
    {
        public AcceptedList()
        {
            InitializeComponent();

            refreshDecidedListView();
        }

        private void refreshDecidedListView()
        {
            using (var db = new DataModelContainer())
            {
                var applications = db.ApprovalSet
                    .Where(a => a.Approved == true)
                    .Select(a => a.Decision.Application);
                acceptedListView.Items.Clear();
                foreach (var application in applications)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        application.Recruited.Name,
                        application.Recruited.Surname,
                        application.Job.Name,
                        application.Decision.ToString()
                    });
                    acceptedListView.Items.Add(item);
                }
            }
        }

        private void refreshLinkClicked(object sender, EventArgs e)
        {
            refreshDecidedListView();
        }

        private void removeSelectedApplicationButtonClicked(object sender, EventArgs e)
        {
            foreach (ListViewItem item in acceptedListView.SelectedItems)
            {
                string recruitedName = item.SubItems[0].Text;
                string recruitedSurname = item.SubItems[1].Text;
                string jobName = item.SubItems[2].Text;
                using (var db = new DataModelContainer())
                {
                    var application = db.ApplicationSet
                      .Where(a => a.Job.Name == jobName
                        && a.Recruited.Name == recruitedName
                        && a.Recruited.Surname == recruitedSurname)
                        .First();
                    db.ApplicationSet.Remove(application);
                    db.SaveChanges();
                }
            }
        }
    }
}
