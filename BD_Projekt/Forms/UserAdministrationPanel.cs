using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BD_Projekt.Forms
{
    public partial class UserAdministrationPanel : Form
    {
        public UserAdministrationPanel()
        {
            InitializeComponent();
            refreshUserList();
        }

        private void refreshUserList()
        {
            usersListView.Items.Clear();
            using (var db = new ModelContainer())
            {
                var users = db.WorkerSet.ToList();
                foreach (var user in users)
                {
                    var listItem = new ListViewItem(new string[] { user.Id.ToString(), user.Name, user.Roles.Name });
                    usersListView.Items.Add(listItem);
                }
            }
        }

        private void formLoad(object sender, EventArgs e)
        {
            using (var db = new ModelContainer())
            {
                var roles = db.RoleSet.ToList();
                foreach(var role in roles){
                    roleChooser.Items.Add(role.Name);
                }
            }
        }

        private void closeButtonClick(object sender, EventArgs e)
        {
            Close();
        }

        private void createNewUserButtonClick(object sender, EventArgs e)
        {
            using (var db = new ModelContainer())
            {
                var login = loginTextBox.Text;
                var passwordHash = SecurePasswordHasher.Hash(passwordTextBox.Text);
                if (passwordHash != SecurePasswordHasher.Hash(repeatPasswordTextBox.Text))
                {

                }
                var worker = new Worker();
                worker.Name = login;
                worker.PasswordHash = passwordHash;
                worker.Roles = db.RoleSet.Where(role => role.Name == roleChooser.Text).First();
                db.WorkerSet.Add(worker);
                db.SaveChanges();
            }
            loginTextBox.Text = "";
            passwordTextBox.Text = "";
            repeatPasswordTextBox.Text = "";
            refreshUserList();
        }

        private void removeUserButtonClick(object sender, EventArgs e)
        {
            using (var db = new ModelContainer())
            {
                foreach(ListViewItem listItem in usersListView.SelectedItems)
                {
                    int id = int.Parse(listItem.SubItems[0].Text);
                    string name = listItem.SubItems[1].Text;
                    db.WorkerSet.Remove(db.WorkerSet.Where(w => w.Id == id && w.Name == name).First());
                    try
                    {
                        db.SaveChanges();

                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message);
                    }
                }
            }
            refreshUserList();
        }

        private void refreshLabelClick(object sender, LinkLabelLinkClickedEventArgs e)
        {
            refreshUserList();
        }
    }
}
