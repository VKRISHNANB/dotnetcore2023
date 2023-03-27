using System;

namespace FirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.ReadLine();
        }
        public static void Firstmethod()
        {
            //ADO.AdoSQLConnectedClient.FindByID(1);
            Console.WriteLine("Enter FName");
            String fname = Console.ReadLine();
            Console.WriteLine("Enter LName");
            String lname = Console.ReadLine();
            ADO.AdoSQLConnectedClient.Add(fname, lname);
            ADO.AdoSQLConnectedClient.GetAllEmployees();
        }
    }
}
