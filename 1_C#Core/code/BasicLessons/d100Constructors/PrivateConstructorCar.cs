using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons
{
    public class Car
    {
        private Car()
        {
            Console.WriteLine("Private Constructor");
        }
        public static  Car CreateCarObject() //factory method
        {
            return new Car();
        }
        public void StartCar()
        {
            Console.WriteLine("Started");
        }
    }
}
