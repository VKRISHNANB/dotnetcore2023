using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TownplanningEfApp.ModelB
{
    public class Asset
    {
        public int AssetId{get;set;}
        public int PlotNo{get;set;}
        public String Type{get;set;}
        public String Description{get;set;}
        // Navigation Propert
        public Village Village{get;set;}
        [ForeignKey("Village")]
        public int VillageId{get;set;}
        // Many to Many
        // One Asset Many Owners - CIRCULAR Reference handled in DbContext
        // AssetDetails is Associated Type
        public List<AssetDetails> Owners{get;set;}
    }
}