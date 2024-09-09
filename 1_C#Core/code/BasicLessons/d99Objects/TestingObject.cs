using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BasicLessons.d2WorkingWithObjects
{
    class TestingObject
    {
        public static void TestA()
        {
            Object obj = new object();
            String s1 = obj.ToString();// Full Name of Type
            //Namespace.ClassName
            Console.WriteLine("ToString "+s1);

            Type t1 = obj.GetType();// Gives handle to the Objects type
            //Namespace.ClassName
            Console.WriteLine("GetType " + t1.FullName);

            Object obj1 = new object();
            bool b1 = obj.Equals(obj1);
            Console.WriteLine("Equals " + b1);

            int x = obj.GetHashCode();
            Console.WriteLine("obj - HashCode " + x);
            Console.WriteLine("obj1- HashCode " + obj1.GetHashCode());
        }
    }
}
