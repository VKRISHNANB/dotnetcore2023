using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Festivals.Library
{
    public class SweetRepository
    {
        // private static FestivalsDB _dbcontext = new FestivalsDB();
        
        // Tracking Changes by the Context
        public static void UpdateSweet_EntryState()
        {
            using (FestivalsDB newContext = new FestivalsDB())
            {
                // add using System.Linq for extended method FirstOrDefault();
                var sweet1 = newContext.Sweets.FirstOrDefault();
                Console.WriteLine("Has Changes Gefore Update " + newContext.ChangeTracker.HasChanges());
                Console.WriteLine("\t" + sweet1.Id + " " + sweet1.Name + " "+ sweet1.CookingTime + " State=" + newContext.Entry(sweet1).State);
                #region TrackingMultipleEntries
                //var entries = newContext.ChangeTracker.Entries<FoodDish>();
                //foreach (var e in entries)
                //{
                //    FoodDish fd = e.Entity;
                //    Console.WriteLine("\t" + fd.Id + " " + fd.Name + " State=" + e.State);
                //}
                #endregion
                sweet1.CookingTime += 30;
                Console.WriteLine("Has Changes Before Save " + newContext.ChangeTracker.HasChanges());
                Console.WriteLine("\t" + sweet1.Id + " " + sweet1.Name + " " + sweet1.CookingTime + " State=" + newContext.Entry(sweet1).State);
                int result = newContext.SaveChanges();
                Console.WriteLine("Update Result " + result);
                Console.WriteLine("Has Changes After Save " + newContext.ChangeTracker.HasChanges());
                Console.WriteLine("\t" + sweet1.Id + " " + sweet1.Name + " " + sweet1.CookingTime + " State=" + newContext.Entry(sweet1).State);
            }
        }      
        // Using Multiple Context
        public static void UpdateSweet_Disconnected()
        {
            FoodDish sweet = null;
            using (FestivalsDB dbcontextA = new FestivalsDB())
            {
                // add using Microsoft.EntityFrameworkCore for extended method AsNoTracking()
                // Get the Dish with out Tracking using contextA
                sweet = dbcontextA.Sweets.AsNoTracking().FirstOrDefault();
                Console.WriteLine(sweet.Id + " " + sweet.Name + " " + sweet.CookingTime);
                // Modify the value of a property in the sweet
                sweet.CookingTime += 30;
            }
            using (FestivalsDB newContext = new FestivalsDB())
            {
                Console.WriteLine("Has Changes Gefore Update " + newContext.ChangeTracker.HasChanges());
                newContext.Sweets.Update(sweet);
                Console.WriteLine("Has Changes Before Save " + newContext.ChangeTracker.HasChanges());
                var result = newContext.SaveChanges();
                Console.WriteLine("Update Result " + result);
                Console.WriteLine("Has Changes After Save " + newContext.ChangeTracker.HasChanges());
            }
            using (FestivalsDB dbcontextB = new FestivalsDB())
            {
                // Check if the changes are successfully updated
                sweet = dbcontextB.Sweets.AsNoTracking().FirstOrDefault();
                Console.WriteLine(sweet.Id + " " + sweet.Name + " " + sweet.CookingTime);
            }
        }
        // https://docs.microsoft.com/en-us/ef/core/what-is-new/ef-core-3.0/breaking-changes#fromsql-executesql-and-executesqlasync-have-been-renamed
        public static void UpdateUsingExecuteSqlRaw(FoodDish  s)
        {
            using (FestivalsDB context = new FestivalsDB())
            {
                String qry= "update Sweets set  CookingTime= {0} where DishType ={1} ";
                int result=context.Database.ExecuteSqlRaw(qry,s.CookingTime,s.DishType);
                Console.WriteLine("\t Updated Records "+result);
            }
        }
        public static void ExecuteSqlInterpolated(FoodDish s)
        {
            using (FestivalsDB context = new FestivalsDB())
            {
                FormattableString qry = $"update Sweets set  CookingTime= {s.CookingTime} where DishType ={s.DishType} ";
                int result=context.Database.ExecuteSqlInterpolated(qry);
                Console.WriteLine("\t Updated Records " + result);

            }
        }
    }
}
