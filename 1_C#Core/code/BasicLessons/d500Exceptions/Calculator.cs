using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d8Exceptions
{
    class Calculator
    {
        public int Divide(int x, int y)
        {
            return x / y;
        }
        public int Add(int x,int y)
        {
            return x + y;
        }
        public int Multiply(int x, int y)
        {
            return x * y;
        }
        public int Subtract(int x, int y)
        {
            return x - y;
        }
        
        public int DivideA(int x, int y)
        {
            //if (y == 0)
            //    throw new ZeroValueException();
            if (y == 0)
                throw new ZeroValueException("ERROR!!! Value for Y is " + y);
            return x / y;
        }
    }
}
