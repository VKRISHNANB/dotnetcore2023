using System;
using System.Collections.Generic;
using System.Text;
using Festivals.Library;

namespace Festivals.ConsoleApp
{
    class ClientSweets
    {
        public static void Demo_TraceEntryStateOfSweetOnUpdate()
        {
            SweetRepository.UpdateSweet_EntryState();
        }
        public static void Demo_UpdateSweet_Disconnected()
        {
            SweetRepository.UpdateSweet_Disconnected();
        }
        public static void Demo_UpdateSqlRaw()
        {
            FoodDish f = new FoodDish
            {
                CookingTime=45,DishType="Sweet"
            };
            SweetRepository.UpdateUsingExecuteSqlRaw(f);
        }
        public static void Demo_UpdateSqlInterpolated()
        {
            FoodDish f = new FoodDish
            {
                CookingTime = 60,
                DishType = "Payasam"
            };
            SweetRepository.ExecuteSqlInterpolated(f);
        }
    }
}
