using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d90Events
{
    class MessageSender // Subscriber
    {
        public void SendMessage(int currentValue,int modifieddata)
        {
            Console.WriteLine("DataModified, CurrentValue{0} ", currentValue);
            Console.WriteLine("Updated Value{0} ", modifieddata);
        }

        public void SendMessage(String name,float oldmark,float newMark)
        {
            Console.WriteLine("Hi, "+name+" Your mark has been modified Old Mark is="+oldmark+" New Mark is="+newMark);
        }
    }
}
