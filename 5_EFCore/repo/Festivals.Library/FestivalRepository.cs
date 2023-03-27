using System;
using System.Collections.Generic;
using System.Text;
using Festivals.Library;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Festivals.Library
{
    public class FestivalRepository
    {
        private static FestivalsDB _dbcontext=new FestivalsDB();
        static FestivalRepository()
        {
          Console.WriteLine("EnsureCreated: " + _dbcontext.Database.EnsureCreated());
        }
        #region Insert
        //Adding a new entity to the context
        public static void AddFestival(Festival f)
        {
            Console.WriteLine("Inserting a new Festival");
            _dbcontext.Add(f);
            //or Another way to add a new entity to the context is to change its state to Added
            //context.Entry(f).State = EntityState.Added;
            _dbcontext.SaveChanges();
        }
       /**
        * Bulk Inserts
        * Bulk Operations are supported only with 4 or more Command Objects
        * For info on batch size limits see the following file
        * src/EFCore.SqlServer/Update/Internal/SqlServerModificationCommandBatch.cs
        */       
        public static void AddMultipleFestivals(params Object[] festivals)
        {
            /* Bulk Operations work only for 4 or more commands */
            _dbcontext.AddRange(festivals);
            var results = _dbcontext.SaveChanges();
            Console.WriteLine("Festivals inserted " + results);
        }
        public static void AddMultipleFestivals(List<Festival> festivalList)
        {
            _dbcontext.AddRange(festivalList);
            int results = _dbcontext.SaveChanges();
            Console.WriteLine("Festivals inserted " + results);
        }
        // Insert into multiple tables      
        public static void AddFestivalAndSweet()
        {
            Console.WriteLine("Inserting a new Festival");
            var festival1 = new Festival
            {
                Name = "Easter",
                Description = "Recurring Monthly",
                FromDate = new DateTime(2020, 01, 1),
                ToDate = new DateTime(2020, 01, 1),
                NoOfDays = 1,
                Location = "Entire State",
                ReligionId=1
            };
            FoodDish sweet1 = new FoodDish
            {
                Name = "Cake",
                DishType = "Sweet",
                CookingTime=30,CookingMethod="Buy from Cake Shop and serve",
                
            };

            _dbcontext.AddRange(festival1,sweet1);
            _dbcontext.SaveChanges();
        }
        
        
        // Insert or update pattern
        public void InsertOrUpdate(Festival f)
        {
            _dbcontext.Entry(f).State = f.FestivalId == 0 ?
                                        EntityState.Added :
                                        EntityState.Modified;
            _dbcontext.SaveChanges();           
        }
        #endregion insert
        #region Queries
        public static void GetReligions()
        {
            Console.WriteLine("Querying for Religions");
            var religions = _dbcontext.Religions.Include(f=>f.Festivals).ToList();
            foreach (Religion religion in religions)
            {
                Console.WriteLine($"{religion.Name} {religion.Description}");
                var festivals = religion.Festivals;
                if (festivals != null)
                {
                    foreach (Festival f in festivals)
                    {
                        Console.WriteLine("\t"+f.FestivalId + " " + f.Name + " " + f.ReligionId);
                    }
                }
                else
                    Console.WriteLine($"\tfestivals Not found");
            }
        }
        public static void GetFestival()
        {
            Console.WriteLine("Querying for Festivals");
            var festivals = _dbcontext.Festivals.Include(r => r.Religion).ToList();
            foreach (Festival f in festivals)
            {
                Console.WriteLine(f.FestivalId + " " + f.Name+" "+f.ReligionId);
                var religion = f.Religion;
                if(religion!=null)
                    Console.WriteLine(  $"\t{religion.Name} {religion.Description}");
                else
                    Console.WriteLine($"\t{f.ReligionId} Religion Not found");

            }
        }
        public static Festival FindFestivalByID(int id)
        {
            Console.WriteLine("Querying for Festival by ID");
            var festival = _dbcontext.Festivals.Find(id);
            if (festival == null) festival = _dbcontext.Festivals.FirstOrDefault();
            Console.WriteLine("\t"+ festival.FestivalId + " " + festival.Name + " " + festival.ReligionId + " " + festival.Description);
            return festival;
        }

        // Filtering Partial Text LINQ
        public static void FindByNameUsingLikeNotParameterized()
        {
            Console.WriteLine("FindByNameUsingLikeNotParameterized ");
            var festivals = _dbcontext.Festivals.Where(
               f => EF.Functions.Like(f.Name, "Pon%")
               ).ToList();
            if (festivals.Count() == 0)
            {
                Console.WriteLine("Festival Pon Not Found");
                return;
            }
            foreach (Festival f in festivals)
            {
                Console.WriteLine(f.FestivalId + " " + f.Name);
            }
        }
        public static void FindByNameUsingLike(String name)
        {
            Console.WriteLine("FindByNameUsingLike " + name);
            var festivals = _dbcontext.Festivals.Where(
                f => EF.Functions.Like(f.Name, name + "%")
                ).ToList();
            if (festivals.Count()==0)
            {
                Console.WriteLine("Festival Not Found" + name);
                return;
            }
            foreach (Festival f in festivals)
            {
                Console.WriteLine(f.FestivalId + " " + f.Name);
            }
        }
        public static void FindByNameUsingContains(String name)
        {
            Console.WriteLine("FindByNameUsingContains " + name);
            var festivals = _dbcontext.Festivals.Where(
                f => f.Name.Contains(name)
                ).ToList();
            if (festivals.Count() == 0)
            {
                Console.WriteLine("Festival Not Found" + name);
                return;
            }
            foreach (Festival f in festivals)
            {
                Console.WriteLine(f.FestivalId + " " + f.Name);
            }
        }
        public static void GetSweetsByDishTypeFIrstOrDefault(String name)
        {
            var sweet = _dbcontext.Sweets.FirstOrDefault(s => s.DishType == name);
            /**
             SELECT TOP(1) [s].[Id], [s].[CookingMethod], [s].[CookingTime], 
             [s].[DishType], [s].[Name]
             FROM[Sweets] AS[s] WHERE[s].[DishType] = @__name_0
            */
            int id = sweet.Id;
            Console.WriteLine("ID={0} Name={1} Duration={2}",id,sweet.Name,sweet.CookingTime+" "+sweet.DishType);
            #region DBSet.Find(Key)
            /**
             Will first search from the Change Tracker,
             if the key is found in the Change Tracker then the entity is already available,
             and executes immediately, so unneeded database query can be avoided
             */
            var sweet1 = _dbcontext.Sweets.Find(id);
           
            Console.WriteLine("After Find ID={0} Name={1} Duration={2}", sweet1.Id, sweet1.Name, sweet1.CookingTime);
            #endregion
            #region LastOrDefault
            //var lastNoOrdersweet = _dbcontext.Sweets.LastOrDefault(s => s.Name == name);
            var lastsweet = _dbcontext.Sweets.OrderBy(i=>i.Id).LastOrDefault(s => s.DishType == name);
            Console.WriteLine("ID={0} Name={1} Duration={2}", lastsweet.Id, lastsweet.Name, lastsweet.CookingTime);
            /**
             * SELECT TOP(1) [s].[Id], [s].[CookingMethod], [s].[CookingTime], 
             * [s].[DishType], [s].[Name]
             * FROM[Sweets] AS[s] WHERE[s].[DishType] = @__name_0
             * ORDER BY[s].[Id] DESC
            */
        #endregion
        }
        #endregion Queries
        #region SaveChanges
        // Getting the Entity State of the Model Object Tracked by the Context
        public static void SaveAllTackingChanges()
        {
            int result = _dbcontext.SaveChanges();
            Console.WriteLine("\t Updated Records " + result);

        }
        // Attaching an existing entity to the context
        /** If you have an entity that you know already exists in the database but 
        * which is not currently being tracked by the context 
        * then you can tell the context to track the entity using the Attach method on DbSet. 
        * The entity will be in the Unchanged state in the context. 
        */
        public static void AttachFestivalNotTracked(Festival f)
        {
            Console.WriteLine("\tBefore Attach State=" + _dbcontext.Entry(f).State);
            _dbcontext.Festivals.Attach(f);
            Console.WriteLine("\tAfter Attach State=" + _dbcontext.Entry(f).State);
            // if the Entity id is not provided while attaching 
            // then the entity will be added to the Context and will be Tracked
            // _dbcontext.SaveChanges();
            /** 
             * no changes will be made to the database if SaveChanges is called without doing 
             * any other manipulation of the attached entity.
             * This is because the entity is in the Unchanged state.              
             */
            /** Important            
             * Calling Attach for an entity that is currently Tracked and in the Added or Modified state 
             * will change its state to Unchanged.
             * */
        }
        /** 
        * If you have an entity that you know already exists in the database 
        * but to which changes may have been made then you can tell the context 
        * to attach the entity and set its state to Modified.   
        */
        public static void UpdateNotTrackedFestival_ByChangingEntityState(Festival f)
        {
            _dbcontext.Entry(f).State = EntityState.Modified;
            _dbcontext.SaveChanges();
        }
        #endregion update
    }
}
