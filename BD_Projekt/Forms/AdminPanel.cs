using BD_Projekt.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD_Projekt
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void createNewJobButtonClick(object sender, EventArgs e)
        {
            new JobAdministrationPanel().Show();
        }

        private void createNewUserButtonClick(object sender, EventArgs e)
        {
            new NewUserPanel().Show();
        }
    }
}
