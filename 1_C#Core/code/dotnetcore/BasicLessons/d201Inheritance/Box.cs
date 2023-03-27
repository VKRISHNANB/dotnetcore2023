using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d201Inheritance
{
    public class Box //base class
    {
        //field
        public int Height;
        public int Width;
        //Constructors
        public Box()
        {
            Console.WriteLine("Box Object Created ");
        }
        //Methods
        public  void Show()// can be inherited but not overridable
        {
            Console.WriteLine("Box.Show: Height-{0},Width-{1}",Height,Width);
        }
       // public int Show(double x) { return 0; }
        public void Show(double x) {  }
        public  void Show(int x)
        {
            Console.WriteLine("Box.Show: Height-{0},Width-{1}", Height, Width);
        }
    }
}
