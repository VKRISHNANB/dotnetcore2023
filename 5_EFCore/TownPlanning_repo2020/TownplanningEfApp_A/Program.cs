using System;
using TownplanningEfApp.Views;
namespace TownplanningEfApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Village
            //  VillagesClient.Demo_AddOneVillage();
            //VillagesClient.Demo_AddManyVillagesWithoutBatch();
            //VillagesClient.Demo_AddManyVillagesBatch();
            //VillagesClient.Demo_AddManyVillagesUsingList();
            //  VillagesClient.Demo_AddVillageAndPerson();
            //  VillagesClient.Demo_InsertOrUpdate();
            //  System.Console.WriteLine("=============");
            //  VillagesClient.Demo_VillagesFilters();
            //  System.Console.WriteLine("=============");
            //  VillagesClient.Demo_UpdateVillage();
            //  VillagesClient.Demo_UpdateVillageNotTracked();
            //  VillagesClient.Demo_UpdateVillageNotTrackedByChangingEntityState();
            //VillagesClient.DisplayAllVillages();
            //  System.Console.WriteLine("=============");
            #endregion village
            #region Person
            /** Adding Person without the related data like AadhaarCard, Role etc**/
            //  PersonClient.Demo_AddOnePerson();
            //PersonClient.Demo_AddNewPersonWithAadhaarAndRole();
            //PersonClient.Demo_AddManyPeople();
            //  PersonClient.Demo_AddAssetstoPerson(13);
            //PersonClient.Demo_ModifyPerson();
            PersonClient.Demo_ModifyNonTrackingPerson();
            //PersonClient.DisplayAllPeople();
            #endregion person
            #region asset
            // AssetClient.Demo_AddAnAsset();
            // AssetClient.Demo_AddManyAsset();
            #endregion
            #region role
            //RoleClient.DisplayAllRoles();
            #endregion role
            System.Console.WriteLine("Completed");
           // Console.ReadKey();
        }
    }
}
