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
    public partial class RecruitedPreviewForm : RefreshableForm
    {
        int recruitedId;
        public RecruitedPreviewForm(int recruitedId)
        {
            this.recruitedId = recruitedId;
            InitializeComponent();
            LoadData();

        }

        private void ApplicationPreviewForm_Load(object sender, EventArgs e)
        {

        }

        override public void LoadData()
        {
            try
            {
                using (var db = new DataModelContainer())
                {
                    var recruited = db.RecruitedSet.Find(recruitedId);
                    nameLabel.Text = recruited.Name;
                    surnameLabel.Text = recruited.Surname;
                    dateOfBirthLabel.Text = recruited.DateOfBirth.ToString();
                    phoneLabel.Text = recruited.PhoneNumber;
                    emailLabel.Text = recruited.Email;
                    applicationsList.Items.Clear();
                    foreach (var application in recruited.Applications)
                    {
                        applicationsList.Items.Add(new ListViewItem(new string[] { application.Job.Name}));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd");
            }

        }


        private void documentsPreviewButton_Click(object sender, EventArgs e)
        {
            try {
                Recruited recruited;
                using (var db = new DataModelContainer())
                {
                    recruited = db.RecruitedSet.Find(recruitedId);

                }
                using (var form = new AddFilePanel(recruited, false))
                {
                    form.ShowDialog();
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd");
            }
        }
    }
}