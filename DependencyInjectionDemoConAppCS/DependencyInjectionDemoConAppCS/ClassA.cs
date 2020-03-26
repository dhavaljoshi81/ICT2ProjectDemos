using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionDemoConAppCS
{
    public class ClassA : ITypeADesign
    {
        
        public void GetDataWithUpdate(int x)
        {
            int result = x * 20;
            Console.WriteLine($"Your updated value is {result}");
        }
    }
}
