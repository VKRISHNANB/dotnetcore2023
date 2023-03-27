using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace TownplanningEfApp.ModelA
{
    public class PersonRepository
    {
        public PersonRepository()
        {
            using (TownPlanningContextA _dbcontext=new TownPlanningContextA())
            {
                Console.WriteLine("EnsureCreated: " + 
                _dbcontext.Database.EnsureCreated());
            }
        }
       
       public static List<Person> GetPeople()
        {
            using (TownPlanningContextA _dbcontext=new TownPlanningContextA())
            {
                List<Person> people = _dbcontext.People
                                    .Include(v=>v.HomeTown)
                                    .Include(crd=>crd.AadhaarCard)
                                    .ToList();          
                //List<Asset> assetList=_dbcontext.Assets.Include(d=>d.Owners).ToList();
                //List<AadhaarCard> cardList=    _dbcontext.AadhaarCards.ToList();  
                return people;
            }
        }
       
        #region  Inserts
        /** Adding a new entity to the context **/
        public static void AddPerson(Person f)
        {
            using (TownPlanningContextA _dbcontext=new TownPlanningContextA())
            {
                Console.WriteLine("Inserting a new Person");               
                _dbcontext.People.Add(f);                
                _dbcontext.SaveChanges();
                /**
                 * If the Person Object has a Navigation Property to AadhaarCard object
                 * And if the AadhaarCard does not have a Navigation Property back to Person but,
                 * AadhaarCard has a PersonId property, then EfCore will treat the PersonId as ForeignKey
                 * --IMPORTANT--
                 * A new Person (Principle) can be added to the table without 
                 * an AadhaarCard (dependent) Object assigned to it.
                 * An Aadhaar (dependent) can be added later, and then assigned to the Person (Principle)
                 */
                /**
                 * If the Person Object has a Navigation Property to AadhaarCard object
                 * then after inserting the new Person Record, the personId of the Person is fetched 
                 * from the new row and assigned to the new AadharCard.PersonId column
                 * 
                 * INSERT INTO [People] ([DateOfBirth], [Name], [VillageId])
                 * VALUES (@p0, @p1, @p2);
                 * ---- Get the auto generated PersonId value from Person table
                 * SELECT [PersonId] FROM [People]
                 * WHERE @@ROWCOUNT = 1 AND [PersonId] = scope_identity();
                 * ----- Here @p4 is the above PersonId (scope_identity)
                 * INSERT INTO [AadhaarCards] ([DateOfIssue], [PersonId], [ValidTill])
                 * VALUES (@p3, @p4, @p5);
                 * */
            }
        }
        public static void AddPeople(params Object[] person)
        {
            using (TownPlanningContextA _dbcontext=new TownPlanningContextA())
            {
                /* Bulk Operations work only for 4 or more commands */
                _dbcontext.AddRange(person);
                var results = _dbcontext.SaveChanges();
                Console.WriteLine("person inserted " + results);
            }
        }
        public static void AddPeople(List<Person> peopleList)
        {
            using (TownPlanningContextA _dbcontext=new TownPlanningContextA())
            {
                _dbcontext.AddRange(peopleList);
                int results = _dbcontext.SaveChanges();
                Console.WriteLine("People inserted " + results);
                foreach (Person p in peopleList)
                {
                    AadhaarCard card = p.AadhaarCard;
                    if (card != null)
                    {
                        card.PersonId = p.PersonId;
                    }
                }
                _dbcontext.SaveChanges();
            }
        }
        public static void AddAadhaar(AadhaarCard card)
        {
            using (TownPlanningContextA _dbcontext = new TownPlanningContextA())
            {
                Console.WriteLine("Inserting a new Aadhaar Card");
                _dbcontext.AadhaarCards.Add(card);
                _dbcontext.SaveChanges();
            }
        }

        #endregion insert

        #region Queries
        public static Person FindPersonByID(int id)
        {
            using (TownPlanningContextA _dbcontext=new TownPlanningContextA())
            {
                Console.WriteLine("Querying for Person by ID");
                var Person = _dbcontext.People.Find(id);
                return Person;
            }
        }

        // Filtering Partial Text LINQ
        public static void FindByNameUsingLike(String name)
        {
            using (TownPlanningContextA _dbcontext=new TownPlanningContextA())
            {
                Console.WriteLine("FindByNameUsingLike " + name);
                var persons = _dbcontext.People.Where(
                    f => EF.Functions.Like(f.Name, name + "%")
                    ).ToList();
                if (persons.Count()==0)
                {
                    Console.WriteLine("Person Not Found" + name);
                    return;
                }
                foreach (Person f in persons)
                {
                    Console.WriteLine(f.PersonId + " " + f.Name);
                }
            }
        }
        public static void FindByNameUsingContains(String name)
        {
            using (TownPlanningContextA _dbcontext=new TownPlanningContextA())
            {
                Console.WriteLine("FindByNameUsingContains " + name);
                var persons = _dbcontext.People.Where(
                    f => f.Name.Contains(name)
                    ).ToList();
                if (persons.Count() == 0)
                {
                    Console.WriteLine("Person Not Found" + name);
                    return;
                }
                foreach (Person f in persons)
                {
                    Console.WriteLine(f.PersonId + " " + f.Name);
                }
            }
        }
        public static void GetPersonByCityFirstOrDefault(String name)
        {
            using (TownPlanningContextA _dbcontext=new TownPlanningContextA())
            {
                var Person = _dbcontext.People.FirstOrDefault(s => s.Name == name);
                int id = Person.PersonId;
                Console.WriteLine("FirstOrDefault:\n \tID={0} Name={1} ",id,Person.Name);
                #region DBSet.Find(Key)
                /**
                Will first search from the Change Tracker,
                if the key is found in the Change Tracker then the entity is already available,
                and executes immediately, so unneeded database query can be avoided
                */
                var Person1 = _dbcontext.People.Find(id);           
                Console.WriteLine("Loaded from Cache After Find\n \tID={0} Name={1}", Person1.PersonId, Person1.Name);
                #endregion
                #region LastOrDefault
                //var lastNotOrderPerson = _dbcontext.Persons.LastOrDefault(s => s.Name == name);
                var lastPerson = _dbcontext.People.OrderBy(i=>i.PersonId)
                                            .LastOrDefault(s => s.Name == name);
                Console.WriteLine("LastOrDefault\n \tID={0} Name={1} City={2}",
                                    lastPerson.PersonId, lastPerson.Name);
                #endregion
            }
        }
        #endregion Queries
        #region SaveChanges
        /** Getting the Entity State of the Model Object Tracked by the Context **/
        public static void SavePerson(Person p)
        {
            using (TownPlanningContextA _dbcontext=new TownPlanningContextA())
            {
                Console.WriteLine("\tBefore SaveChanges State=" + _dbcontext.Entry(p).State);
                int result = _dbcontext.SaveChanges();
                Console.WriteLine("\t Updated Records " + result);
                Console.WriteLine("\tAfter SaveChanges State=" + _dbcontext.Entry(p).State);
            }
        }
        public static void SaveAllTackingChanges()
        {
            using (TownPlanningContextA _dbcontext=new TownPlanningContextA())
            {
                int result = _dbcontext.SaveChanges();
                Console.WriteLine("\t Updated Records " + result);
            }
        }
        /** 
         * Attaching an existing entity to the context
         * If you have an entity that you know already exists in the database but 
         * which is not currently being tracked by the context 
         * then you can tell the context to track the entity using the Attach method on DbSet. 
         * The entity will be in the Unchanged state in the context. 
        */
        public static void AttachPersonNotTracked(Person f)
        {
            using (TownPlanningContextA _dbcontext=new TownPlanningContextA())
            {
                Console.WriteLine("\tBefore Attach State=" + _dbcontext.Entry(f).State);
                _dbcontext.People.Attach(f);
                Console.WriteLine("\tAfter Attach State=" + _dbcontext.Entry(f).State);
                // if the Entity id is not provided while attaching 
                // then the entity will be added to the Context and will be Tracked
                _dbcontext.SaveChanges();
            }
            /** 
             * Changes will NOT be made to the database if SaveChanges() is called without doing 
             * any other manipulation of the attached entity.
             * This is because the entity is in the Unchanged state.              
             */
            /** Important            
             * Calling Attach for an entity that is currently Tracked and  
             * in the Added or Modified state will change its state to
             * "Unchanged" .
             * */
        }
        /** 
        * If you have an entity that you know already exists in the database 
        * but to which changes may have been made then you can tell the context 
        * to attach the entity and set its state to Modified.   
        */
        public static void UpdateNotTrackedPerson_ByChangingEntityState(Person f)
        {
            using (TownPlanningContextA _dbcontext=new TownPlanningContextA())
            {
                //_dbcontext.People.Attach(f); 
                _dbcontext.Entry(f).State = EntityState.Modified;
                _dbcontext.SaveChanges();
            }
        }
        // Insert or update pattern
        public static void InsertOrUpdate(Person f)
        {
            using (TownPlanningContextA _dbcontext = new TownPlanningContextA())
            {
                _dbcontext.Entry(f).State = f.PersonId == 0 ?
                                            EntityState.Added :
                                            EntityState.Modified;
                _dbcontext.SaveChanges();
            }
        }


        #endregion update
    }
}