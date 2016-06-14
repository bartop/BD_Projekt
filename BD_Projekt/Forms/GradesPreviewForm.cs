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
    public partial class GradesPreviewForm : RefreshableForm
    {
        private int applicationId;
        public GradesPreviewForm(int applicationId)
        {
            InitializeComponent();
            this.applicationId = applicationId;
        }

        override public void LoadData()
        {
            using (var db = new ModelContainer())
            {
                var application = db.ApplicationSet.Find(applicationId);
                gradesList.Items.Clear();
                jobLabel.Text = application.Job.Name;
                nameLabel.Text = application.Recruited.Name + " " + application.Recruited.Surname;
                foreach (var grade in application.StageGrades)
                {
                    gradesList.Items.Add(grade.Stage.Name, grade.Grade.ToString());
                }
            }
        }
    }
}
