using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d31Arrays
{
    class DemoA
    {
       private Emp[] eList = new Emp[10];
       private int currentIndex = 0;
        public void AddEmp(Emp e1)
        {
            if (currentIndex <( eList.Length))
            {
                eList[currentIndex] = e1;
                currentIndex++;
            }
            else
                Console.WriteLine("Failed to Add Employee.");
        }
        public Emp[] GetAllEmp()
        {
            return eList;
        }
        public static void TestA()
        {
            DemoA d = new DemoA();
            Emp e1 = new Emp(1)
            { FirstName = "Gates" };
            Emp e2 = new Emp(2)
            { FirstName = "Steve" };
            Emp e3 = new Emp(3)
            { FirstName = "Elon" };
            d.AddEmp(e1);
            d.AddEmp(e2);
            d.AddEmp(e3);
            Emp[] data = d.GetAllEmp();
            Console.WriteLine("Length " + data.Length);
            int count = 0;
            while (data[count] != null)
            {
                Emp e = (Emp)data[count];
                Console.WriteLine(e.GetID() + "-" + e.FirstName);
                count++;
            }
            Console.WriteLine("End ");
        }
    }
}
