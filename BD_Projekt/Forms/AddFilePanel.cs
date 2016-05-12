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
    public partial class AddFilePanel : Form
    {
        public AddFilePanel()
        {
            InitializeComponent();
        }

        private void AddFileButtonClick(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }
    }
}
