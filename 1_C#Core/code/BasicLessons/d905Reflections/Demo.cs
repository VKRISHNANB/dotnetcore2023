using System;
using System.Reflection;
namespace BasicLessons.d94Reflections
{
    public class ReflectionDemo
    {
        public static void QueryTypeMembersDemoA(String s1)
        {
            Type t = Type.GetType(s1);
            Console.WriteLine(" Type..." + t.FullName);
            MethodInfo[] methods = t.GetMethods();
            foreach (MethodInfo m in methods)
            {
                if (m != null)
                {
                    Console.WriteLine(" method..." + m.Name);
                    ParameterInfo[] pa = m.GetParameters();
                    foreach (ParameterInfo p in pa)
                    {
                        if (p != null)
                        {
                            Console.Write("\t Param..." + p.Name);
                            Console.WriteLine("\t Type..." + p.ParameterType.FullName);
                        }
                    }
                }
            }// end of Foreach
        }// end of Method
        public static void QueryTypeMembersDemoB(String s1)
        {
            //Assembly a = Assembly.LoadFrom(s1);
            //Type[] types = a.GetTypes();
            //foreach (Type t in types)
            //{
                Type t = Type.GetType(s1);
                Console.WriteLine(" Type..." + t.FullName);
                MethodInfo[] methods = t.GetMethods();
                foreach (MethodInfo m in methods)
                {
                    if (m != null)
                    {
                        Console.WriteLine(" method..." + m.Name);
                        ParameterInfo[] pa = m.GetParameters();
                        foreach (ParameterInfo p in pa)
                        {
                            if (p != null)
                            {
                                Console.Write("\t Param..." + p.Name);
                                Console.WriteLine(" Type..." + p.ParameterType.FullName);
                            }
                        }
                        //if ("Add" == m.Name)
                        //{
                        //    if (t.IsClass && !t.IsAbstract)
                        //    {
                        //        object o = Activator.CreateInstance(t);
                        //        object[] param = { 10, 2 };
                        //        String result = m.Invoke(o, param).ToString();
                        //        Console.WriteLine("result " + result);
                        //    }
                        //}
                        //else
                        //{
                        //    Console.WriteLine(" Method Not Found");
                        //}
                    }
                    
                }
            //} // end of Foreach
        }
    }
}