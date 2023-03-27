using System;
using System.Reflection;
namespace BasicLessons.d94Reflections
{
    public class ReflextionDemoA
    {
        public static void M1()
        {
            string strName = "BasicLessons.exe";
            Assembly obja = Assembly.LoadFrom(strName);
            Type[] types = obja.GetTypes();
            foreach (Type t in types)
            {
                Console.WriteLine("\nType info for: " + t.FullName);
            }
            Type t1 = types[0];
            if (!t1.IsAbstract)
            {
                Console.WriteLine(t1.FullName );

                Object obj = Activator.CreateInstance(types[0]);
                Console.WriteLine(obj.GetHashCode());
            }
        }
    }
}