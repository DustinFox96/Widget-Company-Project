using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Widget_Company_Project
{
    class WidgetOrders
    {
        public string CompanyName { get; set; }
        public Dictionary<Widget, int> CollectionOfWidgetOrders { get; set; }
        public Dictionary<Service, int> ListOfServiceOrders { get; set; }


        public double Total()
        { double totalWidgetOrders = 0;
            foreach( var order in CollectionOfWidgetOrders)
            {
                totalWidgetOrders += order.Value * order.Key.Price;
            }
            double totalServiceOrders = 0;
            foreach( var s in ListOfServiceOrders)
            {
                totalServiceOrders += s.Key.Price * s.Key.ServiceYears * s.Value;
            }
            return totalWidgetOrders + totalServiceOrders;
        }
    }
}
