using System;
public struct Person
{
    public int Id;
    public String Name;
    //public Person()
    //{
    //    Id = 0;
    //    Name = "Not Assigned";
    //}
    public Person(int x)
    {
        Id = x;
        Name = String.Empty;
    }
    public Person(int x, String s)
    {
        Id = x;
        Name = s;
    }
    public void Echo()
    {
        Console.WriteLine("{0}, {1}",Id,Name);
    }
    public override bool Equals(object obj)
    {
        bool flag = false;
        Person otherPerson;
        if(obj.GetType()== typeof(Person))
        {
            otherPerson = (Person)obj;
            if(this.Id==otherPerson.Id && this.Name==otherPerson.Name)
            {
                flag = true;
            }
        }
        else
        {
            Console.WriteLine("ERROR!!! The Object is not A Person Type");
        }
        return flag;
    }
    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
}