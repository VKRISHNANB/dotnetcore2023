using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d2Static
{
    class NormalClass
    {
        //Fields
        public static int x=0;
        public int y =0; // Member Field / Instance Field
        public readonly int t;
        public const int z= 3000;
        //static constructor
        static NormalClass() // Must not have access modifiers
        {
            Console.WriteLine("Static Block");
        }
        public NormalClass() {  t=0; Console.WriteLine("Non Static Block");       }
        public NormalClass(int v1) { y=v1; t=v1; Console.WriteLine("Non Static Block");       }
        //Methods
        public void M1() {  Console.WriteLine("M1");        }

        public static void M2()
        {
            Console.WriteLine("M2");
        }
         public void DisplayNonStaticData()
        {
            Console.WriteLine("y={0}", y);

        }
    }
}
