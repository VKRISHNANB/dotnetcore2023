//The preferred implementation is to use the CompareTo method of one of the parameters.

//Comparing null with any type is allowed and does not generate an exception when using IComparable. When sorting, null is considered to be less than any other object.

//In real world applications, usage of table-formatted data is so frequent and cannot be ignored. Many table views provide the sort button for each column. How can we do this? Do we need to pass a column name to the “Sort()” and somehow manage to pass the name to the “CompareTo()” method?

//C# provides an easy and flexible solution to this problem. You can create as many comparison logics as possible and pass each logic to the “Sort()” method.

//The key interface is “System.Collections.IComparer” and “System.Collections.Generic.IComparer<T>”.
//In this example, the IComparer interface is implemented using the CaseInsensitiveComparerclass to reverse the order of the contents of the ArrayList.

using System;
using System.Collections;

public class SamplesArrayList
{

    public class myReverserClass : IComparer
    {

        // Calls CaseInsensitiveComparer.Compare with the parameters reversed.
        int IComparer.Compare(Object x, Object y)
        {
            return ((new CaseInsensitiveComparer()).Compare(y, x));
        }

    }

    public static void TestA()
    {

        // Creates and initializes a new ArrayList.
        ArrayList myAL = new ArrayList();
        myAL.Add("The");
        myAL.Add("quick");
        myAL.Add("brown");
        myAL.Add("fox");
        myAL.Add("jumps");
        myAL.Add("over");
        myAL.Add("the");
        myAL.Add("lazy");
        myAL.Add("dog");

        // Displays the values of the ArrayList.
        Console.WriteLine("The ArrayList initially contains the following values:");
        PrintIndexAndValues(myAL);

        // Sorts the values of the ArrayList using the default comparer.
        myAL.Sort();
        Console.WriteLine("After sorting with the default comparer:");
        PrintIndexAndValues(myAL);

        // Sorts the values of the ArrayList using the reverse case-insensitive comparer.
        IComparer myComparer = new myReverserClass();
        myAL.Sort(myComparer);
        Console.WriteLine("After sorting with the reverse case-insensitive comparer:");
        PrintIndexAndValues(myAL);

    }

    public static void PrintIndexAndValues(IEnumerable myList)
    {
        int i = 0;
        foreach (Object obj in myList)
            Console.WriteLine("\t[{0}]:\t{1}", i++, obj);
        Console.WriteLine();
    }

}


/* 
This code produces the following output.
The ArrayList initially contains the following values:
        [0]:    The
        [1]:    quick
        [2]:    brown
        [3]:    fox
        [4]:    jumps
        [5]:    over
        [6]:    the
        [7]:    lazy
        [8]:    dog

After sorting with the default comparer:
        [0]:    brown
        [1]:    dog
        [2]:    fox
        [3]:    jumps
        [4]:    lazy
        [5]:    over
        [6]:    quick
        [7]:    the
        [8]:    The

After sorting with the reverse case-insensitive comparer:
        [0]:    the
        [1]:    The
        [2]:    quick
        [3]:    over
        [4]:    lazy
        [5]:    jumps
        [6]:    fox
        [7]:    dog
        [8]:    brown 
*/
