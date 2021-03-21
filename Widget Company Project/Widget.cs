using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Widget_Company_Project
{
    class Widget : WidgetBase
    {
        public string Size { get; set; }
        public string Model { get; set; }

        private Dictionary<string, double> priceList = new Dictionary<string, double>()
        {
            {"SmallBasic", 50},
            {"SmallAdvance", 125},
            {"SmallEnterprise", 250},
            {"MedBasic", 100},
            {"MedAdvance", 200},
            {"MedEnterprise", 400},
            {"LargeBasic",250},
            {"LargeAdvance", 275},
            {"LargeEnterprise", 50}
        };
        
        public void getPrice()
        {
            var key = Size + Model;
            Price = priceList[key];
        }


    }
}
