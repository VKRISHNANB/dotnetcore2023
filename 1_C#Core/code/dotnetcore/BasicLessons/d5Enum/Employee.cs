using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d5Enum
{
    public enum City { Chennai, Banglore, Hyderabad }
    public enum Designation { Manager, Admin, Developer }

    class Employee
    {
        public readonly int eid;
        public string ename;
        public City ecity; //public String ecity;
        public Designation desgn; //public String desgn
        public Employee(int v1) { eid = v1; }
        public  void Details()
        {
            Console.WriteLine("Details of a employee are:");
            Console.WriteLine("ID="+eid+" Name="+ename);
            Console.WriteLine(ecity);
            Console.WriteLine(desgn);
        }
    }
}
