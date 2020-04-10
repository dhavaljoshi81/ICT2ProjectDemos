using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT2DemoProjects
{

    public class Product
    {

        public int id { get; set; }
        public string Name { get; set; }
        public int Qty { get; set; }
        public int Sales 
        { 
            set
            {
                Qty -= value;
            }
        }
        public int Purchase 
        { 
            set
            {
                Qty += value;
            }
        }


    }
}
