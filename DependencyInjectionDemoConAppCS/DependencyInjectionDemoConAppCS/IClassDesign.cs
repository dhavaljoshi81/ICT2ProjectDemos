using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionDemoConAppCS
{
    public interface IClassDesign<T>
    {
        string Display(T valueX);
    }
}
