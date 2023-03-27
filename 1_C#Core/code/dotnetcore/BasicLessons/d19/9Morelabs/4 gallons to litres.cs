using System;
//Write a program to convert gallons to litres?
class GallonToLitre 
  {
	public static void main(String args) 
 		{
			double gallons; // holds the number of gallons
			double liters; // holds conversion to liters
			gallons = 10; // start with 10 gallons
			liters = gallons * 3.7854; // convert to liters
			Console.WriteLine(gallons + " gallons is " + liters + " liters.");
		}
  }