using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d6Struct
{
    class TestStruct
    {
        public static void TestA()
        {
            Person p;
            p.Id = 12234;
            p.Name = "Sam";
            p.Echo();
            Person p1 = new Person(100);
            p1.Echo();
            Person p2 = new Person(200,"Abcd");
            p2.Echo();
            //p1 = null;
        }

        public static void TestB()
        {
            Person p1;
            p1.Id = 12234;
            p1.Name = "Sam";

            Person p2 = p1;
            p1.Echo();
            p2.Echo();

            p1.Id =56789;
            p1.Name = "Jhon";
            p1.Echo();
            p2.Echo();
        }
        public static void TestEquals()
        {
            Person p1;
            p1.Id = 12234;
            p1.Name = "Sam";
            p1.Echo();
            Person p2 = p1;
            Console.WriteLine("\tp1.Equals(p2) " + p1.Equals(p2));
            p2.Id = 200;
            p2.Name= "Abcd";
            p2.Echo();
            Console.WriteLine("\tp1.Equals(p2) " + p1.Equals(p2));
            //===========
            Console.WriteLine("\tp1.Equals(100) " + p1.Equals(100));
        }
    }
}
