using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;


namespace BD_Projekt
{
    public partial class LoginForm : Form
    {
        private Dictionary<string, Form> roleMapper;

        public LoginForm()
        {
            InitializeComponent();
            initializeMapper();

            using (var db = new ModelContainer())
            {
                var admin = new Role();
                admin.Name = "Administrator";
                var asistant = new Role();
                asistant.Name = "Asistant";
                var recruiter = new Role();
                recruiter.Name = "Recruiter";
                var supervisior = new Role();
                supervisior.Name = "Supervisor";

                db.RoleSet.Add(admin);
                db.RoleSet.Add(asistant);
                db.RoleSet.Add(recruiter);
                db.RoleSet.Add(supervisior);
                db.SaveChanges();
                
                var root = new Worker();
                root.Name = "root";
                root.PasswordHash = SecurePasswordHasher.Hash("root");
                root.Roles = db.RoleSet.Where(r => r.Name == "Administrator").First();
                db.WorkerSet.Add(root);
                db.SaveChanges();
            }
        }

        private void initializeMapper()
        {
            roleMapper = new Dictionary<string, Form>
            {
                { "Administrator",  new AdminPanel() },
                { "Asistant",       new AsistantPanel() },
                { "Recruiter",      new RecruiterPanel() },
                { "Supervisor",       new SupervisorPanel() },
            };
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            using (var db = new ModelContainer())
            {
                var name = loginTextBox.Text;

                try
                {
                    var worker = db.WorkerSet.Where(w => w.Name == name).First();

                    if (worker != null)
                    {
                        if (SecurePasswordHasher.Verify(passwordTextBox.Text, worker.PasswordHash))
                        {
                            //wyswietl odpowiednie okno
                            var form = roleMapper[worker.Roles.Name];
                            form.Show();
                            form.Activate();
                            this.Hide();
                        }
                    }
                } catch (InvalidOperationException)
                {

                }
            }
            
            

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
