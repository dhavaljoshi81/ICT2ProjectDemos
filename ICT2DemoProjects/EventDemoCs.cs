using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT2DemoProjects
{
    class EventDemoCs
    {
        public static void Main1()
        {
            Product p = new Product();
            p.id = 101;
            p.Name = "Laptop";
            p.Qty = 10;
            Console.WriteLine("Product Qty = " + p.Qty.ToString());
            Console.WriteLine("----------");
            p.Purchase = 20;
            Console.WriteLine("Product Qty = " + p.Qty.ToString());
            Console.WriteLine("----------");
            p.Sales = 5;
            Console.WriteLine("Product Qty = " + p.Qty.ToString());
            Console.WriteLine("----------");
            Console.ReadKey();
        }
    }
}
