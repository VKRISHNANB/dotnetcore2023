using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d201Inheritance
{
    class WoodenBox:Box //derived class
    {
        public WoodenBox()
        {
            Console.WriteLine("WoodenBox Object Created ");
        }
        public void TaskA()
        {
            base.Show();
            Show();// this.Show
        }
        //public new void Show()
        //{
        //    Console.WriteLine("WoodenBox.Show: Height-{0},Width-{1}", Height, Width);
        //}
    }
}
