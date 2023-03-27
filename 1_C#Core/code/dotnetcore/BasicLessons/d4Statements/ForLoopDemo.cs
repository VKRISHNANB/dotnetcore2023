using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d3Statements
{
    class ClassA
    {
        //for Loop statement
        public static void M()
        {
            for (int x = 0;x < 10;x++)
            {
                Console.Write(x+" ");
            }
           
        }
        public static void M1()
        {
            for (int x = 9; x >= 0; x--)
            {
                Console.Write(x + " ");
            }
        }

        //Nested For loops
        public static void M2()
        {
            for (int x = 1; x < 10; x++)
            {
                for (int k = 1; k <= x; k++)
                {
                    Console.Write(k + " ");
                }
                Console.WriteLine();
            }
        }

        //Nested For loops
        public static void M3()
        {
            for (int x = 1; x < 10; x++)
            {
                for (int k = 9; k > x; k--)
                {
                    Console.Write(". ");
                }
                for (int l = x; l >= 1; l--)
                {
                    Console.Write(l + " ");
                }
                Console.WriteLine();
            }
        }
        //Nested For loops
        public static void M4()
        {
            for (int x = 1; x < 10; x++)
            {
                for (int k = 9; k > x; k--)
                {
                    Console.Write("  ");
                }
                for (int l = x; l >= 1; l--)
                {
                    Console.Write(l + " ");
                }
                for (int m = 2; m <=x; m++)
                {
                    Console.Write(m + " ");
                }
                Console.WriteLine();
            }
        }
        static void M41(string[] args)
        {
            string n="1";
            for (int i = 1; i < 10; i++)
            {
                int int1 = i + 1;
                string sout = int1.ToString() + n + int1.ToString();
                Console.WriteLine(n.PadLeft(int1+10));
                n = sout;
            }
        }
        public static void M5()
        {
            for (int x = 9; x > 0; x--)
            {
                for (int k = 10; k > x; k--)
                {
                    Console.Write("  ");
                }
                for (int l = (x-1); l >= 1; l--)
                {
                    Console.Write(l + " ");
                }
                for (int m = 2; m < x; m++)
                {
                    Console.Write(m + " ");
                }
                Console.WriteLine();
            }
        }
        //break Goto
        public static void M6BreakGoto()
        {
            for(int i=0;i<10;i++)
            {
                Console.Write(" "+i);
                if (i > 5) break;
            }
            Console.WriteLine();
            Console.WriteLine("OutSide For 1");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(" " + i);
                if (i > 3) goto g1;
            }
            g1: Console.WriteLine("OutSide For 2");

        }

        public static void M6()
        {
            char[] arr = new char[] { 'k', 'i', 'C', 'i', 't' };
            //do
            //{
            //    Console.WriteLine((char)i);
            //}
            //while (int i = 0; i < arr; i++);

            foreach (int i in arr)
            {
                Console.WriteLine((char)i);
            }
            //for (int i = 0; i < arr; i++)
            //{
            //    Console.WriteLine((char)i);
            //}

         //   while (int i = 0; i < arr; i++)
	     //   {
         //       Console.WriteLine((char)i);
         //   }

            //do
            //{
            //    Console.WriteLine((char)i);
            //}until(int i = 0; i < arr; i++);
        }
    }
}
