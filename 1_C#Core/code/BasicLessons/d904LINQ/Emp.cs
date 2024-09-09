using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace BasicLessons.d94LINQ
{
    public class Emp
    {
        public int ID { get; set; }
        public String FirstName { get; set; }
        public String MiddleName { get; set; }
        public String LastName { get; set; }
        public double Salary { get; set; }

        public override string ToString()
        {
            return "ID="+ID+" Name "+FirstName+" Salary "+Salary;
        }
    }
}
