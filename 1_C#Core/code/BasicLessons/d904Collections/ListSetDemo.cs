using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using CollectionsDemo.d1;
namespace CollectionsDemo.d94Collections
{
    class Demo
    {
        public static void TestA()
        {
            ArrayList alist = new ArrayList();
            int count = alist.Count;
            Console.Write("Count "+count);
            Console.WriteLine(" Capacity " + alist.Capacity);// 0
            Random r1 = new Random();
            for (int i = 0; i < 10; i++)
                alist.Add(r1.Next(10));
            Console.Write("Count " + alist.Count);
            Console.WriteLine(" Capacity " + alist.Capacity);// 16
        }
        public static void TestB()
        {
            ArrayList alist = new ArrayList();
            int count = alist.Count;
            Console.Write("Count " + count);
            Console.WriteLine(" Capacity " + alist.Capacity);// 0
            Random r1 = new Random();
            for (int i = 0; i < 10; i++) alist.Add(r1.Next(10));
            Console.Write("Count " + alist.Count);
            Console.WriteLine(" Capacity " + alist.Capacity);// 16

            for (int j = 0; j < 10; j++) alist.Add( j);
            Console.Write("Count " + alist.Count);
            Console.WriteLine(" Capacity " + alist.Capacity);// 32

            for (int i = 0; i < alist.Count; i++)
            {
                Console.Write(alist[i] + ",");
                if (i > 0 && i % 10 == 0) Console.WriteLine();
            }
        }
        public static void TestCForeach()
        {
            ArrayList alist = new ArrayList();
            int count = alist.Count;
            Console.Write("Count " + count);
            Console.WriteLine(" Capacity " + alist.Capacity);// 0
            Random r1 = new Random();
            for (int i = 0; i < 10; i++) alist.Add(r1.Next(10));
            Console.Write("Count " + alist.Count);
            Console.WriteLine(" Capacity " + alist.Capacity);// 16

            for (int j = 0; j < 10; j++) alist.Add( j);
            Console.Write("Count " + alist.Count);
            Console.WriteLine(" Capacity " + alist.Capacity);// 32
            //IEnumerable
            foreach (int x in alist)
            {
                Console.Write(x+" ");
            }

        }
        public static void TestDEnumerable()
        {
            ArrayList alist = new ArrayList();
            int count = alist.Count;
            Console.Write("Count " + count);
            Console.WriteLine(" Capacity " + alist.Capacity);// 0
            Random r1 = new Random();
            for (int i = 0; i < 10; i++) alist.Add(r1.Next(10));
            Console.Write("Count " + alist.Count);
            Console.WriteLine(" Capacity " + alist.Capacity);// 16

            for (int j = 0; j < 10; j++) alist.Add("abcd" + j);
            Console.Write("Count " + alist.Count);
            Console.WriteLine(" Capacity " + alist.Capacity);// 32

            if (alist is IEnumerable)//does alist impliment IEnumerable
            {
                IEnumerator er = alist.GetEnumerator();
                while (er.MoveNext())
                {
                    Object obj = er.Current;
                    if (typeof(int) == obj.GetType())
                    {
                        int x = (int)obj;// unboxing
                        Console.WriteLine(x);
                    }
                    else
                        Console.WriteLine(obj.ToString());
                }
            }
        }
        public static void EmpArrayList()
        {
            ArrayList empList = new ArrayList();
            for(int i=0;i<10;i++)
            {
                Emp e1 = new d1.Emp();
                e1.ID = i;e1.Name = "emp " + i; e1.Salary = 10000 * i;
                empList.Add(e1);
            }
            empList.Add("It Rained Yesterday");
            empList.Add(50000);

            Console.WriteLine("Emp Count "+empList.Count);

            IEnumerator data = null;
            if(empList is IEnumerable) // does empList implement IEnumerable
                data = empList.GetEnumerator();

            while(data.MoveNext())
            {
                Object obj = data.Current;
                if (obj.GetType() == typeof(Emp))
                {
                    Emp e = (Emp)obj;
                    Console.WriteLine("Id={0}, Name={1}, Salary={2} ", e.ID, e.Name, e.Salary);
                }
                else
                    Console.WriteLine("=======> Object is not an Employee");
            }
        }
        
        public static void TestGenericList()
        {
            List<int> nos = new List<int>();
            Console.WriteLine("Length " + nos.Count);
            Console.WriteLine("Capacity " + nos.Capacity);
            nos.Add(123);
            nos.Add(860);
            //nos.Add("Hello");
            Console.WriteLine("Length " + nos.Count);
            Console.WriteLine("Capacity " + nos.Capacity);
            nos.Add(456);
            nos.Add(346);
            nos.Add(321);
            Console.WriteLine("Length " + nos.Count);
            Console.WriteLine("Capacity " + nos.Capacity);
        }
        public static void GenericListInteger()
        {
            List<int> alist = new List<int>();
            int count = alist.Count;
            Console.Write("Count " + count);
            Console.WriteLine(" Capacity " + alist.Capacity);

            for (int i = 0; i < 10; i++)
                alist.Add(i);
            Console.Write("Count " + alist.Count);
            Console.WriteLine(" Capacity " + alist.Capacity);

            //for (int j = 0; j < 10; j++)
            //    alist.Add("abcd" + j);
            

            for (int i = 0; i < count; i++)
            {
                Console.Write(alist[i] + ",");
            }
        }

        public static void GenericListString()
        {
            List<String> alist = new List<String>();
            int count = alist.Count;
            Console.Write("Count " + count);
            Console.WriteLine(" Capacity " + alist.Capacity);
            for (int j = 0; j < 10; j++)
                alist.Add("abcd" + j);
            Console.Write("Count " + alist.Count);
            Console.WriteLine(" Capacity " + alist.Capacity);
            //for (int i = 0; i < 10; i++)
            //    alist.Add(i);
            for (int i = 0; i < count; i++)
            {
                Console.Write(alist[i] + ",");
            }
        }
        public static void GenericListDemoEmp()
        {
            List<d1.Emp> empList = new List<d1.Emp>();

            Console.Write("Length " + empList.Count);
            Console.WriteLine("\tCapacity " + empList.Capacity);
            d1.Emp e1 = new d1.Emp() { ID = 123, Name = "Venkat", Salary = 10000 };
            empList.Add(e1);
            empList.Add(new d1.Emp() { ID = 456, Name = "Krishnan", Salary = 15000 });
            //empList.Add("Hello");
            Console.Write("Length " + empList.Count);
            Console.WriteLine("\tCapacity " + empList.Capacity);
            empList.Add(new d1.Emp() { ID = 1000, Name = "Sam", Salary = 10000 });
            empList.Add(new d1.Emp() { ID = 500, Name = "John", Salary = 10000 });
            empList.Add(new d1.Emp() { ID = 200, Name = "Suresh", Salary = 10000 });
            empList.Add(e1);
            empList.Add(e1);

            Console.Write("Length " + empList.Count);
            Console.WriteLine("\tCapacity " + empList.Capacity);
            //IEnumerator data = empList.GetEnumerator();
            //while (data.MoveNext())
            //{
            //    Object obj = data.Current;
            //    if (obj.GetType() == typeof(Emp))
            //    {
            //        Emp e = (Emp)obj;
            //        Console.WriteLine("Id={0}, Name={1}, Salary={2} ", e.ID, e.Name, e.Salary);
            //    }
            //    else
            //        Console.WriteLine("=======> Object is not an Employee");
            //}
            foreach(Emp e2 in empList)
            {
                Console.WriteLine("Id={0}, Name={1}, Salary={2} ", e2.ID, e2.Name, e2.Salary);
            }
        }
        public static void EmpSetDemo()
        {
            HashSet<Emp> empSet = new HashSet<Emp>();
            for (int i = 1; i <= 10; i++)
            {
                d1.Emp e = new d1.Emp()
                {
                    ID = i,
                    Name = "Emp" + i,
                    Salary = 10000 * i
                };
                empSet.Add(e);
            }
            Console.WriteLine("Count " + empSet.Count);
            Emp e1 = empSet.ElementAt(1);
            Emp e2 = new Emp();
            empSet.Add(e2);
            empSet.Add(e2);// duplicate
            empSet.Add(e1);// duplicate
            empSet.Add(null);
            empSet.Add(null);// duplicate
            empSet.Add(e2);// duplicate
            Console.WriteLine("Count " + empSet.Count);
            foreach (Emp e10 in empSet)
            {
                if (e10 != null)
                 Console.WriteLine("Id={0}, Name={1}, Salary={2} ", e10.ID, e10.Name, e10.Salary);
            }
        }

        public static void TestGenericSortedSet()
        {
            SortedSet<int> alist = new SortedSet<int>();
            int count = alist.Count;
            Console.WriteLine("Count " + count);
           // Console.WriteLine(" Capacity " + alist.Capacity);
            alist.Add(10);   alist.Add(10);      alist.Add(10);
            Random r1 = new Random();
            for (int i = 0; i < 10; i++)
            {
                int x = r1.Next(100);
                alist.Add(x);
                Console.Write(x+" ");
            }
            Console.WriteLine();
            Console.WriteLine("Count " + alist.Count);
            foreach (int i in alist)
                Console.Write(i + ",");
        }
        public static void TestGenericSortedSetString()
        {
            SortedSet<String> alist = new SortedSet<String>();
            int count = alist.Count;
            Console.WriteLine("Count " + count);
            // Console.WriteLine(" Capacity " + alist.Capacity);
            alist.Add("Hello"); alist.Add("Hello"); alist.Add("Hello");
            Random r1 = new Random();
            for (int i = 0; i < 10; i++)
            {
                char[] data = new char[5];
                for (int j = 0; j < 5; j++)
                {
                    int x = r1.Next(90);
                    if (x < 35 ) x += 50;
                    else if (x > 35 ) x += 30;
                    if (x > 90) x = x - (x - 90);
                    data[j]=(char) x;
                }
                String s1 = new string(data);
                alist.Add(s1);
                Console.Write(s1 + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Count " + alist.Count);
            foreach (String i in alist) Console.Write(i + ",");
        }
    }
}
