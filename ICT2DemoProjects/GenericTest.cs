using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT2DemoProjects
{
    class GenericTest
    {
        static void Main1(string[] args)
        {
            DataManager<int> intDM = new DataManager<int>();
            //intDM.DataValue = 10;
            intDM.ChangeValueToDisplay();
            DataManager<float> floatDM = new DataManager<float>(12.29f);
            floatDM.ChangeValueToDisplay();
            Console.ReadKey();            
        }
    }

    class DataManager<T>
    {
        private T dataValue;
        public T DataValue
        {
            get
            {
                return dataValue;
            }
            set
            {
                dataValue = value;
            }
        }

        public DataManager()
        {
            dataValue = default(T);
        }

        public DataManager(T dValue)
        {
            dataValue = dValue;
        }

        public void ChangeValueToDisplay()
        {
            Console.WriteLine("Your updated data is " + dataValue);
        }

    }
}
