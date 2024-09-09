using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d90Events
{
    class EventDemoA
    {
        private int data;
        MessageSenderA msg = new MessageSenderA();

        public void UpdateData(int v)
        {
            if (v == 0) return;
            data += v;
            msg.SendMessage(data,v);
        }
        public int GetCurrentValue() { return data; }
    }
}
