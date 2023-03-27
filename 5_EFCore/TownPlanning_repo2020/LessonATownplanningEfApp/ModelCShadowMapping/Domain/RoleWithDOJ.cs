using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TownplanningEfApp.ModelC
{
    public class RoleWithDOJDate
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RoleId{get;set;}
        public string RoleTitle{get;set;}    
        /**
         * If the PersonId (FK Property) is set as a nullable type 
         * then the Role is vacant, and the Role can exist without a Person 
         **/            
        [ForeignKey("InChargePerson")]
        public int? PersonId{get;set;}
        // Navigation Properties
        public Person InChargePerson{get;set;}
        /** DateOfJoin is a Shadow Property */
        public DateTime? DateOfJoin{get;set;}

    }
}