using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace DelegateSample
{
    class WorkShop
    {
        Stack bag = new Stack();

        //passing a method as a parameter to another method
        //a1 is a functional pointer passed as a parameter to ExecuteMyWork()
        public void ExecuteMyWork(MethodA a1)
        {
            double x = a1(100, 30); //executing the delegate
            Console.WriteLine("Result "+x);
            bag.Push(a1);// storing the delegate in a stack after execution
        }
        public int Count()
        {
            return bag.Count;
        }
        public void Redo()
        {
            MethodA m = (MethodA)bag.Pop();
            Console.WriteLine("Redo "+m.Method.Name);
            ExecuteMyWork(m);
        }
    }
}
