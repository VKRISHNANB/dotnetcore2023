using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSample
{
    class TestFuelTank
    {
        //Events
        public static void M1()
        {
            FuelTank f = new FuelTank();//publisher
            MsgCreater msg = new MsgCreater();//Eventhandler
            f.TankFull += msg.OnFull;
            f.TankEmpty += msg.OnEmpty;
            f.TankReserv += msg.OnReserve;
            f.Changed += msg.OnChange;
            try
            {
                f.FillFuel(10);// onChange
                f.UseFuel(5); // OnChange
                f.UseFuel(4); // OnChange, Reserve
                f.UseFuel(1); // OnChange, Empty
                f.FillFuel(20);// OnChange, Full
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }

    }
}
