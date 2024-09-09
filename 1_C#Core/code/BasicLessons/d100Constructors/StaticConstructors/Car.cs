using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d4ClassesNMethods
{
    class Car
    {
        //static Field
        public static Engine PetrolEngine;

        static Car()// static constructor
        {
            Console.WriteLine("Static Block");
            PetrolEngine = new Engine();
        }
        //static Car(int x)// static constructor
        //{
        //    PetrolEngine = new Engine();
        //}

        // non static constructor
        public Car()
        {
            Console.WriteLine("Constructor ");
            PetrolEngine = new Engine();
        }
        public Car(Engine e)         {
            PetrolEngine = e;
        }
        public static void Start()
        {
            Console.WriteLine("Car. Start");
            if (PetrolEngine != null) PetrolEngine.Start();
            else
                Console.WriteLine("Engine Not Found");
        }
    }
}
