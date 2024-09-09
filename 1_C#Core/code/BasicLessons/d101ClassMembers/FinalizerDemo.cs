using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d4ClassesNMethods
{
    class  FinalizerDemo
    {
        public  FinalizerDemo()
        {
            Console.WriteLine("Object Created "+this.GetHashCode());
        }
        public void Echo()
        {
            Console.WriteLine("Echo...");
        }
        ~ FinalizerDemo()// Finalizer
        {
            Console.WriteLine("Object  Finalizer " + this.GetHashCode());
        }
    }
}
