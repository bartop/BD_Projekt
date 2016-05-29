﻿using System;
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
    public partial class RecruiterPanel : Form
    {
        public RecruiterPanel()
        {
            InitializeComponent();
            RefreshApplications();
        }

        private void RefreshApplications()
        {
            using (var db = new ModelContainer())
            {
                applicationsListBox.Items.Clear();
                foreach (var application in db.ApplicationSet)
                {
                    applicationsListBox.Items.Add(application);
                }
            }
        }
    }
}
