using System;
using System.Reflection;
public class AssemblyLoader
{
    public static void LoadAssembly()
    {
        AppDomain d1 = AppDomain.CurrentDomain;
        Console.WriteLine("Domain :" + d1.FriendlyName);
        Assembly[] assemblies = d1.GetAssemblies();
        foreach (Assembly am in assemblies)
        {
            Console.WriteLine("Assembly :" + am.FullName);

            Console.WriteLine("Enter an Assembly Full Name");
            String assemblyName = Console.ReadLine();

            //      Assembly a =d1.Load(assemblyName);
            //if(null==a)
            //{
            //  Console.WriteLine("Assembly Not Loaded");
            //  return;
            //  }
            //Console.WriteLine("Assembly Name="+a.FullName);
            Console.WriteLine("Enter a Type Full Name");
            String tName = Console.ReadLine();
            Object o = d1.CreateInstance(am.FullName, tName);//.Unwrap();
            if (null == o)
            {
                Console.WriteLine("Object Not Loaded");
                return;
            }

            Console.WriteLine("Object Loaded=" + o.GetHashCode());
            Type t1 = o.GetType();
            if (null == t1)
            {
                Console.WriteLine("type Not Loaded");
                return;
            }
            Console.WriteLine("TypeName=" + t1.Name);
        }
    }
}
