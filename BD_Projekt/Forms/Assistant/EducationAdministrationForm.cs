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
    public partial class EducationAdministrationForm : Form
    {
        private Recruited recruited;

        public EducationAdministrationForm(Recruited recruitedArg)
        {
            InitializeComponent();
            recruited = recruitedArg;
            recruitedTextBox.Text = recruited.Name + " " + recruited.Surname;
            refreshEducationListView();
        }

        private void refreshEducationListView()
        {
            using (var db = new DataModelContainer())
            {
                var educationList = db.EducationSet
                    .Where(e => e.Recruited.Id == recruited.Id).ToList();
                educationListView.Items.Clear();
                foreach (var education in educationList)
                {
                    string[] item =
                    {
                        education.Id.ToString(),
                        education.SchoolName,
                        education.Name,
                        education.FromYear.Date.ToString(),
                        education.ToYear.Date.ToString()
                    };
                    educationListView.Items.Add(new ListViewItem(item));
                }
            }
        }

        private void refreshEducationLinkClicked(object sender, EventArgs e)
        {
            refreshEducationListView();
        }

        private void addEducationButtonClicked(object sender, EventArgs e)
        {
            var education = new Education();
            education.SchoolName = schoolNameTextBox.Text;
            education.Name = educationNameTextBox.Text;
            education.FromYear = fromTimePicker.Value.Date;
            education.ToYear = toTimePicker.Value.Date;
            using (var db = new DataModelContainer())
            {
                var rec = db.RecruitedSet.Attach(recruited);
                rec.Education.Add(education);
                db.SaveChanges();
            }
            refreshEducationListView();
        }

        private void removeEducationButtonClick(object sender, EventArgs e)
        {
            foreach (ListViewItem education in educationListView.SelectedItems)
            {
                var id = int.Parse(education.SubItems[0].Text);
                using (var db = new DataModelContainer())
                {
                    db.EducationSet.Remove(
                        db.EducationSet.Where(
                            ex => ex.Id == id).Single());
                    db.SaveChanges();
                }
            }
            refreshEducationListView();
        }
    }
}
