using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d5Inheritance
{
    public class Shape
    {
        public int Height;
        public int Width;
        //public Shape()
        //{
        //    Console.WriteLine("Shape 1");
        //}
        public Shape(int x)
        {
            Height = Width = x;
            Console.WriteLine("Shape 2");
        }
        public Shape(int h,int w)
        {
            Height = h;
            Width = w;
            Console.WriteLine("Shape 3");
        }

        public virtual void Draw()
        {
            Console.WriteLine("Shape Draw " + this.Height + " " + this.Width);
        }
        public void Display()
        {
            Console.WriteLine("Shape Display "+this.Height+" "+this.Width);
        }
       
        public virtual void Echo()
        {
            Console.WriteLine("Shape Echo");
        }
    }
}
