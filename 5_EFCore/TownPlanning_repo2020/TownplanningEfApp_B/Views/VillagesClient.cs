using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TownplanningEfApp.Models;
namespace TownplanningEfApp.Views
{
    public class VillagesClient
    {
        public static void DisplayAllVillages()
        {
            VillageRepository villageRepository=new VillageRepository();
            var villagelist=villageRepository.GetVillages();
            foreach(Village v in villagelist)
            {
                System.Console.WriteLine($"{v.VillageId}, {v.Name}, {v.City}, {v.Pincode}");
                if(v.Residents !=null)
                {
                    var peoples=v.Residents;
                    foreach(Person p in peoples)
                    {
                        System.Console.WriteLine($"\t{p.PersonId}, {p.Name}, {p.DateOfBirth}, {p.Aadhaar.AadhaarNo}");
                        AadhaarCard card=p.Aadhaar;
                        if(card!=null)
                            System.Console.WriteLine($"\tNo:{card.AadhaarNo} IssuedOn:{card.DateOfIssue} ValidTill:{card.ValidTill}");
                        else
                            System.Console.WriteLine("\tCard not Found for "+p.PersonId);
                        var assets=p.Assets;
                        if (assets!=null)
                        {
                            foreach (var item in assets)
                            {
                                System.Console.WriteLine($"\tOwnerID:{item.PersonId} {item.Property.Description} Share:{item.OwnershipShare} PlotNO{item.Property.PlotNo}");
                            }
                        }
                        else
                            System.Console.WriteLine("\t NO ASSET for this person "+p.PersonId);
                    }
                }
            }
        }
        
        public static void Demo_AddOneVillage()
        {
            VillageRepository villageRepository=new VillageRepository();
            Village f = new Village
            {
                Name = "TNagar",
                City="Chennai",
                State="TN",
                Pincode=123456     
            };
            villageRepository.AddVillage(f);
        }
        // Adding many Records to the same Table
        public static void Demo_AddManyVillagesWithoutBatch()
        {
            #region MultipleVillages
            var Village1 = new Village
            {
                Name = "Village1",
                City="Chennai",
                State="TN",
                Pincode=123456     
            };
            var Village2 = new Village
            {
                Name = "Village2",
                City="Chennai",
                State="TN",
                Pincode=123456 
            };
            var Village3 = new Village
            {
                Name = "Village3",
                City="Chennai",
                State="TN",
                Pincode=123456 
            };
            #endregion //MultipleVillages
            VillageRepository villageRepository=new VillageRepository();
            villageRepository.AddMultipleVillages(Village1, Village2, Village3);
        }
        public static void Demo_AddManyVillagesBatch()
        {
            #region MultipleVillages
            var Village1 = new Village
            {
                Name = "Village4",
                City="Chennai",
                State="TN",
                Pincode=123456     
            };
            var Village2 = new Village
            {
                Name = "Village5",
                City="Chennai",
                State="TN",
                Pincode=123456     
            };
            var Village3 = new Village
            {
                 Name = "Village6",
                City="Chennai",
                State="TN",
                Pincode=123456     
            };
            var Village4 = new Village
            {
                Name = "Village7",
                City="Chennai",
                State="TN",
                Pincode=123456     
            };
            var Village5 = new Village
            {
                Name = "Village8",
                City="Chennai",
                State="TN",
                Pincode=123456     
            };
            #endregion //MultipleVillages
            VillageRepository villageRepository=new VillageRepository();            
            villageRepository.AddMultipleVillages(Village1, Village2, Village3, Village4, Village5);
        }
        public static void Demo_AddManyVillagesUsingList()
        {
            #region MultipleVillages
             var Village1 = new Village
            {
                Name = "Village9",
                City="Chennai",
                State="TN",
                Pincode=123456     
            };
            var Village2 = new Village
            {
                Name = "Village10",
                City="Chennai",
                State="TN",
                Pincode=123456     
            };
            var Village3 = new Village
            {
                 Name = "Village11",
                City="Chennai",
                State="TN",
                Pincode=123456     
            };
            var Village4 = new Village
            {
                Name = "Village12",
                City="Chennai",
                State="TN",
                Pincode=123456     
            };
            var Village5 = new Village
            {
                Name = "Village13",
                City="Chennai",
                State="TN",
                Pincode=123456     
            };
            #endregion //MultipleVillages
            #region List
            List<Village> VillageList = new List<Village>();
            VillageList.Add(Village1);
            VillageList.Add(Village2);
            VillageList.Add(Village3);
            VillageList.Add(Village4);
            VillageList.Add(Village5);
            #endregion //List
            VillageRepository villageRepository=new VillageRepository();
            villageRepository.AddMultipleVillages(VillageList);
        }
        // Adding Records to Multiple Tables
        public static void Demo_AddVillageAndPerson()
        {
            Console.WriteLine("Inserting a new Village");
            var Village1 = new Village
            {
                Name = "Melur",
                City="Madurai",
                State="TN",
                Pincode=987654                
            };
            AadhaarCard card=new AadhaarCard
            {
                DateOfIssue=DateTime.Now,
                ValidTill=DateTime.Now.AddYears(20)                
            };
            Person persona = new Person
            {
                Name = "Sam",
                DateOfBirth=DateTime.Now.AddYears(-25)
            };
            persona.Aadhaar=card;
            Village1.Residents=new List<Person>();
            Village1.Residents.Add(persona);
            VillageRepository villageRepository=new VillageRepository();
            villageRepository.AddVillage(Village1);
            DisplayAllVillages();
        }        
        public static void Demo_InsertOrUpdate()
        {
            Console.WriteLine("Insert Or Update Village");
            Village f = new Village
            {
                Name = "Adayar",
                City="Chennai",
                State="TN",
                Pincode=4444444     
            };
            VillageRepository villageRepository=new VillageRepository();
            villageRepository.InsertOrUpdate(f);
            Village f2 = new Village
            {
                VillageId=10,
                Name = "BesantNagar",
                City="Chennai",
                State="TN",
                Pincode=123456     
            };
            villageRepository.InsertOrUpdate(f2);
        }
        #region Queries
        public static void Demo_VillagesFilters()
        {
            VillageRepository villageRepository=new VillageRepository();
            //  villageRepository. FindByNameUsingLike_NotParameterized();
            //  System.Console.WriteLine("*****************");
            //  villageRepository.FindByNameUsingLike("M");
            //  System.Console.WriteLine("*****************");
            // villageRepository.FindByNameUsingContains("BesantNagar");
            //  System.Console.WriteLine("*****************");
            // villageRepository.FindByNameUsingContains("TNagar");
            // villageRepository.GetVillageByCityFirstOrDefault("Chennai");
        }
        #endregion
        #region Updates
        public static void Demo_UpdateVillage()
        {
            VillageRepository villageRepository=new VillageRepository();

            Village f=villageRepository.FindVillageByID(1);           
            f.Name = "Changed Village "+DateTime.Now.Minute;
            villageRepository.SaveAllTackingChanges();
        }
        public static void Demo_UpdateVillageNotTracked()
        {
            // New Village without primarykey value will be considered as a new Record
            Village f = new Village {
                 Name = "KRoad",
                City="Pune",
                State="MH",
                Pincode=123456     
            };
            VillageRepository villageRepository=new VillageRepository();

            villageRepository.AttachVillageNotTracked(f); // Insert will not Happen
            // villageRepository.SaveAllTackingChanges(); // Insert will be called
            // Existing Village data
            Village f1 = new Village
            {
                VillageId = 5,
                 Name = "AnnaNagar",
                City="Chennai",
                State="TN",
                Pincode=123456     
            };
            villageRepository.AttachVillageNotTracked(f1);
            // Will attach as unchanged data
            // // villageRepository.SaveAllTackingChanges(); // no changes but will now start to Track
            // f1.City += new DateTime(2020, 08, 21); // Entity State is Modified
            // f1.State += new DateTime(2020, 08, 21);
            // villageRepository.SaveAllTackingChanges(); // Update happens
        }
         public static void Demo_UpdateVillageNotTrackedByChangingEntityState()
         {
            Village f1 = new Village
            {
                VillageId = 50,
                 Name = "ThousandLights",
                City="Chennai",
                State="TN",
                Pincode=123456     
            };
         }
        #endregion
    }
}