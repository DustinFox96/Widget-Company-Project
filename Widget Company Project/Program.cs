using System;

namespace Widget_Company_Project
{
    class Program
    {
        static void Main(string[] args)
        { Widget w1 = new Widget()
        {
            Description = "Large Enterprise Widget",
            Unit = "Each",
            Size = "Large",
            Model = "Enterprise"
        };
            w1.getPrice();

            WidgetOrders o1 = new WidgetOrders()
            {
                CompanyName = "Comp1",
                CollectionOfWidgetOrders = { { w1, 1 }, { w2, 3 }, { w3, 7 } }, 
                ListOfServiceOrders = { {} }
                                    

                 },
                ListOfServiceOrders = {

                };

            }
        }
    }
}

            //Widget w1 = new Widget()
            //{
            //    Description = "Makes waffles",
            //    Unit = "Each",
            //    Size = "Small",
            //    Model = "Basic"
            //};

            //w1.getPrice();
            //Console.WriteLine($"Price for w1 is {w1.Price}");
           