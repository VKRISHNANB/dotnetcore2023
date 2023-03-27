using System;
public struct Person
{
    public int Id;
    //public String Name=String.Empty;
    //public String City = String.Empty;
    public String Name ;
    public String City ;
    //public Person()
    //{
    //    Id = 0;Name = String.Empty;City = String.Empty;
    //}
    public Person(int x)
    {
        Id = x; Name = String.Empty; City = String.Empty;
    }
    public Person(int x,String sname,String scity)
    {
        Id = x; Name = sname; City = scity;
    }
    public void Echo()
    {
        Console.WriteLine("{0} ,{1}, {2}",Id,Name,City);
    }
}