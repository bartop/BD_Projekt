using System;
using System.Data;
using System.Collections.Generic;
using System.Windows.Forms;
using System.ComponentModel;
using BD_Projekt.Forms;
using System.Linq;

namespace BD_Projekt.Forms
{
    public partial class JobRequirementsPanel : Form
    {
        Job referencedJob;

        public JobRequirementsPanel(Job job)
        {
            InitializeComponent();
            jobNameTextBox.Text = job.Name;
            referencedJob = job;
            refreshSkillBox();
            refreshRequirementsList();
        }

        private void refreshSkillBox()
        {
            List<string> skillsNames;
            using(var db = new ModelContainer())
            {
                skillsNames = db.SkillSet.Select(s => s.Name).ToList();
            }
            skillsComboBox.Items.Clear();
            foreach(var skillName in skillsNames)
            {
                skillsComboBox.Items.Add(skillName);
            }
        }

        private void refreshRequirementsList()
        {
            using (var db = new ModelContainer())
            {
                var requirements = db.RequiresSet.AsEnumerable().Where(r => r.Jobs.Equals(referencedJob)).ToList();

                requirementsListView.Items.Clear();
                foreach (var req in requirements)
                {
                    requirementsListView.Items.Add(new ListViewItem(
                        new string[] { req.Id.ToString(), req.Skills.Name.ToString(), req.Weight.ToString() }));
                }
            }
        }


        private void skillsAdministrationButtonClick(object sender, EventArgs e)
        {
            using (var dialog = new SkillsAdministrationPanel())
            {
                dialog.ShowDialog();
            }
            refreshSkillBox();
        }

        private void removeRequirementButtonClick(object sender, EventArgs e)
        {
            foreach (ListViewItem reqItem in requirementsListView.SelectedItems)
            {
                var req = new Requires();
                req.Id = int.Parse(reqItem.SubItems[0].Text);
                req.Weight = int.Parse(reqItem.SubItems[2].Text);
                using (var db = new ModelContainer())
                {
                    db.RequiresSet.Remove(db.RequiresSet.Where(r => r.Id == req.Id && r.Weight == req.Weight)
                        .First());
                    db.SaveChanges();
                }
            }
            refreshRequirementsList();
        }

        private void changeWeightButtonClick(object sender, EventArgs e)
        {
            foreach (ListViewItem item in requirementsListView.SelectedItems) {
                Requires req;
                using (var db = new ModelContainer())
                {
                    req = db.RequiresSet.Where(r => r.Id == int.Parse(item.SubItems[0].Text)
                        && int.Parse(item.SubItems[2].Text) == r.Weight).First();
                }
                using (var dialog = new EditSkillWeightPanel(req))
                {
                    dialog.ShowDialog();
                }
            }
        }

        private void addNewRequirementButtonClick(object sender, EventArgs e)
        {
            var req = new Requires();
            req.Weight = int.Parse(skillWeightTextBox.Text);
            using (var db = new ModelContainer())
            {
                var job = db.JobSet.AsEnumerable().Where(j => j.Equals(referencedJob)).First();
                var skill = db.SkillSet.Where(s => s.Name == skillsComboBox.Text).First();
                req.Skills = skill;
                req.Jobs = job;
                db.RequiresSet.Add(req);
                db.SaveChanges();
            }
            refreshRequirementsList();
            skillWeightTextBox.Text = "";
        }

        private void refreshRequirementsLinkClick(object sender, EventArgs e)
        {
            refreshRequirementsList();
        }

        private void refershSkillsLinkClick(object sender, EventArgs e)
        {
            refreshSkillBox();
        }
    }
}
