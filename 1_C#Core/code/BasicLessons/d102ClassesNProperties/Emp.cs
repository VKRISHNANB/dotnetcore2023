using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons
{
    public class Emp
    {
        //fields
        public readonly int id;
        private String name;
        private String city;
        private float salary;
        //constructors
        public Emp()
        {
            Console.WriteLine("Emp Object Created "+GetHashCode());
        }
        //constructor Overloading
        public Emp(int id)
        {
            Console.WriteLine("Emp Object Created " + GetHashCode());
            this.id = id;
        }
        public Emp(int id,String strName,String strCity,float fSalary)
        {
            Console.WriteLine("Emp Object Created " + GetHashCode());
            this.id = id;
            name = strName;
            city = strCity;
            salary = fSalary;
        }
        //Getters and setters
        public String GetName() { return name; }
        public String GetCity() { return city; }
        public float GetSalary() { return salary; }

        public void SetName(String s1)
        {
            //validate min len=3, Max len=15, Only Alph
            if(s1==null) throw new Exception("INVALID NAME!!! Name must not be NULL");
            if(s1==String.Empty) throw new Exception("INVALID NAME!!! Name must not be EMPTY");
            if (s1.Length < 3) throw new Exception("INVALID NAME!!! Name must be atleast 3 char");
            if (s1.Length > 15) throw new Exception("INVALID NAME!!! Name must be less than 16 char");
            char[] data = s1.ToUpper().ToCharArray();
            foreach(char c1 in data)
            {
                int x = (int)c1;
                if (x < 65 || x > 90)
                    throw new Exception("INVALID NAME!!! Name must have only Alphabets");
            }
            name = s1;
        }
        public void SetCity(String s1)
        {
            //validate min len=4, Max len=10, Only Alph
            if (s1 == null) throw new Exception("INVALID CITY!!!  must not be NULL");
            if (s1 == String.Empty) throw new Exception("INVALID City!!!  must not be EMPTY");
            if (s1.Length < 4) throw new Exception("INVALID CITY!!!  must be atleast 4 char");
            if (s1.Length > 10) throw new Exception("INVALID CITY!!!  must be less than 10 char");
            char[] data = s1.ToUpper().ToCharArray();
            foreach (char c1 in data)
            {
                int x = (int)c1;
                if (x < 65 || x > 90) throw new Exception("INVALID CITY!!!  must have only Alphabets");
            }

            city = s1;
        }
        public void SetSalary(float f1)
        {
            //validate min value=15000, Max value=5000000, Only numbers
            salary = f1;
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
            String details = "ID " + id + " Name " + name + " City " + city + " Salary " + salary;
            Console.WriteLine(details);
        }
    }
}
