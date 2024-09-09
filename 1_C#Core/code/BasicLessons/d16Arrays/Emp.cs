using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d31Arrays
{
    class Emp
    {
        private readonly double Id;
        public String Name;
        public String FirstName { get; set; }
        public String MiddleName { get; set; }
        public String LastName { get; set; }
        public double Salary { get; set; }
        public Emp() { }
        public Emp(double v1)
        {
            Id = v1;
        }
        public double GetID()
        {
            return Id;
        }
    }
}
