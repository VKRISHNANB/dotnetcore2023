using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d4IncrementDecrement
{
    class DemoASolution
    {
        public static void M1()
        {
            int r = 35;
            int x = r-- + ++r;// 35 + (35-1) +1
            Console.WriteLine("x="+x);
            Console.WriteLine("r="+r);
        }
        public static void M2()
        {
            int r = 35;
            Console.WriteLine("r=" + r);//35
            Console.WriteLine("r--=" + r--);//35 --> 34
            Console.WriteLine("r=" + r);// 34
            Console.WriteLine("++r=" + ++r);// 34+1 - 35
            Console.WriteLine("r=" + r);// 35

        }
        public static void M3()
        {
            int k = 20;
            int j = --k+2*k;
            Console.WriteLine("j=" + j);//19+(2*19)=>57
        }
        public static void M4()
        {
            int k = 20;
            int i = --k;
            int j = 2 * k;
            Console.WriteLine("--k=" + i);//19
            Console.WriteLine("2k=" + j);//(2*19)=>38
            int m = i + j;
            Console.WriteLine("--k+2*k=" + m);//19+(2*19)=>57
        }
        public static void M5()
        {
            int p = 3;
            int j = 22;
            int q = p * ++j;
            Console.WriteLine("p*++j= " + q);// 3*(1+22)=>69

        }
    }
}
