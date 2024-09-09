using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d201Inheritance
{
    class Triangle:Shape
    {
        public Triangle(int x)
        {
            Console.WriteLine("Triangle Constructor Called....");
        }
        public new void Draw()
        {
            Console.WriteLine("Triangle Draw");
        }
        //public override void Display()
        //{
        //    Console.WriteLine("Triangle Display "+Height+" "+Width);
        //}
        public sealed override void Echo()
        {
            Console.WriteLine("Triangle Echo");
        }
    }
}
