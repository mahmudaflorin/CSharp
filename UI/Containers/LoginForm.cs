using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResManaged3.UI.Containers
{
    public partial class LoginForm : Form
    {
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
    }
}
