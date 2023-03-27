using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d4IncrementDecrement
{
    class DemoA
    {
        public static void M1()
        {
            int r = 35;
            int x = r-- + ++r;
            Console.WriteLine("x="+x);
            Console.WriteLine("r="+r);
        }
        public static void M2()
        {
            int r = 35;
            Console.WriteLine("r=" + r);
            Console.WriteLine("r--=" + r--);
            Console.WriteLine("r=" + r);
            Console.WriteLine("++r=" + ++r);
            Console.WriteLine("r=" + r);
        }
        public static void M3()
        {
            int k = 20;
            int j = --k+2*k;
            Console.WriteLine("j=" + j);
        }
        public static void M4()
        {
            int k = 20;
            int i = --k;
            int j = 2 * k;
            Console.WriteLine("--k=" + i);
            Console.WriteLine("2k=" + j);
            int m = i + j;
            Console.WriteLine("--k+2*k=" + m);
        }
        public static void M5()
        {
            int p = 3;
            int j = 22;
            int q = p * ++j;
            Console.WriteLine("p*++j= " + q);
        }
    }
}
