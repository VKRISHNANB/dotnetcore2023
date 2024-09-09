using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentDotnetCoreLessons.D1
{
    class TestD1
    {
        public static void TestA()
        {
            int v1 = 100;
            int v2 = 20;
            int result = 0;
            result= StaticCalculator.Add(v1,v2);
            Console.WriteLine("Result "+result);
            result = StaticCalculator.Divide(v1, v2);
            Console.WriteLine("Result " + result);
            result = StaticCalculator.Multiply(v1, v2);
            Console.WriteLine("Result " + result);
            result = StaticCalculator.Subtract(v1, v2);
            Console.WriteLine("Result " + result);
        }
        public static void TestB()
        {
            int v1 = 100;
            int v2 = 20;
            int result = 0;
            Calculator c1 = new Calculator();
            result = c1.Add(v1, v2);
            Console.WriteLine("Result " + result);
            result = c1.Divide(v1, v2);
            Console.WriteLine("Result " + result);
            result = c1.Multiply(v1, v2);
            Console.WriteLine("Result " + result);
            result = c1.Subtract(v1, v2);
            Console.WriteLine("Result " + result);
        }
        public static void TestVTM1()
        {
            ValueTypeDemo.M1();
        }
        public static void TestPerson()
        {
            // will load in the stack
            Person p1;
            p1.Id = 100;p1.Name = "Steve";p1.City = "Chennai";
            p1.Echo();
            Person p2 = p1;// Copy
            p2.Echo();
            p1.Id = 200;p1.Name = "Job";
            p1.Echo();// new Value
            p2.Echo();// Old Value
            //===============
            Person p3 = new Person(12345);// will load in the stack
            p3.Echo();
            Person p4 = new Person(5000,"Gates","NY");// will load in the stack
            p4.Echo();
        }
    }
}
