using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d53Inheritance
{
    class Rectangle:Triangle
    {
       
        public override void Draw()
        {
            Console.WriteLine("Rectangle Draw");
        }
        public override void Echo()
        {
            Console.WriteLine("Triangle Echo");
        }
    }
}
