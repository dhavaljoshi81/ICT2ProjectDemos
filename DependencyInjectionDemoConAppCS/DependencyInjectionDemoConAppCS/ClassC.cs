using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionDemoConAppCS
{
    public class ClassC : ITypeB1Design
    {
        private ITypeADesign myClassA;
        public ClassC(ITypeADesign objDesignA)
        {
            myClassA = objDesignA;
        }
        
        public void UpdatedData(int z)
        {
            int result = z + 500;
            Console.WriteLine($"Your new updated value is {result}");
            myClassA.GetDataWithUpdate(z);
        }
    }
}
