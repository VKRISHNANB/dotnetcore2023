using System;
using Microsoft.Data.SqlClient;

namespace ConsoleDataApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection cn=new SqlConnection();
            Console.WriteLine("Hello World!");
            System.Console.WriteLine($"Connection State:{cn.State}");
        }
    }
}
