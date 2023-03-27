using System;
using System.Collections.Generic;
using System.Text;
using TownplanningEfApp.Models;

namespace TownplanningEfApp.Views
{
    public class RoleClient
    {
        public static void DisplayAllRoles()
        {
            var rolelist = RolesRepository.GetRoles();
            StringBuilder sbpersonName = new StringBuilder();
            foreach (VillageAdministrationRole r in rolelist)
            {
                if (r.InChargePerson != null)
                    sbpersonName.Append(r.InChargePerson.Name);
                Console.WriteLine($"\t{r.RoleId}, {r.RoleTitle}, {sbpersonName}");
                sbpersonName.Clear();
            }
        }
        public static void AddRoles()
        {
            List<VillageAdministrationRole> listofroles = new List<VillageAdministrationRole>();
            for(var i=65;i<75;i++)
            {
                VillageAdministrationRole role = new VillageAdministrationRole
                {
                    RoleTitle = "Role " + (char)i
                };
                listofroles.Add(role);
            }
            RolesRepository.AddRole(listofroles);
        }
    }
}
