using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicLessons;
namespace BasicLessons.d4Constructors
{
    class TestConstructor
    {
        public static void TestBox()
        {
            GlassBox b0 = new GlassBox();
            Console.WriteLine(b0.GetHashCode());
            GlassBox b1 = new GlassBox(10);
            Console.WriteLine(b1.GetHashCode());
            GlassBox b2 = new GlassBox(10,20);
            Console.WriteLine(b2.GetHashCode());
        }
        public static void TestPen()
        {
            Pen objB = new Pen();
            int count = objB.GetCount;
            Console.WriteLine(count.ToString());
           //objB.M1();
        }

        public static void TestSample()
        {
            Sample s1 = new Sample();
            s1.Display(100, 200.50f);
            s1.Display();
            Sample s2 = new Sample(10, 55.25f);
            Sample s3 = new Sample(9, 5.6f);
            //Console.WriteLine(s2.i + " " + s2.j);
        }
        public static void TestPrivateConstructor()
        {
            //Car c1 = new Car();
            Car c2 = Car.CreateCarObject();
            Console.WriteLine(c2.GetHashCode());
            c2.StartCar();
        }

    }
}
