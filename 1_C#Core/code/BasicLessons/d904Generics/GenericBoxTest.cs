using System;
class TestGenericBox
{
    public static void M1()
    {
        GenericBox<int> intList = new GenericBox<int>();// T-int
        intList.Add(100);

        int x=intList.Add<double, int>(100.5, 20);//V -double , U-int
        Console.WriteLine(x);

        long l= intList.Add<float, long>(5.98f, 2000000L); // V-float, U-long
        Console.WriteLine(l);
        //-------------------
        GenericBox<String> strList = new GenericBox<String>();// T- String
        strList.Add("Hello");
        char y = strList.Add<String, char>("HCL", 'A');//V-String, U-char
        Console.WriteLine(y);
    }

    public static void M3()
    {
        GenericBoxB<int,String,float> intList = new GenericBoxB<int, String, float>();
        intList.Add(100);
        //int x = intList.Add<float, String>(100.5f, "20");//U -double , V-int
        //Console.WriteLine(x);
        //long l = intList.Add<float, long>(5.98f, 2000000L); // U-float, V-long
        //Console.WriteLine(l);
        //String s = intList.Add<char,bool>(5.98f,"Hello",'A', true); // V-float, U-String
        //Console.WriteLine(l);
       
    }

    #region A
    private class ExampleClass { }
    static void M2()
    {
        // Declare a list of type int.
        GenericBox<int> list1 = new GenericBox<int>();
        list1.Add(1);

        // Declare a list of type string.
        GenericBox<string> list2 = new GenericBox<string>();
        list2.Add("");

        // Declare a list of type ExampleClass.
        GenericBox<ExampleClass> list3 = new GenericBox<ExampleClass>();
        list3.Add(new ExampleClass());
    }
    #endregion
}