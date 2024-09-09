using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d7AbstractClasses
{
    public abstract class AbsDemo
    {
        public int DataA; // Member Field
        public AbsDemo()
        {
            Console.WriteLine("Object Created ");
        }
        // abstract methods
        public abstract void Echo();
        public abstract void Dotask();
        public abstract void Show();

        public static void TaskA()
        {
            Console.WriteLine("AbsDemo. TaskA");
        }
        public  void TaskB()
        {
            Console.WriteLine("AbsDemo. TaskB");
        }        
    }
}
