using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Globalization;
namespace ThSampleA
{
    class ServiceA
    {
        public void DoTaskA()
        {
            Thread t1 = Thread.CurrentThread;
            int id = t1.ManagedThreadId;
            Console.Write("Inside DoTaskA");
            Console.WriteLine("\t Thread ID: " + id);
            int x = 0;
            for (int icount = 0; icount <= 5; icount++)
            {
                x += icount;
                Console.WriteLine("\tID="+id + ": X=" + x+" icount="+icount);
                Thread.Sleep(1000);
            }
        }
        #region b
        int y = 0;
        public void DoTaskB()
        {
            Thread t = Thread.CurrentThread;
            int id = t.ManagedThreadId;
            try
            {
                Monitor.Enter(this);//lock
                Console.WriteLine("DoTaskB ID " + id+" OWNS the LOCK");
                y = 0;
                for (int icount = 0; icount <= 5; icount++)
                {
                    y += icount;
                    Console.WriteLine("\t"+id + ":" + y);
                    Thread.Sleep(1000);
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(id + ":" + err.Message);
            }
             finally
            {
                Monitor.Exit(this);//unlock
                Console.WriteLine(id + ": UnLOCK" );
            }
        }//end of Method


        public void DoTaskC(Object obj)
        {
            Thread t1 = Thread.CurrentThread;
            int id = t1.GetHashCode();
            Console.Write("\t Inside DoTaskC");
            Console.Write("\t Thread ID: " + id);
            Console.WriteLine("\tArgs=" + obj);
            int x = 0;
            for (int icount = 0; icount <= 5; icount++)
            {
                x += icount;
                Console.WriteLine(id + ":" + x);
                Thread.Sleep(1500);
            }
        }
        #endregion
    }
}
