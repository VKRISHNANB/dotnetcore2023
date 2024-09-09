using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d01Intro
{
    class FizzBuzz
    {
        // Write a program that prints the numbers from 1 to 100. 
        // But for multiples of three print "Fizz" instead of the number and for the
        // multiples of five print "Buzz".
        // For numbers which are multiples of both
        // three and five print "FizzBuzz".

        public static void TestA()
        {
           
                int i;
                for (i = 1; i <= 100; i++)
                {
                    if (i % 3 == 0 && i % 5 == 0)
                        Console.WriteLine("FizzBizz");
                    else if (i % 5 == 0)
                        Console.WriteLine("Bizz");
                    else if (i % 3 == 0)
                        Console.WriteLine("Fizz");
                    else
                        Console.WriteLine( i);
                }
        }
    }
}
