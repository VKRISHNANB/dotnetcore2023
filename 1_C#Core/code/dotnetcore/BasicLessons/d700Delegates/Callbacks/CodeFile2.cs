using System;
using System.IO;
namespace Sample.Delegates
{
    
//The calling class registers and calls class “B” as follows:
public class ProcessDelegate
{
    B objB = null;
    public void Process()
    {
        objB = new B();
        int i = 0;
        while (i <= 5)
        {
            objB.Callback += new Notify(CallMe);
            i++;
        }
        objB.Write(1);
    }
    public void CallMe(int Value)
    {
        Console.WriteLine(Value);
    }
}
}// end of namespace
