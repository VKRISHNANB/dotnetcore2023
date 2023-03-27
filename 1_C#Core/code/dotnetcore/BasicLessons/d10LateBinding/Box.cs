using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d4LateBinding
{
    class Box
    {
        public Box()
        {
            Console.WriteLine("Box Object Created "+this.GetHashCode());
        }
        public override string ToString()
        {
            return "I am a Box";
        }
    }
}
