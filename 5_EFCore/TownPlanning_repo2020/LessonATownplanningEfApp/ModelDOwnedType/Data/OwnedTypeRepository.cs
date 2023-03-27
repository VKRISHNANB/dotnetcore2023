using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LessonATownplanningEfApp.ModelDOwnedType
{
    public class OwnedTypeRepository
    {
        TownPlanningContextD _dbcontext = null;
        public OwnedTypeRepository()
        {
            _dbcontext = new TownPlanningContextD();
        }
        public OwnedTypeRepository(bool flagensureDeletedCreated)
        {
            _dbcontext = new TownPlanningContextD(flagensureDeletedCreated);
        }
        public List<VillageD> GetVillages()
        {
            List<VillageD> villages;
            villages = _dbcontext.Villages.Include(r => r.Residents).ToList();
            return villages;
        }
        public List<PersonD> GetPeople()
        {
            List<PersonD> people = _dbcontext.People
                                .Include(v => v.HomeTown)
                                .ToList();
            return people;
        }
        #region  Inserts
        public void AddVillage(VillageD f)
        {
            Console.WriteLine("Inserting a new Village");
            _dbcontext.Add(f);
            _dbcontext.SaveChanges();
        }
        public void AddMultipleVillages(List<VillageD> VillageList)
        {
            _dbcontext.AddRange(VillageList);
            int results = _dbcontext.SaveChanges();
            Console.WriteLine("Villages inserted " + results);
        }
        public void AddPerson(PersonD f)
        {
            Console.WriteLine("Inserting a new Person");           
            _dbcontext.People.Add(f);
            _dbcontext.SaveChanges();
        }
        #endregion
        public PersonD FindPersonByID(int id)
        {
            Console.WriteLine("Querying for Person by ID");
            var Person = _dbcontext.People
                 .Include(v => v.HomeTown)
                 .Where(p => p.PersonDId == id).FirstOrDefault();                 
            return Person;
        }
        public void SaveChangesToTrackedPerson(PersonD p)
        {
            Console.WriteLine("\t\tBefore SaveChanges StateOfPerson=" + _dbcontext.Entry(p).State);
            if(p.Address!=null)
                Console.WriteLine("\t\tBefore SaveChanges StateOfAddress=" + _dbcontext.Entry(p.Address).State);
            _dbcontext.SaveChanges();
            Console.WriteLine("\tAfter SaveChanges StateOfPerson=" + _dbcontext.Entry(p).State);
            if(p.Address!=null)
                Console.WriteLine("\tAfter SaveChanges StateOfAddress=" + _dbcontext.Entry(p.Address).State);

        }
    }
}
