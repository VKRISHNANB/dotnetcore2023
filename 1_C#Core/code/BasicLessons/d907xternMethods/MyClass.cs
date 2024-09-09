using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xtnMethodSampleA
{
    public static class MyClassA
    {
        public static void Echo(this string str)
        {
            Console.WriteLine("Hello " + str);
        }
        public static void Move(this Car c, int Speed)
        {
            Console.WriteLine(c.RegNo + " Moving @... " + Speed);
        }
        public static void Move(this Car c)
        {
            Console.WriteLine(c.RegNo + " Moving @... " );
        }
        public static void Echo(this Car c, String str)
        {
            Console.WriteLine(c.RegNo + " Beep! Beep!... " + str);
        }

    }
}
