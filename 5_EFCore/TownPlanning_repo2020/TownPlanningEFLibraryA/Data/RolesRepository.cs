using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace TownplanningEfApp.Models
{
    public class RolesRepository:IDisposable
    {
        TownPlanningContext nonstaticContext;
        public RolesRepository() => nonstaticContext = new TownPlanningContext();
        public static void AddRole(VillageAdministrationRole role)
        {
            using (TownPlanningContext _dbcontext = new TownPlanningContext())
            {
                Console.WriteLine("Inserting a new Role");
                _dbcontext.Roles.Add(role);
                _dbcontext.SaveChanges();
            }
        }
        public static List<VillageAdministrationRole> GetRoles()
        {
            using (TownPlanningContext _dbcontext = new TownPlanningContext())
            {
                List<VillageAdministrationRole> roles = _dbcontext.Roles
                    .Include(p=>p.InChargePerson)
                    .ToList();
                return roles;
            }
        }
        public static VillageAdministrationRole FindRoleByID(int id)
        {
            using (TownPlanningContext _dbcontext = new TownPlanningContext())
            {
                Console.WriteLine("Querying for Role by ID");
                var role = _dbcontext.Roles.Find(id);
                return role;
            }
        }
        public static void UpdateRole(VillageAdministrationRole role)
        {
            using (TownPlanningContext _dbcontext = new TownPlanningContext())
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
