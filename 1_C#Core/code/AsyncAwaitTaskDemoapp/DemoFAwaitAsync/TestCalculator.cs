using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncAwaitTaskDemoapp
{
    public class TestCalculator
    {
        public static void TestA()
        {
            int await=200;
            Calculator c1=new Calculator();
            System.Console.WriteLine(await+" Result "+c1.Add(100,20,30,40));
        }
        public static async Task TestB()
        {
            Calculator c1=new Calculator();
            // int await=200;
            int answer=await c1.AddAsync(100,20,30,40);

            System.Console.WriteLine("Result "+answer);
            if(answer%2==0)
                System.Console.WriteLine("Answer is an EVEN No");
            else
                System.Console.WriteLine("Answer is NOT an EVEN No");
            System.Console.WriteLine("Working with TASk is FUN");
        }
    }
}