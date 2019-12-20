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
        public static List<CartItemApp> itemApps = new List<CartItemApp>();

        public static void AddItem(string ItemID, string Title, string PriceTag)
        {
            if (NewItem(ItemID))
            {
                CartItemApp itemApp = new CartItemApp() { ItemCode = ItemID, ItemName = Title,Quantity = 1, PriceTag = Convert.ToDouble(PriceTag) }; 
                itemApps.Add(itemApp);
            }
            else
            {
                CartItemApp cartItemApp = itemApps.Find(x => x.ItemCode == ItemID);
                cartItemApp.Quantity = cartItemApp.Quantity + 1;

            }
            
        }

        private static bool NewItem(string ItemID)
        {
            if (itemApps.Exists(x => x.ItemCode == ItemID))
            {
                return false;
            }
            else
                return true;
        }
        public static int TotalItems()
        {
            int c = 0;
            foreach(CartItemApp cartItemApp in itemApps)
            {
                c = c + cartItemApp.Quantity;
            }
            return c;
        }
        //public static void Calculate(Panel panel)
        //{
        //    foreach(CartItemApp i in itemApps)
        //    {
        //        CartItem cartItem = new CartItem();
        //        cartItem.Code = i.ItemCode;
        //        cartItem.ItemName = i.ItemName;
        //        cartItem.Quantity = i.Quantity;
        //        cartItem.PriceEach = i.PriceTag;
        //        cartItem.PriceTotal = i.PriceTag * i.Quantity;
        //        cartItem.Dock = DockStyle.Top;
               
        //        panel.Controls.Add(cartItem);
        //    }
        //}

        public static void RemoveItem(string itemCode)
        {
            itemApps.Remove(itemApps.Find(x => x.ItemCode == itemCode));
        }

        public static double CalculateTotalPrice()
        {
            double totalPrice  = 0;
            foreach (CartItemApp cartItemApp in itemApps)
            {
                totalPrice = totalPrice + (cartItemApp.PriceTag * cartItemApp.Quantity);
            }
            return totalPrice;
        }
    }
}
