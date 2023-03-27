using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace TownplanningEfApp.ModelB
{
    public class RolesRepository:IDisposable
    {
        TownPlanningContextB nonstaticContext;
        public RolesRepository() => nonstaticContext = new TownPlanningContextB();
        public RolesRepository(TownPlanningContextB dbcontext) => nonstaticContext = dbcontext;
        public static void AddRole(VillageAdministrationRole role)
        {
            using (TownPlanningContextB _dbcontext = new TownPlanningContextB())
            {
                Console.WriteLine("Inserting a new Role");
                _dbcontext.Roles.Add(role);
                _dbcontext.SaveChanges();
            }
        }
        public static void AddRoles(List<VillageAdministrationRole> roles)
        {
            using (TownPlanningContextB _dbcontext = new TownPlanningContextB())
            {
                Console.WriteLine("Inserting new Roles");
                _dbcontext.Roles.AddRange(roles);
                _dbcontext.SaveChanges();
            }
        }
        public static List<VillageAdministrationRole> GetRoles()
        {
            using (TownPlanningContextB _dbcontext = new TownPlanningContextB())
            {
                List<VillageAdministrationRole> roles = _dbcontext.Roles
                    .Include(p=>p.InChargePerson)
                    .ToList();
                return roles;
            }
        }
        public static VillageAdministrationRole FindRoleByID(int id)
        {
            using (TownPlanningContextB _dbcontext = new TownPlanningContextB())
            {
                Console.WriteLine("Querying for Role by ID");
                var role = _dbcontext.Roles.Find(id);
                return role;
            }
        }
        public static void UpdateRole(VillageAdministrationRole role)
        {
            using (TownPlanningContextB _dbcontext = new TownPlanningContextB())
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
