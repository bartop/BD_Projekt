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
    public partial class RefreshableForm : Form
    {
        private Timer timer = new Timer();

        public RefreshableForm()
        {
            InitializeComponent();
            timer.Interval = 2500;
            timer.Tick += CallLoadData;
            timer.Start();
        }
        private void CallLoadData(object o, EventArgs e)
        {
            LoadData();
        }
        public virtual void LoadData() { }
    }
}
