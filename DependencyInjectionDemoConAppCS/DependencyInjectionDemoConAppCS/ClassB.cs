using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionDemoConAppCS
{
    class ClassB : ITypeBDesign
    {
        private ITypeADesign myClassA;
        public ClassB(ITypeADesign objDesignA)
        {
            myClassA = objDesignA;
        }
        public void TestDataValue(int y)
        {
            int result = y + 200;
            Console.WriteLine($"Your updated test value is {result}");
            myClassA.GetDataWithUpdate(y);
        }
    }
}
