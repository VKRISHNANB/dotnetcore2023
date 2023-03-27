using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateSample
{
    class TestFuelTank
    {
        public static void M1()
        {
            FuelTankA f = new FuelTankA();//publisher
            try
            {
                f.FillFuel(10);// onChange
                f.WithdrawFuel(5); // OnChange
                f.WithdrawFuel(4); // OnChange, Reserve
                f.WithdrawFuel(1); // OnChange, Empty
                f.FillFuel(22);// OnChange, Full
            }
            catch (Exception err)
            {
                Console.WriteLine("ERROR!!! "+err.Message);
            }
            f.FillFuel(20);// OnChange, Full

        }
        public static void M2()
        {
            FuelTankB f = new FuelTankB();//publisher
            try
            {
                f.FillFuel(10);// onChange
                f.WithdrawFuel(5); // OnChange
                f.WithdrawFuel(4); // OnChange, Reserve
                f.WithdrawFuel(1); // OnChange, Empty
                f.FillFuel(22);// Exception
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
            f.FillFuel(20);// OnChange, Full
        }
        public static void M3()
        {
            FuelTankC f = new FuelTankC();//publisher
            MsgSender mc = new MsgSender(); // Observer
            f.OnChange += mc.OnChange;
            f.OnEmpty += mc.OnEmpty;
            f.OnFull += mc.OnChange;
            f.OnReserve += mc.OnChange;
            try
            {
                f.FillFuel(10);// onChange
                f.WithdrawFuel(5); // OnChange
                f.WithdrawFuel(4); // OnChange, Reserve
                f.WithdrawFuel(1); // OnChange, Empty
                f.FillFuel(22);// Exception
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
            f.FillFuel(20);// OnChange, Full
        }
    }
}
