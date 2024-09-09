﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace CollectionsDemo.d1
{
    class DictionaryDemo
    {
        public static void HashtableDemo()
        {
            Hashtable ht = new Hashtable();
            Console.WriteLine("Count " + ht.Count);
            Console.WriteLine("IsFixedSize " + ht.IsFixedSize);
            ht.Add("id", 123);
            ht.Add("name", "Gates");
            Console.WriteLine("Count " + ht.Count);
            ht.Add("sal", 15000);
            ht.Add("r1", new Random().Next());
            ht.Add("IsDirector", false);
            ht.Add("Address", null);
           // ht.Add("name", "Bill");// Runtime Error duplicate key 
            Console.WriteLine("Count " + ht.Count);
            Console.WriteLine(ht["sal"]);
            Console.WriteLine("ContainsKey(r1) " + ht.ContainsKey("r1"));
            Console.WriteLine("ContainsKey(name) " + ht.ContainsKey("name"));

            foreach (Object k in ht.Keys)
                Console.WriteLine(k + "--" + ht[k]);
        }

        public static void EmpHTDemo()
        {
            Hashtable empTable = new Hashtable();
            for (int i = 1; i <= 10; i++)
            {
                d1.Emp e = new d1.Emp()
                {
                    ID = i,
                    Name = "Emp" + i,
                    Salary = 10000 * i
                };
                empTable.Add(e.ID, e);
            }
            Console.WriteLine("Count " + empTable.Count);
            Console.WriteLine("ContainsKey(5) " + empTable.ContainsKey(5));
            Console.WriteLine("ContainsKey(15) " + empTable.ContainsKey(15));

        }

        public static void EmpDictionaryDemo()
        {
            Dictionary<int, Emp> empMap = new Dictionary<int, Emp>();
            for (int i = 1; i <= 10; i++)
            {
                Emp e = new Emp()
                {
                    ID = i,
                    Name = "Emp" + i,
                    Salary = 10000 * i
                };
                empMap.Add(e.ID, e);
            }
            Emp e1 = new Emp() { ID = 12345, Name = "Venkat", Salary = 1000000 };
            empMap.Add(15, e1);
            empMap.Add(16, e1);
            
            Console.WriteLine("Count " + empMap.Count);
            Console.WriteLine("ContainsKey(5) " + empMap.ContainsKey(5));
            Console.WriteLine("ContainsKey(15) " + empMap.ContainsKey(15));
        }
        public static void TestSortedListA()
        {
            SortedList<int,int> slist = new SortedList<int, int>();
            int count = slist.Count;
            Console.WriteLine("Count " + count);
            Console.WriteLine(" Capacity " + slist.Capacity);
            Random r1 = new Random();
            for (int i = 0; i < 10; i++)
            {
                int x = r1.Next(100);
                if(!slist.ContainsKey(x))
                    slist.Add(x,(x*55));
                Console.Write(x + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Count " + slist.Count);
            Console.WriteLine(" Capacity " + slist.Capacity);

            foreach (var i in slist)
            {
                Console.WriteLine(i.Key + ","+i.Value);
            }
        }
        public static void TestSortedListB()
        {
            SortedList<String, int> slist = new SortedList<String, int>();
            int count = slist.Count;
            Console.WriteLine("Count " + count);
            Console.WriteLine(" Capacity " + slist.Capacity);
            Random r1 = new Random();
            for (int i = 0; i < 10; i++)
            {
                int x = r1.Next(100);
                if(!slist.ContainsKey("v" + x))
                    slist.Add("v" + x, (x*35));
                Console.Write(x + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Count " + slist.Count);
            Console.WriteLine(" Capacity " + slist.Capacity);

            foreach (var i in slist)
            {
                Console.WriteLine(i.Key + " : " + i.Value);
            }
        }
        public static void TestSortedListOfEmp()
        {
            SortedList<int, Emp> empsortlist = new SortedList<int, Emp>();
            Random r1 = new Random();
            Emp e1 = new Emp() { ID = r1.Next(100), Name = "John", Salary = r1.NextDouble() * 5000 };
            Emp e2 = new Emp() { ID = r1.Next(100), Name = "Sam", Salary = r1.NextDouble() * 5000 };
            Emp e3 = new Emp() { ID = r1.Next(100), Name = "Ajith", Salary = r1.NextDouble() * 5000 };
            Emp e4 = new Emp() {ID=r1.Next(100),Name="Ellango",Salary=r1.NextDouble()*5000 };
            Emp e5 = new Emp() {ID=r1.Next(100),Name="Basker",Salary=r1.NextDouble()*5000 };
            if (!empsortlist.ContainsKey(e1.ID))
                empsortlist.Add(e1.ID,e1);
            if (!empsortlist.ContainsKey(e2.ID))
                empsortlist.Add(e2.ID,e2);
            if (!empsortlist.ContainsKey(e3.ID))
                empsortlist.Add(e3.ID,e3);
            if (!empsortlist.ContainsKey(e4.ID))
                empsortlist.Add(e4.ID,e4);
            if (!empsortlist.ContainsKey(e5.ID))
                empsortlist.Add(e5.ID,e5);
            
            Console.WriteLine("Count " + empsortlist.Count);
            Console.WriteLine(" Capacity " + empsortlist.Capacity);

            foreach (var emp in empsortlist)
            {
                Console.WriteLine(emp.Key + " : " + emp.Value.Name );
            }
            Console.WriteLine("===================");
           var orderedlist= empsortlist.OrderBy(tkey => tkey.Value.Name);
            foreach (var emp in orderedlist)
            {
                Console.WriteLine(emp.Key + " : " + emp.Value.Name);
            }
            Console.WriteLine("===================");
            var desclist = empsortlist.OrderByDescending(tkey => tkey.Value.Name);
            foreach (var emp in desclist)
            {
                Console.WriteLine(emp.Key + " : " + emp.Value.Name);
            }
        }
    }
}
