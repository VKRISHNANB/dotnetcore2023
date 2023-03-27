using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicLessons.d6Interfaces.Phones;
using BasicLessons.d7Interfaces;
namespace BasicLessons.d6Interfaces
{
    static class InterfacesDemo
    {
        public static void TestCar()
        {
            d7Interfaces.Car c1 = new d7Interfaces.Car();
            if (c1 is IVehicle)
            {
                Console.WriteLine("c1 is a Vehicle");
                c1.Start();
                c1.Move();
                c1.Turn();
                c1.Stop();
            }
            if (c1 is IFliers)
            {
                Console.WriteLine("c1 Can also Fly");
                c1.Fly();
            }
        }
        public static void TestPhone()
        {
            GalaxyA8 p1 = new GalaxyA8();
            if (p1 is IMobilePhone)// check if an object implements an interface
            {
                IMobilePhone m1 = p1;
                m1.AddContact();
                m1.MakeaCall();
                m1.SendSMS();
            }
            else
                Console.WriteLine("GalaxyA8 does not implement IMobilePhone");
        }
        public static void TestPhoneB(Object p1)
        {
            if (p1 is IMobilePhone)// check if an object implements an interface
            {
                IMobilePhone m1 =(IMobilePhone) p1;
                m1.AddContact();
                m1.MakeaCall();
                m1.SendSMS();
            }
            else
                Console.WriteLine("Object does not implement IMobilePhone");
        }
        public static void TestExpliciteImplementation()
        {
            MyClass c1 = new MyClass();
            c1.Fun1();
            IMyInterfaceA a1 = c1;
            Console.WriteLine("IMyInterfaceA.Fun2 " + a1.Fun2());
            IMyInterfaceB b1 = c1;
            Console.WriteLine("IMyInterfaceB.Fun2 " + b1.Fun2());
            //Console.WriteLine("c1.Fun2 " + c1.Fun2());
        }

        public static void TestA()
        {
            C objC = new C();
            A obj1 = null;
            obj1 = (A)objC;
            obj1.Call("Name");
            B obj2 = objC;
            obj2.Call(1);                
        }
    }
}
