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
    public partial class EditSkillWeightPanel : Form
    {
        private Requires requirement;
        public EditSkillWeightPanel(Requires referencedRequirement, string jobName, string skillName)
        {
            InitializeComponent();
            requirement = referencedRequirement;
            skillNameTextbox.Text = skillName;
            jobNameTextBox.Text = jobName;
            skillWeightTextBox.Text = referencedRequirement.Weight.ToString();
        }

        private void okButtonClick(object sender, EventArgs e)
        {
            using(var db = new DataModelContainer())
            {
                var toChange = db.RequiresSet.Where(r => r.Id == requirement.Id &&
                    r.Weight == requirement.Weight).First();
                toChange.Weight = int.Parse(skillWeightTextBox.Text);
                db.RequiresSet.Attach(toChange);
                var entry = db.Entry(toChange);
                entry.Property(r => r.Weight).IsModified = true;
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
