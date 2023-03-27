using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace TownplanningEfApp.ModelC
{
    public class RolesRepository:IDisposable
    {
        TownPlanningContextC nonstaticContext;
        public RolesRepository() => nonstaticContext = new TownPlanningContextC();
        public RolesRepository(TownPlanningContextC dbcontext) => nonstaticContext = dbcontext;
        public static void AddRole(VillageAdministrationRole role)
        {
            using (TownPlanningContextC _dbcontext = new TownPlanningContextC())
            {
                Console.WriteLine("Inserting a new Role");
                /**
                 * We have overriden the SaveChanges() of the DBContext for 
                 * adding Auditing data to the Shadow Properties while inserting a new Role
                 **/
                _dbcontext.Roles.Add(role);
                _dbcontext.SaveChanges();
            }
        }
        public static void AddRoles(List<VillageAdministrationRole> roles)
        {
            using (TownPlanningContextC _dbcontext = new TownPlanningContextC())
            {
                Console.WriteLine("Inserting new Roles");
                /**
                * These Shadow Properties are used for Auditing Purpose
                * The LastModified Property must be Updated every time a Village is modified
                * We have overriden the SaveChanges() of the DBContext for the purpose 
                */
                //foreach (VillageAdministrationRole v in roles)
                //{
                //    _dbcontext.Entry(v).Property("Created").CurrentValue = DateTime.Now;
                //    _dbcontext.Entry(v).Property("LastModified").CurrentValue = DateTime.Now;
                //}
                _dbcontext.Roles.AddRange(roles);
                _dbcontext.SaveChanges();
            }
        }
        public static List<VillageAdministrationRole> GetRoles()
        {
            using (TownPlanningContextC _dbcontext = new TownPlanningContextC())
            {
                Console.WriteLine("Enter year (LESS THAN 2021");
                int year = int.Parse(Console.ReadLine());
                if (year > DateTime.Now.Year)
                    year = 2020;
                var thisyear = new DateTime(year, 4, 1);
                /** Quering Roles using Shadow Property */
                List<VillageAdministrationRole> roles = _dbcontext.Roles
                    .Where(r=>EF.Property<DateTime?>(r, "DateOfJoining") >=thisyear)
                    .Include(p=>p.InChargePerson)
                    .ToList();
                return roles;
            }
        }
        
        public static List<RoleWithDOJDate> GetRolesCreatedThisYear()
        {
            using (TownPlanningContextC _dbcontext = new TownPlanningContextC())
            {
                Console.WriteLine("Enter year (LESS THAN 2021");
                int year = int.Parse(Console.ReadLine());
                if (year > DateTime.Now.Year)
                    year = 2020;
                var thisyear = new DateTime(year, 4, 1);
                /** Quering Roles using Shadow Property */
                var roles = _dbcontext.Roles
                    .Include(p => p.InChargePerson)
                    .Where(r => EF.Property<DateTime?>(r, "DateOfJoining") >= thisyear)
                    .Select(r => new RoleWithDOJDate {RoleId= r.RoleId, RoleTitle=r.RoleTitle,DateOfJoin= EF.Property<DateTime?>(r, "DateOfJoining"),InChargePerson= r.InChargePerson,PersonId=r.PersonId })
                    .ToList();
                return roles;
            }
        }
        public static Object GetRolesByYearDynamicList()
        {
            using (TownPlanningContextC _dbcontext = new TownPlanningContextC())
            {
                Console.WriteLine("Enter year (LESS THAN 2021");
                int year = int.Parse(Console.ReadLine());
                if (year > DateTime.Now.Year)
                    year = 2020;
                var thisyear = new DateTime(year, 4, 1);
                /** 
                 * Quering Roles using Shadow Property 
                 * Creating a List of anonymous Object that includes the Shadow Property
                 */
                var roles = _dbcontext.Roles
                    .Include(p => p.InChargePerson)
                    .Where(r => EF.Property<DateTime?>(r, "DateOfJoining") >= thisyear)
                    .Select(r => new  { RoleId = r.RoleId, RoleTitle = r.RoleTitle, DateOfJoin = EF.Property<DateTime?>(r, "DateOfJoining"), InChargePerson = r.InChargePerson, PersonId = r.PersonId })
                    .ToList();
                return roles;
            }
        }
        public static VillageAdministrationRole FindRoleByID(int id)
        {
            using (TownPlanningContextC _dbcontext = new TownPlanningContextC())
            {
                Console.WriteLine("Querying for Role by ID");
                var role = _dbcontext.Roles.Find(id);
                return role;
            }
        }
        public static void UpdateRole(VillageAdministrationRole role)
        {
            using (TownPlanningContextC _dbcontext = new TownPlanningContextC())
            {
                Console.WriteLine("Updating Role");
                if (role != null && _dbcontext.Entry(role).State == EntityState.Detached)
                {
                    _dbcontext.Roles.Attach(role);
                    _dbcontext.Entry(role).State = EntityState.Modified;
                }
                _dbcontext.SaveChanges();
            }
        }
        public  VillageAdministrationRole FindTrackingRoleByID(int id)
        {
            Console.WriteLine("Querying for Role by ID");
            nonstaticContext.Roles.Include(p=>p.InChargePerson);
            var role = nonstaticContext.Roles.Find(id) ;
            return role;
        }
        public  void UpdateTrackingRole(VillageAdministrationRole role)
        {
            Console.WriteLine("Updating Role");
            //if (role != null && nonstaticContext.Entry(role).State == EntityState.Detached)
            //    nonstaticContext.Roles.Attach(role);
            nonstaticContext.SaveChanges();
        }
       
        public void Dispose()
        {
            nonstaticContext.Dispose();
        }
    }
}
