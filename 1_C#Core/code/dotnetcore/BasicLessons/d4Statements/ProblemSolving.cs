using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d3Statements
{
    class ClassB
    {
        static int key = (new Random().Next(5, 10));
        //2x^2 + x + 5
        public static void M1()
        {
            int result = 0;
            for(int i=5;i<=10;i++)
            {
                result = ((2 * i * i) + i + 5);
                Console.WriteLine("x={0}, Result={1}",i,result);
            }
        }

        // Write a program for Generate Random Number in a given range of numbers
        public static int ThrowDice()
        {
            int l = 0;
            while (l==0)
            {
                l =Convert.ToInt32(DateTime.Now.Ticks % 12);
            }
            return l;
        }
        //Print the even nos from x Int x = 158376490;
        public static void PrintEvenNos()
        {
            int nos = 158376490;
            Console.WriteLine(nos);
            while (nos!=0)
            {
                int reminder = nos % 10;
                if ((reminder%2) == 0)
                    Console.WriteLine("\t"+reminder +" is an Even");
                nos = nos / 10;
            }
            Console.WriteLine("***********Completed");
        }
        // How to encrypt a value(a password or a PIN).
        public static String Encodedata(String value)
        {
            Console.WriteLine("The Value is " + value);
            int count = value.Length;
            
            String encodedData = String.Empty;
            char[] data = value.ToCharArray();
            for(int i=0;i<count;i++)
            {
                encodedData += ((char)((int)data[i]+key));
            }
            return encodedData;
        }
        public static String Decodedata(String value)
        {
            Console.WriteLine("The Value is " + value);
            int count = value.Length;

            String decodedData = String.Empty;
            char[] data = value.ToCharArray();
            for (int i = 0; i < count; i++)
            {
                decodedData += ((char)((int)data[i] - key));
            }
            return decodedData;
        }
        // Write a program that tells the user what type of movie they can attend based on their age,
        //if they are with their parents, and their amount of money.
        //Under 13: G
        //Under 13 w/ parent: G, PG
        //13 and Over and Under 16 G, PG
        //Under 16 w/ parent G, PG, R
        //16 and Over G, PG, R
        //Matinee: $7.50
        //Evening: $10.50
    }
}
