using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentDotnetCoreLessons.D1
{
    class ValueTypeDemo
    {
        public static void M1()
        {
            int x;
            x= 100;
            int y = x; // copy
            Console.WriteLine("x={0},y={1}",x,y);
            x = 200;
            Console.WriteLine("x={0},y={1}", x,y);
        }
        public static void M2()
        {
            int x=new Int32();

            x = 100;
            int y = x; // copy
            Console.WriteLine("x={0},y={1}", x, y);
            x = 200;
            Console.WriteLine("x={0},y={1}", x, y);
           // x = null;
        }
    }
}
