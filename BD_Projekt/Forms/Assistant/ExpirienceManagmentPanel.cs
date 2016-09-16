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
    public partial class ExpirienceManagmentPanel : Form
    {
        private Recruited recruited;

        public ExpirienceManagmentPanel(Recruited recruitedArg)
        {
            InitializeComponent();
            recruited = recruitedArg;
            recruitedTextBox.Text = recruited.Name + " " + recruited.Surname;
            refreshExpirienceListView();
        }

        private void refreshExpirienceListView()
        {
            using (var db = new DataModelContainer())
            {
                var expiriences = db.ProfessionalExperienceSet
                    .Where(e => e.Recruited.Id == recruited.Id).ToList();
                expirienceListView.Items.Clear();
                foreach ( var expirience in expiriences)
                {
                    string[] item =
                    {
                        expirience.Id.ToString(),
                        expirience.Company,
                        expirience.Job,
                        expirience.From.Date.ToString(),
                        expirience.To.Date.ToString()
                    };
                    expirienceListView.Items.Add(new ListViewItem(item));
                }
            }
        }

        private void refreshExpiriencesLinkClicked(object sender, EventArgs e)
        {
            refreshExpirienceListView();
        }

        private void addExpirienceButtonClicked(object sender, EventArgs e)
        {
            var expirience = new ProfessionalExperience();
            expirience.Company = companyNameTextBox.Text;
            expirience.Job = positionNameTextBox.Text;
            expirience.From = fromTimePicker.Value.Date;
            expirience.To = toTimePicker.Value.Date;
            using (var db = new DataModelContainer())
            {
                var rec = db.RecruitedSet.Attach(recruited);
                rec.ProfessionalExperience.Add(expirience);
                db.SaveChanges();
            }
            refreshExpirienceListView();
        }

        private void removeExpirienceButtonClick(object sender, EventArgs e)
        {
            foreach(ListViewItem expirience in expirienceListView.SelectedItems)
            {
                var id = int.Parse(expirience.SubItems[0].Text);
                using (var db = new DataModelContainer())
                {
                    db.ProfessionalExperienceSet.Remove(
                        db.ProfessionalExperienceSet.Where(
                            ex => ex.Id == id).Single());
                    db.SaveChanges();
                }
            }
            refreshExpirienceListView();
        }
    }
}
