using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d94Generics
{
    class BoxTest
    {
        public static void TestA()
        {
            Box b1 = new Box();
            b1.FillList(100, 110);
            List<int> l = b1.GetList();
            foreach(int x in l)
            {
                Console.WriteLine(x);
            }
        }
        public static void TestB()
        {
            BoxA<String> b1 = new BoxA<String>();
            b1.FillList("Hello");
            List<String> l = b1.GetList();
            foreach(String s in l)
                Console.WriteLine(s);

            BoxA<float> b2 = new BoxA<float>();
            b2.FillList(55.24f);
            List<float> flist = b2.GetList();
            foreach (float f in flist)
                Console.WriteLine(f);
        }
    }
}
