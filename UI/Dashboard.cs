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
    public partial class Dashboard : Form
    {

        private User user, trouser;
        private AddItem addItem;
        private PendingOrders pendingOrders;
        private ModifyItem removeItem;
        private MenuAllItems menuAllItems;
        private ShowAllItem showAllItem;

        public Dashboard()
        {
            InitializeComponent();

            ShowDropDown(pnlManageOrdersDD);
            //BtnAddItems_Click(btnAddItems, new EventArgs());
            BtnPendingOrders_Click(btnAddItems, new EventArgs());

        }

        public Dashboard(User user) : this()
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

        private void BtnManageEmployees_Click(object sender, EventArgs e)
        {
            ShowDropDown(pnlManageEmployeesDD);
        }

        private void BtnManageMenu_Click(object sender, EventArgs e)
        {
            ShowDropDown(pnlManageMenuDD);
        }

        private void BtnManageOrders_Click(object sender, EventArgs e)
        {
            ShowDropDown(pnlManageOrdersDD);
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
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

        private void BtnAddItems_Click(object sender, EventArgs e)
        {
            if(addItem==null)
            {
                addItem = new AddItem(this);
                Contain(addItem);

            }
            else
            {
                Contain(addItem);
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

        private void BtnPendingOrders_Click(object sender, EventArgs e)
        {
            pendingOrders = new PendingOrders();
            Contain(pendingOrders);
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            if(removeItem==null)
            {
                removeItem = new ModifyItem();
            }
            Contain(removeItem);
        }

        private void BtnAllItem_Click(object sender, EventArgs e)
        {
            showAllItem = new ShowAllItem();
            Contain(showAllItem);
        }

        public void HideDropDown()
        {
            pnlManageEmployeesDD.Visible = false;
            pnlManageMenuDD.Visible = false;
            pnlManageOrdersDD.Visible = false;
        }
    }
}
