using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionDemoConAppCS
{
    class Student<TY> : IClassDesign<TY>
    {
        public int id { get; set; }
        public string Name { get; set; }

        public string Display()
        {
            return "Id : " + id.ToString() + " and Name : " + Name;
        }

        public string Display(int valueX)
        {
            return "Id : " + id.ToString() + " and Name : " + Name + " => X value : " + valueX;
        }

        public string Display(TY valueX)
        {
            return "Id : " + id.ToString() + " and Name : " + Name 
                + " => TY value : " + valueX;
        }
    }
}
