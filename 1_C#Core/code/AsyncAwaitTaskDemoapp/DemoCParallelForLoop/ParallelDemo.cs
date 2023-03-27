
using System;
using System.Threading;
using System.Diagnostics;
using System.Threading.Tasks;

namespace AsyncAwaitTaskDemoapp
{
    class ParallelDemo
    {        
        public static void M1()
        {
            Stopwatch sw = Stopwatch.StartNew();
            //NonParallelMethod();
            ParallelMethod();
            #region A
            //ParallelMethod();
            //ParallelMethodA();
            //ParallelMethodB();
            #endregion
            sw.Stop();
            Console.WriteLine("It Took {0} ms",sw.ElapsedMilliseconds);
            Console.WriteLine("\nFinished...");
        }
        public static void NonParallelMethod()
        {
            int id = Thread.CurrentThread.ManagedThreadId;
            int i = 0;
            for ( i = 0; i < 1000; i++)
            {
               Thread.SpinWait(80000000);
            }
            Console.Write("TID={0}, i={1}", id, i);

        }
        public static void ParallelMethod()
        {
            ParallelLoopResult result =Parallel.For(0, 1000, i =>
                {
                    Console.Write(" TaskID=" + Task.CurrentId +" "+i);
                    Thread.SpinWait(80000000);
                }
              );
            Console.WriteLine(result.IsCompleted);
        }
        #region B
       public  static void ParallelMethodA()
        {
            ParallelLoopResult result =
             Parallel.For(10, 40, 
                (int i, ParallelLoopState pls) =>
                {
                    Console.WriteLine("i: {0} task {1}", i, 
                    Task.CurrentId);
                    Thread.Sleep(1000);
                    if (i > 15)
                        pls.Break();
                }
            );
            Console.WriteLine(result.IsCompleted);
            Console.WriteLine("lowest break iteration: {0}",
            result.LowestBreakIteration);
        }
        public static void ParallelMethodB()
        {
            Parallel.For<string>(0, 20,
                () =>
                {
                // invoked once for each thread
                Console.WriteLine(
                    "init thread {0}, task {1}",
                Thread.CurrentThread.ManagedThreadId,
                Task.CurrentId);
                return String.Format("t{0}",
                Thread.CurrentThread.ManagedThreadId);
                },
                (i, pls, str1) =>
                {
                    // invoked for each member
                    Console.WriteLine(
                        "body i {0} str1 {1} thread {2} task {3}",
                        i, str1,Thread.CurrentThread.ManagedThreadId,
                        Task.CurrentId);
                    Thread.Sleep(10);
                    return String.Format("i {0}", i);
                },
                (str1) =>
                {
                    // final action on each thread
                    Console.WriteLine("finally {0}", str1);
                }
                );
        }
        #endregion
        public static void PForEach()
        {
            string[] data = {"zero", "one", "two", "three", 
              "four","five","six", "seven","eight", "nine",
              "ten", "eleven","twelve"};

            ParallelLoopResult result =
                Parallel.ForEach<string>(data, s =>{  Console.WriteLine(s);
                                                      Thread.SpinWait(80000000);
                                                    }
                                         );
        }

        public static void PForEachPls()
        {
            string[] data = { "zero", "one", "two", "three", "four", "five",
                                "six", "seven", "eight", "nine", "ten", "eleven",
                                "twelve" };
            Parallel.ForEach<string>(data,(s, pls, l) =>
            {
                Console.WriteLine("{0} {1}", s, l);
                if (l > 10)
                    pls.Break();
            });
        }
        public static void ParallelInvoke()
        {
            Parallel.Invoke(Foo,Bar);
        }
        public static void Foo()
        {
            for (int i = 0; i < 250;i++ )
            {
                Console.Write(" Foo "+i);
                //Thread.Sleep(100);
            }
        }
        public static void Bar()
        {
            for (int i = 1000; i < 1250; i++)
            {
                Console.Write(" Bar " + i);
                //Thread.Sleep(100);
            }
        }
    }
}