using System;
//Write a program which creates a sort of truth table to show the behavior of all the logical operators?
 class LogicTable
 { 
	public static void main(String args)
	{
	 	bool p, q; 
 		Console.WriteLine("P\tQ\tPANDQ\tPORQ\tPXORQ\tNOTP");
		 p = true; q = true; 
		 Console.WriteLine(p + "\t" + q +"\t"); 
 		Console.WriteLine((p&q) + "\t" + (p|q) + "\t"); 
 		Console.WriteLine((p^q) + "\t" + (!p));
 		p = true; q = false;
 		Console.WriteLine(p + "\t" + q +"\t"); 
 		Console.WriteLine((p&q) + "\t" + (p|q) + "\t");
 		Console.WriteLine((p^q) + "\t" + (!p));
 		p = false; q = true;
 		Console.WriteLine(p + "\t" + q +"\t");
 		Console.WriteLine((p&q) + "\t" + (p|q) + "\t"); 
 		Console.WriteLine((p^q) + "\t" + (!p));
		 p = false; q = false; 
		 Console.WriteLine(p + "\t" + q +"\t"); 
 		Console.WriteLine((p&q) + "\t" + (p|q) + "\t");
 		Console.WriteLine((p^q) + "\t" + (!p));
 	}
 }