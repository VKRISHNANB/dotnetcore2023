using System;
//Strongly typed Func Pointers
namespace DelegateSample
{
    //.Net Types 
        // Value Type
            // Struct, and Enum
        // Ref Type
            // class, interface, and Delegates
    public struct Box { }
    public enum Colors { White, Black, Green, Blue, Red }
    public class Jar { }
    public interface IService { }

    public delegate double MethodA(double v1, double v2);
    public delegate void MethodX(double v1, double v2);
    public delegate long MethodB();
    public delegate String MethodC();
    public delegate double MethodD();

    public class Demo
    {
        Box b1 = new Box();
        Colors c1 = Colors.White;
        Jar j1 = new Jar();
        IService s1 = null;
        MethodA m1 = null;
        public void Display()
        {
            Console.WriteLine(b1.GetHashCode());
            Console.WriteLine(c1.GetHashCode());
            Console.WriteLine(j1.GetHashCode());
            Console.WriteLine(s1==null);
            Console.WriteLine(m1==null);
        }
    }
}