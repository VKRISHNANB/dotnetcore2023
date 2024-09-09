using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d5Inheritance
{
    class Triangle:Shape
    {
        public Triangle():base(0)
        {
            Console.WriteLine("Triangle 1");
        }
        public Triangle(int x):base(x)
        {
            Console.WriteLine("Triangle 2");
        }
        public Triangle(int h, int w):base(h,w)
        {
            Console.WriteLine("Triangle 3");
        }
        public override void Draw()
        {
            Console.WriteLine("Triangle Draw " + this.Height + " " + this.Width);
        }
    }
}
