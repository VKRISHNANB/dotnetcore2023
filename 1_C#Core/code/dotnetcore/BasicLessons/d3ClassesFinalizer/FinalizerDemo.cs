using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d3ClassesFinalizer
{
    class  FinalizerDemo
    {
        public String Name=String.Empty;
        public  FinalizerDemo(int x)
        {
            Console.WriteLine("Object Created "+this.GetHashCode());
        }
        public void Echo()
        {
            Console.WriteLine("Echo..."+Name);
        }
        ~ FinalizerDemo()// finalizer
        {
            Console.WriteLine("Object finalized " + this.GetHashCode());
        }
    }
}
