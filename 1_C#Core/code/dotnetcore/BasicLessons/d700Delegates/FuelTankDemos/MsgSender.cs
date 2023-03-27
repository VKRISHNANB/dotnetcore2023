using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegateSample
{
    public class MsgSender//Event Handler / Observer
    {
        //on enter
        public void OnFull(FuelTankC ft, int lts)
        {
            Console.WriteLine("TankFull " + ft.CurrentLevel);
        }
        //on enter
        public void OnEmpty(FuelTankC ft, int lts)
        {
            Console.WriteLine("TankEmpty " + ft.CurrentLevel);
        }
        //on enter
        public void OnReserve(FuelTankC ft, int lts)
        {
            Console.WriteLine("ResLevel " + ft.CurrentLevel);
        }
        // do event
        public void OnChange(FuelTankC ft, int lts)
        {
            Console.WriteLine("LevelChanged " + ft.CurrentLevel);
        }
    }
}
