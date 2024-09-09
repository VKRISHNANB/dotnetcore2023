using System;
using System.Linq;
using System.Collections.Generic;
namespace BasicLessons.d94LINQ
{
    class DemoA
    {
        public static void GetNos()
        {
            int[] nos = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
            foreach (int i in nos)
            {
                Console.Write(i);
            }
            foreach (int i in nos)
            {
               if (i % 2 == 0)
                    Console.Write(i);
            }
        }

        static IEnumerable<int> GetEvenNos()
        {
            int[] nos = {0,1,2,3,4,5,6,7,8,9,10,11,12,13,14 };
            foreach(int i in nos)
            {
                if (i % 2 == 0)
                    yield return i;// add the value i to an Enumerable Object
            }
        }
        static IEnumerable<int> GetEvenNosB()
        {
            List<int> evennos = new List<int>();
            int[] nos = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
            foreach (int i in nos)
            {
                if (i % 2 == 0)
                    evennos.Add(i);
            }
            return evennos;
        }

        public static void TestGetEvenNos()
        {
            var evenNos = GetEvenNos();
            //IEnumerator<int> elist = evenNos.GetEnumerator();
            //while(elist.MoveNext())
            //{
            //    int i = elist.Current;
            //    Console.Write(i+" ");
            //}
            //Console.WriteLine();

            foreach (int x in evenNos) // evenNos.MoveNext() if true get (elist.Current)
            {
                Console.Write(x);
            }
        }

        public static void TestEvensUsingLINQ()
        {
            int[] nos = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
            var evenNos = (from e in nos // foreach (int e in nos)
                          where e%2 == 0 // if (e%2==0)
                          select e);      // yeild return e;

            foreach (int x in evenNos)
            {
                Console.Write(x + " ");
            }
        }
        public static void LinqDemoListOfCities()
        {
            List<String> cities = new List<string>();
            cities.Add("Chennai");
            cities.Add("Bgl");
            cities.Add("Hyd");
            cities.Add("Ny");
            cities.Add("Pune");
            cities.Add("Cbt");
            cities.Add("Madurai");
            cities.Add("Trichy");
            var city = (from c1 in cities      // foreach( String c1 in cities)
                        where c1.Contains("C") // if( c1.Contains("C")) // case sensitive
                        select c1);            // yield return c1 
            Console.WriteLine(city.Count());
            foreach (Object obj in city)
                Console.WriteLine(obj);
            //----
            //foreach(String c1 in cities)
            //{
            //    if (c1.Contains("C"))
            //        Console.WriteLine(c1);
            //}
        }
        static IEnumerator<Emp> GetEmp()
        {
            List<Emp> empList = new List<Emp>();
            FillData(empList);
            foreach ( Emp e1 in empList)
            {
                yield return e1;
            }
        }
        public static void FillData(List<Emp> elist)
        {
            for(int i=0; i<10; i++)
            {
                Emp e1 = new Emp()
                {
                    ID = i,
                    FirstName = "Emp " + i,
                    Salary = 1000 * i
                };
                elist.Add(e1);
            }
        }

        public static void TestEmpLINQ()
        {
            List<Emp> empList = new List<Emp>();
            FillData(empList);
            //1. return a Collection of Emp whose salary is  > 5000
            var emps = from e1 in empList  // foreach(Emp e1 in empList)
                       where e1.Salary>5000  // if(e1.Salary > 5000)
                       select e1;           // yield return e1
            foreach (Emp e in emps)
            {
                Console.WriteLine(e.ID + " " + e.FirstName + " " + e.Salary);
            }
            //2. return a List of Emp whose salary is  > 5000
            List<Emp> emplist = (from e1 in empList
                       where e1.Salary > 5000
                       select e1).ToList();
            //3. will return the first Emp whose salary is  > 5000 from the collection
            Emp emp = (from e1 in empList
                       where e1.Salary > 5000
                       select e1).First();
            Console.WriteLine("\tFirst:"+emp.ID + " " + emp.FirstName + " " + emp.Salary);
        }

        public static void AnonymousTypeDemoA()
        {
            var emp = new { Name = "Venkat", Salary = 50000 };
            Console.WriteLine(emp.Name + " " + emp.Salary);
        }

        public static void AnonymousTypeDemoB()
        {
            List<Emp> empList = new List<Emp>();
            FillData(empList);
            var Employees = from e in empList
                            where e.Salary > 5000
                            select new { Name = e.FirstName, Salary = e.Salary };

            foreach (var emp in Employees)
            {
                Console.WriteLine(emp.Name + " " + emp.Salary);
            }
        }
    }
}
