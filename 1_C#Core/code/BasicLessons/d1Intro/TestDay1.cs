using System;
namespace BasicLessons.d01Intro
{
    public class TestDay1
    {
        public static void TestDemoA()
        {
            DemoA.M1();
        }
        public static void TestDemoB()
        {
            DemoB.M1();
            DemoB.M2();
            DemoB.M3();
            Console.WriteLine("InchesToMeters="+DemoB.InchesToMeters(10));
            Console.WriteLine("MetersToInches="+DemoB.MetersToInches(10));
        }
        public static void TestMyClass()
        {
            MyClass.M1();
            MyClass.MethodA();
            MyClass.MethodB();
            MyClass.BitwiseTest();
        }
    }
}