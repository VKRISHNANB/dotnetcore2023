using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d90Events
{
    public delegate void MarkChangedSignal(String name, float oldmark, float newMark);

    class Student // Publisher
    {
        public String Name;
        float mark;
        public event MarkChangedSignal markChanged;//multicast
        public void IncreaseMark(float m1)
        {
            float oldMark = mark;
            mark += m1;
            // raising the event (delegate)
            markChanged(Name, oldMark, mark); 
        }
        public void ReduceMark(float m1)
        {
            float oldMark = mark;
            mark -= m1;
            // raising the event (delegate)
            markChanged(Name, oldMark, mark); 
        }
        public float GetCurrentMark()
        {
            return mark;
        }
    }
}
