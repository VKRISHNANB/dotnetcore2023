using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicLessons.d2Static;

namespace BasicLessons.d4ClassesNMethods
{
    class TestStudentDemo
    {
        public static void TestA()
        {
           // Student s1 = new Student();
            Student s1 = new Student(1000);
            s1.Name = "Sam";
            s1.Rank = 5;
            s1.Standard = "10";
           // s1.StudentNo=12324;
            s1.DisplayDetails();
            s1.DoHomeWork("Maths");
        }

        public static void TestStudent()
        {
            Student s1 = new Student(1234);
            // Student s = new  Student();
            //s1.StudentNo = 66666; // Readonly fields can not be changes
            s1.Name = "Raju";
            s1.Standard = "8th";
            s1.Rank = 5;
            s1.DoHomeWork("Maths");
            s1.DisplayDetails();
            //
            Student s2 = new Student(5678);
            s2.Name = "Sam";
            s2.Standard = "6th";
            s2.Rank = 3;
            s2.DoHomeWork("English");
            s2.DisplayDetails();

        }


    }
}
