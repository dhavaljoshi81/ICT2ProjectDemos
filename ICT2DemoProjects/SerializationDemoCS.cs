using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections;

namespace ICT2DemoProjects
{
    class SerializationDemoCS
    {
        public static void Main1()
        {
            
            List<TestClass> arrayList = new List<TestClass>();
            for (int i = 0; i < 10; i++)
            {
                arrayList.Add(new TestClass {TestData = i*20 });
            }

            try
            {
                FileStream fs = File.Open(@"h:\DemoData\testData.txt", FileMode.OpenOrCreate);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, arrayList.First());
                fs.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.ReadKey();

        }


        public static void Main2()
        {
            List<TestClass> arrayList = new List<TestClass>();
            try
            {
                FileStream fs = File.Open(@"h:\DemoData\testData.txt", FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                //arrayList = (List<TestClass>) bf.Deserialize(fs);
                TestClass ts = (TestClass) bf.Deserialize(fs);
                Console.WriteLine(ts.TestData);
                fs.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            //foreach (TestClass v in arrayList)
            //{
            //    Console.WriteLine(v.ToString());
            //    Console.WriteLine(v.TestData);
            //}

            
            Console.ReadKey();

        }

    }

    [Serializable]
    class TestClass
    {
        public int TestData { get; set; }
    }
}
