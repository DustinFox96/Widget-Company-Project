using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Widget_Company_Project
{
    class WidgetBase
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Description { get; set; }
        public string Unit { get; set; }
        public double Price { get; set; }

        //public int Getid()
        //{

        //}

        public WidgetBase() { }

       
    }

}
