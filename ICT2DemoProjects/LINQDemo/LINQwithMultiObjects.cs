using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LINQDemosCS
{
    class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int Rate { get; set; }
        public int Quantity { get; set; }
    }

    class SalesOrder
    {
        public Customer customer;
        public List<Product> products;
    }

    class LINQwithMultiObjects
    {
        static void Main1(string[] args)
        {
            #region Customer Entry

            List<Customer> CustomersList = new List<Customer>();
            CustomersList.Add(new Customer { CustomerID = 1, CustomerName = "Ramesh", Age = 30, City = "Surat", State = "Gujarat", MaxBuyingCapacity = 50000 });
            CustomersList.Add(new Customer { CustomerID = 2, CustomerName = "Yatin", Age = 45, City = "Ujjain", State = "Madhya Pradesh", MaxBuyingCapacity = 75000 });
            CustomersList.Add(new Customer { CustomerID = 3, CustomerName = "Somya", Age = 32, City = "Ahmedabad", State = "Gujarat", MaxBuyingCapacity = 105000 });
            CustomersList.Add(new Customer { CustomerID = 4, CustomerName = "Shruti", Age = 41, City = "Mumbai", State = "Maharashtra", MaxBuyingCapacity = 43000 });
            CustomersList.Add(new Customer { CustomerID = 5, CustomerName = "Pural", Age = 55, City = "Jaipur", State = "Rajasthan", MaxBuyingCapacity = 86000 });

            #endregion

            #region Product Entry

            List<Product> ProductList = new List<Product>();
            ProductList.Add(new Product { ProductID = 101, ProductName = "Computer", Rate = 40000, Quantity = 10 });
            ProductList.Add(new Product { ProductID = 102, ProductName = "Table", Rate = 12000, Quantity = 56 });
            ProductList.Add(new Product { ProductID = 103, ProductName = "Chair", Rate = 5000, Quantity = 100 });
            ProductList.Add(new Product { ProductID = 104, ProductName = "Fan", Rate = 2500, Quantity = 60 });
            ProductList.Add(new Product { ProductID = 105, ProductName = "AC", Rate = 48000, Quantity = 5 });

            #endregion

            #region SalesOrder

            List<SalesOrder> salesOrders = new List<SalesOrder>();
            salesOrders.Add(
                new SalesOrder
                {
                    customer = CustomersList
                        .Single<Customer>(c => c.CustomerID == 1),
                    products = new List<Product>(ProductList
                                    .Where(p => p.ProductID == 101
                                    || p.ProductID == 103))
                }
            );

            salesOrders.Add(
                new SalesOrder
                {
                    customer = CustomersList.
                    Single<Customer>(c => c.CustomerID == 2),
                    products = new List<Product>(ProductList
                    .Where(p => p.ProductID == 101 || p.ProductID == 105))
                }
            );

            salesOrders.Add(
                new SalesOrder
                {
                    customer = CustomersList.
                    Single<Customer>(c => c.CustomerID == 3),
                    products = new List<Product>(ProductList.Where(p => p.ProductID == 102 || p.ProductID == 103))
                }
            );


            salesOrders.Add(
                new SalesOrder
                {
                    customer = CustomersList.Single<Customer>(c => c.CustomerID == 4),
                    products = new List<Product>(ProductList.Where(p => p.ProductID == 102 || p.ProductID == 103 || p.ProductID == 104))
                }
            );

            #endregion

            #region Queries

            var SalesReport = from so in salesOrders
                              where so.products.Contains(
                                    (from p in ProductList
                                     where p.ProductID == 101
                                     select p)
                                     .First()
                                  )
                              select so;
            //*/

            /*var SalesReport = salesOrders
                .Where(SO => SO.products
                        .Any(p => p.ProductID == 101
                            )
                        );

            //*/
            /*var SalesReport = from so in salesOrders
                              where so.products
                                .Any<Product>(p => p.ProductID == 101 
                                            || p.ProductID == 103)
                              select so;                             
            //*/

            //var SalesReport = salesOrders.Where(SO => SO.products.Any(p => p.ProductID == 101 || p.ProductID == 103));

            #endregion

            foreach (SalesOrder so in SalesReport)
            {
                Console.WriteLine(so.customer.CustomerName);
                foreach(Product p in so.products)
                {
                    Console.Write(" - > " + p.ProductName);
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
