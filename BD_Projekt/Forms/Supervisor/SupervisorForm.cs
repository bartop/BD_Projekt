using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BD_Projekt.Forms
{
    public partial class SupervisorForm : BD_Projekt.Forms.MainForm
    {
        private Worker supervisor;

        public SupervisorForm(Worker supervisorArg)
        {
            InitializeComponent();
            supervisor = supervisorArg;
        }

        private void openDecidedPanelButtonClicked(object sender, EventArgs e)
        {
            using (var dialog = new DecidedApplicationsPanel(supervisor))
            {
                dialog.ShowDialog();
            }
        }

        private void openAcceptedButtonClicked(object sender, EventArgs e)
        {
            using (var dialog = new AcceptedList())
            {
                dialog.ShowDialog();
            }
        }
    }
}