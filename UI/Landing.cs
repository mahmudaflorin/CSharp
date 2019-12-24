﻿using ResManaged3.UI.Containers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResManaged3.UI
{
    public partial class Landing : Form
    {
        static LoginForm loginForm;
        static RegistrationForm registrationForm;

        public Landing()
        {
            InitializeComponent();
            if (loginForm == null)
            {
                loginForm = new LoginForm();
                pnlLand.Controls.Add(loginForm);
                pnlLand.Tag = loginForm;
                loginForm.Show();
            }
            registrationForm = new RegistrationForm();
        }

        public LoginForm GetLoginForm()
        {
            return loginForm;
        }
        public RegistrationForm GetRegForm()
        {
            return registrationForm;
        }

        public void Contain(Control control)
        {
            if (!pnlLand.Controls.Contains(control))
            {
                pnlLand.Controls.Clear();
                pnlLand.Controls.Add(control);
                pnlLand.Tag = control;
                control.Show();
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            
        }



        private void BtnSignUp_Click(object sender, EventArgs e)
        {

        }
    }
}
