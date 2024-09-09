using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d91Threads
{
    
    class ThreadSafeClass
    {
        [STAThread]
        public void DotaskA()
        {
        }
        public void DotaskB()
        {
            Monitor.Enter(this);
            try
            {
                Console.WriteLine("Inside TaskB try");
            } finally
            {
                Console.WriteLine("Inside TaskB  ly");
                Monitor.Exit(this);
            }
        }
    }
}
