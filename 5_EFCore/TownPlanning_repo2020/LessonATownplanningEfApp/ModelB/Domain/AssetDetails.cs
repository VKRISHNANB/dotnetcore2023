using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TownplanningEfApp.ModelB
{
    public class AssetDetails
    {
        // Compound Keys - {PersonId, AssetID} - Defined in DbContext
        public int PersonId{get;set;}
        public int AssetID{get;set;}
        public float OwnershipShare{get;set;}
        // Navigation Properties
        // Many to Many - One Asset Many Owners, One Owner Many Assets
        // May cause Circular reference if Person has Navigation Property to AssetDetails
        // Circular Reference is Handled in DbContext
        public Person Owner{get;set;}
        // // May cause Circular reference if Asset has Navigation Property to AssetDetails
        public Asset Property{get;set;}
    }
}