using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace BD_Projekt.Forms
{
    public partial class StagesAdministrationPanel : Form
    {
        public StagesAdministrationPanel()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            using (var db = new ModelContainer())
            {
                stagesList.Items.Clear();
                foreach (var stage in db.StageSet)
                {
                    stagesList.Items.Add(stage);
                }
            }

            deleteButton.Enabled = (stagesList.SelectedItem != null);
            updateButton.Enabled = (stagesList.SelectedItem != null);
            nameTextBox.Enabled = (stagesList.SelectedItem != null);
            if (stagesList.SelectedItem == null) nameTextBox.Clear();

        }

        private void stagesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var db = new ModelContainer())
            {
                deleteButton.Enabled = (stagesList.SelectedItem != null);
                updateButton.Enabled = (stagesList.SelectedItem != null);
                nameTextBox.Enabled = (stagesList.SelectedItem != null);
                if (stagesList.SelectedItem == null) nameTextBox.Clear();

                if (stagesList.SelectedItem != null)
                {
                    Stage stage = (Stage)stagesList.SelectedItem;
                    nameTextBox.Text = stage.Name;
                } else
                {
                    nameTextBox.Text = "";
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (stagesList.SelectedItem != null)
            {
                using (var db = new ModelContainer())
                {
                    Stage stage = db.StageSet.Find(((Stage)stagesList.SelectedItem).Id);
                    db.StageSet.Remove(stage);
                    db.SaveChanges();
                }
            }
            LoadData();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            String text = Interaction.InputBox("Podaj nazwę etapu", "Nazwa");
            if (text.Length > 0)
               using (var db = new ModelContainer())
               {
                    Stage stage = new Stage();
                    stage.Name = text;
                    db.StageSet.Add(stage);
                    db.SaveChanges();
                }
         
            LoadData();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (stagesList.SelectedItem != null)
            {
                using (var db = new ModelContainer())
                {
                    Stage stage = db.StageSet.Find(((Stage)stagesList.SelectedItem).Id);
                    stage.Name = nameTextBox.Text;
                    db.SaveChanges();
                }
            }
            LoadData();
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            stagesList.SelectedItem = null;
            nameTextBox.Clear();
            LoadData();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
