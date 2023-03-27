using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d90Events
{
    public delegate void SignalA(int x,int y);
    class EventDemoB // Publisher
    {
        private int data;
        public event SignalA OnChange; // multicast
        public void UpdateData(int v)
        {
            //d90Events.MessageSender msg = new d90Events.MessageSender();

            //OnChange = msg.SendMessage;

            if (v == 0) return;
            data += v;
            if (OnChange != null) OnChange(data,v);// Raise the signal
        }
        public int GetCurrentValue() { return data; }
    }
}
