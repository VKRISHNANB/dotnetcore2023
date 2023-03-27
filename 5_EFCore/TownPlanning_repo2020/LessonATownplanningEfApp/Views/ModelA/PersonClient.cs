using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TownplanningEfApp.ModelA;

namespace TownplanningEfApp.Views.ModelA
{
    public class PersonClient
    {
        public static void DisplayAllPeople()
        {
            var peoplelist=PersonRepository.GetPeople();
            foreach(Person p in peoplelist)
            {
                Console.WriteLine($"{p.PersonId}, {p.Name}, {p.DateOfBirth}, {p.AadhaarCard.AadhaarId}");
                AadhaarCard card=p.AadhaarCard;
                if(card !=null)
                {
                    System.Console.WriteLine($"\tCardNo: {card.AadhaarId}, IssuedOn: {card.DateOfIssue}, ValidTill: {card.ValidTill}");
                }
                Village v=p.HomeTown;
                if(v !=null)
                {
                    System.Console.WriteLine($"\tVillage: {v.VillageId}, {v.Name}, {v.City}, {v.Pincode}");
                }
            }
        }
        
        public static void Demo_AddOnePersonWithoutAadhaar()
        {
            Person f = new Person
            {
                Name = "John"+new Random().Next(1,100),
                DateOfBirth=DateTime.Now.AddYears(-new Random().Next(1,30)),                
                VillageId=10
            };
            PersonRepository.AddPerson(f);
        }
        public static void Demo_AddNewPersonWithAadhaar()
        {
            Console.WriteLine("Adding New Person with AadhaarCard");
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
            p.AadhaarCard = card;
            PersonRepository.AddPerson(p);
        }
        public static void Demo_AddManyPeopleWithAadhaar()
        {
            TownPlanningContextA dbContext = new TownPlanningContextA();
            List<Person> personList = new List<Person>();
            for (int i = 100; i < 115; i++)
            {
                Person person = new Person
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
                person.AadhaarCard = card;
                personList.Add(person);
            }
            PersonRepository.AddPeople(personList);
        }

        public static void Demo_AddAadhaartoPerson()
        {
            Console.WriteLine("Adding AadhaarCard to Person: Enter Person ID");
            int personid = int.Parse(Console.ReadLine());
            PersonRepositoryTracking pr = new PersonRepositoryTracking();
            Person persona=pr.FindPersonByID(personid);
            if(persona==null)
            {
                System.Console.WriteLine("\tPERSON NOT FOUND!!!");
                return;
            }
            AadhaarCard card = persona.AadhaarCard;//null;
            card=new AadhaarCard
            {
                DateOfIssue=DateTime.Now,
                ValidTill=DateTime.Now.AddYears(50),
                PersonId = persona.PersonId
            };
            /* 
             * The new AadhaarCard object is now a detached Object
             * The dbContext does not track references
             * The new AadhaarCard object must be assigned back to the 
             * persona.AadhaarCard member tobe tracked
             * */
            persona.AadhaarCard=card;
            //PersonRepository.SaveAllTackingChanges();
            pr.SavePerson(persona);
        }
        public static void Demo_AddNewAadhaarWithoutPerson()
        {
            Console.WriteLine("Adding New AadhaarCardWithout Person");
            Console.WriteLine("Enter Person ID");
            int personid = int.Parse(Console.ReadLine());
            AadhaarCard card = new AadhaarCard
            {
                DateOfIssue = DateTime.Now,
                ValidTill = DateTime.Now.AddYears(50),
                PersonId= personid
            };
            PersonRepository.AddAadhaar(card);
            /**
             * If AadharCard Table does not have a row for PersonID=<inputpersonid> then
             *  a new Card will be added 
             * else
             *  DuplicateKey for column PersonId ERROR will be thrown 
             * 
             * Please refer OnModelCreating() in the Context class 
             * for adding Unique Key constraint
             */
        }
        public static void Demo_ModifyPerson()
        {
            Console.WriteLine("Enter PersonID to Modify Person");
            int personid = int.Parse(Console.ReadLine());
            #region PersonNotTracked
            //Person person = PersonRepository.FindPersonByID(personid);
            //if (person == null)
            //{
            //    System.Console.WriteLine("\tPERSON NOT FOUND!!!");
            //    return;
            //}
            //else
            //    person.Name = "CORONA-19";
            //PersonRepository.SavePerson(person);
            #endregion PersonNotTracked
            #region TrackedPerson
            using (PersonRepositoryTracking prt = new PersonRepositoryTracking())
            {
                Person person = prt.FindPersonByID(personid);
                if (person == null)
                {
                    System.Console.WriteLine("\tPERSON NOT FOUND!!!");
                    return;
                }
                else
                    person.Name = "CORONA-19";
                prt.SavePerson(person);
            }
            #endregion TrackedPerson
        }
        public static void Demo_ModifyNonTrackingPerson()
        {
            Console.WriteLine("Enter PersonID to Modify Person");
            int personid = int.Parse(Console.ReadLine());
            Person person = new Person
            {
                PersonId = personid,
                DateOfBirth = DateTime.Now,
                Name = "Shankar",
                VillageId = 10
            };
            using (PersonRepositoryTracking prt = new PersonRepositoryTracking())
            {
               
                prt.UpdateNotTrackedPerson_ByChangingEntityState(person);
            }
            //PersonRepository.UpdateNotTrackedPerson_ByChangingEntityState(person);
        }
    }
}