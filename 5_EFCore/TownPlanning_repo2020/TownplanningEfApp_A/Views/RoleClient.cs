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
            foreach (VillageAdministrationRole r in rolelist)
            {
                StringBuilder sbname = new StringBuilder();
                if (r.InChargePerson!=null)
                    sbname.Append( r.InChargePerson.Name);
                Console.WriteLine($"\t{r.RoleId}, {r.RoleTitle}, {sbname}");
                sbname.Clear();
            }
        }
    }
}
