using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionDemoConAppCS
{
    class ManageData<TZ>
    {
        private IClassDesign<TZ> classDesign = null;

        private TZ x;

        public TZ ZValue
        {
            set
            {
                x = value;
            }
        }

        public ManageData()
        {

        }

        public ManageData(IClassDesign<TZ> objClassDesign)
        {
            classDesign = objClassDesign;
        }

        public IClassDesign<TZ> ServiceClass 
        { 
            set
            {
                classDesign = value;
            }
        }
        public void ShowData()
        {
            if (classDesign != null)
                Console.WriteLine(classDesign.Display(x));
            else
                Console.WriteLine("No Service Data to process further.");
        }
    }
}
