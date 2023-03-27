using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegateSample
{
    public delegate void FuelLevelChangeHandler(FuelTankC ft,int lts);
    public class FuelTankC
    {
        public readonly int MaxLevel = 20;
        public readonly int ReserveLevel = 3;
        public int CurrentLevel = 0;

        public event FuelLevelChangeHandler OnChange;
        public event FuelLevelChangeHandler OnReserve;
        public event FuelLevelChangeHandler OnEmpty;
        public event FuelLevelChangeHandler OnFull;

        public void FillFuel(int lts)
        {
            if (0 >= lts) return;
            if (MaxLevel < (CurrentLevel + lts))
                throw new Exception("Tank Will Overflow");
            CurrentLevel += lts;
            if(OnChange != null)   OnChange(this, lts);
            if (MaxLevel == CurrentLevel)
            {
                if (OnFull != null) OnFull(this, lts);
            }
        }
        public void WithdrawFuel(int lts)
        {
            if (0 >= lts) return;
            if (CurrentLevel < lts)
                throw new Exception("Not enough Fuel");
            CurrentLevel -= lts;
            if (OnChange != null) OnChange(this, lts);

            if (ReserveLevel >= CurrentLevel)
            {
                if (OnReserve != null) OnReserve(this, lts);
            }
            if (0 == CurrentLevel)
            {
                if (OnEmpty != null)  OnEmpty(this, lts);
            }
        }
    }
}
