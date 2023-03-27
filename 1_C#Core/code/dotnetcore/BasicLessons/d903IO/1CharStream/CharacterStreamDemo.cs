using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StreamsSamples
{
    class CharacterStreamDemo
    {
        //char streams
        public static void UsingCharStreamsToRead()
        {
            char ch;
            Console.WriteLine("Press a key followed by ENTER: ");
            int x = Console.Read();
            ch = (char)x; // get a char
            Console.WriteLine("\n"+x+" Your key is: " + ch);
        }
        public static void WritingToCharStream()
        {
            char ch= ' ';
            Console.WriteLine("Press a key q to exit: ");
            while (ch != 'q')
            {
                ch = (char)Console.Read();
                Console.WriteLine("Your key is: " + ch);
            }
        }
        public static void ReadLineUsingCharStream()
        {
            Console.Out.WriteLine("Enter a sentence");
            String str = Console.ReadLine();
            Console.Out.WriteLine(" "+str);
        }
     }
}
