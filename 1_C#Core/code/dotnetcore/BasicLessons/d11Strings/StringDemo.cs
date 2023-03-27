using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons

{
    static class StringDemo
    {
        //working with String
        public static void M1()
        { 
            String s1 ="Hello";
            String s2 ="Hello";
            String s3 ="Hello";
            String s4 ="Hello";
            int x = 100;
            int y = 100;
            int z = 100;
            Console.WriteLine("x={2},y={0},z={1}",y,z,x);
            Console.WriteLine("s1={0},s2{1},s3={2},s4={3}",s1,s2,s3,s4);

        }
        public static void M2()
        {
            String s1 = "Hello";
            String s2 = "Hello";
            String s3 = "Hello";
            String s4 = "Hello";
            Console.WriteLine("s1={0},s2{1},s3={2},s4={3}",s1,s2,s3,s4);           
            s1 = "Welcome";
            Console.WriteLine("s1={0},s2{1},s3={2},s4={3}",s1,s2,s3,s4);
        }
        public static void M3()
        {
            String s1 = "Tom and Jerry are good friends";
            Console.WriteLine("Length "+s1.Length);
            Char[] data = s1.ToCharArray();
            foreach(char c1 in data)
            {
                Console.WriteLine(c1);
            }
            String[] words = s1.Split(' ');
            Console.WriteLine("Word Count "+words.Count());
        }
        public static void M4()
        {
            String s1 = "Tom and Jerry are good friends";
            String s2 = s1.ToUpper();
            Console.WriteLine("s1: " + s1);
            Console.WriteLine("s2: " + s2);
            String s3 = s1.ToLower();
            Console.WriteLine("s1: " + s1);
            Console.WriteLine("s3: " + s3);

            String s4 = "    abcdef    ";
            String s5 = s4.Trim();
            Console.WriteLine(s4);
            Console.WriteLine("s4 Length: " + s4.Length);
            Console.WriteLine(s5);
            Console.WriteLine("s5 Length: " + s5.Length);
            String s6 = s4.TrimEnd();
            Console.WriteLine(s6);
            Console.WriteLine("s6 Length: " + s6.Length);
            String s7 = s4.TrimStart();
            Console.WriteLine(s7);
            Console.WriteLine("s7 Length: " + s7.Length);

        }
        public static void TestStringEquals()
        {
            String s1 = "Hello";
            String s2 = "Hello";
            Console.WriteLine("Enter a word");
            String s3 = Console.ReadLine();//Hello

            bool f1 = (s1 == s2);
            bool f2 = (s1 == s3);
            Console.WriteLine("s1==s2 " + f1); // true
            Console.WriteLine("s1==s3 " + f2);// true

            f1 = (s1.Equals(s2));
            f2 = (s1.Equals(s3));
            Console.WriteLine("s1.Equals(s2) " + f1); // true
            Console.WriteLine("s1.Equals(s3) " + f2); // true
            //Object ob1 = s1;
            //Object ob2 = s2;
            //Object ob3 = s3;
            //Console.WriteLine("ob1==ob2 " + (ob1 == ob2)); // true
            //Console.WriteLine("ob1==ob3 " +(ob1 == ob3) );// false


        }
        public static void M42()
        {
            String s="" ;
            String s1 = String.Empty;
            Console.WriteLine(s);//Error
            Console.WriteLine(s1);// Correct

            s1 = "Hello";
            for(int i=0;i<s1.Length;i++)
            { 
                Console.WriteLine(s1[i]);
            }
        }


        public static void TestSubstring()
        {
            String s1 = "It looks like September is going to have more rain";
            Console.WriteLine(s1);
            Console.WriteLine("Length "+s1.Length);
            String s2 = s1.Substring(5);
            Console.WriteLine(s2);
            Console.WriteLine("s2 Length " + s2.Length);
            String s3 = s1.Substring(5,10);
            Console.WriteLine(s3);
            Console.WriteLine("s3 Length " + s3.Length);
        }
        public static void TestCompareTo()
        {
            String s1 = "September";
            String s3 = "November";
            int x=s1.CompareTo(s3);
            Console.WriteLine("September Compare November = " + x);
            x = s1.CompareTo("Saptember");
            Console.WriteLine("September Compare Saptember = " + x);
            x = s1.CompareTo("September");
            Console.WriteLine("September Compare September = " + x);
            x = s1.CompareTo("Setpember");
            Console.WriteLine("September Compare Setpember = " + x);

            bool flag=s1.Contains("ber");
            Console.WriteLine("Contains- ber " + flag);
            String s2 = s1.Insert(3, " 2017 ");
            Console.WriteLine("Insert " + s2);

            var reversdata=s1.Reverse();
            String s4 = new String(reversdata.ToArray());
            Console.WriteLine("Reverse " + s4);
        }
        public static void SortingStrings()
        {
            //sort the names
            String[] names = new String[5];
            names[0] = "Xavier";
            names[1] = "Basker";
            names[2] = "Anandh";
            names[3] = "John";
            names[4] = "anandh";

            //String temp;
            String temp = String.Empty;
            int len = names.Length;
            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < (len - 1); j++)
                {
                    if (names[j].CompareTo(  names[j + 1]) >0)
                    {
                        temp = names[j];
                        names[j] = names[j + 1];
                        names[j + 1] = temp;
                    }
                }
            }
            for (int i = 0; i < len; i++)
            {
                Console.Write(names[i] + ",");
            }
        }

        //Modifying a String multiple times
        public static void M7()
        {
            int begin = DateTime.Now.Millisecond;
            String s1 = "Abcd";
            for(int i=1;i<1000000;i++)
            {
                s1 += i;
            }
             int after = DateTime.Now.Millisecond;
            Console.WriteLine(after-begin);
            Console.WriteLine(s1);
        }
        public static void M71()
        {
            int begin = DateTime.Now.Millisecond;
            double x = 100;
            for (int i = 1; i < 1000000; i++)
            {
                x += i;
            }
            int after = DateTime.Now.Millisecond;
            Console.WriteLine(after-begin);
            Console.WriteLine(x);
        }
        public static void TestStringBuilder()
        {
            String s1 = "Abcd";
            StringBuilder sb = new StringBuilder(s1);
            int begin = DateTime.Now.Millisecond;

            for (int i = 1; i < 1000000; i++)
            {
                sb.Append(i);
            }
            //Console.WriteLine("StringBuilder:"+sb);
            int after = DateTime.Now.Millisecond;
            Console.WriteLine(after - begin);
            Console.WriteLine("String:"+s1);
        }
        public static void M9()
        {
            String s1 = "Hello";
            Console.WriteLine("S1 "+s1);
            StringBuilder sb = new StringBuilder();
            Console.WriteLine("Capacity "+sb.Capacity);//16 chars
            Console.WriteLine("Length "+sb.Length);//zero - 0
            
            StringBuilder sb1 = new StringBuilder(200);
            Console.WriteLine("sb1 Capacity "+sb1.Capacity);//200 chars
            Console.WriteLine("sb1 Length "+sb1.Length);//zero - 0

            sb.Append(" Today it was raining. Hope it rains through this month");
            Console.WriteLine("Capacity " + sb.Capacity); 
            Console.WriteLine("Length " + sb.Length);

            Console.WriteLine("B4 Replace " + sb);
            sb.Replace('i', 'e');
            Console.WriteLine("After Replace " + sb);

            sb.Remove(5, 20);
            Console.WriteLine("After Remove " + sb);
            Console.WriteLine("Capacity " + sb.Capacity);
            Console.WriteLine("Length " + sb.Length);

            sb.Insert(10, " Have a great Time! ");
            Console.WriteLine("After Insert " + sb);

            sb.Capacity = sb.Length;
            Console.WriteLine("Capacity " + sb.Capacity);
            Console.WriteLine("Length " + sb.Length);
        }
    }
}
