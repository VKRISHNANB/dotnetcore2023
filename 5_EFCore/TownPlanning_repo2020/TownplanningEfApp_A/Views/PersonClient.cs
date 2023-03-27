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
                Console.WriteLine($"{p.PersonId}, {p.Name}, {p.DateOfBirth}, {p.AadhaarNo}");
                AadhaarCard card=p.Aadhaar;
                if(card !=null)
                {
                    System.Console.WriteLine($"\tCardNo: {card.AadhaarNo}, IssuedOn: {card.DateOfIssue}, ValidTill: {card.ValidTill}");
                }
                Village v=p.HomeTown;
                if(v !=null)
                {
                    System.Console.WriteLine($"\tVillage: {v.VillageId}, {v.Name}, {v.City}, {v.Pincode}");
                }
                var role = p.Role;
                if (role != null)
                {
                    System.Console.WriteLine($"\tRole: {role.RoleTitle},{role.DateOfJoin}");
                }
                var assetList=p.Assets;
                foreach (var item in assetList)
                {
                    System.Console.WriteLine($"\tAssetId: {item.AssetID} Share: {item.OwnershipShare}  PlotNo: {item.Property.PlotNo} AssetType: {item.Property.Type} {item.Property.Description}");
                }
                
            }
        }
        /**
         * Person has One to One Relationship with
         * AadhaarCard and Role. So can not Insert new Person 
         * Without these objects. USE AddNewPersonWithAadhaarAndRole()
         * **/
        public static void Demo_AddOnePerson()
        {
            Person f = new Person
            {
                Name = "John"+new Random().Next(1,100),
                DateOfBirth=DateTime.Now.AddYears(-new Random().Next(1,30)),                
                VillageId=10
            };
            PersonRepository.AddPerson(f);
        }
        public static void Demo_AddNewPersonWithAadhaarAndRole()
        {
            Console.WriteLine("Adding AadhaarCard to Person");
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
            VillageAdministrationRole role = RolesRepository.FindRoleByID(roleid);
            #region trackingrole
            //using (RolesRepository rr=new RolesRepository())
            //{
            //    role = rr.FindTrackingRoleByID(roleid);
            //    if (role == null || role.InChargePerson != null)
            //    {
            //        Console.WriteLine("FAILED to ADD Role. Role not EMPTY");
            //    }
            //    else
            //    {
            //        role.DateOfJoin = DateTime.Now;
            //        role.InChargePerson = p;
            //        p.RoleId = role.RoleId;
            //        PersonRepository.AddPerson(p);
            //        role.PersonId = p.PersonId;
            //        rr.UpdateTrackingRole(role);
            //    }
            //}
            #endregion trackingrole
            if (role == null || role.InChargePerson != null)
            {
                Console.WriteLine("FAILED to ADD Role. Role not EMPTY");
            }
            else
            {
                role.DateOfJoin = DateTime.Now;
                role.InChargePerson = p;
                p.RoleId = role.RoleId;
                PersonRepository.AddPerson(p);
                role.PersonId = p.PersonId;
                RolesRepository.UpdateRole(role);
            }
        }
        public static void Demo_AddManyPeople()
        {
            TownPlanningContext dbContext = new TownPlanningContext();
            List<Person> personList = new List<Person>();
            for (int i = 100; i < 115; i++)
            {
                Person person = new Person
                {
                    Name = "John" + new Random().Next(1, 100),
                    DateOfBirth = DateTime.Now.AddYears(-new Random().Next(1, 30)),
                    VillageId = 10,
                    RoleId = 1
                };
                AadhaarCard card = new AadhaarCard
                {
                    DateOfIssue = DateTime.Now,
                    ValidTill = DateTime.Now.AddYears(50)
                };
                person.Aadhaar = card;
                personList.Add(person);
            }
            PersonRepository.AddPeople(personList);
        }

        public static void Demo_AddAssetstoPerson(int personid)
        {
            Console.WriteLine("Adding Asset to Person");            
            Person persona=PersonRepository.FindPersonByID(personid);
            if(persona==null)
            {
                System.Console.WriteLine("\tPERSON NOT FOUND!!!");
                return;
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
        }
        public static void Demo_AddAadhaartoPerson(int personid)
        {
            Console.WriteLine("Adding AadhaarCard to Person");            
            Person persona=PersonRepository.FindPersonByID(personid);
            if(persona==null)
            {
                System.Console.WriteLine("\tPERSON NOT FOUND!!!");
                return;
            }
            AadhaarCard card=new AadhaarCard
            {
                DateOfIssue=DateTime.Now,
                ValidTill=DateTime.Now.AddYears(50)
            };
            persona.Aadhaar=card;
            PersonRepository.SaveAllTackingChanges();
        }   
        public static void Demo_ModifyPerson()
        {
            Console.WriteLine("Enter PersonID to Modify Person");
            int personid = int.Parse(Console.ReadLine());
            using (PersonRepositoryTracking prt = new PersonRepositoryTracking())
            {
                //Person person = PersonRepository.FindPersonByID(personid);
                Person person = prt.FindPersonByID(personid);
                if (person == null)
                {
                    System.Console.WriteLine("\tPERSON NOT FOUND!!!");
                    return;
                }
                else
                    person.Name = "CORONA-19";
                prt.SavePerson(person);
                //PersonRepository.SavePerson(person);
            }
        }
        public static void Demo_ModifyNonTrackingPerson()
        {
            Console.WriteLine("Enter PersonID to Modify Person");
            int personid = int.Parse(Console.ReadLine());
            using (PersonRepositoryTracking prt = new PersonRepositoryTracking())
            {
                Person person = new Person
                {
                    PersonId = personid,
                    AadhaarNo = personid,
                    DateOfBirth = DateTime.Now,
                    Name = "Shankar",
                    RoleId = 1,
                    VillageId = 10
                };
                prt.UpdateNotTrackedPerson_ByChangingEntityState(person);
            }
        }
    }
}