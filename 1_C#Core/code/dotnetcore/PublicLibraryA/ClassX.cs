using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryA
{
    public class ClassX
    {
        public ClassX()
        {
            Console.WriteLine("ClassX Object  Created");
        }
        public void DotaskA()
        {
            Console.WriteLine("Public --> ClassX. DoTaskA");
        }
        void DotaskB()// private
        {
            Console.WriteLine("Private --> ClassX. DoTaskB");
        }

        internal void DotaskC()
        {
            Console.WriteLine("internal --> ClassX. DoTaskC");
        }

        protected void DotaskD()
        {
            Console.WriteLine("Protected --> ClassX. DoTaskD");
        }

        internal protected void DotaskE()
        {
            Console.WriteLine("protected internal --> ClassX. DoTaskE");
        }
    }
}
