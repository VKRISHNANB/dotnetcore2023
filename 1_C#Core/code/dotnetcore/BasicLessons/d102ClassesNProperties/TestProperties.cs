using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d4ClassesNProperties
{
    class TestProperties
    {
        public static void TestEmp()
        {
            Emp e1 = new Emp(1000);
            //e1.GetName = "John";
            e1.SetName("John");
            //e1.City = "Chennai";
            e1.SetCity("Chennai");
            //e1.Salary = 100000;
            e1.SetSalary(10000);
            e1.StartWork();
            e1.StopWork();
            e1.ShowDetails();
        }
        public static void TestMobilePhone()
        {
            MPhone p1 = new MPhone();
            p1.MobileNo = 72000000L;
            Console.WriteLine(p1.MobileNo);
            p1.Cost = 45092;
            p1.PhoneColor =Color.RED ;
            p1.Model = "M1";
            p1.ShowDetails();
            p1.MobileNo = 9200000011;
            p1.Cost = 45000;
            p1.PhoneColor = Color.BLACK;
            p1.Model = "M1";
            p1.ShowDetails();
        }
    }
}
