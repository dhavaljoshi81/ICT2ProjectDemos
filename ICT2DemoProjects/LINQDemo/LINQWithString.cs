using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//This is LINQ Demo program with objects (Sequences) and Elements

namespace LINQDemoConsoleCS
{
    class LINQWithString
    {
        string[] persons = { "Roshan",
            "Mathuradas", "Tarika", 
            "Viren", "Kiran", "Darshan", "Roshani" };

        static void Main1(string[] args)
        {
            LINQWithString objLINQCS = new LINQWithString();

            //objLINQCS.LengthWiseFilterLambda();
            //objLINQCS.LengthWiseFilterQuery();
            //objLINQCS.LetterInFilterLambda('r');
            //objLINQCS.LetterInFilterQuery('r');
            //objLINQCS.ChainQueryFilterLambda();
            //objLINQCS.ChainQueryFilterQuery();
            //objLINQCS.ShowLengthOfAllElements();
            //objLINQCS.ShowInSortedOreder();
            //objLINQCS.ShowMinLengthElements();
            //objLINQCS.RemoveVowels();

            #region "Vowel Demo"
            //IEnumerable<char> txt = "This is a simple statement for you.";

            //foreach (char vowel in "aeiou")
            //{
            //    var str = from x in txt
            //              where x != vowel select x;
            //    foreach (char c in str)
            //        Console.Write(c);

            //    Console.WriteLine();
            //}

            #endregion

            Console.ReadKey();
        }

        #region "Methods"
        //Using IEnumerable instance and Lambda Expression
        public void LengthWiseFilterLambda()
        {
            IEnumerable<string> people = persons.Where(p => p.Length > 6);
            foreach (string person in people)
                Console.WriteLine(person);
        }

        //Using IEnumerable instance and Query Expression
        public void LengthWiseFilterQuery()
        {
            IEnumerable<string> people = from p in persons 
                                         where p.Length > 6 
                                         select p;

            foreach (string person in people)
                Console.WriteLine(person);
        }

        //Using IEnumerable instance and Lambda Expression
        public void LetterInFilterLambda(char c)
        {
            IEnumerable<string> people = persons.Where(p => p.ToLower().Contains(c.ToString().ToLower()));
            foreach (string person in people)
                Console.WriteLine(person);
        }

        //Using IEnumerable instance and Query Expression
        public void LetterInFilterQuery(char c)
        {
            IEnumerable<string> people = from p in persons
                                         where p.Contains(c)
                                         select p;

            foreach (string person in people)
                Console.WriteLine(person);
        }

        //Using Chain Query Operators with Lambda Expression
        public void ChainQueryFilterLambda()
        {
            var people1 = (persons
                .Where(p => p.Contains('r')).Where(p => p.Contains('a')));
                //.Select(p => p.ToUpper() + " Ok"));
                //.OrderBy(p => p));//.OrderBy(i=>i.Length) ;
            //var people = people1.OrderBy(p => p.Length);
            foreach (string person in people1)
                Console.WriteLine(person);
        }

        //Using Chain Query Operators with Lambda Expression
        public void ChainQueryFilterQuery()
        {
            var people = (from p in persons
                          where p.Contains('r')
                          && p.Contains('a')
                          orderby p.Length
                          select p).Where(u => u.Contains('d'));

            foreach (string person in people)
                Console.WriteLine(person);
        }

        //Show Length of all Elements
        public void ShowLengthOfAllElements()
        {
            //var data = persons.Select(p => p.Length);
            var data = from p in persons select new { p, p.Length };

            foreach (var per in data)
                //Console.WriteLine(per.ToString());
                Console.WriteLine(per.p + " len: " + per.Length.ToString());
        }

        //Show in Sorted order
        public void ShowInSortedOreder()
        {
            var people = (from p in persons orderby p select p).Skip(2);
            
            foreach (string person in people)
                Console.WriteLine(person);

            Console.WriteLine();
            Console.WriteLine("Total persons in the list are " + people.Count().ToString());
            Console.WriteLine("First person in the list is " + people.First());
            Console.WriteLine("Last person in the list is " + people.Last());
            Console.WriteLine("Person at 4th position in the list is " + people.ElementAt(3));
        }

        //Show Minimum Length Elements using Subqueries
        public void ShowMinLengthElements()
        {
            var Elements = persons
                .Where(p => p.Length == persons.OrderBy(x => x.Length)
                .Select(x => x.Length).First());
            
            //*/
            /*var Elements = from p in persons
                           where p.Length == (from x in persons
                                              orderby x.Length
                                              select x.Length).First()
                           select p;
            //*/
            /*var Elements = from p in persons
                           where p.Length == persons.OrderBy(x => x.Length).First().Length
                           //where p.Length == persons.Min(x => x.Length)
                           select p;
            //*/
            
            foreach(string person in Elements)
                Console.WriteLine(person);
        }

        //Remove vowels from all Elements
        public void RemoveVowels()
        {
            var Data = persons
                .Select(p => p.Replace("a", "")
                        .Replace("e", "")
                        .Replace("i", "")
                        .Replace("o", "")
                        .Replace("u", ""))
                .OrderBy(p => p);

            foreach (string s in Data)
                Console.WriteLine(s);
        }

        #endregion
    }
}
