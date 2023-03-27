using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventSample
{
    public class MsgCreater//Event Handler / Observer
    {
        public void OnFull(FuelTank ft, int lts)
        {
            Console.WriteLine("TankFull " + ft.CurrentLevel);
        }
        public void OnEmpty(FuelTank ft, int lts)
        {
            Console.WriteLine("TankEmpty " + ft.CurrentLevel);
        }
        public void OnReserve(FuelTank ft, int lts)
        {
            Console.WriteLine("ResLevel " + ft.CurrentLevel);
        }
        public void OnChange(FuelTank ft, int lts)
        {
            Console.WriteLine("LevelChanged " + ft.CurrentLevel);
        }
    }
}
