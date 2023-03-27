using System;
public class ComparerExample
{
    public static void TestComparer()
    {
        String s1 = "A";// "anandh";
        String s2 = "B";// "Anandh";
        String s3 = "a";// "Anandh";
        String s4 = "A";// ;
        Console.WriteLine("s1={0}, s2={1}, Compare={2}", s1, s2, s1.CompareTo(s2));
        Console.WriteLine("s1={0}, s3={1}, Compare={2}", s1, s3, s1.CompareTo(s3));
        Console.WriteLine("s1={0}, s4={1}, Compare={2}", s1, s4, s1.CompareTo(s4));
        s1 = "tap";
        s2 = "pat";
        Console.WriteLine("s1={0}, s2={1}, Compare={2}", s1, s2, s1.CompareTo(s2));

    }
}