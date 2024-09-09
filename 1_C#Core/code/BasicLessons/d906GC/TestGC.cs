using System;
using System.Collections;

namespace GCSample
{
    class TestGC
    {
        public static void DemoA()
        {
            ArrayList myArray = new ArrayList();
            int y = GC.GetGeneration(myArray);
            Console.WriteLine("Gen myArray: " + y);
            for (int x = 0; x < 100000; x++)
            {
                myArray.Add(new Object());
            }
            Array a = myArray.ToArray();
            object[] a1 = { 1, 2, 3, 4 };
            y = GC.GetGeneration(myArray);
            Console.WriteLine("Gen myArray: " + y);
            y = GC.GetGeneration(a);
            Console.WriteLine("Gen a: " + y);
            y = GC.GetGeneration(a1);
            Console.WriteLine("Gen a1: " + y);
            long tm = GC.GetTotalMemory(false);
            Console.WriteLine("TotalMemory: " + tm);
            int i = a.Length;
            Console.WriteLine(i);
            int maxGen = GC.MaxGeneration;
            Console.WriteLine("MaxGeneration :" + maxGen);
            y = GC.GetGeneration(myArray);
            Console.WriteLine("Gen myArray: " + y);
            y = GC.GetGeneration(a);
            Console.WriteLine("Gen a: " + y);
            y = GC.GetGeneration(a1);
            Console.WriteLine("Gen a1: " + y);
            a = null;
            myArray = null;
            GC.Collect();
            tm = GC.GetTotalMemory(false);
            Console.WriteLine("AfterCollectTotalMemory: " + tm);
            y = GC.GetGeneration(a1);
            Console.WriteLine("Gen a1: " + y);
        }

        public static void DemoB()
        {
            String str = "Hello ";
            for (int i = 0; i < 10000; i++)
                str += i;
            Console.WriteLine("Over");
        }
    }
}
