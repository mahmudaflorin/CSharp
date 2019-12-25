using ResManaged3.App;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResManaged3.UI.Containers
{
    public partial class LoginForm : Form
    {
        User user;
        public LoginForm()
        { 
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopLevel = false;
            this.Dock = DockStyle.Fill;

        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            if(this.Parent.Parent is Landing)
            {
                Console.WriteLine("ok");
                Landing landing = this.Parent.Parent as Landing;
                landing.Contain(landing.GetRegForm());
            }
        }

        private void TbUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            //AuthApp authApp = new AuthApp(tbUserName.Text.Trim(), tbPassword.Text);
            AuthApp authApp = new AuthApp("nfsiam", "1234");//bypass

            user = authApp.GetProfile();
            if(user==null)
            {
                MessageBox.Show("No login information found for provided username and password", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Thread th = new Thread(ShowUserEnd);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
                if (this.Parent.Parent is Landing)
                {
                    (this.Parent.Parent as Landing).Close();
                }
            }
        }

        void ShowUserEnd()
        {
            if (user.UserType.Equals(0))
            {
                UserEnd userEnd = new UserEnd(user);
                userEnd.BringToFront();
                Application.Run(userEnd);
            }
            else if(user.UserType.Equals(1))
            {
                Dashboard dashboard = new Dashboard(user);
                dashboard.BringToFront();
                Application.Run(dashboard);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            //BtnLogin_Click(btnLogin, new EventArgs());//bypass

        }
    }
}
