using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d4ClassesNMethods
{
    class Student
    {
        //fields
        public readonly int StudentNo;
        public String Name;
        public String Standard;
        public int Rank;
        //constructor
        public Student(int id)
        {
            StudentNo = id;
        }
        //Methods
        public void DisplayDetails()
        {
            //StudentNo = 12345;
            Console.WriteLine("{0},{1},{2},{3}",StudentNo,Name,Standard,Rank);
        }
        public void DoHomeWork( string subject )
        {
            Console.WriteLine(StudentNo+" has Homework in "+subject);
        }
    }
}
