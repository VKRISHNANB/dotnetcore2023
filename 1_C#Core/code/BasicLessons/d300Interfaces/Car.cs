using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d7Interfaces
{
    //A class can Implement more than one interface
    //The class must override all the methods of the interface
    public class Car :IVehicle,IFliers 
    {
        public void Move()
        {
            Console.WriteLine("Car Move");
        }
        public void Start()
        {
            Console.WriteLine("Car Start");
        }
        public void Stop()
        {
            Console.WriteLine("Car Stop");
        }
        public void Turn()
        {
            Console.WriteLine("Car Turn");
        }
        public void Fly()
        {
            Console.WriteLine("Car Fly - Feeling like Harry Potter!!!");
        }
    }
}
