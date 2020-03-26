using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionDemoConAppCS
{
    class ClassA1 : ITypeADesign
    {
        public void GetDataWithUpdate(int x)
        {
            int result = x * 2 - 10;
            Console.WriteLine($"Your updated A1 value is {result}");
        }
    }
}
