using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BD_Projekt
{
    public partial class NewUserPanel : Form
    {
        public NewUserPanel()
        {
            InitializeComponent();
        }

        private void CreateNewUserClick(object sender, EventArgs e)
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
    }
}
