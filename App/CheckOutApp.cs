using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ResManaged3.UI.Elements;

namespace ResManaged3.App
{
    class CheckOutApp
    {
        public static void Calculate(/*FlowLayoutPanel flowLayoutPanel*/Panel panel)
        {
            foreach(Item i in MenuAllItemsApp.itemList)
            {
                CartItem cartItem = new CartItem();
                cartItem.Dock = DockStyle.Top;
                //flowLayoutPanel.Controls.Add(cartItem);
                panel.Controls.Add(cartItem);
            }
        }
    }
}
