using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Globalization;
namespace ThSampleA
{
    class ThDemoA
    {

        public static void DemoCurrentTH()
        {
            Thread t1 = Thread.CurrentThread;
            int id = t1.ManagedThreadId;
            Console.WriteLine("ThreadID=" + id);
            Console.WriteLine("IsAlive=" + t1.IsAlive);
            Console.WriteLine("Priority=" + t1.Priority);
            Console.WriteLine("ThreadState=" + t1.ThreadState);
            Console.WriteLine("CurrentCulture=" + t1.CurrentCulture);
            Console.WriteLine( DateTime.Now.ToLongDateString());
            t1.CurrentCulture = new CultureInfo("fr-FR");
            Console.WriteLine("CurrentCulture=" + t1.CurrentCulture);
            Console.WriteLine(DateTime.Now.ToLongDateString());
            t1.CurrentCulture = new CultureInfo("de-DE");
            Console.WriteLine("CurrentCulture=" + t1.CurrentCulture);
            Console.WriteLine(DateTime.Now.ToLongDateString());
        }

        public static void CultureInfoList()
        {
            CultureInfo[] list =CultureInfo.GetCultures(CultureTypes.AllCultures);
            foreach (CultureInfo c in list)
            {
                Console.WriteLine(c.EnglishName +" "+c.Name);
            }
        }
        public static void DemoA()
        {
            Thread t = Thread.CurrentThread;
            int id = t.ManagedThreadId;
            Console.WriteLine("MainTh ID " + id);
            ServiceA a1 = new ServiceA();
            a1.DoTaskA();
        }
        
        //Multiple Threads
        public static void DemoB(){
            Thread t = Thread.CurrentThread;
            int id = t.ManagedThreadId;
            Console.WriteLine("MainTh ID " + id);
            ServiceA a1 = new ServiceA();
            Thread t1 = new Thread(a1.DoTaskA);//delegate
            t1.Start();
            Console.WriteLine("----------------End of DemoB-------------- ");
        }
        // Thread State
        public static void DemoB2()
        {
            Thread t = Thread.CurrentThread;
            int id = t.ManagedThreadId;
            Console.WriteLine("MainTh ID " + id);
            ServiceA a1 = new ServiceA();
            Thread t1 = new Thread(a1.DoTaskA);//delegate
            Console.WriteLine(t1.ManagedThreadId + " T1 State " + t1.ThreadState);
            t1.Start();
            Console.WriteLine(t1.ManagedThreadId + " State After Start " + t1.ThreadState);
            Thread.Sleep(3000);
            Console.WriteLine(t1.ManagedThreadId + " T1 State After Sleep " + t1.ThreadState);
            Console.WriteLine("----------------End of DemoB-------------- ");
        }

        public static void DemoC() {
            Thread t = Thread.CurrentThread;
            int id = t.ManagedThreadId;
            Console.WriteLine("MainTh ID: " + id);
            ServiceA a1 = new ServiceA();
            ThreadStart ts = a1.DoTaskA;
            Thread t1 = new Thread(ts);
            Thread t2 = new Thread(ts);
            t1.Start();
            t2.Start();
            Console.WriteLine("----------------End of DemoC-------------- ");
        }

        public static void DemoC2()
        {
            Thread t = Thread.CurrentThread;
            int id = t.ManagedThreadId;
            Console.WriteLine("MainTh ID: " + id);
            ServiceA a1 = new ServiceA();
            ThreadStart ts = a1.DoTaskB;
            Thread t1 = new Thread(ts);
            Thread t2 = new Thread(ts);
            t1.Start();
            t2.Start();
            // Thread.Sleep(30000);
            t1.Join(7000);
            if (t1.IsAlive) t1.Abort();
            t2.Join(7000);
            if (t2.IsAlive) t2.Abort();

            Console.WriteLine("----------------End of DemoC-------------- ");
        }

        public static void DemoE()
        {
            Thread t = Thread.CurrentThread;
            int id = t.ManagedThreadId;
            Console.WriteLine("MainTh ID: " + id);
            ServiceA a1 = new ServiceA();
            ThreadStart ts = a1.DoTaskA;
            Thread t1 = new Thread(ts);
            Thread t2 = new Thread(ts);
            //Console.WriteLine("T1 State: " + t1.ThreadState);
            //Console.WriteLine("T2 State: " + t2.ThreadState);
            //t1.Priority = ThreadPriority.Lowest;
            //t2.Priority = ThreadPriority.Highest;
            t1.Start();
            t2.Start();
            //Console.WriteLine("T1 State: " + t1.ThreadState);
            //Console.WriteLine("T2 State: " + t2.ThreadState);
            //t1.Join(10000);
            //Console.WriteLine("T1 After Join State: " + t1.ThreadState);
            //if (t1.IsAlive)
            //    t1.Abort();
            //t2.Join(7000);

            Console.WriteLine("T2 After Join State: " + t2.ThreadState);
            //if (t2.IsAlive)
            //    t2.Abort();
            //Console.WriteLine("T1 After Abort State: " + t1.ThreadState);
            //Console.WriteLine("T2 After Abort State: " + t2.ThreadState);
        }
        public static void DemoD()
        {
            ServiceA a = new ServiceA();
            ThreadStart ts = new ThreadStart(a.DoTaskB);
            Thread t1 = new Thread(ts);
            Thread t2 = new Thread(ts);
            Thread t3 = new Thread(ts);
            t1.Start();
            t2.Start();
            t3.Start();
            t1.Join(7000);
            if (t1.IsAlive)
                t1.Abort();
            t2.Join(9000);
            if (t2.IsAlive)
                t2.Abort();
            t3.Join(4000);
            if (t3.IsAlive)
                t3.Abort();
        }
        //ParameterizedThreadStart
        public static void DemoF()
        {
            Thread t = Thread.CurrentThread;
            int id = t.GetHashCode();
            Console.WriteLine("MainTh ID " + id);
            ServiceA a1 = new ServiceA();
            ParameterizedThreadStart pts =
                new ParameterizedThreadStart(a1.DoTaskC);
            Thread t1 = new Thread(pts);
            t1.Start(1000);
            t1.Join();
        }
        
        public static void THPoolA()
        {
            ServiceA a1=new ServiceA();
            WaitCallback wcb = new WaitCallback(a1.DoTaskC);
            Object data = (object)10;
            ThreadPool.QueueUserWorkItem(wcb, data);   
            //Thread.Sleep(12000);
            ThreadPool.QueueUserWorkItem(wcb, data);
        }
        public static void THPoolB()
        {
            int x = 0;
            int y = 0;
            ServiceA a1 = new ServiceA();
            ThreadPool.GetMaxThreads(out x, out y);
            Console.WriteLine("Max threads X= " + x + " Y: " + y);
            WaitCallback wcb = new WaitCallback(a1.DoTaskC);
            Object data = (object)10;
            ThreadPool.QueueUserWorkItem(wcb, data);
            ThreadPool.GetAvailableThreads(out x, out y);
            Console.WriteLine("Available threads X= " + x + " Y: " + y);
            Thread.Sleep(12000);
            ThreadPool.GetAvailableThreads(out x, out y);
            Console.WriteLine("Available threads X= " + x + " Y: " + y);
            ThreadPool.QueueUserWorkItem(wcb, data);
        }
    }
}

