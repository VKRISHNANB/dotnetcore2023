using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegateSample
{
    public class MsgCreater//Event Handler / Observer
    {
        //on enter
        public void OnFull(FuelTankB ft, int lts)
        {
            Console.WriteLine("TankFull " + ft.CurrentLevel);
        }
        //on enter
        public void OnEmpty(FuelTankB ft, int lts)
        {
            Console.WriteLine("TankEmpty " + ft.CurrentLevel);
        }
        //on enter
        public void OnReserve(FuelTankB ft, int lts)
        {
            Console.WriteLine("ResLevel " + ft.CurrentLevel);
        }
        // do event
        public void OnChange(FuelTankB ft, int lts)
        {
            Console.WriteLine("LevelChanged " + ft.CurrentLevel);
        }
    }
}
