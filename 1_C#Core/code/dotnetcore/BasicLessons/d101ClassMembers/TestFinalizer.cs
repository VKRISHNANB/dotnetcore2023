using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d4ClassesNMethods
{
    class TestFinalizer
    {
        public static void Test1()
        {
            FinalizerDemo f1 = new  FinalizerDemo();
            f1.Echo();
            //f1.FinalizerDemo();
            f1 = null;
            GC.WaitForPendingFinalizers();

            // f1.Echo(); // NullReferenceException
            GC.Collect(); // will first call the  FinalizerDemo of f1 before 
            // removing the object from the heap
        }
    }
}
