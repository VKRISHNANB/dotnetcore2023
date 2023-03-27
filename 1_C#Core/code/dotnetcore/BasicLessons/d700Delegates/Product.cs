using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegateSample
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public DateTime MDate { get; set; }
        public DateTime EDate { get; set; }
        public Product()
        {
            Console.WriteLine("Product Created");
        }
        public long GetAge()
        {
            long x = DateTime.Now.Subtract(MDate).Ticks;
            DateTime dt = new DateTime(x);
            Console.WriteLine("Age  " + dt);
            return x;
        }
        public long GetLife()
        {
            long x = EDate.Subtract(DateTime.Now).Ticks;
            DateTime dt = new DateTime(x);
            Console.WriteLine("Life  " + dt);
            return x;
        }
    }
}
