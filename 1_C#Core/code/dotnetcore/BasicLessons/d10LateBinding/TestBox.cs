using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d4LateBinding
{
    class TestBox
    {
        public static void EBTest()
        {
            Box b1 = new Box(); // early binding
            b1.ToString();
        }
        public static void LBTest()
        {
            Console.WriteLine("Enter a Class Name");
            String tName = Console.ReadLine();
            Type t1 = Type.GetType(tName); // Box b1;
            if (t1 == null)
            {
                Console.WriteLine("Class Not found");
            }
            else
            {
                Object obj = Activator.CreateInstance(t1); // b1=new Box()
                Console.WriteLine(obj.ToString());
            }
        }
    }
}
