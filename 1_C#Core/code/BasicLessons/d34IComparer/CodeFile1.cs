//IComparable - Defines an interface for an object with a CompareTo() method 
// that takes another object of the same type and compares the current object 
// to the passed one.
// It internalizes the comparison to the object, 
// allowing for a more inline comparison operation, 
// and is useful when there's only one logical way, 
// or an overwhelmingly common default way, to compare objects of a type.

//IComparer - Defines an interface with a Compare() method 
// that takes two objects of another type(which don't have to implement IComparable) 
// and compares them. 
// This externalizes the comparison, and is useful when there are many 
// feasible ways to compare two objects of a type, or when the type doesn't implement IComparable (or the IComparable implementation compares a different way than what you want) and you don't have control over that type's source.
using System;
using System.Collections;

public class Temperature : IComparable
{
    // The temperature value
    protected double temperatureF;

    public int CompareTo(object obj)
    {
        if (obj == null) return 1;

        Temperature otherTemperature = obj as Temperature;
        if (otherTemperature != null)
            return this.temperatureF.CompareTo(otherTemperature.temperatureF);
        else
            throw new ArgumentException("Object is not a Temperature");
    }

    public double Fahrenheit
    {
        get
        {
            return this.temperatureF;
        }
        set
        {
            this.temperatureF = value;
        }
    }

    public double Celsius
    {
        get
        {
            return (this.temperatureF - 32) * (5.0 / 9);
        }
        set
        {
            this.temperatureF = (value * 9.0 / 5) + 32;
        }
    }
}

public class CompareTemperatures
{
    public static void M1()
    {
        ArrayList temperatures = new ArrayList();
        // Initialize random number generator.
        Random rnd = new Random();

        // Generate 10 temperatures between 0 and 100 randomly.
        for (int ctr = 1; ctr <= 10; ctr++)
        {
            int degrees = rnd.Next(0, 100);
            Temperature temp = new Temperature();
            temp.Fahrenheit = degrees;
            temperatures.Add(temp);
        }

        // Sort ArrayList.
        temperatures.Sort();

        foreach (Temperature temp in temperatures)
            Console.WriteLine(temp.Fahrenheit);

    }
}
// The example displays the following output to the console (individual
// values may vary because they are randomly generated):
//       2
//       7
//       16
//       17
//       31
//       37
//       58
//       66
//       72
//       95
