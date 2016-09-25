using System;
using System.Data;
using System.Data.Entity.Validation;
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
            using (var db = new DataModelContainer())
            {
                var users = db.WorkerSet.ToList();
                usersListView.SetObjects(users);
            }
        }

        private void formLoad(object sender, EventArgs e)
        {
            using (var db = new DataModelContainer())
            {
                var roles = db.RoleSet.ToList();
                foreach(var role in roles){
                    roleChooser.Items.Add(role.Name);
                }
                roleChooser.SelectedIndex = 0;
            }
        }

        private void closeButtonClick(object sender, EventArgs e)
        {
            Close();
        }

        private void createNewUserButtonClick(object sender, EventArgs eventArgs)
        {
            try {
                using (var db = new DataModelContainer())
                {
                    var login = loginTextBox.Text;
                    var passwordHash = SecurePasswordHasher.Hash(passwordTextBox.Text);
                    if (SecurePasswordHasher.Verify(repeatPasswordTextBox.Text, passwordHash))
                    {
                        var worker = new Worker();
                        worker.Login = login;
                        worker.PasswordHash = passwordHash;
                        worker.Name = nameTextBox.Text;
                        worker.Surname = surnameTextBox.Text;
                        worker.Roles = db.RoleSet.Where(role => role.Name == roleChooser.Text).First();
                        db.WorkerSet.Add(worker);
                        db.SaveChanges();

                        loginTextBox.Clear();
                        nameTextBox.Clear();
                        surnameTextBox.Clear();
                        passwordTextBox.Clear();
                        repeatPasswordTextBox.Clear();
                        refreshUserList();
                    }
                    else
                    {
                        MessageBox.Show("Niepoprawnie powtórzone hasło!", "Błąd");

                    }
                }

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
                MessageBox.Show(ex.Message, "Błąd");
            }
        }

        private void removeUserButtonClick(object sender, EventArgs e)
        {
            using (var db = new DataModelContainer())
            {
                foreach(ListViewItem listItem in usersListView.SelectedItems)
                {
                    int id = int.Parse(listItem.SubItems[0].Text);
                    string name = listItem.SubItems[1].Text;
                    db.WorkerSet.Remove(db.WorkerSet.Where(w => w.Id == id).First());
                    try
                    {
                        db.SaveChanges();

                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message, "Błąd");
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
