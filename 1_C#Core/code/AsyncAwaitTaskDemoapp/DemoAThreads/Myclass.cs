using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AsyncAwaitTaskDemoapp
{   
    class Myclass
    {
        int x;
        public void Execute()
        {
            Thread t1 = Thread.CurrentThread;
            int id = t1.GetHashCode();
            try
            {
                Monitor.Enter(this);
                x = 0;
                for (int i = 0; i < 5; i++)
                {
                    x += i;
                    Console.WriteLine("THID=" + id + " X=" + x);
                    Thread.SpinWait(10000000);
                }
            }
            catch(Exception err)
            {
                Console.WriteLine(id+" Error " + err.Message);                
            }
            finally
            {
                Monitor.Exit(this);
            }
            Console.WriteLine(id+" Completed");
        }
        public void ExecuteA(Object obj)
        {
            Thread t1 = Thread.CurrentThread;
            int id = t1.GetHashCode();
            int x = 0;
            if(obj.GetType()==typeof(Int32))         x=(int)obj;

            for (int i = 0; i < 5; i++)
            {
                x += i;
                Console.WriteLine("THID=" + id + " X=" + x);
                Thread.Sleep(1000);
            }
        }
    }
}
