using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d6Interfaces
{
    interface A
    {
        void Call(string a);
    }
    public class B
    {
        public virtual void Call(int b)
        {
            Console.WriteLine(b++);
        }
    }
    public class C : B, A
    {
        public void Call(string a) //implicite Implimentation
        {
            Console.WriteLine(a);
        }
        public override void Call(int b) // specilizing inherited method
        {
            Console.WriteLine(b);
        }
    }
}
