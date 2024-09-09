using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d201Inheritance
{
    public class Emp
    {
        //fields
        public readonly int ID;
        private String Name;
        private String City;
        private float Salary;
        //constructors
        public Emp()
        {
            Console.WriteLine("Emp Object Created "+GetHashCode());
        }
        //constructor Overloading
        public Emp(int id)
        {
            Console.WriteLine("Emp Object Created " + GetHashCode());
            ID = id;
        }
        public Emp(int id,String strName,String strCity,float fSalary)
        {
            Console.WriteLine("Emp Object Created " + GetHashCode());
            ID = id;
            Name = strName;
            City = strCity;
            Salary = fSalary;
        }
        //Getters and setters
        public String GetName() { return Name; }
        public String GetCity() { return City; }
        public float GetSalary() { return Salary; }

        public void SetName(String s1)
        {
            //validate min len=3, Max len=15, Only Alph
            Name = s1;
        }
        public void SetCity(String s1)
        {
            //validate min len=4, Max len=10, Only Alph
            City = s1;
        }
        public void SetSalary(float f1)
        {
            //validate min value=15000, Max value=5000000, Only numbers
            Salary = f1;
        }

        //methods - non static
        public void StartWork()
        {
            Console.WriteLine("Emp Work Started");
        }
        public void StopWork()
        {
            Console.WriteLine("Emp Work Stopped");
        }
        public void ContinueWork()
        {
            Console.WriteLine("Emp Work Started Again ....");
        }
        public void CompleteWork()
        {
            Console.WriteLine("Emp Work Completed");
        }
        public void ShowDetails()
        {
            Console.WriteLine("Emp ShowDetails ");
            String details = "ID " + ID + " Name " + Name + " City " + City + " Salary " + Salary;
            Console.WriteLine(details);
        }
    }
}
