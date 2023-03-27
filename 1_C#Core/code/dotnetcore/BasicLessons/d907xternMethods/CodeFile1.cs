using System;
namespace xtnMethodSampleA
{
public static class MyClassB
{
  public static void Display(this Car c, int speed)
  {
    c.Move();
    Console.WriteLine("Current Speed "+speed +" "+c.RegNo );
    //Console.WriteLine("Cost is "+c.cost  ); //Not Accesable 
    MyClassA.Move(c, speed);
  }
  public static String SayHello(this String str,  string name)
  {
    return "Hello " + name +" "+str ;
  }
  public static string SayHello(this Int32 str, string name)
  {
    return "Hello " + name;
  }
        //public static void Echo(this Car c,   //    String str)
        //{
        //  Console.WriteLine(c.RegNo + " Beep! Beep! From ClassB " + str);
        //}
    }
}