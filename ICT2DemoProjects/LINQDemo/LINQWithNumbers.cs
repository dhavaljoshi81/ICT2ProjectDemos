using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace LINQDemoConsoleCS
{
    class LINQWithNumbers
    {
        static void Main1(string[] args)
        {
            int[] values = { 22, 44, 23, 64, 12, 12, 36, 76, 99, 83 };

            #region "Operations"
            //var Data = values.Take(4);
            //var Data1 = (from v in values orderby v select v);
            //var Data = Data1.Reverse();
            //var Data = values.Reverse<int>();
            //var Data = values.Skip(3).Reverse<int>();
            //var Data = values.Reverse();

            //foreach (int x in Data)
            //    Console.WriteLine(x.ToString());
            #endregion

            #region "MoreFunctionality"

            //Console.WriteLine("Total values are " + values.Count().ToString());
            //Console.WriteLine("List contatins value 12? " + values.Contains(12).ToString());
            //Console.WriteLine("List contatins value 129? " + values.Any(x => x == 129).ToString());
            //Console.WriteLine("List contatins any value? " + values.Any().ToString());
            //Console.WriteLine("List has any value divisible by 5? " + values.Any(x => x % 5 == 0).ToString());
            //Console.WriteLine("List has any value divisible by 2? " + values.Any(x => x % 2 == 0).ToString());
            //Console.WriteLine("Fist value is " + values.First());
            //Console.WriteLine("Last value is " + values.Last());
            //Console.WriteLine("Value at 5th position is " + values.ElementAt(4));

            #endregion

            #region "Operation On sequences"

            int[] newValues = { 20, 41, 23, 60, 12, 14, 37 };

            //Console.WriteLine("Operation -> Concatination of Two List");
            //var allValues = values.Concat(newValues);
            //foreach (int x in allValues)
            //    Console.WriteLine(x.ToString());

            //Console.WriteLine("Operation -> Union of Two List");
            //var uniqueValues = values.Union(newValues);
            //foreach (int x in uniqueValues)
            //    Console.WriteLine(x.ToString());

            //Console.WriteLine("======");

            //var commonValues = newValues.Intersect(values);
            //foreach (int x in commonValues)
            //    Console.WriteLine(x.ToString());
            #endregion

            #region "Deferred Execution Demo"

            //Console.WriteLine("Deferred Execution Demo");
            //var listValues = new List<int>();
            //listValues.Add(5);
            //listValues.Add(4);

            //var newList = listValues.Select(x => x * 5);

            //listValues.Add(3);
            //listValues.Add(8);

            //foreach (int v in newList)
            //    Console.WriteLine(v.ToString());

            #endregion

            Console.ReadKey();
        }
    }
}
