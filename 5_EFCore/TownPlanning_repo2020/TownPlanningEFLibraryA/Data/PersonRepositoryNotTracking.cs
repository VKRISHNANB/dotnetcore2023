using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace TownplanningEfApp.Models
{
    public class PersonRepository
    {
        public PersonRepository()
        {
            using (TownPlanningContext _dbcontext=new TownPlanningContext())
            {
                Console.WriteLine("EnsureCreated: " + 
                _dbcontext.Database.EnsureCreated());
            }
        }
       
       public static List<Person> GetPeople()
        {
            using (TownPlanningContext _dbcontext=new TownPlanningContext())
            {
                List<Person> people = _dbcontext.People
                                    .Include(v=>v.HomeTown)
                                    .Include(a=>a.Assets)
                                    .Include(crd=>crd.Aadhaar)
                                    .Include(r=>r.Role)
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
            using (TownPlanningContext _dbcontext=new TownPlanningContext())
            {
                Console.WriteLine("Inserting a new Person");               
                _dbcontext.People.Add(f);
                _dbcontext.SaveChanges();
                /** 
                 * The following update is required if there is a 
                 * bi-directional association
                 **/
                AadhaarCard card = f.Aadhaar;
                if (card!=null)
                {
                    card.PersonId = f.PersonId;
                    _dbcontext.SaveChanges(); 
                }
            }
        }
        public static void AddPeople(params Object[] person)
        {
            using (TownPlanningContext _dbcontext=new TownPlanningContext())
            {
                /* Bulk Operations work only for 4 or more commands */
                _dbcontext.AddRange(person);
                var results = _dbcontext.SaveChanges();
                Console.WriteLine("person inserted " + results);
            }
        }
        public static void AddPeople(List<Person> peopleList)
        {
            using (TownPlanningContext _dbcontext=new TownPlanningContext())
            {
                _dbcontext.AddRange(peopleList);
                int results = _dbcontext.SaveChanges();
                Console.WriteLine("People inserted " + results);
                foreach (Person p in peopleList)
                {
                    AadhaarCard card = p.Aadhaar;
                    if (card != null)
                    {
                        card.PersonId = p.PersonId;
                    }
                }
                _dbcontext.SaveChanges();
            }
        }
        #endregion insert
        
        #region Queries
        public static Person FindPersonByID(int id)
        {
            using (TownPlanningContext _dbcontext=new TownPlanningContext())
            {
                Console.WriteLine("Querying for Person by ID");
                var Person = _dbcontext.People.Find(id);
                return Person;
            }
        }

        // Filtering Partial Text LINQ
        public static void FindByNameUsingLike(String name)
        {
            using (TownPlanningContext _dbcontext=new TownPlanningContext())
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
            using (TownPlanningContext _dbcontext=new TownPlanningContext())
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
            using (TownPlanningContext _dbcontext=new TownPlanningContext())
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
            using (TownPlanningContext _dbcontext=new TownPlanningContext())
            {
                Console.WriteLine("\tBefore SaveChanges State=" + _dbcontext.Entry(p).State);
                int result = _dbcontext.SaveChanges();
                Console.WriteLine("\t Updated Records " + result);
                Console.WriteLine("\tAfter SaveChanges State=" + _dbcontext.Entry(p).State);
            }
        }
        public static void SaveAllTackingChanges()
        {
            using (TownPlanningContext _dbcontext=new TownPlanningContext())
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
            using (TownPlanningContext _dbcontext=new TownPlanningContext())
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
            using (TownPlanningContext _dbcontext=new TownPlanningContext())
            {
                //_dbcontext.People.Attach(f); 
                _dbcontext.Entry(f).State = EntityState.Modified;
                _dbcontext.SaveChanges();
            }
        }
        // Insert or update pattern
        public static void InsertOrUpdate(Person f)
        {
            using (TownPlanningContext _dbcontext = new TownPlanningContext())
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