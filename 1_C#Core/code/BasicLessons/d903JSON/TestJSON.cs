using System;
using System.Threading.Tasks;

public class TestJSON
{
     static  void TestJsonReaderSample()
        {
           try{
                BasicLessons.JsonReaderSample.DemoA.TaskA();
            Console.WriteLine("....Over....");
           }catch(Exception err){
               Console.WriteLine(err.Message);
               Console.WriteLine(err.StackTrace);
           }
        }
        static  async Task TestJsonReaderSample(string[] args)
        {
        //    try{
        //        await BasicLessons.JsonReaderSample.DemoA.TaskB();
        //     Console.WriteLine("....Over....");
        //    }catch(Exception err){
        //        Console.WriteLine(err.Message);
        //        Console.WriteLine(err.StackTrace);
        //    }
            await BasicLessons.JsonReaderSample.DemoA.TaskB();

        }

}