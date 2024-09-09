using System;
class RefSwap
{
    public int a, b;
    public RefSwap(int i, int j)
    {
        a = i;
        b = j;
    }
    public void Show()
    {
        Console.WriteLine("a: {0}, b: {1}", a, b);
    }
}
class RefSwapDemo
{
    //By Ref
    // This method changes its arguments.
    public static void SwapA(ref RefSwap ob1, ref RefSwap ob2)
    {
        RefSwap t = new RefSwap(0, 0);
        t = ob1;
        ob1 = ob2;
        ob2 = t;
    }
    //By Value
    public static void SwapB(RefSwap ob1, RefSwap ob2)
    {
        RefSwap t = new RefSwap(0, 0);
        t.a = ob1.a;
        t.b = ob1.b;
        ob1.a = ob2.a;
        ob1.b = ob2.b;
        ob2.a = t.a;
        ob2.b = t.b;
    }
    public static void TestRefSwapA()
    {
        RefSwap x = new RefSwap(1, 2);
        RefSwap y = new RefSwap(3, 4);
        Console.Write("x before call: ");
        x.Show();
        Console.Write("y before call: ");
        y.Show();
        Console.WriteLine();
        // Exchange the objects to which x and y refer.
        SwapA(ref x, ref y);
        Console.Write("x after call: ");
        x.Show();
        Console.Write("y after call: ");
        y.Show();
    }
    public static void TestRefSwapB()
    {
        RefSwap x = new RefSwap(1, 2);
        RefSwap y = new RefSwap(3, 4);
        Console.Write("x before call: ");
        x.Show();
        Console.Write("y before call: ");
        y.Show();
        Console.WriteLine();
        // Exchange the objects to which x and y refer.
        SwapB(x, y);
        Console.Write("x after call: ");
        x.Show();
        Console.Write("y after call: ");
        y.Show();
    }
}