using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d6Interfaces
{
    interface IMyInterfaceA
    {
        void Fun1();
        int Fun2();
    }
    interface IMyInterfaceB
    {
        int Fun2();
    }

    class MyClass : IMyInterfaceA, IMyInterfaceB
    {
        public void  Fun1()// implicite
        {
            Console.WriteLine("MyClass fun1");
        }

        //public int Fun2() // implicite for MyClass
        //{
        //    return 5000;
        //}

        //void IMyInterfaceA.fun1(){ } // explicite for IMyInterfaceA
        int IMyInterfaceA.Fun2() // explicite for IMyInterfaceA
        {
            return 0;
        }
        int IMyInterfaceB.Fun2() // explicite for IMyInterfaceB
        {
            return 100;
        }
    }
}
