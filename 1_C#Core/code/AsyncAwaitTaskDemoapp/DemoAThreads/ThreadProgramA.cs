using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AsyncAwaitTaskDemoapp
{
    public class ThreadProgramA
    {
        public static void TestThread()
        {
            Thread t1 = Thread.CurrentThread;
            int id = t1.GetHashCode();            
            Console.WriteLine("TH ID " + id);
            Console.WriteLine("t1.ManagedThreadId " +
                                     t1.ManagedThreadId);
            Myclass c1 = new Myclass();
            Thread t2 = new Thread(c1.Execute);
            t2.Start();
            //c1.Execute();
        }
        public static void TestMultiThread()
        {
            Myclass c1 = new Myclass();
            ThreadStart ts = new ThreadStart(c1.Execute);
            Thread t1 = new Thread(ts);
            Thread t2 = new Thread(ts);
            Thread t3 = new Thread(ts);
            t1.Start();
            t2.Start();
            t3.Start();
        }
        public static void TestThreadPool()
        {
            Myclass c1 = new Myclass();
            WaitCallback wcb = c1.ExecuteA;
            int min = 0;
            int max = 0;
            ThreadPool.GetAvailableThreads(out min, out max);
            Console.WriteLine(min + " Available " + max);
            ThreadPool.QueueUserWorkItem(wcb, 100);
            ThreadPool.GetAvailableThreads(out min, out max);
            Console.WriteLine(min + " Available " + max);
            Thread.Sleep(1500);
            ThreadPool.QueueUserWorkItem(wcb, 200);
            ThreadPool.GetAvailableThreads(out min, out max);
            Console.WriteLine(min + " Available " + max);
            Thread.Sleep(1500);
            ThreadPool.QueueUserWorkItem(wcb, 300);
            ThreadPool.GetAvailableThreads(out min, out max);
            Console.WriteLine(min + " Available " + max);
            Thread.Sleep(1500);
            ThreadPool.QueueUserWorkItem(wcb, 400);
            ThreadPool.GetAvailableThreads(out min, out max);
            Console.WriteLine(min + " Available " + max);
        }        
    }
}
