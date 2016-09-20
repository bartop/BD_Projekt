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
    public partial class RecruitedList : Form
    {
        Worker recruiter;
        public RecruitedList(Worker recruiterArg)
        {
            InitializeComponent();
            refreshRecruitedList();
            recruiter = recruiterArg;
        }

        private void refreshRecruitedList()
        {
            List<Recruited> recruitedList;
            using (var db = new DataModelContainer())
            {
                recruitedList = db.RecruitedSet.ToList();

                recruitedListView.Items.Clear();
                foreach (var recruited in recruitedList)
                {
                    var viewItem = new ListViewItem(
                        new string[] {
                            recruited.Id.ToString(),
                            recruited.Name,
                            recruited.Surname,
                            recruited.Email });
                    recruitedListView.Items.Add(viewItem);
                }
            }
        }

        private void refreshListLinkCliked(object sender, EventArgs e)
        {
            refreshRecruitedList();
        }

        private void manageSkillsButtonClicked(object sender, EventArgs e)
        {
            foreach (ListViewItem item in recruitedListView.SelectedItems)
            {
                Recruited rec;
                using (var db = new DataModelContainer())
                {
                    int id = int.Parse(item.SubItems[0].Text);
                    rec = db.RecruitedSet
                        .Where(r => r.Id == id).Single();
                }
                using (var dialog = new SkillLevelForm(rec))
                {
                    dialog.ShowDialog();
                }
            }
        }

        private void closeWindowButtonClicked(object sender, EventArgs e)
        {
            Close();
        }

        private void manageApplicationsButtonClicked(object sender, EventArgs e)
        {
            foreach (ListViewItem item in recruitedListView.SelectedItems)
            {
                Recruited rec;
                Worker work;
                using (var db = new DataModelContainer())
                {
                    int id = int.Parse(item.SubItems[0].Text);
                    rec = db.RecruitedSet
                        .Where(r => r.Id == id).Single();
                    work = db.WorkerSet
                        .Where(w => w.Id == recruiter.Id).Single();
                }
                using (var dialog = new ApplicationList(rec, work))
                {
                    dialog.ShowDialog();
                }
            }
        }

        private void showDocumentsButtonClicked(object sender, EventArgs e)
        {
            foreach (ListViewItem item in recruitedListView.SelectedItems)
            {
                Recruited rec;
                using (var db = new DataModelContainer())
                {
                    int id = int.Parse(item.SubItems[0].Text);
                    rec = db.RecruitedSet
                        .Where(r => r.Id == id).Single();
                }
                using (var dialog = new AddFilePanel(rec, false))
                {
                    dialog.ShowDialog();
                }
            }
        }
    }
}
