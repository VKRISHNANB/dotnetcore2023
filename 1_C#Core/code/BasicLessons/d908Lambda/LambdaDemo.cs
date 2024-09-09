using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LambdaSampleA
{
  class LambdaDemo
  {
    static void DemoA()
    {
      Func<int, int> f1 = x => x / 2;
		      /*
		      public int f1(int x)
		      {
			      return x/2;
		      }
		      */
      int i = 100;
      int result = f1(i);
      Console.WriteLine(result);
    }
    
    static void DemoB()
    {
      Func<int> f1 = () => 100;
      int result = f1();
      Console.WriteLine(result);
    }
    static void DemoC()
    {
      Func<double, double, double> callme = (x, y) => (x + y) / 2;
      int v1 = 101;
      int v2 = 10;
      double result = callme(v1, v2);
      Console.WriteLine(result);
    }
    static void DemoD()
    {
      Func<int, double> f1  = x => x  / 2;
      int v1 = 101;
      double result = f1(v1);
      Console.WriteLine(result);
    }
    static void DemoE()
    {
      Func<int, double> f1 = x => x  / 2;
      int v1 = 101;
      double result = f1(v1);
      Console.WriteLine(result);
    }
    static void DemoF()
    {
      Func<double, int> f1 = x => (int)x / 2;
      int v1 = 101;
      int result = f1(v1);
      Console.WriteLine(result);
    }
    static void DemoG()
    {
      Func<int, double> f1= x => (double)x / 2;
      int v1 = 101;
      double result = f1(v1);
      Console.WriteLine(result);
    }
        static void Demo1()
        {
            double d = Dotrans((x, y) => x * y);
            Console.WriteLine(d);
            d = Dotrans((x, y) => x + y);
            Console.WriteLine(d);
            double d1 = Dotrans(Run);
            Console.WriteLine(d1);
        }
        static void Demo2()
        {
          Echo(() => "Hello");
          Echo(() => "World ");
        }
        public static  double Run(int v1,int v2)
        {
            if (v2 == 0) v2 = 1;
            return v1 / v2;
        }
        static double Dotrans(Func<int, int, double> f2)
        {
            return f2(50, 0);
        }
        static double DotransA(MyHandlerA  f2)
        {
            return f2(50, 5);
        }
        static void Echo(Func<string> f1)
        {
            string str = f1();
            Console.WriteLine(str);
        }
        static void EchoA(MyHandlerB  f1)
        {
            string str = f1();
            Console.WriteLine(str);
        }
    }
    public delegate double MyHandlerA(int v1, int v2);
    public delegate String MyHandlerB();
}
