using System;
using System.Drawing;
using System.Collections;
class Application {
  public static void TestA() 
  {
    Application a1=new Application();
    Console.WriteLine(a1.GetHashCode());
    Console.WriteLine(a1.GetType().FullName);
    a1=null;
    Console.WriteLine("a1 Is Null " + (a1 == null));
     GC.Collect();

     //Image img = new Bitmap("MyProfile");
     //   int gen = GC.GetGeneration(img);
     //   if(img is IDisposable) img.Dispose();
     //   img = null;
     //  GC.Collect(gen);

    Console.ReadKey();
  }
  public static void TestB()
  {
      ArrayList myArray = new ArrayList();
      Console.WriteLine("Gen myArray: " + GC.GetGeneration(myArray));
      for (int x = 0; x < 100000; x++) {
              myArray.Add(new Object()); 
      }
      Array a=myArray.ToArray();
      object[] a1={1,2,3,4};
      Console.WriteLine("Gen myArray: " + GC.GetGeneration(myArray));
      Console.WriteLine("Gen a: " + GC.GetGeneration(a));
      Console.WriteLine("Gen a1: " + GC.GetGeneration(a1));
      Console.WriteLine("TotalMemory: "+GC.GetTotalMemory(false));      
      int i=a.Length;
      Console.WriteLine(i);
      Console.WriteLine("MaxGeneration :" + GC.MaxGeneration);
      Console.WriteLine("Gen myArray: " + GC.GetGeneration(myArray));
      Console.WriteLine("Gen a: " + GC.GetGeneration(a));
      Console.WriteLine("Gen a1: " + GC.GetGeneration(a1));
      a=null;
      myArray=null;
      GC.Collect();
      Console.WriteLine("AfterCollectTotalMemory: "+GC.GetTotalMemory(false));	
      Console.WriteLine("Gen a1: " + GC.GetGeneration(a1));
   }
  //  protected  void  ize() 
  //  {
  //     Console.WriteLine("In  ize."); 
  //  }

  ~Application()
  {
      Console.WriteLine("In  ize."); 
  }
}
