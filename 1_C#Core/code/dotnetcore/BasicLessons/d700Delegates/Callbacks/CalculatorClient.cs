using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace BasicLessons.d90Delegates.Callbacks
{
    public delegate int AsynMethods(int v1, int v2);
    class CalculatorClient
    {
        public static  void TestAdd()
        {
            Thread t1 = Thread.CurrentThread;
            Console.WriteLine("Main Thread ID "+t1.ManagedThreadId );
            int x = 100;
            int y = 30;
            Calculator c1 = new Calculator();
            AsynMethods m1 = c1.Add;
            AsyncCallback cb = NotifyMe;
            IAsyncResult result= m1.BeginInvoke(x, y,cb,m1);
            //int z = m1.EndInvoke(result);
            //Console.WriteLine("Output " + z);
            String data = String.Empty;
            while (!result.IsCompleted)
            {
                Console.WriteLine("Enter a Value");
                data = Console.ReadLine();
            }
        }
        public static void NotifyMe(IAsyncResult result )
        {
            AsynMethods m1 = (AsynMethods)result.AsyncState;
            int z = m1.EndInvoke(result);
            Console.WriteLine("Output " + z);
        }
    }
}
