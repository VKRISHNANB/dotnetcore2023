using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons 
{
    class DemoA
    {
        public static void M1()
        {
            String s1 = "Hello";
            char[] data = new char[] {'W','o','r','l','d'};
            String s2 = new String(data);
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            //String is an array of char
            char[] data1 = s1.ToCharArray();
            // converting the string in s1 to array of char
            for(int i=0;i<data1.Length;i++)
            {
                Console.WriteLine(data1[i]);
            }
        }
        public static void M2()
        {
            String s1 = "ALL MEN ARE CREATED EQUAL";
            Console.WriteLine(s1);

            String s2 = s1.Substring(12, 3);
            Console.WriteLine(s2);
        }
    }
}
