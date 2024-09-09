using System;
using System.Collections.Generic;
public class GenericBox<T>
{
    T t1;
    List<T> dataListT = new List<T>();
  
    public void Add(T input)
    {
        Console.WriteLine("Type "+input.GetType().FullName);
        t1 = input;
        dataListT.Add(input);
    }
    public U Add<V,U>(V input1, U input2)
    {
        Console.WriteLine("Type of V " + input1.GetType().FullName);
        Console.WriteLine("Type of U " + input2.GetType().FullName);
        return input2;
    }
}
