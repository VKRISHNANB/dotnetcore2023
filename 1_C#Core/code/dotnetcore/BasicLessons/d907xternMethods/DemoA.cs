using System;
using System.Collections.Generic;
using System.Text;

namespace BasicLessons.d701xternMethods
{
    public delegate void MyDelegate(int v1);

    class DemoA
    {
        public static void M1()
        {
            int x = 200;
            MyDelegate d = delegate(int j)
            {
                x += j;
                Console.WriteLine("Inside Delegate "+x);
            };
            //d(100);
            MyClassA.Callme(d);
            Console.WriteLine("X " + x);
        }
    }
    public static class MyClassA
    {
        public static void Callme(MyDelegate d1)
        {
            d1(100);
            d1(200);
        }
    }
}
