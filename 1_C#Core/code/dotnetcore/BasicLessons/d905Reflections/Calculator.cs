using System;
namespace BasicLessons.d94Reflections
{ 
    public class Calculator
    {
	    public Calculator(){}
	    public double Add(int x,int y)
        {
		    Console.WriteLine("Add called " );
		    return x+y;
	     }
        public double Divide(int x, int y)
        {
            Console.WriteLine("Divide called ");
            return x / y;
        }
        public double Multiply(int x, int y)
        {
            Console.WriteLine("Multiply called ");
            return x * y;
        }
        public double Subtract(int x, int y)
        {
            Console.WriteLine("Subtract called ");
            return x - y;
        }
    }
}