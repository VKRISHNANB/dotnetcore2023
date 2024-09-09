using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d90Events
{
    class TestEventDemoB
    {
        public static void TestA()
        {
            d90Events.EventDemoB e1 = new d90Events.EventDemoB();
            d90Events.MessageSender msg = new d90Events.MessageSender();
            e1.OnChange += msg.SendMessage;
            Console.WriteLine(e1.GetCurrentValue());
            e1.UpdateData(1000);
            e1.UpdateData(-300);
        }
    }
}
