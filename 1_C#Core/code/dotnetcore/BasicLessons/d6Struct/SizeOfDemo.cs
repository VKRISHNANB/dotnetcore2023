using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d6Struct
{
    class SizeOfDemo
    {
        public  static void M1()
        {
            int intSize = sizeof(int);
            Console.WriteLine(intSize);
            Console.WriteLine("byte {0}.", sizeof(byte));
            Console.WriteLine("short {0}.", sizeof(short));
            Console.WriteLine("int {0}.", sizeof(int));
            Console.WriteLine("long {0}.", sizeof(long));
            Console.WriteLine("float {0}.", sizeof(float));
            Console.WriteLine("double {0}.", sizeof(double));
            Console.WriteLine("decimal {0}.", sizeof(decimal));
            Console.WriteLine("char {0}.", sizeof(char));
            Console.WriteLine("bool {0}.", sizeof(bool));
        }
    }
}
