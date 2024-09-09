using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d201Inheritance
{
    class Rectangle:Triangle
    {
        public Rectangle():base(123)
        {
            Console.WriteLine("Rectangle Constructor Called....");
        }
        public Rectangle(int x) : base(x)
        {
            Console.WriteLine("Rectangle Constructor Called....");
        }
        public new void Draw()
        {
            Console.WriteLine("Rectangle Draw");
        }
        //public  override void Echo()
        //{
        //    Console.WriteLine("Triangle Echo");
        //}
    }
}
