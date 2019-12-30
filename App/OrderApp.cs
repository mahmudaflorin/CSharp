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
        public List<OrderPaletteApp> GetOrderPalettes(int status)
        {
            Order order = new Order();
            List<OrderPaletteApp> orderPaletteApps = order.GetOrderPalettes(status);
            
            orderPaletteApps.Reverse();


            return orderPaletteApps;
        }
    }
}
