using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegateSample
{
    public class Calculator
    {
        #region events
        public event MethodA M1;
        public void Run()
        {
            if (M1 != null)
            {
                double x = M1(100, 5);
                Console.WriteLine(x);
            }
            else
                Console.WriteLine("Event Handler is not assigned");
        }
        #endregion

        public double Add(double x, double y)
        {
            Console.WriteLine("Add Called ");
            return x + y;       
        }
        public double Divide(double x, double y)
        {
            Console.WriteLine("Divide Called ....");
            return x / y;
        }
        public double Subtract(double x, double y)
        {
            Console.WriteLine("Subtract Called");
            return x - y;
        }
        public double Product(double x, double y)
        {
            Console.WriteLine("Product Called");
            return x * y;       
        }
        public string GetManufacturer()
        {
            return "Casio";
        }
        #region A
        ////List<double> resultStore = new List<double>();
        //public void SaveInMemory(double result)
        //{
        //   // resultStore.Add(result);
        //}
        //public void RecallFromMemory()
        //{
        //    foreach(double d1 in resultStore)
        //    {
        //        Console.WriteLine("Result "+d1);
        //    }
        //}
        #endregion 
        public string GetModel()
        {
            return "2011";
        }
        public double GetCost()
        {
            return 1250.95;
        }
    }
}
