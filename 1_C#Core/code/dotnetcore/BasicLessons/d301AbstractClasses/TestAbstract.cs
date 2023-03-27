using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d7AbstractClasses
{
    class TestAbstract
    {

        public static void TestClassA()
        {
           // ClassA a1 = new ClassA();
            ClassA c1 = new ClassB(); 
            c1.Echo();
            c1.Show();
           
        }

       
        public static void TestAbsDemoA()
        {
            //AbsDemo abs = new AbsDemo();
            AbsDemo c1 = new DemoA();
            c1.Echo();
            c1.Show();
            c1.Dotask();
            //c1.Run();
            DemoA a1 = (DemoA)c1;
            a1.Run();
        }

    }
}
