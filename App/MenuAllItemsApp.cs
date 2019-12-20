using ResManaged3.UI.Elements;
using System.Collections.Generic;
using System.Windows.Forms;
namespace ResManaged3.App
{
    public class MenuAllItemsApp
    {
        public static void Populate(FlowLayoutPanel flowLayoutPanel)
        {
            for (int i = 0; i < 10; i++)
            {
                Item item = new Item();
                item.ItemID = "p" + i;
                item.Title = "Random Title " + i;
                item.Description = "A big random test description for demo purpose " + i;
                item.PriceTag = i + "24";

                flowLayoutPanel.Controls.Add(item);
            }
        }


        public static List<Item> itemList = new List<Item>();

        
    }
}
