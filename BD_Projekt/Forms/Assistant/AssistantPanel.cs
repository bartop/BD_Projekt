using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BD_Projekt.Forms
{
    public partial class AssistantPanel : BD_Projekt.Forms.MainForm
    {
        Worker assistant;

        public AssistantPanel(Worker worker)
        {
            InitializeComponent();
            assistant = worker;
        }

        private void recruitedPanelButtonClicked(object sender, EventArgs e)
        {
            new RecruitedAdministrationPanel(assistant).Show();
        }
    }
}
