using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons
{
    public class WoodenWall
    {
        public int Height;
        public int Width;
        public String Color;

        public class Window
        {
            public String WindowType;
            private readonly WoodenWall container;
            public Window(WoodenWall wall)
            {
                this.container = wall;
            }
        }
    }
}
