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
    public partial class AsistantPanel : Form
    {
        public AddFilePanel new_recruitment_documents_Pane;

        public AsistantPanel()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new_recruitment_documents_Pane = new AddFilePanel();
            new_recruitment_documents_Pane.Activate();
            new_recruitment_documents_Pane.Show();
        }
    }
}
