using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ResManaged3.UI.Elements;

namespace ResManaged3.UI.Containers
{
    public partial class AddItem : Form
    {
        Dashboard dashboard;
        public AddItem()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopLevel = false;
            this.Dock = DockStyle.Fill;

            //Item item = new Item();
            //item.Location(482, 115);
            //item.Location = new Point(482, 115);
            //item.Enabled = false;
            //this.Controls.Add(item);

        }

        public AddItem(Dashboard dashboard):this()
        {
            this.dashboard = dashboard;
        }

        private void Panel1_MouseEnter(object sender, EventArgs e)
        {
            pnlRight.BackColor = Color.FromArgb(249, 170, 51);
            pnlBottom.BackColor = Color.FromArgb(249, 170, 51);
            pnlLeft.BackColor = Color.FromArgb(249, 170, 51);
            pnlTop.BackColor = Color.FromArgb(249, 170, 51);
        }

        private void Panel1_MouseLeave(object sender, EventArgs e)
        {
            pnlRight.BackColor = Color.FromArgb(241, 241, 241);
            pnlBottom.BackColor = Color.FromArgb(241, 241, 241);
            pnlLeft.BackColor = Color.FromArgb(241, 241, 241);
            pnlTop.BackColor = Color.FromArgb(241, 241, 241);
        }

        private void TbTitle_TextChanged(object sender, EventArgs e)
        {
            lblTitle.Text = tbTitle.Text;
        }

        private void TbDescription_TextChanged(object sender, EventArgs e)
        {
            lblDescription.Text = tbDescription.Text;
        }

        private void TbPriceTag_TextChanged(object sender, EventArgs e)
        {
            lblPriceTag.Text = tbPriceTag.Text;
        }
    }
}
