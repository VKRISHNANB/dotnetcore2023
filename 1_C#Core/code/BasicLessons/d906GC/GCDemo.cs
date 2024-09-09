using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d96GC
{
    class GCDemo
    {
        Object ob;
        public void M1()
        {
            ob = new object();
            Console.WriteLine(ob.ToString());
        }
        public void M2()
        {
            Console.WriteLine(ob.ToString());
        }
    }

    public class TestGC
    {
        public static void TestA()
        {
            GCDemo d1 = new GCDemo();
            d1.M1();
            d1 = null;
        }
    }
}
