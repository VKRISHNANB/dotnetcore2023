using System;
public class QueryType
 {
   public static void M1()
   {
        Type t,t1,t2,t3;
        String tName = "System.Int32";
        t = Type.GetType(tName);
        System.Console.WriteLine("Your integer object type is:"+t.FullName);

        t1=10.GetType();    // Integer DataType
        string s ="Hello December";     //  Assign string
        byte b =0111;          // Byte DataType
        t2=s.GetType(); 
        t3=b.GetType();
        System.Console.WriteLine(t1.FullName);
        System.Console.WriteLine(t2.FullName);
        System.Console.WriteLine(t3.FullName);
    }
 }