using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD_Projekt.Forms
{
    public partial class SkillsAdministrationPanel : Form
    {
        public SkillsAdministrationPanel()
        {
            InitializeComponent();
            refreshSkillList();
        }

        private void refreshSkillList()
        {
            List<string> skillList;
            using (var db = new DataModelContainer())
            {
                skillList = db.SkillSet.Select(s => s.Name).ToList();
            }
            skillListView.Items.Clear();
            foreach (var skillName in skillList)
            {
                skillListView.Items.Add(skillName);
            }
        }

        private void addSkillButtonClick(object sender, EventArgs e)
        {
            var skill = new Skill();
            skill.Name = skillNameTextBox.Text;
            skillNameTextBox.Text = "";
            using(var db = new DataModelContainer())
            {
                db.SkillSet.Add(skill);
                try
                {
                    db.SaveChanges();
                }
                catch (DbEntityValidationException exception)
                {
                    DataModelContainer.handleValidationException(exception);
                }
            }
            refreshSkillList();
        }

        private void closeButtonClick(object sender, EventArgs e)
        {
            Close();
        }

        private void deleteSkillButtonClick(object sender, EventArgs e)
        {
            using (var db = new DataModelContainer())
            {
                foreach (ListViewItem item in skillListView.SelectedItems)
                {
                    db.SkillSet.RemoveRange(db.SkillSet.Where(s => s.Name == item.Text).ToList());
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
            refreshSkillList();
        }

        private void refreshLabelClick(object sender, EventArgs e)
        {
            refreshSkillList();
        }
    }
}
