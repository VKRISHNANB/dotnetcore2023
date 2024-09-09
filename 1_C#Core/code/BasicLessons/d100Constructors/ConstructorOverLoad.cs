using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d4Constructors
{
    class GlassBox
    {
       public GlassBox()
        {
            Console.WriteLine("Constructor 1");
        }
        public GlassBox(int x)//:this(x,100) //:this()
        {
            Console.WriteLine("Constructor 2");
        }
        public GlassBox(int x,int y) 
        {
            Console.WriteLine("Constructor 3");
        }
    }
}
