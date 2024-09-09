using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d4ClassesNMethods
{
    public  sealed class SealedClassDemo
    {
        public SealedClassDemo()
        {
            Console.WriteLine("Constructor");
        }
        public void Echo()
        {
            Console.WriteLine("Echo");
        }
        //public abstract void Show();
    }
    //public class ChildA:SealedClassDemo
    //{

    //}
}
