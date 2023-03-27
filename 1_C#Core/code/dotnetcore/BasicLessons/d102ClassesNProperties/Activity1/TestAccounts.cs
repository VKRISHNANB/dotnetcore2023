using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d4ClassesNProperties.Activity1
{
    class TestBank
    {
        public static void TestCustomer()
        {
            Customer c1 = new Customer();

            c1.Accountnumber = 12345;
            c1.Address = "Chennai";
            c1.emailaddress="Abcd@somewhere.com";
            c1.Name = "Abcd";
            c1.Phonenumber = 9400000001L;
            c1.TypeofAccount = AccountType.Savings;
            Console.WriteLine(c1.Accountnumber);
            Console.WriteLine(c1.Address);
            Console.WriteLine(c1.emailaddress);
            Console.WriteLine(c1.Name);
            Console.WriteLine(c1.Phonenumber);
            Console.WriteLine(c1.TypeofAccount);
        }
        public static void TestEmployee()
        {
            Employee c1 = new Employee();
            c1.Employeeid = 111111;
            c1.Address = "Chennai";
            c1.emailaddress = "xyz@somewhere.com";
            c1.Name = "xyz";
            c1.Phonenumber = 9400000002L;
            Console.WriteLine(c1.Employeeid);
            Console.WriteLine(c1.Address);
            Console.WriteLine(c1.emailaddress);
            Console.WriteLine(c1.Name);
            Console.WriteLine(c1.Phonenumber);
        }
        public static void TestBranch()
        {
            Branch b1 = new Branch();
            b1.BranchId = 5677788;
            b1.Location = "Madurai";
           b1.custList = new Activity1.Customer[5];
            b1.empList = new Activity1.Employee[5];
            for(int i=1;i<=5;i++)
            {
                Customer c1 = new Customer();
                c1.Accountnumber = i+1;
                c1.Address = "Chennai";
                c1.emailaddress = "Abcd@somewhere.com";
                c1.Name = "Abcd"+i;
                c1.Phonenumber = 9400000001L;
                c1.TypeofAccount = AccountType.Savings;
                b1.custList[i] = c1;
            }
            for (int i = 1; i <= 5; i++)
            {
                Employee c1 = new Employee();
                c1.Employeeid = 111111;
                c1.Address = "Chennai";
                c1.emailaddress = "xyz@somewhere.com";
                c1.Name = "xyz";
                c1.Phonenumber = 9400000002L;
                b1.empList[i] = c1;
            }
        }
   }
}
