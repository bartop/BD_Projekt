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
    public partial class SkillLevelForm : Form
    {
        Recruited recruited;

        public SkillLevelForm(Recruited recruitedArg)
        {
            InitializeComponent();
            recruited = recruitedArg;
            refreshSkillBox();
            refreshSkillLevelsList();
            for (int i = 0; i < 10; ++i)
            {
                levelComboBox.Items.Add(i);
            }
            recruitedNameTextBox.Text = recruited.Name + " " + recruited.Surname;
        }

        private void refreshSkillBox()
        {
            List<string> skillsNames;
            using (var db = new DataModelContainer())
            {
                skillsNames = db.SkillSet.Select(s => s.Name).ToList();
                List<string> possessedSkills = db.RecruitedSet
                    .Where(r => r.Id == recruited.Id)
                    .Single()
                    .Posesses
                    .Select(p => p.Skills)
                    .Select(s => s.Name).ToList();

                skillsNames = new List<string>(skillsNames.Except(possessedSkills));
            }
            skillsComboBox.Items.Clear();
            foreach (var skillName in skillsNames)
            {
                skillsComboBox.Items.Add(skillName);
            }
        }

        private void refreshSkillLevelsList()
        {
            skillLevelListView.Items.Clear();
            using (var db = new DataModelContainer())
            {
                foreach(var skillLevel in db.PosessesSet.
                    Where(p => p.Recruited.Id == recruited.Id).ToList())
                {
                    skillLevelListView.Items.Add(
                        new ListViewItem(
                            new string[] { skillLevel.Skills.Name,
                                skillLevel.Level.ToString() }));
                }
            }
        }

        private void refreshSkillsLinkClicked(object sender, EventArgs e)
        {
            refreshSkillBox();
        }

        private void addSkillGradeButtonClicked(object sender, EventArgs e)
        {
            var skillGrade = new Posesses();
            skillGrade.Level = byte.Parse(levelComboBox.Text);
            using (var db = new DataModelContainer())
            {
                var rec = db.RecruitedSet.Where(r => r.Id == recruited.Id).Single();
                var skill = db.SkillSet
                    .Where(s => s.Name == skillsComboBox.Text).Single();
                skillGrade.Recruited = rec;
                skillGrade.Skills = skill;
                db.PosessesSet.Add(skillGrade);
                db.SaveChanges();
            }
            refreshSkillLevelsList();
            refreshSkillBox();
        }

        private void deleteSkillGradeButtonClick(object sender, EventArgs e)
        {
            foreach (ListViewItem item in skillLevelListView.SelectedItems)
            {
                using (var db = new DataModelContainer())
                {
                    var name = item.SubItems[0].Text;
                    db.PosessesSet.Remove(
                        db.PosessesSet.Where(p => p.Recruited.Id == recruited.Id &&
                        p.Skills.Name == name).Single());
                    db.SaveChanges();
                }
            }
            refreshSkillLevelsList();
            refreshSkillBox();
        }
    }
}