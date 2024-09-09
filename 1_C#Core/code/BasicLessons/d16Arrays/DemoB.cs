using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace BasicLessons.d31Arrays
{
    //https://www.codeproject.com/Articles/31640/Basics-of-NET-Collections-in-C

    class DemoB
    {
        public static void EvenNumbers()
        {
            int[] NOs = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for (int i = 0; i < NOs.Count(); i++)
            {
                if (NOs[i] % 2 == 0)
                    Console.Write(NOs[i] + ",");
            }
        }
        public static void TestIntArrayDemo()
        {
            Demo app = new Demo();
            app.PrintArray();
        }
        public static void MultiArray()
        {
            MultiDimArray app = new MultiDimArray();
            app.PrintSales();
        }
        public static void ObjectArray()
        {
            Object[] obj = new Object[4];
            obj[0] = 123;
            obj[1] = false;
            obj[2] = "Hello";
            obj[3] = new Emp(1000);
            Console.WriteLine("obj Length " + obj.Length);
            foreach (Object a in obj)
                Console.WriteLine(a.ToString());
        }
        public static void PrintPrime()
        {
            int value = 1000;
            for (int i = 2; i < value; i++)
            {
                bool prime = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        prime = false; // If Value is divisible..
                    }
                }
                if (prime == true)
                    Console.Write("{0} ", i.ToString().PadLeft(3));
            }
        }
       

    }
    class Demo
    {
        protected int[] numbers;
        public Demo()
        {
            numbers = new int[6];
            for (int i = 0; i < 6; i++)
                numbers[i] = i * i;
        }
        public  void PrintArray()
        {
            for (int i = 0; i < numbers.Count(); i++)
            {
                Console.WriteLine("numbers[{0}]={1}", i,
                    numbers[i]);
            }
        }
       
    }
}