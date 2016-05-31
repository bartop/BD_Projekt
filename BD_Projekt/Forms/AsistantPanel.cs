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
    public partial class AsistantPanel : Form
    {
        string[] nationality = new string[] { "Afghan", "Albanian", "Algerian", "American", "Andorran", "Angolan", "Antiguans", "Argentinean", "Armenian", "Australian", "Austrian", "Azerbaijani", "Bahamian", "Bahraini", "Bangladeshi", "Barbadian", "Barbudans", "Batswana", "Belarusian", "Belgian", "Belizean", "Beninese", "Bhutanese", "Bolivian", "Bosnian", "Brazilian", "British", "Bruneian", "Bulgarian", "Burkinabe", "Burmese", "Burundian", "Cambodian", "Cameroonian", "Canadian", "Cape Verdean", "Central African", "Chadian", "Chilean", "Chinese", "Colombian", "Comoran", "Congolese", "Costa Rican", "Croatian", "Cuban", "Cypriot", "Czech", "Danish", "Djibouti", "Dominican", "Dutch", "East Timorese", "Ecuadorean", "Egyptian", "Emirian", "Equatorial Guinean", "Eritrean", "Estonian", "Ethiopian", "Fijian", "Filipino", "Finnish", "French", "Gabonese", "Gambian", "Georgian", "German", "Ghanaian", "Greek", "Grenadian", "Guatemalan", "Guinea-Bissauan", "Guinean", "Guyanese", "Haitian", "Herzegovinian", "Honduran", "Hungarian", "Icelander", "Indian", "Indonesian", "Iranian", "Iraqi", "Irish", "Israeli", "Italian", "Ivorian", "Jamaican", "Japanese", "Jordanian", "Kazakhstani", "Kenyan", "Kittian and Nevisian", "Kuwaiti", "Kyrgyz", "Laotian", "Latvian", "Lebanese", "Liberian", "Libyan", "Liechtensteiner", "Lithuanian", "Luxembourger", "Macedonian", "Malagasy", "Malawian", "Malaysian", "Maldivan", "Malian", "Maltese", "Marshallese", "Mauritanian", "Mauritian", "Mexican", "Micronesian", "Moldovan", "Monacan", "Mongolian", "Moroccan", "Mosotho", "Motswana", "Mozambican", "Namibian", "Nauruan", "Nepalese", "Netherlander", "New Zealander", "Ni-Vanuatu", "Nicaraguan", "Nigerian", "Nigerien", "North Korean", "Northern Irish", "Norwegian", "Omani", "Pakistani", "Palauan", "Panamanian", "Papua New Guinean", "Paraguayan", "Peruvian", "Polish", "Portuguese", "Qatari", "Romanian", "Russian", "Rwandan", "Saint Lucian", "Salvadoran", "Samoan", "San Marinese", "Sao Tomean", "Saudi", "Scottish", "Senegalese", "Serbian", "Seychellois", "Sierra Leonean", "Singaporean", "Slovakian", "Slovenian", "Solomon Islander", "Somali", "South African", "South Korean", "Spanish", "Sri Lankan", "Sudanese", "Surinamer", "Swazi", "Swedish", "Swiss", "Syrian", "Taiwanese", "Tajik", "Tanzanian", "Thai", "Togolese", "Tongan", "Trinidadian or Tobagonian", "Tunisian", "Turkish", "Tuvaluan", "Ugandan", "Ukrainian", "Uruguayan", "Uzbekistani", "Venezuelan", "Vietnamese", "Welsh", "Yemenite", "Zambian", "Zimbabwean" };
        string[] education = new string[] { "Podstawowe", "Zasadnicze zawodowe", "Średnie", "Wyższe" };
        byte[] levels = new byte[] { 1, 2, 3, 4, 5};
        public AddFilePanel new_recruitment_documents_Pane;
         

        public AsistantPanel()
        {
            InitializeComponent();
            button3.Enabled = false;
            button4.Enabled = false;
            comboBox4.Enabled = false;
            comboBox5.Enabled = false;
        }           
      
        private void confirmClick(object sender, EventArgs e)
        {
            using (var db = new ModelContainer())
            {
                if (chceckBoxes())
                {
                    var recruited = new Recruited();
                    recruited.Name = textBox1.Text;
                    recruited.Surname = textBox3.Text;
                    recruited.PhoneNumber = textBox14.Text;
                    recruited.Name = textBox1.Text;
                    recruited.DateOfBirth = dateTimePicker1.Value;
                    recruited.Email = textBox13.Text;
                    recruited.Nationality = comboBox2.Text;
                    recruited.Education = comboBox3.Text;
                    db.RecruitedSet.Add(recruited);
                    db.SaveChanges();

                    var application = new Application();
                    application.Recruited = recruited;
                    application.YearsOfExpirience = Byte.Parse(textBox9.Text);
                    application.Assistant = db.WorkerSet.Where(n => n.Name.Equals("a")).First(); /// do poprawy !!!!!!!!!
                    application.Job = db.JobSet.Where(n => n.Name.Equals(comboBox1.Text)).First();
                    db.ApplicationSet.Add(application);
                    db.SaveChanges();
                    button5.Enabled = false;
                    button3.Enabled = true;
                    comboBox4.Enabled = true;
                    comboBox5.Enabled = true;
                    button4.Enabled = true;
                }
            }
        }
        private void clearClick(object sender, EventArgs e)
        {
            comboBox4.ResetText();
            comboBox5.ResetText();
            textBox1.Clear();
            textBox3.Clear();
            textBox9.Clear();
            dateTimePicker1.ResetText();
            textBox13.Clear();
            textBox14.Clear();
            comboBox1.ResetText();
            comboBox2.ResetText();
            comboBox3.ResetText();       
            button5.Enabled = true;
            button3.Enabled = false;
            button4.Enabled = false;
            comboBox4.Enabled = false;
            comboBox5.Enabled = false;
        }

        private void documentsAddClick(object sender, EventArgs e)
        {
            new_recruitment_documents_Pane = new AddFilePanel();
            new_recruitment_documents_Pane.Activate();
            new_recruitment_documents_Pane.Show();
        }      

        private void positionChoose(object sender, EventArgs e)
        {
            if (comboBox1.Items.Count == 0)
            {
                using (var db = new ModelContainer())
                {
                    var positions = db.JobSet.ToList();
                    foreach (var position in positions)
                    {
                        comboBox1.Items.Add(position.Name);
                    }
                }
            }
        }

        private void nationalityChoose(object sender, EventArgs e)
        {
            if (comboBox2.Items.Count == 0)
            {
                foreach (string nat in nationality)
                {
                    comboBox2.Items.Add(nat);
                }
            }
        }

        private void educationChoose(object sender, EventArgs e)
        {
            if (comboBox3.Items.Count == 0)
            {
                foreach (string edu in education)
                {
                    comboBox3.Items.Add(edu);
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
                if (comboBox4.Text == String.Empty || comboBox5.Text == String.Empty || Byte.TryParse(comboBox5.Text, out levelB) == false)
                {
                    MessageBox.Show("Formaularz posiada puste pola", "Error-comboBoxes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {                    
                    var possess = new Posesses();
                    possess.Level = levelB;
                    possess.Recruited = db.RecruitedSet.ToList().Last();
                    possess.Skills = db.SkillSet.Where(s => s.Name.Equals(comboBox4.Text)).First();
                    db.PosessesSet.Add(possess);
                    db.SaveChanges(); 
                }
            }
        }

        private void levelChoose(object sender, EventArgs e)
        {
            if (comboBox5.Items.Count == 0)
            {
                foreach (byte level in levels)
                {
                    comboBox5.Items.Add(level);
                }
            }
        }

        private void skillChoose(object sender, EventArgs e)
        {
            if (comboBox4.Items.Count == 0)
            {
                using (var db = new ModelContainer())
                {
                    var skills = db.SkillSet.ToList();
                    foreach (var skill in skills)
                    {
                        comboBox4.Items.Add(skill.Name);
                    }
                }
            }
        }

        private bool chceckBoxes()
        {
            if(textBox1.Text == String.Empty || textBox13.Text == String.Empty || textBox14.Text == String.Empty || 
                textBox3.Text == String.Empty || textBox9.Text == String.Empty || comboBox1.Text == String.Empty || 
                comboBox2.Text == String.Empty || comboBox3.Text == String.Empty)
            {
                MessageBox.Show("Formaularz posiada puste pola", "Error-TextBoxes",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;         
            }
            else
            {
                byte temp;
                if (textBox13.Text.IndexOf("@") == -1 || Byte.TryParse(textBox9.Text, out temp) == false)
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
