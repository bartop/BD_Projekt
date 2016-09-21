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
    public partial class RecruiterForm : MainForm
    {
        Worker recruiter;
        public RecruiterForm(Worker recruiterArg)
        {
            InitializeComponent();
            recruiter = recruiterArg;
        }

        private void openRecruitedListButtonClicked(object sender, EventArgs e)
        {
            new RecruitedList(recruiter).Show();
        }

        private void addRecruitedButton_Click(object sender, EventArgs e)
        {
            new RecruitedAdministrationPanel(recruiter).Show();
        }
    }
}
