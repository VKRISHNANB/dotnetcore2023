using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d4ClassesNProperties
{
    class Box
    {
        private int width, height;
        public int Width
        {
            get
            {
                Console.WriteLine("Width.Get");
                return width;
            }
            set
            {
                if(value<=0)
                {
                    Console.WriteLine("Value MUST BE > ZERO!!!");return;
                }
                width = value;
            }
        }
        public int Height {
            get { return height; }
            set { height = value; }
        }
    }
}
