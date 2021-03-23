using System;
using System.Collections.Generic;

namespace Widget_Company_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Widget w1A = new Widget()
            {
                Description = "Large Enterprise Widget",
                Unit = "Each",
                Size = "Large",
                Model = "Enterprise"
            };
            w1A.getPrice();


            Widget w2A = new Widget()
            {
                Description = "Small Advanced Widgets",
                Unit = "Each",
                Size = "Small",
                Model = "Advance"
            };
            w2A.getPrice();


            Widget w3A = new Widget()
            {
                Description = "Medium Basic Widgets",
                Unit = "Each",
                Size = "Med",
                Model = "Advance"
            };
            w3A.getPrice();

            Service s1A = new Service()
            {
                WidgetId = w1A.Id,
                ServiceYears = 3
            };
            s1A.serviceCost(w1A.Price);

            Service s2A = new Service()
            {
                WidgetId = w2A.Id,
                ServiceYears = 3
            };
            s2A.serviceCost(w2A.Price);

            Service s3A = new Service()
            {
                WidgetId = w3A.Id,
                ServiceYears = 3
            };
            s3A.serviceCost(w3A.Price);

            WidgetOrders o1 = new WidgetOrders()
            {
                CompanyName = "A",
                CollectionOfWidgetOrders =  new Dictionary<Widget, int>{ { w1A, 1 }, { w2A, 3 }, { w3A, 7 } },
                ListOfServiceOrders = new Dictionary<Service, int> { { s1A, 1 }, { s2A, 3 }, { s3A, 7 } }


            };
                

            Widget w1B = new Widget()
            {
                Description = "Medium EnterPrise Widgets",
                Unit = "Each",
                Size = "Med",
                Model = "Enterprise"

            };
            w1B.getPrice();

            Widget w2B = new Widget()
            {
                Description = "Large Adavanced Widgets",
                Unit = "Each",
                Size = "Large",
                Model = "Advance",

            };
            w2B.getPrice();

            Widget w3B = new Widget()
            {
                Description = "Medium Basic Widgets",
                Unit = "Each",
                Size = "Small",
                Model = "Basic"
            };
            w3B.getPrice();

            Service s1B = new Service()
            {
                WidgetId = w1B.Id,
                ServiceYears = 4
            };
            s1B.serviceCost(w1B.Price);

            Service s2B = new Service()
            {
                WidgetId = w2B.Id,
                ServiceYears = 4
            };
            s2B.serviceCost(w2B.Price);

            Service s3B = new Service()
            {
                WidgetId = w3B.Id,
                ServiceYears = 4
            };
            s3B.serviceCost(w3B.Price);

            WidgetOrders o2 = new WidgetOrders()
            {
                CompanyName = "B",
                CollectionOfWidgetOrders = new Dictionary<Widget, int> { { w1B, 4 }, { w2B, 5 }, { w3B, 2 } },
                ListOfServiceOrders = new Dictionary<Service, int> { { s1B, 4 }, { s2B, 5 }, { s3B, 2 } }
            };
       

        Widget w1C = new Widget()
            {
                Description = "Small Enterprise Widgets",
                Unit = "Each",
                Size = "Small",
                Model = "Enterprise"
            };
            w1C.getPrice();

            Widget w2C = new Widget()
            {
                Description = "Medium Advance Widgets",
                Unit = "Each",
                Size = "Med",
                Model = "Advance"
            };
            w2C.getPrice();

            Widget w3C = new Widget()
            {
                Description = "Large Basic Widget",
                Unit = "Each",
                Size = "Large",
                Model = "Basic"
            };
            w3C.getPrice();

            Service s1C = new Service()
            {
                WidgetId = w1C.Id,
                ServiceYears = 5
            };
            s1C.serviceCost(w1C.Price);

            Service s2C = new Service()
            {
                WidgetId = w2C.Id,
                ServiceYears = 5
            };
            s2C.serviceCost(w2C.Price);

            Service s3C = new Service()
            {
                WidgetId = w3C.Id,
                ServiceYears = 5
            };
            s3C.serviceCost(w3C.Price);

            WidgetOrders o3 = new WidgetOrders()
            {
                CompanyName = "C",
                CollectionOfWidgetOrders = new Dictionary<Widget, int> { { w1C, 7 }, { w2C, 3 }, { w3C, 10 } },
                ListOfServiceOrders = new Dictionary<Service, int> { { s1C, 7 }, { s2C, 3 }, { s3C, 10 } }
            };

            Console.WriteLine($"Company A order");
            Console.WriteLine($"{w1A.Description} {o1.CollectionOfWidgetOrders[w1A]} ");
            Console.WriteLine($"{w2A.Description} {o1.CollectionOfWidgetOrders[w2A]} ");
            Console.WriteLine($"{w3A.Description} {o1.CollectionOfWidgetOrders[w3A]} ");
            Console.WriteLine($"Total is {o1.Total()}");

            Console.WriteLine();

            Console.WriteLine($"Company B order");
            Console.WriteLine($"{w1B.Description} {o2.CollectionOfWidgetOrders[w1B]} ");
            Console.WriteLine($"{w2B.Description} {o2.CollectionOfWidgetOrders[w2B]} ");
            Console.WriteLine($"{w3B.Description} {o2.CollectionOfWidgetOrders[w3B]} ");
            Console.WriteLine($"Total is {o2.Total()}");

            Console.WriteLine();

            Console.WriteLine($"Company C order");
            Console.WriteLine($"{w1C.Description} {o3.CollectionOfWidgetOrders[w1C]} ");
            Console.WriteLine($"{w2C.Description} {o3.CollectionOfWidgetOrders[w2C]} ");
            Console.WriteLine($"{w3C.Description} {o3.CollectionOfWidgetOrders[w3C]} ");
            Console.WriteLine($"Total is {o3.Total()}");










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
           