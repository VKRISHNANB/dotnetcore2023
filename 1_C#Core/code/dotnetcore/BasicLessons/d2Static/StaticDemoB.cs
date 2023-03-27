using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d2Static
{
    // Static Fields, Constants, Readonly
    // Instance Variables, Constructor
    class DemoB
    {
        public static int X=0;
        public const int y=314;
        public int z=0;// non static instance variable
        public readonly int t; // non static instance variable
        //Constructor
        public DemoB(int v1) { t = v1; }

        
    }
}
