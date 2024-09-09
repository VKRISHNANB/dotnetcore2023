using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d4ClassesNMethods
{
    public class Car
    {
        //static Field
        public static Engine PetrolEngine;

        static Car()// static constructor
        {
            Console.WriteLine("Static Block");
            PetrolEngine = new Engine();
        }
        /* **
C# does not allow parameterized static constructors. This is a fundamental limitation of the language design. Let me explain why and provide some additional context:

Static Constructor Definition:
A static constructor in C# is used to initialize any static data or perform a particular action that needs to occur only once for a class. It is called automatically before any static members are referenced or any instance of the class is created.
Syntax and Limitations:

A static constructor does not take any parameters.
It cannot be called directly; it's invoked by the runtime.
A class can have only one static constructor.
Reason for No Parameters:
The main reason static constructors can't have parameters is that there's no way to pass arguments to them. They are called automatically by the runtime, not by user code.
        */
        // static Car(int x)// static constructor
        // {
        //     PetrolEngine = new Engine();
        // }

        // non static constructor
        public Car()
        {
            Console.WriteLine("Constructor ");
            PetrolEngine = new Engine();
        }
        public Car(Engine e)
        {
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
