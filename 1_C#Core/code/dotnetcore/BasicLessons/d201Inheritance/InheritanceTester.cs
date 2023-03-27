using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BasicLessons.d201Inheritance
{
    static class InheritanceTester
    {
        public static void TestBox()
        {
            Box b1 = new Box();
            b1.Height = 100; b1.Width = 200;
            b1.Show();
            b1.Height = 300; b1.Width = 400;
            b1.Show();
        }
        public static void TestWoodenBox()
        {
            WoodenBox b1 = new WoodenBox();
            b1.Height = 100;
            b1.Width = 200;
            b1.Show();// Box.Show
            //b1.TaskA();            
        }
        public static void TestBoxPolymorphism()
        {
            Box b1 = new WoodenBox();// up casting
            b1.Height = 100; b1.Width = 200;
            b1.Show();
            //b1.TaskA();
            WoodenBox b2 = (WoodenBox)b1;
           b2.TaskA();
        }
        public static void TestShapeasObject()
        {
            Object s1 = new Shape();
            Object s2 = s1;
            Console.WriteLine("s1=>Get HashCode " + s1.GetHashCode());
            Console.WriteLine("ToString " + s1.ToString());
            Console.WriteLine("GetType " + s1.GetType().FullName);
            Console.WriteLine("Equals " + s1.Equals(s2));
            Console.WriteLine("s2=>Get HashCode " + s2.GetHashCode());
            // s1.Draw();
        }
        public static void TestTriangle()
        {
            Shape t1 = new Triangle(100);
            t1.Draw();//Shape.Draw
            t1.Display();//Triangle.Display
            Triangle t2 = (Triangle)t1;
            t2.Draw();//Triangle.Draw
            t2.Display();//Triangle.Display
        }
        public static void TestRecangle()
        {
            Shape t1 = new Rectangle();
            t1.Draw();//Rec.Draw
            t1.Display();//Shape.Display
        }
        public static void TestTaskA()
        {
            Shape s1 = new Shape();
            //TaskA(s1);
            //s1 = new Triangle();
            //TaskA(s1);
            s1 = new Rectangle();
            TaskA(s1);
        }
        public static void TaskA(Shape s)
        {
            s.Draw();
        }
    }
}
