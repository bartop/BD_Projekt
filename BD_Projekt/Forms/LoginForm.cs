using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BD_Projekt.Forms
{
    public partial class LoginForm : BD_Projekt.Forms.MainForm
    {
        private Dictionary<string, Type> roleMapper;

        public LoginForm()
        {
            InitializeComponent();
            initializeMapper();
        }

        private void initializeMapper()
        {
            roleMapper = new Dictionary<string, Type>
            {
                { "Administrator",  typeof(AdminPanel) },
                { "Asistant",       typeof(AsistantPanel) },
                { "Recruiter",      typeof(RecruiterPanel) },
                { "Supervisor",      typeof(SupervisorPanel) },
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
                            Form form = null;
                            if (worker.Roles.Name.Equals("Administrator"))
                            {
                                form = new AdminPanel();
                            }  else if (worker.Roles.Name.Equals("Asistant"))
                            {
                                form = new AsistantPanel();
                            }
                            else if (worker.Roles.Name.Equals("Recruiter"))
                            {
                                form = new RecruiterPanel();
                            }
                            else if (worker.Roles.Name.Equals("Supervisor"))
                            {
                                form = new SupervisorPanel(worker);
                            }

                            form.Show();
                            this.Hide();
                        } else
                        {
                            MessageBox.Show("Wpisałeś nieprawidłowe hasło!", "Nieprawidłowe hasło");
                        }
                    }
                } catch (InvalidOperationException)
                {
                    MessageBox.Show("Wpisałeś niepoprawny login!", "Nieprawidłowy login");
                }
            }
        }

        private void passwordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                loginButton.PerformClick();
            }
        }
    }
}
