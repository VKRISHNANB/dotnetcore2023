using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d1Intro
{
    // Demo for value Types
    class Workingwithnos
    {
        static int g1 = 1000;// static global variable
        int g2 = 500;// non static global variable

        public static void DemoA()
        {
            int data1 = 100;
            int data2 = data1;
            Console.WriteLine("Value A={0} ,Value B={1}", data1, data2);
            data1 = 200;
            Console.WriteLine("x={0} ,y={1}", data1, data2);
            Console.WriteLine("x={0} ,y={1}", data1, data2);
            //int z = new int();
            //z = null;
        }
        public static void DemoB()
        {
           // Console.WriteLine("g1={0}, Data1={1}",g1,data1);
            Console.WriteLine("g1={0}",g1);
            //Console.WriteLine("g2={0}",g2); Static method accessing non static variable
            g1 = 2000;
        }
        public static void DemoC()
        {
            Console.WriteLine("g1={0}", g1);
        }
        public void DisplayNonStaticData()
        {
            Console.WriteLine("g2={0}", g2);
        }
        public static void OrderOfOperation()
        {
            int a = 5;
            int b = 4;
            int c = 2;
            int d = a + b * c; 
            //The output demonstrates that the multiplication is performed before the addition.
            Console.WriteLine(d);
            // You can force a different order of operation by adding parentheses around the operation
            // or operations you want performed first.
            d = (a + b) * c;
            Console.WriteLine(d);   
        }
    }
}
