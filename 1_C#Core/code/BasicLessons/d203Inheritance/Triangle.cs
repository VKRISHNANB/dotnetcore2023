using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d53Inheritance
{
    class Triangle:Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Triangle Draw " + this.Height + " " + this.Width);
        }
    }
}
