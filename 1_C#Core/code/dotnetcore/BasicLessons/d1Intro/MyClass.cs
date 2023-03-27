using System;

namespace BasicLessons.d01Intro
{
    class MyClass
    {
      public static void M1()
        {
            Console.WriteLine("My Class M1()");
        }
        public static void MethodA()
        {
            int x = 5;
            Console.WriteLine(x);// 5
            x = 3;
            Console.WriteLine(x);// 3
            x += 10;
            Console.WriteLine(x);// 13
        }
        public static void MethodB()
        {
            Console.WriteLine("Enter Your Age");
            String strAge = Console.ReadLine();
            //Console.Clear();
            //int x = Convert.ToInt32(strAge);
            int age = int.Parse(strAge);//converting a string value into no
            if (age < 18)
            {
                Console.WriteLine(" Sorry , You can not drive a bike " + age);//if true
            }
            else
            {
                Console.WriteLine(" Yes, You can drive a Bike " + age);//if not true
            }
        }
        public static void BitwiseTest()
        {
            //d05BitOperators.DemoA.TestBitwiseXOR();
            int i = 2, j = i;
            Console.WriteLine("i|j " + (i | j));
            Console.WriteLine("(j&5) " + (j & 5)); //00110010 & 00110101 => 00110000
            Console.WriteLine("(i|j&5) " + (i | j & 5)); //00110010 | 00110000 => 10
            Console.WriteLine("2 -25*1 " + (2 - 25 * 1));//00110010 & 00010111
            Console.WriteLine("(i|j&5 ) & (2 -25*1) " + ((i | j & 5) & (-23)));

        }
    }
}
