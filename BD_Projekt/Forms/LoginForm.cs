﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BD_Projekt.Forms
{
    public partial class LoginForm : BD_Projekt.Forms.MainForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }


        private void loginButton_Click(object sender, EventArgs e)
        {
            using (var db = new DataModelContainer())
            {
                var login = loginTextBox.Text;
                try
                {
                    var worker = db.WorkerSet.Where(w => w.Login == login).Single();

                    if (worker != null)
                    {
                        if (SecurePasswordHasher
                            .Verify(passwordTextBox.Text, worker.PasswordHash))
                        {
                            Form form = null;
                            if (worker.Roles.Id == Role.Administrator)
                            {
                                form = new AdminPanel();
                            }  else if (worker.Roles.Id == Role.Asistant)
                            {
                                form = new AssistantPanel(worker);
                            }
                            else if (worker.Roles.Id == Role.Recruiter)
                            {
                                form = new RecruiterForm(worker);
                            }
                            else if (worker.Roles.Id == Role.Supervisor)
                            {
                               form = new SupervisorForm(worker);
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
