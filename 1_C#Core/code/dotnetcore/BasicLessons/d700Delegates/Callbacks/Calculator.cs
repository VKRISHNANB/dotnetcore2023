using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace BasicLessons.d90Delegates.Callbacks
{
    class Calculator
    {
        public int  Add(int v1,int v2)
        {
            Thread t1 = Thread.CurrentThread;
            Console.WriteLine("Add Started "+t1.ManagedThreadId );
            System.Threading.Thread.Sleep(30000);
            return v1 + v2;
        }
    }
}
