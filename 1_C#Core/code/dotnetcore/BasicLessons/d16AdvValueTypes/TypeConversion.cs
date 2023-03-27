using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d06AdvValueTypes
{
    class TypeConversionDemo
    {
        public static void M1()
        {
            int x = 10;
            long l1 =9998887776563387L;
            double d2 = 999999999999999d;
            Console.WriteLine(l1);
            Console.WriteLine(d2);
            double d1 = 34.840;
            FuncA(x);// Implicite Casting 
           // FuncB(d1); 
            int i = (int)d1; // Explicite Casting
            FuncB(i); 
            i = Convert.ToInt32(d1);// Explicite Casting
            FuncB(i); 
        }
        private static void FuncA(double d)
        {
            Console.Write(d+" ");
        }
        private static void FuncB(int d)
        {
            Console.Write(d + " ");
        }

        public void D(int value)
        {
            int test = value;
            for (int intI = 0; intI < 10; intI++)
            {
                //int test = intI;
                Console.WriteLine(test);
            }
        }
    }
}
