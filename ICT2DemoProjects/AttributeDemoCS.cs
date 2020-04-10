using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT2DemoProjects
{
    [System.AttributeUsage(System.AttributeTargets.Class | System.AttributeTargets.Struct)]
    public class Author : System.Attribute
    {
        private string name;
        public double version;
        public int x;
        public Author(string name)
        {
            this.name = name;
            version = 1.0;
        }
    }

    [Author("Dhaval", version = 2.12)]
    class MyClass
    {

    }

    [Author("", x = 20)]
    struct MyStruct
    {

    }


    class AttributeDemoCS
    {
    }
}
