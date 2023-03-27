using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegateSample
{
    public class FuelTankA
    {
        readonly int MaxLevel = 20;
        readonly int ReserveLevel = 3;
        int CurrentLevel = 0;
        public void FillFuel(int lts)
        {
            if (0 >= lts) return;
            if (MaxLevel < (CurrentLevel + lts))
                throw new Exception("Fuel Overflow");
            CurrentLevel += lts;
            Console.WriteLine("Changed");

            if (MaxLevel == CurrentLevel)
                Console.WriteLine("Full");
        }
        public void WithdrawFuel(int lts)
        {
            if (0 >= lts) return;
            if (CurrentLevel < lts)
                throw new Exception("Not enough Fuel");
            CurrentLevel -= lts;
            Console.WriteLine("Changed");
            if (ReserveLevel >= CurrentLevel)
               Console.WriteLine("Reserve");
            if (0 == CurrentLevel)
                Console.WriteLine("Empty");            
        }
    }
}
