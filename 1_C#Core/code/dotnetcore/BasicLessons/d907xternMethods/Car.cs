using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xtnMethodSampleA
{
    public class Car
    {
        private int cost = 1000000;
        public string RegNo = "TN5R1234";
        public void Move()
        {
            Console.WriteLine("Car Started");
        }
         public void PrintCost()
        {
            Console.WriteLine("Car Cost="+cost);
        }
    }
}
