using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d53Inheritance
{
    public class Shape
    {
        public int Height;
        public int Width;
       
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
