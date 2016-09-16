using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD_Projekt.Forms
{
    public partial class ChangeJobNameForm : Form
    {
        private Job job;
        public ChangeJobNameForm(Job passedJob)
        {
            InitializeComponent();
            job = passedJob;
            jobNameTextbox.Text = job.Name;
        }

        private void okButtonClick(object sender, EventArgs e)
        {
            using(var db = new DataModelContainer())
            {
                var toChange = db.JobSet.AsEnumerable().Where(j => job.Equals(j)).First();
                toChange.Name = jobNameTextbox.Text;
                db.JobSet.Attach(toChange);
                var entry = db.Entry(toChange);
                entry.Property(j => j.Name).IsModified = true;
                db.SaveChanges();
            }
            Close();
        }

        private void cancelButtonClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
