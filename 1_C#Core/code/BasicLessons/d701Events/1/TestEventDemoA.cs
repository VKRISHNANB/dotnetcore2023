using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d90Events
{
    class TestEventDemoA
    {
        public static void TestA()
        {
            EventDemoA e1 = new EventDemoA();
            Console.WriteLine(e1.GetCurrentValue());
            e1.UpdateData(1000);
            e1.UpdateData(-300);
        }
    }
}
