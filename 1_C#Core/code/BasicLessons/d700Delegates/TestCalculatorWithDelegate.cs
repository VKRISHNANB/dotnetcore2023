using System;
using System.Diagnostics;
using System.Reflection ;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegateSample
{
    class TestCalculatorWithDelegate
    {
        //MethodInfo -- Reflections
        static void Demo()
        {
            String tName = "DelegateSample.Calculator,DelegateSample";
            Type t1 = Type.GetType(tName);
            Object obj = Activator.CreateInstance(t1);
            System.Reflection.MethodInfo m1 =
                t1.GetMethod("Divide");
            Object[] data = new Object[] { 100, 50 };
            Object result = m1.Invoke(obj, data);
            Console.WriteLine(result);
    }
        static void TestCalculatorWithoutDelegate()
        {
            Calculator c1 = new Calculator();
            double x = 0;
            x = c1.Add(100, 20);
            Console.WriteLine("without Delegates Result=" + x);
        }
        //public delegate double MethodA1(double v1, double v2);
        //Using Delegate MethodA - Single cast
        public static void SinglecastDemoA()
        {
            Calculator c1 = new Calculator();
            double x = 0;
            MethodA m1 = c1.Add;// AddressOf Add
            x = m1(100, 50); // c1.Add(100,50)
            Console.WriteLine("Result=" + x);
        }
        public static void SinglecastDemoB()
        {
            Calculator c1 = new Calculator();
            double x = 0;
            MethodA m1 = c1.Add;// AddressOf Add
            x = m1(100, 50);
            Console.WriteLine("Result=" + x);
            Console.WriteLine("Method Name=" + m1.Method.Name);
            String mType = m1.Method.GetType().FullName;
            Console.WriteLine("Method Type=" + mType);
            String targetName = m1.Target.GetType().FullName;
            Console.WriteLine("Target Type=" + targetName);
            #region A
            m1 = c1.Product;
            x = m1(100, 50);
            Console.WriteLine("Method Name=" + m1.Method.Name);
            Console.WriteLine("Result=" + x);
            m1 = c1.Divide;
            x = m1(100, 50);
            Console.WriteLine("Method Name=" + m1.Method.Name);
            Console.WriteLine("Result=" + x);
            #endregion
        }

        public static void MulticastDemo()//multicast
        {
            Calculator c1 = new Calculator();
            double x = 0;
            MethodA m1 = c1.Divide;
            m1 += c1.Subtract;
            m1 += c1.Add;
            m1 += c1.Product;
            x = m1(100, 50);
            Console.WriteLine("Result="+x);
        }

        public static void TestInvocationList()
        {
            Calculator c1 = new Calculator();
            double x = 0;
            MethodA m1 = c1.Add;// single cast
            m1 += c1.Divide; // multicast
            m1 += c1.Product;
            m1 += c1.Subtract;
            Delegate[] methods = m1.GetInvocationList();
            foreach (MethodA mth in methods)
            {
                x = mth(100, 50);
                Console.Write("\t"+mth.Method.Name + ":");
                Console.WriteLine("Result " + x);
            }
        }
        // Passing Method as a parameter to another Method
        public static void TestB()
        {
            Calculator c1 = new Calculator();
            MethodA m1 = c1.Add;     Execute(m1);
            m1 = c1.Divide;          Execute(m1);
            m1 = c1.Subtract;        Execute(m1);
            m1 = c1.Product;         Execute(m1);
        }
        public static void Execute(MethodA m)
        {
            double x = 0;
            x = m(100, 50); 
            Console.WriteLine("Result=" + x);
        }
    
        static void TestingEvents()
        {
            Calculator c1 = new Calculator();
            c1.M1 += c1.Product ;// single cast
           
        }

        public static void TestRedo()
        {
            Calculator c1 = new Calculator();
            MethodA m1 = c1.Add;
            WorkShop w = new WorkShop();
            //passing a Method as an argument to another method
            w.ExecuteMyWork(m1);

            m1 = c1.Divide;
            w.ExecuteMyWork(m1);

            m1 = c1.Product;
            w.ExecuteMyWork(m1);

            int mcount = w.Count();
            Console.WriteLine("Total Methods "+ mcount);
            w.Redo();
        }

        public static void SyncDemo()
        {
            Calculator c1 = new Calculator();
            double x = 0;
            MethodA m1 = c1.Add;
            x= m1(100, 50);
            Console.WriteLine("Result=" + x);
            m1 = c1.Divide;
            x = m1(100, 50);
            Console.WriteLine("Result=" + x);
            m1 = c1.Product;
            x = m1(100, 50);
            Console.WriteLine("Result=" + x);
            m1 = c1.Subtract;
            x = m1(100, 50);
            Console.WriteLine("Result=" + x);
        }

        public static void AsyncDemoA()
        {
            Calculator c1 = new Calculator();
            MethodA m1 = c1.Add;
            m1.BeginInvoke(100, 50, null, null);
            m1 = c1.Divide;
            m1.BeginInvoke(100, 50, null, null);
            m1 = c1.Product;
            m1.BeginInvoke(100, 50, null, null);
            m1 = c1.Subtract;
            m1.BeginInvoke(100, 50, null, null);
        }

        public static void AsyncDemoB()
        {
            Calculator c1 = new Calculator();
            double x = 0;
            MethodA m1 = c1.Add;
            IAsyncResult ar = m1.BeginInvoke(100, 50, null, null);
            while (!ar.IsCompleted)
            {
                Console.Write(".");
            }
            Console.WriteLine("Async Call Completed");            
            x = m1.EndInvoke(ar);
            Console.WriteLine("Result=" + x);
        }
        //Async Callbacks
        public static void TestingAsyncCallback()
        {
            #region Async Callbacks
            //Stopwatch w = new Stopwatch();
            //w.Start();
            //AsyncCallB();
            //for (int i = 0; i < 10; i++)
            //{
            //    System.Threading.Thread.Sleep(500);
            //    Console.Write(i + " ");
            //}
            //w.Stop();
            //Console.WriteLine("Time Taken=" + w.ElapsedMilliseconds);

            #endregion
        }

        public static void AsyncCallA()
        {
            Calculator c1 = new Calculator();
            double x = 0;
            MethodA m1 = c1.Add;
            IAsyncResult ar = m1.BeginInvoke(100, 50,null,null);
            MethodA m2 = c1.Divide;
            IAsyncResult ar1 = m2.BeginInvoke(100, 50, null, null);

            MethodA m3 = c1.Product;
            IAsyncResult ar2 = m3.BeginInvoke(100, 50, null, null);
            while (!ar1.IsCompleted)
            {
                Console.Write(".");
            }
            x = m2.EndInvoke(ar1);
            Console.WriteLine("Result="+x);
            while (!ar2.IsCompleted)
            {
                Console.Write(".");
            }
            x = m3.EndInvoke(ar2);
            Console.WriteLine("Result=" + x);
            while (!ar.IsCompleted)
            {
                Console.Write(".");
            }
            x = m1.EndInvoke(ar);
            Console.WriteLine("Result=" + x);
        }
        public static void AsyncCallB()
        {
            Calculator c1 = new Calculator();
            MethodA m1 = c1.Add;
            AsyncCallback cb = Notify;
            IAsyncResult ar = m1.BeginInvoke(100, 50, Notify, m1);
            Console.WriteLine("Invoked Method "+DateTime.Now);
        }
        public static void Notify(IAsyncResult ar)
        {
            double x = 0;
            MethodA m1 = (MethodA)ar.AsyncState;
            x = m1.EndInvoke(ar);
            Console.WriteLine("Inside Notify =" + x);
            Console.Write( DateTime.Now);
        }
        
        //Product Class and MethodInfo
        static void MInvoke()
        {
            Type t1 = typeof(Product);
            Product p1 = (Product)Activator.CreateInstance(t1);
            Random r = new Random();
            p1.ID = r.Next();
            p1.Name = "ProductA";
            p1.Price = r.NextDouble() * 10000;
            int m = r.Next(1, 12);
            p1.MDate = DateTime.Now.AddMonths(-m);
            m = r.Next(1, 365);
            p1.EDate = DateTime.Now.AddDays(m);
            Console.WriteLine("MDate " + p1.MDate);
            Console.WriteLine("EDate " + p1.EDate);
            MethodInfo mth = t1.GetMethod("GetAge");
            long x = (long)mth.Invoke(p1, null);
            Console.WriteLine("Result " + x);
        }
        static void MethodInfoDemo()
        {
            Type t1 = typeof(Product);
            MethodInfo[] mths = t1.GetMethods();
            foreach (MethodInfo m in mths)
            {
                Console.WriteLine(m.ReturnType + " " + m.Name);
                ParameterInfo[] paras = m.GetParameters();
                if (null != paras)
                {
                    foreach (ParameterInfo p in paras)
                    {
                        Console.WriteLine("------" + p.Name +
                            " " + p.ParameterType);
                    }
                }
            }
        }
        static void ReflectionDemo()
        {
            Type t1 = typeof(Product);
            PropertyInfo[] props = t1.GetProperties();
            foreach (PropertyInfo p in props)
            {
                Console.WriteLine(p.Name + " " + p.PropertyType);
            }
            ConstructorInfo[] cons = t1.GetConstructors();
            foreach (ConstructorInfo c in cons)
            {
                Console.WriteLine(c.Name + " " + c.IsSpecialName);
            }
            MethodInfo[] mths = t1.GetMethods();
            foreach (MethodInfo m in mths)
            {
                Console.WriteLine(m.Name);
            }
        }
        static void ProductDemo()
        {
            Random r = new Random();
            Product p1 = new Product();
            p1.ID = r.Next();
            p1.Name = "ProductA";
            p1.Price = r.NextDouble() * 10000;
            int m = r.Next(1, 12);
            p1.MDate = DateTime.Now.AddMonths(-m);
            m = r.Next(1, 365);
            p1.EDate = DateTime.Now.AddDays(m);
            Console.WriteLine("MDate " + p1.MDate);
            Console.WriteLine("EDate " + p1.EDate);
            p1.GetAge();
            p1.GetLife();
        }
    }
}
