using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD_Projekt.Forms
{
    public partial class AddFilePanel : Form
    {
        private Recruited recruited;

        public AddFilePanel(Recruited recruitedArg, bool allowEdit = true)
        {
            InitializeComponent();
            recruited = recruitedArg;
            recuitedTextBox.Text = recruited.Name + " " + recruited.Surname;
            refreshDocumentsList();

            if (!allowEdit)
            {
                addFileButton.Visible = false;
                removeFileButton.Visible = false;
            }
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
                var buffer = File.ReadAllBytes(path);
                var doc = new Document();
                doc.File = buffer;
                doc.Name = Path.GetFileNameWithoutExtension(path);
                doc.Extension = Path.GetExtension(path);
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

        private void openFileButtonClicked(object sender, EventArgs e)
        {
            foreach (ListViewItem item in documentsListView.SelectedItems)
            {
                int id = int.Parse(item.SubItems[0].Text);
                using (var db = new DataModelContainer())
                {
                    var doc = db.DocumentSet.Where(d => d.Id == id).Single();
                    var filePath = Path.GetTempPath() + doc.Name + doc.Extension;
                    File.WriteAllBytes(filePath, doc.File);
                    System.Diagnostics.Process.Start(@filePath);
                }
            }
        }
    }
}
