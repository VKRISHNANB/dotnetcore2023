using System;
using System.Collections.Generic;

public class GenericBoxB<T,U,V>
{
    List<T> dataListT = new List<T>();
    List<U> dataListU = new List<U>();
    List<V> dataListV = new List<V>();
    public void Add(T input)
    {
        Console.WriteLine("Type "+input.GetType().FullName);
        dataListT.Add(input);
    }
    // DataType of V & U is not the same as the templates defined at the Class level
    public U Add<W,X>(V input1, U input2)
    {
        Console.WriteLine("Type of V " + input1.GetType().FullName);
        //dataListV.Add(input1);

        Console.WriteLine("Type of U " + input2.GetType().FullName);
        //dataListU.Add(input2);

        return input2;
    }
    public U Add<P,Q>(V input1, U input2,P input3, Q input4)
    {
        Console.WriteLine("Type of V " + input1.GetType().FullName);
        dataListV.Add(input1);
        Console.WriteLine("Type of U " + input2.GetType().FullName);
        dataListU.Add(input2);
        Console.WriteLine("Type of P " + input3.GetType().FullName);
        Console.WriteLine("Type of Q " + input4.GetType().FullName);
        return input2;
    }
}
