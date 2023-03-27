using System;
namespace BasicLessons.d6Interfaces.Phones
{
    
    class GalaxyA8 : IMobilePhone
    {
        public void MakeaCall()
        {
            Console.WriteLine("Make a call");
        }
        public void SendSMS()
        {
            Console.WriteLine("Send a SMS");
        }
        public void AddContact()
        {
            Console.WriteLine("Adding contact");
        }
    }
}