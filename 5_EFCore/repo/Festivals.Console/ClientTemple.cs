using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Temples.Data;
namespace Festivals.ConsoleApp
{
    class TempleClient
    {
        public static void Demo_TempleDB()
        {
            Temple t = new Temple
            {
                Name = "Kovil",
                Description = "Kovil",
                Location = "Chennai"
            };
            TempleRepository.AddTemple(t);
            TempleRepository.GetTemples();
        }
    }
}
