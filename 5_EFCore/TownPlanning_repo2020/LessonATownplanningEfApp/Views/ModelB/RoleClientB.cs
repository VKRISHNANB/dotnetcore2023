using System;
using System.Collections.Generic;
using System.Text;
using TownplanningEfApp.ModelB;

namespace TownplanningEfApp.Views.ModelB
{
    public class RoleClient
    {
        public static void DisplayAllRoles()
        {
            var rolelist = RolesRepository.GetRoles();
            StringBuilder sbname = new StringBuilder();
            foreach (VillageAdministrationRole r in rolelist)
            {
                if (r.InChargePerson!=null)
                    sbname.Append( r.InChargePerson.Name);
                Console.WriteLine($"\t{r.RoleId}, {r.RoleTitle}, {sbname}");
                sbname.Clear();
            }
        }
    }
}
