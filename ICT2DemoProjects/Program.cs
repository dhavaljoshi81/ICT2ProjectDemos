using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT2DemoProjects
{
    interface IClassDesign
    {
        void Display();
    }
    class Test : IClassDesign
    {
        private int testID;
        public int TestID 
        { 
            get
            {
                return testID;
            }
            set
            {
                testID = value;
            }
        }

        //public override string ToString()
        //{
        //    return "Your TestID = " + testID.ToString();
        //}

        public string TestOutput()
        {
            return "TestID = " + testID.ToString();
        }

        public void Display()
        {
            Console.WriteLine("This is Display Function.");
        }
    }

    class ClassA : Test
    {
        public override string ToString()
        {
            return "Your Class A tostring is called ";
        }
    }

    class Program
    {
        static void Main1(string[] args)
        {
            object o;
            Test t = new Test();
            t.TestID = 11;
            Console.WriteLine(t.TestID.ToString());
            Console.WriteLine("====");
            Console.WriteLine(t.TestOutput());
            Console.WriteLine("====");
            Console.WriteLine(t.ToString());
            t.Display();
            ClassA objCA = new ClassA();
            Console.WriteLine(objCA.ToString());
            o = t;
            Console.WriteLine(o.ToString());
            o = objCA;
            Console.WriteLine(o.ToString());
            Console.ReadKey();
            
            
        }
    }
}
