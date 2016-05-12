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
    public partial class EditSkillForm : Form
    {
        private Skill skill;

        public EditSkillForm(Skill skillToUpdate)
        {
            InitializeComponent();
            skill = skillToUpdate;
            updatedSkillTextBox.Text = skill.Name;
        }

        private void cancelButtonClick(object sender, EventArgs e)
        {
            Close();
        }

        private void confirmButtonClick(object sender, EventArgs e)
        {
            using(var db = new ModelContainer())
            {
                skill.Name = updatedSkillTextBox.Text;
                db.SkillSet.Attach(skill);
                var entry = db.Entry(skill);
                entry.Property(s => s.Name).IsModified = true;
                db.SaveChanges();
            }
            Close();
        }
    }
}
