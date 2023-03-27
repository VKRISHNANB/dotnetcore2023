using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d90Events
{
    class MarkManager
    {
        public static void ChangeMark()
        {
            MessageSender msg = new MessageSender();// subscriber
            Student s1 = new Student();
            s1.Name = "Suresh";
            Student s2 = new Student();
            s2.Name = "Arun";

            s1.markChanged += msg.SendMessage;
            s2.markChanged += msg.SendMessage;

            s1.IncreaseMark(75);
            s2.IncreaseMark(96);
            s1.ReduceMark(10);
            s2.ReduceMark(5);
        }
    }
}
