using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace TownplanningEfApp.ModelC
{
    public class PersonRepositoryTracking:IDisposable
    {
        TownPlanningContextC _dbcontext;
        public PersonRepositoryTracking()=>     _dbcontext = new TownPlanningContextC();
        public PersonRepositoryTracking(TownPlanningContextC dbcontext)=>  _dbcontext = dbcontext;
        public   List<Person> GetPeople()
        {
            Console.WriteLine("Enter year (LESS THAN 2021");
            int year = int.Parse(Console.ReadLine());
            if (year > DateTime.Now.Year)
                year = 2020;
            var thisyear = new DateTime(year, 4, 1);
            /** Quering Roles using Shadow Property */
            List<Person> people = _dbcontext.People
                                .Include(v => v.HomeTown)
                                .Include(r => r.Role)
                                .Where(r => EF.Property<DateTime?>(r.Role, "DateOfJoining") >= thisyear)                               
                                .ToList();
            return people;
        }
       
        #region  Inserts
        /** Adding a new entity to the context **/
        public  void AddPerson(Person f)
        {           
            Console.WriteLine("Inserting a new Person");
            /**
             * These Shadow Properties are used for Auditing Purpose
             * The LastModified Property must be Updated every time a Person is modified
             * We have overriden the SaveChanges() of the DBContext for the purpose
             */
            //_dbcontext.Entry(f).Property("Created").CurrentValue = DateTime.Now;
            //_dbcontext.Entry(f).Property("LastModified").CurrentValue = DateTime.Now;
            _dbcontext.People.Add(f);
            _dbcontext.SaveChanges();            
        }
        #endregion insert

        #region Queries
        public  Person FindPersonByID(int id)
        {           
            Console.WriteLine("Querying for Person by ID");
            var Person = _dbcontext.People
                 .Include(v => v.HomeTown)
                 .Include(r => r.Role)
                 .Where(p=>p.PersonId==id)
                 .FirstOrDefault();
            return Person;
        }
        #endregion Queries
        #region SaveChanges
        /** Getting the Entity State of the Model Object Tracked by the Context **/
        public  void SavePerson(Person p)
        {
            //_dbcontext.Entry(p).Property("LastModified").CurrentValue = DateTime.Now;
            Console.WriteLine("\tBefore SaveChanges State=" + _dbcontext.Entry(p).State);
            int result = _dbcontext.SaveChanges();
            Console.WriteLine("\t Updated Records " + result);
            Console.WriteLine("\tAfter SaveChanges State=" + _dbcontext.Entry(p).State);
        }
        #endregion update
        public void Dispose()
        {
            _dbcontext.Dispose();
        }
    }
}