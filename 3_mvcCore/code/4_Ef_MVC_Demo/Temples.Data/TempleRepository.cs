using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Temples.Data;
namespace Temples.Data
{
    public class TempleRepository
    {
        private static TempleDB _dbcontext = new TempleDB();
        public static void AddTemple(Temple t)
        {
            // Create
            Console.WriteLine("Inserting a new Temple");
            _dbcontext.Add(t);
            _dbcontext.SaveChanges();
        }
        public static void GetTemples()
        {
            // Read
            Console.WriteLine("Querying for Temples");
            var temples = _dbcontext.Temples.ToList();
            foreach (Temple t in temples)
            {
                Console.WriteLine(t.TempleId+ " " + t.Name);
            }
        }
    }
}
