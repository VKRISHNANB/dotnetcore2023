using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d4InnerClass
{
    class TestEmp
    {
        public static void TestA()
        {
           // Emp.Address address = new Emp.Address(null);

            Emp e1 = new Emp();
            //Inner class object
            Emp.Address add = e1.GetAddress();
            add.Address1 = "Ambattur";
            add.Address2 = "Chennai";
            Console.WriteLine(add.Address1);
            Console.WriteLine(add.Address2);
        }
    }
}
