using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TownplanningEfApp.Models;

namespace TownplanningEfApp.Views
{
    public class PersonClient
    {
        public static void DisplayAllPeople()
        {
            var peoplelist=PersonRepository.GetPeople();
            foreach(Person p in peoplelist)
            {
                Console.WriteLine($"{p.PersonId}, {p.Name}, {p.DateOfBirth}");
                AadhaarCard card=p.Aadhaar;
                if(card !=null)
                {
                    System.Console.WriteLine($"\tCardNo:{card.AadhaarNo}, IssuedOn:{card.DateOfIssue}, ValidTill:{card.ValidTill}");
                }
                Village v=p.HomeTown;
                if(v !=null)
                {
                    System.Console.WriteLine($"\tVillage:{v.VillageId}, {v.Name}, {v.City}, {v.Pincode}");
                }
                var role = p.Role;
                if (role != null)
                {
                    System.Console.WriteLine($"\tRole:{role.RoleTitle},{role.DateOfJoin}");
                }
                var assetList=p.Assets;
                foreach (var item in assetList)
                {
                    System.Console.WriteLine($"\tAssetId:{item.AssetID} Share:{item.OwnershipShare}  PlotNo:{item.Property.PlotNo} AssetType:{item.Property.Type} {item.Property.Description}");
                }
                
            }
        }
        public static void Demo_AddNewPersonWithoutChildren()
        {
            Console.WriteLine("Adding new Person without Children  ");
            Person p = new Person
            {
                Name = "John" + new Random().Next(1, 100),
                DateOfBirth = DateTime.Now.AddYears(-new Random().Next(1, 30)),
                VillageId = 10
            };
            PersonRepository.AddPerson(p);
            /**
             * Even though 
             */
        }
        public static void Demo_AddManyPeople()
        {
            List<Person> personList=new List<Person>();
            for(int i=1;i<15;i++)
            {
               Person person = new Person            
               { 
                    Name = "John"+new Random().Next(1,100),
                    DateOfBirth=DateTime.Now.AddYears(-new Random().Next(1,30)),                
                    VillageId=10
               };
                personList.Add(person);
            }
            PersonRepository.AddPeople(personList);           
        }
        public static void Demo_AddNewPersonWithAadhaarAndRole()
        {
            Console.WriteLine("Adding new Person with AadhaarCard and Role ");
            Person p = new Person
            {
                Name = "John" + new Random().Next(1, 100),
                DateOfBirth = DateTime.Now.AddYears(-new Random().Next(1, 30)),
                VillageId = 10
            };
            AadhaarCard card = new AadhaarCard
            {
                DateOfIssue = DateTime.Now,
                ValidTill = DateTime.Now.AddYears(50)
            };
            p.Aadhaar = card;
            Console.WriteLine("Enter Role ID");
            int roleid =int.Parse( Console.ReadLine());
            VillageAdministrationRole role = null;
            #region trackingrole
            using (TownPlanningContext dbContext = new TownPlanningContext())
            {
                using (RolesRepository rr = new RolesRepository(dbContext))
                {
                    role = rr.FindTrackingRoleByID(roleid);
                    if (role == null || role.InChargePerson != null)
                    {
                        Console.WriteLine("FAILED to ADD Role. Role not EMPTY");
                    }
                    else
                    {
                        role.DateOfJoin = DateTime.Now;
                        role.InChargePerson = p;                       
                    }
                    using (PersonRepositoryTracking personRepo = new PersonRepositoryTracking(dbContext))
                    {
                        p.Role = role;
                        personRepo.AddPerson(p);
                    }
                }
            }
            #endregion trackingrole
            
        }
        public static void Demo_AddAssetstoPerson(int personid)
        {
            Console.WriteLine("Adding Asset to Person");            
            Person persona=PersonRepository.FindPersonByID(personid);
            if(persona==null)
            {
                System.Console.WriteLine("\tPERSON NOT FOUND!!!");
            }
            AssetDetails assetdtls=new AssetDetails
            {
                AssetID=21,
                PersonId=persona.PersonId,
                OwnershipShare=80
            };
            persona.Assets=new List<AssetDetails>();
            persona.Assets.Add(assetdtls);
            PersonRepository.SaveAllTackingChanges();
            DisplayAllPeople();
        }
        public static void Demo_AddAadhaartoPerson(int personid)
        {
            Console.WriteLine("Adding AadhaarCard to Person");            
            Person persona=PersonRepository.FindPersonByID(personid);
            if(persona==null)
            {
                System.Console.WriteLine("\tPERSON NOT FOUND!!!");
            }
            AadhaarCard card=new AadhaarCard
            {
                DateOfIssue=DateTime.Now,
                ValidTill=DateTime.Now.AddYears(50)
            };
            persona.Aadhaar=card;
            PersonRepository.SaveAllTackingChanges();
            DisplayAllPeople();
        }   
    }
}