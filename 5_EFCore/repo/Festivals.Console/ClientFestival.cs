using System;
using System.Collections.Generic;
using System.Text;
using Festivals.Library;
using System.Linq;
namespace Festivals.ConsoleApp
{
    class FestivalClient
    {
        public static void ListAllFestivals()
        {
            FestivalRepository.GetFestival();
        }
        public static void ListAllReligions()
        {
            FestivalRepository.GetReligions();
        }
        
        #region Insert
        public static void Demo_AddOneFestival()
        {
            Festival f = new Festival
            {
                Name = "Tamil New year",
                Description = "Tamil puthu varusha pirappu (Tamil New Year)." +
                    " Tamil Nadu celebrates the threshold of the spring season." +
                    " The Sun appears from the 1st constellation Aries on this auspicious day." +
                    " People read their astrological prospects and offer prayers to their family deity." +
                    " This event takes place during mid April.",
                FromDate = new DateTime(2020, 04, 13),
                ToDate = new DateTime(2020, 04, 13),
                NoOfDays = 1,
                Location = "Entire State",
                ReligionId=1                
            };
            FestivalRepository.AddFestival(f);
            FestivalRepository.GetFestival();
        }
        // Adding many Records to the same Table
        public static void Demo_AddManyFestivalsWithoutBatch()
        {
            #region MultipleFestivals
            var festival1 = new Festival
            {
                Name = "Ekadasi",
                Description = "Recurring Monthly",
                FromDate = new DateTime(2020, 01, 1),
                ToDate = new DateTime(2020, 01, 1),
                NoOfDays = 1,
                Location = "Entire State",
                ReligionId = 1
            };
            var festival2 = new Festival
            {
                Name = "Vinayagar Chathurthu",
                Description = "Vinayagar Birthday",
                FromDate = new DateTime(2020, 01, 1),
                ToDate = new DateTime(2020, 01, 1),
                NoOfDays = 1,
                Location = "Entire State",
                ReligionId = 1
            };
            var festival3 = new Festival
            {
                Name = "Karthigai Deepam",
                Description = "Naragasuran Vadham",
                FromDate = new DateTime(2020, 01, 1),
                ToDate = new DateTime(2020, 01, 1),
                NoOfDays = 1,
                Location = "Entire State",
                ReligionId = 1
            };
            #endregion //MultipleFestivals
            FestivalRepository.AddMultipleFestivals(festival1, festival2, festival3);
            FestivalRepository.GetFestival();
        }
        public static void Demo_AddManyFestivalsBatch()
        {
            #region MultipleFestivals
            var festival1 = new Festival
            {
                Name = "Ekadasi",
                Description = "Recurring Monthly",
                FromDate = new DateTime(2020, 01, 1),
                ToDate = new DateTime(2020, 01, 1),
                NoOfDays = 1,
                Location = "Entire State",
                ReligionId = 1
            };
            var festival2 = new Festival
            {
                Name = "Vinayagar Chathurthu",
                Description = "Vinayagar Birthday",
                FromDate = new DateTime(2020, 01, 1),
                ToDate = new DateTime(2020, 01, 1),
                NoOfDays = 1,
                Location = "Entire State",
                ReligionId = 1
            };
            var festival3 = new Festival
            {
                Name = "Karthigai Deepam",
                Description = "Naragasuran Vadham",
                FromDate = new DateTime(2020, 01, 1),
                ToDate = new DateTime(2020, 01, 1),
                NoOfDays = 1,
                Location = "Entire State",
                ReligionId = 1
            };
            var festival4 = new Festival
            {
                Name = "ThiruValluvar Day",
                Description = "Thiruvalluvar Birthday",
                FromDate = new DateTime(2020, 01, 1),
                ToDate = new DateTime(2020, 01, 1),
                NoOfDays = 1,
                Location = "Entire State",
                ReligionId = 1
            };
            var festival5 = new Festival
            {
                Name = "Mattu Pongal",
                Description = "Thanks day for Cows",
                FromDate = new DateTime(2020, 01, 1),
                ToDate = new DateTime(2020, 01, 1),
                NoOfDays = 1,
                Location = "Entire State",
                ReligionId = 1
            };
            #endregion //MultipleFestivals
            FestivalRepository.AddMultipleFestivals(festival1, festival2, festival3, festival4, festival5);
            FestivalRepository.GetFestival();
        }
        public static void Demo_AddManyFestivalsUsingList()
        {
            #region MultipleFestivals
            var festival1 = new Festival
            {
                Name = "Ekadasi",
                Description = "Recurring Monthly",
                FromDate = new DateTime(2020, 01, 1),
                ToDate = new DateTime(2020, 01, 1),
                NoOfDays = 1,
                Location = "Entire State",
                ReligionId = 1
            };
            var festival2 = new Festival
            {
                Name = "Vinayagar Chathurthu",
                Description = "Vinayagar Birthday",
                FromDate = new DateTime(2020, 01, 1),
                ToDate = new DateTime(2020, 01, 1),
                NoOfDays = 1,
                Location = "Entire State",
                ReligionId = 1
            };
            var festival3 = new Festival
            {
                Name = "Karthigai Deepam",
                Description = "Naragasuran Vadham",
                FromDate = new DateTime(2020, 01, 1),
                ToDate = new DateTime(2020, 01, 1),
                NoOfDays = 1,
                Location = "Entire State",
                ReligionId = 1
            };
            var festival4 = new Festival
            {
                Name = "ThiruValluvar Day",
                Description = "Thiruvalluvar Birthday",
                FromDate = new DateTime(2020, 01, 1),
                ToDate = new DateTime(2020, 01, 1),
                NoOfDays = 1,
                Location = "Entire State",
                ReligionId = 1
            };
            var festival5 = new Festival
            {
                Name = "Mattu Pongal",
                Description = "Thanks day for Cows",
                FromDate = new DateTime(2020, 01, 1),
                ToDate = new DateTime(2020, 01, 1),
                NoOfDays = 1,
                Location = "Entire State",
                ReligionId = 1
            };
            #endregion //MultipleFestivals
            #region List
            List<Festival> festivalList = new List<Festival>();
            festivalList.Add(festival1);
            festivalList.Add(festival2);
            festivalList.Add(festival3);
            festivalList.Add(festival4);
            festivalList.Add(festival5);
            #endregion //List
            FestivalRepository.AddMultipleFestivals(festivalList);
            FestivalRepository.GetFestival();
        }
        // Adding Records to Multiple Tables
        public static void Demo_AddFestivalAndSweet()
        {
            FestivalRepository.AddFestivalAndSweet();
            FestivalRepository.GetFestival();
        }
        // Inserting Related Data Parent and Child Records using Navigation Property
        public static void Demo_AddNewFestivalWithReligion()
        {
            Festival f = new Festival
            {
                Name = "New Festival for testing",
                Description = "Demo_ing",
                FromDate = new DateTime(2020, 04, 13),
                ToDate = new DateTime(2020, 04, 13),
                NoOfDays = 1,
                Location = "Entire State",
                Religion= new Religion
                {
                    Description = "Abcd",
                    Name = "Abcd"
                }
        };
            FestivalRepository.AddFestival(f);
        }
        // Insert new related data (children) to existing master (Parent)
        public static void Demo_AddReligionToExistingFestival()
        {
            Festival f = FestivalRepository.FindFestivalByID(3);
            f.Religion = new Religion
            {
                Description = "Efgh",
                Name = "Efgh"
            };
            FestivalRepository.SaveAllTackingChanges();
        }
        #endregion
        #region Queries
        public static void Demo_FestivalsFilters()
        {
            //FestivalRepository.FindByNameUsingLikeNotParameterized();
            //FestivalRepository.FindByNameUsingLike("Pon");
            //FestivalRepository.FindByNameUsingContains("Pon");
            // FestivalRepository.FindByNameUsingContains("Pongal");

            FestivalRepository.GetSweetsByDishTypeFIrstOrDefault("NotSweet");
        }
        #endregion

        #region Updates
        public static void Demo_UpdateFestival()
        {
            Festival f=FestivalRepository.FindFestivalByID(1);           
            f.Name = "Changed Festival "+DateTime.Now.Minute;
            FestivalRepository.SaveAllTackingChanges();
        }
        public static void Demo_UpdateFestivalNotTracked()
        {
            // New Festival without primarykey value will be considered as a new Record
            Festival f = new Festival {
                Name = "Vinayagar Chathurthu",
                Description = "Vinayagar Birthday",
                FromDate = new DateTime(2020, 12, 21),
                ToDate = new DateTime(2020, 12, 21),
                NoOfDays = 1,
                Location = "Entire State",
                ReligionId = 1
            };
            FestivalRepository.AttachFestivalNotTracked(f);
            FestivalRepository.SaveAllTackingChanges(); // Insert will be called
            // Existing Festival data
            Festival f1 = new Festival
            {
                FestivalId = 5,
                Name = "Vinayagar Chathurthu",
                Description = "Vinayagar Birthday",
                FromDate = new DateTime(2020, 11, 21),
                ToDate = new DateTime(2020, 11, 21),
                NoOfDays = 1,
                Location = "Entire State",
                ReligionId = 1
            };
            FestivalRepository.AttachFestivalNotTracked(f1);
            // Will attach as unchanged data
            FestivalRepository.SaveAllTackingChanges(); // no changes but will now start to Track
            f1.FromDate = new DateTime(2020, 08, 21); // Entity State is Modified
            f1.ToDate = new DateTime(2020, 08, 21);
            FestivalRepository.SaveAllTackingChanges(); // Update happens
        }
        #endregion
    }
}
