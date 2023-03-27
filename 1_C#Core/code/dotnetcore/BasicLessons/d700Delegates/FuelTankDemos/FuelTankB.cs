using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegateSample
{
    public class FuelTankB
    {
        public readonly int MaxLevel = 20;
        public readonly int ReserveLevel = 3;
        public int CurrentLevel = 0;

        public void FillFuel(int lts)
        {
            MsgCreater mc = new MsgCreater();
            if (0 >= lts) return;
            if (MaxLevel < (CurrentLevel + lts))
                throw new Exception("Tank Will Overflow");
            CurrentLevel += lts;
            mc.OnChange(this, lts);
            if (MaxLevel == CurrentLevel)
                mc.OnFull(this, lts);
        }
        public void WithdrawFuel(int lts)
        {
            MsgCreater mc = new MsgCreater();

            if (0 >= lts) return;
            if (CurrentLevel < lts)
                throw new Exception("Not enough Fuel");
            CurrentLevel -= lts;
            mc.OnChange(this, lts);

            if (ReserveLevel >= CurrentLevel)
                mc.OnReserve(this, lts);
            if (0 == CurrentLevel)
                mc.OnEmpty(this, lts);
        }
    }
}
