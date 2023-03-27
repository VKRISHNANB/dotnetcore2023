using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace xtnMethodSampleA
{
  public class Tester
  {
    public static void TestA()
    {
      Car c = new Car();
      c.Move();
      c.Move(180);
      c.Echo("Give Way");
      c.Display(80);
    }
        public static void Test()
        {
            //Car c1 = new Car();
            //MyClassB.Display(c1, 120);
            MyClassB.Display(new Car(), 120);
        }
        static void TestC()
        {
            string result = MyClassB.SayHello("Bill", " Gates");
            Console.WriteLine(result);
            //str.Echo();


            //Console.WriteLine("***");
            //MyClassA.Echo(str);
            //MyClassA.Echo(c, "TN");
            //MyClassB.Display(c, 80);
            Console.Read();
        }
    }                                                                               
  
 
}
