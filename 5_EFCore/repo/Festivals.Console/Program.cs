using System;

namespace Festivals.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DemoA();
        }
        static void DemoA()
        {
            FestivalClient.ListAllFestivals();
            Console.WriteLine("================");
            FestivalClient.ListAllReligions();
            //FestivalClient.Demo_AddOneFestival();
            //FestivalClient.Demo_AddManyFestivalsWithoutBatch();
            //FestivalClient.Demo_AddManyFestivalsBatch();
            //FestivalClient.Demo_AddManyFestivalsUsingList();
            //FestivalClient.Demo_AddFestivalAndSweet();
            //FestivalClient.Demo_AddNewFestivalWithReligion();
            //FestivalClient.Demo_AddReligionToExistingFestival();
            //FestivalClient.Demo_FestivalsFilters();
            //FestivalClient.Demo_UpdateFestival();
            //FestivalClient.Demo_UpdateFestivalNotTracked();
            //FestivalClient.Demo_UpdateFestivalNotTracked();

            // Sweet
            //ClientSweets.Demo_TraceEntryStateOfSweetOnUpdate();
            //ClientSweets.Demo_UpdateSweet_Disconnected();
            //ClientSweets.Demo_UpdateSqlRaw();
            //ClientSweets.Demo_UpdateSqlInterpolated();

            // Temple
            //TempleClient.Demo_TempleDB();
        }

    }
}
