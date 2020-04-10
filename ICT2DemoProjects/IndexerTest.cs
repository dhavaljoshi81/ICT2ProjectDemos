using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICT2DemoProjects.StudentModule;
using ICT2DemoProjects.StudentModule.IndexerDemo;

namespace ICT2DemoProjects
{


    class IndexerTest
    {
        static void Main1(string[] args)
        {
            StudentIndexer SI = new StudentIndexer();
            StudentDB s = new StudentDB
            {
                StudentID = 1,
                StudentName = "ABC",
                Age = 20,
                Semester = 1
            };
            SI[0] = s;
            s = new StudentDB
            {
                StudentID = 2,
                StudentName = "PQR",
                Age = 22,
                Semester = 2
            };
            SI[1] = s;
            s = new StudentDB
            {
                StudentID = 3,
                StudentName = "YUV",
                Age = 23,
                Semester = 1
            };
            SI[2] = s;
            s = new StudentDB
            {
                StudentID = 4,
                StudentName = "ABC",
                Age = 25,
                Semester = 2
            };
            SI[3] = s;

            ArrayList studList = SI["ABC"];
            foreach (StudentDB stud in studList)
            {
                Console.WriteLine(stud.StudentID + " " + stud.StudentName + " " + stud.Age + " " + stud.Semester);
                
            }
            


            Console.ReadKey();
        }
    }
}
