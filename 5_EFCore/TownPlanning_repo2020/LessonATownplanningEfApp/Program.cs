using System;
using TownplanningEfApp.Views.ModelA;
using LessonATownplanningEfApp.Views.ModelC;
using LessonATownplanningEfApp.Views.ModelD;
namespace TownplanningEfApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestModelA();
            //TestModelB();
            //TestModelC();
            //TestModelD();

            System.Console.WriteLine("==========Completed=============");
            Console.ReadKey();
        }
        static void TestModelA()
        {
            #region Village
            /** Seed data for Village */
            //VillagesClient.Demo_AddOneVillage();
            //VillagesClient.Demo_AddManyVillagesWithoutBatch();
            //VillagesClient.Demo_AddManyVillagesBatch();
            //VillagesClient.Demo_AddManyVillagesUsingList();
            //VillagesClient.Demo_AddVillagePersonAndCard();
            //VillagesClient.Demo_InsertOrUpdate();
            //  System.Console.WriteLine("=============");
            //VillagesClient.Demo_VillagesFilters();
            //  System.Console.WriteLine("=============");
            //  VillagesClient.Demo_UpdateVillage();
            //  VillagesClient.Demo_UpdateVillageNotTracked();
            //  VillagesClient.Demo_UpdateVillageNotTrackedByChangingEntityState();
            //VillagesClient.DisplayAllVillages();
            //  System.Console.WriteLine("=============");
            #endregion village
            #region PersonModleA
            /** Adding Person without the related data like AadhaarCard etc**/
            //PersonClient.Demo_AddOnePersonWithoutAadhaar();
            /** Adding a new AADHAARCARD without Person*/
            //PersonClient.Demo_AddNewAadhaarWithoutPerson();
            //PersonClient.Demo_AddAadhaartoPerson();
            //PersonClient.Demo_AddNewPersonWithAadhaar();
            //PersonClient.Demo_AddManyPeopleWithAadhaar();
            //PersonClient.Demo_ModifyPerson();
            //PersonClient.Demo_ModifyNonTrackingPerson();
            //PersonClient.DisplayAllPeople();
            #endregion person
        }
        static void TestModelB()
        {
            #region Village
            /** Seed data for Village */
            Views.ModelB.VillagesClientB.Init();
            Views.ModelB.VillagesClientB.DisplayAllVillages();
            #endregion village
            #region PersonModelB
            //Views.ModelB.PersonClientB.Demo_AddNewPersonWithAadhaarAndRole();
            //Views.ModelB.PersonClientB.Demo_AddManyPeopleWithNoRole();
            //Views.ModelB.PersonClientB.Demo_AddAssetstoPerson(13);
            //Views.ModelB.PersonClientB.DisplayAllPeople();
            //System.Console.WriteLine("=============");
            #endregion person
            #region asset
            //Views.ModelB.AssetClient.Demo_AddAnAsset();
            //Views.ModelB.AssetClient.Demo_AddManyAsset();
            #endregion
            #region role
            //Views.ModelB.RoleClient.DisplayAllRoles();
            #endregion role
        }
        static void TestModelC()
        {
            //ShadowPropertyClient.Init();
            //ShadowPropertyClient.DisplayAllVillages();
            ShadowPropertyClient.Demo_AddNewPersonWithRole();
            ShadowPropertyClient.Demo_ChangePersonVillage();
            //ShadowPropertyClient.DisplayAllPeople();
            //ShadowPropertyClient.DisplayAllRoles();
            ShadowPropertyClient.DisplayAllRolesWithDOJ();
        }
        static void TestModelD()
        {
            //OwnedTypeClient.Init();
            //OwnedTypeClient.Demo_AddNewPersonWithAddress();
            OwnedTypeClient.Demo_AddNewPersonWithOutAddress();
            OwnedTypeClient.Demo_UpdatePersonAddress();
            //OwnedTypeClient.DisplayAllPeople();
        }
    }
}
