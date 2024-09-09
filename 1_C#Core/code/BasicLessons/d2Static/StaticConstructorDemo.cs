using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d02Static
{
    class StaticConstructorDemo
    {
        public static int DataA;
        public static double DataB=3.14;
        static StaticConstructorDemo()
        {
            DataA = 123;
            Console.WriteLine("Static Constructor");
        }
        public StaticConstructorDemo()
        {
            Console.WriteLine("Non Static Constructor");
        }
        public static void Echo()
        {
            Console.WriteLine("Static Method ");
        }
        public  void Dotask()
        {
            Console.WriteLine("Non Static Method ");
        }
        public static void TestA()
        {
            Console.WriteLine(StaticConstructorDemo.DataA);
            Console.WriteLine(StaticConstructorDemo.DataB);
        }
    }
}
