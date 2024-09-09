using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d71AccessModifiers
{
    public class DemoA
    {
        public DemoA()
        {
            Console.WriteLine("Object  Created");
        }
        public void DotaskA()
        {
            Console.WriteLine("Public --> ClassA. DoTaskA");
        }
         void DotaskB()// private
        {
            Console.WriteLine("Private --> ClassA. DoTaskB");
        }

        internal void DotaskC()
        {
            Console.WriteLine("internal --> ClassA. DoTaskC");
        }

        protected void DotaskD()
        {
            Console.WriteLine("Protected --> ClassA. DoTaskD");
        }

        internal protected void DotaskE()
        {
            Console.WriteLine("protected internal --> ClassA. DoTaskE");
        }

    }
}
