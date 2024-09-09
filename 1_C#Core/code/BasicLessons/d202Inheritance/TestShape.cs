using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicLessons.d5Inheritance;
namespace BasicLessons.d52Inheritance
{
    class TestShape
    {
        public static void TestA()
        {
            Triangle t1 = new Triangle();
            Triangle t2 = new Triangle(10);
            Triangle t3 = new Triangle(100,200);
            t1.Display();
            t2.Display();
            t3.Display();
            //-------------
            t1.Draw();
            t2.Draw();
            t3.Draw();
        }
    }
}
