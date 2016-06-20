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
    public partial class AsistantPanel : MainForm
    {
        string[] nationality = new string[] { "Afghan", "Albanian", "Algerian", "American", "Andorran", "Angolan", "Antiguans", "Argentinean", "Armenian", "Australian", "Austrian", "Azerbaijani", "Bahamian", "Bahraini", "Bangladeshi", "Barbadian", "Barbudans", "Batswana", "Belarusian", "Belgian", "Belizean", "Beninese", "Bhutanese", "Bolivian", "Bosnian", "Brazilian", "British", "Bruneian", "Bulgarian", "Burkinabe", "Burmese", "Burundian", "Cambodian", "Cameroonian", "Canadian", "Cape Verdean", "Central African", "Chadian", "Chilean", "Chinese", "Colombian", "Comoran", "Congolese", "Costa Rican", "Croatian", "Cuban", "Cypriot", "Czech", "Danish", "Djibouti", "Dominican", "Dutch", "East Timorese", "Ecuadorean", "Egyptian", "Emirian", "Equatorial Guinean", "Eritrean", "Estonian", "Ethiopian", "Fijian", "Filipino", "Finnish", "French", "Gabonese", "Gambian", "Georgian", "German", "Ghanaian", "Greek", "Grenadian", "Guatemalan", "Guinea-Bissauan", "Guinean", "Guyanese", "Haitian", "Herzegovinian", "Honduran", "Hungarian", "Icelander", "Indian", "Indonesian", "Iranian", "Iraqi", "Irish", "Israeli", "Italian", "Ivorian", "Jamaican", "Japanese", "Jordanian", "Kazakhstani", "Kenyan", "Kittian and Nevisian", "Kuwaiti", "Kyrgyz", "Laotian", "Latvian", "Lebanese", "Liberian", "Libyan", "Liechtensteiner", "Lithuanian", "Luxembourger", "Macedonian", "Malagasy", "Malawian", "Malaysian", "Maldivan", "Malian", "Maltese", "Marshallese", "Mauritanian", "Mauritian", "Mexican", "Micronesian", "Moldovan", "Monacan", "Mongolian", "Moroccan", "Mosotho", "Motswana", "Mozambican", "Namibian", "Nauruan", "Nepalese", "Netherlander", "New Zealander", "Ni-Vanuatu", "Nicaraguan", "Nigerian", "Nigerien", "North Korean", "Northern Irish", "Norwegian", "Omani", "Pakistani", "Palauan", "Panamanian", "Papua New Guinean", "Paraguayan", "Peruvian", "Polish", "Portuguese", "Qatari", "Romanian", "Russian", "Rwandan", "Saint Lucian", "Salvadoran", "Samoan", "San Marinese", "Sao Tomean", "Saudi", "Scottish", "Senegalese", "Serbian", "Seychellois", "Sierra Leonean", "Singaporean", "Slovakian", "Slovenian", "Solomon Islander", "Somali", "South African", "South Korean", "Spanish", "Sri Lankan", "Sudanese", "Surinamer", "Swazi", "Swedish", "Swiss", "Syrian", "Taiwanese", "Tajik", "Tanzanian", "Thai", "Togolese", "Tongan", "Trinidadian or Tobagonian", "Tunisian", "Turkish", "Tuvaluan", "Ugandan", "Ukrainian", "Uruguayan", "Uzbekistani", "Venezuelan", "Vietnamese", "Welsh", "Yemenite", "Zambian", "Zimbabwean" };
        string[] education = new string[] { "Podstawowe", "Zasadnicze zawodowe", "Średnie", "Wyższe" };
        byte[] levels = new byte[] { 1, 2, 3, 4, 5};
        List<Recruited> listTemp; 
        AddFilePanel new_recruitment_documents_Pane;
        string loginAsistant;
        Recruited recruited;

        public AsistantPanel()
        {

        }
        public AsistantPanel(string login)
        {
            InitializeComponent();
            buttonAdd.Enabled = false;
            buttonInclude.Enabled = false;
            comboBoxSkills.Enabled = false;
            comboBoxLavel.Enabled = false;
            loginAsistant = login;
        }

        private void enabledRest(object sender, EventArgs e)
        {
            buttonAddPerson.Enabled = false;
            buttonFindPerson.Enabled = false;
            buttonAddExp.Enabled = true;
            comboBoxPosition.Enabled = true;
            textBoxExp.Enabled = true;
            comboBoxSkills.Enabled = true;
            comboBoxLavel.Enabled = true;
            buttonAddStory.Enabled = true;
            buttonInclude.Enabled = true;
            buttonAdd.Enabled = true;
            textBoxStoryCompany.Enabled = true;
            textBoxStoryState.Enabled = true;
            dateStartJob.Enabled = true;
            dateEndJob.Enabled = true; 
            skillChoose(sender, e);
            positionChoose(sender, e);
            levelChoose(sender, e);
        }
        private void addPersonClick(object sender, EventArgs e)
        {
            using (var db = new ModelContainer())
            {
                if (chceckBoxes())
                {
                    recruited = new Recruited();
                    recruited.Name = textBoxName.Text;
                    recruited.Surname = textBoxSurname.Text;
                    recruited.PhoneNumber = textBoxPhone.Text;
                    recruited.DateOfBirth = dateTimePicker1.Value;
                    recruited.Email = textBoxMail.Text;
                    recruited.Nationality = comboBoxNationality.Text;
                    recruited.Education = comboBoxEducation.Text;
                    db.RecruitedSet.Add(recruited);
                    db.SaveChanges();

                    enabledRest(sender, e);
                }
            }
        }
        private void findClick(object sender, EventArgs e)
        {
            if (textBoxName.Text == String.Empty || textBoxSurname.Text == String.Empty)
            {
                MessageBox.Show("Formaularz posiada puste pola, należy podać imię i nazwisko", "Error-TextBoxes", MessageBoxButtons.OK, MessageBoxIcon.Error);               
            }
            else
            {
                using (var db = new ModelContainer())
                {
                    var recruiters = db.RecruitedSet.ToList();
                    listTemp = new List<Recruited>();
                    listBox.ResetText();
                    foreach (var recruiter in recruiters)
                    {
                        if (recruiter.Name.Equals(textBoxName.Text) && recruiter.Surname.Equals(textBoxSurname.Text))
                        {
                            listTemp.Add(recruiter);
                            listBox.Items.Add(recruiter.Name + " " + recruiter.Surname + " " + recruiter.DateOfBirth + " " + recruiter.PhoneNumber);
                        }
                    }
                }
            }
        }

        private void selectPerson(object sender, EventArgs e)
        {
            if (listBox.Items.Count > 0)
            {
                recruited = new Recruited();
                recruited = listTemp[listBox.SelectedIndex];
                textBoxName.Clear();
                textBoxSurname.Clear();
                textBoxName.Text = recruited.Name;
                textBoxSurname.Text = recruited.Surname;
                textBoxPhone.Text = recruited.PhoneNumber;
                dateTimePicker1.Value = recruited.DateOfBirth;
                textBoxMail.Text = recruited.Email;
                comboBoxNationality.Text = recruited.Nationality;
                comboBoxEducation.Text = recruited.Education;
                enabledRest(sender, e);
            }            
        }

        private void addExpClick(object sender, EventArgs e)
        {
            using (var db = new ModelContainer())
            {
                if (chceckBoxes2())
                {     
                    var application = new Application();
                    application.Recruited = db.RecruitedSet.Where(r => r.Id == recruited.Id).First();
                    application.YearsOfExpirience = Byte.Parse(textBoxExp.Text);                 
                    application.Assistant = db.WorkerSet.Where(w => w.Name == loginAsistant).First();
                    application.Job = db.JobSet.Where(n => n.Name == comboBoxPosition.Text).First();
                    db.ApplicationSet.Add(application);
                    db.SaveChanges();                  
                }
                comboBoxPosition.SelectedIndex = -1;
                textBoxExp.Clear();
            }
        }
        private void clearClick(object sender, EventArgs e)
        {
            comboBoxSkills.SelectedIndex = -1;
            comboBoxLavel.SelectedIndex = -1;
            textBoxName.Clear();
            textBoxSurname.Clear();
            textBoxExp.Clear();
            dateTimePicker1.ResetText();
            textBoxMail.Clear();
            textBoxPhone.Clear();
            comboBoxPosition.SelectedIndex = -1;
            comboBoxNationality.SelectedIndex = -1;
            comboBoxEducation.SelectedIndex = -1;
            dateStartJob.ResetText();
            dateEndJob.ResetText();
            textBoxStoryState.Clear();
            textBoxStoryCompany.Clear();
            buttonAddPerson.Enabled = true;
            buttonFindPerson.Enabled = true;
            buttonAddExp.Enabled = false;
            comboBoxPosition.Enabled = false;
            textBoxExp.Enabled = false;
            comboBoxSkills.Enabled = false;
            comboBoxLavel.Enabled = false;
            buttonAddStory.Enabled = false;
            buttonInclude.Enabled = false;
            textBoxStoryCompany.Enabled = false;
            textBoxStoryState.Enabled = false;
            dateStartJob.Enabled = false;
            dateEndJob.Enabled = false;
            buttonAdd.Enabled = false;
        }

        private void addStoryClick(object sender, EventArgs e)
        {
            using (var db = new ModelContainer())
            {
                if (textBoxStoryState.Text == String.Empty || textBoxStoryCompany.Text == String.Empty || dateStartJob.Value > dateEndJob.Value)
                {
                    MessageBox.Show("Formaularz posiada puste pola lub format daty jest zły", "Error- combo / text Boxes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var profExperience = new ProfessionalExperience();
                    profExperience.Job = textBoxStoryState.Text;
                    profExperience.Company = textBoxStoryCompany.Text;
                    profExperience.From = dateStartJob.Value;
                    profExperience.To = dateEndJob.Value;
                    profExperience.Recruited = db.RecruitedSet.Where(r => r.Id == recruited.Id).First();
                    profExperience.RecruitedId = db.RecruitedSet.Where(r => r.Id == recruited.Id).First().Id;
                    db.ProfessionalExperienceSet.Add(profExperience);
                    db.SaveChanges();
                }
                textBoxStoryState.ResetText();
                textBoxStoryCompany.ResetText();
                dateEndJob.ResetText();
                dateStartJob.ResetText();
            }
        }


        private void documentsAddClick(object sender, EventArgs e)
        {
            new_recruitment_documents_Pane = new AddFilePanel();
            new_recruitment_documents_Pane.Activate();
            new_recruitment_documents_Pane.Show();
        }      

        private void positionChoose(object sender, EventArgs e)
        {
            if (comboBoxPosition.Items.Count == 0)
            {
                using (var db = new ModelContainer())
                {
                    var positions = db.JobSet.ToList();
                    foreach (var position in positions)
                    {
                       comboBoxPosition.Items.Add(position.Name);
                    }
                }
            }
        }

        private void nationalityChoose(object sender, EventArgs e)
        {
            if (comboBoxNationality.Items.Count == 0)
            {
                foreach (string nat in nationality)
                {
                    comboBoxNationality.Items.Add(nat);
                }
            }
        }

        private void educationChoose(object sender, EventArgs e)
        {
            if (comboBoxEducation.Items.Count == 0)
            {
                foreach (string edu in education)
                {
                    comboBoxEducation.Items.Add(edu);
                }
            }
        }

        private void mainFormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void skillsFormClick(object sender, EventArgs e)
        {
            using (var db = new ModelContainer())
            {
                byte levelB;
                if (comboBoxSkills.Text == String.Empty || comboBoxLavel.Text == String.Empty || Byte.TryParse(comboBoxLavel.Text, out levelB) == false)
                {
                    MessageBox.Show("Formaularz posiada puste pola", "Error-comboBoxes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {                    
                    var possess = new Posesses();
                    possess.Level = levelB;
                    possess.Recruited = db.RecruitedSet.Where(r => r.Id == recruited.Id).First();
                    possess.Skills = db.SkillSet.Where(s => s.Name == comboBoxSkills.Text).First();
                    db.PosessesSet.Add(possess);
                    db.SaveChanges(); 
                }
                comboBoxLavel.SelectedIndex = -1; 
                comboBoxSkills.SelectedIndex = -1; 
            }
        }

        private void levelChoose(object sender, EventArgs e)
        {
            if (comboBoxLavel.Items.Count == 0)
            {
                foreach (byte level in levels)
                {
                    comboBoxLavel.Items.Add(level);
                }
            }
        }

        private void skillChoose(object sender, EventArgs e)
        {
            if (comboBoxSkills.Items.Count == 0)
            {
                using (var db = new ModelContainer())
                {
                    var skills = db.SkillSet.ToList();
                    //var requires = db.RequiresSet.ToList();
                    // foreach (var requ in requires)
                    foreach (var skill in skills)
                    {
                        //var job = db.JobSet.Where(n => n.Name == comboBoxPosition.Text).First();
                        //if(requ.Jobs == job) ;
                        comboBoxSkills.Items.Add(skill.Name);
                    }
                }
            }
        }

        private bool chceckBoxes()
        {
            if(textBoxName.Text == String.Empty || textBoxMail.Text == String.Empty || textBoxPhone.Text == String.Empty || 
                textBoxSurname.Text == String.Empty || comboBoxNationality.Text == String.Empty || comboBoxEducation.Text == String.Empty)
            {
                MessageBox.Show("Formaularz posiada puste pola", "Error-TextBoxes",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;         
            }
            else
            {          
                if (textBoxMail.Text.IndexOf("@") == -1)
                {
                    MessageBox.Show("Błędny adres e-mail!!!", "Error-TextBoxes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                    return true;
            }            
        }

        private bool chceckBoxes2()
        {
            if (comboBoxPosition.Text == String.Empty  || textBoxExp.Text == String.Empty)
            {
                MessageBox.Show("Formaularz posiada puste pola", "Error-TextBoxes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                byte temp;
                if (Byte.TryParse(textBoxExp.Text, out temp) == false)
                {
                    MessageBox.Show("Błędna liczba lat doświadczenia!!!", "Error-TextBoxes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                    return true;
            }
        }

    }
}
