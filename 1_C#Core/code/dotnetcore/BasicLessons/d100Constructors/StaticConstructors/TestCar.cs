using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d4ClassesNMethods
{
    class TestCar
    {
        public static void M1()
        {
            Car.Start();
            Car.PetrolEngine.Start();
            Car.Start();
        }
        public static void M2()
        {
            Car c1;
            c1= new Car();
            Car c2 = new Car();
            Engine e1 = new Engine();
            Car c3 = new Car(e1);
        }
    }
}
