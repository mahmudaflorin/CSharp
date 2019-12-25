using ResManaged3.App;
using ResManaged3.UI.Elements;

using ResManaged3.UI.Containers;
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

namespace ResManaged3.UI
{
    public partial class UserEnd : Form
    {

        private static MenuAllItems menuAllItems;
        private static PersonalInfo personalInfo;
        private static CheckOut checkOut;
        private static DeliverySettings deliverySettings;

        private User user;
        public UserEnd()
        {
            InitializeComponent();

            
            ShowDropDown(pnlMenuDD);
            BtnAllItems_Click(btnAllItems, new EventArgs());

        }

        public UserEnd(User user) : this()
        {
            this.user = user;
            lblNameOfUser.Text = user.Name;
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
            else if (menuAllItems == null)
            {
                menuAllItems = new MenuAllItems();
                Contain(menuAllItems);
            }
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

            
        }

        private void BtnDeliverySettings_Click(object sender, EventArgs e)
        {
            if (deliverySettings == null)
            {
                deliverySettings = new DeliverySettings();
                Contain(deliverySettings);
            }
            else
            {
                Contain(deliverySettings);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
            base.OnFormClosing(e);
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            StaticClear();
            Thread th = new Thread(ShowLanding);
            //th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Close();
        }

        void ShowLanding()
        {
            Landing landing = new Landing();
            Application.Run(landing);
        }

        void StaticClear()
        {

            CheckOutApp.itemApps.Clear();
            CheckOut.TotalPrice = 0;
            if(CheckOut.lblTotalPrice!=null)
            {
                CheckOut.lblTotalPrice.Text = "0.00";

            }
            if(Item.btnCheckOut!=null)
            {
                Item.btnCheckOut = null;
            }
            btnCheckOut.Text = "( " + CheckOutApp.TotalItems() + " )    Check Out";
            user = null;
            menuAllItems = null;
            personalInfo = null;
            checkOut = null;
            //CheckOut.clearCartDel.Invoke();
            deliverySettings = null;
        }
    }
}
