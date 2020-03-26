using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionDemoConAppCS
{
    class Customer<TX> : IClassDesign<TX>
    {
        public int CustID { get; set; }
        public string CustName { get; set; }
        public int Balance { get; set; }

        public string Display()
        {
            return "Customer Name : " + CustName + " and Balance = " + Balance;
        }
        public string Display(int valueX)
        {
            return "Customer Name : " + CustName + " and Balance = " + Balance
                + " => X parameter : " + valueX;
        }

        public string Display(TX valueX)
        {
            return "Customer Name : " + CustName + " and Balance = " + Balance
                + " => TX parameter : " + valueX.ToString();
            
        }
    }
}
