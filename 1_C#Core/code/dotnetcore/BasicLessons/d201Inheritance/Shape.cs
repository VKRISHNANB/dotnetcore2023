using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d201Inheritance
{
    public class Shape
    {
        public int Height, Width;
        public Shape()
        {
            Console.WriteLine("Shape Constructor Called....");
        }
        public Shape(int x)
        {
            Console.WriteLine("Shape Constructor Called....");
            Height = Width = x;
        }

        public void Draw()
        {
            Console.WriteLine("Shape Draw");
        }
        public virtual void Display()
        {
            Console.WriteLine("Shape Display "+Height+" "+Width);
        }
        public override string ToString() // overriding System.Object.ToString() -- base class of Shape
        {
            return "Hello :) I am  Shape. Can I help You";
        }
        public virtual void Echo()
        {
            Console.WriteLine("Shape Echo");
        }
        //public sealed void M1()
        //{
        
        //}
    }
}
