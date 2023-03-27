using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Threading;

namespace PLINQDemo
{
    class ProgramD
    {
        static void MainD(string[] args)
        {
            IEnumerable<int> numbers = 
                Enumerable.Range(1, 1000);

            //ParallelEnumerable.Repeat


            // Remove AsParallel() Method in PLINQ
            //query to see the difference in speed
            IEnumerable<int> results =
            from n in numbers.AsParallel().AsOrdered()
                where IsDivisibleByFive(n)
                select n;
            Stopwatch sw = Stopwatch.StartNew();
            IList<int> resultsList = results.ToList();
            Console.WriteLine("{0} items", 
                resultsList.Count());
            sw.Stop();
            Console.WriteLine("It Took {0} ms", 
                sw.ElapsedMilliseconds);
            Console.WriteLine("\nFinished...");
            foreach (int i in resultsList)
                Console.Write(i+" ");
            Console.ReadKey(true);
        }

        static bool IsDivisibleByFive(int i)
        {
            Thread.SpinWait(2000000);
            return i % 5 == 0;
        }
    }
}