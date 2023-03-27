using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TownplanningEfApp.ModelB;
namespace TownplanningEfApp.Views.ModelB
{   
    public class VillagesClientB
    {
        private static void DisplayVillage(Village v)
        {
            System.Console.WriteLine($"{v.VillageId}, {v.Name}, {v.City}, {v.Pincode}");
        }
        public static void DisplayAllVillages()
        {
            VillageRepository villageRepository=new VillageRepository();
            var villagelist=villageRepository.GetVillages();
            foreach(Village v in villagelist)
            {
                DisplayVillage(v);
                if (v.Residents !=null)
                {
                    var peoples=v.Residents;
                    foreach(Person p in peoples)
                    {
                        PersonClientB.DisplayPersonDetails(p);
                    }
                }
            }
        }

        public static void Init()
        {
            /**
             * Create Database and Seed Data
             * */
            Demo_AddManyVillagesUsingList();
            List<VillageAdministrationRole> rolelist = new List<VillageAdministrationRole>();
            for (int i = 65; i < 75; i++)
            {
                VillageAdministrationRole role = new VillageAdministrationRole()
                {
                    RoleTitle = "Role" + (char)i,
                };
                rolelist.Add(role);
            }
            RolesRepository.AddRoles(rolelist);

        }
        
        public static void Demo_AddManyVillagesUsingList()
        {
            #region MultipleVillages
            var Village1 = new Village
            {
                Name = "Village1",
                City = "Chennai",
                State = "TN",
                Pincode = 123456
            };
            var Village2 = new Village
            {
                Name = "Village2",
                City = "Chennai",
                State = "TN",
                Pincode = 123456
            };
            var Village3 = new Village
            {
                Name = "Village3",
                City = "Chennai",
                State = "TN",
                Pincode = 123456
            };
            var Village4 = new Village
            {
                Name = "Village4",
                City = "Chennai",
                State = "TN",
                Pincode = 123456
            };
            var Village5 = new Village
            {
                Name = "Village5",
                City = "Chennai",
                State = "TN",
                Pincode = 123456
            };

            var Village6 = new Village
            {
                Name = "Village6",
                City = "Chennai",
                State = "TN",
                Pincode = 123456
            };
            var Village7 = new Village
            {
                Name = "Village7",
                City = "Chennai",
                State = "TN",
                Pincode = 123456
            };
            var Village8 = new Village
            {
                Name = "Village8",
                City = "Chennai",
                State = "TN",
                Pincode = 123456
            };
            var Village9 = new Village
            {
                Name = "Village9",
                City = "Chennai",
                State = "TN",
                Pincode = 123456
            };
            var Village10 = new Village
            {
                Name = "Village10",
                City = "Chennai",
                State = "TN",
                Pincode = 123456
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
    }
}