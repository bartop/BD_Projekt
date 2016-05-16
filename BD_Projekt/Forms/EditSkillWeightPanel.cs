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
        public EditSkillWeightPanel(Requires referencedRequirement)
        {
            InitializeComponent();
            requirement = referencedRequirement;

        }

        private void okButtonClick(object sender, EventArgs e)
        {

            Close();
        }

        private void cancelButtonClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
