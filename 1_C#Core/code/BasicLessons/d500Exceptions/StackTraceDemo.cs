using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d8Exceptions
{
    class ClassA
    {
        public int M1(int x,int y)
        {
            ClassB b1 = new ClassB();
            return b1.M2(x,y);
        }
    }
    class ClassB
    {
        public int M2(int x, int y)
        {
            Calculator c1 = new Calculator();
            return c1.Divide(x,y);
        }
    }
}
