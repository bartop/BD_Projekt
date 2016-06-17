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
        public AddFilePanel new_recruitment_documents_Pane;
        string loginAsistant; 

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
      
        private void confirmClick(object sender, EventArgs e)
        {
            using (var db = new ModelContainer())
            {
                if (chceckBoxes())
                {
                    var recruited = new Recruited();
                    recruited.Name = textBoxName.Text;
                    recruited.Surname = textBoxSurname.Text;
                    recruited.PhoneNumber = textBoxPhone.Text;
                    recruited.Name = textBoxName.Text;
                    recruited.DateOfBirth = dateTimePicker1.Value;
                    recruited.Email = textBoxMail.Text;
                    recruited.Nationality = comboBoxNationality.Text;
                    recruited.Education = comboBoxEducation.Text;
                    db.RecruitedSet.Add(recruited);
                    db.SaveChanges();

                    var application = new Application();
                    application.Recruited = recruited;
                    application.YearsOfExpirience = Byte.Parse(textBoxExp.Text);                 
                    application.Assistant = db.WorkerSet.Where(w => w.Name == loginAsistant).First();
                    application.Job = db.JobSet.Where(n => n.Name ==comboBoxPosition.Text).First();
                    db.ApplicationSet.Add(application);
                    db.SaveChanges();
                    buttonConfirm.Enabled = false;
                    buttonAdd.Enabled = true;
                    comboBoxSkills.Enabled = true;
                    comboBoxLavel.Enabled = true;
                    buttonInclude.Enabled = true;
                    skillChoose(sender,e);
                }
            }
        }
        private void clearClick(object sender, EventArgs e)
        {
            comboBoxSkills.ResetText();
            comboBoxLavel.ResetText();
            textBoxName.Clear();
            textBoxSurname.Clear();
            textBoxExp.Clear();
            dateTimePicker1.ResetText();
            textBoxMail.Clear();
            textBoxPhone.Clear();
           comboBoxPosition.ResetText();
            comboBoxNationality.ResetText();
            comboBoxEducation.ResetText();       
            buttonConfirm.Enabled = true;
            buttonAdd.Enabled = false;
            buttonInclude.Enabled = false;
            comboBoxSkills.Enabled = false;
            comboBoxLavel.Enabled = false;
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
                    possess.Recruited = db.RecruitedSet.ToList().Last();
                    possess.Skills = db.SkillSet.Where(s => s.Name == comboBoxSkills.Text).First();
                    db.PosessesSet.Add(possess);
                    db.SaveChanges(); 
                }
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
                    var requires= db.RequiresSet.ToList();
                    foreach (var requ in requires)
                    {
                        var job = db.JobSet.Where(n => n.Name == comboBoxPosition.Text).First();
                        if(requ.Jobs == job) ;
                        comboBoxSkills.Items.Add(requ.Skills.Name);
                    }
                }
            }
        }

        private bool chceckBoxes()
        {
            if(textBoxName.Text == String.Empty || textBoxMail.Text == String.Empty || textBoxPhone.Text == String.Empty || 
                textBoxSurname.Text == String.Empty || textBoxExp.Text == String.Empty ||comboBoxPosition.Text == String.Empty || 
                comboBoxNationality.Text == String.Empty || comboBoxEducation.Text == String.Empty)
            {
                MessageBox.Show("Formaularz posiada puste pola", "Error-TextBoxes",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;         
            }
            else
            {
                byte temp;
                if (textBoxMail.Text.IndexOf("@") == -1 || Byte.TryParse(textBoxExp.Text, out temp) == false)
                {
                    MessageBox.Show("Błędny adres e-mail lub liczba lat doświadczenia!!!", "Error-TextBoxes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                    return true;
            }            
        }

    }
}
