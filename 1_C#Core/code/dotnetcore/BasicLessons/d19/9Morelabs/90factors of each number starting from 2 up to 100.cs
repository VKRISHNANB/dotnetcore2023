using System;
//Write a program to find factors of each number starting from 2 up to 100.?
 class FindFactor 
 { 
 	public static void main(String args)
	{
		 for(int i=2; i <= 100; i++) 
		{ 
		Console.WriteLine("Factors of " + i + ": "); 
		for(int j = 2; j < i; j++) 
		if((i%j) == 0) 
		Console.WriteLine(j + " ");
 		Console.WriteLine();
		} 
	}
}