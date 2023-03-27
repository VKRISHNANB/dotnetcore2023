//Write a program to show the difference in the range of value of integer and double using Modulus operator.
using System;
class TestResult
 {
	 public static void main(String[] args)
	{
		 int iresult, irem; double dresult, drem;
 		 iresult = 10 / 3; 
		 irem = 10 % 3;
 		dresult = 10.0 / 3.0;
 		drem = 10.0 % 3.0;
		Console.WriteLine("Result and remainder of 10 / 3: " + iresult + " " + irem); 		
		Console.WriteLine("Result and remainder of 10.0 / 3.0: " + dresult + " " + drem);
	} 
 }