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
        string[] nationality = new string[] { "Afghan", "Albanian", "Algerian", "American", "Andorran", "Angolan", "Antiguans", "Argentinean", "Armenian", "Australian", "Austrian", "Azerbaijani", "Bahamian", "Bahraini", "Bangladeshi", "Barbadian", "Barbudans", "Batswana", "Belarusian", "Belgian", "Belizean", "Beninese", "Bhutanese", "Bolivian", "Bosnian", "Brazilian", "British", "Bruneian", "Bulgarian", "Burkinabe", "Burmese", "Burundian", "Cambodian", "Cameroonian", "Canadian", "Cape Verdean", "Central African", "Chadian", "Chilean", "Chinese", "Colombian", "Comoran", "Congolese", "Costa Rican", "Croatian", "Cuban", "Cypriot", "Czech", "Danish", "Djibouti", "Dominican", "Dutch", "East Timorese", "Ecuadorean", "Egyptian", "Emirian", "Equatorial Guinean", "Eritrean", "Estonian", "Ethiopian", "Fijian", "Filipino", "Finnish", "French", "Gabonese", "Gambian", "Georgian", "German", "Ghanaian", "Greek", "Grenadian", "Guatemalan", "Guinea-Bissauan", "Guinean", "Guyanese", "Haitian", "Herzegovinian", "Honduran", "Hungarian", "Icelander", "Indian", "Indonesian", "Iranian", "Iraqi", "Irish", "Israeli", "Italian", "Ivorian", "Jamaican", "Japanese", "Jordanian", "Kazakhstani", "Kenyan", "Kittian and Nevisian", "Kuwaiti", "Kyrgyz", "Laotian", "Latvian", "Lebanese", "Liberian", "Libyan", "Liechtensteiner", "Lithuanian", "Luxembourger", "Macedonian", "Malagasy", "Malawian", "Malaysian", "Maldivan", "Malian", "Maltese", "Marshallese", "Mauritanian", "Mauritian", "Mexican", "Micronesian", "Moldovan", "Monacan", "Mongolian", "Moroccan", "Mosotho", "Motswana", "Mozambican", "Namibian", "Nauruan", "Nepalese", "Netherlander", "New Zealander", "Ni-Vanuatu", "Nicaraguan", "Nigerian", "Nigerien", "North Korean", "Northern Irish", "Norwegian", "Omani", "Pakistani", "Palauan", "Panamanian", "Papua New Guinean", "Paraguayan", "Peruvian", "Polish", "Portuguese", "Qatari", "Romanian", "Russian", "Rwandan", "Saint Lucian", "Salvadoran", "Samoan", "San Marinese", "Sao Tomean", "Saudi", "Scottish", "Senegalese", "Serbian", "Seychellois", "Sierra Leonean", "Singaporean", "Slovakian", "Slovenian", "Solomon Islander", "Somali", "South African", "South Korean", "Spanish", "Sri Lankan", "Sudanese", "Surinamer", "Swazi", "Swedish", "Swiss", "Syrian", "Taiwanese", "Tajik", "Tanzanian", "Thai", "Togolese", "Tongan", "Trinidadian or Tobagonian", "Tunisian", "Turkish", "Tuvaluan", "Ugandan", "Ukrainian", "Uruguayan", "Uzbekistani", "Venezuelan", "Vietnamese", "Welsh", "Yemenite", "Zambian", "Zimbabwean" };
        string[] education = new string[] { "Podstawowe", "Zasadnicze zawodowe", "Średnie", "Wyższe" };

    public AddFilePanel new_recruitment_documents_Pane;

        public AsistantPanel()
        {
            InitializeComponent();
        }      
     
        private void SkillsFormClick(object sender, EventArgs e)
        {
        }

        private void ConfirmClick(object sender, EventArgs e)
        {
            using (var db = new ModelContainer())
            {
                var recruited = new Recruited();
                recruited.Name = textBox1.Text + " " + textBox3.Text ;
                recruited.PhoneNumber = textBox14.Text;
                recruited.Surname = textBox9.Text;
                recruited.DateOfBirth = new DateTime(1994, 12, 13);//textBox12.Text;
                recruited.Email = textBox13.Text;
                recruited.Nationality = comboBox2.Text;
                recruited.Education = comboBox3.Text;

                //db.RecruitedSet.Add(recruited);
                var application = new Application();
                application.Recruited = recruited;
                db.SaveChanges();

            }
        }
        private void ClearClick(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox3.Clear();
            textBox9.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
            comboBox1.ResetText();
            comboBox2.ResetText();
            comboBox3.ResetText();
        }

        private void DocumentsAddClick(object sender, EventArgs e)
        {
            new_recruitment_documents_Pane = new AddFilePanel();
            new_recruitment_documents_Pane.Activate();
            new_recruitment_documents_Pane.Show();
        }

        private void positionChoose(object sender, EventArgs e)
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

        private void nationalityChoose(object sender, EventArgs e)
        {
            foreach (string nat in nationality)
            {
                comboBox2.Items.Add(nat);
            }
        }

        private void educationChoose(object sender, EventArgs e)
        {
            foreach (string edu in education)
            {
                comboBox3.Items.Add(edu);
            }
        }
    }
}
