using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d5Enum
{
    class TestEnum
    {
        public static void M1()
        {
            Employee e1 = new Employee(348);
            //e1.eid = 123;
            e1.ename = "John";
            e1.ecity = City.Banglore; //ecity = "Chennai";
            e1.desgn = Designation.Developer;//edept = "Testing";
        }
        public static void M2()
        {
            string name = String.Empty;// To avoid NullPointer Exception
            Type t1 = null;
            t1 = typeof(DayOfWeek);
            String[] enumNames = Enum.GetNames(t1);
            int len = enumNames.Length;
            for (int i = 0; i < len; i++)
            {
                //name = Enum.GetName(t1, i);
                name = enumNames[i];
                Console.Write(name + " ");
            }
            foreach (String s1 in enumNames)
            {
                Console.Write(s1 + " ");
            }
            Console.WriteLine();
            t1 = typeof(Designation);
            len = Enum.GetNames(t1).Length;
            for (int i = 0; i < len; i++)
            {
                name = Enum.GetName(t1, i);
                Console.Write(name + " ");
            }
        }
        public static void M3()
        {
            Console.WriteLine("Enter City Chennai|Banglore|Hyderabad");
            String strValue = Console.ReadLine();
            bool isValidCity = false;
            if (strValue == null || strValue == String.Empty)
            {
                Console.WriteLine("Value Required");
                System.Threading.Thread.Sleep(1000);
                return;
            }
            if (strValue.Equals("Chennai"))
            {
                isValidCity = true;
            }
            else if (strValue.Equals("Banglore"))
            {
                isValidCity = true;
            }
            else if (strValue.Equals("Hyderabad"))
            {
                isValidCity = true;
            }
            else
            {
                Console.WriteLine("IN VALID CITY!!!");
                System.Threading.Thread.Sleep(1000);
                return;
            }
            if (isValidCity)
            {
                Type t1 = typeof(City);
                City eCity = (City)Enum.Parse(t1, strValue);
                Console.WriteLine(eCity.ToString() + " " + (int)eCity);
            }
        }
       
         public static void TestMovieRating()
        {
            Type t1 = typeof(MovieRating);
            String[] enumNames = Enum.GetNames(t1);
            String name = String.Empty;
            int len = enumNames.Length;
            for (int i = 0; i < len; i++)
            {
                name = enumNames[i];
                MovieRating movies = (MovieRating)Enum.Parse(t1, name);
                Console.WriteLine(name + " " + (int)movies);
            }
        }
         public static void TestDeserts()
        {
            Type t1 = typeof(Deserts);
            String[] enumNames = Enum.GetNames(t1);
            String name = String.Empty;
            int len = enumNames.Length;
            for (int i = 0; i < len; i++)
            {
                name = enumNames[i];
                Deserts d = (Deserts)Enum.Parse(t1, name);
                Console.WriteLine(name + " " + (int)d);
            }
        }
         public static void TestPets()
        {
            Type t1 = typeof(Pets);
            String[] enumNames = Enum.GetNames(t1);
            String name = String.Empty;
            int len = enumNames.Length;
            for (int i = 0; i < len; i++)
            {
                name = enumNames[i];
                Pets myPet = (Pets)Enum.Parse(t1, name);
                Console.WriteLine(name + " " + (int)myPet);
            }
        }
        private static void TestStringEnum()
        {
            Console.Write("This is almost like an enum.", LogCategory.Info);
        }
    }
}
