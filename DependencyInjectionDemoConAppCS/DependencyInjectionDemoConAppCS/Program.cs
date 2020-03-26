using System;
using Microsoft.Extensions.DependencyInjection;

namespace DependencyInjectionDemoConAppCS
{
    class Program
    {
        static void Main1(string[] args)
        {
            Customer<int> cust = new Customer<int> { CustID = 11, CustName = "XYZ", Balance = 20000 };
            ManageData<int> objMD = new ManageData<int>(cust);
            objMD.ZValue = 200;
            objMD.ShowData();

            Console.WriteLine("=====");
            Student<string> stud = new Student<string> { id = 1, Name = "ABC" };
            ManageData<string> objMDString = new ManageData<string>();
            objMDString.ZValue = "Hello to all";
            objMDString.ServiceClass = stud;
            objMDString.ShowData();

        }

        static void Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();
            
            serviceCollection.AddScoped<ITypeADesign, ClassA1>();
            serviceCollection.AddScoped<ITypeADesign, ClassA>();

            serviceCollection.AddScoped<ITypeBDesign, ClassB>();
            
            var serviceProvider = serviceCollection.BuildServiceProvider();

            ITypeBDesign typeBDesign = serviceProvider.GetService<ITypeBDesign>();
            typeBDesign.TestDataValue(33);

            Console.ReadKey();
        }
    }
}
