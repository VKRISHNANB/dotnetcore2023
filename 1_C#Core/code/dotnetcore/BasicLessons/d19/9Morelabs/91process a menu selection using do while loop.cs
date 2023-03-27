using System;
//Write a program to process a menu selection using do..while loop?
 class DoWhileEx
 {
 	public static void main(String[] args) 	{
		 char choice; 
		do
		 { 
			Console.WriteLine("Syntax of:");
 			Console.WriteLine(" 1. if");
 			Console.WriteLine(" 2. switch"); 
 			Console.WriteLine(" 3. for"); 
 			Console.WriteLine(" 4. while");
 			Console.WriteLine(" 5. do-while\n"); 
 			Console.WriteLine("Choose one: "); 
			do
			{
				choice = (char) Console.In.Read();
			}while(choice == '\n' | choice == '\r');

		} while( choice < '1' | choice > '5');
		Console.WriteLine("\n");
		switch(choice)
 		{
 			case '1': 
 			Console.WriteLine("The if:\n");
 			Console.WriteLine("if(condition) statement;");
			Console.WriteLine("else statement;"); 
			break; 
			case '2':
 			Console.WriteLine("The switch:\n");
 			Console.WriteLine("switch(expression) {");
 			Console.WriteLine(" case constant:");
 			Console.WriteLine(" statement sequence");
 			Console.WriteLine(" break;");
 			Console.WriteLine(" // ...");
 			Console.WriteLine("}");
 			break;
 			case '3': 
 			Console.WriteLine("The for:\n");  
 			Console.WriteLine("for(init; condition; iteration)");
 			Console.WriteLine(" statement;");
 			break; 
			case '4': 
			Console.WriteLine("The while:\n"); 
		Console.WriteLine("while(condition) statement;");
		break; 
		case '5': 
		Console.WriteLine("The do-while:\n"); 
		Console.WriteLine("do {");
		Console.WriteLine(" statement;");
		Console.WriteLine("} while (condition);");
		break;
		} 
	}
}