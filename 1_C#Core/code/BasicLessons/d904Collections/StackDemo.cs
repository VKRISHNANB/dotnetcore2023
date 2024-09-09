using System;
using System.Collections;
namespace d94Collections
{ 
class StackDemo
{
        public static void DemoA()
        {
            Stack st = new Stack();
            Random r = new Random();
            int x = 0;
            st.Push(25);
            Console.Write(25+" " );
            for (int i = 0; i < 10; i++)
            {
                x = r.Next(100);
                st.Push(x);
                Console.Write(" " + x);
            }
            Console.WriteLine("");
            int count = st.Count;
            Console.WriteLine("Count=" + count);
            for (int i = 0; i < count; i++)
            {
                Console.Write(st.Peek() + " ");
                // Peek reads the first object in the queue 
                // without removing the object
            }

            Console.WriteLine("");
            count = st.Count;
            Console.WriteLine("Count After Peek =" + count);
            Console.WriteLine("Contains 25-" + st.Contains(25));
            for (int i = 0; i < 5; i++)
            {
                Console.Write(st.Pop() + " ");
            }
            Console.WriteLine("");
            count = st.Count;
            Console.WriteLine("Count After Pop=" + count);
        }

        private static void PrintValues(Stack s)
    {
        IEnumerator ie = s.GetEnumerator();
        while (ie.MoveNext())
        {
            Console.WriteLine("\t"+ ie.Current);
        }
    }

    public static void TestStackA()
    {
        Stack myStack = new Stack();
        myStack.Push("HCL");
        myStack.Push("Wipro");
        Console.Write("Total no of objects in the stack : ");
        Console.Write(myStack.Count);
        Console.Write("\nThe objects are: ");
        PrintValues(myStack);
        Console.WriteLine("\n Object no: 0\t    1");
        Console.Write("\nThe object at first is: ");
        Console.Write(myStack.Peek()); // returns the object without removing it
        Console.Write("\nThe removed object is: ");
        Console.Write(myStack.Pop());
        Console.Write("\nTotal remaining no of objects in the stack: ");
        Console.Write(myStack.Count);
        Console.Write("\nThe object is: ");
        PrintValues(myStack);
        Console.WriteLine("\nObject no \t: 0");
        myStack.Clear(); // Remove all the Objects
        myStack.Push("CTS");
        myStack.Push("Infosys");
        myStack.Push("Tcs");
        Console.Write("\nTotal no of NEW objects in the stack: ");
        Console.Write(myStack.Count);
        Console.Write("\nThe objects are: ");
        PrintValues(myStack);
        Console.WriteLine("\nObject no \t: a\t b\t c");
    }

    public static void UsingStackA()
    {
        Stack myStack = new Stack();
        myStack.Push("HCL");
        myStack.Push("Wipro");
        Console.Write("Total no of objects in the stack : ");
        int count = myStack.Count;
        Console.Write("Count "+count);
        Console.Write("\nThe objects are: ");
        for(int i=0;i<count;i++)
        {
            Console.WriteLine("\t"+myStack.Pop()+",");
        }
        count = myStack.Count;
        Console.Write("Count after POP " + count);
    }
    public static void UsingStackB()
    {
        Stack myStack = new Stack();
        myStack.Push("HCL");
        myStack.Push("Wipro");
        Console.Write("Total no of objects in the stack : ");
        int count = myStack.Count;
        Console.WriteLine("Count " + count);
        Console.WriteLine("\nThe objects are: ");
        //for (int i = 0; i < count; i++)
        //{
        //    Console.Write(myStack.Pop() + ",");
        //}
        IEnumerator ie = myStack.GetEnumerator();
        while (ie.MoveNext())
        {
            var s1 = ie.Current;
            Console.WriteLine("\t"+ s1);
        }
        count = myStack.Count;
        Console.WriteLine("Count after POP " + count);
    }
    public static void UsingStackC()
    {
        Stack myStack = new Stack();
        myStack.Push("HCL");
        myStack.Push("Wipro");
        Console.Write("Total no of objects in the stack : ");
        Console.WriteLine(myStack.Count);
        Console.WriteLine("The objects are: ");
        IEnumerator ie = myStack.GetEnumerator();
        while (ie.MoveNext())
        {
            var s1 = ie.Current;
            Console.WriteLine("\t" + s1);
        }

        Console.Write("The object at first is: ");
        Console.WriteLine(myStack.Peek()); // returns the object without removing it
        Console.Write("The removed object is: ");
        Console.WriteLine(myStack.Pop());
        Console.Write("Total remaining objects in the stack: ");
        Console.WriteLine(myStack.Count);
        Console.WriteLine("The objects are: ");
        ie = myStack.GetEnumerator();
        while (ie.MoveNext())
        {
            var s1 = ie.Current;
            Console.WriteLine("\t" + s1);
        }

        myStack.Clear(); // Remove all the Objects
        Console.Write("Total objects in stack After Clear : ");
        Console.WriteLine(myStack.Count);
        myStack.Push("CTS");
        myStack.Push("Infosys");
        myStack.Push("Tcs");
        Console.Write("Total NEW objects in the stack: ");
        Console.WriteLine(myStack.Count);
        Console.WriteLine("The objects are: ");
        ie = myStack.GetEnumerator();
        while (ie.MoveNext())
        {
            var s1 = ie.Current;
            Console.WriteLine("\t" + s1);
        }
    }
    public static void UsingStackD()
    {
        Stack myStack = new Stack();
        myStack.Push("HCL");
        myStack.Push("Wipro");
        Console.Write("Total no of objects in the stack : ");
        Console.WriteLine(myStack.Count);
        Console.WriteLine("The objects are: ");
        PrintValues(myStack);
        Console.Write("The object at first is: ");
        Console.WriteLine(myStack.Peek()); // returns the object without removing it
        Console.Write("The removed object is: ");
        Console.WriteLine(myStack.Pop());
        Console.Write("Total remaining objects in the stack: ");
        Console.WriteLine(myStack.Count);
        Console.WriteLine("The objects are: ");
        PrintValues(myStack);
        myStack.Clear(); // Remove all the Objects
        Console.Write("Total objects in stack After Clear : ");
        Console.WriteLine(myStack.Count);
        myStack.Push("CTS");
        myStack.Push("Infosys");
        myStack.Push("Tcs");
        Console.Write("Total NEW objects in the stack: ");
        Console.WriteLine(myStack.Count);
        Console.WriteLine("The objects are: ");
        PrintValues(myStack);
    }
  }
}