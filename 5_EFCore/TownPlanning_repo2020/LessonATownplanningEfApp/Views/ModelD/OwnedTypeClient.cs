using System;
using System.Collections.Generic;
using System.Text;
using LessonATownplanningEfApp.ModelDOwnedType;
namespace LessonATownplanningEfApp.Views.ModelD
{
    public class OwnedTypeClient
    {
        public static void Init()
        {
            /**
             * Create Database and Seed Data
             * */
            Demo_AddManyVillagesUsingList();
            DisplayAllVillages();
        }
        
        public static void DisplayAllVillages()
        {
            OwnedTypeRepository villageRepository = new OwnedTypeRepository();
            var villagelist = villageRepository.GetVillages();
            foreach (VillageD v in villagelist)
            {
                DisplayVillage(v);
                if (v.Residents != null)
                {
                    var peoples = v.Residents;
                    foreach (PersonD p in peoples)
                    {
                        DisplayPersonDetails(p);
                    }
                }
            }
        }
        private static void DisplayVillage(VillageD v)
        {
            System.Console.WriteLine($"{v.VillageDId}, {v.Name}, {v.City}, {v.Pincode}");
        }
        public static void DisplayAllPeople()
        {
            OwnedTypeRepository peopleRepository = new OwnedTypeRepository();
            var people = peopleRepository.GetPeople();
            foreach(var p in people)
            {
                DisplayPersonDetails(p);
            }
        }
        private static void DisplayPersonDetails(PersonD p)
        {
            Console.WriteLine($"{p.PersonDId}, {p.Name}, {p.DateOfBirth}");
            Address address = p.Address;
            if (address != null)
            {
                System.Console.WriteLine($"\tAddress: {address.FullAddress}");
            }
            else
                System.Console.WriteLine($"\tAddress: Address NOT Assigned");
            VillageD v = p.HomeTown;
            if (v != null)
            {
                System.Console.WriteLine($"\tVillage: {v.VillageDId}, {v.Name}, {v.City}, {v.Pincode}");
            }
            else
                System.Console.WriteLine($"\tVillage: Village NOT Assigned");
        }
       
        private static void Demo_AddManyVillagesUsingList()
        {
            #region MultipleVillages
            var Village1 = new VillageD
            {
                Name = "Village1",
                City = "Chennai",
                State = "TN",
                Pincode = 123456
            };
            var Village2 = new VillageD
            {
                Name = "Village2",
                City = "Chennai",
                State = "TN",
                Pincode = 123456
            };
            var Village3 = new VillageD
            {
                Name = "Village3",
                City = "Chennai",
                State = "TN",
                Pincode = 123456
            };
            var Village4 = new VillageD
            {
                Name = "Village4",
                City = "Chennai",
                State = "TN",
                Pincode = 123456
            };
            var Village5 = new VillageD
            {
                Name = "Village5",
                City = "Chennai",
                State = "TN",
                Pincode = 123456
            };

            var Village6 = new VillageD
            {
                Name = "Village6",
                City = "Chennai",
                State = "TN",
                Pincode = 123456
            };
            var Village7 = new VillageD
            {
                Name = "Village7",
                City = "Chennai",
                State = "TN",
                Pincode = 123456
            };
            var Village8 = new VillageD
            {
                Name = "Village8",
                City = "Chennai",
                State = "TN",
                Pincode = 123456
            };
            var Village9 = new VillageD
            {
                Name = "Village9",
                City = "Chennai",
                State = "TN",
                Pincode = 123456
            };
            var Village10 = new VillageD
            {
                Name = "Village10",
                City = "Chennai",
                State = "TN",
                Pincode = 123456
            };
            #endregion //MultipDleVillages
            #region List
            List<VillageD> VillageList = new List<VillageD>();
            VillageList.Add(Village1);
            VillageList.Add(Village2);
            VillageList.Add(Village3);
            VillageList.Add(Village4);
            VillageList.Add(Village5);
            VillageList.Add(Village6);
            VillageList.Add(Village7);
            VillageList.Add(Village8);
            VillageList.Add(Village9);
            VillageList.Add(Village10);
            #endregion //List
            OwnedTypeRepository villageRepository = new OwnedTypeRepository(true);
            villageRepository.AddMultipleVillages(VillageList);
        }
        public static void Demo_AddNewPersonWithAddress()
        {
            PersonD p = new PersonD
            {
                Name = "John" + new Random().Next(1, 100),
                DateOfBirth = DateTime.Now.AddYears(-new Random().Next(1, 30)),
                VillageId = 10,
                Address = new Address(                
                    doorNo : "1A",
                    flatName:"LakeView Apartments",
                    plotNo: "28",
                     streetName:"Lords Street"
                )
                //Address = new Address
                //{
                //   DoorNo= "1A",
                //    FlatName="LakeView Apartments", 
                //    PlotNo="28",
                //    StreetName="Lords Street" 
                //}
            };
            OwnedTypeRepository personRepo = new OwnedTypeRepository();
            personRepo.AddPerson(p);

        }
        public static void Demo_AddNewPersonWithOutAddress()
        {
            PersonD p = new PersonD
            {
                Name = "John" + new Random().Next(1, 100),
                DateOfBirth = DateTime.Now.AddYears(-new Random().Next(1, 30)),
                VillageId = 10
            };
            OwnedTypeRepository personRepo = new OwnedTypeRepository();
            personRepo.AddPerson(p);
            DisplayPersonDetails(p);

        }
        public static void Demo_UpdatePersonAddress()
        {
            OwnedTypeRepository personRepo = new OwnedTypeRepository();
            Console.WriteLine("Enter Person Id to Find");
            int id = int.Parse(Console.ReadLine());
            PersonD person = personRepo.FindPersonByID(id);
            Address address = person.Address;
            DisplayPersonDetails(person);
            if(address==null)
            {
                address = new Address(
                doorNo: "1000",
                flatName: "ABCD",
                plotNo : "2000",
                streetName : "Xyz"
              );
            }
            /** 
             * The dbContext does not track the references or new Objects 
             * The new Address Object must be added back to person Object
             * */
            person.Address = address;
            personRepo.SaveChangesToTrackedPerson(person);
            DisplayPersonDetails(person);
        }
    }
}
