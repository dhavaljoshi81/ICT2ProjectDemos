using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Data;

namespace LINQDemosCS
{
    class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public int Age { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public int MaxBuyingCapacity { get; set; }

        public override string ToString()
        {
            return "CustomerID=" + CustomerID
                + "\tName=" + CustomerName
                + "\tAge=" + Age
                + "\tState=" + State
                + "\tCity=" + City
                + "\tMaxBuyingCapacity=" + MaxBuyingCapacity;
        }
    }

    class LINQwithObjects
    {
        static void Main1(string[] args)
        {
            #region LINQ on Customers
            List<Customer> CustomersList = new List<Customer>();
            CustomersList.Add(new Customer { CustomerID = 1, CustomerName = "Ramesh", Age = 30, City = "Surat", State = "Gujarat", MaxBuyingCapacity = 50000 });
            CustomersList.Add(new Customer { CustomerID = 2, CustomerName = "Yatin", Age = 45, City = "Ujjain", State = "Madhya Pradesh", MaxBuyingCapacity = 75000 });
            CustomersList.Add(new Customer { CustomerID = 3, CustomerName = "Somya", Age = 32, City = "Ahmedabad", State = "Gujarat", MaxBuyingCapacity = 105000 });
            CustomersList.Add(new Customer { CustomerID = 4, CustomerName = "Shruti", Age = 41, City = "Mumbai", State = "Maharashtra", MaxBuyingCapacity = 43000 });
            CustomersList.Add(new Customer { CustomerID = 5, CustomerName = "Pural", Age = 55, City = "Jaipur", State = "Rajasthan", MaxBuyingCapacity = 86000 });

            #region LINQOperations
            var Customers = from c in CustomersList
                            where c.CustomerName.Contains("a") 
                            && c.MaxBuyingCapacity > 50000
                            //&& c.MaxBuyingCapacity < 100000
                            select c;

            
            #endregion


            Console.WriteLine("{0,11}\t{1,13}\t{2,3}\t{3,12}\t{4,10}\t{5,20}",
                    "Customer ID", "Customer Name", "Age", "State", "City", "Max Buying Capacity");

            foreach (Customer customer in Customers)
            {
                Console.WriteLine(customer.ToString());

                //Console.WriteLine("CustomerID={0,-3}\tName={1,-10}\tAge={2,-3}\tState={3,-12}\tCity={4,-10}\tMaxBuyingCapacity={5,10}",
                //    customer.CustomerID, customer.CustomerName, customer.Age, customer.State, customer.City, customer.MaxBuyingCapacity);

                //Console.WriteLine("{0,11}\t{1,-13}\t{2,3}\t{3,-12}\t{4,-10}\t{5,20}",
                //    customer.CustomerID, customer.CustomerName, customer.Age, customer.State, customer.City, customer.MaxBuyingCapacity);
            }

            #endregion


            Console.ReadKey();
        }

    }
}
