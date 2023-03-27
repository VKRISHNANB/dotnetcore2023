using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace TownplanningEfApp.Models
{
    public class VillageRepository
    {
        TownPlanningContext _dbcontext = null;
        public VillageRepository()
        {
            _dbcontext = new TownPlanningContext();
            Console.WriteLine("EnsureCreated: " + 
             _dbcontext.Database.EnsureCreated());
        }
        public  List<Village> GetVillages()
        {
            List<Village> villages;
             villages= _dbcontext.Villages.Include(r => r.Residents).ThenInclude(c => c.Aadhaar).ToList();              
             _dbcontext.Villages.Include(r => r.Residents).ThenInclude(c => c.Assets).ThenInclude(a=>a.Property).ToList();              
            return villages;
        }
        #region  Inserts
          //Adding a new entity to the context
        public  void AddVillage(Village f)
        {
            Console.WriteLine("Inserting a new Village");
              _dbcontext.Add(f);
              _dbcontext.Villages.Add(f);
            // or Another way to add a new entity to the context is to change its state to Added
            // _dbcontext.Villages.Attach(f);
            // _dbcontext.Entry(f).State = EntityState.Added;
               _dbcontext.SaveChanges();            
        }
       /**
        * Bulk Inserts
        * Bulk Operations are supported only with 4 or more Command Objects
        * For info on batch size limits see the following file
        * src/EFCore.SqlServer/Update/Internal/SqlServerModificationCommandBatch.cs
        */       
        public void AddMultipleVillages(params Object[] Villages)
        {
            /* Bulk Operations work only for 4 or more commands */
            _dbcontext.AddRange(Villages);
            var results = _dbcontext.SaveChanges();
            Console.WriteLine("Villages inserted " + results);
        }
        public void AddMultipleVillages(List<Village> VillageList)
        {
            _dbcontext.AddRange(VillageList);
            int results = _dbcontext.SaveChanges();
            Console.WriteLine("Villages inserted " + results);                
        }
        // Insert or update pattern
        public void InsertOrUpdate(Village f)
        {
            _dbcontext.Entry(f).State = f.VillageId == 0 ?
                                        EntityState.Added :
                                        EntityState.Modified;
            _dbcontext.SaveChanges();                
        }
        #endregion insert
        
        #region Queries
        public Village FindVillageByID(int id)
        {
            Console.WriteLine("Querying for Village by ID");
            Village village;
            village = _dbcontext.Villages.Find(id);                
            return village;
        }

        public void FindByNameUsingLike_NotParameterized()
        {
            Console.WriteLine("FindByNameUsingLike Query NotParameterized " );
            /**
                No Parameter is created in SQl if 
                search value is directly in Query
                    Where(s=> s.Name=="Sam")
            */
            var villages = _dbcontext.Villages
                            .Where(f=>f.Name == "Adayar")
                            .ToList();
            if (villages.Count()==0)
            {
                Console.WriteLine("Village Not Found" );
            }
            else
            {
                foreach (Village f in villages)
                {
                    Console.WriteLine(f.VillageId + " " + f.Name);
                }
            }
            /**
                Parameter is created in SQL 
                if search value is in a variable

                var name="Sam";
                Where(s=> s.Name==name)
            */
            Console.WriteLine("****FindByNameUsingLike Query WithParameterized " );

            String villagename="Adayar";
            // String villagename="Village1";
            villages = _dbcontext.Villages
                                .Where(f=>f.Name == villagename)
                                .ToList();
            if (villages.Count()==0)
            {
                Console.WriteLine("Village Not Found" );
            }
            else
            {
                foreach (Village f in villages)
                {
                    Console.WriteLine(f.VillageId + " " + f.Name);
                }
            }
        }
        // Filtering Partial Text LINQ
        public void FindByNameUsingLike(String name)
        {
                Console.WriteLine("FindByNameUsingLike " + name);
                var villages = _dbcontext.Villages.Where(
                    f => EF.Functions.Like(f.Name, name + "%")
                    ).ToList();
                if (villages.Count()==0)
                {
                    Console.WriteLine("Village Not Found" + name);
                    return;
                }
                foreach (Village f in villages)
                {
                    Console.WriteLine(f.VillageId + " " + f.Name);
                }
        }
        public void FindByNameUsingContains(String name)
        {
                Console.WriteLine("FindByNameUsingContains " + name);
                var villages = _dbcontext.Villages.Where(
                    f => f.Name.Contains(name)
                    ).ToList();
                if (villages.Count() == 0)
                {
                    Console.WriteLine("Village Not Found" + name);
                    return;
                }
                foreach (Village f in villages)
                {
                    Console.WriteLine(f.VillageId + " " + f.Name);
                }
        }
        public void GetVillageByCityFirstOrDefault(String city)
        {
                var village = _dbcontext.Villages
                                .OrderBy(i=>i.VillageId)
                                .FirstOrDefault(s => s.City == city);
                /**
                * SELECT TOP(1) [v].[VillageId], [v].[City], [v].[Name], [v].[Pincode], [v].[State]
                * FROM [Villages] AS [v]
                * WHERE [v].[City] = @__city_0
                */
                int id = village.VillageId;
                Console.WriteLine("FirstOrDefault:\n \tID={0} Name={1} City={2}",id,village.Name,village.City);
                #region DBSet.Find(Key)
                /**
                Will first search from the Change Tracker,
                if the key is found in the Change Tracker 
                then the entity is already available,
                and executes immediately, so unneeded database query can be avoided
                */
                var village1 = _dbcontext.Villages.Find(2); // Find(id)          
                Console.WriteLine("Loaded from Cache After Find\n \tID={0} Name={1} City={2}", village1.VillageId, village1.Name, village1.City);
                #endregion
                #region LastOrDefault
            //var lastNotOrdervillage = _dbcontext.Villages.LastOrDefault(s => s.Name == name);
                var lastvillage = _dbcontext.Villages
                                    .OrderBy(i=>i.VillageId)
                                    .LastOrDefault(s => s.City == city);
                Console.WriteLine("LastOrDefault\n \tID={0} Name={1} City={2}",
                                    lastvillage.VillageId, lastvillage.Name, lastvillage.City);
                /**
                SELECT TOP(1) [v].[VillageId], [v].[City], [v].[Name], [v].[Pincode], [v].[State]
                FROM [Villages] AS [v]
                WHERE [v].[City] = @__city_0
                ORDER BY [v].[VillageId] DESC            
                */
                #endregion
        }
        #endregion Queries
        #region SaveChanges
        /**
         * Getting the Entity State of the Model Object 
         * Tracked by the Context
         */
        public void SaveAllTackingChanges()
        {
                int result = _dbcontext.SaveChanges();
                Console.WriteLine("\t Updated Records " + result);
        }
        // Attaching an existing entity to the context
        /** 
        * If you have an entity that you know already 
        * exists in the database but 
        * which is not currently being tracked by the context 
        * then you can tell the context to track 
        * the entity using the Attach method on DbSet. 
        * The entity will be in the Unchanged state in the context. 
        **/
        public static void AttachVillageNotTracked(Village f)
        {
            using (TownPlanningContext _dbcontext=new TownPlanningContext())
            {
                Console.WriteLine("\tBefore Attach State=" + _dbcontext.Entry(f).State);
                _dbcontext.Villages.Attach(f);
                Console.WriteLine("\tAfter Attach State=" + _dbcontext.Entry(f).State);
                // if the Entity id is not provided while attaching 
                // then the entity will be added to the Context and will be Tracked
                _dbcontext.SaveChanges();
                /** 
                * no changes will be made to the database if SaveChanges is called without doing 
                * any other manipulation of the attached entity.
                * This is because the entity is in the Unchanged state.              
                */
                /** Important            
                * Calling Attach for an entity that is currently Tracked and in 
                * the Added or Modified state 
                * will change its state to Unchanged.
                * */
            }
        }
        /** 
        * If you have an entity that you know already exists in the database 
        * but to which changes may have been made then you can tell the context 
        * to attach the entity and set its state to Modified.   
        */
        public static void UpdateNotTrackedVillage_ByChangingEntityState(Village f)
        {
            using (TownPlanningContext _dbcontext=new TownPlanningContext())
            {
                _dbcontext.Villages.Attach(f);
                _dbcontext.Entry(f).State = EntityState.Modified;
                _dbcontext.SaveChanges();
            }
        }
        #endregion update
    }
}