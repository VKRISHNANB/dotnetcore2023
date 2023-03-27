using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d4Constructors
{
    class Sample
    {
        int i = 0;
        float j = 0;
        //OptionalParameters
        public Sample(int x = 0, Single y = 0.0f)
        {
            i = x;
            j = y;
            Console.WriteLine("x= " + x + " y=" + y);
        }
        public Sample(int r, Single s,long t )
        {
            i = r;
            j = s;
            Console.WriteLine("r= " + r + " s=" + s+" t="+t);
        }
        public void Display(int p = 0, Single q = 0.0f)
        {
            Console.WriteLine("M1-p= "+p+" q="+q);
        }
        #region Options
        //Optional can not be used like ref or out
        //public Sample(Optional int ii = 0, Optional Single jj = 0.0f)
        //{
        //    i = ii;
        //    j = jj;
        //}
        #endregion

        public static void TestSample()
        {
            Sample s1 = new Sample();
            Sample s2 = new Sample(10);
            Sample s3 = new Sample(10, 55.25f);
            Sample s4 = new Sample(9, 5.6f, 9856L);
            //below s2.i and s2.j will not work from another class
            Console.WriteLine(s2.i + " " + s2.j);
            s2.Display(100, 200.50f);
            s2.Display();
        }
    }
}
