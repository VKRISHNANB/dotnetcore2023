using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d6Struct
{
    class BoxingDemo
    {
        public static void TestA()
        {
            int x = 100;
            Object obj = x;// Boxing
            x = 3000;
            int z = (int)obj;// Un Boxing
            Console.WriteLine(x+" "+z);
        }
        public static void TestB()
        {
            int x = 100;
            ArrayList al = new ArrayList();
            al.Add(x); // Boxing
            int z = (int)al[0];// Un Boxing
            Console.WriteLine(x + " " + z);
        }
        public static void TestC()
        {
            int total = 35;
            DateTime date = DateTime.Now;
            //boxing String.Format(String,Object,Object)
            string s = String.Format("Your total was {0} on {1}", total, date);

            Hashtable t = new Hashtable();
            t.Add(0, "zero");// boxing of 0 - Hashtable.Add(Object,Object)
            t.Add(1, "one");// boxing of 1

            DateTime d = DateTime.Now;
            String s1 = d.ToString();

            int[] x = new int[2];
            x[0] = 33;

            ArrayList a = new ArrayList();
            a.Add(33);//boxing

            MyStruct s2 = new MyStruct(15);
            IProcess ip = (IProcess)s2;// boxing
            ip.Process();

            string s3 = "The answer is " +42.ToString();
        }
    }
}
