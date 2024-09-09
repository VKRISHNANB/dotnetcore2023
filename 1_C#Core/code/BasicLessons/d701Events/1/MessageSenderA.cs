using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d90Events
{
    class MessageSenderA // Subscriber
    {
        public void SendMessage(int currentValue,int modifieddata)
        {
            Console.WriteLine("DataModified, CurrentValue{0} ", currentValue);
            Console.WriteLine("Updated Value{0} ", modifieddata);
        }
    }
}
