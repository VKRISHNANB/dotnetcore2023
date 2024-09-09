using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d4Constructors
{
    public class Pen
    {
        private int Count = 0;
        public Pen(int vcount)
        {
            Count = vcount;
        }
        public Pen() : this(1)
        {
            Count++;
        }
        // property
        public int GetCount 
        {
            get { return Count; }
            set { Count=value; }
        }
        public static void TestPen()
        {
            int i = 5;
           // Pen objB = new Pen(i++);
            Pen objB = new Pen();
            int count = objB.GetCount;
            Console.WriteLine(count.ToString());
            Console.WriteLine(i);

        }
    }
}
