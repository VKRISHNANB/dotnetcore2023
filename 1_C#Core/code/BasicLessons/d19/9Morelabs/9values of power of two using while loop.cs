using System;
//Write a program to display the values of power of two using while loop?
 class PowerValue 
 {
	 public static void main(String args)
 	{
 		int e; int result;
 		for(int i=0; i < 10; i++)
		{
		 result = 1; e = i;
 		while(e > 0)
  		{ 
 		result *= 2; e --; 
		}
		Console.WriteLine("2 to the power of " + i + " is " + result);
 		}
 	}
 }