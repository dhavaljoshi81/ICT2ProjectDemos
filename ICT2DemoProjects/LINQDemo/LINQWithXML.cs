using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;

namespace ICT2DemoProjects.LINQDemo
{
    class LINQWithXML
    {
        static void Main1(string[] args)
        {
            XElement books = XElement.Parse(
                                            @"<books>
                                            <book>
                                                    <title>C Programming</title>
                                                    <author>Yashwant Kanitkar</author>
                                            </book>
                                            <book>
                                                    <title>Software Engineering</title>
                                                    <author>Roger Pressman</author>
                                            </book>
                                            <book>
                                                    <title>Operating System</title>
                                                    <author>Galvin Silberschatz</author>
                                            </book>
                                            </books>");

            var titles = from book in books.Elements("book")
                         //where ((string)book.Element("author")).Equals("Roger Pressman")
                         orderby book.Element("title").Value
                         select book.Element("title");



            foreach (var title in titles)
                Console.WriteLine(title.Value);

            Console.ReadKey();
        }
    }
}
