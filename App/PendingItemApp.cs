using ResManaged3.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResManaged3.App
{
    class PendingItemApp
    {
        public List<OrderPaletteApp> GetOrderPalettes()
        {
            Order order = new Order();
            List<OrderPaletteApp> orderPaletteApps = order.GetOrderPalettes();
            
            orderPaletteApps.Reverse();


            return orderPaletteApps;
        }
    }
}
