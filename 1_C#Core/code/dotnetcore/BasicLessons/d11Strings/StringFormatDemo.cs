using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d32Strings
{
    class StringFormatDemo
    {
        public static void M1()
        {
            String s1 = String.Format("{0} ,{1} , {2}", "A", "B", "C");
            Console.WriteLine(s1);
            // Out of Index
            //String s2 = String.Format("{0} ,{1} , {3}", "A", "B", "C");
            //Console.WriteLine(s2);
            // In Valid Input Format
            //String s3 = String.Format("{A , B, C}");
            //Console.WriteLine(s3);
            String x="Alex";
            String y=$" Hello {x}";
            String s4 = $"Value1:{x} , Value2:{y}";
            Console.WriteLine(s4);
        }
        public static void M2()
        {
            String letter = "Sir,\n As I am suffering from {4} , I want leave for {3} days,\n from {1} to {2}.\n\n Thank You \n {0}";

            String reason = "fever";
            String myName = "Venkat";
            String no_of_Days = "4";
            String fromdate = "6-Aug-2018";
            String todate = "9-Aug-2018";

            String s1 = String.Format(letter, myName, fromdate, todate, no_of_Days,reason);
            
            Console.WriteLine(s1);
        }
    }
}
