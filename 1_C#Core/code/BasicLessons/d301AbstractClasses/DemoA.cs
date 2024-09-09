using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d7AbstractClasses
{
    public class DemoA : AbsDemo
    {
        public override void Dotask()
        {
            Console.WriteLine("DemoA Dotask");
        }
        public override void Echo()
        {
            Console.WriteLine("DemoA Echo");
        }
        public override void Show()
        {
            Console.WriteLine("DemoA Show");
        }
        public void Run()
        {
            Console.WriteLine("DemoA Run");
        }
    }
}
