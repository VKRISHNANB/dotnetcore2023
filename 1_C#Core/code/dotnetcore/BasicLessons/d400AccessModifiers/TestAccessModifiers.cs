using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d71AccessModifiers
{
    class TestAccessModifiers
    {
        public static void TestA()
        {
            DemoA d1 = new DemoA();
            DemoB d2 = new DemoB();
            d1.DotaskA();// public
           // d1.DotaskB(); // private
            d1.DotaskC(); // internal
            //d1.DotaskD(); // protected
            d1.DotaskE(); // internal protected
            ChildA c1 = new ChildA();
            c1.ExecuteTasks();
        }
        public static void TestB()
        {
            LibraryA.ClassX d1 = new LibraryA.ClassX();
            //LibraryA.ClassY d2 = new LibraryA.ClassY();internal
            d1.DotaskA();// public
            // d1.DotaskB(); // private
            //d1.DotaskC(); // internal
            //d1.DotaskD(); // protected
            //d1.DotaskE(); // internal protected
            ChildX c1 = new ChildX();
            c1.ExecuteTasks();
        }
    }
}
