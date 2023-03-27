using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d2Static
{
    class TestStatic
    {
        public static void TestingStaticMembers()
        {
            Console.WriteLine(NormalClass.x);
            NormalClass.x = 50000;
            Console.WriteLine(NormalClass.x);
            NormalClass.M2();
            //Constant Member
            Console.WriteLine(NormalClass.z);
            // ClassC.z = 50000;
        }

        public static  void TestDemoA()
        {
            NormalClass.x = 122334;// Static 
           // NormalClass.y = 567878;
           // Console.WriteLine("x=" + NormalClass.x + " y=" + NormalClass.y);
            Console.WriteLine("x=" + NormalClass.x );
            //NormalClass.z = 12345;
            //NormalClass.t = 98765;
            NormalClass a1 = new NormalClass(222222);
            //a1.z = 54321;
            // a1.t = 2222222; // READONLY
            Console.WriteLine("a1-z=" + NormalClass.z + " a1-t=" + a1.t);
            NormalClass a2 = new NormalClass(333333);
            //a2.z = 20000;
            Console.WriteLine("a2-z=" + NormalClass.z + " a2-t=" + a2.t);
        }
        public static void TestingConstantsMembers()
        {
            Console.WriteLine(NormalClass.z);
            // NormalClass.z = 50000;
        }

      
    }
}
