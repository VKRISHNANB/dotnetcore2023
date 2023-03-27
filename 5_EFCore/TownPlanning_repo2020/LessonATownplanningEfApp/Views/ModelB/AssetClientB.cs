using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TownplanningEfApp.ModelB;
namespace TownplanningEfApp.Views.ModelB
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
            TownPlanningContextB dbContext=new TownPlanningContextB();
            dbContext.Assets.Add(asset);
        }
        public static void Demo_AddManyAsset()
        {
            TownPlanningContextB dbContext=new TownPlanningContextB();
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