using System;
namespace BasicLessons.d06AdvValueTypes
{
    public class VarDemo
    {
        public static void M1()
        {
            var x = 100;// int x=100;
            var flag = false; // bool flag= false;
            var str = "Hello"; // String str = "Hello";
            var obj = new Object(); // Object obj = new Object();

            Console.WriteLine("x "+x.GetType().FullName);
            Console.WriteLine("flag "+flag.GetType().FullName);
            Console.WriteLine("str "+str.GetType().FullName);
            Console.WriteLine("obj "+obj.GetType().FullName);

        }
    }
}