using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionDemoConAppCS
{
    public class ClassD : ITypeBDesign
    {
        private ITypeADesign myClassA;
        public ClassD(ITypeADesign objDesignA)
        {
            myClassA = objDesignA;
        }
        public void TestDataValue(int y)
        {
            int result = y * 50;
            Console.WriteLine($"Your updated test value is {result}");
            myClassA.GetDataWithUpdate(y);
        }
    }
}
