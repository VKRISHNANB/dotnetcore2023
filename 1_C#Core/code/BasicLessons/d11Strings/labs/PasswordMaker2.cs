using System;
public class PasswordMaker2
{
	public static void M1(String[] args)
	{
		if(null==args)
		{
			Console.WriteLine("Arguments not provided");
			Console.WriteLine("Provide Firstname Middlename Lastname age");
			return;
	   }
	   if(args.Length<4)
		{
				Console.WriteLine("Arguments must be as below");
				Console.WriteLine("java PasswordMaker2  Firstname Middlename Lastname age");
			return;
		}
		String fName=args[0];
		String mName=args[1];
		String lName=args[2];
		int age=int.Parse (args[3]);
		Console.WriteLine(fName+","+mName+","+lName+","+age);
		String result=""+getMiddleChar(fName);
		result+=getMiddleChar(mName);
		result+=getMiddleChar(lName);
      result+=(age*100);
      Console.WriteLine("Result "+result);
	}
	public static char getMiddleChar(String s)
	{
		int len=s.Length;
		int m=len/2;
		return s[m] ;
	}
}
