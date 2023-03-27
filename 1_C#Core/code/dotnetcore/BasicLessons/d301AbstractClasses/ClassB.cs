using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d7AbstractClasses
{
    class ClassB : ClassA
    {
        public override void Echo()
        {
            Console.WriteLine("ClassB.Echo");
        }
        public ClassB()
        {
            Console.WriteLine("ClassB Constructed");
        }
    }
}
