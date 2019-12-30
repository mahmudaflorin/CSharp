using ResManaged3.App;
using ResManaged3.UI.Elements;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResManaged3.UI.Containers
{
    public partial class PendingOrders : Form
    {
        PendingItemApp pendingItemApp;
        static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Edu\Programs\C#\Practice\ResManaged3\Data\ResM.mdf;Integrated Security=True";

        public PendingOrders()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopLevel = false;
            this.Dock = DockStyle.Fill;


            ShowPendingOrders();
        }

        void ShowPendingOrders()
        {
            if(pendingItemApp==null)
            {
                pendingItemApp = new PendingItemApp();
            }
            //PendingItemApp 
            List<OrderPaletteApp> orderPaletteApps = pendingItemApp.GetOrderPalettes();

            
            foreach(OrderPaletteApp orderPaletteApp in orderPaletteApps)
            {
                OrderPalette2 orderPalette2 = new OrderPalette2();

                orderPalette2.OrderID = orderPaletteApp.OrderID;
                orderPalette2.Bill = orderPaletteApp.Bill;
                orderPalette2.AddPhn = orderPaletteApp.AddPhn;

                List<Label> labels = new List<Label>();

                foreach(string str in orderPaletteApp.itemnames)
                {
                    Label label = new Label();
                    label.AutoSize = true;
                    label.Margin = new Padding(3, 5, 3, 5);
                    label.Padding = new Padding(3, 5, 3, 5);
                    label.BackColor = Color.FromArgb(180, 52, 73, 85);
                    label.ForeColor = Color.White;
                    label.Font = new Font("Open Sans", 9);
                    label.Text = str;
                    labels.Add(label);
                }

                orderPalette2.Items = labels;

                orderPalette2.Dock = DockStyle.Top;

                panel1.Controls.Add(orderPalette2);

            }
        }

    }
}
