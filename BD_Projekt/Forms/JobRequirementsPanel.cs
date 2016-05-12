using System;
using System.Data;
using System.Collections.Generic;
using System.Windows.Forms;
using System.ComponentModel;
using BD_Projekt.Forms;
using System.Linq;

namespace BD_Projekt
{
    public partial class JobRequirementsPanel : Form
    {
        private class SkillRequirements
        {
            public String Name { get; set; }
            public int Weight { get; set; }
        }
        List<Requires> requirementsList;
        BindingList<SkillRequirements> displayedData;
        Job referencedJob;

        public JobRequirementsPanel(Job job)
        {
            InitializeComponent();
            jobNameTextBox.Text = job.Name;
            referencedJob = job;
            requirementsList = new List<Requires>();
            displayedData = new BindingList<SkillRequirements>();
            var source = new BindingSource(displayedData, null);
            skillsTable.DataSource = source;
            reloadSkillBox();
        }

        private void reloadSkillBox()
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

        private void addSkillClick(object sender, EventArgs e)
        {
            Skill skill;
            using(var db = new ModelContainer())
            {
                skill = db.SkillSet.Where(s => s.Name == skillsComboBox.Text).First();
            }
            var requirement = new Requires();
            requirement.Weight = int.Parse(skillWeightTextBox.Text);
            requirement.Skills = skill;
            requirementsList.Add(requirement);

            var toDisplay = new SkillRequirements();
            toDisplay.Weight = int.Parse(skillWeightTextBox.Text);
            toDisplay.Name = skillsComboBox.Text;
            displayedData.Add(toDisplay);
        }

        private void addJobButtonClick(object sender, EventArgs e)
        {
            using(var db = new ModelContainer())
            {
                foreach (var requirement in requirementsList)
                {
                    requirement.Jobs = referencedJob;
                    db.RequiresSet.Add(requirement);
                }
                db.SaveChanges();
            }
        }

 
        private void newSkillButtonClick(object sender, EventArgs e)
        {
            new SkillsAdministrationPanel().Show();
        }

        private void refreshTimerTick(object sender, EventArgs e)
        {
            reloadSkillBox();
        }
    }
}
