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
    public partial class DecisionPreviewForm : RefreshableForm
    {
        private int decisionId;
        public DecisionPreviewForm(int decisionId)
        {
            this.decisionId = decisionId;
            InitializeComponent();
            LoadData();
        }

        public override void LoadData()
        {
            using (var db = new ModelContainer())
            {
                var decision = db.DecisionSet.Find(decisionId);
                nameLabel.Text = decision.Application.Recruited.Name + " " + decision.Application.Recruited.Surname;

                decisionLabel.Text = decision.ToString();

                recruiterLabel.Text = decision.Worker.Name + " " + decision.Worker.Surname; 

                if (decision.Approval != null)
                {
                    acceptationLabel.Text = decision.Approval.ToString();
                }
                else
                {
                    acceptationLabel.Text = "Nie wydana";
                }
                explanationTextBox.Text = decision.Explanation;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
