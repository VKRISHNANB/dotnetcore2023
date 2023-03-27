//Write a program to display the difference in precision of the different data types?
using System; 
class PrecisionEx
 {
	 public static void main(String[] args)
	{
		 int var; // this declares an int variable
		double x; // this declares a floating-point variable 
		var = 10; // assign var the value 10
 		x = 10.0; // assign x the value 10.0
 		Console.WriteLine("Original value of var: " + var);
 		Console.WriteLine("Original value of x: " + x);
 		Console.WriteLine(); // print a blank line 
		// now, divide both by 4 
		var = var / 4; 
		x = x / 4; 
		Console.WriteLine("var after division: " + var); 
		Console.WriteLine("x after division: " + x);
	}
}