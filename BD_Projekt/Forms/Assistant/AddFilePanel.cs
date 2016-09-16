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
    public partial class AddFilePanel : Form
    {
        private Recruited recruited;

        public AddFilePanel(Recruited recruitedArg)
        {
            InitializeComponent();
            recruited = recruitedArg;
            recuitedTextBox.Text = recruited.Name + " " + recruited.Surname;
            refreshDocumentsList();
        }

        private void refreshDocumentsList()
        {
            using (var db = new DataModelContainer())
            {
                var documentsList = db.DocumentSet
                    .Where(d => d.Recruited.Id == recruited.Id).ToList();

                documentsListView.Items.Clear();
                foreach (var document in documentsList)
                {
                    string[] item =
                    {
                        document.Id.ToString(),
                        document.Name
                    };
                    documentsListView.Items.Add(new ListViewItem(item));
                }
            }
        }

        private void AddFileButtonClick(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();
            if (result != DialogResult.OK) return;
            var paths = openFileDialog1.FileNames;
            foreach(var path in paths)
            {
                var buffer = System.IO.File.ReadAllBytes(path);
                var doc = new Document();
                doc.File = buffer;
                doc.Name = path;
                using (var db = new DataModelContainer())
                {
                    db.RecruitedSet.Attach(recruited);
                    recruited.Documents.Add(doc);
                    db.SaveChanges();
                }
            }
            refreshDocumentsList();
        }

        private void refreshLabelCliked(object sender, EventArgs e)
        {
            refreshDocumentsList();
        }

        private void removeFileButtonClicked(object sender, EventArgs e)
        {
            foreach(ListViewItem item in documentsListView.SelectedItems)
            {
                int id = int.Parse(item.SubItems[0].Text);
                using(var db = new DataModelContainer())
                {
                    db.DocumentSet.Remove(
                        db.DocumentSet.Where(d => d.Id == id).Single());
                    db.SaveChanges();
                }
            }
            refreshDocumentsList();
        }
    }
}
