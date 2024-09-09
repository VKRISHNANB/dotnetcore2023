using System;

namespace BasicLessons.d01Intro
{
    class DemoB
    {
        //global variables
        static int x = 123; // Class Variables , Non- Instance Variable
        static int y = 456;
        public static void M1()
        {
            //local variables
            int x = 100;
            int y = 200;
            int z = 300;
            String s1 = "Hello";
            Console.WriteLine("M1==>x="+x);//local
            Console.WriteLine("M1==>x="+DemoB.x);//global
            Console.WriteLine("y={0},z={1},s1={2}",y,z,s1);//global
        }

        public static void M2()
        {
            int x = 100;
            int y = 100;
            int z = 100;
            String s1 = "Hello";
            String s2 = "Hello";
            String s3 = "Hello";
            s1 = "Welcome";
            Console.WriteLine("x={2},y={0},z={1}",y,z,x);
            Console.WriteLine("s1={0},s2{1},s3={2}",s1,s2,s3);
        }

        public static void M3()
        {
            Console.WriteLine("Enter your Name");
            String strName = Console.ReadLine();
            Console.WriteLine("your Name is "+strName);
            Console.WriteLine("Upper Case "+strName.ToUpper());
            Console.WriteLine("Lower Case "+strName.ToLower());
            Console.WriteLine("Length "+strName.Length);
        }

        public static float MetersToInches(int meters)
        {
            float inches = ( 100/2.5f)* meters;
            return inches;
        }

        public static float InchesToMeters(int inches)
        {
            float meters = inches*(2.5f/100);
            return meters;
        }
        public static void Display()
        {
            Console.WriteLine(y);
        }
    }
}
