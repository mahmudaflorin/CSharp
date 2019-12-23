using ResManaged3.UI.Elements;
using System.Collections.Generic;
using System.Windows.Forms;
namespace ResManaged3.App
{

    public class ItemApp
    {
        public string ItemID { get; set; }
        public string ImageFilePath { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double PriceTag { get; set; }

    }

    public class MenuAllItemsApp
    {

        List<ItemApp> itemAppList;

        public List<ItemApp> GetItems()
        {
            if (itemAppList==null)
            {
                itemAppList = new List<ItemApp>();

                for (int i = 0; i < 10; i++)
                {
                    ItemApp itemApp = new ItemApp();
                    itemApp.ItemID = "p" + i;
                    itemApp.Title = "Random Title " + i;
                    itemApp.Description = "A big random test description for demo purpose " + i;
                    itemApp.PriceTag = i * 20;

                    itemAppList.Add(itemApp);

                } 
            }
            return itemAppList;
        }
        
    }
}
