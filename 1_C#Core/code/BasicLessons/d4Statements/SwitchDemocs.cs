using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d3Statements
{
    class SwitchDemocs
    {
        public static void M1()
        {
            char ch = Convert.ToChar('a' | 'b' | 'c');
            switch (ch)
            {
                case 'A':
                case 'a':
                    Console.WriteLine("case A | case a");
                    break;

                case 'B':
                case 'b':
                    Console.WriteLine("case B | case b");
                    break;

                case 'C':
                case 'c':
                case 'D':
                case 'd':
                    Console.WriteLine("case D | case d");
                    break;
            }
        }

        public static void M4()
        {
            string[] strs = { "one", "two", "three", "two", "one" };
            foreach (string s in strs)
            {
                switch (s)
                {
                    case "one":
                    case "two": Console.Write(2); break;
                    case "three": Console.Write(3); break;
                }
            }
            Console.WriteLine();
            //https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/switch
        }
    }
}
