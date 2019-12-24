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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopLevel = false;
            this.Dock = DockStyle.Fill;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            if (this.Parent.Parent is Landing)
            {
                Console.WriteLine("ok");
                Landing landing = this.Parent.Parent as Landing;
                landing.Contain(landing.GetLoginForm());
            }
        }
    }
}
