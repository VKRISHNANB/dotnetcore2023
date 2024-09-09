using System;
//Write a program to prevent division by zero using Ternary Operator (?:).
  class PreventZeroDiv
 { 
	public static void main(String args)
 	{
		for(int i = -5; i < 6; i++)
 		if(i != 0 ? true : false)
		Console.WriteLine("100 / " + i + " is " + 100 / i); 
	} 
  }