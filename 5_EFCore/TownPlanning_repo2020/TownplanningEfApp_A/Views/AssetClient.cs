using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TownplanningEfApp.Models;
namespace TownplanningEfApp.Views
{
    public class AssetClient
    {
        public static void Demo_AddAnAsset()
        {
           Asset asset=new Asset
           {
               Description="2BFlat",
               PlotNo=123,
               Type="Home",
               VillageId=5
           };
            TownPlanningContext dbContext=new TownPlanningContext();
            dbContext.Assets.Add(asset);
        }
        public static void Demo_AddManyAsset()
        {
            TownPlanningContext dbContext=new TownPlanningContext();
            List<Asset> assetList=new List<Asset>();
            for(int i=200;i<225;i++)
            {
                Asset asset=new Asset
                {
                    Description="2BFlat",
                    PlotNo=i,
                    Type="Home",
                    VillageId=10
                };
                assetList.Add(asset);
            }
            dbContext.AddRange(assetList);
            dbContext.SaveChanges();
        }
    }
}