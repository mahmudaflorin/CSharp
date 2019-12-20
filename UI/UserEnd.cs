using ResManaged3.UI.Containers;
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
    public partial class UserEnd : Form
    {

        private static MenuAllItems menuAllItems;
        private static PersonalInfo personalInfo;
        private static CheckOut checkOut;
        public UserEnd()
        {
            InitializeComponent();
            //Controls.SetChildIndex(btnCheckOut, 0);
            
            ShowDropDown(pnlMenuDD);
            if(menuAllItems==null)
            {
                menuAllItems = new MenuAllItems();
                pnlContainer.Controls.Add(menuAllItems);
                pnlContainer.Tag = menuAllItems;
                menuAllItems.Show();
            }


            //BtnPersonalInfo_Click(btnPersonalInfo, new EventArgs());
            //form3 = new Form3();
            // pnlContainer.Controls.Add(form3);
            //pnlContainer.Tag = form3;
            // form3.Show();

        }

        public void ShowDropDown(Panel pnlDD)
        {
            if (pnlDD.Visible == false)
            {
                HideDropDown();
                pnlDD.Visible = true;
            }
            else
            {
                pnlDD.Visible = false;
            }
        }
        public void HideDropDown()
        {
            pnlMyProDD.Visible = false;
            pnlMenuDD.Visible = false;
            pnlSupportDD.Visible = false;
        }

        private void BtnMyPro_Click(object sender, EventArgs e)
        {
            ShowDropDown(pnlMyProDD);
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            ShowDropDown(pnlMenuDD);
        }

        private void BtnSupport_Click(object sender, EventArgs e)
        {
            ShowDropDown(pnlSupportDD);
        }

        private void BtnPersonalInfo_Click(object sender, EventArgs e)
        {
            if(personalInfo == null)
            {
                personalInfo = new PersonalInfo();
                Contain(personalInfo);
            }
            else
            {
                Contain(personalInfo);
            }
        }

        private void BtnAllItems_Click(object sender, EventArgs e)
        {
            if(menuAllItems!=null)
            {
                Contain(menuAllItems);
            }
            //this.Controls.SetChildIndex(btnCheckOut, 0);
        }

        private void Contain(Control control)
        {
            if (!pnlContainer.Controls.Contains(control))
            {
                pnlContainer.Controls.Clear();
                pnlContainer.Controls.Add(control);
                pnlContainer.Tag = control;
                control.Show();
            }
        }

        private void BtnCheckOut_Click(object sender, EventArgs e)
        {
            checkOut = new CheckOut();
            Contain(checkOut);
           
            //Contain(checkOut);

        }
    }
}
