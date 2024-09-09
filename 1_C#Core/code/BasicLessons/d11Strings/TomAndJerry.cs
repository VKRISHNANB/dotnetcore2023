using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d32Strings
{
    //String s2 = "Tom and Jerry are good friends";
    //Write a method that can count the words in a string
    //Write a method that can reverse the string
    class TomAndJerry
    {
        public static void TestA()
        {
            String s1 = "Tom and Jerry are good friends";
            String[] data = s1.Split(' ');
            int count = data.Length;
            Console.WriteLine(s1);
            Console.WriteLine("Word Count "+count);
            for(int j=(count-1);j>=0;j--)
            {
                Console.Write(data[j]+" ");
            }
            Console.WriteLine();
            var s2 = s1.Reverse();
            foreach (var c in s2)
            {
                Console.Write(c );
            }
            Console.WriteLine();
            var s3 =data.Reverse();
            foreach (var c in s3)
            {
                Console.Write(c+" ");
            }
        }
        public static void TestB()
        {
            String s1 = "This monsoon the rains are good";
            char[] data = s1.ToCharArray();
            foreach(char c in data)
            {
                Console.Write(c);
            }
        }
    }
}
