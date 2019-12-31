using ResManaged3.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResManaged3.App
{
    class OrderApp
    {
        public List<OrderPaletteApp> GetPendingOrderPalettes()
        {
            Order order = new Order();
            List<OrderPaletteApp> orderPaletteApps = order.GetOrderPalettes(0);
            
            orderPaletteApps.Reverse();


            return orderPaletteApps;
        }
        public List<OrderPaletteApp> GetTakenOrderPalettes()
        {
            Order order = new Order();
            List<OrderPaletteApp> orderPaletteApps = order.GetOrderPalettes(1);

            orderPaletteApps.Reverse();


            return orderPaletteApps;
        }
    }
}
