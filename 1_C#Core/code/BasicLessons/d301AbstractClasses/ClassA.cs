using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d7AbstractClasses
{
    public abstract class ClassA
    {
        public ClassA()
        {
            Console.WriteLine("ClassA Constructed");
        }
        public virtual void  Echo()
        {
        }
        public void Show()
        {
            Console.WriteLine("ClassA.Show");
        }
    }
}
