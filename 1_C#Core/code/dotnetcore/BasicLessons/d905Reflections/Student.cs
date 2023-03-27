using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d94Reflections
{
    class Student
    {
        public readonly int StudentNo;
        public String Name=String.Empty;
        public String Standard=String.Empty;
        public int Rank=0;

        public Student(int i)
        {
            StudentNo = i;
        }
        public void DisplayDetails()
        {
            Console.WriteLine("{0},{1},{2},{3}",StudentNo,Name,Standard,Rank);
        }
        public void DoHomeWork( string subject )
        {
            Console.WriteLine(StudentNo+" has Homework in "+subject);
        }
    }
}
