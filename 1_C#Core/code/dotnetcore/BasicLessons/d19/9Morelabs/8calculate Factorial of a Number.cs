using System;
//Write a program to calculate Factorial of a Number?
 class Factorial
 { 
	public static void main(String args)
	{
 		int sum = 0;
		 int fact = 1;
 		// compute the factorial of the numbers through 5 
		for(int i = 1; i <= 5; i++)
		{
 		sum += i;
 		// i is known throughout the loop
		 fact *= i; 
		}
		Console.WriteLine("Sum is " + sum);
 		Console.WriteLine("Factorial is " + fact);
	 } 
 }