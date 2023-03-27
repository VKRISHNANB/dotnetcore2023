using System;
//Write a program to depict a bool value can control flow of a program?
 class boolEx 
  {
	 public static void main(String args)
 		{
 			bool b; 
			b = false; 
			Console.WriteLine("b is " + b); 
			b = true; 
			Console.WriteLine("b is " + b); 
			// a bool value can control the if statement 
			if(b) Console.WriteLine("This is executed."); 
			b = false; 
			if(b) Console.WriteLine("This is not executed."); 
			// outcome of a relational operator is a bool value 
			Console.WriteLine("10 > 9 is " + (10 > 9));
          } 
  } 
