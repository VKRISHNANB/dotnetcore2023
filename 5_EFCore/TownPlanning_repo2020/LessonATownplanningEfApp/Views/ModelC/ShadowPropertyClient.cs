using System;
using System.Collections.Generic;
using System.Text;
using TownplanningEfApp.ModelC;

namespace LessonATownplanningEfApp.Views.ModelC
{
    public class ShadowPropertyClient
    {
        public static void Init()
        {
            /**
             * Create Database and Seed Data
             * */
            Demo_AddManyVillagesUsingList();
            List<VillageAdministrationRole> rolelist = new List<VillageAdministrationRole>();
            for(int i=65;i<75;i++)
            {
                VillageAdministrationRole role = new VillageAdministrationRole()
                {
                    RoleTitle = "Role" + (char)i
                };
                rolelist.Add(role);
            }
            RolesRepository.AddRoles(rolelist);
            //DisplayAllVillages();
            //DisplayAllRoles();
        }
        private static void DisplayVillage(Village v)
        {
            System.Console.WriteLine($"{v.VillageId}, {v.Name}, {v.City}, {v.Pincode}");
        }
        public static void DisplayAllVillages()
        {
            VillageRepository villageRepository = new VillageRepository();
            var villagelist = villageRepository.GetVillages();
            foreach (Village v in villagelist)
            {
                DisplayVillage(v);
                if (v.Residents != null)
                {
                    var peoples = v.Residents;
                    foreach (Person p in peoples)
                    {
                        DisplayPersonDetails(p);
                    }
                }
            }
        }
        public static void DisplayAllRoles()
        {
            var rolelist = RolesRepository.GetRoles();
            StringBuilder sbname = new StringBuilder();
            foreach (VillageAdministrationRole r in rolelist)
            {
                if (r.InChargePerson != null)
                    sbname.Append(r.InChargePerson.Name);
                Console.WriteLine($"\t{r.RoleId}, {r.RoleTitle}, {sbname}");
                sbname.Clear();
            }
        }
        public static void DisplayAllPeople()
        {
            PersonRepositoryTracking prt = new PersonRepositoryTracking();
            var peoplelist = prt.GetPeople();
            foreach (Person p in peoplelist)
            {
                DisplayPersonDetails(p);
            }
        }
        private static void DisplayPersonDetails(Person p)
        {
            Console.WriteLine($"{p.PersonId}, {p.Name}, {p.DateOfBirth}");
            Village v = p.HomeTown;
            if (v != null)
            {
                System.Console.WriteLine($"\tVillage: {v.VillageId}, {v.Name}, {v.City}, {v.Pincode}");
            }
            else
                System.Console.WriteLine($"\tVillage: Village NOT Assigned");

            var role = p.Role;
            if (role != null)
            {
                System.Console.WriteLine($"\tRole: {role.RoleTitle}");
            }
            else
                System.Console.WriteLine($"\tRole: NO ROLE Assigned");
        }
        public static void DisplayAllRolesWithDOJ()
        {
            //var rolelist = RolesRepository.GetRolesCreatedThisYear();
            //StringBuilder sbname = new StringBuilder();
            //foreach (RoleWithDOJDate r in rolelist)
            //{
            //    if (r.InChargePerson != null)
            //        sbname.Append(r.InChargePerson.Name);
            //    Console.WriteLine($"\t{r.RoleId}, {r.RoleTitle}, {sbname}, DOJ:{r.DateOfJoin}");
            //    sbname.Clear();
            //}
            /** Using Dynamic anonymous role Object that includes the Shadow Property*/
            dynamic roles = RolesRepository.GetRolesByYearDynamicList();
            StringBuilder sbname = new StringBuilder();
            foreach (var r in roles)
            {
                if (r.InChargePerson != null)
                    sbname.Append(r.InChargePerson.Name);
                Console.WriteLine($"\t{r.RoleId}, {r.RoleTitle}, {sbname}, DOJ:{r.DateOfJoin}");
                sbname.Clear();
            }
        }

        private static void Demo_AddManyVillagesUsingList()
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
            VillageList.Add(Village6);
            VillageList.Add(Village7);
            VillageList.Add(Village8);
            VillageList.Add(Village9);
            VillageList.Add(Village10);
            #endregion //List
            VillageRepository villageRepository = new VillageRepository(true);
            villageRepository.AddMultipleVillages(VillageList);
        }
       
        public static void Demo_AddNewPersonWithRole()
        {
            Console.WriteLine("Adding New Person");
            Person p = new Person
            {
                Name = "John" + new Random().Next(1, 100),
                DateOfBirth = DateTime.Now.AddYears(-new Random().Next(1, 30)),
                VillageId = 10
            };
            Console.WriteLine("Enter Role ID");
            int roleid = int.Parse(Console.ReadLine());
            VillageAdministrationRole role = null;
            using (TownPlanningContextC dbContext = new TownPlanningContextC())
            {
                using (RolesRepository rr = new RolesRepository(dbContext))
                {
                    role = rr.FindTrackingRoleByID(roleid);
                    if (role == null )
                    {
                        Console.WriteLine("FAILED to ADD Role. Role not EMPTY");
                    }
                    else
                    {
                        /**
                         * Can not use Lampda expressions with Shadow Properties here because
                         * they are not actual properties of the entity
                         * Check the SQL Query generated while updating the Role Table
                         */
                        dbContext.Entry(role).Property("DateOfJoining").CurrentValue= DateTime.Now;
                        dbContext.Entry(role).Property("PreviousInChargePersonId").CurrentValue =role.PersonId;
                        //dbContext.Entry(role).Property("LastModified").CurrentValue = DateTime.Now;
                        role.InChargePerson = p;
                    }
                    using (PersonRepositoryTracking personRepo = new PersonRepositoryTracking(dbContext))
                    {
                        p.Role = role;
                        personRepo.AddPerson(p);
                    }
                }
            }
        }
        public static void Demo_ChangePersonVillage()
        {
            using (PersonRepositoryTracking personRepo = new PersonRepositoryTracking())
            {
                Console.WriteLine("Enter PersonID to Change his Village");
                int personid = int.Parse(Console.ReadLine());
                Person p = personRepo.FindPersonByID(personid);
                Console.WriteLine(p.Name +" Village: "+p.VillageId+" "+p.HomeTown.Name);
                Console.WriteLine("Enter new VillageID");
                int villageid = int.Parse(Console.ReadLine());
                p.VillageId = villageid;
                personRepo.SavePerson(p);
            }
           
        }
    }
}
