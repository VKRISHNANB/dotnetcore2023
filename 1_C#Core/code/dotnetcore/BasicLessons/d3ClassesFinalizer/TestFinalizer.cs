using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicLessons;
namespace BasicLessons.d3ClassesFinalizer
{
    class TestFinalizerA
    {
        public static void Test1()
        {
             FinalizerDemo f1 = new  FinalizerDemo(1);
            f1.Echo();
            //f1.~ izerDemo();
            f1 = null;
            // f1.Echo(); // NullReferenceException
           GC.Collect(); // will first call the  izer of f1 before 
            //removing the object from the heap
        }
    }
}
