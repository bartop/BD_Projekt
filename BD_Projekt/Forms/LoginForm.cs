using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;


namespace BD_Projekt
{
    public partial class LoginForm : BD_Projekt.Forms.MainForm
    {
        private Dictionary<string, Form> roleMapper;

        public LoginForm()
        {
            InitializeComponent();
            initializeMapper();
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
    }
}
