using System;
using System.IO;
//Write a program to swap the values of two variable without using Third Variable?
class Swapping 
 {
	public static void main(String[] args) { 
        TextReader input = Console.In;
		Console.WriteLine("Enter Number 1: ");
		int num1 =int.Parse( input.ReadLine());
		Console.WriteLine("Enter Number 2: ");
		int num2 = int.Parse(input.ReadLine());
		num1 = num1 + num2;
		num2 = num1 - num2;
		num1 = num1 - num2;
		Console.WriteLine("After swapping, num1= " + num1 + " and num2= " + num2);
 	}
}