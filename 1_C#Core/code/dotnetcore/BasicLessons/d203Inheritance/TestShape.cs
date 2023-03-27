using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicLessons.d5Inheritance;
namespace BasicLessons.d53Inheritance
{
    class TestShape
    {
        public static void TestA()
        {
            Shape s1 = new Shape();
            Triangle t1 = new Triangle();
            Rectangle r1 = new Rectangle();
            //----------------------------
            RunA(s1);
            RunA(t1);
            RunA(r1);
            s1 = (Shape)t1;
            RunA(s1);
        }
        public static void RunA(Shape s)
        {
            Console.WriteLine("1");
            s.Draw();
        }
        public static void RunA(Triangle s)
        {
            Console.WriteLine("2");

            s.Draw();
        }
        public static void RunA(Rectangle  s)
        {
            Console.WriteLine("3");

            s.Draw();
        }
    }
}
