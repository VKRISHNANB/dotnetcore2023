using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d8Exceptions
{
//testing Bitbucket 
    class ThrowDemoA
    {
        public int M1(int x, int y)
        {
            ThrowDemoB b1 = null;
            int result = 0;
            try
            {
                b1 = new ThrowDemoB();
                result = b1.M2(x, y);
            }
            catch (Exception err)
            {
                Console.WriteLine("\tError in DemoA: " + err.Message);
                throw err;
            }
            return result;
        }
    }
    class ThrowDemoB
    {
        public int M2(int x, int y)
        {
            Calculator c1 = null;
            int result = 0;
            try
            {
                c1=new Calculator();
                result = c1.Divide(x, y);
            }
            catch (Exception err)
            {
                Console.WriteLine("\tError in DemoB: "+err.Message);
                throw err; //re throw
            }
            return result ;
        }
    }

}
