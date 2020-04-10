using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICT2DemoProjects.StudentModule;

namespace ICT2DemoProjects.StudentModule.IndexerDemo
{
    class StudentIndexer
    {
        StudentDB[] students = new StudentDB[4];
        public StudentDB this[int id]
        {
            get
            {
                return students[id];
            }
            set
            {
                students[id] = value;
            }
        }

        public ArrayList this[short age]
        {
            get
            {
                ArrayList studs = new ArrayList();
                foreach(StudentDB s in students)
                {
                    if(s.Age == age)
                    {
                        studs.Add(s);
                    }
                }
                return studs;
            }
            
        }

        public ArrayList this[int age1, int age2]
        {
            get
            {
                ArrayList studs = new ArrayList();
                foreach (StudentDB s in students)
                {
                    if (s.Age >= age1 && s.Age <= age2)
                    {
                        studs.Add(s);
                    }
                }
                return studs;
            }

        }

        public ArrayList this[string name]
        {
            get
            {
                ArrayList studs = new ArrayList();
                foreach (StudentDB s in students)
                {
                    if (s.StudentName.Equals(name))
                    {
                        studs.Add(s);
                    }
                }
                return studs;
            }

        }
    }
}
