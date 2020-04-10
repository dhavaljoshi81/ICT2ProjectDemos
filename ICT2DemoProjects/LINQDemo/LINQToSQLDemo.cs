using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ICT2DemoProjects.LINQDemo
{
    class LINQToSQLDemo
    {
        static void Main1(string[] args)
        {
            StudentDataContext SDC = new StudentDataContext();
            foreach (Student st in SDC.Students.ToList())
            {
                Console.WriteLine(st.Id + " : " + st.Name);
            }
            Console.WriteLine(" ========= ");

            Student s = new Student();
            s.Id = 4;
            s.Name = "PLS";
            s.Age = 20;
            SDC.Students.InsertOnSubmit(s);
            SDC.SubmitChanges();

            foreach (Student st in SDC.Students.ToList())
            {
                Console.WriteLine(st.Id + " : " + st.Name);
            }
            Console.WriteLine(" ========= ");
            SDC.Students.DeleteOnSubmit(
                SDC.Students.SingleOrDefault(std => std.Id == 2)
                );
            SDC.SubmitChanges();
            foreach (Student st in SDC.Students.ToList())
            {
                Console.WriteLine(st.Id + " : " + st.Name);
            }
            Console.WriteLine(" ========= ");

            Console.ReadKey();


        }
    }
}
