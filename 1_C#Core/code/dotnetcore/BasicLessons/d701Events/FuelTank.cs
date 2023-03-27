using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventSample
{
    public delegate void FuelIndicator(FuelTank ft,int lts);

    public class FuelTank
    {
         readonly int MaxLevel = 20;
         readonly int ReserveLevel = 3;
         public int CurrentLevel = 0;
        //events
         public event FuelIndicator TankFull;
         public event FuelIndicator TankReserv;
         public event FuelIndicator TankEmpty;
         public event FuelIndicator Changed;

        public void FillFuel(int lts) 
        {
            if (0 >= lts) return;
            if(MaxLevel<(CurrentLevel+lts ))
                throw new Exception("Fuel Overflow");

            CurrentLevel += lts;
            if(Changed!=null)
                Changed(this, lts);//raise event
            if (MaxLevel == CurrentLevel)
                if(TankFull!=null)TankFull(this, lts);//raise event
        }

        public void UseFuel(int lts)
        {
            if (0 >= lts)  return;
            if (CurrentLevel < lts)
                throw new Exception("Not enough Fuel");
            CurrentLevel -= lts;
            if (Changed != null) Changed(this, lts);//Raise Event
            if (0 == CurrentLevel)
            {   if (TankEmpty != null) TankEmpty(this, lts);//Raise Event
            }
            else if (ReserveLevel >= CurrentLevel)
            {       if (TankReserv != null) TankReserv(this, lts);//Raise Event 
            }           
        }
    } 
}
