using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Widget_Company_Project
{
    class Service : WidgetBase
    {
        public Guid WidgetId { get; set; }
        public int ServiceYears { get; set; }


        public Service() { }

        public Service(Guid widgetid)
        {
            WidgetId = widgetid;
        }
        public void serviceCost(Double widgetPrice)
        {
            Price = widgetPrice * .25;
        }
    }
}
