using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Festivals.Library;
namespace AspEfcoreapp
{
    public class FestivalController : Controller
    {
        public IActionResult Index()
        {     
            Demo_AddFestivalAndSweet();       
            List<Festival> festivalList=FestivalRepository.GetFestival();
            return View("ListFestivals",festivalList);
        }
        public  IActionResult Demo_AddOneFestival()
        {
            Festival f = new Festival
            {
                Name = "Tamil New year",
                Description = " Tamil Nadu celebrates the threshold of the spring season." +
                    " This event takes place during mid April.",
                FromDate = new DateTime(2020, 04, 13),
                ToDate = new DateTime(2020, 04, 13),
                NoOfDays = 1,
                Location = "Entire State",
                ReligionId=1                
            };
            FestivalRepository.AddFestival(f);
            FestivalRepository.GetFestival();
            return View();
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