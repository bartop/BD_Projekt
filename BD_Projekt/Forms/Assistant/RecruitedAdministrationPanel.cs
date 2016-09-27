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

using System.Data.Entity.Validation;
using System.Diagnostics;

namespace BD_Projekt
{
    public partial class RecruitedAdministrationPanel : Form
    {
        string[] nationality = new string[] { "Afghan", "Albanian", "Algerian", "American", "Andorran", "Angolan", "Antiguans", "Argentinean", "Armenian", "Australian", "Austrian", "Azerbaijani", "Bahamian", "Bahraini", "Bangladeshi", "Barbadian", "Barbudans", "Batswana", "Belarusian", "Belgian", "Belizean", "Beninese", "Bhutanese", "Bolivian", "Bosnian", "Brazilian", "British", "Bruneian", "Bulgarian", "Burkinabe", "Burmese", "Burundian", "Cambodian", "Cameroonian", "Canadian", "Cape Verdean", "Central African", "Chadian", "Chilean", "Chinese", "Colombian", "Comoran", "Congolese", "Costa Rican", "Croatian", "Cuban", "Cypriot", "Czech", "Danish", "Djibouti", "Dominican", "Dutch", "East Timorese", "Ecuadorean", "Egyptian", "Emirian", "Equatorial Guinean", "Eritrean", "Estonian", "Ethiopian", "Fijian", "Filipino", "Finnish", "French", "Gabonese", "Gambian", "Georgian", "German", "Ghanaian", "Greek", "Grenadian", "Guatemalan", "Guinea-Bissauan", "Guinean", "Guyanese", "Haitian", "Herzegovinian", "Honduran", "Hungarian", "Icelander", "Indian", "Indonesian", "Iranian", "Iraqi", "Irish", "Israeli", "Italian", "Ivorian", "Jamaican", "Japanese", "Jordanian", "Kazakhstani", "Kenyan", "Kittian and Nevisian", "Kuwaiti", "Kyrgyz", "Laotian", "Latvian", "Lebanese", "Liberian", "Libyan", "Liechtensteiner", "Lithuanian", "Luxembourger", "Macedonian", "Malagasy", "Malawian", "Malaysian", "Maldivan", "Malian", "Maltese", "Marshallese", "Mauritanian", "Mauritian", "Mexican", "Micronesian", "Moldovan", "Monacan", "Mongolian", "Moroccan", "Mosotho", "Motswana", "Mozambican", "Namibian", "Nauruan", "Nepalese", "Netherlander", "New Zealander", "Ni-Vanuatu", "Nicaraguan", "Nigerian", "Nigerien", "North Korean", "Northern Irish", "Norwegian", "Omani", "Pakistani", "Palauan", "Panamanian", "Papua New Guinean", "Paraguayan", "Peruvian", "Polish", "Portuguese", "Qatari", "Romanian", "Russian", "Rwandan", "Saint Lucian", "Salvadoran", "Samoan", "San Marinese", "Sao Tomean", "Saudi", "Scottish", "Senegalese", "Serbian", "Seychellois", "Sierra Leonean", "Singaporean", "Slovakian", "Slovenian", "Solomon Islander", "Somali", "South African", "South Korean", "Spanish", "Sri Lankan", "Sudanese", "Surinamer", "Swazi", "Swedish", "Swiss", "Syrian", "Taiwanese", "Tajik", "Tanzanian", "Thai", "Togolese", "Tongan", "Trinidadian or Tobagonian", "Tunisian", "Turkish", "Tuvaluan", "Ugandan", "Ukrainian", "Uruguayan", "Uzbekistani", "Venezuelan", "Vietnamese", "Welsh", "Yemenite", "Zambian", "Zimbabwean" };
        Worker assistant;

        public RecruitedAdministrationPanel(Worker worker)
        {
            InitializeComponent();
            assistant = worker;
            refreshRecruitedList();
            foreach (var nat in nationality) {
                nationalityGui.Items.Add(nat);
            }
            nationalityGui.SelectedIndex = nationality.ToList().LastIndexOf("Polish");
        }

        private void confirmClick(object sender, EventArgs ev)
        {
            try {
                using (var db = new DataModelContainer())
                {
                    if (chceckBoxes())
                    {
                        var recruited = new Recruited();
                        recruited.Name = name.Text;
                        recruited.Surname = surname.Text;
                        recruited.PhoneNumber = phoneNumber.Text;
                        recruited.Name = name.Text;
                        recruited.DateOfBirth = birthDate.Value.Date;
                        recruited.Email = email.Text;
                        recruited.Nationality = nationalityGui.Text;
                        db.RecruitedSet.Add(recruited);
                        db.SaveChanges();

                    }
                }
                refreshRecruitedList();
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    foreach (var ve in eve.ValidationErrors)
                    {
                        MessageBox.Show(ve.ErrorMessage, ve.PropertyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } 

        private bool chceckBoxes()
        {
            if(name.Text == String.Empty || email.Text == String.Empty || phoneNumber.Text == String.Empty || 
                surname.Text == String.Empty || nationalityGui.Text == String.Empty )
            {
                MessageBox.Show("Formularz posiada puste pola", "Błąd",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;         
            }
            return true;          
        }

        private void refreshRecruitedList()
        {
            List<Recruited> recruitedList;
            using (var db = new DataModelContainer())
            {
                recruitedList = db.RecruitedSet.ToList();
                recruitedListView.SetObjects(recruitedList);

               /* recruitedListView.Items.Clear();
                foreach (var recruited in recruitedList)
                {
                    var viewItem = new ListViewItem(
                        new string[] {
                            recruited.Id.ToString(),
                            recruited.Name + " " + recruited.Surname,
                            recruited.Email });
                    recruitedListView.Items.Add(viewItem);
                } */
            }
        }

        private void refreshLinkLabelClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            refreshRecruitedList();
        }

        private void closeWindowButtonClicked(object sender, EventArgs e)
        {
            this.Close();
        }

        private void removeRecruitedButtonClicked(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Tej operacji nie można cofnąć! Czy na pewno chcesz trwale usunąć wszystkich zaznaczonych rekrutowanych?", "Uwaga", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            try {
                foreach (ListViewItem item in recruitedListView.SelectedItems)
                {
                    int id = int.Parse(item.SubItems[0].Text);
                    using (var db = new DataModelContainer())
                    {
                        db.RecruitedSet.Remove(
                            db.RecruitedSet.Where(r => r.Id == id).First());
                        db.SaveChanges();
                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd");
            }
            refreshRecruitedList();
        }

        private void manageDocumentsButtonClicked(object sender, EventArgs e)
        {
            foreach( ListViewItem item in recruitedListView.SelectedItems )
            {
                Recruited recruited;
                using (var db = new DataModelContainer())
                {
                    int id = int.Parse(item.SubItems[0].Text);
                    recruited = 
                        db.RecruitedSet.Where(r => r.Id == id).Single();
                }
                using(var dialog = new AddFilePanel(recruited))
                {
                    dialog.ShowDialog();
                }
            }
        }

        private void manageExpirienceButtonClicked(object sender, EventArgs e)
        {
            foreach (ListViewItem item in recruitedListView.SelectedItems)
            {
                Recruited recruited;
                using (var db = new DataModelContainer())
                {
                    int id = int.Parse(item.SubItems[0].Text);
                    recruited =
                        db.RecruitedSet.Where(r => r.Id == id).Single();
                }
                using (var dialog = new ExpirienceManagmentPanel(recruited))
                {
                    dialog.ShowDialog();
                }
            }
        }

        private void manageEducationButtonClicked(object sender, EventArgs e)
        {
            foreach (ListViewItem item in recruitedListView.SelectedItems)
            {
                Recruited recruited;
                using (var db = new DataModelContainer())
                {
                    int id = int.Parse(item.SubItems[0].Text);
                    recruited =
                        db.RecruitedSet.Where(r => r.Id == id).Single();
                }
                using (var dialog = new EducationAdministrationForm(recruited))
                {
                    dialog.ShowDialog();
                }
            }
        }

        private void manageApplicationsButtonClicked(object sender, EventArgs e)
        {
            foreach (ListViewItem item in recruitedListView.SelectedItems)
            {
                Recruited recruited;
                using (var db = new DataModelContainer())
                {
                    int id = int.Parse(item.SubItems[0].Text);
                    recruited =
                        db.RecruitedSet.Where(r => r.Id == id).Single();
                }
                using (var dialog = new ApplicationAdministrationPanel(
                    assistant, recruited))
                {
                    dialog.ShowDialog();
                }
            }

        }

        private void showDataButtonClicked(object sender, EventArgs e)
        {
            foreach (ListViewItem item in recruitedListView.SelectedItems)
            {
                Recruited recruited;
                using (var db = new DataModelContainer())
                {
                    int id = int.Parse(item.SubItems[0].Text);
                    recruited =
                        db.RecruitedSet.Where(r => r.Id == id).Single();
                }
                using (var dialog = new RecruitedPreviewForm(recruited.Id))
                {
                    dialog.ShowDialog();
                }
            }
        }
    }
}
